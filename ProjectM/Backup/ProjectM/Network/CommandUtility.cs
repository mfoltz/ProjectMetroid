// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CommandUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Tiles;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Network
{
  public static class CommandUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_filter;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoCommand_Internal_Static_Void_byref_CommandInput_byref_CollisionWorld_byref_CommandOutput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoRotationAndAim_Internal_Static_Void_byref_EntityInput_byref_CommandRotationInput_byref_EntityAimData_byref_Rotation_byref_float3_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoMountedMovementAndRotation_Internal_Static_Void_byref_EntityInput_byref_ConstantCommandMountData_byref_InputCommandStateHistoryBufferElement_byref_Velocity_byref_Translation_byref_Rotation_CurveCollection_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoMovement_Internal_Static_Void_byref_InputCommandStateHistoryBufferElement_byref_InputCommandStateHistoryBufferElement_byref_CommandMovementInput_byref_Entity_byref_Velocity_byref_MoveVelocity_byref_Translation_byref_Rotation_CurveCollection_Single_Single_byref_CollisionWorld_byref_ComponentDataFromEntity_1_Translation_byref_ComponentDataFromEntity_1_Dead_byref_ComponentDataFromEntity_1_MoveStopTrigger_byref_ComponentDataFromEntity_1_EntityCategory_byref_ComponentDataFromEntity_1_DynamicCollision_byref_ComponentDataFromEntity_1_BuffableFlagState_byref_ComponentDataFromEntity_1_Team_NativeList_1_ColliderCastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveStop_Private_Static_Boolean_byref_CollisionWorld_byref_Entity_byref_float3_byref_float3_byref_quaternion_byref_MoveStopAbilityData_byref_ComponentDataFromEntity_1_Translation_byref_ComponentDataFromEntity_1_Dead_byref_ComponentDataFromEntity_1_MoveStopTrigger_byref_ComponentDataFromEntity_1_EntityCategory_byref_ComponentDataFromEntity_1_BuffableFlagState_byref_ComponentDataFromEntity_1_Team_NativeList_1_ColliderCastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResolveDynamicCollision_Internal_Static_Void_Entity_Single_byref_Translation_byref_CollisionDetection_byref_DynamicCollision_byref_CollisionRadius_ComponentDataFromEntity_1_CollisionRadius_ComponentDataFromEntity_1_DynamicCollision_ComponentDataFromEntity_1_PlayerCharacter_ComponentDataFromEntity_1_BuffableFlagState_Boolean_NativeList_1_CastResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_MapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_SnapshotMapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_TMapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1150637, RefRangeEnd = 1150639, XrefRangeStart = 1150464, XrefRangeEnd = 1150637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoCommand(
      ref CommandInput input,
      ref CollisionWorld collisionWorld,
      out CommandOutput output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_DoCommand_Internal_Static_Void_byref_CommandInput_byref_CollisionWorld_byref_CommandOutput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1150650, RefRangeEnd = 1150652, XrefRangeStart = 1150639, XrefRangeEnd = 1150650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoRotationAndAim(
      [In] ref EntityInput entityInput,
      [In] ref CommandRotationInput rotationInput,
      ref EntityAimData aimData,
      ref Rotation rotation,
      [In] ref float3 entityPosition,
      float deltaTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref entityInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotationInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aimData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_DoRotationAndAim_Internal_Static_Void_byref_EntityInput_byref_CommandRotationInput_byref_EntityAimData_byref_Rotation_byref_float3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1150683, RefRangeEnd = 1150684, XrefRangeStart = 1150652, XrefRangeEnd = 1150683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoMountedMovementAndRotation(
      [In] ref EntityInput entityInput,
      [In] ref ConstantCommandMountData constantMountData,
      [In] ref InputCommandStateHistoryBufferElement inputCommandState,
      ref ProjectM.Velocity velocity,
      ref Translation translation,
      ref Rotation rotation,
      CurveCollection curveCollection,
      float deltaTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref entityInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref constantMountData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_DoMountedMovementAndRotation_Internal_Static_Void_byref_EntityInput_byref_ConstantCommandMountData_byref_InputCommandStateHistoryBufferElement_byref_Velocity_byref_Translation_byref_Rotation_CurveCollection_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1150708, RefRangeEnd = 1150710, XrefRangeStart = 1150684, XrefRangeEnd = 1150708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoMovement(
      [In] ref InputCommandStateHistoryBufferElement inputCommandState,
      [In] ref InputCommandStateHistoryBufferElement latestInputCommandState,
      [In] ref CommandMovementInput movementInput,
      [In] ref Entity controlledEntity,
      ref ProjectM.Velocity velocity,
      ref MoveVelocity moveVelocity,
      ref Translation translation,
      [In] ref Rotation rotation,
      CurveCollection curveCollection,
      float timeSinceCast,
      float commandDeltaTime,
      ref CollisionWorld collisionWorld,
      ref ComponentDataFromEntity<Translation> getTranslation,
      ref ComponentDataFromEntity<Dead> getDead,
      ref ComponentDataFromEntity<MoveStopTrigger> getMoveStopTrigger,
      ref ComponentDataFromEntity<EntityCategory> getEntityCategory,
      ref ComponentDataFromEntity<DynamicCollision> getDynamicCollision,
      ref ComponentDataFromEntity<BuffableFlagState> getBuffableFlagState,
      ref ComponentDataFromEntity<Team> getTeam,
      NativeList<ColliderCastHit> moveStopHits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[20];
      numPtr[0] = (System.IntPtr) ref inputCommandState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref latestInputCommandState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref movementInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref controlledEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveVelocity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &timeSinceCast;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &commandDeltaTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) ref getTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) ref getDead;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(14) * sizeof (System.IntPtr))) = (System.IntPtr) ref getMoveStopTrigger;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(15) * sizeof (System.IntPtr))) = (System.IntPtr) ref getEntityCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(16) * sizeof (System.IntPtr))) = (System.IntPtr) ref getDynamicCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(17) * sizeof (System.IntPtr))) = (System.IntPtr) ref getBuffableFlagState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(18) * sizeof (System.IntPtr))) = (System.IntPtr) ref getTeam;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(19) * sizeof (System.IntPtr))) = (System.IntPtr) &moveStopHits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_DoMovement_Internal_Static_Void_byref_InputCommandStateHistoryBufferElement_byref_InputCommandStateHistoryBufferElement_byref_CommandMovementInput_byref_Entity_byref_Velocity_byref_MoveVelocity_byref_Translation_byref_Rotation_CurveCollection_Single_Single_byref_CollisionWorld_byref_ComponentDataFromEntity_1_Translation_byref_ComponentDataFromEntity_1_Dead_byref_ComponentDataFromEntity_1_MoveStopTrigger_byref_ComponentDataFromEntity_1_EntityCategory_byref_ComponentDataFromEntity_1_DynamicCollision_byref_ComponentDataFromEntity_1_BuffableFlagState_byref_ComponentDataFromEntity_1_Team_NativeList_1_ColliderCastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1150764, RefRangeEnd = 1150765, XrefRangeStart = 1150710, XrefRangeEnd = 1150764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool MoveStop(
      ref CollisionWorld collisionWorld,
      [In] ref Entity controlledEntity,
      [In] ref float3 position,
      [In] ref float3 newVelocity,
      [In] ref quaternion rotation,
      [In] ref MoveStopAbilityData moveStop,
      ref ComponentDataFromEntity<Translation> getTranslation,
      ref ComponentDataFromEntity<Dead> getDead,
      ref ComponentDataFromEntity<MoveStopTrigger> getMoveStopTrigger,
      ref ComponentDataFromEntity<EntityCategory> getEntityCategory,
      ref ComponentDataFromEntity<BuffableFlagState> getBuffableFlagState,
      ref ComponentDataFromEntity<Team> getTeam,
      NativeList<ColliderCastHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[13];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controlledEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref newVelocity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveStop;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref getTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref getDead;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref getMoveStopTrigger;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref getEntityCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref getBuffableFlagState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref getTeam;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &hits;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_MoveStop_Private_Static_Boolean_byref_CollisionWorld_byref_Entity_byref_float3_byref_float3_byref_quaternion_byref_MoveStopAbilityData_byref_ComponentDataFromEntity_1_Translation_byref_ComponentDataFromEntity_1_Dead_byref_ComponentDataFromEntity_1_MoveStopTrigger_byref_ComponentDataFromEntity_1_EntityCategory_byref_ComponentDataFromEntity_1_BuffableFlagState_byref_ComponentDataFromEntity_1_Team_NativeList_1_ColliderCastHit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1150814, RefRangeEnd = 1150816, XrefRangeStart = 1150765, XrefRangeEnd = 1150814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ResolveDynamicCollision(
      Entity entity,
      float deltaTime,
      ref Translation translation,
      ref CollisionDetection collisionDetection,
      [In] ref DynamicCollision dynamicCollision,
      [In] ref CollisionRadius collisionRadius,
      ComponentDataFromEntity<CollisionRadius> getCollisionRadius,
      ComponentDataFromEntity<DynamicCollision> getDynamicCollision,
      ComponentDataFromEntity<PlayerCharacter> getPlayerCharacter,
      ComponentDataFromEntity<BuffableFlagState> getBuffableFlagState,
      bool isPlayer,
      NativeList<CastResult> castResults)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionDetection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref dynamicCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &getCollisionRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &getDynamicCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &getPlayerCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &getBuffableFlagState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &isPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &castResults;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_ResolveDynamicCollision_Internal_Static_Void_Entity_Single_byref_Translation_byref_CollisionDetection_byref_DynamicCollision_byref_CollisionRadius_ComponentDataFromEntity_1_CollisionRadius_ComponentDataFromEntity_1_DynamicCollision_ComponentDataFromEntity_1_PlayerCharacter_ComponentDataFromEntity_1_BuffableFlagState_Boolean_NativeList_1_CastResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150816, XrefRangeEnd = 1150822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ResolveStaticCollision(
      ref Translation translation,
      ref LastTranslation lastTranslation,
      ref MapCollision mapCollision,
      ref TileMapCollisionMath.MapData mapData,
      byte heightLevel,
      MapCollisionFlags mapCollisionFlags,
      out bool insideBounds,
      WorldType worldType,
      Entity optionalCheckOwner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mapCollisionFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref insideBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalCheckOwner;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_MapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150822, XrefRangeEnd = 1150830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ResolveStaticCollision(
      ref Translation translation,
      ref LastTranslation lastTranslation,
      ref MapCollision mapCollision,
      ref TileMapCollisionMath.SnapshotMapData mapData,
      byte heightLevel,
      MapCollisionFlags mapCollisionFlags,
      out bool insideBounds,
      WorldType worldType,
      Entity optionalCheckOwner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mapCollisionFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref insideBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalCheckOwner;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_SnapshotMapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1150832, RefRangeEnd = 1150837, XrefRangeStart = 1150830, XrefRangeEnd = 1150832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ResolveStaticCollision<TMapData, TCollisionCheck>(
      ref Translation translation,
      ref LastTranslation lastTranslation,
      ref MapCollision mapCollision,
      ref TMapData mapData,
      byte heightLevel,
      MapCollisionFlags mapCollisionFlags,
      out bool insideBounds,
      WorldType worldType,
      Entity optionalCheckOwner)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[9];
      numPtr1[0] = (System.IntPtr) ref translation;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapData);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &mapCollisionFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref insideBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalCheckOwner;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.MethodInfoStoreGeneric_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_TMapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0<TMapData, TCollisionCheck>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TMapData local = ref mapData;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TMapData>(objectPointer, false, false);
      local = (TMapData) valueGeneric;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1150838, RefRangeEnd = 1150839, XrefRangeStart = 1150837, XrefRangeEnd = 1150838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1150840, RefRangeEnd = 1150841, XrefRangeStart = 1150839, XrefRangeEnd = 1150840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1150842, RefRangeEnd = 1150843, XrefRangeStart = 1150841, XrefRangeEnd = 1150842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1150844, RefRangeEnd = 1150845, XrefRangeStart = 1150843, XrefRangeEnd = 1150844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CommandUtility.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CommandUtility()
    {
      Il2CppClassPointerStore<CommandUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (CommandUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr);
      CommandUtility.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (filter));
      CommandUtility.NativeMethodInfoPtr_DoCommand_Internal_Static_Void_byref_CommandInput_byref_CollisionWorld_byref_CommandOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691302);
      CommandUtility.NativeMethodInfoPtr_DoRotationAndAim_Internal_Static_Void_byref_EntityInput_byref_CommandRotationInput_byref_EntityAimData_byref_Rotation_byref_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691303);
      CommandUtility.NativeMethodInfoPtr_DoMountedMovementAndRotation_Internal_Static_Void_byref_EntityInput_byref_ConstantCommandMountData_byref_InputCommandStateHistoryBufferElement_byref_Velocity_byref_Translation_byref_Rotation_CurveCollection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691304);
      CommandUtility.NativeMethodInfoPtr_DoMovement_Internal_Static_Void_byref_InputCommandStateHistoryBufferElement_byref_InputCommandStateHistoryBufferElement_byref_CommandMovementInput_byref_Entity_byref_Velocity_byref_MoveVelocity_byref_Translation_byref_Rotation_CurveCollection_Single_Single_byref_CollisionWorld_byref_ComponentDataFromEntity_1_Translation_byref_ComponentDataFromEntity_1_Dead_byref_ComponentDataFromEntity_1_MoveStopTrigger_byref_ComponentDataFromEntity_1_EntityCategory_byref_ComponentDataFromEntity_1_DynamicCollision_byref_ComponentDataFromEntity_1_BuffableFlagState_byref_ComponentDataFromEntity_1_Team_NativeList_1_ColliderCastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691305);
      CommandUtility.NativeMethodInfoPtr_MoveStop_Private_Static_Boolean_byref_CollisionWorld_byref_Entity_byref_float3_byref_float3_byref_quaternion_byref_MoveStopAbilityData_byref_ComponentDataFromEntity_1_Translation_byref_ComponentDataFromEntity_1_Dead_byref_ComponentDataFromEntity_1_MoveStopTrigger_byref_ComponentDataFromEntity_1_EntityCategory_byref_ComponentDataFromEntity_1_BuffableFlagState_byref_ComponentDataFromEntity_1_Team_NativeList_1_ColliderCastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691306);
      CommandUtility.NativeMethodInfoPtr_ResolveDynamicCollision_Internal_Static_Void_Entity_Single_byref_Translation_byref_CollisionDetection_byref_DynamicCollision_byref_CollisionRadius_ComponentDataFromEntity_1_CollisionRadius_ComponentDataFromEntity_1_DynamicCollision_ComponentDataFromEntity_1_PlayerCharacter_ComponentDataFromEntity_1_BuffableFlagState_Boolean_NativeList_1_CastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691307);
      CommandUtility.NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_MapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691308);
      CommandUtility.NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_SnapshotMapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691309);
      CommandUtility.NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_TMapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691310);
      CommandUtility.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691312);
      CommandUtility.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691313);
      CommandUtility.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691314);
      CommandUtility.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, 100691315);
    }

    public CommandUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CollisionFilter filter
    {
      get
      {
        CollisionFilter filter;
        IL2CPP.il2cpp_field_static_get_value(CommandUtility.NativeFieldInfoPtr_filter, (void*) &filter);
        return filter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CommandUtility.NativeFieldInfoPtr_filter, (void*) &value);
      }
    }

    public class RemoveOldInputCommands : SystemBase
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
      private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_60;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_0_Private_Void_byref_DynamicBuffer_1_InputCommandBufferElement_byref_InputCommandDataProxy_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149360, XrefRangeEnd = 1149364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149364, XrefRangeEnd = 1149367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnDestroy()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149367, XrefRangeEnd = 1149386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnUpdate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RemoveOldInputCommands()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3_0(
        ref DynamicBuffer<InputCommandBufferElement> inputCommandsBuffer,
        [In] ref InputCommandDataProxy inputCommandDataProxy)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref inputCommandsBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandDataProxy;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr__OnUpdate_b__3_0_Private_Void_byref_DynamicBuffer_1_InputCommandBufferElement_byref_InputCommandDataProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149386, XrefRangeEnd = 1149411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149433, RefRangeEnd = 1149434, XrefRangeStart = 1149411, XrefRangeEnd = 1149433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
        ComponentSystemBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149438, RefRangeEnd = 1149439, XrefRangeStart = 1149434, XrefRangeEnd = 1149438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RemoveOldInputCommands()
      {
        Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (RemoveOldInputCommands));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr);
        CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, nameof (_WorldFrame));
        CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
        CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
        CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientNetworkState_60));
        CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, 100691316);
        CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, 100691317);
        CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, 100691318);
        CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, 100691319);
        CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr__OnUpdate_b__3_0_Private_Void_byref_DynamicBuffer_1_InputCommandBufferElement_byref_InputCommandDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, 100691320);
        CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, 100691321);
        CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, 100691322);
        CommandUtility.RemoveOldInputCommands.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, 100691323);
      }

      public RemoveOldInputCommands(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SingletonAccessor<WorldFrame> _WorldFrame
      {
        get
        {
          return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr__WorldFrame));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
        }
      }

      public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
      {
        get
        {
          return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
        }
        [param: In] set
        {
          *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
        }
      }

      public unsafe EntityQuery _SingletonEntityQuery_ClientNetworkState_60
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_60));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.RemoveOldInputCommands.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_60)) = value;
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/RemoveOldInputCommands/<>c__DisplayClass_OnUpdate_LambdaJob0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass_OnUpdate_LambdaJob0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_InputCommandData_0;
        private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
        private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
        private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_byref_DynamicBuffer_1_InputCommandBufferElement_byref_InputCommandDataProxy_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveOldInputCommands_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
        [FieldOffset(0)]
        public ComponentDataFromEntity<InputCommandData> _ComponentDataFromEntity_InputCommandData_0;
        [FieldOffset(32)]
        public CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
        [FieldOffset(104)]
        public unsafe CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149319, XrefRangeEnd = 1149334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void OriginalLambdaBody(
          ref DynamicBuffer<InputCommandBufferElement> inputCommandsBuffer,
          [In] ref InputCommandDataProxy inputCommandDataProxy)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref inputCommandsBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandDataProxy;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_byref_DynamicBuffer_1_InputCommandBufferElement_byref_InputCommandDataProxy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149334, XrefRangeEnd = 1149336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Execute(
          ArchetypeChunk chunk,
          int chunkIndex,
          int firstEntityIndex)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1149344, RefRangeEnd = 1149345, XrefRangeStart = 1149336, XrefRangeEnd = 1149344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void IterateEntities(
          ref ArchetypeChunk chunk,
          ref CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1149349, RefRangeEnd = 1149350, XrefRangeStart = 1149345, XrefRangeEnd = 1149349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          CommandUtility.RemoveOldInputCommands componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveOldInputCommands_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149350, XrefRangeEnd = 1149354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void RunWithoutJobSystem(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149354, XrefRangeEnd = 1149360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass_OnUpdate_LambdaJob0()
        {
          Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_InputCommandData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_InputCommandData_0));
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_byref_DynamicBuffer_1_InputCommandBufferElement_byref_InputCommandDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691324);
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691325);
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691326);
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveOldInputCommands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691327);
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691328);
          CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691329);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LambdaParameterValueProviders
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inputCommandsBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inputCommandDataProxy;
          private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveOldInputCommands_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<InputCommandBufferElement> forParameter_inputCommandsBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<InputCommandDataProxy> forParameter_inputCommandDataProxy;

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149236, RefRangeEnd = 1149237, XrefRangeStart = 1149230, XrefRangeEnd = 1149236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe void ScheduleTimeInitialize(
            CommandUtility.RemoveOldInputCommands componentSystem)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveOldInputCommands_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149243, RefRangeEnd = 1149244, XrefRangeStart = 1149237, XrefRangeEnd = 1149243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
            ref ArchetypeChunk p0,
            int p1,
            int p2)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[3];
            numPtr[0] = (System.IntPtr) ref p0;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
          }

          static LambdaParameterValueProviders()
          {
            Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inputCommandsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inputCommandsBuffer));
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inputCommandDataProxy));
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveOldInputCommands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691330);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691331);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
          }

          [StructLayout(LayoutKind.Explicit)]
          public struct Runtimes
          {
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inputCommandsBuffer;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inputCommandDataProxy;
            [FieldOffset(0)]
            public LambdaParameterValueProvider_DynamicBuffer<InputCommandBufferElement>.Runtime runtime_inputCommandsBuffer;
            [FieldOffset(24)]
            public LambdaParameterValueProvider_IComponentData<InputCommandDataProxy>.Runtime runtime_inputCommandDataProxy;

            static Runtimes()
            {
              Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
              CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inputCommandsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inputCommandsBuffer));
              CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inputCommandDataProxy));
            }

            public Il2CppSystem.Object BoxIl2CppObject()
            {
              return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
            }
          }
        }

        [ObfuscatedName("ProjectM.Network.CommandUtility/RemoveOldInputCommands/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00006157$PostfixBurstDelegate")]
        public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
        {
          private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

          [CallerCount(5227)]
          [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData,
            Il2CppSystem.AsyncCallback _param3,
            Il2CppSystem.Object _param4)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[4];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
          }

          [CallerCount(3)]
          [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static MulticastDelegateNPublicSealedVoObObUnique()
          {
            Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00006157$PostfixBurstDelegate");
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691332);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691333);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691334);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691335);
          }

          public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }
        }

        [ObfuscatedName("ProjectM.Network.CommandUtility/RemoveOldInputCommands/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00006157$BurstDirectCall")]
        public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
          private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149244, XrefRangeEnd = 1149258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) ref _param0;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149258, XrefRangeEnd = 1149276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe System.IntPtr GetFunctionPointer()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149276, XrefRangeEnd = 1149291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Constructor()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(10560)]
          [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Initialize()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149318, RefRangeEnd = 1149319, XrefRangeStart = 1149291, XrefRangeEnd = 1149318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static ObjectNInternalAbstractSealedInPoDeInUnique()
          {
            Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00006157$BurstDirectCall");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691336);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691337);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691338);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691339);
            CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691341);
          }

          public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public new static unsafe System.IntPtr Pointer
          {
            get
            {
              System.IntPtr pointer;
              IL2CPP.il2cpp_field_static_get_value(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
              return pointer;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
            }
          }

          public static unsafe System.IntPtr DeferredCompilation
          {
            get
            {
              System.IntPtr deferredCompilation;
              IL2CPP.il2cpp_field_static_get_value(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
              return deferredCompilation;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(CommandUtility.RemoveOldInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
            }
          }
        }
      }
    }

    public class ClearInputCommands : SystemBase
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149545, XrefRangeEnd = 1149558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnUpdate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.ClearInputCommands.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ClearInputCommands()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149558, XrefRangeEnd = 1149591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.ClearInputCommands.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149591, XrefRangeEnd = 1149607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
        ComponentSystemBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149611, RefRangeEnd = 1149612, XrefRangeStart = 1149607, XrefRangeEnd = 1149611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ClearInputCommands()
      {
        Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (ClearInputCommands));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr);
        CommandUtility.ClearInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
        CommandUtility.ClearInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
        CommandUtility.ClearInputCommands.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, 100691342);
        CommandUtility.ClearInputCommands.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, 100691343);
        CommandUtility.ClearInputCommands.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, 100691344);
        CommandUtility.ClearInputCommands.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, 100691345);
        CommandUtility.ClearInputCommands.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, 100691346);
      }

      public ClearInputCommands(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.ClearInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.ClearInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
        }
      }

      public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
      {
        get
        {
          return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.ClearInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
        }
        [param: In] set
        {
          *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.ClearInputCommands.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/ClearInputCommands/<>c")]
      [Serializable]
      public sealed class __c : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr___9;
        private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_DynamicBuffer_1_InputCommandBufferElement_0;

        [CallerCount(3875)]
        [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe __c()
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c>.NativeClassPtr))
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void _OnUpdate_b__0_0(
          ref DynamicBuffer<InputCommandBufferElement> inputCommandsBuffer)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref inputCommandsBuffer;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_DynamicBuffer_1_InputCommandBufferElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c()
        {
          Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, "<>c");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c>.NativeClassPtr);
          CommandUtility.ClearInputCommands.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c>.NativeClassPtr, "<>9");
          CommandUtility.ClearInputCommands.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c>.NativeClassPtr, "<>9__0_0");
          CommandUtility.ClearInputCommands.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c>.NativeClassPtr, 100691348);
          CommandUtility.ClearInputCommands.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_DynamicBuffer_1_InputCommandBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c>.NativeClassPtr, 100691349);
        }

        public __c(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public static unsafe CommandUtility.ClearInputCommands.__c __9
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.ClearInputCommands.__c.NativeFieldInfoPtr___9, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (CommandUtility.ClearInputCommands.__c) null : new CommandUtility.ClearInputCommands.__c(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.ClearInputCommands.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public static unsafe R<DynamicBuffer<InputCommandBufferElement>> __9__0_0
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.ClearInputCommands.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (R<DynamicBuffer<InputCommandBufferElement>>) null : new R<DynamicBuffer<InputCommandBufferElement>>(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.ClearInputCommands.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/ClearInputCommands/<>c__DisplayClass_OnUpdate_LambdaJob0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass_OnUpdate_LambdaJob0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
        private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
        private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandBufferElement_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClearInputCommands_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
        [FieldOffset(0)]
        public CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
        [FieldOffset(40)]
        public unsafe CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149522, XrefRangeEnd = 1149525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void OriginalLambdaBody(
          ref DynamicBuffer<InputCommandBufferElement> inputCommandsBuffer)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref inputCommandsBuffer;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandBufferElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149525, XrefRangeEnd = 1149527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Execute(
          ArchetypeChunk chunk,
          int chunkIndex,
          int firstEntityIndex)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1149532, RefRangeEnd = 1149533, XrefRangeStart = 1149527, XrefRangeEnd = 1149532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void IterateEntities(
          ref ArchetypeChunk chunk,
          ref CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1149534, RefRangeEnd = 1149535, XrefRangeStart = 1149533, XrefRangeEnd = 1149534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CommandUtility.ClearInputCommands componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClearInputCommands_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149535, XrefRangeEnd = 1149539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void RunWithoutJobSystem(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149539, XrefRangeEnd = 1149545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass_OnUpdate_LambdaJob0()
        {
          Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.ClearInputCommands>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691350);
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691351);
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691352);
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClearInputCommands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691353);
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691354);
          CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691355);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LambdaParameterValueProviders
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inputCommandsBuffer;
          private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClearInputCommands_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<InputCommandBufferElement> forParameter_inputCommandsBuffer;

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149442, RefRangeEnd = 1149443, XrefRangeStart = 1149439, XrefRangeEnd = 1149442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe void ScheduleTimeInitialize(
            CommandUtility.ClearInputCommands componentSystem)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClearInputCommands_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149446, RefRangeEnd = 1149447, XrefRangeStart = 1149443, XrefRangeEnd = 1149446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
            ref ArchetypeChunk p0,
            int p1,
            int p2)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[3];
            numPtr[0] = (System.IntPtr) ref p0;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
          }

          static LambdaParameterValueProviders()
          {
            Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inputCommandsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inputCommandsBuffer));
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClearInputCommands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691356);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691357);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
          }

          [StructLayout(LayoutKind.Explicit)]
          public struct Runtimes
          {
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inputCommandsBuffer;
            [FieldOffset(0)]
            public LambdaParameterValueProvider_DynamicBuffer<InputCommandBufferElement>.Runtime runtime_inputCommandsBuffer;

            static Runtimes()
            {
              Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
              CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inputCommandsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inputCommandsBuffer));
            }

            public Il2CppSystem.Object BoxIl2CppObject()
            {
              return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
            }
          }
        }

        [ObfuscatedName("ProjectM.Network.CommandUtility/ClearInputCommands/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00006165$PostfixBurstDelegate")]
        public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
        {
          private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

          [CallerCount(5227)]
          [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData,
            Il2CppSystem.AsyncCallback _param3,
            Il2CppSystem.Object _param4)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[4];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
          }

          [CallerCount(3)]
          [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static MulticastDelegateNPublicSealedVoObObUnique()
          {
            Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00006165$PostfixBurstDelegate");
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691358);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691359);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691360);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691361);
          }

          public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }
        }

        [ObfuscatedName("ProjectM.Network.CommandUtility/ClearInputCommands/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00006165$BurstDirectCall")]
        public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
          private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149447, XrefRangeEnd = 1149461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) ref _param0;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149461, XrefRangeEnd = 1149479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe System.IntPtr GetFunctionPointer()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149479, XrefRangeEnd = 1149494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Constructor()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(10560)]
          [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Initialize()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149521, RefRangeEnd = 1149522, XrefRangeStart = 1149494, XrefRangeEnd = 1149521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static ObjectNInternalAbstractSealedInPoDeInUnique()
          {
            Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00006165$BurstDirectCall");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691362);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691363);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691364);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691365);
            CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691367);
          }

          public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public new static unsafe System.IntPtr Pointer
          {
            get
            {
              System.IntPtr pointer;
              IL2CPP.il2cpp_field_static_get_value(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
              return pointer;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
            }
          }

          public static unsafe System.IntPtr DeferredCompilation
          {
            get
            {
              System.IntPtr deferredCompilation;
              IL2CPP.il2cpp_field_static_get_value(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
              return deferredCompilation;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(CommandUtility.ClearInputCommands.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
            }
          }
        }
      }
    }

    public class InputCommandStateHistorySystem_Server : 
      CommandUtility.InputCommandStateHistorySystem_Base
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InputCommandStateHistorySystem_Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149612, XrefRangeEnd = 1149613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandStateHistorySystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InputCommandStateHistorySystem_Server()
      {
        Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (InputCommandStateHistorySystem_Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Server>.NativeClassPtr);
        CommandUtility.InputCommandStateHistorySystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Server>.NativeClassPtr, 100691368);
        CommandUtility.InputCommandStateHistorySystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Server>.NativeClassPtr, 100691369);
      }

      public InputCommandStateHistorySystem_Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class InputCommandStateHistorySystem_Client : 
      CommandUtility.InputCommandStateHistorySystem_Base
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InputCommandStateHistorySystem_Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Client>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandStateHistorySystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InputCommandStateHistorySystem_Client()
      {
        Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (InputCommandStateHistorySystem_Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Client>.NativeClassPtr);
        CommandUtility.InputCommandStateHistorySystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Client>.NativeClassPtr, 100691370);
        CommandUtility.InputCommandStateHistorySystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Client>.NativeClassPtr, 100691371);
      }

      public InputCommandStateHistorySystem_Client(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class InputCommandStateHistorySystem_Base : SystemBase
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149816, XrefRangeEnd = 1149820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149820, XrefRangeEnd = 1149839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnUpdate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InputCommandStateHistorySystem_Base()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1149857, RefRangeEnd = 1149859, XrefRangeStart = 1149839, XrefRangeEnd = 1149857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149887, RefRangeEnd = 1149888, XrefRangeStart = 1149859, XrefRangeEnd = 1149887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
        ComponentSystemBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1149892, RefRangeEnd = 1149893, XrefRangeStart = 1149888, XrefRangeEnd = 1149892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InputCommandStateHistorySystem_Base()
      {
        Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (InputCommandStateHistorySystem_Base));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr);
        CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, nameof (_WorldFrame));
        CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
        CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
        CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, 100691372);
        CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, 100691373);
        CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, 100691374);
        CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, 100691375);
        CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, 100691376);
        CommandUtility.InputCommandStateHistorySystem_Base.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, 100691377);
      }

      public InputCommandStateHistorySystem_Base(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SingletonAccessor<WorldFrame> _WorldFrame
      {
        get
        {
          return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr__WorldFrame));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
        }
      }

      public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
      {
        get
        {
          return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
        }
        [param: In] set
        {
          *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/InputCommandStateHistorySystem_Base/<>c__DisplayClass2_0")]
      public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
        private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0;

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe __c__DisplayClass2_0()
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr))
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void _OnUpdate_b__0(
          ref DynamicBuffer<InputCommandStateHistoryBufferElement> inputCommandStateHistoryBuffer,
          [In] ref Controller controller)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref inputCommandStateHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass2_0()
        {
          Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, "<>c__DisplayClass2_0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr, nameof (currentFrame));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr, 100691378);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr, 100691379);
        }

        public __c__DisplayClass2_0(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public __c__DisplayClass2_0()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0>.NativeClassPtr, data));
        }

        public unsafe CommandUtility.InputCommandStateHistorySystem_Base __4__this
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
            return pointer == System.IntPtr.Zero ? (CommandUtility.InputCommandStateHistorySystem_Base) null : new CommandUtility.InputCommandStateHistorySystem_Base(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe int currentFrame
        {
          get
          {
            return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeFieldInfoPtr_currentFrame));
          }
          [param: In] set
          {
            *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0.NativeFieldInfoPtr_currentFrame)) = value;
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/InputCommandStateHistorySystem_Base/<>c__DisplayClass_OnUpdate_LambdaJob0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass_OnUpdate_LambdaJob0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Movement_0;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_1;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MapCollision_2;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Mounter_3;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_4;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_5;
        private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
        private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
        private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandStateHistorySystem_Base_byref___c__DisplayClass2_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
        [FieldOffset(0)]
        public int currentFrame;
        [FieldOffset(8)]
        public ComponentDataFromEntity<Movement> _ComponentDataFromEntity_Movement_0;
        [FieldOffset(40)]
        public ComponentDataFromEntity<BuffableFlagState> _ComponentDataFromEntity_BuffableFlagState_1;
        [FieldOffset(72)]
        public ComponentDataFromEntity<MapCollision> _ComponentDataFromEntity_MapCollision_2;
        [FieldOffset(104)]
        public ComponentDataFromEntity<Mounter> _ComponentDataFromEntity_Mounter_3;
        [FieldOffset(136)]
        public ComponentDataFromEntity<TargetDirection> _ComponentDataFromEntity_TargetDirection_4;
        [FieldOffset(168)]
        public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_5;
        [FieldOffset(200)]
        public CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
        [FieldOffset(272)]
        public unsafe CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149702, XrefRangeEnd = 1149759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void OriginalLambdaBody(
          ref DynamicBuffer<InputCommandStateHistoryBufferElement> inputCommandStateHistoryBuffer,
          [In] ref Controller controller)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref inputCommandStateHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(8)]
        [CachedScanResults(RefRangeStart = 1149759, RefRangeEnd = 1149767, XrefRangeStart = 1149759, XrefRangeEnd = 1149759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void ReadFromDisplayClass(
          ref CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(7)]
        [CachedScanResults(RefRangeStart = 1149767, RefRangeEnd = 1149774, XrefRangeStart = 1149767, XrefRangeEnd = 1149767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void WriteToDisplayClass(
          ref CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149774, XrefRangeEnd = 1149776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Execute(
          ArchetypeChunk chunk,
          int chunkIndex,
          int firstEntityIndex)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1149784, RefRangeEnd = 1149785, XrefRangeStart = 1149776, XrefRangeEnd = 1149784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void IterateEntities(
          ref ArchetypeChunk chunk,
          ref CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1149805, RefRangeEnd = 1149806, XrefRangeStart = 1149785, XrefRangeEnd = 1149805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          CommandUtility.InputCommandStateHistorySystem_Base componentSystem,
          ref CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass2_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandStateHistorySystem_Base_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149806, XrefRangeEnd = 1149810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void RunWithoutJobSystem(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149810, XrefRangeEnd = 1149816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass_OnUpdate_LambdaJob0()
        {
          Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (currentFrame));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Movement_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Movement_0));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_BuffableFlagState_1));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_MapCollision_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_MapCollision_2));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Mounter_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Mounter_3));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_TargetDirection_4));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_5));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691380);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691381);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691382);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691383);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691384);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandStateHistorySystem_Base_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691385);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691386);
          CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691387);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LambdaParameterValueProviders
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inputCommandStateHistoryBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
          private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandStateHistorySystem_Base_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<InputCommandStateHistoryBufferElement> forParameter_inputCommandStateHistoryBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149619, RefRangeEnd = 1149620, XrefRangeStart = 1149613, XrefRangeEnd = 1149619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe void ScheduleTimeInitialize(
            CommandUtility.InputCommandStateHistorySystem_Base componentSystem)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandStateHistorySystem_Base_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149626, RefRangeEnd = 1149627, XrefRangeStart = 1149620, XrefRangeEnd = 1149626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
            ref ArchetypeChunk p0,
            int p1,
            int p2)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[3];
            numPtr[0] = (System.IntPtr) ref p0;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
          }

          static LambdaParameterValueProviders()
          {
            Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inputCommandStateHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inputCommandStateHistoryBuffer));
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandStateHistorySystem_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691388);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691389);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
          }

          [StructLayout(LayoutKind.Explicit)]
          public struct Runtimes
          {
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inputCommandStateHistoryBuffer;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
            [FieldOffset(0)]
            public LambdaParameterValueProvider_DynamicBuffer<InputCommandStateHistoryBufferElement>.Runtime runtime_inputCommandStateHistoryBuffer;
            [FieldOffset(24)]
            public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;

            static Runtimes()
            {
              Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
              CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inputCommandStateHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inputCommandStateHistoryBuffer));
              CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
            }

            public Il2CppSystem.Object BoxIl2CppObject()
            {
              return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
            }
          }
        }

        [ObfuscatedName("ProjectM.Network.CommandUtility/InputCommandStateHistorySystem_Base/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00006179$PostfixBurstDelegate")]
        public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
        {
          private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

          [CallerCount(5227)]
          [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData,
            Il2CppSystem.AsyncCallback _param3,
            Il2CppSystem.Object _param4)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[4];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
          }

          [CallerCount(3)]
          [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static MulticastDelegateNPublicSealedVoObObUnique()
          {
            Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00006179$PostfixBurstDelegate");
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691390);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691391);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691392);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691393);
          }

          public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }
        }

        [ObfuscatedName("ProjectM.Network.CommandUtility/InputCommandStateHistorySystem_Base/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00006179$BurstDirectCall")]
        public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
          private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149627, XrefRangeEnd = 1149641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) ref _param0;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149641, XrefRangeEnd = 1149659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe System.IntPtr GetFunctionPointer()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149659, XrefRangeEnd = 1149674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Constructor()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(10560)]
          [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Initialize()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149701, RefRangeEnd = 1149702, XrefRangeStart = 1149674, XrefRangeEnd = 1149701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static ObjectNInternalAbstractSealedInPoDeInUnique()
          {
            Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00006179$BurstDirectCall");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691394);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691395);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691396);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691397);
            CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691399);
          }

          public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public new static unsafe System.IntPtr Pointer
          {
            get
            {
              System.IntPtr pointer;
              IL2CPP.il2cpp_field_static_get_value(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
              return pointer;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
            }
          }

          public static unsafe System.IntPtr DeferredCompilation
          {
            get
            {
              System.IntPtr deferredCompilation;
              IL2CPP.il2cpp_field_static_get_value(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
              return deferredCompilation;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(CommandUtility.InputCommandStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
            }
          }
        }
      }
    }

    public class InputCommandAbilityStateHistorySystem_Server : 
      CommandUtility.InputCommandAbilityStateHistorySystem_Base
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InputCommandAbilityStateHistorySystem_Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149893, XrefRangeEnd = 1149894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandAbilityStateHistorySystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InputCommandAbilityStateHistorySystem_Server()
      {
        Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (InputCommandAbilityStateHistorySystem_Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Server>.NativeClassPtr);
        CommandUtility.InputCommandAbilityStateHistorySystem_Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Server>.NativeClassPtr, 100691400);
        CommandUtility.InputCommandAbilityStateHistorySystem_Server.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Server>.NativeClassPtr, 100691401);
      }

      public InputCommandAbilityStateHistorySystem_Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class InputCommandAbilityStateHistorySystem_Client : 
      CommandUtility.InputCommandAbilityStateHistorySystem_Base
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InputCommandAbilityStateHistorySystem_Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Client>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandAbilityStateHistorySystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InputCommandAbilityStateHistorySystem_Client()
      {
        Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (InputCommandAbilityStateHistorySystem_Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Client>.NativeClassPtr);
        CommandUtility.InputCommandAbilityStateHistorySystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Client>.NativeClassPtr, 100691402);
        CommandUtility.InputCommandAbilityStateHistorySystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Client>.NativeClassPtr, 100691403);
      }

      public InputCommandAbilityStateHistorySystem_Client(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class InputCommandAbilityStateHistorySystem_Base : SystemBase
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__IsServer;
      private static readonly System.IntPtr NativeFieldInfoPtr__Query;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
      private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_WorldFrame_61;
      private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_62;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150047, XrefRangeEnd = 1150056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150056, XrefRangeEnd = 1150079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnUpdate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InputCommandAbilityStateHistorySystem_Base()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1150110, RefRangeEnd = 1150112, XrefRangeStart = 1150079, XrefRangeEnd = 1150110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1150140, RefRangeEnd = 1150141, XrefRangeStart = 1150112, XrefRangeEnd = 1150140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
        ComponentSystemBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1150145, RefRangeEnd = 1150146, XrefRangeStart = 1150141, XrefRangeEnd = 1150145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InputCommandAbilityStateHistorySystem_Base()
      {
        Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (InputCommandAbilityStateHistorySystem_Base));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr);
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, nameof (_IsServer));
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, nameof (_Query));
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__SingletonEntityQuery_WorldFrame_61 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, nameof (_SingletonEntityQuery_WorldFrame_61));
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_62 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_62));
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, 100691404);
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, 100691405);
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, 100691406);
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, 100691407);
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, 100691408);
        CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, 100691409);
      }

      public InputCommandAbilityStateHistorySystem_Base(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe bool _IsServer
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__IsServer));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__IsServer)) = value;
        }
      }

      public unsafe EntityQuery _Query
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__Query));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__Query)) = value;
        }
      }

      public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
        }
      }

      public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
      {
        get
        {
          return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
        }
        [param: In] set
        {
          *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
        }
      }

      public unsafe EntityQuery _SingletonEntityQuery_WorldFrame_61
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__SingletonEntityQuery_WorldFrame_61));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__SingletonEntityQuery_WorldFrame_61)) = value;
        }
      }

      public unsafe EntityQuery _SingletonEntityQuery_ServerTime_62
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_62));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_62)) = value;
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/InputCommandAbilityStateHistorySystem_Base/<>c__DisplayClass3_0")]
      public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
        private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
        private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
        private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0;

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe __c__DisplayClass3_0()
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr))
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void _OnUpdate_b__0(
          ref DynamicBuffer<InputCommandStateHistoryBufferElement> inputCommandStateHistoryBuffer,
          [In] ref Controller controller)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref inputCommandStateHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass3_0()
        {
          Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, "<>c__DisplayClass3_0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, nameof (entityManager));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, nameof (isServer));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, nameof (serverTime));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, nameof (currentFrame));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, 100691410);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, 100691411);
        }

        public __c__DisplayClass3_0(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public __c__DisplayClass3_0()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0>.NativeClassPtr, data));
        }

        public unsafe EntityManager entityManager
        {
          get
          {
            return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager));
          }
          [param: In] set
          {
            *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager)) = value;
          }
        }

        public unsafe bool isServer
        {
          get
          {
            return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_isServer));
          }
          [param: In] set
          {
            *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_isServer)) = value;
          }
        }

        public unsafe double serverTime
        {
          get
          {
            return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_serverTime));
          }
          [param: In] set
          {
            *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_serverTime)) = value;
          }
        }

        public unsafe int currentFrame
        {
          get
          {
            return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_currentFrame));
          }
          [param: In] set
          {
            *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr_currentFrame)) = value;
          }
        }

        public unsafe CommandUtility.InputCommandAbilityStateHistorySystem_Base __4__this
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
            return pointer == System.IntPtr.Zero ? (CommandUtility.InputCommandAbilityStateHistorySystem_Base) null : new CommandUtility.InputCommandAbilityStateHistorySystem_Base(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/InputCommandAbilityStateHistorySystem_Base/<>c__DisplayClass_OnUpdate_LambdaJob0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass_OnUpdate_LambdaJob0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
        private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
        private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Movement_0;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_IsSpellControlled_1;
        private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
        private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
        private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandAbilityStateHistorySystem_Base_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
        [FieldOffset(0)]
        public EntityManager entityManager;
        [FieldOffset(8)]
        public bool isServer;
        [FieldOffset(16)]
        public double serverTime;
        [FieldOffset(24)]
        public int currentFrame;
        [FieldOffset(32)]
        public ComponentDataFromEntity<Movement> _ComponentDataFromEntity_Movement_0;
        [FieldOffset(64)]
        public ComponentDataFromEntity<IsSpellControlled> _ComponentDataFromEntity_IsSpellControlled_1;
        [FieldOffset(96)]
        public CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
        [FieldOffset(168)]
        public unsafe CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149983, XrefRangeEnd = 1150015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void OriginalLambdaBody(
          ref DynamicBuffer<InputCommandStateHistoryBufferElement> inputCommandStateHistoryBuffer,
          [In] ref Controller controller)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref inputCommandStateHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1150015, RefRangeEnd = 1150016, XrefRangeStart = 1150015, XrefRangeEnd = 1150015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void ReadFromDisplayClass(
          ref CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1150016, RefRangeEnd = 1150017, XrefRangeStart = 1150016, XrefRangeEnd = 1150016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void WriteToDisplayClass(
          ref CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150017, XrefRangeEnd = 1150019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Execute(
          ArchetypeChunk chunk,
          int chunkIndex,
          int firstEntityIndex)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1150027, RefRangeEnd = 1150028, XrefRangeStart = 1150019, XrefRangeEnd = 1150027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void IterateEntities(
          ref ArchetypeChunk chunk,
          ref CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1150036, RefRangeEnd = 1150037, XrefRangeStart = 1150028, XrefRangeEnd = 1150036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          CommandUtility.InputCommandAbilityStateHistorySystem_Base componentSystem,
          ref CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandAbilityStateHistorySystem_Base_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150037, XrefRangeEnd = 1150041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void RunWithoutJobSystem(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150041, XrefRangeEnd = 1150047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass_OnUpdate_LambdaJob0()
        {
          Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (isServer));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (serverTime));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (currentFrame));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Movement_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Movement_0));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_IsSpellControlled_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_IsSpellControlled_1));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_InputCommandStateHistoryBufferElement_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691412);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691413);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691414);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691415);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691416);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandAbilityStateHistorySystem_Base_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691417);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691418);
          CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691419);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LambdaParameterValueProviders
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inputCommandStateHistoryBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
          private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandAbilityStateHistorySystem_Base_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<InputCommandStateHistoryBufferElement> forParameter_inputCommandStateHistoryBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149900, RefRangeEnd = 1149901, XrefRangeStart = 1149894, XrefRangeEnd = 1149900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe void ScheduleTimeInitialize(
            CommandUtility.InputCommandAbilityStateHistorySystem_Base componentSystem)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandAbilityStateHistorySystem_Base_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149907, RefRangeEnd = 1149908, XrefRangeStart = 1149901, XrefRangeEnd = 1149907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
            ref ArchetypeChunk p0,
            int p1,
            int p2)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[3];
            numPtr[0] = (System.IntPtr) ref p0;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
          }

          static LambdaParameterValueProviders()
          {
            Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inputCommandStateHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inputCommandStateHistoryBuffer));
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InputCommandAbilityStateHistorySystem_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691420);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691421);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
          }

          [StructLayout(LayoutKind.Explicit)]
          public struct Runtimes
          {
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inputCommandStateHistoryBuffer;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
            [FieldOffset(0)]
            public LambdaParameterValueProvider_DynamicBuffer<InputCommandStateHistoryBufferElement>.Runtime runtime_inputCommandStateHistoryBuffer;
            [FieldOffset(24)]
            public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;

            static Runtimes()
            {
              Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
              CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inputCommandStateHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inputCommandStateHistoryBuffer));
              CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
            }

            public Il2CppSystem.Object BoxIl2CppObject()
            {
              return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
            }
          }
        }

        [ObfuscatedName("ProjectM.Network.CommandUtility/InputCommandAbilityStateHistorySystem_Base/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_0000618D$PostfixBurstDelegate")]
        public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
        {
          private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

          [CallerCount(5227)]
          [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData,
            Il2CppSystem.AsyncCallback _param3,
            Il2CppSystem.Object _param4)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[4];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
          }

          [CallerCount(3)]
          [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static MulticastDelegateNPublicSealedVoObObUnique()
          {
            Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000618D$PostfixBurstDelegate");
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691422);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691423);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691424);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691425);
          }

          public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }
        }

        [ObfuscatedName("ProjectM.Network.CommandUtility/InputCommandAbilityStateHistorySystem_Base/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_0000618D$BurstDirectCall")]
        public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
          private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149908, XrefRangeEnd = 1149922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) ref _param0;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149922, XrefRangeEnd = 1149940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe System.IntPtr GetFunctionPointer()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149940, XrefRangeEnd = 1149955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Constructor()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(10560)]
          [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Initialize()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1149982, RefRangeEnd = 1149983, XrefRangeStart = 1149955, XrefRangeEnd = 1149982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static ObjectNInternalAbstractSealedInPoDeInUnique()
          {
            Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000618D$BurstDirectCall");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691426);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691427);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691428);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691429);
            CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691431);
          }

          public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public new static unsafe System.IntPtr Pointer
          {
            get
            {
              System.IntPtr pointer;
              IL2CPP.il2cpp_field_static_get_value(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
              return pointer;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
            }
          }

          public static unsafe System.IntPtr DeferredCompilation
          {
            get
            {
              System.IntPtr deferredCompilation;
              IL2CPP.il2cpp_field_static_get_value(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
              return deferredCompilation;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(CommandUtility.InputCommandAbilityStateHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
            }
          }
        }
      }
    }

    public class TileCollisionHistorySystem_Base : SystemBase
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
      private static readonly System.IntPtr NativeFieldInfoPtr__IsServer;
      private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr__UsersInCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150367, XrefRangeEnd = 1150391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150391, XrefRangeEnd = 1150398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnDestroy()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150398, XrefRangeEnd = 1150418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnUpdate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileCollisionHistorySystem_Base()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150418, XrefRangeEnd = 1150420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1150463, RefRangeEnd = 1150464, XrefRangeStart = 1150420, XrefRangeEnd = 1150463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
        ComponentSystemBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TileCollisionHistorySystem_Base()
      {
        Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility>.NativeClassPtr, nameof (TileCollisionHistorySystem_Base));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr);
        CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, nameof (_TileWorldSystem));
        CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
        CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, nameof (_TilePolygons));
        CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, nameof (_IsServer));
        CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, nameof (_WorldFrame));
        CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__UsersInCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, nameof (_UsersInCollision));
        CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
        CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, 100691432);
        CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, 100691433);
        CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, 100691434);
        CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, 100691435);
        CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, 100691436);
        CommandUtility.TileCollisionHistorySystem_Base.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, 100691437);
      }

      public TileCollisionHistorySystem_Base(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe TileWorldSystem _TileWorldSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TileWorldSystem));
          return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TileModelSpatialLookupMap));
          return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
      {
        get
        {
          return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TilePolygons));
        }
        [param: In] set
        {
          *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__TilePolygons)) = value;
        }
      }

      public unsafe bool _IsServer
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__IsServer));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__IsServer)) = value;
        }
      }

      public unsafe SingletonAccessor<WorldFrame> _WorldFrame
      {
        get
        {
          return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__WorldFrame));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision> _UsersInCollision
      {
        get
        {
          return *(NativeArray<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__UsersInCollision));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr__UsersInCollision), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct UserInCollision
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_TileBounds;
        private static readonly System.IntPtr NativeFieldInfoPtr_InCollision;
        [FieldOffset(0)]
        public BoundsMinMax TileBounds;
        [FieldOffset(16)]
        public bool InCollision;

        static UserInCollision()
        {
          Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, nameof (UserInCollision));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>.NativeClassPtr);
          CommandUtility.TileCollisionHistorySystem_Base.UserInCollision.NativeFieldInfoPtr_TileBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>.NativeClassPtr, nameof (TileBounds));
          CommandUtility.TileCollisionHistorySystem_Base.UserInCollision.NativeFieldInfoPtr_InCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>.NativeClassPtr, nameof (InCollision));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/TileCollisionHistorySystem_Base/<>c__DisplayClass9_0")]
      public sealed class __c__DisplayClass9_0 : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
        private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
        private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
        private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
        private static readonly System.IntPtr NativeFieldInfoPtr_tilePolygons;
        private static readonly System.IntPtr NativeFieldInfoPtr_usersInCollision;
        private static readonly System.IntPtr NativeFieldInfoPtr_spatialLookup;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileGameplayHeightsHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_DynamicBuffer_1_TileDisabledCollisionHistoryElement_byref_Translation_byref_Controller_byref_InputCommandDataProxy_0;

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe __c__DisplayClass9_0()
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr))
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void _OnUpdate_b__0(
          Entity entity,
          ref DynamicBuffer<TileCollisionHistoryElement> tileCollisionHistoryBuffer,
          ref DynamicBuffer<TileGameplayHeightsHistoryElement> tileGameplayHeightsHistoryBuffer,
          ref DynamicBuffer<TileCollisionHistoryMetadataElement> tileCollisionHistoryMetadataBuffer,
          ref DynamicBuffer<TileDisabledCollisionHistoryElement> tileDisabledCollisionHistoryBuffer,
          [In] ref Translation translationDO_NOT_USE,
          [In] ref Controller controller,
          [In] ref InputCommandDataProxy inputCommandDataProxy)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[8];
          numPtr[0] = (System.IntPtr) &entity;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileGameplayHeightsHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionHistoryMetadataBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileDisabledCollisionHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref translationDO_NOT_USE;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandDataProxy;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileGameplayHeightsHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_DynamicBuffer_1_TileDisabledCollisionHistoryElement_byref_Translation_byref_Controller_byref_InputCommandDataProxy_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass9_0()
        {
          Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, "<>c__DisplayClass9_0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr);
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, nameof (isServer));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, nameof (currentFrame));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, nameof (tileWorld));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_tilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, nameof (tilePolygons));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_usersInCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, nameof (usersInCollision));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_spatialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, nameof (spatialLookup));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, 100691438);
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileGameplayHeightsHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_DynamicBuffer_1_TileDisabledCollisionHistoryElement_byref_Translation_byref_Controller_byref_InputCommandDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, 100691439);
        }

        public __c__DisplayClass9_0(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public __c__DisplayClass9_0()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0>.NativeClassPtr, data));
        }

        public unsafe bool isServer
        {
          get
          {
            return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_isServer));
          }
          [param: In] set
          {
            *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_isServer)) = value;
          }
        }

        public unsafe CommandUtility.TileCollisionHistorySystem_Base __4__this
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
            return pointer == System.IntPtr.Zero ? (CommandUtility.TileCollisionHistorySystem_Base) null : new CommandUtility.TileCollisionHistorySystem_Base(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe int currentFrame
        {
          get
          {
            return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_currentFrame));
          }
          [param: In] set
          {
            *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_currentFrame)) = value;
          }
        }

        public unsafe TileWorld tileWorld
        {
          get
          {
            return *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_tileWorld));
          }
          [param: In] set
          {
            *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_tileWorld)) = value;
          }
        }

        public unsafe TileMapCollisionMath.TilePolygons tilePolygons
        {
          get
          {
            return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_tilePolygons));
          }
          [param: In] set
          {
            *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_tilePolygons)) = value;
          }
        }

        public unsafe NativeArray<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision> usersInCollision
        {
          get
          {
            return *(NativeArray<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_usersInCollision));
          }
          [param: In] set
          {
            __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_usersInCollision), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          }
        }

        public unsafe SpatialLookupParams spatialLookup
        {
          get
          {
            return *(SpatialLookupParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_spatialLookup));
          }
          [param: In] set
          {
            *(SpatialLookupParams*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0.NativeFieldInfoPtr_spatialLookup)) = value;
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.CommandUtility/TileCollisionHistorySystem_Base/<>c__DisplayClass_OnUpdate_LambdaJob0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass_OnUpdate_LambdaJob0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
        private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
        private static readonly System.IntPtr NativeFieldInfoPtr_tilePolygons;
        private static readonly System.IntPtr NativeFieldInfoPtr_usersInCollision;
        private static readonly System.IntPtr NativeFieldInfoPtr_spatialLookup;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_InputCommandState_0;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_IsSpellControlled_1;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MapCollision_2;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ConnectedUser_3;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TilePosition_4;
        private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TileData_5;
        private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
        private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
        private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileGameplayHeightsHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_DynamicBuffer_1_TileDisabledCollisionHistoryElement_byref_Translation_byref_Controller_byref_InputCommandDataProxy_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TileCollisionHistorySystem_Base_byref___c__DisplayClass9_0_0;
        [FieldOffset(0)]
        public bool isServer;
        [FieldOffset(4)]
        public int currentFrame;
        [FieldOffset(8)]
        public TileWorld tileWorld;
        [FieldOffset(32)]
        public TileMapCollisionMath.TilePolygons tilePolygons;
        [FieldOffset(112)]
        public NativeArray<CommandUtility.TileCollisionHistorySystem_Base.UserInCollision> usersInCollision;
        [FieldOffset(128)]
        public SpatialLookupParams spatialLookup;
        [FieldOffset(208)]
        public ComponentDataFromEntity<InputCommandState> _ComponentDataFromEntity_InputCommandState_0;
        [FieldOffset(240)]
        public ComponentDataFromEntity<IsSpellControlled> _ComponentDataFromEntity_IsSpellControlled_1;
        [FieldOffset(272)]
        public ComponentDataFromEntity<MapCollision> _ComponentDataFromEntity_MapCollision_2;
        [FieldOffset(304)]
        public ComponentDataFromEntity<ConnectedUser> _ComponentDataFromEntity_ConnectedUser_3;
        [FieldOffset(336)]
        public ComponentDataFromEntity<TilePosition> _ComponentDataFromEntity_TilePosition_4;
        [FieldOffset(368)]
        public ComponentDataFromEntity<TileData> _ComponentDataFromEntity_TileData_5;
        [FieldOffset(400)]
        public CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
        [FieldOffset(664)]
        public unsafe CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150192, XrefRangeEnd = 1150318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void OriginalLambdaBody(
          Entity entity,
          ref DynamicBuffer<TileCollisionHistoryElement> tileCollisionHistoryBuffer,
          ref DynamicBuffer<TileGameplayHeightsHistoryElement> tileGameplayHeightsHistoryBuffer,
          ref DynamicBuffer<TileCollisionHistoryMetadataElement> tileCollisionHistoryMetadataBuffer,
          ref DynamicBuffer<TileDisabledCollisionHistoryElement> tileDisabledCollisionHistoryBuffer,
          [In] ref Translation translationDO_NOT_USE,
          [In] ref Controller controller,
          [In] ref InputCommandDataProxy inputCommandDataProxy)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[8];
          numPtr[0] = (System.IntPtr) &entity;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileGameplayHeightsHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionHistoryMetadataBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileDisabledCollisionHistoryBuffer;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref translationDO_NOT_USE;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputCommandDataProxy;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileGameplayHeightsHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_DynamicBuffer_1_TileDisabledCollisionHistoryElement_byref_Translation_byref_Controller_byref_InputCommandDataProxy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1150318, RefRangeEnd = 1150319, XrefRangeStart = 1150318, XrefRangeEnd = 1150318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void ReadFromDisplayClass(
          ref CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150319, XrefRangeEnd = 1150321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Execute(
          ArchetypeChunk chunk,
          int chunkIndex,
          int firstEntityIndex)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1150345, RefRangeEnd = 1150346, XrefRangeStart = 1150321, XrefRangeEnd = 1150345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void IterateEntities(
          ref ArchetypeChunk chunk,
          ref CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1150366, RefRangeEnd = 1150367, XrefRangeStart = 1150346, XrefRangeEnd = 1150366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          CommandUtility.TileCollisionHistorySystem_Base componentSystem,
          ref CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass9_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TileCollisionHistorySystem_Base_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass_OnUpdate_LambdaJob0()
        {
          Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (isServer));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (currentFrame));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (tileWorld));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_tilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (tilePolygons));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_usersInCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (usersInCollision));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_spatialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (spatialLookup));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_InputCommandState_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_InputCommandState_0));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_IsSpellControlled_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_IsSpellControlled_1));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_MapCollision_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_MapCollision_2));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ConnectedUser_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_ConnectedUser_3));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_TilePosition_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_TilePosition_4));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_TileData_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_TileData_5));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileGameplayHeightsHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_DynamicBuffer_1_TileDisabledCollisionHistoryElement_byref_Translation_byref_Controller_byref_InputCommandDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691440);
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691441);
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691442);
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691443);
          CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TileCollisionHistorySystem_Base_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100691444);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LambdaParameterValueProviders
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tileCollisionHistoryBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tileGameplayHeightsHistoryBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tileCollisionHistoryMetadataBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tileDisabledCollisionHistoryBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translationDO_NOT_USE;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_inputCommandDataProxy;
          private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TileCollisionHistorySystem_Base_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity forParameter_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<TileCollisionHistoryElement> forParameter_tileCollisionHistoryBuffer;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_DynamicBuffer<TileGameplayHeightsHistoryElement> forParameter_tileGameplayHeightsHistoryBuffer;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_DynamicBuffer<TileCollisionHistoryMetadataElement> forParameter_tileCollisionHistoryMetadataBuffer;
          [FieldOffset(128)]
          public LambdaParameterValueProvider_DynamicBuffer<TileDisabledCollisionHistoryElement> forParameter_tileDisabledCollisionHistoryBuffer;
          [FieldOffset(168)]
          public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translationDO_NOT_USE;
          [FieldOffset(200)]
          public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;
          [FieldOffset(232)]
          public LambdaParameterValueProvider_IComponentData<InputCommandDataProxy> forParameter_inputCommandDataProxy;

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1150168, RefRangeEnd = 1150169, XrefRangeStart = 1150146, XrefRangeEnd = 1150168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe void ScheduleTimeInitialize(
            CommandUtility.TileCollisionHistorySystem_Base componentSystem)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TileCollisionHistorySystem_Base_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1150191, RefRangeEnd = 1150192, XrefRangeStart = 1150169, XrefRangeEnd = 1150191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
            ref ArchetypeChunk p0,
            int p1,
            int p2)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[3];
            numPtr[0] = (System.IntPtr) ref p0;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
          }

          static LambdaParameterValueProviders()
          {
            Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tileCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tileCollisionHistoryBuffer));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tileGameplayHeightsHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tileGameplayHeightsHistoryBuffer));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tileCollisionHistoryMetadataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tileCollisionHistoryMetadataBuffer));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tileDisabledCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tileDisabledCollisionHistoryBuffer));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translationDO_NOT_USE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translationDO_NOT_USE));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_inputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_inputCommandDataProxy));
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TileCollisionHistorySystem_Base_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691445);
            CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691446);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
          }

          [StructLayout(LayoutKind.Explicit)]
          public struct Runtimes
          {
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tileCollisionHistoryBuffer;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tileGameplayHeightsHistoryBuffer;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tileCollisionHistoryMetadataBuffer;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tileDisabledCollisionHistoryBuffer;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translationDO_NOT_USE;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_inputCommandDataProxy;
            [FieldOffset(0)]
            public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
            [FieldOffset(8)]
            public LambdaParameterValueProvider_DynamicBuffer<TileCollisionHistoryElement>.Runtime runtime_tileCollisionHistoryBuffer;
            [FieldOffset(32)]
            public LambdaParameterValueProvider_DynamicBuffer<TileGameplayHeightsHistoryElement>.Runtime runtime_tileGameplayHeightsHistoryBuffer;
            [FieldOffset(56)]
            public LambdaParameterValueProvider_DynamicBuffer<TileCollisionHistoryMetadataElement>.Runtime runtime_tileCollisionHistoryMetadataBuffer;
            [FieldOffset(80)]
            public LambdaParameterValueProvider_DynamicBuffer<TileDisabledCollisionHistoryElement>.Runtime runtime_tileDisabledCollisionHistoryBuffer;
            [FieldOffset(104)]
            public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translationDO_NOT_USE;
            [FieldOffset(112)]
            public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;
            [FieldOffset(120)]
            public LambdaParameterValueProvider_IComponentData<InputCommandDataProxy>.Runtime runtime_inputCommandDataProxy;

            static Runtimes()
            {
              Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
              CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
              CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tileCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tileCollisionHistoryBuffer));
              CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tileGameplayHeightsHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tileGameplayHeightsHistoryBuffer));
              CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tileCollisionHistoryMetadataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tileCollisionHistoryMetadataBuffer));
              CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tileDisabledCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tileDisabledCollisionHistoryBuffer));
              CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translationDO_NOT_USE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translationDO_NOT_USE));
              CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
              CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_inputCommandDataProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_inputCommandDataProxy));
            }

            public Il2CppSystem.Object BoxIl2CppObject()
            {
              return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandUtility.TileCollisionHistorySystem_Base.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
            }
          }
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_TMapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0<TMapData, TCollisionCheck>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CommandUtility.NativeMethodInfoPtr_ResolveStaticCollision_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_MapCollision_byref_TMapData_Byte_MapCollisionFlags_byref_Boolean_WorldType_Entity_0, Il2CppClassPointerStore<CommandUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMapData>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollisionCheck>.NativeClassPtr))
      }))));
    }
  }
}
