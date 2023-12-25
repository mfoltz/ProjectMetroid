// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeUtility
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Pathfinding;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class BehaviourTreeUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_LineOfSight_Public_Static_Boolean_float3_float3_byref_MapCollision_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PathfindingLineOfSight_Public_Static_Boolean_float3_float3_byref_MapCollision_byref_PathfindingTerrainData_byref_MiscAiGameplayData_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindFirstWalkable_Public_Static_Boolean_float3_float3_Single_byref_PathfindingTerrainData_byref_BehaviourTreeJobData_byref_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetIndexOf_Public_Static_Boolean_byref_BehaviourTreeNode_UInt16_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePathRequest_Public_Static_Entity_Entity_PathfindingSolver_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePathRequestEntity_Private_Static_Entity_ParallelWriter_Int32_byref_PathRequest_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindPathToPosition_Initialize_Public_Static_BehaviourTreeResult_float3_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindPathToPosition_Tick_Public_Static_FindPathToPositionTickResult_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindPathToPosition_Abort_Public_Static_Void_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRandomTileInArea_Public_Static_Boolean_float3_float2_byref_BehaviourTreeJobData_byref_float3_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMoveSpeed_Public_Static_Void_byref_BehaviourTreeJobData_byref_BehaviourTreeExpansionContext_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBlocked_Internal_Static_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_float3_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseBool_Public_Static_BehaviourTreeResult_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_T_ptr_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_byref_T_ptr_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1342584, RefRangeEnd = 1342587, XrefRangeStart = 1342583, XrefRangeEnd = 1342584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool LineOfSight(
      float3 start,
      float3 end,
      [In] ref MapCollision mapCollision,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_LineOfSight_Public_Static_Boolean_float3_float3_byref_MapCollision_byref_BehaviourTreeJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342588, RefRangeEnd = 1342589, XrefRangeStart = 1342587, XrefRangeEnd = 1342588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool PathfindingLineOfSight(
      float3 start,
      float3 end,
      [In] ref MapCollision mapCollision,
      [In] ref PathfindingTerrainData agentTerrainData,
      [In] ref MiscAiGameplayData miscAiGameplayData,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref agentTerrainData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref miscAiGameplayData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_PathfindingLineOfSight_Public_Static_Boolean_float3_float3_byref_MapCollision_byref_PathfindingTerrainData_byref_MiscAiGameplayData_byref_BehaviourTreeJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1342590, RefRangeEnd = 1342592, XrefRangeStart = 1342589, XrefRangeEnd = 1342590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindFirstWalkable(
      float3 start,
      float3 end,
      float mapCollisionRadius,
      [In] ref PathfindingTerrainData agentTerrainData,
      ref BehaviourTreeJobData jobData,
      out float3 result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mapCollisionRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref agentTerrainData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_TryFindFirstWalkable_Public_Static_Boolean_float3_float3_Single_byref_PathfindingTerrainData_byref_BehaviourTreeJobData_byref_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1342596, RefRangeEnd = 1342599, XrefRangeStart = 1342592, XrefRangeEnd = 1342596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetIndexOf(
      ref BehaviourTreeNode node,
      ushort childNodeIndex,
      out int result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref node;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &childNodeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_TryGetIndexOf_Public_Static_Boolean_byref_BehaviourTreeNode_UInt16_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1342622, RefRangeEnd = 1342625, XrefRangeStart = 1342599, XrefRangeEnd = 1342622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreatePathRequest(
      Entity owner,
      PathfindingSolver solver,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      int maxExpansionsOverride = -1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &solver;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxExpansionsOverride;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_CreatePathRequest_Public_Static_Entity_Entity_PathfindingSolver_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342625, XrefRangeEnd = 1342638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreatePathRequestEntity(
      EntityCommandBuffer.ParallelWriter commandBuffer,
      int jobIndex,
      [In] ref PathRequest pathRequest)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pathRequest;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_CreatePathRequestEntity_Private_Static_Entity_ParallelWriter_Int32_byref_PathRequest_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342651, RefRangeEnd = 1342652, XrefRangeStart = 1342638, XrefRangeEnd = 1342651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeResult FindPathToPosition_Initialize(
      float3 pos,
      int requestEntityBlackboardIndex,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      int maxExpansionsOverride = -1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &requestEntityBlackboardIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxExpansionsOverride;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_FindPathToPosition_Initialize_Public_Static_BehaviourTreeResult_float3_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342671, RefRangeEnd = 1342672, XrefRangeStart = 1342652, XrefRangeEnd = 1342671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeUtility.FindPathToPositionTickResult FindPathToPosition_Tick(
      int pathRequestRegisterIndex,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &pathRequestRegisterIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_FindPathToPosition_Tick_Public_Static_FindPathToPositionTickResult_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeUtility.FindPathToPositionTickResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342688, RefRangeEnd = 1342689, XrefRangeStart = 1342672, XrefRangeEnd = 1342688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindPathToPosition_Abort(
      int pathRequestRegisterIndex,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &pathRequestRegisterIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_FindPathToPosition_Abort_Public_Static_Void_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1342704, RefRangeEnd = 1342707, XrefRangeStart = 1342689, XrefRangeEnd = 1342704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetRandomTileInArea(
      float3 pos,
      float2 radius,
      ref BehaviourTreeJobData jobData,
      out float3 result,
      int maxTries = 10)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxTries;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_TryGetRandomTileInArea_Public_Static_Boolean_float3_float2_byref_BehaviourTreeJobData_byref_float3_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342717, RefRangeEnd = 1342718, XrefRangeStart = 1342707, XrefRangeEnd = 1342717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetMoveSpeed(
      ref BehaviourTreeJobData jobData,
      [In] ref BehaviourTreeExpansionContext context,
      float moveSpeed)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &moveSpeed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_SetMoveSpeed_Public_Static_Void_byref_BehaviourTreeJobData_byref_BehaviourTreeExpansionContext_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1342730, RefRangeEnd = 1342734, XrefRangeStart = 1342718, XrefRangeEnd = 1342730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsBlocked(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData,
      [In] ref float3 subjectPosition,
      [In] ref float2 direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref subjectPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_IsBlocked_Internal_Static_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_float3_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe BehaviourTreeResult ParseBool(bool value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.NativeMethodInfoPtr_ParseBool_Public_Static_BehaviourTreeResult_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void Serialize<T>(T value, void* ptr)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ptr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.MethodInfoStoreGeneric_Serialize_Public_Static_Void_T_ptr_Void_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1342737, RefRangeEnd = 1342738, XrefRangeStart = 1342734, XrefRangeEnd = 1342737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStructArray<byte> Serialize<T>(T value)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.MethodInfoStoreGeneric_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static ref T Deserialize<T>(void* ptr)
    {
      // ISSUE: unable to decompile the method.
    }

    static BehaviourTreeUtility()
    {
      Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr);
      BehaviourTreeUtility.NativeMethodInfoPtr_LineOfSight_Public_Static_Boolean_float3_float3_byref_MapCollision_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665252);
      BehaviourTreeUtility.NativeMethodInfoPtr_PathfindingLineOfSight_Public_Static_Boolean_float3_float3_byref_MapCollision_byref_PathfindingTerrainData_byref_MiscAiGameplayData_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665253);
      BehaviourTreeUtility.NativeMethodInfoPtr_TryFindFirstWalkable_Public_Static_Boolean_float3_float3_Single_byref_PathfindingTerrainData_byref_BehaviourTreeJobData_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665254);
      BehaviourTreeUtility.NativeMethodInfoPtr_TryGetIndexOf_Public_Static_Boolean_byref_BehaviourTreeNode_UInt16_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665255);
      BehaviourTreeUtility.NativeMethodInfoPtr_CreatePathRequest_Public_Static_Entity_Entity_PathfindingSolver_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665256);
      BehaviourTreeUtility.NativeMethodInfoPtr_CreatePathRequestEntity_Private_Static_Entity_ParallelWriter_Int32_byref_PathRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665257);
      BehaviourTreeUtility.NativeMethodInfoPtr_FindPathToPosition_Initialize_Public_Static_BehaviourTreeResult_float3_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665258);
      BehaviourTreeUtility.NativeMethodInfoPtr_FindPathToPosition_Tick_Public_Static_FindPathToPositionTickResult_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665259);
      BehaviourTreeUtility.NativeMethodInfoPtr_FindPathToPosition_Abort_Public_Static_Void_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665260);
      BehaviourTreeUtility.NativeMethodInfoPtr_TryGetRandomTileInArea_Public_Static_Boolean_float3_float2_byref_BehaviourTreeJobData_byref_float3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665261);
      BehaviourTreeUtility.NativeMethodInfoPtr_SetMoveSpeed_Public_Static_Void_byref_BehaviourTreeJobData_byref_BehaviourTreeExpansionContext_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665262);
      BehaviourTreeUtility.NativeMethodInfoPtr_IsBlocked_Internal_Static_Boolean_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_float3_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665263);
      BehaviourTreeUtility.NativeMethodInfoPtr_ParseBool_Public_Static_BehaviourTreeResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665264);
      BehaviourTreeUtility.NativeMethodInfoPtr_Serialize_Public_Static_Void_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665265);
      BehaviourTreeUtility.NativeMethodInfoPtr_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665266);
      BehaviourTreeUtility.NativeMethodInfoPtr_Deserialize_Public_Static_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, 100665267);
    }

    public BehaviourTreeUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static class Abilities : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityStateBuffer_Public_Static_Boolean_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_DynamicBuffer_1_AbilityStateBuffer_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1342582, RefRangeEnd = 1342583, XrefRangeStart = 1342574, XrefRangeEnd = 1342582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryGetAbilityStateBuffer(
        int abilityIndex,
        ref BehaviourTreeExpansionContext context,
        ref BehaviourTreeJobData jobData,
        out DynamicBuffer<AbilityStateBuffer> result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &abilityIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeUtility.Abilities.NativeMethodInfoPtr_TryGetAbilityStateBuffer_Public_Static_Boolean_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_DynamicBuffer_1_AbilityStateBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Abilities()
      {
        Il2CppClassPointerStore<BehaviourTreeUtility.Abilities>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, nameof (Abilities));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeUtility.Abilities>.NativeClassPtr);
        BehaviourTreeUtility.Abilities.NativeMethodInfoPtr_TryGetAbilityStateBuffer_Public_Static_Boolean_Int32_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_byref_DynamicBuffer_1_AbilityStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeUtility.Abilities>.NativeClassPtr, 100665268);
      }

      public Abilities(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FindPathToPositionTickResult
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeFieldInfoPtr_FailedDueToRequestDestroyed;
      [FieldOffset(0)]
      public BehaviourTreeResult Result;
      [FieldOffset(4)]
      public bool FailedDueToRequestDestroyed;

      static FindPathToPositionTickResult()
      {
        Il2CppClassPointerStore<BehaviourTreeUtility.FindPathToPositionTickResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr, nameof (FindPathToPositionTickResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeUtility.FindPathToPositionTickResult>.NativeClassPtr);
        BehaviourTreeUtility.FindPathToPositionTickResult.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeUtility.FindPathToPositionTickResult>.NativeClassPtr, nameof (Result));
        BehaviourTreeUtility.FindPathToPositionTickResult.NativeFieldInfoPtr_FailedDueToRequestDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeUtility.FindPathToPositionTickResult>.NativeClassPtr, nameof (FailedDueToRequestDestroyed));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeUtility.FindPathToPositionTickResult>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    private sealed class MethodInfoStoreGeneric_Serialize_Public_Static_Void_T_ptr_Void_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeUtility.NativeMethodInfoPtr_Serialize_Public_Static_Void_T_ptr_Void_0, Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeUtility.NativeMethodInfoPtr_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_0, Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Deserialize_Public_Static_byref_T_ptr_Void_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BehaviourTreeUtility.NativeMethodInfoPtr_Deserialize_Public_Static_byref_T_ptr_Void_0, Il2CppClassPointerStore<BehaviourTreeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
