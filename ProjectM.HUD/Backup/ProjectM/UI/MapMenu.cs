// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class MapMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantMissionSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoMapNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapTexture;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurseDebuffVisualization;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleIconArray;
    private static readonly System.IntPtr NativeFieldInfoPtr_PanAndZoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentPanAndZoom;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_RelicSense;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_ServantThroneHelper;
    private static readonly System.IntPtr NativeFieldInfoPtr_RelicMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_HelpText;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneMarkerNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerritoryMarkerNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerritoryMarkerPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneAreaMarkerPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleBorderMarkerNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleBorderPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapMarkerNode1;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapMarkerNode2;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapMarkerPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipParentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZoomScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllyColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_NonAllyColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelToNetherButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalPlayerIconPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalPlayerPathIconPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUDElements;
    private static readonly System.IntPtr NativeFieldInfoPtr_InBindingNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneAreaMarkerCache;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleBorderCache;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapMarkerCache1;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapMarkerCache2;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerritoryMarkerCache;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapRegionNamePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapRegionNamesNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapRegionNameCache;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlphaStartThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlphaEndThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapInfoText;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointModeHelpKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoWaypointsHelpKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectStartCryptKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectStartGraveyardKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectRespawnLocationKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoSpawnPointsAvailableKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_PanMapKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoomKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddRemoveMarkerKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoMapFoundKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoMapInCryptKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecommendedLowPopulationKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTimerKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTextTimerKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapSoundMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaceMarkerSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveMarkerSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnCryptClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnWoodenCoffinClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnStoneCoffinClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbortMissionPopupPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCastleSprite_Internal_Sprite_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1268090, RefRangeEnd = 1268091, XrefRangeStart = 1268028, XrefRangeEnd = 1268090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenu.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenu.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1268091, RefRangeEnd = 1268093, XrefRangeStart = 1268091, XrefRangeEnd = 1268091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Sprite GetCastleSprite(int id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMenu.NativeMethodInfoPtr_GetCastleSprite_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268093, XrefRangeEnd = 1268094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapMenu()
    {
      Il2CppClassPointerStore<MapMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenu>.NativeClassPtr);
      MapMenu.NativeFieldInfoPtr_ServantMissionSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (ServantMissionSubMenu));
      MapMenu.NativeFieldInfoPtr_MapNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapNode));
      MapMenu.NativeFieldInfoPtr_NoMapNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (NoMapNode));
      MapMenu.NativeFieldInfoPtr_MapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapTexture));
      MapMenu.NativeFieldInfoPtr_CurseDebuffVisualization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (CurseDebuffVisualization));
      MapMenu.NativeFieldInfoPtr_CastleIconArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (CastleIconArray));
      MapMenu.NativeFieldInfoPtr_PanAndZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (PanAndZoom));
      MapMenu.NativeFieldInfoPtr_ParentPanAndZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (ParentPanAndZoom));
      MapMenu.NativeFieldInfoPtr_PlayerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (PlayerMarker));
      MapMenu.NativeFieldInfoPtr_Parent_RelicSense = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (Parent_RelicSense));
      MapMenu.NativeFieldInfoPtr_Parent_ServantThroneHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (Parent_ServantThroneHelper));
      MapMenu.NativeFieldInfoPtr_RelicMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (RelicMapping));
      MapMenu.NativeFieldInfoPtr_HelpText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (HelpText));
      MapMenu.NativeFieldInfoPtr_MapZoneMarkerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapZoneMarkerNode));
      MapMenu.NativeFieldInfoPtr_TerritoryMarkerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (TerritoryMarkerNode));
      MapMenu.NativeFieldInfoPtr_TerritoryMarkerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (TerritoryMarkerPrefab));
      MapMenu.NativeFieldInfoPtr_MapZoneAreaMarkerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapZoneAreaMarkerPrefab));
      MapMenu.NativeFieldInfoPtr_CastleBorderMarkerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (CastleBorderMarkerNode));
      MapMenu.NativeFieldInfoPtr_CastleBorderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (CastleBorderPrefab));
      MapMenu.NativeFieldInfoPtr_MapMarkerNode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapMarkerNode1));
      MapMenu.NativeFieldInfoPtr_MapMarkerNode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapMarkerNode2));
      MapMenu.NativeFieldInfoPtr_MapMarkerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapMarkerPrefab));
      MapMenu.NativeFieldInfoPtr_TooltipParentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (TooltipParentNode));
      MapMenu.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (Settings));
      MapMenu.NativeFieldInfoPtr_MaxZoomScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MaxZoomScale));
      MapMenu.NativeFieldInfoPtr_AllyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (AllyColor));
      MapMenu.NativeFieldInfoPtr_NonAllyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (NonAllyColor));
      MapMenu.NativeFieldInfoPtr_TravelToNetherButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (TravelToNetherButton));
      MapMenu.NativeFieldInfoPtr_SpawnButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (SpawnButton));
      MapMenu.NativeFieldInfoPtr_LocalPlayerIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (LocalPlayerIconPrefab));
      MapMenu.NativeFieldInfoPtr_LocalPlayerPathIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (LocalPlayerPathIconPrefab));
      MapMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      MapMenu.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (Tooltip));
      MapMenu.NativeFieldInfoPtr_HideHUDElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (HideHUDElements));
      MapMenu.NativeFieldInfoPtr_InBindingNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (InBindingNode));
      MapMenu.NativeFieldInfoPtr_MapZoneAreaMarkerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapZoneAreaMarkerCache));
      MapMenu.NativeFieldInfoPtr_CastleBorderCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (CastleBorderCache));
      MapMenu.NativeFieldInfoPtr_MapMarkerCache1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapMarkerCache1));
      MapMenu.NativeFieldInfoPtr_MapMarkerCache2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapMarkerCache2));
      MapMenu.NativeFieldInfoPtr_TerritoryMarkerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (TerritoryMarkerCache));
      MapMenu.NativeFieldInfoPtr_MapRegionNamePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapRegionNamePrefab));
      MapMenu.NativeFieldInfoPtr_MapRegionNamesNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapRegionNamesNode));
      MapMenu.NativeFieldInfoPtr_MapRegionNameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapRegionNameCache));
      MapMenu.NativeFieldInfoPtr_AlphaStartThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (AlphaStartThreshold));
      MapMenu.NativeFieldInfoPtr_AlphaEndThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (AlphaEndThreshold));
      MapMenu.NativeFieldInfoPtr_MapInfoText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapInfoText));
      MapMenu.NativeFieldInfoPtr_WaypointModeHelpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (WaypointModeHelpKey));
      MapMenu.NativeFieldInfoPtr_NoWaypointsHelpKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (NoWaypointsHelpKey));
      MapMenu.NativeFieldInfoPtr_SelectStartCryptKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (SelectStartCryptKey));
      MapMenu.NativeFieldInfoPtr_SelectStartGraveyardKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (SelectStartGraveyardKey));
      MapMenu.NativeFieldInfoPtr_SelectRespawnLocationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (SelectRespawnLocationKey));
      MapMenu.NativeFieldInfoPtr_NoSpawnPointsAvailableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (NoSpawnPointsAvailableKey));
      MapMenu.NativeFieldInfoPtr_PanMapKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (PanMapKey));
      MapMenu.NativeFieldInfoPtr_ZoomKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (ZoomKey));
      MapMenu.NativeFieldInfoPtr_AddRemoveMarkerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (AddRemoveMarkerKey));
      MapMenu.NativeFieldInfoPtr_CloseKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (CloseKey));
      MapMenu.NativeFieldInfoPtr_NoMapFoundKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (NoMapFoundKey));
      MapMenu.NativeFieldInfoPtr_NoMapInCryptKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (NoMapInCryptKey));
      MapMenu.NativeFieldInfoPtr_RecommendedLowPopulationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (RecommendedLowPopulationKey));
      MapMenu.NativeFieldInfoPtr_MapIconTimerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapIconTimerKey));
      MapMenu.NativeFieldInfoPtr_MapIconTextTimerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapIconTextTimerKey));
      MapMenu.NativeFieldInfoPtr_MapSoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (MapSoundMapping));
      MapMenu.NativeFieldInfoPtr_PlaceMarkerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (PlaceMarkerSound));
      MapMenu.NativeFieldInfoPtr_RemoveMarkerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (RemoveMarkerSound));
      MapMenu.NativeFieldInfoPtr_SpawnCryptClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (SpawnCryptClickSound));
      MapMenu.NativeFieldInfoPtr_SpawnWoodenCoffinClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (SpawnWoodenCoffinClickSound));
      MapMenu.NativeFieldInfoPtr_SpawnStoneCoffinClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (SpawnStoneCoffinClickSound));
      MapMenu.NativeFieldInfoPtr_AbortMissionPopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (AbortMissionPopupPrefab));
      MapMenu.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (_Initialized));
      MapMenu.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, 100667729);
      MapMenu.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, 100667730);
      MapMenu.NativeMethodInfoPtr_GetCastleSprite_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, 100667731);
      MapMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, 100667732);
    }

    public MapMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ServantMissionSubMenu ServantMissionSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_ServantMissionSubMenu));
        return pointer == System.IntPtr.Zero ? (ServantMissionSubMenu) null : new ServantMissionSubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_ServantMissionSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform MapNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform NoMapNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoMapNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoMapNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RawImage MapTexture
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapTexture));
        return pointer == System.IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RawImage CurseDebuffVisualization
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CurseDebuffVisualization));
        return pointer == System.IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CurseDebuffVisualization), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Sprite> CastleIconArray
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CastleIconArray));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CastleIconArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapPanAndZoom PanAndZoom
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_PanAndZoom));
        return pointer == System.IntPtr.Zero ? (MapPanAndZoom) null : new MapPanAndZoom(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_PanAndZoom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapPanAndZoom ParentPanAndZoom
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_ParentPanAndZoom));
        return pointer == System.IntPtr.Zero ? (MapPanAndZoom) null : new MapPanAndZoom(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_ParentPanAndZoom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image PlayerMarker
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_PlayerMarker));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_PlayerMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Parent_RelicSense
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_Parent_RelicSense));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_Parent_RelicSense), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Parent_ServantThroneHelper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_Parent_ServantThroneHelper));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_Parent_ServantThroneHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public RelicMapping RelicMapping
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_RelicMapping);
        return new RelicMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_RelicMapping), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RelicMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LocalizedText HelpText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_HelpText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_HelpText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform MapZoneMarkerNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapZoneMarkerNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapZoneMarkerNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TerritoryMarkerNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TerritoryMarkerNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TerritoryMarkerNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerritoryMapEntry TerritoryMarkerPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TerritoryMarkerPrefab));
        return pointer == System.IntPtr.Zero ? (TerritoryMapEntry) null : new TerritoryMapEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TerritoryMarkerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapZoneAreaMarker MapZoneAreaMarkerPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapZoneAreaMarkerPrefab));
        return pointer == System.IntPtr.Zero ? (MapZoneAreaMarker) null : new MapZoneAreaMarker(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapZoneAreaMarkerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform CastleBorderMarkerNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CastleBorderMarkerNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CastleBorderMarkerNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapZoneAreaMarker CastleBorderPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CastleBorderPrefab));
        return pointer == System.IntPtr.Zero ? (MapZoneAreaMarker) null : new MapZoneAreaMarker(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CastleBorderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform MapMarkerNode1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerNode1));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerNode1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform MapMarkerNode2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerNode2));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerNode2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapMarker MapMarkerPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerPrefab));
        return pointer == System.IntPtr.Zero ? (MapMarker) null : new MapMarker(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipParentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TooltipParentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TooltipParentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapSettings Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_Settings));
        return pointer == System.IntPtr.Zero ? (MapSettings) null : new MapSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float MaxZoomScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MaxZoomScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MaxZoomScale)) = value;
      }
    }

    public unsafe ColorAsset AllyColor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AllyColor));
        return pointer == System.IntPtr.Zero ? (ColorAsset) null : new ColorAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AllyColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorAsset NonAllyColor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NonAllyColor));
        return pointer == System.IntPtr.Zero ? (ColorAsset) null : new ColorAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NonAllyColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button TravelToNetherButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TravelToNetherButton));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TravelToNetherButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SpawnButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SpawnButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SpawnButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<MapIconAuthoring> LocalPlayerIconPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_LocalPlayerIconPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<MapIconAuthoring>) null : new WeakAssetReference<MapIconAuthoring>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_LocalPlayerIconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<MapIconAuthoring> LocalPlayerPathIconPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_LocalPlayerPathIconPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<MapIconAuthoring>) null : new WeakAssetReference<MapIconAuthoring>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_LocalPlayerPathIconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapTooltip Tooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_Tooltip));
        return pointer == System.IntPtr.Zero ? (MapTooltip) null : new MapTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_Tooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDElementType HideHUDElements
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_HideHUDElements));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_HideHUDElements)) = value;
      }
    }

    public unsafe RectTransform InBindingNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_InBindingNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_InBindingNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<MapZoneAreaMarker> MapZoneAreaMarkerCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapZoneAreaMarkerCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<MapZoneAreaMarker>) null : new UI_Cache<MapZoneAreaMarker>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapZoneAreaMarkerCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<MapZoneAreaMarker> CastleBorderCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CastleBorderCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<MapZoneAreaMarker>) null : new UI_Cache<MapZoneAreaMarker>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CastleBorderCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<MapMarker> MapMarkerCache1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerCache1));
        return pointer == System.IntPtr.Zero ? (UI_Cache<MapMarker>) null : new UI_Cache<MapMarker>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerCache1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<MapMarker> MapMarkerCache2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerCache2));
        return pointer == System.IntPtr.Zero ? (UI_Cache<MapMarker>) null : new UI_Cache<MapMarker>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapMarkerCache2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<TerritoryMapEntry> TerritoryMarkerCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TerritoryMarkerCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<TerritoryMapEntry>) null : new UI_Cache<TerritoryMapEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_TerritoryMarkerCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapRegionNameEntry MapRegionNamePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapRegionNamePrefab));
        return pointer == System.IntPtr.Zero ? (MapRegionNameEntry) null : new MapRegionNameEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapRegionNamePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform MapRegionNamesNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapRegionNamesNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapRegionNamesNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<MapRegionNameEntry> MapRegionNameCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapRegionNameCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<MapRegionNameEntry>) null : new UI_Cache<MapRegionNameEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapRegionNameCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float AlphaStartThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AlphaStartThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AlphaStartThreshold)) = value;
      }
    }

    public unsafe float AlphaEndThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AlphaEndThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AlphaEndThreshold)) = value;
      }
    }

    public unsafe LocalizedText MapInfoText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapInfoText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapInfoText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey WaypointModeHelpKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_WaypointModeHelpKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_WaypointModeHelpKey)) = value;
      }
    }

    public unsafe LocalizationKey NoWaypointsHelpKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoWaypointsHelpKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoWaypointsHelpKey)) = value;
      }
    }

    public unsafe LocalizationKey SelectStartCryptKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SelectStartCryptKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SelectStartCryptKey)) = value;
      }
    }

    public unsafe LocalizationKey SelectStartGraveyardKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SelectStartGraveyardKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SelectStartGraveyardKey)) = value;
      }
    }

    public unsafe LocalizationKey SelectRespawnLocationKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SelectRespawnLocationKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SelectRespawnLocationKey)) = value;
      }
    }

    public unsafe LocalizationKey NoSpawnPointsAvailableKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoSpawnPointsAvailableKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoSpawnPointsAvailableKey)) = value;
      }
    }

    public unsafe LocalizationKey PanMapKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_PanMapKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_PanMapKey)) = value;
      }
    }

    public unsafe LocalizationKey ZoomKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_ZoomKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_ZoomKey)) = value;
      }
    }

    public unsafe LocalizationKey AddRemoveMarkerKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AddRemoveMarkerKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AddRemoveMarkerKey)) = value;
      }
    }

    public unsafe LocalizationKey CloseKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CloseKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_CloseKey)) = value;
      }
    }

    public unsafe LocalizationKey NoMapFoundKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoMapFoundKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoMapFoundKey)) = value;
      }
    }

    public unsafe LocalizationKey NoMapInCryptKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoMapInCryptKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_NoMapInCryptKey)) = value;
      }
    }

    public unsafe LocalizationKey RecommendedLowPopulationKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_RecommendedLowPopulationKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_RecommendedLowPopulationKey)) = value;
      }
    }

    public unsafe LocalizationKey MapIconTimerKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapIconTimerKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapIconTimerKey)) = value;
      }
    }

    public unsafe LocalizationKey MapIconTextTimerKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapIconTextTimerKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapIconTextTimerKey)) = value;
      }
    }

    public unsafe UISoundMapping MapSoundMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapSoundMapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_MapSoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType PlaceMarkerSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_PlaceMarkerSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_PlaceMarkerSound)) = value;
      }
    }

    public unsafe UISoundType RemoveMarkerSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_RemoveMarkerSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_RemoveMarkerSound)) = value;
      }
    }

    public unsafe UISoundType SpawnCryptClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SpawnCryptClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SpawnCryptClickSound)) = value;
      }
    }

    public unsafe UISoundType SpawnWoodenCoffinClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SpawnWoodenCoffinClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SpawnWoodenCoffinClickSound)) = value;
      }
    }

    public unsafe UISoundType SpawnStoneCoffinClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SpawnStoneCoffinClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_SpawnStoneCoffinClickSound)) = value;
      }
    }

    public unsafe MapMenu_AbortMissionPopup AbortMissionPopupPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AbortMissionPopupPrefab));
        return pointer == System.IntPtr.Zero ? (MapMenu_AbortMissionPopup) null : new MapMenu_AbortMissionPopup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr_AbortMissionPopupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMenu.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MenuMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetWorkstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_InteractBuff;
      [FieldOffset(0)]
      public MapMenuMode MenuMode;
      [FieldOffset(4)]
      public Entity TargetWorkstation;
      [FieldOffset(12)]
      public Entity InteractBuff;

      static InitData()
      {
        Il2CppClassPointerStore<MapMenu.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenu.InitData>.NativeClassPtr);
        MapMenu.InitData.NativeFieldInfoPtr_MenuMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu.InitData>.NativeClassPtr, nameof (MenuMode));
        MapMenu.InitData.NativeFieldInfoPtr_TargetWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu.InitData>.NativeClassPtr, nameof (TargetWorkstation));
        MapMenu.InitData.NativeFieldInfoPtr_InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu.InitData>.NativeClassPtr, nameof (InteractBuff));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapMenu.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.MapMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__70_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__70_0_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Initialize_b__70_0(InputContextEntry entry, InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapMenu.__c.NativeMethodInfoPtr__Initialize_b__70_0_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<MapMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenu.__c>.NativeClassPtr);
        MapMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu.__c>.NativeClassPtr, "<>9");
        MapMenu.__c.NativeFieldInfoPtr___9__70_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMenu.__c>.NativeClassPtr, "<>9__70_0");
        MapMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenu.__c>.NativeClassPtr, 100667734);
        MapMenu.__c.NativeMethodInfoPtr__Initialize_b__70_0_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenu.__c>.NativeClassPtr, 100667735);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe MapMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (MapMenu.__c) null : new MapMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__70_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapMenu.__c.NativeFieldInfoPtr___9__70_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapMenu.__c.NativeFieldInfoPtr___9__70_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
