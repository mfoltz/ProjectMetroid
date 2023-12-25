// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStormRegionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.LightningStorm
{
  public class LightningStormRegionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__FrameLightningStrikes;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__LightningStormCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrierSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameplayAttractors;
    private static readonly System.IntPtr NativeFieldInfoPtr__AmbienceAttractors;
    private static readonly System.IntPtr NativeFieldInfoPtr__LightningConsumers;
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDurationBetweenStrikes;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDurationBetweenStrikes;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupLightningStrikes_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupLightningStrikes_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob3_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob3_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob4_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddSceneDependencies_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddSceneDependencies_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_56;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupLightningStrikes_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyStrikeDuration_Private_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessLightningStrikes_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStrikePosition_Private_Static_float3_byref_float2_byref_PolygonRegionBlob_byref_LightningStrikeData_byref_CollisionWorld_byref_MapData_byref_NativeList_1_AttractorData_byref_NativeList_1_AttractorData_byref_NativeList_1_ConsumerData_byref_Random_Single_byref_Entity_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyRepellersInRange_Private_Static_Boolean_float2_byref_PolygonRegionBlob_byref_NativeList_1_AttractorData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAttractorsInRange_Private_Static_NativeList_1_AttractorData_float2_byref_PolygonRegionBlob_byref_NativeList_1_AttractorData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustStrikePosition_Private_Static_Void_byref_float2_byref_LightningStrikeData_byref_NativeList_1_AttractorData_byref_Random_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckStrikeConsumers_Private_Static_Void_byref_float2_byref_LightningStrikeData_byref_PolygonRegionBlob_byref_Entity_byref_NativeList_1_ConsumerData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetupLightningStrikes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAddSceneDependencies_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116090, XrefRangeEnd = 1116132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LightningStormRegionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116132, XrefRangeEnd = 1116144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LightningStormRegionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116144, XrefRangeEnd = 1116150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LightningStormRegionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116174, RefRangeEnd = 1116175, XrefRangeStart = 1116150, XrefRangeEnd = 1116174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupLightningStrikes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_SetupLightningStrikes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1116190, RefRangeEnd = 1116192, XrefRangeStart = 1116175, XrefRangeEnd = 1116190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float VerifyStrikeDuration(float duration)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &duration;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_VerifyStrikeDuration_Private_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116287, RefRangeEnd = 1116288, XrefRangeStart = 1116192, XrefRangeEnd = 1116287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessLightningStrikes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_ProcessLightningStrikes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116308, RefRangeEnd = 1116309, XrefRangeStart = 1116288, XrefRangeEnd = 1116308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetStrikePosition(
      ref float2 strikeCoordinates,
      ref PolygonRegionBlob region,
      ref LightningStrikeData strike,
      ref CollisionWorld collisionWorld,
      ref TileMapCollisionMath.MapData mapData,
      [In] ref NativeList<LightningStormRegionSystem.AttractorData> attractors,
      [In] ref NativeList<LightningStormRegionSystem.AttractorData> repellers,
      [In] ref NativeList<LightningStormRegionSystem.ConsumerData> consumers,
      ref Unity.Mathematics.Random random,
      float originalPositionWeight,
      ref Entity owner,
      out bool abortStrike)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) ref strikeCoordinates;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref region;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref strike;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref attractors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref repellers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &originalPositionWeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref abortStrike;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_GetStrikePosition_Private_Static_float3_byref_float2_byref_PolygonRegionBlob_byref_LightningStrikeData_byref_CollisionWorld_byref_MapData_byref_NativeList_1_AttractorData_byref_NativeList_1_AttractorData_byref_NativeList_1_ConsumerData_byref_Random_Single_byref_Entity_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116332, RefRangeEnd = 1116333, XrefRangeStart = 1116309, XrefRangeEnd = 1116332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AnyRepellersInRange(
      float2 strikePosition,
      ref PolygonRegionBlob region,
      [In] ref NativeList<LightningStormRegionSystem.AttractorData> repellers)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &strikePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref region;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref repellers;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_AnyRepellersInRange_Private_Static_Boolean_float2_byref_PolygonRegionBlob_byref_NativeList_1_AttractorData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116356, RefRangeEnd = 1116357, XrefRangeStart = 1116333, XrefRangeEnd = 1116356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<LightningStormRegionSystem.AttractorData> GetAttractorsInRange(
      float2 strikePosition,
      ref PolygonRegionBlob region,
      [In] ref NativeList<LightningStormRegionSystem.AttractorData> attractors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &strikePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref region;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref attractors;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_GetAttractorsInRange_Private_Static_NativeList_1_AttractorData_float2_byref_PolygonRegionBlob_byref_NativeList_1_AttractorData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<LightningStormRegionSystem.AttractorData>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116397, RefRangeEnd = 1116398, XrefRangeStart = 1116357, XrefRangeEnd = 1116397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AdjustStrikePosition(
      ref float2 strikePosition,
      [In] ref LightningStrikeData strike,
      [In] ref NativeList<LightningStormRegionSystem.AttractorData> attractorsInRange,
      ref Unity.Mathematics.Random random,
      float originalPositionWeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref strikePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref strike;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref attractorsInRange;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &originalPositionWeight;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_AdjustStrikePosition_Private_Static_Void_byref_float2_byref_LightningStrikeData_byref_NativeList_1_AttractorData_byref_Random_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116417, RefRangeEnd = 1116418, XrefRangeStart = 1116398, XrefRangeEnd = 1116417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckStrikeConsumers(
      ref float2 strikePosition,
      ref LightningStrikeData strike,
      ref PolygonRegionBlob region,
      ref Entity owner,
      [In] ref NativeList<LightningStormRegionSystem.ConsumerData> consumers)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref strikePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref strike;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref region;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumers;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_CheckStrikeConsumers_Private_Static_Void_byref_float2_byref_LightningStrikeData_byref_PolygonRegionBlob_byref_Entity_byref_NativeList_1_ConsumerData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddSceneMetadataDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkMetadataLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116418, XrefRangeEnd = 1116432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddSceneDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningStormRegionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116432, XrefRangeEnd = 1116619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LightningStormRegionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116619, XrefRangeEnd = 1116635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetupLightningStrikes_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetupLightningStrikes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116663, RefRangeEnd = 1116664, XrefRangeStart = 1116635, XrefRangeEnd = 1116663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessLightningStrikes_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116692, RefRangeEnd = 1116693, XrefRangeStart = 1116664, XrefRangeEnd = 1116692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessLightningStrikes_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116693, XrefRangeEnd = 1116712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessLightningStrikes_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116712, XrefRangeEnd = 1116731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessLightningStrikes_LambdaJob3_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116731, XrefRangeEnd = 1116747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAddSceneDependencies_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddSceneDependencies_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116751, RefRangeEnd = 1116752, XrefRangeStart = 1116747, XrefRangeEnd = 1116751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116756, RefRangeEnd = 1116757, XrefRangeStart = 1116752, XrefRangeEnd = 1116756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116761, RefRangeEnd = 1116762, XrefRangeStart = 1116757, XrefRangeEnd = 1116761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116766, RefRangeEnd = 1116767, XrefRangeStart = 1116762, XrefRangeEnd = 1116766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116771, RefRangeEnd = 1116772, XrefRangeStart = 1116767, XrefRangeEnd = 1116771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116776, RefRangeEnd = 1116777, XrefRangeStart = 1116772, XrefRangeEnd = 1116776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1116781, RefRangeEnd = 1116782, XrefRangeStart = 1116777, XrefRangeEnd = 1116781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LightningStormRegionSystem()
    {
      Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStormRegionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr);
      LightningStormRegionSystem.NativeFieldInfoPtr__FrameLightningStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_FrameLightningStrikes));
      LightningStormRegionSystem.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_CurveCollectionSystem));
      LightningStormRegionSystem.NativeFieldInfoPtr__LightningStormCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_LightningStormCollectionSystem));
      LightningStormRegionSystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_CollisionSystem));
      LightningStormRegionSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      LightningStormRegionSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      LightningStormRegionSystem.NativeFieldInfoPtr__SpawnBarrierSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_SpawnBarrierSystem));
      LightningStormRegionSystem.NativeFieldInfoPtr__GameplayAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_GameplayAttractors));
      LightningStormRegionSystem.NativeFieldInfoPtr__AmbienceAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_AmbienceAttractors));
      LightningStormRegionSystem.NativeFieldInfoPtr__LightningConsumers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_LightningConsumers));
      LightningStormRegionSystem.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_TilePolygons));
      LightningStormRegionSystem.NativeFieldInfoPtr_MinDurationBetweenStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (MinDurationBetweenStrikes));
      LightningStormRegionSystem.NativeFieldInfoPtr_MaxDurationBetweenStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (MaxDurationBetweenStrikes));
      LightningStormRegionSystem.NativeFieldInfoPtr___SetupLightningStrikes_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>SetupLightningStrikes_LambdaJob0_entityQuery");
      LightningStormRegionSystem.NativeFieldInfoPtr___SetupLightningStrikes_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>SetupLightningStrikes_LambdaJob0_profilerMarker");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob0_entityQuery");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob0_profilerMarker");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob1_entityQuery");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob1_profilerMarker");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob2_entityQuery");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob2_profilerMarker");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob3_entityQuery");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob3_profilerMarker");
      LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob4_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>ProcessLightningStrikes_LambdaJob4_profilerMarker");
      LightningStormRegionSystem.NativeFieldInfoPtr___AddSceneDependencies_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>AddSceneDependencies_LambdaJob0_entityQuery");
      LightningStormRegionSystem.NativeFieldInfoPtr___AddSceneDependencies_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>AddSceneDependencies_LambdaJob0_profilerMarker");
      LightningStormRegionSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_56 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_56));
      LightningStormRegionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688318);
      LightningStormRegionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688319);
      LightningStormRegionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688320);
      LightningStormRegionSystem.NativeMethodInfoPtr_SetupLightningStrikes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688321);
      LightningStormRegionSystem.NativeMethodInfoPtr_VerifyStrikeDuration_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688322);
      LightningStormRegionSystem.NativeMethodInfoPtr_ProcessLightningStrikes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688323);
      LightningStormRegionSystem.NativeMethodInfoPtr_GetStrikePosition_Private_Static_float3_byref_float2_byref_PolygonRegionBlob_byref_LightningStrikeData_byref_CollisionWorld_byref_MapData_byref_NativeList_1_AttractorData_byref_NativeList_1_AttractorData_byref_NativeList_1_ConsumerData_byref_Random_Single_byref_Entity_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688324);
      LightningStormRegionSystem.NativeMethodInfoPtr_AnyRepellersInRange_Private_Static_Boolean_float2_byref_PolygonRegionBlob_byref_NativeList_1_AttractorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688325);
      LightningStormRegionSystem.NativeMethodInfoPtr_GetAttractorsInRange_Private_Static_NativeList_1_AttractorData_float2_byref_PolygonRegionBlob_byref_NativeList_1_AttractorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688326);
      LightningStormRegionSystem.NativeMethodInfoPtr_AdjustStrikePosition_Private_Static_Void_byref_float2_byref_LightningStrikeData_byref_NativeList_1_AttractorData_byref_Random_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688327);
      LightningStormRegionSystem.NativeMethodInfoPtr_CheckStrikeConsumers_Private_Static_Void_byref_float2_byref_LightningStrikeData_byref_PolygonRegionBlob_byref_Entity_byref_NativeList_1_ConsumerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688328);
      LightningStormRegionSystem.NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688329);
      LightningStormRegionSystem.NativeMethodInfoPtr_AddSceneDependencies_Public_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688330);
      LightningStormRegionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688331);
      LightningStormRegionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688332);
      LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetupLightningStrikes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688333);
      LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688334);
      LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688335);
      LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688336);
      LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessLightningStrikes_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688337);
      LightningStormRegionSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddSceneDependencies_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688338);
      LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688339);
      LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688340);
      LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688341);
      LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688342);
      LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688343);
      LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688344);
      LightningStormRegionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, 100688345);
    }

    public LightningStormRegionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<LightningStormRegionSystem.FrameLightningStrike> _FrameLightningStrikes
    {
      get
      {
        return *(NativeList<LightningStormRegionSystem.FrameLightningStrike>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__FrameLightningStrikes));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__FrameLightningStrikes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<LightningStormRegionSystem.FrameLightningStrike>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LightningStormTypeCollectionSystem _LightningStormCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__LightningStormCollectionSystem));
        return pointer == System.IntPtr.Zero ? (LightningStormTypeCollectionSystem) null : new LightningStormTypeCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__LightningStormCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrierSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__SpawnBarrierSystem));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__SpawnBarrierSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<LightningStormRegionSystem.AttractorData> _GameplayAttractors
    {
      get
      {
        return *(NativeList<LightningStormRegionSystem.AttractorData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__GameplayAttractors));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__GameplayAttractors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<LightningStormRegionSystem.AttractorData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<LightningStormRegionSystem.AttractorData> _AmbienceAttractors
    {
      get
      {
        return *(NativeList<LightningStormRegionSystem.AttractorData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__AmbienceAttractors));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__AmbienceAttractors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<LightningStormRegionSystem.AttractorData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<LightningStormRegionSystem.ConsumerData> _LightningConsumers
    {
      get
      {
        return *(NativeList<LightningStormRegionSystem.ConsumerData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__LightningConsumers));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__LightningConsumers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<LightningStormRegionSystem.ConsumerData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public static unsafe float MinDurationBetweenStrikes
    {
      get
      {
        float durationBetweenStrikes;
        IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.NativeFieldInfoPtr_MinDurationBetweenStrikes, (void*) &durationBetweenStrikes);
        return durationBetweenStrikes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.NativeFieldInfoPtr_MinDurationBetweenStrikes, (void*) &value);
      }
    }

    public static unsafe float MaxDurationBetweenStrikes
    {
      get
      {
        float durationBetweenStrikes;
        IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.NativeFieldInfoPtr_MaxDurationBetweenStrikes, (void*) &durationBetweenStrikes);
        return durationBetweenStrikes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.NativeFieldInfoPtr_MaxDurationBetweenStrikes, (void*) &value);
      }
    }

    public unsafe EntityQuery __SetupLightningStrikes_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___SetupLightningStrikes_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___SetupLightningStrikes_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetupLightningStrikes_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___SetupLightningStrikes_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___SetupLightningStrikes_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ProcessLightningStrikes_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ProcessLightningStrikes_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ProcessLightningStrikes_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ProcessLightningStrikes_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ProcessLightningStrikes_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ProcessLightningStrikes_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ProcessLightningStrikes_LambdaJob3_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob3_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob3_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ProcessLightningStrikes_LambdaJob3_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob3_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob3_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __ProcessLightningStrikes_LambdaJob4_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob4_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___ProcessLightningStrikes_LambdaJob4_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __AddSceneDependencies_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___AddSceneDependencies_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___AddSceneDependencies_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AddSceneDependencies_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___AddSceneDependencies_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr___AddSceneDependencies_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_56
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_56));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStormRegionSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_56)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AttractorData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_LightningAttractorData_byref_Translation_byref_Velocity_0;
      [FieldOffset(0)]
      public readonly float2 Position;
      [FieldOffset(8)]
      public readonly float2 Velocity;
      [FieldOffset(16)]
      public readonly float Weight;
      [FieldOffset(20)]
      public readonly float Radius;

      [CallerCount(0)]
      public unsafe AttractorData(
        [In] ref LightningAttractorData data,
        [In] ref Translation translation,
        [In] ref ProjectM.Velocity velocity = default (ProjectM.Velocity))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.AttractorData.NativeMethodInfoPtr__ctor_Public_Void_byref_LightningAttractorData_byref_Translation_byref_Velocity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AttractorData()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.AttractorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (AttractorData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.AttractorData>.NativeClassPtr);
        LightningStormRegionSystem.AttractorData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.AttractorData>.NativeClassPtr, nameof (Position));
        LightningStormRegionSystem.AttractorData.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.AttractorData>.NativeClassPtr, nameof (Velocity));
        LightningStormRegionSystem.AttractorData.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.AttractorData>.NativeClassPtr, nameof (Weight));
        LightningStormRegionSystem.AttractorData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.AttractorData>.NativeClassPtr, nameof (Radius));
        LightningStormRegionSystem.AttractorData.NativeMethodInfoPtr__ctor_Public_Void_byref_LightningAttractorData_byref_Translation_byref_Velocity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.AttractorData>.NativeClassPtr, 100688346);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.AttractorData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ConsumerData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReplacePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReplacePrefabIgnoreCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_AlterPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_SetConsumerAsOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr_StrikePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0;
      [FieldOffset(0)]
      public readonly float2 Position;
      [FieldOffset(8)]
      public readonly float Radius;
      [FieldOffset(12)]
      public readonly bool ReplacePrefab;
      [FieldOffset(13)]
      public readonly bool ReplacePrefabIgnoreCollision;
      [FieldOffset(14)]
      public readonly bool AlterPosition;
      [FieldOffset(15)]
      public readonly bool SetConsumerAsOwner;
      [FieldOffset(16)]
      public readonly PrefabGUID StrikePrefab;
      [FieldOffset(20)]
      public readonly Entity Entity;

      [CallerCount(0)]
      public unsafe ConsumerData(
        [In] ref LightningConsumer consumer,
        [In] ref Translation translation,
        [In] ref Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.ConsumerData.NativeMethodInfoPtr__ctor_Public_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ConsumerData()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (ConsumerData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr);
        LightningStormRegionSystem.ConsumerData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, nameof (Position));
        LightningStormRegionSystem.ConsumerData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, nameof (Radius));
        LightningStormRegionSystem.ConsumerData.NativeFieldInfoPtr_ReplacePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, nameof (ReplacePrefab));
        LightningStormRegionSystem.ConsumerData.NativeFieldInfoPtr_ReplacePrefabIgnoreCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, nameof (ReplacePrefabIgnoreCollision));
        LightningStormRegionSystem.ConsumerData.NativeFieldInfoPtr_AlterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, nameof (AlterPosition));
        LightningStormRegionSystem.ConsumerData.NativeFieldInfoPtr_SetConsumerAsOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, nameof (SetConsumerAsOwner));
        LightningStormRegionSystem.ConsumerData.NativeFieldInfoPtr_StrikePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, nameof (StrikePrefab));
        LightningStormRegionSystem.ConsumerData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, nameof (Entity));
        LightningStormRegionSystem.ConsumerData.NativeMethodInfoPtr__ctor_Public_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, 100688347);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.ConsumerData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum LightningStrikeType
    {
      Gameplay,
      Ambience,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FrameLightningStrike
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StrikeType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Region;
      private static readonly System.IntPtr NativeFieldInfoPtr_StormType;
      [FieldOffset(0)]
      public LightningStormRegionSystem.LightningStrikeType StrikeType;
      [FieldOffset(8)]
      public LightningStormRegion Region;
      [FieldOffset(32)]
      public BlobAssetReference<LightningStormTypeBlob> StormType;

      static FrameLightningStrike()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.FrameLightningStrike>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, nameof (FrameLightningStrike));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.FrameLightningStrike>.NativeClassPtr);
        LightningStormRegionSystem.FrameLightningStrike.NativeFieldInfoPtr_StrikeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.FrameLightningStrike>.NativeClassPtr, nameof (StrikeType));
        LightningStormRegionSystem.FrameLightningStrike.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.FrameLightningStrike>.NativeClassPtr, nameof (Region));
        LightningStormRegionSystem.FrameLightningStrike.NativeFieldInfoPtr_StormType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.FrameLightningStrike>.NativeClassPtr, nameof (StormType));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.FrameLightningStrike>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/<>c__DisplayClass20_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass20_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_lightningStormTypeCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_frameLightningStrikes;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetupLightningStrikes_b__0_Internal_Void_byref_LightningStormRegion_0;
      [FieldOffset(0)]
      public LightningStormTypeCollection lightningStormTypeCollection;
      [FieldOffset(16)]
      public float deltaTime;
      [FieldOffset(24)]
      public CurveCollection curveCollection;
      [FieldOffset(40)]
      public double serverTime;
      [FieldOffset(48)]
      public Unity.Mathematics.Random random;
      [FieldOffset(56)]
      public NativeList<LightningStormRegionSystem.FrameLightningStrike> frameLightningStrikes;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass20_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SetupLightningStrikes_b__0(ref LightningStormRegion region)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref region;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__SetupLightningStrikes_b__0_Internal_Void_byref_LightningStormRegion_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass20_0()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass20_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_lightningStormTypeCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (lightningStormTypeCollection));
        LightningStormRegionSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (deltaTime));
        LightningStormRegionSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (curveCollection));
        LightningStormRegionSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (serverTime));
        LightningStormRegionSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (random));
        LightningStormRegionSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_frameLightningStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, nameof (frameLightningStrikes));
        LightningStormRegionSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, 100688348);
        LightningStormRegionSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__SetupLightningStrikes_b__0_Internal_Void_byref_LightningStormRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, 100688349);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass20_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/<>c__DisplayClass22_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass22_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayAttractors;
      private static readonly System.IntPtr NativeFieldInfoPtr_ambienceAttractors;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightningConsumers;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightningStrikes;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessLightningStrikes_b__0_Internal_Void_Entity_byref_LightningAttractorGameplay_byref_Translation_byref_Velocity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessLightningStrikes_b__1_Internal_Void_byref_LightningAttractorGameplay_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessLightningStrikes_b__2_Internal_Void_byref_LightningAttractorAmbience_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessLightningStrikes_b__3_Internal_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessLightningStrikes_b__4_Internal_Void_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<LightningStormRegionSystem.AttractorData> gameplayAttractors;
      [FieldOffset(24)]
      public NativeList<LightningStormRegionSystem.AttractorData> ambienceAttractors;
      [FieldOffset(40)]
      public NativeList<LightningStormRegionSystem.ConsumerData> lightningConsumers;
      [FieldOffset(56)]
      public NativeList<LightningStormRegionSystem.FrameLightningStrike> lightningStrikes;
      [FieldOffset(72)]
      public Unity.Mathematics.Random random;
      [FieldOffset(80)]
      public PrefabLookupMap prefabLookup;
      [FieldOffset(128)]
      public CollisionWorld collisionWorld;
      [FieldOffset(472)]
      public TileMapCollisionMath.MapData mapData;
      [FieldOffset(576)]
      public EntityCommandBuffer spawnCommandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass22_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessLightningStrikes_b__0(
        Entity entity,
        [In] ref LightningAttractorGameplay attractor,
        [In] ref Translation translation,
        [In] ref ProjectM.Velocity velocity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref attractor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__0_Internal_Void_Entity_byref_LightningAttractorGameplay_byref_Translation_byref_Velocity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessLightningStrikes_b__1(
        [In] ref LightningAttractorGameplay attractor,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref attractor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__1_Internal_Void_byref_LightningAttractorGameplay_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessLightningStrikes_b__2(
        [In] ref LightningAttractorAmbience attractor,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref attractor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__2_Internal_Void_byref_LightningAttractorAmbience_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessLightningStrikes_b__3(
        [In] ref LightningConsumer consumer,
        [In] ref Translation translation,
        [In] ref Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__3_Internal_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessLightningStrikes_b__4()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__4_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass22_0()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass22_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (entityManager));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_gameplayAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (gameplayAttractors));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_ambienceAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (ambienceAttractors));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_lightningConsumers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (lightningConsumers));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_lightningStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (lightningStrikes));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (random));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_prefabLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (prefabLookup));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (collisionWorld));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (mapData));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, 100688350);
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__0_Internal_Void_Entity_byref_LightningAttractorGameplay_byref_Translation_byref_Velocity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, 100688351);
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__1_Internal_Void_byref_LightningAttractorGameplay_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, 100688352);
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__2_Internal_Void_byref_LightningAttractorAmbience_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, 100688353);
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__3_Internal_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, 100688354);
        LightningStormRegionSystem.__c__DisplayClass22_0.NativeMethodInfoPtr__ProcessLightningStrikes_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, 100688355);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass22_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/<>c__DisplayClass29_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass29_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_convertOnDemand;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSceneDependencies_b__0_Internal_Void_byref_LightningConsumer_0;
      [FieldOffset(0)]
      public ConvertOnDemandContext convertOnDemand;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass29_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddSceneDependencies_b__0([In] ref LightningConsumer lightningConsumer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref lightningConsumer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__AddSceneDependencies_b__0_Internal_Void_byref_LightningConsumer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass29_0()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass29_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass29_0>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_convertOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (convertOnDemand));
        LightningStormRegionSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass29_0>.NativeClassPtr, 100688356);
        LightningStormRegionSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__AddSceneDependencies_b__0_Internal_Void_byref_LightningConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass29_0>.NativeClassPtr, 100688357);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass29_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_SetupLightningStrikes_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetupLightningStrikes_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_lightningStormTypeCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_frameLightningStrikes;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningStormRegion_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass20_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public LightningStormTypeCollection lightningStormTypeCollection;
      [FieldOffset(16)]
      public float deltaTime;
      [FieldOffset(24)]
      public CurveCollection curveCollection;
      [FieldOffset(40)]
      public double serverTime;
      [FieldOffset(48)]
      public Unity.Mathematics.Random random;
      [FieldOffset(56)]
      public NativeList<LightningStormRegionSystem.FrameLightningStrike> frameLightningStrikes;
      [FieldOffset(72)]
      public LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115238, XrefRangeEnd = 1115264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref LightningStormRegion region)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref region;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningStormRegion_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115264, RefRangeEnd = 1115265, XrefRangeStart = 1115264, XrefRangeEnd = 1115264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115265, RefRangeEnd = 1115266, XrefRangeStart = 1115265, XrefRangeEnd = 1115265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115266, XrefRangeEnd = 1115268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115273, RefRangeEnd = 1115274, XrefRangeStart = 1115268, XrefRangeEnd = 1115273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115276, RefRangeEnd = 1115277, XrefRangeStart = 1115274, XrefRangeEnd = 1115276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        LightningStormRegionSystem componentSystem,
        ref LightningStormRegionSystem.__c__DisplayClass20_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass20_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115277, XrefRangeEnd = 1115281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115281, XrefRangeEnd = 1115287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetupLightningStrikes_LambdaJob0()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass_SetupLightningStrikes_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_lightningStormTypeCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (lightningStormTypeCollection));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (deltaTime));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (curveCollection));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (serverTime));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (random));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_frameLightningStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (frameLightningStrikes));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningStormRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, 100688358);
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, 100688359);
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, 100688360);
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, 100688361);
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, 100688362);
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, 100688363);
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, 100688364);
        LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, 100688365);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_region;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<LightningStormRegion> forParameter_region;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115158, RefRangeEnd = 1115159, XrefRangeStart = 1115155, XrefRangeEnd = 1115158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(LightningStormRegionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115162, RefRangeEnd = 1115163, XrefRangeStart = 1115159, XrefRangeEnd = 1115162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_region));
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100688366);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100688367);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_region;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<LightningStormRegion>.Runtime runtime_region;

          static Runtimes()
          {
            Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_region));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_SetupLightningStrikes_LambdaJob0/ProjectM.LightningStorm.RunWithoutJobSystem_000057C5$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000057C5$PostfixBurstDelegate");
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688368);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688369);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688370);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688371);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_SetupLightningStrikes_LambdaJob0/ProjectM.LightningStorm.RunWithoutJobSystem_000057C5$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115163, XrefRangeEnd = 1115177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115177, XrefRangeEnd = 1115195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115195, XrefRangeEnd = 1115210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115237, RefRangeEnd = 1115238, XrefRangeStart = 1115210, XrefRangeEnd = 1115237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000057C5$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688372);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688373);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688374);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688375);
          LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688377);
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
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_SetupLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessLightningStrikes_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayAttractors;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LightningAttractorGameplay_byref_Translation_byref_Velocity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<LightningStormRegionSystem.AttractorData> gameplayAttractors;
      [FieldOffset(24)]
      public LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115384, XrefRangeEnd = 1115391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref LightningAttractorGameplay attractor,
        [In] ref Translation translation,
        [In] ref ProjectM.Velocity velocity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref attractor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LightningAttractorGameplay_byref_Translation_byref_Velocity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 980573, RefRangeEnd = 980586, XrefRangeStart = 980573, XrefRangeEnd = 980586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 980586, RefRangeEnd = 980599, XrefRangeStart = 980586, XrefRangeEnd = 980599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115391, XrefRangeEnd = 1115393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115405, RefRangeEnd = 1115406, XrefRangeStart = 1115393, XrefRangeEnd = 1115405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115408, RefRangeEnd = 1115409, XrefRangeStart = 1115406, XrefRangeEnd = 1115408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        LightningStormRegionSystem componentSystem,
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115409, XrefRangeEnd = 1115413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115413, XrefRangeEnd = 1115419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessLightningStrikes_LambdaJob0()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessLightningStrikes_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr_gameplayAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (gameplayAttractors));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LightningAttractorGameplay_byref_Translation_byref_Velocity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, 100688378);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, 100688379);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, 100688380);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, 100688381);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, 100688382);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, 100688383);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, 100688384);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, 100688385);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_attractor;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_velocity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<LightningAttractorGameplay> forParameter_attractor;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<ProjectM.Velocity> forParameter_velocity;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115297, RefRangeEnd = 1115298, XrefRangeStart = 1115287, XrefRangeEnd = 1115297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(LightningStormRegionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115308, RefRangeEnd = 1115309, XrefRangeStart = 1115298, XrefRangeEnd = 1115308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_attractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_attractor));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_velocity));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100688386);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100688387);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_attractor;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_velocity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<LightningAttractorGameplay>.Runtime runtime_attractor;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<ProjectM.Velocity>.Runtime runtime_velocity;

          static Runtimes()
          {
            Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_attractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_attractor));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_velocity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob0/ProjectM.LightningStorm.RunWithoutJobSystem_000057CE$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000057CE$PostfixBurstDelegate");
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688388);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688389);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688390);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688391);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob0/ProjectM.LightningStorm.RunWithoutJobSystem_000057CE$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115309, XrefRangeEnd = 1115323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115323, XrefRangeEnd = 1115341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115341, XrefRangeEnd = 1115356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115383, RefRangeEnd = 1115384, XrefRangeStart = 1115356, XrefRangeEnd = 1115383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000057CE$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688392);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688393);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688394);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688395);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688397);
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
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessLightningStrikes_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayAttractors;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningAttractorGameplay_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<LightningStormRegionSystem.AttractorData> gameplayAttractors;
      [FieldOffset(16)]
      public LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115508, XrefRangeEnd = 1115511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref LightningAttractorGameplay attractor,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref attractor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningAttractorGameplay_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723251, RefRangeEnd = 723285, XrefRangeStart = 723251, XrefRangeEnd = 723285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723285, RefRangeEnd = 723319, XrefRangeStart = 723285, XrefRangeEnd = 723319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115511, XrefRangeEnd = 1115513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115521, RefRangeEnd = 1115522, XrefRangeStart = 1115513, XrefRangeEnd = 1115521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115524, RefRangeEnd = 1115525, XrefRangeStart = 1115522, XrefRangeEnd = 1115524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        LightningStormRegionSystem componentSystem,
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115525, XrefRangeEnd = 1115529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115529, XrefRangeEnd = 1115535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessLightningStrikes_LambdaJob1()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessLightningStrikes_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr_gameplayAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, nameof (gameplayAttractors));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningAttractorGameplay_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, 100688398);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, 100688399);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, 100688400);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, 100688401);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, 100688402);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, 100688403);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, 100688404);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, 100688405);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_attractor;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<LightningAttractorGameplay> forParameter_attractor;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115425, RefRangeEnd = 1115426, XrefRangeStart = 1115419, XrefRangeEnd = 1115425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(LightningStormRegionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115432, RefRangeEnd = 1115433, XrefRangeStart = 1115426, XrefRangeEnd = 1115432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_attractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_attractor));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100688406);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100688407);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_attractor;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<LightningAttractorGameplay>.Runtime runtime_attractor;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_attractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_attractor));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob1/ProjectM.LightningStorm.RunWithoutJobSystem_000057D7$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000057D7$PostfixBurstDelegate");
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688408);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688409);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688410);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688411);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob1/ProjectM.LightningStorm.RunWithoutJobSystem_000057D7$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115433, XrefRangeEnd = 1115447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115447, XrefRangeEnd = 1115465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115465, XrefRangeEnd = 1115480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115507, RefRangeEnd = 1115508, XrefRangeStart = 1115480, XrefRangeEnd = 1115507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000057D7$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688412);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688413);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688414);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688415);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688417);
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
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessLightningStrikes_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ambienceAttractors;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningAttractorAmbience_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<LightningStormRegionSystem.AttractorData> ambienceAttractors;
      [FieldOffset(16)]
      public LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115624, XrefRangeEnd = 1115627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref LightningAttractorAmbience attractor,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref attractor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningAttractorAmbience_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 999309, RefRangeEnd = 999314, XrefRangeStart = 999309, XrefRangeEnd = 999314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 999314, RefRangeEnd = 999318, XrefRangeStart = 999314, XrefRangeEnd = 999318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115627, XrefRangeEnd = 1115629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115637, RefRangeEnd = 1115638, XrefRangeStart = 1115629, XrefRangeEnd = 1115637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115640, RefRangeEnd = 1115641, XrefRangeStart = 1115638, XrefRangeEnd = 1115640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        LightningStormRegionSystem componentSystem,
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115641, XrefRangeEnd = 1115645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115645, XrefRangeEnd = 1115651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessLightningStrikes_LambdaJob2()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessLightningStrikes_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr_ambienceAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, nameof (ambienceAttractors));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningAttractorAmbience_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, 100688418);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, 100688419);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, 100688420);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, 100688421);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, 100688422);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, 100688423);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, 100688424);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, 100688425);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_attractor;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<LightningAttractorAmbience> forParameter_attractor;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115541, RefRangeEnd = 1115542, XrefRangeStart = 1115535, XrefRangeEnd = 1115541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(LightningStormRegionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115548, RefRangeEnd = 1115549, XrefRangeStart = 1115542, XrefRangeEnd = 1115548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_attractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_attractor));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100688426);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100688427);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_attractor;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<LightningAttractorAmbience>.Runtime runtime_attractor;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_attractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_attractor));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob2/ProjectM.LightningStorm.RunWithoutJobSystem_000057E0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_000057E0$PostfixBurstDelegate");
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688428);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688429);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688430);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688431);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob2/ProjectM.LightningStorm.RunWithoutJobSystem_000057E0$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115549, XrefRangeEnd = 1115563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115563, XrefRangeEnd = 1115581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115581, XrefRangeEnd = 1115596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115623, RefRangeEnd = 1115624, XrefRangeStart = 1115596, XrefRangeEnd = 1115623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_000057E0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688432);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688433);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688434);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688435);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688437);
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
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob3")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessLightningStrikes_LambdaJob3
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_lightningConsumers;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<LightningStormRegionSystem.ConsumerData> lightningConsumers;
      [FieldOffset(16)]
      public LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115742, XrefRangeEnd = 1115745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref LightningConsumer consumer,
        [In] ref Translation translation,
        [In] ref Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759599, RefRangeEnd = 759601, XrefRangeStart = 759599, XrefRangeEnd = 759601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759601, RefRangeEnd = 759603, XrefRangeStart = 759601, XrefRangeEnd = 759603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115745, XrefRangeEnd = 1115747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115756, RefRangeEnd = 1115757, XrefRangeStart = 1115747, XrefRangeEnd = 1115756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115759, RefRangeEnd = 1115760, XrefRangeStart = 1115757, XrefRangeEnd = 1115759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        LightningStormRegionSystem componentSystem,
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115760, XrefRangeEnd = 1115764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115764, XrefRangeEnd = 1115770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessLightningStrikes_LambdaJob3()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessLightningStrikes_LambdaJob3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr_lightningConsumers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, nameof (lightningConsumers));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningConsumer_byref_Translation_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, 100688438);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, 100688439);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, 100688440);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, 100688441);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, 100688442);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, 100688443);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, 100688444);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, 100688445);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_consumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<LightningConsumer> forParameter_consumer;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115658, RefRangeEnd = 1115659, XrefRangeStart = 1115651, XrefRangeEnd = 1115658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(LightningStormRegionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115666, RefRangeEnd = 1115667, XrefRangeStart = 1115659, XrefRangeEnd = 1115666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_consumer));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100688446);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100688447);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_consumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<LightningConsumer>.Runtime runtime_consumer;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_consumer));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob3/ProjectM.LightningStorm.RunWithoutJobSystem_000057E9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_000057E9$PostfixBurstDelegate");
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688448);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688449);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688450);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688451);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob3/ProjectM.LightningStorm.RunWithoutJobSystem_000057E9$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115667, XrefRangeEnd = 1115681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115681, XrefRangeEnd = 1115699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115699, XrefRangeEnd = 1115714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115741, RefRangeEnd = 1115742, XrefRangeStart = 1115714, XrefRangeEnd = 1115741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_000057E9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688452);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688453);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688454);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688455);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688457);
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
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob4")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessLightningStrikes_LambdaJob4
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_lightningStrikes;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayAttractors;
      private static readonly System.IntPtr NativeFieldInfoPtr_ambienceAttractors;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_lightningConsumers;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeList<LightningStormRegionSystem.FrameLightningStrike> lightningStrikes;
      [FieldOffset(16)]
      public Unity.Mathematics.Random random;
      [FieldOffset(24)]
      public NativeList<LightningStormRegionSystem.AttractorData> gameplayAttractors;
      [FieldOffset(40)]
      public NativeList<LightningStormRegionSystem.AttractorData> ambienceAttractors;
      [FieldOffset(56)]
      public PrefabLookupMap prefabLookup;
      [FieldOffset(104)]
      public CollisionWorld collisionWorld;
      [FieldOffset(448)]
      public TileMapCollisionMath.MapData mapData;
      [FieldOffset(552)]
      public NativeList<LightningStormRegionSystem.ConsumerData> lightningConsumers;
      [FieldOffset(568)]
      public EntityCommandBuffer spawnCommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115845, XrefRangeEnd = 1115895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115895, RefRangeEnd = 1115896, XrefRangeStart = 1115895, XrefRangeEnd = 1115895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115896, RefRangeEnd = 1115897, XrefRangeStart = 1115896, XrefRangeEnd = 1115896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115898, RefRangeEnd = 1115899, XrefRangeStart = 1115897, XrefRangeEnd = 1115898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115900, RefRangeEnd = 1115901, XrefRangeStart = 1115899, XrefRangeEnd = 1115900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        LightningStormRegionSystem componentSystem,
        ref LightningStormRegionSystem.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115901, XrefRangeEnd = 1115905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1115966, RefRangeEnd = 1115967, XrefRangeStart = 1115905, XrefRangeEnd = 1115966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessLightningStrikes_LambdaJob4()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessLightningStrikes_LambdaJob4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_lightningStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (lightningStrikes));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (random));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_gameplayAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (gameplayAttractors));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_ambienceAttractors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (ambienceAttractors));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_prefabLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (prefabLookup));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (collisionWorld));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (mapData));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_lightningConsumers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (lightningConsumers));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (spawnCommandBuffer));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, 100688458);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, 100688459);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, 100688460);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, 100688461);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, 100688462);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, 100688463);
        LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, 100688464);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob4/ProjectM.LightningStorm.RunWithoutJobSystem_000057F1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_000057F1$PostfixBurstDelegate");
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100688465);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100688466);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100688467);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100688468);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_ProcessLightningStrikes_LambdaJob4/ProjectM.LightningStorm.RunWithoutJobSystem_000057F1$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115770, XrefRangeEnd = 1115784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115784, XrefRangeEnd = 1115802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115802, XrefRangeEnd = 1115817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115844, RefRangeEnd = 1115845, XrefRangeStart = 1115817, XrefRangeEnd = 1115844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_000057F1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688469);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688470);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688471);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688472);
          LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688474);
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
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_ProcessLightningStrikes_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_AddSceneDependencies_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_AddSceneDependencies_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_convertOnDemand;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningConsumer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass29_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ConvertOnDemandContext convertOnDemand;
      [FieldOffset(64)]
      public LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1116068, RefRangeEnd = 1116069, XrefRangeStart = 1116050, XrefRangeEnd = 1116068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref LightningConsumer lightningConsumer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref lightningConsumer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningConsumer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1083729, RefRangeEnd = 1083733, XrefRangeStart = 1083729, XrefRangeEnd = 1083733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1083733, RefRangeEnd = 1083736, XrefRangeStart = 1083733, XrefRangeEnd = 1083736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref LightningStormRegionSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116069, XrefRangeEnd = 1116071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1116076, RefRangeEnd = 1116077, XrefRangeStart = 1116071, XrefRangeEnd = 1116076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1116079, RefRangeEnd = 1116080, XrefRangeStart = 1116077, XrefRangeEnd = 1116079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        LightningStormRegionSystem componentSystem,
        ref LightningStormRegionSystem.__c__DisplayClass29_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass29_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116080, XrefRangeEnd = 1116084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116084, XrefRangeEnd = 1116090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AddSceneDependencies_LambdaJob0()
      {
        Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem>.NativeClassPtr, "<>c__DisplayClass_AddSceneDependencies_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr);
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr_convertOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, nameof (convertOnDemand));
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_LightningConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, 100688475);
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, 100688476);
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, 100688477);
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, 100688478);
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, 100688479);
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, 100688480);
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, 100688481);
        LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, 100688482);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_lightningConsumer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<LightningConsumer> forParameter_lightningConsumer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115970, RefRangeEnd = 1115971, XrefRangeStart = 1115967, XrefRangeEnd = 1115970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(LightningStormRegionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1115974, RefRangeEnd = 1115975, XrefRangeStart = 1115971, XrefRangeEnd = 1115974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_lightningConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_lightningConsumer));
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_LightningStormRegionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100688483);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100688484);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_lightningConsumer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<LightningConsumer>.Runtime runtime_lightningConsumer;

          static Runtimes()
          {
            Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_lightningConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_lightningConsumer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_AddSceneDependencies_LambdaJob0/ProjectM.LightningStorm.RunWithoutJobSystem_000057F8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000057F8$PostfixBurstDelegate");
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688485);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688486);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688487);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688488);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.LightningStorm.LightningStormRegionSystem/ProjectM.LightningStorm.<>c__DisplayClass_AddSceneDependencies_LambdaJob0/ProjectM.LightningStorm.RunWithoutJobSystem_000057F8$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115975, XrefRangeEnd = 1115989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115989, XrefRangeEnd = 1116007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116007, XrefRangeEnd = 1116022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1116049, RefRangeEnd = 1116050, XrefRangeStart = 1116022, XrefRangeEnd = 1116049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000057F8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688489);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688490);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688491);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688492);
          LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688494);
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
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(LightningStormRegionSystem.__c__DisplayClass_AddSceneDependencies_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
