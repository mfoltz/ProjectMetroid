// Decompiled with JetBrains decompiler
// Type: MapTooltip
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using ProjectM;
using ProjectM.CastleBuilding;
using ProjectM.Terrain;
using ProjectM.UI;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class MapTooltip : StunGUIBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MainAlpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_FadeInCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_TitleText;
  private static readonly System.IntPtr NativeFieldInfoPtr_CharactersText;
  private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_MissionAbortText;
  private static readonly System.IntPtr NativeFieldInfoPtr_LK_RestrictedAreaTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr_LK_RestrictedAreaDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_LK_CastleAreaAlly;
  private static readonly System.IntPtr NativeFieldInfoPtr_LK_CastleArea;
  private static readonly System.IntPtr NativeFieldInfoPtr_LK_TerritoryOwner;
  private static readonly System.IntPtr NativeFieldInfoPtr_GenericCharacterSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_TitleRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_CharactersRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_MostCommonRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemsRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_OuterLayout;
  private static readonly System.IntPtr NativeFieldInfoPtr_InnerLayout;
  private static readonly System.IntPtr NativeFieldInfoPtr_MapTooltipItemEntryPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArrowUpNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArrowRightNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArrowDownNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArrowLeftNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_LK_MissionInProgress;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr__ParentRect;
  private static readonly System.IntPtr NativeFieldInfoPtr__ItemsCache;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentId;
  private static readonly System.IntPtr NativeFieldInfoPtr__StartTime;
  private static readonly System.IntPtr NativeFieldInfoPtr__TimeNow;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedMembersCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedPylonTeam;
  private static readonly System.IntPtr NativeFieldInfoPtr__CachedPylonOwnersString;
  private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedTime;
  private static readonly System.IntPtr NativeFieldInfoPtr__MemoizedOwnerName;
  private static readonly System.IntPtr NativeFieldInfoPtr_TeamBuilder;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_EntityManager_byref_MapZoneData_byref_NativeArray_1_MapZoneDiscoverableElement_Bounds_ManagedDataRegistry_PrefabLookupMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_EntityManager_byref_PylonTooltipData_MapTooltipType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowMission_Public_Void_byref_MapZoneData_Bounds_ManagedDataRegistry_PrefabLookupMap_DynamicBuffer_1_ActiveServantMission_EntityManager_GameDataSystem_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPylonTeamString_Private_String_EntityManager_Team_NativeList_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Private_Void_Bounds_byref_Vector2_byref_Vector2_byref_ArrowDirection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowArrow_Private_Void_ArrowDirection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckStartTime_Private_Void_TooltipId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveAndFadeIn_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205995, XrefRangeEnd = 1206008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206008, XrefRangeEnd = 1206084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show(
    EntityManager entityManager,
    [In] ref MapZoneData mapZoneData,
    [In] ref NativeArray<MapZoneDiscoverableElement> discoverablesArray,
    Bounds targetBounds,
    ManagedDataRegistry managedDataRegistry,
    PrefabLookupMap prefabGuidLookupMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref discoverablesArray;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &targetBounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) managedDataRegistry));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuidLookupMap;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_Show_Public_Void_EntityManager_byref_MapZoneData_byref_NativeArray_1_MapZoneDiscoverableElement_Bounds_ManagedDataRegistry_PrefabLookupMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1206133, RefRangeEnd = 1206134, XrefRangeStart = 1206084, XrefRangeEnd = 1206133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show(
    EntityManager entityManager,
    [In] ref PylonTooltipData pylonTooltipData,
    MapTooltipType type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pylonTooltipData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_Show_Public_Void_EntityManager_byref_PylonTooltipData_MapTooltipType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206134, XrefRangeEnd = 1206247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowMission(
    [In] ref MapZoneData mapZoneData,
    Bounds targetBounds,
    ManagedDataRegistry managedDataRegistry,
    PrefabLookupMap prefabLookupMap,
    DynamicBuffer<ActiveServantMission> activeMissions,
    EntityManager entityManager,
    GameDataSystem gameDataSystem,
    long ticks)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) ref mapZoneData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetBounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) managedDataRegistry));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &activeMissions;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ticks;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_ShowMission_Public_Void_byref_MapZoneData_Bounds_ManagedDataRegistry_PrefabLookupMap_DynamicBuffer_1_ActiveServantMission_EntityManager_GameDataSystem_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206247, XrefRangeEnd = 1206273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetPylonTeamString(
    EntityManager entityManager,
    Team team,
    NativeList<Entity> owners)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &team;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &owners;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_GetPylonTeamString_Private_String_EntityManager_Team_NativeList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 1206292, RefRangeEnd = 1206295, XrefRangeStart = 1206273, XrefRangeEnd = 1206292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetPosition(
    Bounds targetBounds,
    out Vector2 position,
    out Vector2 pivot,
    out MapTooltip.ArrowDirection arrowDirection)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &targetBounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrowDirection;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_GetPosition_Private_Void_Bounds_byref_Vector2_byref_Vector2_byref_ArrowDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206295, XrefRangeEnd = 1206297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206297, XrefRangeEnd = 1206301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowArrow(MapTooltip.ArrowDirection arrowDirection)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &arrowDirection;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_ShowArrow_Private_Void_ArrowDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 1206306, RefRangeEnd = 1206309, XrefRangeStart = 1206301, XrefRangeEnd = 1206306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckStartTime(MapTooltip.TooltipId newId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &newId;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_CheckStartTime_Private_Void_TooltipId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1206314, RefRangeEnd = 1206315, XrefRangeStart = 1206309, XrefRangeEnd = 1206314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetActiveAndFadeIn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr_SetActiveAndFadeIn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206315, XrefRangeEnd = 1206321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MapTooltip()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MapTooltip()
  {
    Il2CppClassPointerStore<MapTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (MapTooltip));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr);
    MapTooltip.NativeFieldInfoPtr_MainAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (MainAlpha));
    MapTooltip.NativeFieldInfoPtr_FadeInCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (FadeInCurve));
    MapTooltip.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (TitleText));
    MapTooltip.NativeFieldInfoPtr_CharactersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (CharactersText));
    MapTooltip.NativeFieldInfoPtr_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (DescriptionText));
    MapTooltip.NativeFieldInfoPtr_MissionAbortText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (MissionAbortText));
    MapTooltip.NativeFieldInfoPtr_LK_RestrictedAreaTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (LK_RestrictedAreaTitle));
    MapTooltip.NativeFieldInfoPtr_LK_RestrictedAreaDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (LK_RestrictedAreaDescription));
    MapTooltip.NativeFieldInfoPtr_LK_CastleAreaAlly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (LK_CastleAreaAlly));
    MapTooltip.NativeFieldInfoPtr_LK_CastleArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (LK_CastleArea));
    MapTooltip.NativeFieldInfoPtr_LK_TerritoryOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (LK_TerritoryOwner));
    MapTooltip.NativeFieldInfoPtr_GenericCharacterSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (GenericCharacterSprite));
    MapTooltip.NativeFieldInfoPtr_TitleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (TitleRect));
    MapTooltip.NativeFieldInfoPtr_CharactersRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (CharactersRect));
    MapTooltip.NativeFieldInfoPtr_DescriptionRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (DescriptionRect));
    MapTooltip.NativeFieldInfoPtr_MostCommonRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (MostCommonRect));
    MapTooltip.NativeFieldInfoPtr_ItemsRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (ItemsRect));
    MapTooltip.NativeFieldInfoPtr_OuterLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (OuterLayout));
    MapTooltip.NativeFieldInfoPtr_InnerLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (InnerLayout));
    MapTooltip.NativeFieldInfoPtr_MapTooltipItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (MapTooltipItemEntryPrefab));
    MapTooltip.NativeFieldInfoPtr_ArrowUpNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (ArrowUpNode));
    MapTooltip.NativeFieldInfoPtr_ArrowRightNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (ArrowRightNode));
    MapTooltip.NativeFieldInfoPtr_ArrowDownNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (ArrowDownNode));
    MapTooltip.NativeFieldInfoPtr_ArrowLeftNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (ArrowLeftNode));
    MapTooltip.NativeFieldInfoPtr_LK_MissionInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (LK_MissionInProgress));
    MapTooltip.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (TimeKeys));
    MapTooltip.NativeFieldInfoPtr__ParentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_ParentRect));
    MapTooltip.NativeFieldInfoPtr__ItemsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_ItemsCache));
    MapTooltip.NativeFieldInfoPtr__CurrentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_CurrentId));
    MapTooltip.NativeFieldInfoPtr__StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_StartTime));
    MapTooltip.NativeFieldInfoPtr__TimeNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_TimeNow));
    MapTooltip.NativeFieldInfoPtr__CachedMembersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_CachedMembersCount));
    MapTooltip.NativeFieldInfoPtr__CachedPylonTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_CachedPylonTeam));
    MapTooltip.NativeFieldInfoPtr__CachedPylonOwnersString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_CachedPylonOwnersString));
    MapTooltip.NativeFieldInfoPtr_LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (LocalizedTime));
    MapTooltip.NativeFieldInfoPtr__MemoizedOwnerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (_MemoizedOwnerName));
    MapTooltip.NativeFieldInfoPtr_TeamBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (TeamBuilder));
    MapTooltip.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663366);
    MapTooltip.NativeMethodInfoPtr_Show_Public_Void_EntityManager_byref_MapZoneData_byref_NativeArray_1_MapZoneDiscoverableElement_Bounds_ManagedDataRegistry_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663367);
    MapTooltip.NativeMethodInfoPtr_Show_Public_Void_EntityManager_byref_PylonTooltipData_MapTooltipType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663368);
    MapTooltip.NativeMethodInfoPtr_ShowMission_Public_Void_byref_MapZoneData_Bounds_ManagedDataRegistry_PrefabLookupMap_DynamicBuffer_1_ActiveServantMission_EntityManager_GameDataSystem_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663369);
    MapTooltip.NativeMethodInfoPtr_GetPylonTeamString_Private_String_EntityManager_Team_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663370);
    MapTooltip.NativeMethodInfoPtr_GetPosition_Private_Void_Bounds_byref_Vector2_byref_Vector2_byref_ArrowDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663371);
    MapTooltip.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663372);
    MapTooltip.NativeMethodInfoPtr_ShowArrow_Private_Void_ArrowDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663373);
    MapTooltip.NativeMethodInfoPtr_CheckStartTime_Private_Void_TooltipId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663374);
    MapTooltip.NativeMethodInfoPtr_SetActiveAndFadeIn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663375);
    MapTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, 100663376);
  }

  public MapTooltip(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CanvasGroup MainAlpha
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_MainAlpha));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_MainAlpha), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve FadeInCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_FadeInCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_FadeInCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText TitleText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_TitleText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText CharactersText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_CharactersText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_CharactersText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText DescriptionText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_DescriptionText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_DescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText MissionAbortText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_MissionAbortText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_MissionAbortText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey LK_RestrictedAreaTitle
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_RestrictedAreaTitle));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_RestrictedAreaTitle)) = value;
    }
  }

  public unsafe LocalizationKey LK_RestrictedAreaDescription
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_RestrictedAreaDescription));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_RestrictedAreaDescription)) = value;
    }
  }

  public unsafe LocalizationKey LK_CastleAreaAlly
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_CastleAreaAlly));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_CastleAreaAlly)) = value;
    }
  }

  public unsafe LocalizationKey LK_CastleArea
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_CastleArea));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_CastleArea)) = value;
    }
  }

  public unsafe LocalizationKey LK_TerritoryOwner
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_TerritoryOwner));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_TerritoryOwner)) = value;
    }
  }

  public unsafe Sprite GenericCharacterSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_GenericCharacterSprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_GenericCharacterSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform TitleRect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_TitleRect));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_TitleRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform CharactersRect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_CharactersRect));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_CharactersRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform DescriptionRect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_DescriptionRect));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_DescriptionRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform MostCommonRect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_MostCommonRect));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_MostCommonRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform ItemsRect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ItemsRect));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ItemsRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayoutGroup OuterLayout
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_OuterLayout));
      return pointer == System.IntPtr.Zero ? (LayoutGroup) null : new LayoutGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_OuterLayout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayoutGroup InnerLayout
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_InnerLayout));
      return pointer == System.IntPtr.Zero ? (LayoutGroup) null : new LayoutGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_InnerLayout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MapTooltipItemEntry MapTooltipItemEntryPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_MapTooltipItemEntryPrefab));
      return pointer == System.IntPtr.Zero ? (MapTooltipItemEntry) null : new MapTooltipItemEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_MapTooltipItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform ArrowUpNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ArrowUpNode));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ArrowUpNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform ArrowRightNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ArrowRightNode));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ArrowRightNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform ArrowDownNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ArrowDownNode));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ArrowDownNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform ArrowLeftNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ArrowLeftNode));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_ArrowLeftNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey LK_MissionInProgress
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_MissionInProgress));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LK_MissionInProgress)) = value;
    }
  }

  public unsafe LocalizationTimeKeys TimeKeys
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_TimeKeys));
      return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform _ParentRect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__ParentRect));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__ParentRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UI_Cache<MapTooltipItemEntry> _ItemsCache
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__ItemsCache));
      return pointer == System.IntPtr.Zero ? (UI_Cache<MapTooltipItemEntry>) null : new UI_Cache<MapTooltipItemEntry>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__ItemsCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MapTooltip.TooltipId _CurrentId
  {
    get
    {
      return *(MapTooltip.TooltipId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__CurrentId));
    }
    [param: In] set
    {
      *(MapTooltip.TooltipId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__CurrentId)) = value;
    }
  }

  public unsafe float _StartTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__StartTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__StartTime)) = value;
    }
  }

  public unsafe float _TimeNow
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__TimeNow));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__TimeNow)) = value;
    }
  }

  public unsafe int _CachedMembersCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__CachedMembersCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__CachedMembersCount)) = value;
    }
  }

  public unsafe Team _CachedPylonTeam
  {
    get
    {
      return *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__CachedPylonTeam));
    }
    [param: In] set
    {
      *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__CachedPylonTeam)) = value;
    }
  }

  public unsafe string _CachedPylonOwnersString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__CachedPylonOwnersString)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__CachedPylonOwnersString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public LocalizedTimeBuilder LocalizedTime
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LocalizedTime);
      return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public MemoizedFixedString64 _MemoizedOwnerName
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__MemoizedOwnerName);
      return new MemoizedFixedString64(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedFixedString64>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr__MemoizedOwnerName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedFixedString64>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe StringBuilder TeamBuilder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_TeamBuilder));
      return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapTooltip.NativeFieldInfoPtr_TeamBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TooltipId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneId;
    private static readonly System.IntPtr NativeFieldInfoPtr_PylonTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_IconId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TooltipId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TooltipId_TooltipId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TooltipId_TooltipId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public MapTooltipType TooltipType;
    [FieldOffset(4)]
    public MapZoneId ZoneId;
    [FieldOffset(16)]
    public Team PylonTeam;
    [FieldOffset(24)]
    public int IconId;
    [FieldOffset(28)]
    public FixedString64 Name;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205978, XrefRangeEnd = 1205980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(MapTooltip.TooltipId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapTooltip.TooltipId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TooltipId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205980, XrefRangeEnd = 1205983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapTooltip.TooltipId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1205985, RefRangeEnd = 1205986, XrefRangeStart = 1205983, XrefRangeEnd = 1205985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(MapTooltip.TooltipId obj1, MapTooltip.TooltipId obj2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &obj1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &obj2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapTooltip.TooltipId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TooltipId_TooltipId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205986, XrefRangeEnd = 1205988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(MapTooltip.TooltipId obj1, MapTooltip.TooltipId obj2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &obj1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &obj2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapTooltip.TooltipId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TooltipId_TooltipId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205988, XrefRangeEnd = 1205995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapTooltip.TooltipId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TooltipId()
    {
      Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapTooltip>.NativeClassPtr, nameof (TooltipId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr);
      MapTooltip.TooltipId.NativeFieldInfoPtr_TooltipType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, nameof (TooltipType));
      MapTooltip.TooltipId.NativeFieldInfoPtr_ZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, nameof (ZoneId));
      MapTooltip.TooltipId.NativeFieldInfoPtr_PylonTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, nameof (PylonTeam));
      MapTooltip.TooltipId.NativeFieldInfoPtr_IconId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, nameof (IconId));
      MapTooltip.TooltipId.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, nameof (Name));
      MapTooltip.TooltipId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TooltipId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, 100663377);
      MapTooltip.TooltipId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, 100663378);
      MapTooltip.TooltipId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TooltipId_TooltipId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, 100663379);
      MapTooltip.TooltipId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TooltipId_TooltipId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, 100663380);
      MapTooltip.TooltipId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, 100663381);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapTooltip.TooltipId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public enum ArrowDirection
  {
    None,
    Up,
    Right,
    Down,
    Left,
  }
}
