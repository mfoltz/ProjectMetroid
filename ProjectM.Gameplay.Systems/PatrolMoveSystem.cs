// Decompiled with JetBrains decompiler
// Type: ProjectM.PatrolMoveSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Behaviours;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Pathfinding;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class PatrolMoveSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__RoadPathGraphSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__SnapDisabledUnitsChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__SnapDisabledUnitsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasLoggedPathfindingErrors;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateLocalPatrol_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InstantiateGlobalPatrol_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InstantiateGlobalPatrol_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateGlobalPatrol_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateGlobalPatrol_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___MovePatrol_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateOffsets_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetFollowData_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetFollowData_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNextWaypoint_Private_Static_Entity_byref_Entity_byref_Entity_byref_Random_BufferFromEntity_1_PathWaypointNeighbours_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__MoveTowards_Private_Static_float3_float3_float3_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateNextPathRequest_Private_Static_Void_EntityCommandBuffer_Entity_byref_DynamicBuffer_1_PatrolBusStopNode_byref_GlobalPatrolState_byref_MovePatrolState_byref_Random_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckPlacement_Private_Static_Boolean_Entity_float3_quaternion_byref_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateLocalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForInstantiateGlobalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateGlobalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForMovePatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateOffsets_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetFollowData_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407173, XrefRangeEnd = 1407217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolMoveSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407217, XrefRangeEnd = 1407221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolMoveSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1407251, RefRangeEnd = 1407253, XrefRangeStart = 1407221, XrefRangeEnd = 1407251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetNextWaypoint(
      [In] ref Entity fromNode,
      [In] ref Entity currentNode,
      ref Unity.Mathematics.Random random,
      BufferFromEntity<PathWaypointNeighbours> getNeighbours,
      out bool reachedDeadEnd)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref fromNode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentNode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getNeighbours;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref reachedDeadEnd;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr_GetNextWaypoint_Private_Static_Entity_byref_Entity_byref_Entity_byref_Random_BufferFromEntity_1_PathWaypointNeighbours_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1407258, RefRangeEnd = 1407260, XrefRangeStart = 1407253, XrefRangeEnd = 1407258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 _MoveTowards(
      float3 source,
      float3 target,
      float minMovementSpeed,
      float maxMovementSpeed,
      float deltaTime,
      float maxDistance)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minMovementSpeed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxMovementSpeed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &maxDistance;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr__MoveTowards_Private_Static_float3_float3_float3_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1407285, RefRangeEnd = 1407287, XrefRangeStart = 1407260, XrefRangeEnd = 1407285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateNextPathRequest(
      EntityCommandBuffer commandBuffer,
      Entity patrolEntity,
      [In] ref DynamicBuffer<PatrolBusStopNode> busStops,
      ref GlobalPatrolState patrolState,
      ref MovePatrolState movePatrolState,
      ref Unity.Mathematics.Random random,
      out bool reachedDeadEnd)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &patrolEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref busStops;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref reachedDeadEnd;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr_CreateNextPathRequest_Private_Static_Void_EntityCommandBuffer_Entity_byref_DynamicBuffer_1_PatrolBusStopNode_byref_GlobalPatrolState_byref_MovePatrolState_byref_Random_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407287, XrefRangeEnd = 1407403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolMoveSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407415, RefRangeEnd = 1407416, XrefRangeStart = 1407403, XrefRangeEnd = 1407415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckPlacement(
      Entity unit,
      float3 newPosition,
      quaternion newRotation,
      ref GetPlacementResult.JobData getPlacementJobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &unit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref getPlacementJobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr_CheckPlacement_Private_Static_Boolean_Entity_float3_quaternion_byref_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PatrolMoveSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407416, XrefRangeEnd = 1407469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolMoveSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407500, RefRangeEnd = 1407501, XrefRangeStart = 1407469, XrefRangeEnd = 1407500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateLocalPatrol_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateLocalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407538, RefRangeEnd = 1407539, XrefRangeStart = 1407501, XrefRangeEnd = 1407538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForInstantiateGlobalPatrol_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForInstantiateGlobalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407573, RefRangeEnd = 1407574, XrefRangeStart = 1407539, XrefRangeEnd = 1407573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateGlobalPatrol_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateGlobalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407605, RefRangeEnd = 1407606, XrefRangeStart = 1407574, XrefRangeEnd = 1407605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForMovePatrol_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForMovePatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407631, RefRangeEnd = 1407632, XrefRangeStart = 1407606, XrefRangeEnd = 1407631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateOffsets_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateOffsets_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407657, RefRangeEnd = 1407658, XrefRangeStart = 1407632, XrefRangeEnd = 1407657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetFollowData_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetFollowData_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407662, RefRangeEnd = 1407663, XrefRangeStart = 1407658, XrefRangeEnd = 1407662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407667, RefRangeEnd = 1407668, XrefRangeStart = 1407663, XrefRangeEnd = 1407667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1407672, RefRangeEnd = 1407673, XrefRangeStart = 1407668, XrefRangeEnd = 1407672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PatrolMoveSystem()
    {
      Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (PatrolMoveSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr);
      PatrolMoveSystem.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, nameof (_ModificationSystem));
      PatrolMoveSystem.NativeFieldInfoPtr__RoadPathGraphSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, nameof (_RoadPathGraphSystem));
      PatrolMoveSystem.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, nameof (_PlacementSystemData));
      PatrolMoveSystem.NativeFieldInfoPtr__SnapDisabledUnitsChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, nameof (_SnapDisabledUnitsChunkRange));
      PatrolMoveSystem.NativeFieldInfoPtr__SnapDisabledUnitsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, nameof (_SnapDisabledUnitsQuery));
      PatrolMoveSystem.NativeFieldInfoPtr__HasLoggedPathfindingErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, nameof (_HasLoggedPathfindingErrors));
      PatrolMoveSystem.NativeFieldInfoPtr___UpdateLocalPatrol_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>UpdateLocalPatrol_entityQuery");
      PatrolMoveSystem.NativeFieldInfoPtr___InstantiateGlobalPatrol_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>InstantiateGlobalPatrol_entityQuery");
      PatrolMoveSystem.NativeFieldInfoPtr___InstantiateGlobalPatrol_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>InstantiateGlobalPatrol_profilerMarker");
      PatrolMoveSystem.NativeFieldInfoPtr___UpdateGlobalPatrol_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>UpdateGlobalPatrol_entityQuery");
      PatrolMoveSystem.NativeFieldInfoPtr___UpdateGlobalPatrol_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>UpdateGlobalPatrol_profilerMarker");
      PatrolMoveSystem.NativeFieldInfoPtr___MovePatrol_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>MovePatrol_entityQuery");
      PatrolMoveSystem.NativeFieldInfoPtr___UpdateOffsets_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>UpdateOffsets_entityQuery");
      PatrolMoveSystem.NativeFieldInfoPtr___SetFollowData_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>SetFollowData_entityQuery");
      PatrolMoveSystem.NativeFieldInfoPtr___SetFollowData_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>SetFollowData_profilerMarker");
      PatrolMoveSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668193);
      PatrolMoveSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668194);
      PatrolMoveSystem.NativeMethodInfoPtr_GetNextWaypoint_Private_Static_Entity_byref_Entity_byref_Entity_byref_Random_BufferFromEntity_1_PathWaypointNeighbours_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668195);
      PatrolMoveSystem.NativeMethodInfoPtr__MoveTowards_Private_Static_float3_float3_float3_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668196);
      PatrolMoveSystem.NativeMethodInfoPtr_CreateNextPathRequest_Private_Static_Void_EntityCommandBuffer_Entity_byref_DynamicBuffer_1_PatrolBusStopNode_byref_GlobalPatrolState_byref_MovePatrolState_byref_Random_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668197);
      PatrolMoveSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668198);
      PatrolMoveSystem.NativeMethodInfoPtr_CheckPlacement_Private_Static_Boolean_Entity_float3_quaternion_byref_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668199);
      PatrolMoveSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668200);
      PatrolMoveSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668201);
      PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateLocalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668202);
      PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForInstantiateGlobalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668203);
      PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateGlobalPatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668204);
      PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForMovePatrol_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668205);
      PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateOffsets_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668206);
      PatrolMoveSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetFollowData_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668207);
      PatrolMoveSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668208);
      PatrolMoveSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668209);
      PatrolMoveSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, 100668210);
    }

    public PatrolMoveSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorldRoadGraphSystem _RoadPathGraphSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__RoadPathGraphSystem));
        return pointer == System.IntPtr.Zero ? (WorldRoadGraphSystem) null : new WorldRoadGraphSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__RoadPathGraphSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChunkRange _SnapDisabledUnitsChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__SnapDisabledUnitsChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__SnapDisabledUnitsChunkRange)) = value;
      }
    }

    public unsafe EntityQuery _SnapDisabledUnitsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__SnapDisabledUnitsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__SnapDisabledUnitsQuery)) = value;
      }
    }

    public unsafe NativeReference<bool> _HasLoggedPathfindingErrors
    {
      get
      {
        return *(NativeReference<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__HasLoggedPathfindingErrors));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr__HasLoggedPathfindingErrors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __UpdateLocalPatrol_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___UpdateLocalPatrol_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___UpdateLocalPatrol_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __InstantiateGlobalPatrol_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___InstantiateGlobalPatrol_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___InstantiateGlobalPatrol_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __InstantiateGlobalPatrol_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___InstantiateGlobalPatrol_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___InstantiateGlobalPatrol_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateGlobalPatrol_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___UpdateGlobalPatrol_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___UpdateGlobalPatrol_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateGlobalPatrol_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___UpdateGlobalPatrol_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___UpdateGlobalPatrol_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __MovePatrol_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___MovePatrol_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___MovePatrol_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __UpdateOffsets_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___UpdateOffsets_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___UpdateOffsets_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __SetFollowData_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___SetFollowData_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___SetFollowData_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetFollowData_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___SetFollowData_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.NativeFieldInfoPtr___SetFollowData_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SnapDisabledUnitsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_RotationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_FollowerType;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUIDType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTransformType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementJobData;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ChunkRange ChunkRange;
      [FieldOffset(12)]
      public EntityTypeHandle EntityType;
      [FieldOffset(16)]
      public ComponentTypeHandle<Rotation> RotationType;
      [FieldOffset(48)]
      public ComponentTypeHandle<Follower> FollowerType;
      [FieldOffset(80)]
      public ComponentTypeHandle<PrefabGUID> PrefabGUIDType;
      [FieldOffset(112)]
      public ComponentTypeHandle<LastTranslation> LastTranslationType;
      [FieldOffset(144)]
      public ComponentTypeHandle<SpawnTransform> SpawnTransformType;
      [FieldOffset(176)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(208)]
      public GetPlacementResult.JobData PlacementJobData;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406191, XrefRangeEnd = 1406224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.SnapDisabledUnitsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SnapDisabledUnitsJob()
      {
        Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, nameof (SnapDisabledUnitsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr);
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (ChunkRange));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (EntityType));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (RotationType));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_FollowerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (FollowerType));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_PrefabGUIDType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (PrefabGUIDType));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_LastTranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (LastTranslationType));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_SpawnTransformType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (SpawnTransformType));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (GetTranslation));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeFieldInfoPtr_PlacementJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, nameof (PlacementJobData));
        PatrolMoveSystem.SnapDisabledUnitsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, 100668211);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.SnapDisabledUnitsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.PatrolMoveSystem/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_getNeighbours;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldRoadGraph;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasLoggedPathfindingErrors;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_MovePatrolState_byref_PatrolState_byref_UnitCompositionSpawner_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_GlobalPatrolState_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_PatrolBusStopNode_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_MovePatrolState_byref_DynamicBuffer_1_WaypointTargetBufferEntry_byref_UnitCompositionSpawner_byref_GlobalPatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_PatrolBusStopNode_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_FormationOffsetBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_MovePatrolState_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_Translation_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        ref MovePatrolState movePatrolState,
        ref PatrolState patrolState,
        ref UnitCompositionSpawner spawner,
        ref Translation translation,
        ref Rotation rotation,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref movePatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_MovePatrolState_byref_PatrolState_byref_UnitCompositionSpawner_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref GlobalPatrolState globalPatrolState,
        ref MovePatrolState movePatrolState,
        ref Translation translation,
        ref Rotation rotation,
        ref Velocity velocity,
        [In] ref DynamicBuffer<PatrolBusStopNode> busStops)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref globalPatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref busStops;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_GlobalPatrolState_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_PatrolBusStopNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        ref MovePatrolState movePatrolState,
        ref DynamicBuffer<WaypointTargetBufferEntry> waypoints,
        ref UnitCompositionSpawner spawner,
        [In] ref GlobalPatrolState patrolState,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        [In] ref DynamicBuffer<PatrolBusStopNode> busStops)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref waypoints;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref busStops;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_MovePatrolState_byref_DynamicBuffer_1_WaypointTargetBufferEntry_byref_UnitCompositionSpawner_byref_GlobalPatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_PatrolBusStopNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        ref MovePatrolState patrolState,
        ref Translation translation,
        ref Rotation rotation,
        ref Velocity velocity,
        ref DynamicBuffer<FormationOffsetBuffer> offsets,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref offsets;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        Entity entity,
        ref MovePatrolState patrolState,
        ref Translation translation,
        ref Rotation rotation,
        ref DynamicBuffer<FormationOffsetBuffer> offsets)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref offsets;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_FormationOffsetBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__5(
        Entity entity,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        [In] ref MovePatrolState patrolState,
        [In] ref DynamicBuffer<FormationOffsetBuffer> offsets,
        [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref offsets;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_MovePatrolState_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr);
        PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
        PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (random));
        PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_getNeighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (getNeighbours));
        PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_worldRoadGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (worldRoadGraph));
        PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (commandBuffer));
        PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_hasLoggedPathfindingErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (hasLoggedPathfindingErrors));
        PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (deltaTime));
        PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (modificationStruct));
        PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, 100668212);
        PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_MovePatrolState_byref_PatrolState_byref_UnitCompositionSpawner_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, 100668213);
        PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_GlobalPatrolState_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_PatrolBusStopNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, 100668214);
        PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_MovePatrolState_byref_DynamicBuffer_1_WaypointTargetBufferEntry_byref_UnitCompositionSpawner_byref_GlobalPatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_PatrolBusStopNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, 100668215);
        PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, 100668216);
        PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_FormationOffsetBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, 100668217);
        PatrolMoveSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_MovePatrolState_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, 100668218);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass11_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass11_0>.NativeClassPtr, data));
      }

      public unsafe PatrolMoveSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PatrolMoveSystem) null : new PatrolMoveSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Unity.Mathematics.Random random
      {
        get
        {
          return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_random));
        }
        [param: In] set
        {
          *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_random)) = value;
        }
      }

      public unsafe BufferFromEntity<PathWaypointNeighbours> getNeighbours
      {
        get
        {
          return *(BufferFromEntity<PathWaypointNeighbours>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_getNeighbours));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_getNeighbours), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<PathWaypointNeighbours>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<WorldRoadGraph> worldRoadGraph
      {
        get
        {
          return *(Nullable_Unboxed<WorldRoadGraph>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_worldRoadGraph));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_worldRoadGraph), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<WorldRoadGraph>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe NativeReference<bool> hasLoggedPathfindingErrors
      {
        get
        {
          return *(NativeReference<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_hasLoggedPathfindingErrors));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_hasLoggedPathfindingErrors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe ModificationStructure modificationStruct
      {
        get
        {
          return *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_modificationStruct));
        }
        [param: In] set
        {
          *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolMoveSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_modificationStruct)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_UpdateLocalPatrol")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateLocalPatrol
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_getNeighbours;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PathSettings_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PathWaypointNode_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeState_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MiscAiGameplayData_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PathWaypointNodeWait_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MovePatrolState_byref_PatrolState_byref_UnitCompositionSpawner_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0;
      [FieldOffset(0)]
      public Unity.Mathematics.Random random;
      [FieldOffset(8)]
      public BufferFromEntity<PathWaypointNeighbours> getNeighbours;
      [FieldOffset(48)]
      public ComponentDataFromEntity<PathSettings> _ComponentDataFromEntity_PathSettings_0;
      [FieldOffset(80)]
      public ComponentDataFromEntity<PathWaypointNode> _ComponentDataFromEntity_PathWaypointNode_1;
      [FieldOffset(112)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_2;
      [FieldOffset(144)]
      public ComponentDataFromEntity<BehaviourTreeState> _ComponentDataFromEntity_BehaviourTreeState_3;
      [FieldOffset(176)]
      public ComponentDataFromEntity<MiscAiGameplayData> _ComponentDataFromEntity_MiscAiGameplayData_4;
      [FieldOffset(208)]
      public ComponentDataFromEntity<PathWaypointNodeWait> _ComponentDataFromEntity_PathWaypointNodeWait_5;
      [FieldOffset(240)]
      public PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(440)]
      public unsafe PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406262, XrefRangeEnd = 1406315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref MovePatrolState movePatrolState,
        ref PatrolState patrolState,
        ref UnitCompositionSpawner spawner,
        ref Translation translation,
        ref Rotation rotation,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref movePatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MovePatrolState_byref_PatrolState_byref_UnitCompositionSpawner_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406315, RefRangeEnd = 1406316, XrefRangeStart = 1406315, XrefRangeEnd = 1406315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406316, XrefRangeEnd = 1406318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406338, RefRangeEnd = 1406339, XrefRangeStart = 1406318, XrefRangeEnd = 1406338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406359, RefRangeEnd = 1406360, XrefRangeStart = 1406339, XrefRangeEnd = 1406359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PatrolMoveSystem componentSystem,
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateLocalPatrol()
      {
        Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateLocalPatrol");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr);
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (random));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr_getNeighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (getNeighbours));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_PathSettings_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_PathSettings_0));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_PathWaypointNode_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_PathWaypointNode_1));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_2));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeState_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_BehaviourTreeState_3));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_MiscAiGameplayData_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_MiscAiGameplayData_4));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_PathWaypointNodeWait_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_PathWaypointNodeWait_5));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (_runtimes));
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MovePatrolState_byref_PatrolState_byref_UnitCompositionSpawner_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, 100668219);
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, 100668220);
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, 100668221);
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, 100668222);
        PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, 100668223);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_movePatrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_patrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<MovePatrolState> forParameter_movePatrolState;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<PatrolState> forParameter_patrolState;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_spawner;
        [FieldOffset(96)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(128)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(160)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406242, RefRangeEnd = 1406243, XrefRangeStart = 1406224, XrefRangeEnd = 1406242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PatrolMoveSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406261, RefRangeEnd = 1406262, XrefRangeStart = 1406243, XrefRangeEnd = 1406261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_movePatrolState));
          PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_patrolState));
          PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawner));
          PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, 100668224);
          PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, 100668225);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_movePatrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_patrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<MovePatrolState>.Runtime runtime_movePatrolState;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PatrolState>.Runtime runtime_patrolState;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_spawner;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;

          static Runtimes()
          {
            Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_movePatrolState));
            PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_patrolState));
            PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawner));
            PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateLocalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_InstantiateGlobalPatrol")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_InstantiateGlobalPatrol
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_worldRoadGraph;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_GlobalPatrolState_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_PatrolBusStopNode_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Nullable_Unboxed<WorldRoadGraph> worldRoadGraph;
      [FieldOffset(72)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(88)]
      public PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(296)]
      public unsafe PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406475, XrefRangeEnd = 1406491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref GlobalPatrolState globalPatrolState,
        ref MovePatrolState movePatrolState,
        ref Translation translation,
        ref Rotation rotation,
        ref Velocity velocity,
        [In] ref DynamicBuffer<PatrolBusStopNode> busStops)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref globalPatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref busStops;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_GlobalPatrolState_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_PatrolBusStopNode_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406491, RefRangeEnd = 1406492, XrefRangeStart = 1406491, XrefRangeEnd = 1406491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406492, RefRangeEnd = 1406493, XrefRangeStart = 1406492, XrefRangeEnd = 1406492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406493, XrefRangeEnd = 1406495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406516, RefRangeEnd = 1406517, XrefRangeStart = 1406495, XrefRangeEnd = 1406516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406519, RefRangeEnd = 1406520, XrefRangeStart = 1406517, XrefRangeEnd = 1406519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PatrolMoveSystem componentSystem,
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406520, XrefRangeEnd = 1406524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406524, XrefRangeEnd = 1406530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_InstantiateGlobalPatrol()
      {
        Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>c__DisplayClass_InstantiateGlobalPatrol");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr);
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr_worldRoadGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, nameof (worldRoadGraph));
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, nameof (commandBuffer));
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, nameof (_runtimes));
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_GlobalPatrolState_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_PatrolBusStopNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, 100668226);
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, 100668227);
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, 100668228);
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, 100668229);
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, 100668230);
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, 100668231);
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, 100668232);
        PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, 100668233);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_globalPatrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_movePatrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_velocity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_busStops;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<GlobalPatrolState> forParameter_globalPatrolState;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<MovePatrolState> forParameter_movePatrolState;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(136)]
        public LambdaParameterValueProvider_IComponentData<Velocity> forParameter_velocity;
        [FieldOffset(168)]
        public LambdaParameterValueProvider_DynamicBuffer<PatrolBusStopNode> forParameter_busStops;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406379, RefRangeEnd = 1406380, XrefRangeStart = 1406360, XrefRangeEnd = 1406379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PatrolMoveSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406399, RefRangeEnd = 1406400, XrefRangeStart = 1406380, XrefRangeEnd = 1406399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_globalPatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_globalPatrolState));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_movePatrolState));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_velocity));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_busStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_busStops));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, 100668234);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, 100668235);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_globalPatrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_movePatrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_velocity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_busStops;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<GlobalPatrolState>.Runtime runtime_globalPatrolState;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<MovePatrolState>.Runtime runtime_movePatrolState;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Velocity>.Runtime runtime_velocity;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_DynamicBuffer<PatrolBusStopNode>.Runtime runtime_busStops;

          static Runtimes()
          {
            Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_globalPatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_globalPatrolState));
            PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_movePatrolState));
            PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_velocity));
            PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_busStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_busStops));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_InstantiateGlobalPatrol/ProjectM.RunWithoutJobSystem_00000BA1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, "RunWithoutJobSystem_00000BA1$PostfixBurstDelegate");
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668236);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668237);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668238);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668239);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_InstantiateGlobalPatrol/ProjectM.RunWithoutJobSystem_00000BA1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406400, XrefRangeEnd = 1406414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406414, XrefRangeEnd = 1406432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406432, XrefRangeEnd = 1406447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406474, RefRangeEnd = 1406475, XrefRangeStart = 1406447, XrefRangeEnd = 1406474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol>.NativeClassPtr, "RunWithoutJobSystem_00000BA1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668240);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668241);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668242);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668243);
          PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668245);
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
            IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_InstantiateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_UpdateGlobalPatrol")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateGlobalPatrol
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasLoggedPathfindingErrors;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldRoadGraph;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_RoadPathfindingRequest_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_RoadPathfindingResult_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeState_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MiscAiGameplayData_6;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MovePatrolState_byref_DynamicBuffer_1_WaypointTargetBufferEntry_byref_UnitCompositionSpawner_byref_GlobalPatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_PatrolBusStopNode_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public Unity.Mathematics.Random random;
      [FieldOffset(24)]
      public NativeReference<bool> hasLoggedPathfindingErrors;
      [FieldOffset(40)]
      public Nullable_Unboxed<WorldRoadGraph> worldRoadGraph;
      [FieldOffset(112)]
      public ComponentDataFromEntity<RoadPathfindingRequest> _ComponentDataFromEntity_RoadPathfindingRequest_0;
      [FieldOffset(144)]
      public BufferFromEntity<RoadPathfindingResult> _BufferFromEntity_RoadPathfindingResult_1;
      [FieldOffset(184)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_2;
      [FieldOffset(216)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_3;
      [FieldOffset(248)]
      public ComponentDataFromEntity<Disabled> _ComponentDataFromEntity_Disabled_4;
      [FieldOffset(280)]
      public ComponentDataFromEntity<BehaviourTreeState> _ComponentDataFromEntity_BehaviourTreeState_5;
      [FieldOffset(312)]
      public ComponentDataFromEntity<MiscAiGameplayData> _ComponentDataFromEntity_MiscAiGameplayData_6;
      [FieldOffset(344)]
      public PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(568)]
      public unsafe PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406645, XrefRangeEnd = 1406733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref MovePatrolState movePatrolState,
        ref DynamicBuffer<WaypointTargetBufferEntry> waypoints,
        ref UnitCompositionSpawner spawner,
        [In] ref GlobalPatrolState patrolState,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        [In] ref DynamicBuffer<PatrolBusStopNode> busStops)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref movePatrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref waypoints;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref busStops;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MovePatrolState_byref_DynamicBuffer_1_WaypointTargetBufferEntry_byref_UnitCompositionSpawner_byref_GlobalPatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_PatrolBusStopNode_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406733, RefRangeEnd = 1406734, XrefRangeStart = 1406733, XrefRangeEnd = 1406733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406734, RefRangeEnd = 1406735, XrefRangeStart = 1406734, XrefRangeEnd = 1406734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406735, XrefRangeEnd = 1406737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406758, RefRangeEnd = 1406759, XrefRangeStart = 1406737, XrefRangeEnd = 1406758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406782, RefRangeEnd = 1406783, XrefRangeStart = 1406759, XrefRangeEnd = 1406782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PatrolMoveSystem componentSystem,
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406783, XrefRangeEnd = 1406787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406787, XrefRangeEnd = 1406793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateGlobalPatrol()
      {
        Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateGlobalPatrol");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr);
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (commandBuffer));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (random));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_hasLoggedPathfindingErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (hasLoggedPathfindingErrors));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_worldRoadGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (worldRoadGraph));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_RoadPathfindingRequest_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_RoadPathfindingRequest_0));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__BufferFromEntity_RoadPathfindingResult_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_BufferFromEntity_RoadPathfindingResult_1));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_2));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_3));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_Disabled_4));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeState_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_BehaviourTreeState_5));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__ComponentDataFromEntity_MiscAiGameplayData_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_ComponentDataFromEntity_MiscAiGameplayData_6));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (_runtimes));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MovePatrolState_byref_DynamicBuffer_1_WaypointTargetBufferEntry_byref_UnitCompositionSpawner_byref_GlobalPatrolState_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_DynamicBuffer_1_PatrolBusStopNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, 100668246);
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, 100668247);
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, 100668248);
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, 100668249);
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, 100668250);
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, 100668251);
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, 100668252);
        PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, 100668253);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_movePatrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_waypoints;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_patrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_busStops;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<MovePatrolState> forParameter_movePatrolState;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<WaypointTargetBufferEntry> forParameter_waypoints;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner> forParameter_spawner;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_IComponentData<GlobalPatrolState> forParameter_patrolState;
        [FieldOffset(144)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;
        [FieldOffset(184)]
        public LambdaParameterValueProvider_DynamicBuffer<PatrolBusStopNode> forParameter_busStops;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406549, RefRangeEnd = 1406550, XrefRangeStart = 1406530, XrefRangeEnd = 1406549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PatrolMoveSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406569, RefRangeEnd = 1406570, XrefRangeStart = 1406550, XrefRangeEnd = 1406569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_movePatrolState));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_waypoints));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawner));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_patrolState));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_busStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_busStops));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, 100668254);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, 100668255);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_movePatrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_waypoints;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_patrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_busStops;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<MovePatrolState>.Runtime runtime_movePatrolState;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<WaypointTargetBufferEntry>.Runtime runtime_waypoints;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<UnitCompositionSpawner>.Runtime runtime_spawner;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<GlobalPatrolState>.Runtime runtime_patrolState;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;
          [FieldOffset(80)]
          public LambdaParameterValueProvider_DynamicBuffer<PatrolBusStopNode>.Runtime runtime_busStops;

          static Runtimes()
          {
            Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_movePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_movePatrolState));
            PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_waypoints));
            PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawner));
            PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_patrolState));
            PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
            PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_busStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_busStops));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_UpdateGlobalPatrol/ProjectM.RunWithoutJobSystem_00000BAA$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, "RunWithoutJobSystem_00000BAA$PostfixBurstDelegate");
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668256);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668257);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668258);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668259);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_UpdateGlobalPatrol/ProjectM.RunWithoutJobSystem_00000BAA$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406570, XrefRangeEnd = 1406584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406584, XrefRangeEnd = 1406602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406602, XrefRangeEnd = 1406617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406644, RefRangeEnd = 1406645, XrefRangeStart = 1406617, XrefRangeEnd = 1406644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol>.NativeClassPtr, "RunWithoutJobSystem_00000BAA$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668260);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668261);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668262);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668263);
          PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668265);
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
            IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_UpdateGlobalPatrol.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_MovePatrol")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_MovePatrol
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(8)]
      public PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(216)]
      public unsafe PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406831, XrefRangeEnd = 1406860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref MovePatrolState patrolState,
        ref Translation translation,
        ref Rotation rotation,
        ref Velocity velocity,
        ref DynamicBuffer<FormationOffsetBuffer> offsets,
        [In] ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref offsets;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1406860, RefRangeEnd = 1406862, XrefRangeStart = 1406860, XrefRangeEnd = 1406860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406862, XrefRangeEnd = 1406864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406884, RefRangeEnd = 1406885, XrefRangeStart = 1406864, XrefRangeEnd = 1406884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406887, RefRangeEnd = 1406888, XrefRangeStart = 1406885, XrefRangeEnd = 1406887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PatrolMoveSystem componentSystem,
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_MovePatrol()
      {
        Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>c__DisplayClass_MovePatrol");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr);
        PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, nameof (deltaTime));
        PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, nameof (_runtimes));
        PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_Velocity_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_DynamicBuffer_1_UnitCompositionActiveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, 100668266);
        PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, 100668267);
        PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, 100668268);
        PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, 100668269);
        PatrolMoveSystem.__c__DisplayClass_MovePatrol.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, 100668270);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_patrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_velocity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_offsets;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<MovePatrolState> forParameter_patrolState;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(96)]
        public LambdaParameterValueProvider_IComponentData<Velocity> forParameter_velocity;
        [FieldOffset(128)]
        public LambdaParameterValueProvider_DynamicBuffer<FormationOffsetBuffer> forParameter_offsets;
        [FieldOffset(168)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406811, RefRangeEnd = 1406812, XrefRangeStart = 1406793, XrefRangeEnd = 1406811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PatrolMoveSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406830, RefRangeEnd = 1406831, XrefRangeStart = 1406812, XrefRangeEnd = 1406830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_patrolState));
          PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_velocity));
          PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_offsets));
          PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, 100668271);
          PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, 100668272);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_patrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_velocity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_offsets;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<MovePatrolState>.Runtime runtime_patrolState;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Velocity>.Runtime runtime_velocity;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<FormationOffsetBuffer>.Runtime runtime_offsets;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;

          static Runtimes()
          {
            Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_patrolState));
            PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_velocity));
            PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_offsets));
            PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_MovePatrol.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_UpdateOffsets")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateOffsets
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_FormationOffsetBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(8)]
      public PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(152)]
      public unsafe PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406916, XrefRangeEnd = 1406951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref MovePatrolState patrolState,
        ref Translation translation,
        ref Rotation rotation,
        ref DynamicBuffer<FormationOffsetBuffer> offsets)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref offsets;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_FormationOffsetBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1406860, RefRangeEnd = 1406862, XrefRangeStart = 1406860, XrefRangeEnd = 1406862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406951, XrefRangeEnd = 1406953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406968, RefRangeEnd = 1406969, XrefRangeStart = 1406953, XrefRangeEnd = 1406968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1406971, RefRangeEnd = 1406972, XrefRangeStart = 1406969, XrefRangeEnd = 1406971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PatrolMoveSystem componentSystem,
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateOffsets()
      {
        Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateOffsets");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr);
        PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, nameof (deltaTime));
        PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, nameof (_runtimes));
        PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MovePatrolState_byref_Translation_byref_Rotation_byref_DynamicBuffer_1_FormationOffsetBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, 100668273);
        PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, 100668274);
        PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, 100668275);
        PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, 100668276);
        PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, 100668277);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_patrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_offsets;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<MovePatrolState> forParameter_patrolState;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_DynamicBuffer<FormationOffsetBuffer> forParameter_offsets;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406901, RefRangeEnd = 1406902, XrefRangeStart = 1406888, XrefRangeEnd = 1406901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PatrolMoveSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406915, RefRangeEnd = 1406916, XrefRangeStart = 1406902, XrefRangeEnd = 1406915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_patrolState));
          PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_offsets));
          PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, 100668278);
          PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, 100668279);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_patrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_offsets;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<MovePatrolState>.Runtime runtime_patrolState;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<FormationOffsetBuffer>.Runtime runtime_offsets;

          static Runtimes()
          {
            Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_patrolState));
            PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_offsets));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_UpdateOffsets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_SetFollowData")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetFollowData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Follower_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SpawnTransform_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_EntityModificationBuffer_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_IntModificationBuffer_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_MovePatrolState_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ModificationStructure modificationStruct;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Follower> _ComponentDataFromEntity_Follower_0;
      [FieldOffset(64)]
      public ComponentDataFromEntity<SpawnTransform> _ComponentDataFromEntity_SpawnTransform_1;
      [FieldOffset(96)]
      public BufferFromEntity<EntityModificationBuffer> _BufferFromEntity_EntityModificationBuffer_2;
      [FieldOffset(136)]
      public BufferFromEntity<IntModificationBuffer> _BufferFromEntity_IntModificationBuffer_3;
      [FieldOffset(176)]
      public PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(328)]
      public unsafe PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407075, XrefRangeEnd = 1407128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<UnitCompositionActiveUnit> activeUnits,
        [In] ref MovePatrolState patrolState,
        [In] ref DynamicBuffer<FormationOffsetBuffer> offsets,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeUnits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref patrolState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref offsets;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_MovePatrolState_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1407128, RefRangeEnd = 1407129, XrefRangeStart = 1407128, XrefRangeEnd = 1407128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1407129, RefRangeEnd = 1407130, XrefRangeStart = 1407129, XrefRangeEnd = 1407129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407130, XrefRangeEnd = 1407132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1407147, RefRangeEnd = 1407148, XrefRangeStart = 1407132, XrefRangeEnd = 1407147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1407162, RefRangeEnd = 1407163, XrefRangeStart = 1407148, XrefRangeEnd = 1407162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PatrolMoveSystem componentSystem,
        ref PatrolMoveSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407163, XrefRangeEnd = 1407167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407167, XrefRangeEnd = 1407173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetFollowData()
      {
        Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem>.NativeClassPtr, "<>c__DisplayClass_SetFollowData");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr);
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (modificationStruct));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr__ComponentDataFromEntity_Follower_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (_ComponentDataFromEntity_Follower_0));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr__ComponentDataFromEntity_SpawnTransform_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (_ComponentDataFromEntity_SpawnTransform_1));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr__BufferFromEntity_EntityModificationBuffer_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (_BufferFromEntity_EntityModificationBuffer_2));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr__BufferFromEntity_IntModificationBuffer_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (_BufferFromEntity_IntModificationBuffer_3));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (_runtimes));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_UnitCompositionActiveUnit_byref_MovePatrolState_byref_DynamicBuffer_1_FormationOffsetBuffer_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, 100668280);
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, 100668281);
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, 100668282);
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, 100668283);
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, 100668284);
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, 100668285);
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, 100668286);
        PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, 100668287);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_SetFollowData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeUnits;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_patrolState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_offsets;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit> forParameter_activeUnits;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<MovePatrolState> forParameter_patrolState;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_DynamicBuffer<FormationOffsetBuffer> forParameter_offsets;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406985, RefRangeEnd = 1406986, XrefRangeStart = 1406972, XrefRangeEnd = 1406985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PatrolMoveSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1406999, RefRangeEnd = 1407000, XrefRangeStart = 1406986, XrefRangeEnd = 1406999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeUnits));
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_patrolState));
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_offsets));
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PatrolMoveSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, 100668288);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, 100668289);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeUnits;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_patrolState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_offsets;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<UnitCompositionActiveUnit>.Runtime runtime_activeUnits;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<MovePatrolState>.Runtime runtime_patrolState;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_DynamicBuffer<FormationOffsetBuffer>.Runtime runtime_offsets;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeUnits));
            PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_patrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_patrolState));
            PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_offsets));
            PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_SetFollowData/ProjectM.RunWithoutJobSystem_00000BC1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, "RunWithoutJobSystem_00000BC1$PostfixBurstDelegate");
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668290);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668291);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668292);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668293);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.PatrolMoveSystem/ProjectM.<>c__DisplayClass_SetFollowData/ProjectM.RunWithoutJobSystem_00000BC1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407000, XrefRangeEnd = 1407014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407014, XrefRangeEnd = 1407032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407032, XrefRangeEnd = 1407047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1407074, RefRangeEnd = 1407075, XrefRangeStart = 1407047, XrefRangeEnd = 1407074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData>.NativeClassPtr, "RunWithoutJobSystem_00000BC1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668294);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668295);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668296);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668297);
          PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668299);
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
            IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PatrolMoveSystem.__c__DisplayClass_SetFollowData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
