// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.ApplyPlacementResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public static class ApplyPlacementResult : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_ApplyResult_byref_PlacementResult_Nullable_Unboxed_1_ControlledBy_JobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_Nullable_Unboxed_1_ControlledBy_NativeHashMap_2_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTeamForReference_Private_Static_Boolean_Entity_ComponentDataFromEntity_1_TeamReference_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupAttachments_Private_Static_Void_byref_JobData_byref_PlacementResult_NativeHashMap_2_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityOrPrefab_Private_Static_Entity_PlacementEntityId_NativeList_1_CreateTileModelData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityId_Private_Static_Entity_PlacementEntityId_NativeHashMap_2_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1130463, RefRangeEnd = 1130471, XrefRangeStart = 1130444, XrefRangeEnd = 1130463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ApplyPlacementResult.ApplyResult Execute(
      [In] ref PlacementResult placementResult,
      Nullable_Unboxed<ControlledBy> controlledBy,
      ApplyPlacementResult.JobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref placementResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controlledBy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.NativeMethodInfoPtr_Execute_Public_Static_ApplyResult_byref_PlacementResult_Nullable_Unboxed_1_ControlledBy_JobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ApplyPlacementResult.ApplyResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1130797, RefRangeEnd = 1130798, XrefRangeStart = 1130471, XrefRangeEnd = 1130797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateTileModels(
      ref ApplyPlacementResult.JobData jobData,
      [In] ref PlacementResult result,
      Nullable_Unboxed<ControlledBy> controlledBy,
      NativeHashMap<int, Entity> entityIdFromCreateDataIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controlledBy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityIdFromCreateDataIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.NativeMethodInfoPtr_CreateTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_Nullable_Unboxed_1_ControlledBy_NativeHashMap_2_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1130847, RefRangeEnd = 1130848, XrefRangeStart = 1130798, XrefRangeEnd = 1130847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void MoveTileModels(
      ref ApplyPlacementResult.JobData jobData,
      [In] ref PlacementResult result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.NativeMethodInfoPtr_MoveTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1130848, XrefRangeEnd = 1130853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetTeamForReference(
      Entity entity,
      ComponentDataFromEntity<TeamReference> teamReferenceFromEntity,
      out Entity teamEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &teamReferenceFromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref teamEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.NativeMethodInfoPtr_TryGetTeamForReference_Private_Static_Boolean_Entity_ComponentDataFromEntity_1_TeamReference_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1131114, RefRangeEnd = 1131115, XrefRangeStart = 1130853, XrefRangeEnd = 1131114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetupAttachments(
      ref ApplyPlacementResult.JobData jobData,
      [In] ref PlacementResult result,
      NativeHashMap<int, Entity> entityIdFromCreateDataIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityIdFromCreateDataIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.NativeMethodInfoPtr_SetupAttachments_Private_Static_Void_byref_JobData_byref_PlacementResult_NativeHashMap_2_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1131124, RefRangeEnd = 1131126, XrefRangeStart = 1131115, XrefRangeEnd = 1131124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetEntityOrPrefab(
      PlacementEntityId placementEntityId,
      NativeList<CreateTileModelData> tileModelsToCreate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &placementEntityId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelsToCreate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.NativeMethodInfoPtr_GetEntityOrPrefab_Private_Static_Entity_PlacementEntityId_NativeList_1_CreateTileModelData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1131135, RefRangeEnd = 1131137, XrefRangeStart = 1131126, XrefRangeEnd = 1131135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetEntityId(
      PlacementEntityId childEntityToAttach,
      NativeHashMap<int, Entity> entityIdFromCreateDataIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &childEntityToAttach;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityIdFromCreateDataIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.NativeMethodInfoPtr_GetEntityId_Private_Static_Entity_PlacementEntityId_NativeHashMap_2_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1131170, RefRangeEnd = 1131171, XrefRangeStart = 1131137, XrefRangeEnd = 1131170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyTileModels(
      ref ApplyPlacementResult.JobData jobData,
      [In] ref PlacementResult result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.NativeMethodInfoPtr_DestroyTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ApplyPlacementResult()
    {
      Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (ApplyPlacementResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr);
      ApplyPlacementResult.NativeMethodInfoPtr_Execute_Public_Static_ApplyResult_byref_PlacementResult_Nullable_Unboxed_1_ControlledBy_JobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, 100689812);
      ApplyPlacementResult.NativeMethodInfoPtr_CreateTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_Nullable_Unboxed_1_ControlledBy_NativeHashMap_2_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, 100689813);
      ApplyPlacementResult.NativeMethodInfoPtr_MoveTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, 100689814);
      ApplyPlacementResult.NativeMethodInfoPtr_TryGetTeamForReference_Private_Static_Boolean_Entity_ComponentDataFromEntity_1_TeamReference_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, 100689815);
      ApplyPlacementResult.NativeMethodInfoPtr_SetupAttachments_Private_Static_Void_byref_JobData_byref_PlacementResult_NativeHashMap_2_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, 100689816);
      ApplyPlacementResult.NativeMethodInfoPtr_GetEntityOrPrefab_Private_Static_Entity_PlacementEntityId_NativeList_1_CreateTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, 100689817);
      ApplyPlacementResult.NativeMethodInfoPtr_GetEntityId_Private_Static_Entity_PlacementEntityId_NativeHashMap_2_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, 100689818);
      ApplyPlacementResult.NativeMethodInfoPtr_DestroyTileModels_Private_Static_Void_byref_JobData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, 100689819);
    }

    public ApplyPlacementResult(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct JobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetUserOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTeamReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBlueprintData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleAreaRequirement;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeart;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleTerritory;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLastTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetStaticTransformCompatible;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDismantleDestroyData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPlacementDestroyData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDestroyAfterDuration;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachedChildrenBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachToParentsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeartConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetUserHeartCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetServantCoffinstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPylonstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleLimited;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDyeableCastleObject;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedChild;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleBuildingFusedChildrenBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToCreate;
      private static readonly System.IntPtr NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToMove;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedSequencePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_DestroyCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsDismantleOperation;
      [FieldOffset(0)]
      public SyncedServerDebugSettings ServerDebugSettings;
      [FieldOffset(40)]
      public ComponentDataFromEntity<UserOwner> GetUserOwner;
      [FieldOffset(72)]
      public ComponentDataFromEntity<Team> GetTeam;
      [FieldOffset(104)]
      public ComponentDataFromEntity<TeamReference> GetTeamReference;
      [FieldOffset(136)]
      public ComponentDataFromEntity<BlueprintData> GetBlueprintData;
      [FieldOffset(168)]
      public ComponentDataFromEntity<CastleAreaRequirement> GetCastleAreaRequirement;
      [FieldOffset(200)]
      public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
      [FieldOffset(232)]
      public ComponentDataFromEntity<CastleHeart> GetCastleHeart;
      [FieldOffset(264)]
      public ComponentDataFromEntity<CastleTerritory> GetCastleTerritory;
      [FieldOffset(296)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(328)]
      public ComponentDataFromEntity<LastTranslation> GetLastTranslation;
      [FieldOffset(360)]
      public ComponentDataFromEntity<Rotation> GetRotation;
      [FieldOffset(392)]
      public ComponentDataFromEntity<StaticTransformCompatible> GetStaticTransformCompatible;
      [FieldOffset(424)]
      public ComponentDataFromEntity<DismantleDestroyData> GetDismantleDestroyData;
      [FieldOffset(456)]
      public ComponentDataFromEntity<PlacementDestroyData> GetPlacementDestroyData;
      [FieldOffset(488)]
      public ComponentDataFromEntity<DestroyAfterDurationCounter> GetDestroyAfterDuration;
      [FieldOffset(520)]
      public BufferFromEntity<CastleBuildingAttachedChildrenBuffer> GetAttachedChildrenBuffer;
      [FieldOffset(560)]
      public BufferFromEntity<CastleBuildingAttachToParentsBuffer> GetAttachToParentsBuffer;
      [FieldOffset(600)]
      public ComponentDataFromEntity<CastleHeartConnection> GetCastleHeartConnection;
      [FieldOffset(632)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(664)]
      public ComponentDataFromEntity<UserHeartCount> GetUserHeartCount;
      [FieldOffset(696)]
      public ComponentDataFromEntity<ServantCoffinstation> GetServantCoffinstation;
      [FieldOffset(728)]
      public ComponentDataFromEntity<Pylonstation> GetPylonstation;
      [FieldOffset(760)]
      public ComponentDataFromEntity<CastleLimited> GetCastleLimited;
      [FieldOffset(792)]
      public ComponentDataFromEntity<DyeableCastleObject> GetDyeableCastleObject;
      [FieldOffset(824)]
      public ComponentDataFromEntity<CastleBuildingFusedChild> GetCastleBuildingFusedChild;
      [FieldOffset(856)]
      public BufferFromEntity<CastleBuildingFusedChildrenBuffer> GetCastleBuildingFusedChildrenBuffer;
      [FieldOffset(896)]
      public NativeList<CreateTileModelData> ApplyPlacementHistoryTileModelsToCreate;
      [FieldOffset(912)]
      public NativeList<MoveTileModelData> ApplyPlacementHistoryTileModelsToMove;
      [FieldOffset(928)]
      public Entity NetworkedSequencePrefab;
      [FieldOffset(936)]
      public EntityCommandBuffer SpawnCommandBuffer;
      [FieldOffset(952)]
      public EntityCommandBuffer DestroyCommandBuffer;
      [FieldOffset(968)]
      public bool IsDismantleOperation;

      static JobData()
      {
        Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, nameof (JobData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr);
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (ServerDebugSettings));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetUserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetUserOwner));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetTeam));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetTeamReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetTeamReference));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetBlueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetBlueprintData));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetCastleAreaRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleAreaRequirement));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetPrefabGUID));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleHeart));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetCastleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleTerritory));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetTranslation));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetLastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetLastTranslation));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetRotation));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetStaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetStaticTransformCompatible));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetDismantleDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetDismantleDestroyData));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetPlacementDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetPlacementDestroyData));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetDestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetDestroyAfterDuration));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetAttachedChildrenBuffer));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetAttachToParentsBuffer));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetCastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleHeartConnection));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleFloor));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetUserHeartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetUserHeartCount));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetServantCoffinstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetServantCoffinstation));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetPylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetPylonstation));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetCastleLimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleLimited));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetDyeableCastleObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetDyeableCastleObject));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetCastleBuildingFusedChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleBuildingFusedChild));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_GetCastleBuildingFusedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (GetCastleBuildingFusedChildrenBuffer));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (ApplyPlacementHistoryTileModelsToCreate));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_ApplyPlacementHistoryTileModelsToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (ApplyPlacementHistoryTileModelsToMove));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_NetworkedSequencePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (NetworkedSequencePrefab));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_SpawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (SpawnCommandBuffer));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_DestroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (DestroyCommandBuffer));
        ApplyPlacementResult.JobData.NativeFieldInfoPtr_IsDismantleOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, nameof (IsDismantleOperation));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyPlacementResult.JobData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ApplyResult
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityIdFromCreateDataIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public NativeHashMap<int, Entity> EntityIdFromCreateDataIndex;

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 1130435, RefRangeEnd = 1130444, XrefRangeStart = 1130429, XrefRangeEnd = 1130435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResult.ApplyResult.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ApplyResult()
      {
        Il2CppClassPointerStore<ApplyPlacementResult.ApplyResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, nameof (ApplyResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyPlacementResult.ApplyResult>.NativeClassPtr);
        ApplyPlacementResult.ApplyResult.NativeFieldInfoPtr_EntityIdFromCreateDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.ApplyResult>.NativeClassPtr, nameof (EntityIdFromCreateDataIndex));
        ApplyPlacementResult.ApplyResult.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResult.ApplyResult>.NativeClassPtr, 100689820);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyPlacementResult.ApplyResult>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VariationData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Index;
      [FieldOffset(0)]
      public byte Index;

      static VariationData()
      {
        Il2CppClassPointerStore<ApplyPlacementResult.VariationData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ApplyPlacementResult>.NativeClassPtr, nameof (VariationData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyPlacementResult.VariationData>.NativeClassPtr);
        ApplyPlacementResult.VariationData.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyPlacementResult.VariationData>.NativeClassPtr, nameof (Index));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyPlacementResult.VariationData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
