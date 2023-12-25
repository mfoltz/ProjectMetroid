// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.CastleBuilding;
using ProjectM.Network;
using ProjectM.Terrain;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class MapMenuMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ZOOM_ADJUST_MULTIPLICATOR;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisableSendAimInputQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ResetMovementCameraDirectionQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldToAnchoredSpace;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerritoryOwnerCacheSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CreateCharacterEventAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantMissionSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__MenuMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__Target;
    private static readonly System.IntPtr NativeFieldInfoPtr__InteractBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbortMissionPopup;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__ZoneOffsets;
    private static readonly System.IntPtr NativeFieldInfoPtr__ZoomAdjustData;
    private static readonly System.IntPtr NativeFieldInfoPtr__PanAdjust;
    private static readonly System.IntPtr NativeFieldInfoPtr__Canvas;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastHasMapData;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastMapProjection;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastZoneMapTexture;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastPlayerZone;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapMenuContextEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedWaypoints;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnLocationCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantMissionSubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__HoveredMapZoneEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldCorners;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapIconHover;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasSetProjectionMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr__ResponseEntityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RecommendedGraveyardExitTeleport;
    private static readonly System.IntPtr NativeFieldInfoPtr_RevealAlphaTexture;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapTexture;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetMapMenu_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetMapMenu_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TerritoryHoverCalc_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TerritoryHoverCalc_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetMapZones_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetMapZones_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateMainMapTerritories_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateMainMapTerritories_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GatherMapIcons_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GatherMapIcons_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindPlayerZone_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindPlayerZone_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindPlayerZone2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindPlayerZone2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_CastleTerritoryManager_21;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_22;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleCloseMenu_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDead_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMapMenu_Private_MapMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMapIconHoverChange_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BoundsFromCorners_Private_Static_Bounds_Il2CppStructArray_1_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RenderTooltip_Private_Void_EntityManager_MapMenu_Entity_PrefabCollectionSystem_SingletonAccessor_1_ServantMissionSettingsSingleton_MapMenu_AbortMissionPopup_ManagedDataRegistry_HoverOutput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalcMapRegionNameAlpha_Private_Single_Single_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MapIconTargetIsInUserRespawnPointOwnerBuffer_Public_Static_Boolean_EntityManager_Entity_MapIconTargetEntity_byref_Int32_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MapIconTargetIsInUserRespawnPointOwnerBuffer_Public_Static_Boolean_DynamicBuffer_1_RespawnPointOwnerBuffer_MapIconTargetEntity_byref_Int32_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendSpawnEvent_Private_Void_Boolean_SpawnLocationSelector_NetworkId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateContextEntries_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPositionInRevealedArea_Private_Static_Boolean_RectTransform_Texture2D_byref_Matrix4x4_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPositionInRevealedArea_Private_Static_Boolean_RectTransform_Texture2D_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHelpText_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HideHelpText_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowHelpText_Private_Void_LocalizationKey_Nullable_Unboxed_1_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteCustomMapMarker_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalcFitOnScreenScale_Private_Single_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustZoomScale_Private_ValueTuple_Unboxed_2_Single_Single_WorldZone_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustPan_Private_Void_RectTransform_RectTransform_WorldZone_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetZoneOffsetAndScale_Private_Void_WorldZone_OffsetAndScale_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetZoneOffsetAndScale_Private_OffsetAndScale_WorldZone_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalcTextureSize_Private_Vector2_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendTeleportToWaypoint_Private_Void_NetworkId_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TravelToNetherWorld_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMapActive_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMapActiveNoText_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySetProjectionMatrix_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetZoneMapData_Private_Boolean_TerrainManager_byref_Texture2D_byref_float4x4_byref_WorldZone_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPlayerChunk_Private_Boolean_TerrainManager_byref_TerrainChunk_byref_WorldZone_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindZoneEntity_Private_Entity_TerrainChunk_WorldZone_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindZoneEntity_Private_Entity_WorldZone_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__54_0_Private_Void_Entity_byref_InitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__54_1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetMapMenu_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTerritoryHoverCalc_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetMapZones_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateMainMapTerritories_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGatherMapIcons_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindPlayerZone_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindPlayerZone2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269077, XrefRangeEnd = 1269166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269166, XrefRangeEnd = 1269179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269179, XrefRangeEnd = 1269204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1269216, RefRangeEnd = 1269220, XrefRangeStart = 1269204, XrefRangeEnd = 1269216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleCloseMenu()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_HandleCloseMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1269224, RefRangeEnd = 1269225, XrefRangeStart = 1269220, XrefRangeEnd = 1269224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsDead()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_IsDead_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1269239, RefRangeEnd = 1269241, XrefRangeStart = 1269225, XrefRangeEnd = 1269239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapMenu GetMapMenu()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_GetMapMenu_Private_MapMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (MapMenu) null : new MapMenu(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269241, XrefRangeEnd = 1269295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269295, XrefRangeEnd = 1269310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269310, XrefRangeEnd = 1269849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnMapIconHoverChange(bool hover)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hover;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_OnMapIconHoverChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1269850, RefRangeEnd = 1269851, XrefRangeStart = 1269849, XrefRangeEnd = 1269850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Bounds BoundsFromCorners(Il2CppStructArray<Vector3> corners)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) corners);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_BoundsFromCorners_Private_Static_Bounds_Il2CppStructArray_1_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1269858, RefRangeEnd = 1269859, XrefRangeStart = 1269851, XrefRangeEnd = 1269858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RenderTooltip(
      EntityManager entityManager,
      MapMenu mapMenu,
      Entity targetEntity,
      PrefabCollectionSystem prefabCollectionSystem,
      SingletonAccessor<ServantMissionSettingsSingleton> servantMissionSettingsAccessor,
      MapMenu_AbortMissionPopup abortMissionPopup,
      ManagedDataRegistry managedDataRegistry,
      MapMenuMapper.HoverOutput hoverOutput)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapMenu);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &servantMissionSettingsAccessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) abortMissionPopup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) managedDataRegistry));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &hoverOutput;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_RenderTooltip_Private_Void_EntityManager_MapMenu_Entity_PrefabCollectionSystem_SingletonAccessor_1_ServantMissionSettingsSingleton_MapMenu_AbortMissionPopup_ManagedDataRegistry_HoverOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269859, XrefRangeEnd = 1269860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float CalcMapRegionNameAlpha(
      float zoomScale,
      float minScale,
      float maxScale,
      float alphaStartThreshold,
      float alphaEndThreshold)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &zoomScale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minScale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxScale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &alphaStartThreshold;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &alphaEndThreshold;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_CalcMapRegionNameAlpha_Private_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1269865, RefRangeEnd = 1269866, XrefRangeStart = 1269860, XrefRangeEnd = 1269865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool MapIconTargetIsInUserRespawnPointOwnerBuffer(
      EntityManager entityManager,
      Entity userEntity,
      MapIconTargetEntity mapIconTargetEntityComp,
      out int spawnPointBufferIndexOut,
      out bool isLocked)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mapIconTargetEntityComp;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnPointBufferIndexOut;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref isLocked;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_MapIconTargetIsInUserRespawnPointOwnerBuffer_Public_Static_Boolean_EntityManager_Entity_MapIconTargetEntity_byref_Int32_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1269878, RefRangeEnd = 1269879, XrefRangeStart = 1269866, XrefRangeEnd = 1269878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool MapIconTargetIsInUserRespawnPointOwnerBuffer(
      DynamicBuffer<RespawnPointOwnerBuffer> spawnPointBuffer,
      MapIconTargetEntity mapIconTargetEntityComp,
      out int spawnPointBufferIndexOut,
      out bool isLocked)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &spawnPointBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mapIconTargetEntityComp;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnPointBufferIndexOut;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref isLocked;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_MapIconTargetIsInUserRespawnPointOwnerBuffer_Public_Static_Boolean_DynamicBuffer_1_RespawnPointOwnerBuffer_MapIconTargetEntity_byref_Int32_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1269952, RefRangeEnd = 1269953, XrefRangeStart = 1269879, XrefRangeEnd = 1269952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendSpawnEvent(
      bool respawn,
      SpawnLocationSelector spawnLocationSelector,
      NetworkId spawnLocationIcon,
      int spawnLocationIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &respawn;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnLocationSelector;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnLocationIcon;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnLocationIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_SendSpawnEvent_Private_Void_Boolean_SpawnLocationSelector_NetworkId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269953, XrefRangeEnd = 1269967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SpawnButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_SpawnButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269967, XrefRangeEnd = 1269978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateContextEntries()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_UpdateContextEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1269989, RefRangeEnd = 1269990, XrefRangeStart = 1269978, XrefRangeEnd = 1269989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsPositionInRevealedArea(
      RectTransform rectTransform,
      Texture2D revealMaskTexture,
      ref Matrix4x4 worldToAnchoredSpace,
      Vector2 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) revealMaskTexture);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldToAnchoredSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_IsPositionInRevealedArea_Private_Static_Boolean_RectTransform_Texture2D_byref_Matrix4x4_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1270001, RefRangeEnd = 1270003, XrefRangeStart = 1269990, XrefRangeEnd = 1270001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsPositionInRevealedArea(
      RectTransform rectTransform,
      Texture2D revealMaskTexture,
      Vector2 anchoredPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) revealMaskTexture);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &anchoredPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_IsPositionInRevealedArea_Private_Static_Boolean_RectTransform_Texture2D_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270019, RefRangeEnd = 1270020, XrefRangeStart = 1270003, XrefRangeEnd = 1270019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateHelpText(bool localPlayerExists)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localPlayerExists;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_UpdateHelpText_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270020, XrefRangeEnd = 1270025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HideHelpText()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_HideHelpText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270037, RefRangeEnd = 1270038, XrefRangeStart = 1270025, XrefRangeEnd = 1270037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowHelpText(LocalizationKey localizationKey, Nullable_Unboxed<Color> color = default (Nullable_Unboxed<Color>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &localizationKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_ShowHelpText_Private_Void_LocalizationKey_Nullable_Unboxed_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270048, RefRangeEnd = 1270049, XrefRangeStart = 1270038, XrefRangeEnd = 1270048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeleteCustomMapMarker()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_DeleteCustomMapMarker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270049, XrefRangeEnd = 1270050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float CalcFitOnScreenScale(
      float mapWidth,
      float mapHeight,
      float windowWidth,
      float windowHeight)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &mapWidth;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mapHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &windowWidth;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &windowHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_CalcFitOnScreenScale_Private_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270050, XrefRangeEnd = 1270061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ValueTuple_Unboxed<float, float> AdjustZoomScale(
      WorldZone zoneType,
      float defaultScale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &zoneType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultScale;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_AdjustZoomScale_Private_ValueTuple_Unboxed_2_Single_Single_WorldZone_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<float, float>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270078, RefRangeEnd = 1270079, XrefRangeStart = 1270061, XrefRangeEnd = 1270078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AdjustPan(
      RectTransform parentRect,
      RectTransform mapRect,
      WorldZone zoneType,
      float defaultScale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentRect);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapRect);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &zoneType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultScale;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_AdjustPan_Private_Void_RectTransform_RectTransform_WorldZone_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270079, XrefRangeEnd = 1270082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetZoneOffsetAndScale(WorldZone zoneType, OffsetAndScale offsetAndScale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &zoneType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetAndScale;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_SetZoneOffsetAndScale_Private_Void_WorldZone_OffsetAndScale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1270105, RefRangeEnd = 1270108, XrefRangeStart = 1270082, XrefRangeEnd = 1270105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OffsetAndScale GetZoneOffsetAndScale(WorldZone zoneType, float defaultScale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &zoneType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultScale;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_GetZoneOffsetAndScale_Private_OffsetAndScale_WorldZone_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(OffsetAndScale*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Vector2 CalcTextureSize(float mapWidth, float mapHeight, float zoomScale)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &mapWidth;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mapHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &zoomScale;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_CalcTextureSize_Private_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270113, RefRangeEnd = 1270114, XrefRangeStart = 1270108, XrefRangeEnd = 1270113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendTeleportToWaypoint(NetworkId fromWaypointId, NetworkId targetWaypointId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromWaypointId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetWaypointId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_SendTeleportToWaypoint_Private_Void_NetworkId_NetworkId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270114, XrefRangeEnd = 1270123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TravelToNetherWorld_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_TravelToNetherWorld_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270123, XrefRangeEnd = 1270126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMapActive(bool active)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &active;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_SetMapActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270126, XrefRangeEnd = 1270129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMapActiveNoText()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_SetMapActiveNoText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270129, XrefRangeEnd = 1270140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrySetProjectionMatrix()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_TrySetProjectionMatrix_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1270171, RefRangeEnd = 1270174, XrefRangeStart = 1270140, XrefRangeEnd = 1270171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetZoneMapData(
      TerrainManager terrainManager,
      out Texture2D zoneMapTexture,
      out float4x4 projectionMatrix,
      out WorldZone zoneType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) terrainManager);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionMatrix;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref zoneType;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_TryGetZoneMapData_Private_Boolean_TerrainManager_byref_Texture2D_byref_float4x4_byref_WorldZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Texture2D local = ref zoneMapTexture;
      System.IntPtr pointer = zero;
      Texture2D texture2D = pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      local = texture2D;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270174, XrefRangeEnd = 1270190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPlayerChunk(
      TerrainManager terrainManager,
      out TerrainChunk terrainChunk,
      out WorldZone zoneType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) terrainManager);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref terrainChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref zoneType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_TryGetPlayerChunk_Private_Boolean_TerrainManager_byref_TerrainChunk_byref_WorldZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270205, RefRangeEnd = 1270206, XrefRangeStart = 1270190, XrefRangeEnd = 1270205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity FindZoneEntity(TerrainChunk currentChunk, WorldZone zoneType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &currentChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &zoneType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_FindZoneEntity_Private_Entity_TerrainChunk_WorldZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270221, RefRangeEnd = 1270222, XrefRangeStart = 1270206, XrefRangeEnd = 1270221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity FindZoneEntity(WorldZone zoneType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &zoneType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_FindZoneEntity_Private_Entity_WorldZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270222, XrefRangeEnd = 1270238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1270240, RefRangeEnd = 1270242, XrefRangeStart = 1270238, XrefRangeEnd = 1270240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__54_0(Entity entity, ref MapMenu.InitData initData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref initData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__54_0_Private_Void_Entity_byref_InitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270242, XrefRangeEnd = 1270243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__54_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__54_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270243, XrefRangeEnd = 1270503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270503, XrefRangeEnd = 1270519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetMapMenu_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForGetMapMenu_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270519, XrefRangeEnd = 1270535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnStartRunning_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270557, RefRangeEnd = 1270558, XrefRangeStart = 1270535, XrefRangeEnd = 1270557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTerritoryHoverCalc_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForTerritoryHoverCalc_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270558, XrefRangeEnd = 1270577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270602, RefRangeEnd = 1270603, XrefRangeStart = 1270577, XrefRangeEnd = 1270602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetMapZones_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForGetMapZones_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270603, XrefRangeEnd = 1270622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateMainMapTerritories_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForUpdateMainMapTerritories_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270622, XrefRangeEnd = 1270641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob4_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270666, RefRangeEnd = 1270667, XrefRangeStart = 1270641, XrefRangeEnd = 1270666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGatherMapIcons_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForGatherMapIcons_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270667, XrefRangeEnd = 1270683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindPlayerZone_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForFindPlayerZone_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270683, XrefRangeEnd = 1270699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindPlayerZone2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForFindPlayerZone2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270703, RefRangeEnd = 1270704, XrefRangeStart = 1270699, XrefRangeEnd = 1270703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270708, RefRangeEnd = 1270709, XrefRangeStart = 1270704, XrefRangeEnd = 1270708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270713, RefRangeEnd = 1270714, XrefRangeStart = 1270709, XrefRangeEnd = 1270713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1270718, RefRangeEnd = 1270719, XrefRangeStart = 1270714, XrefRangeEnd = 1270718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapMenuMapper()
    {
      Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr);
      MapMenuMapper.NativeFieldInfoPtr_ZOOM_ADJUST_MULTIPLICATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (ZOOM_ADJUST_MULTIPLICATOR));
      MapMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      MapMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_Query));
      MapMenuMapper.NativeFieldInfoPtr__DisableSendAimInputQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_DisableSendAimInputQuery));
      MapMenuMapper.NativeFieldInfoPtr__ResetMovementCameraDirectionQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_ResetMovementCameraDirectionQuery));
      MapMenuMapper.NativeFieldInfoPtr__MapMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_MapMenu));
      MapMenuMapper.NativeFieldInfoPtr__WorldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_WorldToAnchoredSpace));
      MapMenuMapper.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_TerrainManager));
      MapMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      MapMenuMapper.NativeFieldInfoPtr__TerritoryOwnerCacheSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_TerritoryOwnerCacheSystem));
      MapMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      MapMenuMapper.NativeFieldInfoPtr__CreateCharacterEventAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_CreateCharacterEventAccessor));
      MapMenuMapper.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_ServerDebugSettings));
      MapMenuMapper.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_BalanceSettings));
      MapMenuMapper.NativeFieldInfoPtr__ServantMissionSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_ServantMissionSettingsAccessor));
      MapMenuMapper.NativeFieldInfoPtr__MenuMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_MenuMode));
      MapMenuMapper.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_Target));
      MapMenuMapper.NativeFieldInfoPtr__InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_InteractBuff));
      MapMenuMapper.NativeFieldInfoPtr__AbortMissionPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_AbortMissionPopup));
      MapMenuMapper.NativeFieldInfoPtr__DefaultMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_DefaultMap));
      MapMenuMapper.NativeFieldInfoPtr__ZoneOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_ZoneOffsets));
      MapMenuMapper.NativeFieldInfoPtr__ZoomAdjustData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_ZoomAdjustData));
      MapMenuMapper.NativeFieldInfoPtr__PanAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_PanAdjust));
      MapMenuMapper.NativeFieldInfoPtr__Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_Canvas));
      MapMenuMapper.NativeFieldInfoPtr__LastHasMapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_LastHasMapData));
      MapMenuMapper.NativeFieldInfoPtr__LastMapProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_LastMapProjection));
      MapMenuMapper.NativeFieldInfoPtr__LastZoneMapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_LastZoneMapTexture));
      MapMenuMapper.NativeFieldInfoPtr__LastPlayerZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_LastPlayerZone));
      MapMenuMapper.NativeFieldInfoPtr__MapMenuContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_MapMenuContextEntriesCache));
      MapMenuMapper.NativeFieldInfoPtr__UnlockedWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_UnlockedWaypoints));
      MapMenuMapper.NativeFieldInfoPtr__SpawnLocationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_SpawnLocationCount));
      MapMenuMapper.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_UIDataSystem));
      MapMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      MapMenuMapper.NativeFieldInfoPtr__ServantMissionSubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_ServantMissionSubMenuEntity));
      MapMenuMapper.NativeFieldInfoPtr__HoveredMapZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_HoveredMapZoneEntity));
      MapMenuMapper.NativeFieldInfoPtr__WorldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_WorldCorners));
      MapMenuMapper.NativeFieldInfoPtr__MapIconHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_MapIconHover));
      MapMenuMapper.NativeFieldInfoPtr_HasSetProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (HasSetProjectionMatrix));
      MapMenuMapper.NativeFieldInfoPtr__ResponseEntityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_ResponseEntityQuery));
      MapMenuMapper.NativeFieldInfoPtr__RecommendedGraveyardExitTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_RecommendedGraveyardExitTeleport));
      MapMenuMapper.NativeFieldInfoPtr_RevealAlphaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (RevealAlphaTexture));
      MapMenuMapper.NativeFieldInfoPtr_MapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (MapTexture));
      MapMenuMapper.NativeFieldInfoPtr_VisionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (VisionData));
      MapMenuMapper.NativeFieldInfoPtr_ProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (ProjectionMatrix));
      MapMenuMapper.NativeFieldInfoPtr___GetMapMenu_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>GetMapMenu_LambdaJob0_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___GetMapMenu_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>GetMapMenu_LambdaJob0_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>OnStartRunning_LambdaJob0_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>OnStartRunning_LambdaJob0_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___TerritoryHoverCalc_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>TerritoryHoverCalc_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___TerritoryHoverCalc_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>TerritoryHoverCalc_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___GetMapZones_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>GetMapZones_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___GetMapZones_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>GetMapZones_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___UpdateMainMapTerritories_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>UpdateMainMapTerritories_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___UpdateMainMapTerritories_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>UpdateMainMapTerritories_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob4_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob4_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___GatherMapIcons_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>GatherMapIcons_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___GatherMapIcons_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>GatherMapIcons_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>FindPlayerZone_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>FindPlayerZone_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>FindPlayerZone2_entityQuery");
      MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>FindPlayerZone2_profilerMarker");
      MapMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_CastleTerritoryManager_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_SingletonEntityQuery_CastleTerritoryManager_21));
      MapMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalControlled_22));
      MapMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667736);
      MapMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667737);
      MapMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667738);
      MapMenuMapper.NativeMethodInfoPtr_HandleCloseMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667739);
      MapMenuMapper.NativeMethodInfoPtr_IsDead_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667740);
      MapMenuMapper.NativeMethodInfoPtr_GetMapMenu_Private_MapMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667741);
      MapMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667742);
      MapMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667743);
      MapMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667744);
      MapMenuMapper.NativeMethodInfoPtr_OnMapIconHoverChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667745);
      MapMenuMapper.NativeMethodInfoPtr_BoundsFromCorners_Private_Static_Bounds_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667746);
      MapMenuMapper.NativeMethodInfoPtr_RenderTooltip_Private_Void_EntityManager_MapMenu_Entity_PrefabCollectionSystem_SingletonAccessor_1_ServantMissionSettingsSingleton_MapMenu_AbortMissionPopup_ManagedDataRegistry_HoverOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667747);
      MapMenuMapper.NativeMethodInfoPtr_CalcMapRegionNameAlpha_Private_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667748);
      MapMenuMapper.NativeMethodInfoPtr_MapIconTargetIsInUserRespawnPointOwnerBuffer_Public_Static_Boolean_EntityManager_Entity_MapIconTargetEntity_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667749);
      MapMenuMapper.NativeMethodInfoPtr_MapIconTargetIsInUserRespawnPointOwnerBuffer_Public_Static_Boolean_DynamicBuffer_1_RespawnPointOwnerBuffer_MapIconTargetEntity_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667750);
      MapMenuMapper.NativeMethodInfoPtr_SendSpawnEvent_Private_Void_Boolean_SpawnLocationSelector_NetworkId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667751);
      MapMenuMapper.NativeMethodInfoPtr_SpawnButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667752);
      MapMenuMapper.NativeMethodInfoPtr_UpdateContextEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667753);
      MapMenuMapper.NativeMethodInfoPtr_IsPositionInRevealedArea_Private_Static_Boolean_RectTransform_Texture2D_byref_Matrix4x4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667754);
      MapMenuMapper.NativeMethodInfoPtr_IsPositionInRevealedArea_Private_Static_Boolean_RectTransform_Texture2D_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667755);
      MapMenuMapper.NativeMethodInfoPtr_UpdateHelpText_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667756);
      MapMenuMapper.NativeMethodInfoPtr_HideHelpText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667757);
      MapMenuMapper.NativeMethodInfoPtr_ShowHelpText_Private_Void_LocalizationKey_Nullable_Unboxed_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667758);
      MapMenuMapper.NativeMethodInfoPtr_DeleteCustomMapMarker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667759);
      MapMenuMapper.NativeMethodInfoPtr_CalcFitOnScreenScale_Private_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667760);
      MapMenuMapper.NativeMethodInfoPtr_AdjustZoomScale_Private_ValueTuple_Unboxed_2_Single_Single_WorldZone_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667761);
      MapMenuMapper.NativeMethodInfoPtr_AdjustPan_Private_Void_RectTransform_RectTransform_WorldZone_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667762);
      MapMenuMapper.NativeMethodInfoPtr_SetZoneOffsetAndScale_Private_Void_WorldZone_OffsetAndScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667763);
      MapMenuMapper.NativeMethodInfoPtr_GetZoneOffsetAndScale_Private_OffsetAndScale_WorldZone_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667764);
      MapMenuMapper.NativeMethodInfoPtr_CalcTextureSize_Private_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667765);
      MapMenuMapper.NativeMethodInfoPtr_SendTeleportToWaypoint_Private_Void_NetworkId_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667766);
      MapMenuMapper.NativeMethodInfoPtr_TravelToNetherWorld_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667767);
      MapMenuMapper.NativeMethodInfoPtr_SetMapActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667768);
      MapMenuMapper.NativeMethodInfoPtr_SetMapActiveNoText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667769);
      MapMenuMapper.NativeMethodInfoPtr_TrySetProjectionMatrix_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667770);
      MapMenuMapper.NativeMethodInfoPtr_TryGetZoneMapData_Private_Boolean_TerrainManager_byref_Texture2D_byref_float4x4_byref_WorldZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667771);
      MapMenuMapper.NativeMethodInfoPtr_TryGetPlayerChunk_Private_Boolean_TerrainManager_byref_TerrainChunk_byref_WorldZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667772);
      MapMenuMapper.NativeMethodInfoPtr_FindZoneEntity_Private_Entity_TerrainChunk_WorldZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667773);
      MapMenuMapper.NativeMethodInfoPtr_FindZoneEntity_Private_Entity_WorldZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667774);
      MapMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667775);
      MapMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__54_0_Private_Void_Entity_byref_InitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667777);
      MapMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__54_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667778);
      MapMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667779);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForGetMapMenu_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667780);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667781);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForTerritoryHoverCalc_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667782);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667783);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForGetMapZones_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667784);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForUpdateMainMapTerritories_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667785);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667786);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForGatherMapIcons_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667787);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForFindPlayerZone_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667788);
      MapMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForFindPlayerZone2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667789);
      MapMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667790);
      MapMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667791);
      MapMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667792);
      MapMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, 100667793);
    }

    public MapMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float ZOOM_ADJUST_MULTIPLICATOR
    {
      get
      {
        float adjustMultiplicator;
        IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.NativeFieldInfoPtr_ZOOM_ADJUST_MULTIPLICATOR, (void*) &adjustMultiplicator);
        return adjustMultiplicator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.NativeFieldInfoPtr_ZOOM_ADJUST_MULTIPLICATOR, (void*) &value);
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _DisableSendAimInputQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__DisableSendAimInputQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__DisableSendAimInputQuery)) = value;
      }
    }

    public unsafe EntityQuery _ResetMovementCameraDirectionQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ResetMovementCameraDirectionQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ResetMovementCameraDirectionQuery)) = value;
      }
    }

    public unsafe MapMenu _MapMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__MapMenu));
        return pointer == System.IntPtr.Zero ? (MapMenu) null : new MapMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__MapMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Matrix4x4 _WorldToAnchoredSpace
    {
      get
      {
        return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__WorldToAnchoredSpace));
      }
      [param: In] set
      {
        *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__WorldToAnchoredSpace)) = value;
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerritoryOwnerCacheSystem _TerritoryOwnerCacheSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__TerritoryOwnerCacheSystem));
        return pointer == System.IntPtr.Zero ? (TerritoryOwnerCacheSystem) null : new TerritoryOwnerCacheSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__TerritoryOwnerCacheSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<CreateCharacterCacheData> _CreateCharacterEventAccessor
    {
      get
      {
        return *(SingletonAccessor<CreateCharacterCacheData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__CreateCharacterEventAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__CreateCharacterEventAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<CreateCharacterCacheData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServantMissionSettingsSingleton> _ServantMissionSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServantMissionSettingsSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ServantMissionSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ServantMissionSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServantMissionSettingsSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe MapMenuMode _MenuMode
    {
      get
      {
        return *(MapMenuMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__MenuMode));
      }
      [param: In] set
      {
        *(MapMenuMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__MenuMode)) = value;
      }
    }

    public unsafe Entity _Target
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__Target));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__Target)) = value;
      }
    }

    public unsafe Entity _InteractBuff
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__InteractBuff));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__InteractBuff)) = value;
      }
    }

    public unsafe MapMenu_AbortMissionPopup _AbortMissionPopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__AbortMissionPopup));
        return pointer == System.IntPtr.Zero ? (MapMenu_AbortMissionPopup) null : new MapMenu_AbortMissionPopup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__AbortMissionPopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Texture2D _DefaultMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__DefaultMap));
        return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__DefaultMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<WorldZone, OffsetAndScale> _ZoneOffsets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ZoneOffsets));
        return pointer == System.IntPtr.Zero ? (Dictionary<WorldZone, OffsetAndScale>) null : new Dictionary<WorldZone, OffsetAndScale>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ZoneOffsets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapMenuMapper.ZoomData _ZoomAdjustData
    {
      get
      {
        return *(MapMenuMapper.ZoomData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ZoomAdjustData));
      }
      [param: In] set
      {
        *(MapMenuMapper.ZoomData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ZoomAdjustData)) = value;
      }
    }

    public unsafe Vector2 _PanAdjust
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__PanAdjust));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__PanAdjust)) = value;
      }
    }

    public unsafe Canvas _Canvas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__Canvas));
        return pointer == System.IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__Canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _LastHasMapData
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__LastHasMapData));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__LastHasMapData)) = value;
      }
    }

    public unsafe float4x4 _LastMapProjection
    {
      get
      {
        return *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__LastMapProjection));
      }
      [param: In] set
      {
        *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__LastMapProjection)) = value;
      }
    }

    public unsafe Texture2D _LastZoneMapTexture
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__LastZoneMapTexture));
        return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__LastZoneMapTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorldZone _LastPlayerZone
    {
      get
      {
        return *(WorldZone*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__LastPlayerZone));
      }
      [param: In] set
      {
        *(WorldZone*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__LastPlayerZone)) = value;
      }
    }

    public unsafe List<InputContextEntry.Data> _MapMenuContextEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__MapMenuContextEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__MapMenuContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _UnlockedWaypoints
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__UnlockedWaypoints));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__UnlockedWaypoints)) = value;
      }
    }

    public unsafe int _SpawnLocationCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__SpawnLocationCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__SpawnLocationCount)) = value;
      }
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__UIDataSystem));
        return pointer == System.IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _ServantMissionSubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ServantMissionSubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ServantMissionSubMenuEntity)) = value;
      }
    }

    public unsafe Entity _HoveredMapZoneEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__HoveredMapZoneEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__HoveredMapZoneEntity)) = value;
      }
    }

    public unsafe Il2CppStructArray<Vector3> _WorldCorners
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__WorldCorners));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__WorldCorners), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _MapIconHover
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__MapIconHover));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__MapIconHover)) = value;
      }
    }

    public unsafe bool HasSetProjectionMatrix
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr_HasSetProjectionMatrix));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr_HasSetProjectionMatrix)) = value;
      }
    }

    public unsafe EntityQuery _ResponseEntityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ResponseEntityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__ResponseEntityQuery)) = value;
      }
    }

    public unsafe NetworkId _RecommendedGraveyardExitTeleport
    {
      get
      {
        return *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__RecommendedGraveyardExitTeleport));
      }
      [param: In] set
      {
        *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__RecommendedGraveyardExitTeleport)) = value;
      }
    }

    public static unsafe int RevealAlphaTexture
    {
      get
      {
        int revealAlphaTexture;
        IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.NativeFieldInfoPtr_RevealAlphaTexture, (void*) &revealAlphaTexture);
        return revealAlphaTexture;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.NativeFieldInfoPtr_RevealAlphaTexture, (void*) &value);
      }
    }

    public static unsafe int MapTexture
    {
      get
      {
        int mapTexture;
        IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.NativeFieldInfoPtr_MapTexture, (void*) &mapTexture);
        return mapTexture;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.NativeFieldInfoPtr_MapTexture, (void*) &value);
      }
    }

    public static unsafe int VisionData
    {
      get
      {
        int visionData;
        IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.NativeFieldInfoPtr_VisionData, (void*) &visionData);
        return visionData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.NativeFieldInfoPtr_VisionData, (void*) &value);
      }
    }

    public static unsafe int ProjectionMatrix
    {
      get
      {
        int projectionMatrix;
        IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.NativeFieldInfoPtr_ProjectionMatrix, (void*) &projectionMatrix);
        return projectionMatrix;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.NativeFieldInfoPtr_ProjectionMatrix, (void*) &value);
      }
    }

    public unsafe EntityQuery __GetMapMenu_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GetMapMenu_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GetMapMenu_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetMapMenu_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GetMapMenu_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GetMapMenu_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnStartRunning_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnStartRunning_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TerritoryHoverCalc_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___TerritoryHoverCalc_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___TerritoryHoverCalc_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TerritoryHoverCalc_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___TerritoryHoverCalc_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___TerritoryHoverCalc_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GetMapZones_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GetMapZones_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GetMapZones_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetMapZones_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GetMapZones_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GetMapZones_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateMainMapTerritories_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___UpdateMainMapTerritories_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___UpdateMainMapTerritories_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateMainMapTerritories_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___UpdateMainMapTerritories_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___UpdateMainMapTerritories_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob4_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob4_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GatherMapIcons_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GatherMapIcons_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GatherMapIcons_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GatherMapIcons_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GatherMapIcons_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___GatherMapIcons_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __FindPlayerZone_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindPlayerZone_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __FindPlayerZone2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindPlayerZone2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr___FindPlayerZone2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_CastleTerritoryManager_21
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_CastleTerritoryManager_21));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_CastleTerritoryManager_21)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalControlled_22
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_22));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_22)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TerritoryOutput
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CenterPosWS;
      private static readonly System.IntPtr NativeFieldInfoPtr_AspectRatio;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextureDataIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamStatus;
      private static readonly System.IntPtr NativeFieldInfoPtr_Hovered;
      [FieldOffset(0)]
      public float2 CenterPosWS;
      [FieldOffset(8)]
      public float2 AspectRatio;
      [FieldOffset(16)]
      public int TextureDataIndex;
      [FieldOffset(20)]
      public TerritoryMapEntry.LocalTerritoryTeamStatus TeamStatus;
      [FieldOffset(21)]
      public bool Hovered;

      static TerritoryOutput()
      {
        Il2CppClassPointerStore<MapMenuMapper.TerritoryOutput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (TerritoryOutput));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.TerritoryOutput>.NativeClassPtr);
        MapMenuMapper.TerritoryOutput.NativeFieldInfoPtr_CenterPosWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.TerritoryOutput>.NativeClassPtr, nameof (CenterPosWS));
        MapMenuMapper.TerritoryOutput.NativeFieldInfoPtr_AspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.TerritoryOutput>.NativeClassPtr, nameof (AspectRatio));
        MapMenuMapper.TerritoryOutput.NativeFieldInfoPtr_TextureDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.TerritoryOutput>.NativeClassPtr, nameof (TextureDataIndex));
        MapMenuMapper.TerritoryOutput.NativeFieldInfoPtr_TeamStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.TerritoryOutput>.NativeClassPtr, nameof (TeamStatus));
        MapMenuMapper.TerritoryOutput.NativeFieldInfoPtr_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.TerritoryOutput>.NativeClassPtr, nameof (Hovered));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.TerritoryOutput>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MapZoneOutput
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MeshIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnchoredPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_SizeDelta;
      private static readonly System.IntPtr NativeFieldInfoPtr_Color;
      [FieldOffset(0)]
      public int MeshIndex;
      [FieldOffset(4)]
      public float2 AnchoredPosition;
      [FieldOffset(12)]
      public float2 SizeDelta;
      [FieldOffset(20)]
      public Color Color;

      static MapZoneOutput()
      {
        Il2CppClassPointerStore<MapMenuMapper.MapZoneOutput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (MapZoneOutput));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.MapZoneOutput>.NativeClassPtr);
        MapMenuMapper.MapZoneOutput.NativeFieldInfoPtr_MeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.MapZoneOutput>.NativeClassPtr, nameof (MeshIndex));
        MapMenuMapper.MapZoneOutput.NativeFieldInfoPtr_AnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.MapZoneOutput>.NativeClassPtr, nameof (AnchoredPosition));
        MapMenuMapper.MapZoneOutput.NativeFieldInfoPtr_SizeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.MapZoneOutput>.NativeClassPtr, nameof (SizeDelta));
        MapMenuMapper.MapZoneOutput.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.MapZoneOutput>.NativeClassPtr, nameof (Color));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.MapZoneOutput>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HoverOutput
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HoverIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_HoveredMapZoneEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapTooltipType;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneTooltipData;
      private static readonly System.IntPtr NativeFieldInfoPtr_PylonTooltipData;
      private static readonly System.IntPtr NativeFieldInfoPtr_Team;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsAlly;
      [FieldOffset(0)]
      public int HoverIndex;
      [FieldOffset(4)]
      public Entity HoveredMapZoneEntity;
      [FieldOffset(12)]
      public MapTooltipType MapTooltipType;
      [FieldOffset(16)]
      public MapZoneTooltipData MapZoneTooltipData;
      [FieldOffset(164)]
      public PylonTooltipData PylonTooltipData;
      [FieldOffset(264)]
      public Team Team;
      [FieldOffset(272)]
      public bool IsAlly;

      static HoverOutput()
      {
        Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (HoverOutput));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr);
        MapMenuMapper.HoverOutput.NativeFieldInfoPtr_HoverIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr, nameof (HoverIndex));
        MapMenuMapper.HoverOutput.NativeFieldInfoPtr_HoveredMapZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr, nameof (HoveredMapZoneEntity));
        MapMenuMapper.HoverOutput.NativeFieldInfoPtr_MapTooltipType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr, nameof (MapTooltipType));
        MapMenuMapper.HoverOutput.NativeFieldInfoPtr_MapZoneTooltipData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr, nameof (MapZoneTooltipData));
        MapMenuMapper.HoverOutput.NativeFieldInfoPtr_PylonTooltipData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr, nameof (PylonTooltipData));
        MapMenuMapper.HoverOutput.NativeFieldInfoPtr_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr, nameof (Team));
        MapMenuMapper.HoverOutput.NativeFieldInfoPtr_IsAlly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr, nameof (IsAlly));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.HoverOutput>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ZoomData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HasData;
      private static readonly System.IntPtr NativeFieldInfoPtr_ZoomAdjust;
      private static readonly System.IntPtr NativeFieldInfoPtr_RelRectPosition;
      [FieldOffset(0)]
      public bool HasData;
      [FieldOffset(4)]
      public float ZoomAdjust;
      [FieldOffset(8)]
      public Vector2 RelRectPosition;

      static ZoomData()
      {
        Il2CppClassPointerStore<MapMenuMapper.ZoomData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, nameof (ZoomData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.ZoomData>.NativeClassPtr);
        MapMenuMapper.ZoomData.NativeFieldInfoPtr_HasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.ZoomData>.NativeClassPtr, nameof (HasData));
        MapMenuMapper.ZoomData.NativeFieldInfoPtr_ZoomAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.ZoomData>.NativeClassPtr, nameof (ZoomAdjust));
        MapMenuMapper.ZoomData.NativeFieldInfoPtr_RelRectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.ZoomData>.NativeClassPtr, nameof (RelRectPosition));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.ZoomData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass50_0")]
    public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapZoneData;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleInput_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass50_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass50_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268094, XrefRangeEnd = 1268102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleInput_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass50_0.NativeMethodInfoPtr__HandleInput_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass50_0()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass50_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass50_0>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
        MapMenuMapper.__c__DisplayClass50_0.NativeFieldInfoPtr_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass50_0>.NativeClassPtr, nameof (mapZoneData));
        MapMenuMapper.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass50_0>.NativeClassPtr, 100667794);
        MapMenuMapper.__c__DisplayClass50_0.NativeMethodInfoPtr__HandleInput_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass50_0>.NativeClassPtr, 100667795);
      }

      public __c__DisplayClass50_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe MapMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper) null : new MapMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe MapZoneData mapZoneData
      {
        get
        {
          return *(MapZoneData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass50_0.NativeFieldInfoPtr_mapZoneData));
        }
        [param: In] set
        {
          *(MapZoneData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass50_0.NativeFieldInfoPtr_mapZoneData)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass53_0")]
    public sealed class __c__DisplayClass53_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_returnValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetMapMenu_b__0_Internal_Void_Entity_MapMenu_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass53_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass53_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GetMapMenu_b__0(Entity entity, MapMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass53_0.NativeMethodInfoPtr__GetMapMenu_b__0_Internal_Void_Entity_MapMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass53_0()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass53_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass53_0>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass53_0.NativeFieldInfoPtr_returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass53_0>.NativeClassPtr, nameof (returnValue));
        MapMenuMapper.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass53_0>.NativeClassPtr, 100667796);
        MapMenuMapper.__c__DisplayClass53_0.NativeMethodInfoPtr__GetMapMenu_b__0_Internal_Void_Entity_MapMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass53_0>.NativeClassPtr, 100667797);
      }

      public __c__DisplayClass53_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass53_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass53_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass53_0>.NativeClassPtr, data));
      }

      public unsafe MapMenu returnValue
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass53_0.NativeFieldInfoPtr_returnValue));
          return pointer == System.IntPtr.Zero ? (MapMenu) null : new MapMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass53_0.NativeFieldInfoPtr_returnValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass56_0")]
    public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldToAnchoredSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_revealMaskTexture;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerZoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerExists;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapTexture;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__10;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_PointerEventData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_PointerEventData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_PointerEventData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_RecommendedSpawnLocationResponseEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__10_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass56_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268102, XrefRangeEnd = 1268103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268103, XrefRangeEnd = 1268115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268115, XrefRangeEnd = 1268136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        [In] ref RecommendedSpawnLocationResponseEvent responseEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref responseEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_RecommendedSpawnLocationResponseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268136, XrefRangeEnd = 1268138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__10()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass56_0()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass56_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_worldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, nameof (worldToAnchoredSpace));
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_revealMaskTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, nameof (revealMaskTexture));
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_playerZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, nameof (playerZoneType));
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localPlayerExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, nameof (localPlayerExists));
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localPlayerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, nameof (localPlayerEntity));
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_mapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, nameof (mapTexture));
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, nameof (localUserEntity));
        MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr___9__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, "<>9__10");
        MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, 100667798);
        MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, 100667799);
        MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, 100667800);
        MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, 100667801);
        MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_RecommendedSpawnLocationResponseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, 100667802);
        MapMenuMapper.__c__DisplayClass56_0.NativeMethodInfoPtr__OnUpdate_b__10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_0>.NativeClassPtr, 100667803);
      }

      public __c__DisplayClass56_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe MapMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper) null : new MapMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Matrix4x4 worldToAnchoredSpace
      {
        get
        {
          return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_worldToAnchoredSpace));
        }
        [param: In] set
        {
          *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_worldToAnchoredSpace)) = value;
        }
      }

      public unsafe Texture2D revealMaskTexture
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_revealMaskTexture));
          return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_revealMaskTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe WorldZone playerZoneType
      {
        get
        {
          return *(WorldZone*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_playerZoneType));
        }
        [param: In] set
        {
          *(WorldZone*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_playerZoneType)) = value;
        }
      }

      public unsafe bool localPlayerExists
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localPlayerExists));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localPlayerExists)) = value;
        }
      }

      public unsafe Entity localPlayerEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localPlayerEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localPlayerEntity)) = value;
        }
      }

      public unsafe RawImage mapTexture
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_mapTexture));
          return pointer == System.IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_mapTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe Il2CppSystem.Action __9__10
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr___9__10));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_0.NativeFieldInfoPtr___9__10), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass56_1")]
    public sealed class __c__DisplayClass56_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_found;
      private static readonly System.IntPtr NativeFieldInfoPtr_mouseWorldPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_occupants;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryHoverEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryDecayBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_hoverOutput;
      private static readonly System.IntPtr NativeFieldInfoPtr_menuMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_discoveredMapZones;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeServantMissions;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionColorNormal;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionCurrentMapZoneDataEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionColorSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionColorActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_polygonScale;
      private static readonly System.IntPtr NativeFieldInfoPtr_polygonsToShow;
      private static readonly System.IntPtr NativeFieldInfoPtr_isMouseInRevealedArea;
      private static readonly System.IntPtr NativeFieldInfoPtr_regionNamesAlpha;
      private static readonly System.IntPtr NativeFieldInfoPtr_managedDataRegistry;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_terrainManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_visionRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_filterer;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverDebugSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapIconRenderData;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_MapZoneData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_DynamicBuffer_1_MapZonePolygonVertexElement_DynamicBuffer_1_MapZoneDiscoverableElement_byref_UiPolygonMesh_byref_MapZoneData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_MapRegionNameComponent_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_Rotation_byref_MapIconData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass56_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        [In] ref CastleTerritory castleTerritory,
        [In] ref DynamicBuffer<CastleTerritoryTiles> tiles,
        [In] ref MapZoneData mapZoneData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_MapZoneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__5(
        Entity entity,
        DynamicBuffer<MapZonePolygonVertexElement> polygonData,
        DynamicBuffer<MapZoneDiscoverableElement> discoverableElements,
        [In] ref UiPolygonMesh uiPolygonMesh,
        [In] ref MapZoneData chunkMapZoneData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &polygonData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &discoverableElements;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref uiPolygonMesh;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkMapZoneData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_DynamicBuffer_1_MapZonePolygonVertexElement_DynamicBuffer_1_MapZoneDiscoverableElement_byref_UiPolygonMesh_byref_MapZoneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__6(
        Entity entities,
        [In] ref MapRegionNameComponent mapRegionName,
        [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entities;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapRegionName;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_MapRegionNameComponent_byref_Translation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__7(
        Entity entity,
        [In] ref PrefabGUID prefabGUID,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref MapIconData mapIconData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapIconData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_Rotation_byref_MapIconData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass56_1()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass56_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_found = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (found));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_mouseWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (mouseWorldPosition));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (occupants));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_territoryHoverEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (territoryHoverEntity));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (localPlayerTeam));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_territoryDecayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (territoryDecayBuffer));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_hoverOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (hoverOutput));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_menuMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (menuMode));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_discoveredMapZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (discoveredMapZones));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_activeServantMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (activeServantMissions));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (servantMissionColorNormal));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionCurrentMapZoneDataEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (servantMissionCurrentMapZoneDataEntity));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (servantMissionColorSelected));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (servantMissionColorActive));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_polygonScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (polygonScale));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_polygonsToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (polygonsToShow));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_isMouseInRevealedArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (isMouseInRevealedArea));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_regionNamesAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (regionNamesAlpha));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_managedDataRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (managedDataRegistry));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (balanceSettings));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_terrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (terrainManager));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_playerTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (playerTranslation));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_visionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (visionRange));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_filterer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (filterer));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_serverDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (serverDebugSettings));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_mapIconRenderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, nameof (mapIconRenderData));
        MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, "CS$<>8__locals1");
        MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, 100667804);
        MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_MapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, 100667805);
        MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_Entity_DynamicBuffer_1_MapZonePolygonVertexElement_DynamicBuffer_1_MapZoneDiscoverableElement_byref_UiPolygonMesh_byref_MapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, 100667806);
        MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_Entity_byref_MapRegionNameComponent_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, 100667807);
        MapMenuMapper.__c__DisplayClass56_1.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_Rotation_byref_MapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_1>.NativeClassPtr, 100667808);
      }

      public __c__DisplayClass56_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe bool found
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_found));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_found)) = value;
        }
      }

      public unsafe float3 mouseWorldPosition
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_mouseWorldPosition));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_mouseWorldPosition)) = value;
        }
      }

      public unsafe DynamicBuffer<CastleTerritoryOccupant> occupants
      {
        get
        {
          return *(DynamicBuffer<CastleTerritoryOccupant>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_occupants));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_occupants), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<CastleTerritoryOccupant>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Entity territoryHoverEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_territoryHoverEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_territoryHoverEntity)) = value;
        }
      }

      public unsafe Team localPlayerTeam
      {
        get
        {
          return *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_localPlayerTeam));
        }
        [param: In] set
        {
          *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_localPlayerTeam)) = value;
        }
      }

      public unsafe DynamicBuffer<CastleTerritoryDecay> territoryDecayBuffer
      {
        get
        {
          return *(DynamicBuffer<CastleTerritoryDecay>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_territoryDecayBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_territoryDecayBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<CastleTerritoryDecay>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe MapMenuMapper.HoverOutput hoverOutput
      {
        get
        {
          return *(MapMenuMapper.HoverOutput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_hoverOutput));
        }
        [param: In] set
        {
          *(MapMenuMapper.HoverOutput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_hoverOutput)) = value;
        }
      }

      public unsafe MapMenuMode menuMode
      {
        get
        {
          return *(MapMenuMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_menuMode));
        }
        [param: In] set
        {
          *(MapMenuMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_menuMode)) = value;
        }
      }

      public unsafe DynamicBuffer<DiscoveredMapZoneElement> discoveredMapZones
      {
        get
        {
          return *(DynamicBuffer<DiscoveredMapZoneElement>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_discoveredMapZones));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_discoveredMapZones), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<DiscoveredMapZoneElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DynamicBuffer<ActiveServantMission> activeServantMissions
      {
        get
        {
          return *(DynamicBuffer<ActiveServantMission>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_activeServantMissions));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_activeServantMissions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<ActiveServantMission>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Color servantMissionColorNormal
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorNormal));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorNormal)) = value;
        }
      }

      public unsafe Entity servantMissionCurrentMapZoneDataEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionCurrentMapZoneDataEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionCurrentMapZoneDataEntity)) = value;
        }
      }

      public unsafe Color servantMissionColorSelected
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorSelected));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorSelected)) = value;
        }
      }

      public unsafe Color servantMissionColorActive
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorActive));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_servantMissionColorActive)) = value;
        }
      }

      public unsafe float polygonScale
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_polygonScale));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_polygonScale)) = value;
        }
      }

      public unsafe NativeList<MapMenuMapper.MapZoneOutput> polygonsToShow
      {
        get
        {
          return *(NativeList<MapMenuMapper.MapZoneOutput>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_polygonsToShow));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_polygonsToShow), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MapMenuMapper.MapZoneOutput>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool isMouseInRevealedArea
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_isMouseInRevealedArea));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_isMouseInRevealedArea)) = value;
        }
      }

      public unsafe float regionNamesAlpha
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_regionNamesAlpha));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_regionNamesAlpha)) = value;
        }
      }

      public ManagedDataRegistry managedDataRegistry
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_managedDataRegistry);
          return new ManagedDataRegistry(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_managedDataRegistry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServerGameBalanceSettings balanceSettings
      {
        get
        {
          return *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_balanceSettings));
        }
        [param: In] set
        {
          *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_balanceSettings)) = value;
        }
      }

      public unsafe TerrainManager terrainManager
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_terrainManager));
          return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_terrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Translation playerTranslation
      {
        get
        {
          return *(Translation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_playerTranslation));
        }
        [param: In] set
        {
          *(Translation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_playerTranslation)) = value;
        }
      }

      public unsafe float visionRange
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_visionRange));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_visionRange)) = value;
        }
      }

      public TextFilterer filterer
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_filterer);
          return new TextFilterer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_filterer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SyncedServerDebugSettings serverDebugSettings
      {
        get
        {
          return *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_serverDebugSettings));
        }
        [param: In] set
        {
          *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_serverDebugSettings)) = value;
        }
      }

      public unsafe NativeList<MapIconRenderData> mapIconRenderData
      {
        get
        {
          return *(NativeList<MapIconRenderData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_mapIconRenderData));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_mapIconRenderData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MapIconRenderData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass56_0 field_Public___c__DisplayClass56_0_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper.__c__DisplayClass56_0) null : new MapMenuMapper.__c__DisplayClass56_0(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_1.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass56_2")]
    public sealed class __c__DisplayClass56_2 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_halfBlock;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryScale;
      private static readonly System.IntPtr NativeFieldInfoPtr_zoomFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__8_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass56_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__8(
        Entity entity,
        [In] ref CastleTerritory castleTerritory,
        [In] ref MapZoneData mapZoneData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_2.NativeMethodInfoPtr__OnUpdate_b__8_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass56_2()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass56_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_halfBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr, nameof (halfBlock));
        MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_territoryScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr, nameof (territoryScale));
        MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_zoomFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr, nameof (zoomFactor));
        MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_field_Public___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr, "CS$<>8__locals2");
        MapMenuMapper.__c__DisplayClass56_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr, 100667809);
        MapMenuMapper.__c__DisplayClass56_2.NativeMethodInfoPtr__OnUpdate_b__8_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_2>.NativeClassPtr, 100667810);
      }

      public __c__DisplayClass56_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe float2 halfBlock
      {
        get
        {
          return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_halfBlock));
        }
        [param: In] set
        {
          *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_halfBlock)) = value;
        }
      }

      public unsafe float territoryScale
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_territoryScale));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_territoryScale)) = value;
        }
      }

      public unsafe float zoomFactor
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_zoomFactor));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_zoomFactor)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass56_1 field_Public___c__DisplayClass56_1_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_field_Public___c__DisplayClass56_1_0));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper.__c__DisplayClass56_1) null : new MapMenuMapper.__c__DisplayClass56_1(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_2.NativeFieldInfoPtr_field_Public___c__DisplayClass56_1_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass56_3")]
    public sealed class __c__DisplayClass56_3 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__11_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass56_3()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268138, XrefRangeEnd = 1268139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__11()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_3.NativeMethodInfoPtr__OnUpdate_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass56_3()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass56_3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_3>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass56_3.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_3>.NativeClassPtr, nameof (entry));
        MapMenuMapper.__c__DisplayClass56_3.NativeFieldInfoPtr_field_Public___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_3>.NativeClassPtr, "CS$<>8__locals3");
        MapMenuMapper.__c__DisplayClass56_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_3>.NativeClassPtr, 100667811);
        MapMenuMapper.__c__DisplayClass56_3.NativeMethodInfoPtr__OnUpdate_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_3>.NativeClassPtr, 100667812);
      }

      public __c__DisplayClass56_3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe MapIconRenderData entry
      {
        get
        {
          return *(MapIconRenderData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_3.NativeFieldInfoPtr_entry));
        }
        [param: In] set
        {
          *(MapIconRenderData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_3.NativeFieldInfoPtr_entry)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass56_1 field_Public___c__DisplayClass56_1_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_3.NativeFieldInfoPtr_field_Public___c__DisplayClass56_1_0));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper.__c__DisplayClass56_1) null : new MapMenuMapper.__c__DisplayClass56_1(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_3.NativeFieldInfoPtr_field_Public___c__DisplayClass56_1_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass56_4")]
    public sealed class __c__DisplayClass56_4 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromId;
      private static readonly System.IntPtr NativeFieldInfoPtr_toId;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass56_3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__9_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass56_4()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_4>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268139, XrefRangeEnd = 1268141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__9()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass56_4.NativeMethodInfoPtr__OnUpdate_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass56_4()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass56_4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_4>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_fromId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_4>.NativeClassPtr, nameof (fromId));
        MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_toId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_4>.NativeClassPtr, nameof (toId));
        MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_field_Public___c__DisplayClass56_3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_4>.NativeClassPtr, "CS$<>8__locals4");
        MapMenuMapper.__c__DisplayClass56_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_4>.NativeClassPtr, 100667813);
        MapMenuMapper.__c__DisplayClass56_4.NativeMethodInfoPtr__OnUpdate_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass56_4>.NativeClassPtr, 100667814);
      }

      public __c__DisplayClass56_4(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe NetworkId fromId
      {
        get
        {
          return *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_fromId));
        }
        [param: In] set
        {
          *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_fromId)) = value;
        }
      }

      public unsafe NetworkId toId
      {
        get
        {
          return *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_toId));
        }
        [param: In] set
        {
          *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_toId)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass56_3 field_Public___c__DisplayClass56_3_0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_field_Public___c__DisplayClass56_3_0));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper.__c__DisplayClass56_3) null : new MapMenuMapper.__c__DisplayClass56_3(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass56_4.NativeFieldInfoPtr_field_Public___c__DisplayClass56_3_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass85_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass85_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_zoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentChunk;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldZoneEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__FindZoneEntity_b__0_Internal_Void_Entity_byref_WorldZoneId_0;
      [FieldOffset(0)]
      public WorldZone zoneType;
      [FieldOffset(4)]
      public TerrainChunk currentChunk;
      [FieldOffset(12)]
      public Entity worldZoneEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass85_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _FindZoneEntity_b__0(Entity entity, [In] ref WorldZoneId worldZoneId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldZoneId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass85_0.NativeMethodInfoPtr__FindZoneEntity_b__0_Internal_Void_Entity_byref_WorldZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass85_0()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass85_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass85_0>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass85_0.NativeFieldInfoPtr_zoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass85_0>.NativeClassPtr, nameof (zoneType));
        MapMenuMapper.__c__DisplayClass85_0.NativeFieldInfoPtr_currentChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass85_0>.NativeClassPtr, nameof (currentChunk));
        MapMenuMapper.__c__DisplayClass85_0.NativeFieldInfoPtr_worldZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass85_0>.NativeClassPtr, nameof (worldZoneEntity));
        MapMenuMapper.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass85_0>.NativeClassPtr, 100667815);
        MapMenuMapper.__c__DisplayClass85_0.NativeMethodInfoPtr__FindZoneEntity_b__0_Internal_Void_Entity_byref_WorldZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass85_0>.NativeClassPtr, 100667816);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass85_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/<>c__DisplayClass86_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass86_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_zoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldZoneEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__FindZoneEntity_b__0_Internal_Void_Entity_byref_WorldZoneId_0;
      [FieldOffset(0)]
      public WorldZone zoneType;
      [FieldOffset(4)]
      public Entity worldZoneEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass86_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass86_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _FindZoneEntity_b__0(Entity entity, [In] ref WorldZoneId worldZoneId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldZoneId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass86_0.NativeMethodInfoPtr__FindZoneEntity_b__0_Internal_Void_Entity_byref_WorldZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass86_0()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass86_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass86_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass86_0>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass86_0.NativeFieldInfoPtr_zoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass86_0>.NativeClassPtr, nameof (zoneType));
        MapMenuMapper.__c__DisplayClass86_0.NativeFieldInfoPtr_worldZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass86_0>.NativeClassPtr, nameof (worldZoneEntity));
        MapMenuMapper.__c__DisplayClass86_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass86_0>.NativeClassPtr, 100667817);
        MapMenuMapper.__c__DisplayClass86_0.NativeMethodInfoPtr__FindZoneEntity_b__0_Internal_Void_Entity_byref_WorldZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass86_0>.NativeClassPtr, 100667818);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass86_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_GetMapMenu_LambdaJob0")]
    public sealed class __c__DisplayClass_GetMapMenu_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_returnValue;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_MapMenu_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass53_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass53_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass53_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1268153, RefRangeEnd = 1268156, XrefRangeStart = 1268152, XrefRangeEnd = 1268153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, MapMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_MapMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(18)]
      [CachedScanResults(RefRangeStart = 755322, RefRangeEnd = 755340, XrefRangeStart = 755322, XrefRangeEnd = 755340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MapMenuMapper.__c__DisplayClass53_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass53_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 755341, RefRangeEnd = 755365, XrefRangeStart = 755341, XrefRangeEnd = 755365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MapMenuMapper.__c__DisplayClass53_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass53_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268156, XrefRangeEnd = 1268158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268164, RefRangeEnd = 1268165, XrefRangeStart = 1268158, XrefRangeEnd = 1268164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268167, RefRangeEnd = 1268168, XrefRangeStart = 1268165, XrefRangeEnd = 1268167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        ref MapMenuMapper.__c__DisplayClass53_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass53_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268168, XrefRangeEnd = 1268174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetMapMenu_LambdaJob0()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_GetMapMenu_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr_returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, nameof (returnValue));
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_MapMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, 100667819);
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass53_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, 100667820);
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass53_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, 100667821);
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, 100667822);
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, 100667823);
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass53_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, 100667824);
        MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, 100667825);
      }

      public __c__DisplayClass_GetMapMenu_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_GetMapMenu_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe MapMenu returnValue
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr_returnValue));
          return pointer == System.IntPtr.Zero ? (MapMenu) null : new MapMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr_returnValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menu;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<MapMenu> forParameter_menu;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268145, RefRangeEnd = 1268146, XrefRangeStart = 1268141, XrefRangeEnd = 1268145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268151, RefRangeEnd = 1268152, XrefRangeStart = 1268146, XrefRangeEnd = 1268151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menu));
          MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667826);
          MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667827);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menu;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menu));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<MapMenu>.Runtime runtime_menu
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu);
              return new LambdaParameterValueProvider_ManagedComponentData<MapMenu>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<MapMenu>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GetMapMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<MapMenu>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_OnStartRunning_LambdaJob0")]
    public sealed class __c__DisplayClass_OnStartRunning_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_InitData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268184, XrefRangeEnd = 1268186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref MapMenu.InitData initData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref initData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_InitData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268186, XrefRangeEnd = 1268200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268206, RefRangeEnd = 1268207, XrefRangeStart = 1268200, XrefRangeEnd = 1268206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnStartRunning_LambdaJob0()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnStartRunning_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_InitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100667828);
        MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100667830);
        MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100667831);
        MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100667832);
      }

      public __c__DisplayClass_OnStartRunning_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnStartRunning_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe MapMenuMapper hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper) null : new MapMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_initData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<MapMenu.InitData> forParameter_initData;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268174, XrefRangeEnd = 1268178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268183, RefRangeEnd = 1268184, XrefRangeStart = 1268178, XrefRangeEnd = 1268183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_initData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_initData));
          MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667833);
          MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667834);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_initData;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<MapMenu.InitData>.StructuralChangeRuntime runtime_initData;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_initData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_initData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_TerritoryHoverCalc")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TerritoryHoverCalc
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_found;
      private static readonly System.IntPtr NativeFieldInfoPtr_mouseWorldPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_occupants;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryHoverEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryDecayBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_hoverOutput;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_MapZoneData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool found;
      [FieldOffset(4)]
      public float3 mouseWorldPosition;
      [FieldOffset(16)]
      public DynamicBuffer<CastleTerritoryOccupant> occupants;
      [FieldOffset(32)]
      public Entity territoryHoverEntity;
      [FieldOffset(40)]
      public Team localPlayerTeam;
      [FieldOffset(48)]
      public DynamicBuffer<CastleTerritoryDecay> territoryDecayBuffer;
      [FieldOffset(64)]
      public MapMenuMapper.HoverOutput hoverOutput;
      [FieldOffset(344)]
      public MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(456)]
      public unsafe MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268304, XrefRangeEnd = 1268321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref CastleTerritory castleTerritory,
        [In] ref DynamicBuffer<CastleTerritoryTiles> tiles,
        [In] ref MapZoneData mapZoneData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_MapZoneData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268321, RefRangeEnd = 1268322, XrefRangeStart = 1268321, XrefRangeEnd = 1268321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268322, RefRangeEnd = 1268323, XrefRangeStart = 1268322, XrefRangeEnd = 1268322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268323, XrefRangeEnd = 1268325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268337, RefRangeEnd = 1268338, XrefRangeStart = 1268325, XrefRangeEnd = 1268337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268340, RefRangeEnd = 1268341, XrefRangeStart = 1268338, XrefRangeEnd = 1268340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268341, XrefRangeEnd = 1268345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268345, XrefRangeEnd = 1268351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TerritoryHoverCalc()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_TerritoryHoverCalc");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_found = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (found));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_mouseWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (mouseWorldPosition));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (occupants));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_territoryHoverEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (territoryHoverEntity));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (localPlayerTeam));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_territoryDecayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (territoryDecayBuffer));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_hoverOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (hoverOutput));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryTiles_byref_MapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, 100667835);
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, 100667836);
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, 100667837);
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, 100667838);
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, 100667839);
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, 100667840);
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, 100667841);
        MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, 100667842);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleTerritory;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tiles;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapZoneData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_castleTerritory;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles> forParameter_tiles;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<MapZoneData> forParameter_mapZoneData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268217, RefRangeEnd = 1268218, XrefRangeStart = 1268207, XrefRangeEnd = 1268217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268228, RefRangeEnd = 1268229, XrefRangeStart = 1268218, XrefRangeEnd = 1268228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleTerritory));
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tiles));
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapZoneData));
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr, 100667843);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr, 100667844);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleTerritory;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tiles;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapZoneData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_castleTerritory;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles>.Runtime runtime_tiles;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<MapZoneData>.Runtime runtime_mapZoneData;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleTerritory));
            MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tiles));
            MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapZoneData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_TerritoryHoverCalc/ProjectM.UI.RunWithoutJobSystem_00001049$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, "RunWithoutJobSystem_00001049$PostfixBurstDelegate");
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667845);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667846);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667847);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667848);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_TerritoryHoverCalc/ProjectM.UI.RunWithoutJobSystem_00001049$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268229, XrefRangeEnd = 1268243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268243, XrefRangeEnd = 1268261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268261, XrefRangeEnd = 1268276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268303, RefRangeEnd = 1268304, XrefRangeStart = 1268276, XrefRangeEnd = 1268303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc>.NativeClassPtr, "RunWithoutJobSystem_00001049$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667849);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667850);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667851);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667852);
          MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667854);
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
            IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_TerritoryHoverCalc.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RecommendedSpawnLocationResponseEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268371, RefRangeEnd = 1268372, XrefRangeStart = 1268359, XrefRangeEnd = 1268371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RecommendedSpawnLocationResponseEvent responseEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref responseEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RecommendedSpawnLocationResponseEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1261517, RefRangeEnd = 1261519, XrefRangeStart = 1261517, XrefRangeEnd = 1261519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        MapMenuMapper.__c__DisplayClass56_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1261530, RefRangeEnd = 1261532, XrefRangeStart = 1261530, XrefRangeEnd = 1261532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        MapMenuMapper.__c__DisplayClass56_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268372, XrefRangeEnd = 1268374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268379, RefRangeEnd = 1268380, XrefRangeStart = 1268374, XrefRangeEnd = 1268379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268382, RefRangeEnd = 1268383, XrefRangeStart = 1268380, XrefRangeEnd = 1268382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        MapMenuMapper.__c__DisplayClass56_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268383, XrefRangeEnd = 1268389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "<>4__this");
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RecommendedSpawnLocationResponseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667855);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667856);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667857);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667858);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667859);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667860);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100667861);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, data));
      }

      public unsafe MapMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper) null : new MapMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_responseEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RecommendedSpawnLocationResponseEvent> forParameter_responseEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268354, RefRangeEnd = 1268355, XrefRangeStart = 1268351, XrefRangeEnd = 1268354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268358, RefRangeEnd = 1268359, XrefRangeStart = 1268355, XrefRangeEnd = 1268358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_responseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_responseEvent));
          MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100667862);
          MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100667863);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_responseEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RecommendedSpawnLocationResponseEvent>.Runtime runtime_responseEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_responseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_responseEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_GetMapZones")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GetMapZones
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_menuMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_discoveredMapZones;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeServantMissions;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionColorNormal;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionCurrentMapZoneDataEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionColorSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionColorActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldToAnchoredSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_polygonScale;
      private static readonly System.IntPtr NativeFieldInfoPtr_polygonsToShow;
      private static readonly System.IntPtr NativeFieldInfoPtr_isMouseInRevealedArea;
      private static readonly System.IntPtr NativeFieldInfoPtr_mouseWorldPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_hoverOutput;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_MapZonePolygonVertexElement_DynamicBuffer_1_MapZoneDiscoverableElement_byref_UiPolygonMesh_byref_MapZoneData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public MapMenuMode menuMode;
      [FieldOffset(8)]
      public DynamicBuffer<DiscoveredMapZoneElement> discoveredMapZones;
      [FieldOffset(24)]
      public DynamicBuffer<ActiveServantMission> activeServantMissions;
      [FieldOffset(40)]
      public Color servantMissionColorNormal;
      [FieldOffset(56)]
      public Entity servantMissionCurrentMapZoneDataEntity;
      [FieldOffset(64)]
      public Color servantMissionColorSelected;
      [FieldOffset(80)]
      public Color servantMissionColorActive;
      [FieldOffset(96)]
      public Matrix4x4 worldToAnchoredSpace;
      [FieldOffset(160)]
      public float polygonScale;
      [FieldOffset(168)]
      public NativeList<MapMenuMapper.MapZoneOutput> polygonsToShow;
      [FieldOffset(184)]
      public bool isMouseInRevealedArea;
      [FieldOffset(188)]
      public float3 mouseWorldPosition;
      [FieldOffset(200)]
      public MapMenuMapper.HoverOutput hoverOutput;
      [FieldOffset(480)]
      public MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(632)]
      public unsafe MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268492, XrefRangeEnd = 1268525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        DynamicBuffer<MapZonePolygonVertexElement> polygonData,
        DynamicBuffer<MapZoneDiscoverableElement> discoverableElements,
        [In] ref UiPolygonMesh uiPolygonMesh,
        [In] ref MapZoneData chunkMapZoneData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &polygonData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &discoverableElements;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref uiPolygonMesh;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkMapZoneData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_MapZonePolygonVertexElement_DynamicBuffer_1_MapZoneDiscoverableElement_byref_UiPolygonMesh_byref_MapZoneData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268525, RefRangeEnd = 1268526, XrefRangeStart = 1268525, XrefRangeEnd = 1268525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268526, RefRangeEnd = 1268527, XrefRangeStart = 1268526, XrefRangeEnd = 1268526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268527, XrefRangeEnd = 1268529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268544, RefRangeEnd = 1268545, XrefRangeStart = 1268529, XrefRangeEnd = 1268544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268547, RefRangeEnd = 1268548, XrefRangeStart = 1268545, XrefRangeEnd = 1268547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268548, XrefRangeEnd = 1268552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268552, XrefRangeEnd = 1268558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetMapZones()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_GetMapZones");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_menuMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (menuMode));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_discoveredMapZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (discoveredMapZones));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_activeServantMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (activeServantMissions));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_servantMissionColorNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (servantMissionColorNormal));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_servantMissionCurrentMapZoneDataEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (servantMissionCurrentMapZoneDataEntity));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_servantMissionColorSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (servantMissionColorSelected));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_servantMissionColorActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (servantMissionColorActive));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_worldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (worldToAnchoredSpace));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_polygonScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (polygonScale));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_polygonsToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (polygonsToShow));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_isMouseInRevealedArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (isMouseInRevealedArea));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_mouseWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (mouseWorldPosition));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_hoverOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (hoverOutput));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_MapZonePolygonVertexElement_DynamicBuffer_1_MapZoneDiscoverableElement_byref_UiPolygonMesh_byref_MapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100667864);
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100667865);
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100667866);
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100667867);
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100667868);
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100667869);
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100667870);
        MapMenuMapper.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100667871);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_polygonData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_discoverableElements;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_uiPolygonMesh;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chunkMapZoneData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<MapZonePolygonVertexElement> forParameter_polygonData;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_DynamicBuffer<MapZoneDiscoverableElement> forParameter_discoverableElements;
        [FieldOffset(88)]
        public LambdaParameterValueProvider_IComponentData<UiPolygonMesh> forParameter_uiPolygonMesh;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_IComponentData<MapZoneData> forParameter_chunkMapZoneData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268402, RefRangeEnd = 1268403, XrefRangeStart = 1268389, XrefRangeEnd = 1268402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268416, RefRangeEnd = 1268417, XrefRangeStart = 1268403, XrefRangeEnd = 1268416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_polygonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_polygonData));
          MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_discoverableElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_discoverableElements));
          MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_uiPolygonMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_uiPolygonMesh));
          MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chunkMapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chunkMapZoneData));
          MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, 100667872);
          MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, 100667873);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_polygonData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_discoverableElements;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_uiPolygonMesh;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chunkMapZoneData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<MapZonePolygonVertexElement>.Runtime runtime_polygonData;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<MapZoneDiscoverableElement>.Runtime runtime_discoverableElements;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<UiPolygonMesh>.Runtime runtime_uiPolygonMesh;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<MapZoneData>.Runtime runtime_chunkMapZoneData;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_polygonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_polygonData));
            MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_discoverableElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_discoverableElements));
            MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_uiPolygonMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_uiPolygonMesh));
            MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chunkMapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chunkMapZoneData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_GetMapZones/ProjectM.UI.RunWithoutJobSystem_0000105B$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, "RunWithoutJobSystem_0000105B$PostfixBurstDelegate");
          MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667874);
          MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667875);
          MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667876);
          MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667877);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_GetMapZones/ProjectM.UI.RunWithoutJobSystem_0000105B$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268417, XrefRangeEnd = 1268431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268431, XrefRangeEnd = 1268449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268449, XrefRangeEnd = 1268464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268491, RefRangeEnd = 1268492, XrefRangeStart = 1268464, XrefRangeEnd = 1268491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones>.NativeClassPtr, "RunWithoutJobSystem_0000105B$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667878);
          MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667879);
          MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667880);
          MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667881);
          MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667883);
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
            IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_UpdateMainMapTerritories")]
    public sealed class __c__DisplayClass_UpdateMainMapTerritories : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_occupants;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryHoverEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryDecayBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_halfBlock;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryScale;
      private static readonly System.IntPtr NativeFieldInfoPtr_hoverOutput;
      private static readonly System.IntPtr NativeFieldInfoPtr_zoomFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_revealMaskTexture;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268600, RefRangeEnd = 1268601, XrefRangeStart = 1268574, XrefRangeEnd = 1268600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref CastleTerritory castleTerritory,
        [In] ref MapZoneData mapZoneData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268604, RefRangeEnd = 1268605, XrefRangeStart = 1268601, XrefRangeEnd = 1268604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        MapMenuMapper.__c__DisplayClass56_2 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268638, RefRangeEnd = 1268639, XrefRangeStart = 1268605, XrefRangeEnd = 1268638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        MapMenuMapper.__c__DisplayClass56_2 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268639, XrefRangeEnd = 1268641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268650, RefRangeEnd = 1268651, XrefRangeStart = 1268641, XrefRangeEnd = 1268650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268653, RefRangeEnd = 1268654, XrefRangeStart = 1268651, XrefRangeEnd = 1268653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        MapMenuMapper.__c__DisplayClass56_2 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268654, XrefRangeEnd = 1268660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateMainMapTerritories()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_UpdateMainMapTerritories");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (occupants));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryHoverEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (territoryHoverEntity));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (localPlayerTeam));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryDecayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (territoryDecayBuffer));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, "<>4__this");
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_halfBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (halfBlock));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (territoryScale));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_hoverOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (hoverOutput));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_zoomFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (zoomFactor));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_revealMaskTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (revealMaskTexture));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, 100667884);
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, 100667885);
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, 100667886);
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, 100667887);
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, 100667888);
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, 100667889);
        MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, 100667890);
      }

      public __c__DisplayClass_UpdateMainMapTerritories(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateMainMapTerritories()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, data));
      }

      public unsafe DynamicBuffer<CastleTerritoryOccupant> occupants
      {
        get
        {
          return *(DynamicBuffer<CastleTerritoryOccupant>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_occupants));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_occupants), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<CastleTerritoryOccupant>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Entity territoryHoverEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryHoverEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryHoverEntity)) = value;
        }
      }

      public unsafe Team localPlayerTeam
      {
        get
        {
          return *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_localPlayerTeam));
        }
        [param: In] set
        {
          *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_localPlayerTeam)) = value;
        }
      }

      public unsafe DynamicBuffer<CastleTerritoryDecay> territoryDecayBuffer
      {
        get
        {
          return *(DynamicBuffer<CastleTerritoryDecay>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryDecayBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryDecayBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<CastleTerritoryDecay>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe MapMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper) null : new MapMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float2 halfBlock
      {
        get
        {
          return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_halfBlock));
        }
        [param: In] set
        {
          *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_halfBlock)) = value;
        }
      }

      public unsafe float territoryScale
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryScale));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_territoryScale)) = value;
        }
      }

      public unsafe MapMenuMapper.HoverOutput hoverOutput
      {
        get
        {
          return *(MapMenuMapper.HoverOutput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_hoverOutput));
        }
        [param: In] set
        {
          *(MapMenuMapper.HoverOutput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_hoverOutput)) = value;
        }
      }

      public unsafe float zoomFactor
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_zoomFactor));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_zoomFactor)) = value;
        }
      }

      public unsafe Texture2D revealMaskTexture
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_revealMaskTexture));
          return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_revealMaskTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleTerritory;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapZoneData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_castleTerritory;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<MapZoneData> forParameter_mapZoneData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268565, RefRangeEnd = 1268566, XrefRangeStart = 1268558, XrefRangeEnd = 1268565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268573, RefRangeEnd = 1268574, XrefRangeStart = 1268566, XrefRangeEnd = 1268573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleTerritory));
          MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapZoneData));
          MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders>.NativeClassPtr, 100667891);
          MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders>.NativeClassPtr, 100667892);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleTerritory;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapZoneData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_castleTerritory;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<MapZoneData>.Runtime runtime_mapZoneData;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleTerritory));
            MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapZoneData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_UpdateMainMapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob4")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob4 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_regionNamesAlpha;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapRegionNameComponent_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268681, RefRangeEnd = 1268682, XrefRangeStart = 1268676, XrefRangeEnd = 1268681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entities,
        [In] ref MapRegionNameComponent mapRegionName,
        [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entities;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapRegionName;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapRegionNameComponent_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268683, RefRangeEnd = 1268684, XrefRangeStart = 1268682, XrefRangeEnd = 1268683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268685, RefRangeEnd = 1268686, XrefRangeStart = 1268684, XrefRangeEnd = 1268685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268686, XrefRangeEnd = 1268688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268697, RefRangeEnd = 1268698, XrefRangeStart = 1268688, XrefRangeEnd = 1268697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268700, RefRangeEnd = 1268701, XrefRangeStart = 1268698, XrefRangeEnd = 1268700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268701, XrefRangeEnd = 1268707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob4()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, "<>4__this");
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_regionNamesAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (regionNamesAlpha));
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapRegionNameComponent_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667893);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667894);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667895);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667896);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667897);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667898);
        MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100667899);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob4(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob4()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, data));
      }

      public unsafe MapMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper) null : new MapMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float regionNamesAlpha
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_regionNamesAlpha));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_regionNamesAlpha)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entities;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapRegionName;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entities;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<MapRegionNameComponent> forParameter_mapRegionName;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268667, RefRangeEnd = 1268668, XrefRangeStart = 1268660, XrefRangeEnd = 1268667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268675, RefRangeEnd = 1268676, XrefRangeStart = 1268668, XrefRangeEnd = 1268675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entities));
          MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapRegionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapRegionName));
          MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100667900);
          MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100667901);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entities;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapRegionName;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entities;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<MapRegionNameComponent>.Runtime runtime_mapRegionName;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entities));
            MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapRegionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapRegionName));
            MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_GatherMapIcons")]
    public sealed class __c__DisplayClass_GatherMapIcons : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_managedDataRegistry;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_terrainManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerZoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerExists;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_visionRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapTexture;
      private static readonly System.IntPtr NativeFieldInfoPtr_revealMaskTexture;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_filterer;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverDebugSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldToAnchoredSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapIconRenderData;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CastleHeart_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_Rotation_byref_MapIconData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268808, RefRangeEnd = 1268809, XrefRangeStart = 1268735, XrefRangeEnd = 1268808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref PrefabGUID prefabGUID,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref MapIconData mapIconData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapIconData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_Rotation_byref_MapIconData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268816, RefRangeEnd = 1268817, XrefRangeStart = 1268809, XrefRangeEnd = 1268816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268824, RefRangeEnd = 1268825, XrefRangeStart = 1268817, XrefRangeEnd = 1268824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268825, XrefRangeEnd = 1268827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268842, RefRangeEnd = 1268843, XrefRangeStart = 1268827, XrefRangeEnd = 1268842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268848, RefRangeEnd = 1268849, XrefRangeStart = 1268843, XrefRangeEnd = 1268848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        MapMenuMapper.__c__DisplayClass56_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268849, XrefRangeEnd = 1268855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GatherMapIcons()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_GatherMapIcons");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, "<>4__this");
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_managedDataRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (managedDataRegistry));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (balanceSettings));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_terrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (terrainManager));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_playerZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (playerZoneType));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (localPlayerExists));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (localPlayerEntity));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_playerTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (playerTranslation));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_visionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (visionRange));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_mapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (mapTexture));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_revealMaskTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (revealMaskTexture));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (localPlayerTeam));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_filterer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (filterer));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (localUserEntity));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_serverDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (serverDebugSettings));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_worldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (worldToAnchoredSpace));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_mapIconRenderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (mapIconRenderData));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__ComponentDataFromEntity_CastleHeart_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (_ComponentDataFromEntity_CastleHeart_0));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_Rotation_byref_MapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, 100667902);
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, 100667903);
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, 100667904);
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, 100667905);
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, 100667906);
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper___c__DisplayClass56_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, 100667907);
        MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, 100667908);
      }

      public __c__DisplayClass_GatherMapIcons(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_GatherMapIcons()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, data));
      }

      public unsafe MapMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MapMenuMapper) null : new MapMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public ManagedDataRegistry managedDataRegistry
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_managedDataRegistry);
          return new ManagedDataRegistry(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_managedDataRegistry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServerGameBalanceSettings balanceSettings
      {
        get
        {
          return *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_balanceSettings));
        }
        [param: In] set
        {
          *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_balanceSettings)) = value;
        }
      }

      public unsafe TerrainManager terrainManager
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_terrainManager));
          return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_terrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe WorldZone playerZoneType
      {
        get
        {
          return *(WorldZone*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_playerZoneType));
        }
        [param: In] set
        {
          *(WorldZone*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_playerZoneType)) = value;
        }
      }

      public unsafe bool localPlayerExists
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerExists));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerExists)) = value;
        }
      }

      public unsafe Entity localPlayerEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerEntity)) = value;
        }
      }

      public unsafe Translation playerTranslation
      {
        get
        {
          return *(Translation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_playerTranslation));
        }
        [param: In] set
        {
          *(Translation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_playerTranslation)) = value;
        }
      }

      public unsafe float visionRange
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_visionRange));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_visionRange)) = value;
        }
      }

      public unsafe RawImage mapTexture
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_mapTexture));
          return pointer == System.IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_mapTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Texture2D revealMaskTexture
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_revealMaskTexture));
          return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_revealMaskTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Team localPlayerTeam
      {
        get
        {
          return *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerTeam));
        }
        [param: In] set
        {
          *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localPlayerTeam)) = value;
        }
      }

      public TextFilterer filterer
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_filterer);
          return new TextFilterer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_filterer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe SyncedServerDebugSettings serverDebugSettings
      {
        get
        {
          return *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_serverDebugSettings));
        }
        [param: In] set
        {
          *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_serverDebugSettings)) = value;
        }
      }

      public unsafe Matrix4x4 worldToAnchoredSpace
      {
        get
        {
          return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_worldToAnchoredSpace));
        }
        [param: In] set
        {
          *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_worldToAnchoredSpace)) = value;
        }
      }

      public unsafe NativeList<MapIconRenderData> mapIconRenderData
      {
        get
        {
          return *(NativeList<MapIconRenderData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_mapIconRenderData));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_mapIconRenderData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MapIconRenderData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<CastleHeart> _ComponentDataFromEntity_CastleHeart_0
      {
        get
        {
          return *(ComponentDataFromEntity<CastleHeart>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__ComponentDataFromEntity_CastleHeart_0));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__ComponentDataFromEntity_CastleHeart_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<CastleHeart>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_GatherMapIcons.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapIconData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<MapIconData> forParameter_mapIconData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268720, RefRangeEnd = 1268721, XrefRangeStart = 1268707, XrefRangeEnd = 1268720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268734, RefRangeEnd = 1268735, XrefRangeStart = 1268721, XrefRangeEnd = 1268734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapIconData));
          MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, 100667909);
          MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, 100667910);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapIconData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<MapIconData>.Runtime runtime_mapIconData;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
            MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapIconData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_GatherMapIcons.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_FindPlayerZone")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindPlayerZone
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_zoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentChunk;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldZoneEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldZoneId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass85_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass85_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass85_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public WorldZone zoneType;
      [FieldOffset(4)]
      public TerrainChunk currentChunk;
      [FieldOffset(12)]
      public Entity worldZoneEntity;
      [FieldOffset(24)]
      public MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1268941, RefRangeEnd = 1268943, XrefRangeStart = 1268940, XrefRangeEnd = 1268941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref WorldZoneId worldZoneId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldZoneId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1268943, RefRangeEnd = 1268945, XrefRangeStart = 1268943, XrefRangeEnd = 1268943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MapMenuMapper.__c__DisplayClass85_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass85_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1268945, RefRangeEnd = 1268947, XrefRangeStart = 1268945, XrefRangeEnd = 1268945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MapMenuMapper.__c__DisplayClass85_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass85_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268947, XrefRangeEnd = 1268949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268955, RefRangeEnd = 1268956, XrefRangeStart = 1268949, XrefRangeEnd = 1268955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1268958, RefRangeEnd = 1268959, XrefRangeStart = 1268956, XrefRangeEnd = 1268958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        ref MapMenuMapper.__c__DisplayClass85_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass85_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268959, XrefRangeEnd = 1268963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268963, XrefRangeEnd = 1268969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindPlayerZone()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_FindPlayerZone");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_zoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, nameof (zoneType));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_currentChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, nameof (currentChunk));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_worldZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, nameof (worldZoneEntity));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, 100667911);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass85_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, 100667912);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass85_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, 100667913);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, 100667914);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, 100667915);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass85_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, 100667916);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, 100667917);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, 100667918);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_worldZoneId;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<WorldZoneId> forParameter_worldZoneId;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268859, RefRangeEnd = 1268860, XrefRangeStart = 1268855, XrefRangeEnd = 1268859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268864, RefRangeEnd = 1268865, XrefRangeStart = 1268860, XrefRangeEnd = 1268864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_worldZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_worldZoneId));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders>.NativeClassPtr, 100667919);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders>.NativeClassPtr, 100667920);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_worldZoneId;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<WorldZoneId>.Runtime runtime_worldZoneId;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_worldZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_worldZoneId));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_FindPlayerZone/ProjectM.UI.RunWithoutJobSystem_0000107F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, "RunWithoutJobSystem_0000107F$PostfixBurstDelegate");
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667921);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667922);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667923);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667924);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_FindPlayerZone/ProjectM.UI.RunWithoutJobSystem_0000107F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268865, XrefRangeEnd = 1268879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268879, XrefRangeEnd = 1268897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268897, XrefRangeEnd = 1268912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268939, RefRangeEnd = 1268940, XrefRangeStart = 1268912, XrefRangeEnd = 1268939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone>.NativeClassPtr, "RunWithoutJobSystem_0000107F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667925);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667926);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667927);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667928);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667930);
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
            IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_FindPlayerZone2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindPlayerZone2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_zoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldZoneEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldZoneId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass86_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass86_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass86_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public WorldZone zoneType;
      [FieldOffset(4)]
      public Entity worldZoneEntity;
      [FieldOffset(16)]
      public MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1269054, RefRangeEnd = 1269055, XrefRangeStart = 1269054, XrefRangeEnd = 1269054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref WorldZoneId worldZoneId)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldZoneId;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MapMenuMapper.__c__DisplayClass86_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass86_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MapMenuMapper.__c__DisplayClass86_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass86_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269055, XrefRangeEnd = 1269057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1269063, RefRangeEnd = 1269064, XrefRangeStart = 1269057, XrefRangeEnd = 1269063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1269066, RefRangeEnd = 1269067, XrefRangeStart = 1269064, XrefRangeEnd = 1269066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapMenuMapper componentSystem,
        ref MapMenuMapper.__c__DisplayClass86_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass86_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269067, XrefRangeEnd = 1269071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269071, XrefRangeEnd = 1269077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindPlayerZone2()
      {
        Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper>.NativeClassPtr, "<>c__DisplayClass_FindPlayerZone2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr_zoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, nameof (zoneType));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr_worldZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, nameof (worldZoneEntity));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, nameof (_runtimes));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, 100667931);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass86_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, 100667932);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass86_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, 100667933);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, 100667934);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, 100667935);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_byref___c__DisplayClass86_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, 100667936);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, 100667937);
        MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, 100667938);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_worldZoneId;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<WorldZoneId> forParameter_worldZoneId;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268973, RefRangeEnd = 1268974, XrefRangeStart = 1268969, XrefRangeEnd = 1268973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1268978, RefRangeEnd = 1268979, XrefRangeStart = 1268974, XrefRangeEnd = 1268978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_worldZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_worldZoneId));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders>.NativeClassPtr, 100667939);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders>.NativeClassPtr, 100667940);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_worldZoneId;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<WorldZoneId>.Runtime runtime_worldZoneId;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_worldZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_worldZoneId));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_FindPlayerZone2/ProjectM.UI.RunWithoutJobSystem_00001088$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, "RunWithoutJobSystem_00001088$PostfixBurstDelegate");
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667941);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667942);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667943);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667944);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.MapMenuMapper/ProjectM.UI.<>c__DisplayClass_FindPlayerZone2/ProjectM.UI.RunWithoutJobSystem_00001088$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268979, XrefRangeEnd = 1268993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268993, XrefRangeEnd = 1269011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269011, XrefRangeEnd = 1269026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1269053, RefRangeEnd = 1269054, XrefRangeStart = 1269026, XrefRangeEnd = 1269053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2>.NativeClassPtr, "RunWithoutJobSystem_00001088$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667945);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667946);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667947);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667948);
          MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667950);
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
            IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapMenuMapper.__c__DisplayClass_FindPlayerZone2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
