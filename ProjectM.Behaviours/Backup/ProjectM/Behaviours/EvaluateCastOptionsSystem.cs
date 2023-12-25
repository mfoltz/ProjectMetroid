// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EvaluateCastOptionsSystem
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Behaviours
{
  public class EvaluateCastOptionsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_TIMEOUT_FRAMES;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEG_135;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEG_90;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEG_45;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEG_10;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionDetectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr___Cleanup_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Cleanup_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___Evaluation_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Evaluation_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindStateEntity_Private_Static_Entity_EntityManager_byref_EvaluateCastOptionsRequest_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindCandidate_Private_Static_Void_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateGroup_Private_Static_Boolean_EntityManager_Entity_byref_EvaluateCastOptionsRequest_byref_JobParams_NativeList_1_CastResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SuccessDelay_Private_Static_Void_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCooldown_Private_Static_Single_byref_CastOptionBuffer_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Finish_Private_Static_Void_EntityManager_byref_CastOptionBuffer_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastOption_Private_Static_CastOptionBuffer_EntityManager_byref_EvaluateCastOptionsRequest_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastResults_Private_Static_NativeList_1_CastResult_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_EvaluateCastOptionsRequest_byref_JobParams_NativeList_1_CastResult_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BreakTie_Private_Static_Entity_EntityManager_byref_CastOptionBuffer_NativeList_1_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RandomTieBreaker_Private_Static_Entity_NativeList_1_CastOptionCandidate_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AggroProbabilityTieBreaker_Private_Static_Entity_EntityManager_NativeList_1_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateCandidate_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLineOfSightRequirement_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasLineOfSight_Private_Static_Boolean_EntityManager_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateHardCodedConditions_Private_Static_Boolean_EntityManager_byref_EvaluateCastOptionsRequest_byref_CastOptionBuffer_CastOptionCandidate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAbilityOnCooldown_Private_Static_Boolean_EntityManager_Int32_byref_EvaluateCastOptionsRequest_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurrentAbilityStateEntity_Private_Static_Boolean_EntityManager_Int32_byref_EvaluateCastOptionsRequest_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCleanup_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForEvaluation_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343473, XrefRangeEnd = 1343502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EvaluateCastOptionsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343502, XrefRangeEnd = 1343510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EvaluateCastOptionsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343510, XrefRangeEnd = 1343558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EvaluateCastOptionsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1343576, RefRangeEnd = 1343578, XrefRangeStart = 1343558, XrefRangeEnd = 1343576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity FindStateEntity(
      EntityManager entityManager,
      ref EvaluateCastOptionsRequest request)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_FindStateEntity_Private_Static_Entity_EntityManager_byref_EvaluateCastOptionsRequest_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343578, XrefRangeEnd = 1343594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FindCandidate(
      EntityManager entityManager,
      ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_FindCandidate_Private_Static_Void_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1343636, RefRangeEnd = 1343638, XrefRangeStart = 1343594, XrefRangeEnd = 1343636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EvaluateGroup(
      EntityManager entityManager,
      Entity groupEntity,
      ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams,
      NativeList<CastResult> castResults)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &groupEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &castResults;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_EvaluateGroup_Private_Static_Boolean_EntityManager_Entity_byref_EvaluateCastOptionsRequest_byref_JobParams_NativeList_1_CastResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343638, XrefRangeEnd = 1343674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SuccessDelay(
      EntityManager entityManager,
      ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_SuccessDelay_Private_Static_Void_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe float GetCooldown(
      [In] ref CastOptionBuffer castOption,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref castOption;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_GetCooldown_Private_Static_Single_byref_CastOptionBuffer_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1343682, RefRangeEnd = 1343683, XrefRangeStart = 1343674, XrefRangeEnd = 1343682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Finish(
      EntityManager entityManager,
      ref CastOptionBuffer castOption,
      ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castOption;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_Finish_Private_Static_Void_EntityManager_byref_CastOptionBuffer_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343683, XrefRangeEnd = 1343689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastOptionBuffer GetCastOption(
      EntityManager entityManager,
      ref EvaluateCastOptionsRequest request)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_GetCastOption_Private_Static_CastOptionBuffer_EntityManager_byref_EvaluateCastOptionsRequest_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastOptionBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1343696, RefRangeEnd = 1343698, XrefRangeStart = 1343689, XrefRangeEnd = 1343696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<CastResult> GetCastResults(
      EntityManager entityManager,
      [In] ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_GetCastResults_Private_Static_NativeList_1_CastResult_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<CastResult>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1343708, RefRangeEnd = 1343709, XrefRangeStart = 1343698, XrefRangeEnd = 1343708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Evaluate(
      EntityManager entityManager,
      ref CastOptionBuffer castOption,
      ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams,
      NativeList<CastResult> castResults,
      out Entity targetEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castOption;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &castResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_Evaluate_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_EvaluateCastOptionsRequest_byref_JobParams_NativeList_1_CastResult_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343709, XrefRangeEnd = 1343737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity BreakTie(
      EntityManager entityManager,
      [In] ref CastOptionBuffer castOption,
      NativeList<CastOptionCandidate> candidates,
      ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castOption;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &candidates;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_BreakTie_Private_Static_Entity_EntityManager_byref_CastOptionBuffer_NativeList_1_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343737, XrefRangeEnd = 1343743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity RandomTieBreaker(
      NativeList<CastOptionCandidate> candidates,
      [In] ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &candidates;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_RandomTieBreaker_Private_Static_Entity_NativeList_1_CastOptionCandidate_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1343777, RefRangeEnd = 1343778, XrefRangeStart = 1343743, XrefRangeEnd = 1343777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity AggroProbabilityTieBreaker(
      EntityManager entityManager,
      NativeList<CastOptionCandidate> candidates,
      [In] ref EvaluateCastOptionsRequest request,
      [In] ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &candidates;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_AggroProbabilityTieBreaker_Private_Static_Entity_EntityManager_NativeList_1_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1343789, RefRangeEnd = 1343790, XrefRangeStart = 1343778, XrefRangeEnd = 1343789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EvaluateCandidate(
      EntityManager entityManager,
      ref CastOptionBuffer castOption,
      [In] ref CastOptionCandidate candidate,
      ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castOption;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref candidate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_EvaluateCandidate_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343790, XrefRangeEnd = 1343796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EvaluateLineOfSightRequirement(
      EntityManager entityManager,
      [In] ref CastOptionBuffer castOption,
      [In] ref CastOptionCandidate candidate,
      [In] ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castOption;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref candidate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_EvaluateLineOfSightRequirement_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343796, XrefRangeEnd = 1343802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasLineOfSight(
      EntityManager entityManager,
      [In] ref CastOptionCandidate candidate,
      [In] ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref candidate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_HasLineOfSight_Private_Static_Boolean_EntityManager_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1343811, RefRangeEnd = 1343812, XrefRangeStart = 1343802, XrefRangeEnd = 1343811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EvaluateHardCodedConditions(
      EntityManager entityManager,
      ref EvaluateCastOptionsRequest request,
      [In] ref CastOptionBuffer castOption,
      CastOptionCandidate candidate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castOption;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &candidate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_EvaluateHardCodedConditions_Private_Static_Boolean_EntityManager_byref_EvaluateCastOptionsRequest_byref_CastOptionBuffer_CastOptionCandidate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343812, XrefRangeEnd = 1343813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAbilityOnCooldown(
      EntityManager entityManager,
      int abilityIndex,
      ref EvaluateCastOptionsRequest request,
      ref EvaluateCastOptionsSystem.JobParams jobParams)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_IsAbilityOnCooldown_Private_Static_Boolean_EntityManager_Int32_byref_EvaluateCastOptionsRequest_byref_JobParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343813, XrefRangeEnd = 1343814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCurrentAbilityStateEntity(
      EntityManager entityManager,
      int abilityIndex,
      ref EvaluateCastOptionsRequest request,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_TryGetCurrentAbilityStateEntity_Private_Static_Boolean_EntityManager_Int32_byref_EvaluateCastOptionsRequest_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EvaluateCastOptionsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343814, XrefRangeEnd = 1343878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EvaluateCastOptionsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343878, XrefRangeEnd = 1343894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCleanup_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCleanup_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343894, XrefRangeEnd = 1343910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForEvaluation_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr___GetEntityQuery_ForEvaluation_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1343914, RefRangeEnd = 1343915, XrefRangeStart = 1343910, XrefRangeEnd = 1343914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1343919, RefRangeEnd = 1343920, XrefRangeStart = 1343915, XrefRangeEnd = 1343919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EvaluateCastOptionsSystem()
    {
      Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EvaluateCastOptionsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr);
      EvaluateCastOptionsSystem.NativeFieldInfoPtr_REQUEST_TIMEOUT_FRAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (REQUEST_TIMEOUT_FRAMES));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_135 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (DEG_135));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_90 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (DEG_90));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (DEG_45));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (DEG_10));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr__CollisionDetectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (_CollisionDetectionSystem));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr__PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (_PostUpdateBarrier));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (_ServerTime));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (_WorldFrame));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      EvaluateCastOptionsSystem.NativeFieldInfoPtr___Cleanup_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, "<>Cleanup_entityQuery");
      EvaluateCastOptionsSystem.NativeFieldInfoPtr___Cleanup_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, "<>Cleanup_profilerMarker");
      EvaluateCastOptionsSystem.NativeFieldInfoPtr___Evaluation_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, "<>Evaluation_entityQuery");
      EvaluateCastOptionsSystem.NativeFieldInfoPtr___Evaluation_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, "<>Evaluation_profilerMarker");
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665320);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665321);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665322);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_FindStateEntity_Private_Static_Entity_EntityManager_byref_EvaluateCastOptionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665323);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_FindCandidate_Private_Static_Void_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665324);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_EvaluateGroup_Private_Static_Boolean_EntityManager_Entity_byref_EvaluateCastOptionsRequest_byref_JobParams_NativeList_1_CastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665325);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_SuccessDelay_Private_Static_Void_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665326);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_GetCooldown_Private_Static_Single_byref_CastOptionBuffer_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665327);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_Finish_Private_Static_Void_EntityManager_byref_CastOptionBuffer_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665328);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_GetCastOption_Private_Static_CastOptionBuffer_EntityManager_byref_EvaluateCastOptionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665329);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_GetCastResults_Private_Static_NativeList_1_CastResult_EntityManager_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665330);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_Evaluate_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_EvaluateCastOptionsRequest_byref_JobParams_NativeList_1_CastResult_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665331);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_BreakTie_Private_Static_Entity_EntityManager_byref_CastOptionBuffer_NativeList_1_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665332);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_RandomTieBreaker_Private_Static_Entity_NativeList_1_CastOptionCandidate_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665333);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_AggroProbabilityTieBreaker_Private_Static_Entity_EntityManager_NativeList_1_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665334);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_EvaluateCandidate_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665335);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_EvaluateLineOfSightRequirement_Private_Static_Boolean_EntityManager_byref_CastOptionBuffer_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665336);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_HasLineOfSight_Private_Static_Boolean_EntityManager_byref_CastOptionCandidate_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665337);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_EvaluateHardCodedConditions_Private_Static_Boolean_EntityManager_byref_EvaluateCastOptionsRequest_byref_CastOptionBuffer_CastOptionCandidate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665338);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_IsAbilityOnCooldown_Private_Static_Boolean_EntityManager_Int32_byref_EvaluateCastOptionsRequest_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665339);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_TryGetCurrentAbilityStateEntity_Private_Static_Boolean_EntityManager_Int32_byref_EvaluateCastOptionsRequest_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665340);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665341);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665342);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCleanup_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665343);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr___GetEntityQuery_ForEvaluation_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665344);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665345);
      EvaluateCastOptionsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, 100665346);
    }

    public EvaluateCastOptionsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int REQUEST_TIMEOUT_FRAMES
    {
      get
      {
        int requestTimeoutFrames;
        IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_REQUEST_TIMEOUT_FRAMES, (void*) &requestTimeoutFrames);
        return requestTimeoutFrames;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_REQUEST_TIMEOUT_FRAMES, (void*) &value);
      }
    }

    public static unsafe int DEG_135
    {
      get
      {
        int deg135;
        IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_135, (void*) &deg135);
        return deg135;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_135, (void*) &value);
      }
    }

    public static unsafe int DEG_90
    {
      get
      {
        int deg90;
        IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_90, (void*) &deg90);
        return deg90;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_90, (void*) &value);
      }
    }

    public static unsafe int DEG_45
    {
      get
      {
        int deg45;
        IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_45, (void*) &deg45);
        return deg45;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_45, (void*) &value);
      }
    }

    public static unsafe int DEG_10
    {
      get
      {
        int deg10;
        IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_10, (void*) &deg10);
        return deg10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.NativeFieldInfoPtr_DEG_10, (void*) &value);
      }
    }

    public unsafe CollisionDetectionSystem_Server _CollisionDetectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__CollisionDetectionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionDetectionSystem_Server) null : new CollisionDetectionSystem_Server(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__CollisionDetectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PostUpdateBarrier _PostUpdateBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__PostUpdateBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__PostUpdateBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __Cleanup_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr___Cleanup_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr___Cleanup_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Cleanup_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr___Cleanup_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr___Cleanup_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __Evaluation_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr___Evaluation_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr___Evaluation_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Evaluation_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr___Evaluation_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsSystem.NativeFieldInfoPtr___Evaluation_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct JobParams
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GetHealth;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameplayConditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_Collision;
      private static readonly System.IntPtr NativeFieldInfoPtr_Random;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_Frame;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Health> GetHealth;
      [FieldOffset(32)]
      public TileWorld TileWorld;
      [FieldOffset(56)]
      public ConditionChecker GameplayConditionChecker;
      [FieldOffset(2256)]
      public CollisionDetection Collision;
      [FieldOffset(2272)]
      public Unity.Mathematics.Random Random;
      [FieldOffset(2280)]
      public double ServerTime;
      [FieldOffset(2288)]
      public float DeltaTime;
      [FieldOffset(2292)]
      public int Frame;

      static JobParams()
      {
        Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, nameof (JobParams));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr);
        EvaluateCastOptionsSystem.JobParams.NativeFieldInfoPtr_GetHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, nameof (GetHealth));
        EvaluateCastOptionsSystem.JobParams.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, nameof (TileWorld));
        EvaluateCastOptionsSystem.JobParams.NativeFieldInfoPtr_GameplayConditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, nameof (GameplayConditionChecker));
        EvaluateCastOptionsSystem.JobParams.NativeFieldInfoPtr_Collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, nameof (Collision));
        EvaluateCastOptionsSystem.JobParams.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, nameof (Random));
        EvaluateCastOptionsSystem.JobParams.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, nameof (ServerTime));
        EvaluateCastOptionsSystem.JobParams.NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, nameof (DeltaTime));
        EvaluateCastOptionsSystem.JobParams.NativeFieldInfoPtr_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, nameof (Frame));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsSystem.JobParams>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.EvaluateCastOptionsSystem/<>c__DisplayClass14_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass14_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_frame;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobParams;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EvaluateCastOptionsRequest_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_EvaluateCastOptionsRequest_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public int frame;
      [FieldOffset(16)]
      public EntityCommandBuffer postUpdateCommandBuffer;
      [FieldOffset(32)]
      public EvaluateCastOptionsSystem.JobParams jobParams;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass14_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, ref EvaluateCastOptionsRequest request)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EvaluateCastOptionsRequest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(ref EvaluateCastOptionsRequest request)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref request;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_EvaluateCastOptionsRequest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass14_0()
      {
        Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, "<>c__DisplayClass14_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr);
        EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr, nameof (entityManager));
        EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr, nameof (frame));
        EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_jobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr, nameof (jobParams));
        EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr, 100665347);
        EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EvaluateCastOptionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr, 100665348);
        EvaluateCastOptionsSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_EvaluateCastOptionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr, 100665349);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass14_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.EvaluateCastOptionsSystem/ProjectM.Behaviours.<>c__DisplayClass_Cleanup")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Cleanup
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_frame;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EvaluateCastOptionsRequest_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public int frame;
      [FieldOffset(16)]
      public EntityCommandBuffer postUpdateCommandBuffer;
      [FieldOffset(32)]
      public EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343325, XrefRangeEnd = 1343335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref EvaluateCastOptionsRequest request)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref request;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EvaluateCastOptionsRequest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1343335, RefRangeEnd = 1343337, XrefRangeStart = 1343335, XrefRangeEnd = 1343335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref EvaluateCastOptionsSystem.__c__DisplayClass14_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1343337, RefRangeEnd = 1343339, XrefRangeStart = 1343337, XrefRangeEnd = 1343337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref EvaluateCastOptionsSystem.__c__DisplayClass14_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343339, XrefRangeEnd = 1343341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1343347, RefRangeEnd = 1343348, XrefRangeStart = 1343341, XrefRangeEnd = 1343347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1343350, RefRangeEnd = 1343351, XrefRangeStart = 1343348, XrefRangeEnd = 1343350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        EvaluateCastOptionsSystem componentSystem,
        ref EvaluateCastOptionsSystem.__c__DisplayClass14_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_byref___c__DisplayClass14_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343351, XrefRangeEnd = 1343355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343355, XrefRangeEnd = 1343361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Cleanup()
      {
        Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, "<>c__DisplayClass_Cleanup");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr);
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, nameof (entityManager));
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, nameof (frame));
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, nameof (_runtimes));
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EvaluateCastOptionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, 100665350);
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, 100665351);
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, 100665352);
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, 100665353);
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, 100665354);
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, 100665355);
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, 100665356);
        EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, 100665357);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_request;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<EvaluateCastOptionsRequest> forParameter_request;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1343244, RefRangeEnd = 1343245, XrefRangeStart = 1343240, XrefRangeEnd = 1343244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(EvaluateCastOptionsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1343249, RefRangeEnd = 1343250, XrefRangeStart = 1343245, XrefRangeEnd = 1343249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_request));
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders>.NativeClassPtr, 100665358);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders>.NativeClassPtr, 100665359);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_request;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EvaluateCastOptionsRequest>.Runtime runtime_request;

          static Runtimes()
          {
            Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_request));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.EvaluateCastOptionsSystem/ProjectM.Behaviours.<>c__DisplayClass_Cleanup/ProjectM.Behaviours.RunWithoutJobSystem_0000065A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, "RunWithoutJobSystem_0000065A$PostfixBurstDelegate");
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665360);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665361);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665362);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665363);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.EvaluateCastOptionsSystem/ProjectM.Behaviours.<>c__DisplayClass_Cleanup/ProjectM.Behaviours.RunWithoutJobSystem_0000065A$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343250, XrefRangeEnd = 1343264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343264, XrefRangeEnd = 1343282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343282, XrefRangeEnd = 1343297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1343324, RefRangeEnd = 1343325, XrefRangeStart = 1343297, XrefRangeEnd = 1343324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup>.NativeClassPtr, "RunWithoutJobSystem_0000065A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665364);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665365);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665366);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665367);
          EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665369);
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
            IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.__c__DisplayClass_Cleanup.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.EvaluateCastOptionsSystem/ProjectM.Behaviours.<>c__DisplayClass_Evaluation")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Evaluation
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobParams;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_EvaluateCastOptionsRequest_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public EvaluateCastOptionsSystem.JobParams jobParams;
      [FieldOffset(2304)]
      public EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(2336)]
      public unsafe EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343444, XrefRangeEnd = 1343448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref EvaluateCastOptionsRequest request)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref request;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_EvaluateCastOptionsRequest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1343449, RefRangeEnd = 1343450, XrefRangeStart = 1343448, XrefRangeEnd = 1343449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref EvaluateCastOptionsSystem.__c__DisplayClass14_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1343451, RefRangeEnd = 1343452, XrefRangeStart = 1343450, XrefRangeEnd = 1343451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref EvaluateCastOptionsSystem.__c__DisplayClass14_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343452, XrefRangeEnd = 1343454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1343459, RefRangeEnd = 1343460, XrefRangeStart = 1343454, XrefRangeEnd = 1343459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1343462, RefRangeEnd = 1343463, XrefRangeStart = 1343460, XrefRangeEnd = 1343462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        EvaluateCastOptionsSystem componentSystem,
        ref EvaluateCastOptionsSystem.__c__DisplayClass14_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_byref___c__DisplayClass14_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343463, XrefRangeEnd = 1343467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343467, XrefRangeEnd = 1343473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Evaluation()
      {
        Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem>.NativeClassPtr, "<>c__DisplayClass_Evaluation");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr);
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, nameof (entityManager));
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr_jobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, nameof (jobParams));
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, nameof (_runtimes));
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_EvaluateCastOptionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, 100665370);
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, 100665371);
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, 100665372);
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, 100665373);
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, 100665374);
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, 100665375);
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, 100665376);
        EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, 100665377);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_request;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<EvaluateCastOptionsRequest> forParameter_request;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1343364, RefRangeEnd = 1343365, XrefRangeStart = 1343361, XrefRangeEnd = 1343364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(EvaluateCastOptionsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1343368, RefRangeEnd = 1343369, XrefRangeStart = 1343365, XrefRangeEnd = 1343368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_request));
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EvaluateCastOptionsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders>.NativeClassPtr, 100665378);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders>.NativeClassPtr, 100665379);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_request;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<EvaluateCastOptionsRequest>.Runtime runtime_request;

          static Runtimes()
          {
            Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_request));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.EvaluateCastOptionsSystem/ProjectM.Behaviours.<>c__DisplayClass_Evaluation/ProjectM.Behaviours.RunWithoutJobSystem_00000663$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, "RunWithoutJobSystem_00000663$PostfixBurstDelegate");
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665380);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665381);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665382);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665383);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.EvaluateCastOptionsSystem/ProjectM.Behaviours.<>c__DisplayClass_Evaluation/ProjectM.Behaviours.RunWithoutJobSystem_00000663$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343369, XrefRangeEnd = 1343383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343383, XrefRangeEnd = 1343401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343401, XrefRangeEnd = 1343416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1343443, RefRangeEnd = 1343444, XrefRangeStart = 1343416, XrefRangeEnd = 1343443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation>.NativeClassPtr, "RunWithoutJobSystem_00000663$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665384);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665385);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665386);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665387);
          EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665389);
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
            IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(EvaluateCastOptionsSystem.__c__DisplayClass_Evaluation.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
