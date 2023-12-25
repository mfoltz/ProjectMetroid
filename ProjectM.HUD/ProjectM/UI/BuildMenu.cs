// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public class BuildMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StructureSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_CategorySelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_VariationSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motion2DBinding;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompositionAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemBuildModeHiddenUI;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motion2DInOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredMotions;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_SelectFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Group;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_SelectCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_SelectStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_BuildStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CancelBuilding;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PickupStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_DismantleStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_Lkey_RepairStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PlaceStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ReturnStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RotateLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RotateRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissingKnowledge;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CantDismantleStructure;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_EditVariation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_UnableToInterWithEnemyStructures;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_AlreadyEditedByAnoherPlayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_IsBeingDissmantled;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_OutsideCastleArea;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CloseToEnemyPlayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_EnemyCastleArea;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_BlockedBy;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_DismantleBlockedBy;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Environment;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Road;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Unit;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Requires;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Wall;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Floor;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Pillar;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Entrance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Ground;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_BlockedByParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_OutOfRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CastleAttackedOrSieged;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ContainsServant;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ContainsPrisoner;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ThroneHasActiveMissions;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_TeleporterPairExists;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CannotPlacedInMapZone;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresTerritoryLocation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresUnclaimedTerritory;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresConnectedCastleHeart;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresNoConnectedFloors;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresConnectedFloors;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresGrounded;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresConnectionToGround;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CanNotBeMoved;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequireNoCastleItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MustMoveWithSameCastle;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresIntactCastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RequiresIntactConnectionToGround;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ReachedCastleLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ReachedCastleTileLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ReachedCastleHeightLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ReachedWorldHeightLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_BlockedByInteraction;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_BlockedAbove;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_BlockedBelow;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Wallpaper_PrimaryInputInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Wallpaper_Error_SameBlueprint;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Wallpaper_Error_CannotAfford;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Planter;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionWheelPart;
    private static readonly System.IntPtr NativeFieldInfoPtr_VariationWheelSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUDElements;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUDElementsForInventoryBuildings;
    private static readonly System.IntPtr NativeFieldInfoPtr_UiSoundMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_CategoryClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilterClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_StructureActiveClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_StructureInactiveClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hovered_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsedErrorTexts;
    private static readonly System.IntPtr NativeFieldInfoPtr__AnimationTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationSpeed;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Hovered_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Hovered_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnHudEnabled_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnHudDisabled_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAddToEntity_Protected_Virtual_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetInventoryItemBuildMode_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool Hovered
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_get_Hovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_set_Hovered_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223562, XrefRangeEnd = 1223645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223645, XrefRangeEnd = 1223646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnHudEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_OnHudEnabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnHudDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_OnHudDisabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223646, XrefRangeEnd = 1223649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnAddToEntity(EntityManager entityManager, Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenu.NativeMethodInfoPtr_OnAddToEntity_Protected_Virtual_Void_EntityManager_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1223656, RefRangeEnd = 1223660, XrefRangeStart = 1223649, XrefRangeEnd = 1223656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetInventoryItemBuildMode(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_SetInventoryItemBuildMode_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223660, XrefRangeEnd = 1223664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223664, XrefRangeEnd = 1223672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenu()
    {
      Il2CppClassPointerStore<BuildMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr);
      BuildMenu.NativeFieldInfoPtr_StructureSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (StructureSelectionGroup));
      BuildMenu.NativeFieldInfoPtr_CategorySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (CategorySelectionGroup));
      BuildMenu.NativeFieldInfoPtr_TagSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (TagSelectionGroup));
      BuildMenu.NativeFieldInfoPtr_VariationSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (VariationSelectionGroup));
      BuildMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (FakeTooltip));
      BuildMenu.NativeFieldInfoPtr_Motion2DBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (Motion2DBinding));
      BuildMenu.NativeFieldInfoPtr_CompositionAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (CompositionAsset));
      BuildMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      BuildMenu.NativeFieldInfoPtr_ItemBuildModeHiddenUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (ItemBuildModeHiddenUI));
      BuildMenu.NativeFieldInfoPtr_Motion2DInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (Motion2DInOut));
      BuildMenu.NativeFieldInfoPtr_HoveredMotions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (HoveredMotions));
      BuildMenu.NativeFieldInfoPtr_LKey_SelectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_SelectFilter));
      BuildMenu.NativeFieldInfoPtr_LKey_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Group));
      BuildMenu.NativeFieldInfoPtr_LKey_SelectCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_SelectCategory));
      BuildMenu.NativeFieldInfoPtr_LKey_SelectStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_SelectStructure));
      BuildMenu.NativeFieldInfoPtr_LKey_BuildStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_BuildStructure));
      BuildMenu.NativeFieldInfoPtr_LKey_CancelBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_CancelBuilding));
      BuildMenu.NativeFieldInfoPtr_LKey_PickupStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_PickupStructure));
      BuildMenu.NativeFieldInfoPtr_LKey_DismantleStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_DismantleStructure));
      BuildMenu.NativeFieldInfoPtr_Lkey_RepairStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (Lkey_RepairStructure));
      BuildMenu.NativeFieldInfoPtr_LKey_PlaceStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_PlaceStructure));
      BuildMenu.NativeFieldInfoPtr_LKey_ReturnStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_ReturnStructure));
      BuildMenu.NativeFieldInfoPtr_LKey_RotateLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RotateLeft));
      BuildMenu.NativeFieldInfoPtr_LKey_RotateRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RotateRight));
      BuildMenu.NativeFieldInfoPtr_LKey_MissingKnowledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_MissingKnowledge));
      BuildMenu.NativeFieldInfoPtr_LKey_CantDismantleStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_CantDismantleStructure));
      BuildMenu.NativeFieldInfoPtr_LKey_EditVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_EditVariation));
      BuildMenu.NativeFieldInfoPtr_LKey_UnableToInterWithEnemyStructures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_UnableToInterWithEnemyStructures));
      BuildMenu.NativeFieldInfoPtr_LKey_AlreadyEditedByAnoherPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_AlreadyEditedByAnoherPlayer));
      BuildMenu.NativeFieldInfoPtr_LKey_IsBeingDissmantled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_IsBeingDissmantled));
      BuildMenu.NativeFieldInfoPtr_LKey_OutsideCastleArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_OutsideCastleArea));
      BuildMenu.NativeFieldInfoPtr_LKey_CloseToEnemyPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_CloseToEnemyPlayer));
      BuildMenu.NativeFieldInfoPtr_LKey_EnemyCastleArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_EnemyCastleArea));
      BuildMenu.NativeFieldInfoPtr_LKey_BlockedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_BlockedBy));
      BuildMenu.NativeFieldInfoPtr_LKey_DismantleBlockedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_DismantleBlockedBy));
      BuildMenu.NativeFieldInfoPtr_LKey_Environment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Environment));
      BuildMenu.NativeFieldInfoPtr_LKey_Road = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Road));
      BuildMenu.NativeFieldInfoPtr_LKey_Unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Unit));
      BuildMenu.NativeFieldInfoPtr_LKey_Requires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Requires));
      BuildMenu.NativeFieldInfoPtr_LKey_Wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Wall));
      BuildMenu.NativeFieldInfoPtr_LKey_Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Floor));
      BuildMenu.NativeFieldInfoPtr_LKey_Pillar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Pillar));
      BuildMenu.NativeFieldInfoPtr_LKey_Entrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Entrance));
      BuildMenu.NativeFieldInfoPtr_LKey_Ground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Ground));
      BuildMenu.NativeFieldInfoPtr_LKey_BlockedByParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_BlockedByParent));
      BuildMenu.NativeFieldInfoPtr_LKey_OutOfRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_OutOfRange));
      BuildMenu.NativeFieldInfoPtr_LKey_CastleAttackedOrSieged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_CastleAttackedOrSieged));
      BuildMenu.NativeFieldInfoPtr_LKey_ContainsServant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_ContainsServant));
      BuildMenu.NativeFieldInfoPtr_LKey_ContainsPrisoner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_ContainsPrisoner));
      BuildMenu.NativeFieldInfoPtr_LKey_ThroneHasActiveMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_ThroneHasActiveMissions));
      BuildMenu.NativeFieldInfoPtr_LKey_TeleporterPairExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_TeleporterPairExists));
      BuildMenu.NativeFieldInfoPtr_LKey_CannotPlacedInMapZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_CannotPlacedInMapZone));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresTerritoryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresTerritoryLocation));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresUnclaimedTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresUnclaimedTerritory));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectedCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresConnectedCastleHeart));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresNoConnectedFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresNoConnectedFloors));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectedFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresConnectedFloors));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresGrounded));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectionToGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresConnectionToGround));
      BuildMenu.NativeFieldInfoPtr_LKey_CanNotBeMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_CanNotBeMoved));
      BuildMenu.NativeFieldInfoPtr_LKey_RequireNoCastleItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequireNoCastleItems));
      BuildMenu.NativeFieldInfoPtr_LKey_MustMoveWithSameCastle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_MustMoveWithSameCastle));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresIntactCastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresIntactCastleHeartConnection));
      BuildMenu.NativeFieldInfoPtr_LKey_RequiresIntactConnectionToGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_RequiresIntactConnectionToGround));
      BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_ReachedCastleLimit));
      BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleTileLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_ReachedCastleTileLimit));
      BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleHeightLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_ReachedCastleHeightLimit));
      BuildMenu.NativeFieldInfoPtr_LKey_ReachedWorldHeightLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_ReachedWorldHeightLimit));
      BuildMenu.NativeFieldInfoPtr_LKey_BlockedByInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_BlockedByInteraction));
      BuildMenu.NativeFieldInfoPtr_LKey_BlockedAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_BlockedAbove));
      BuildMenu.NativeFieldInfoPtr_LKey_BlockedBelow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_BlockedBelow));
      BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_PrimaryInputInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Wallpaper_PrimaryInputInfo));
      BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_Error_SameBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Wallpaper_Error_SameBlueprint));
      BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_Error_CannotAfford = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Wallpaper_Error_CannotAfford));
      BuildMenu.NativeFieldInfoPtr_LKey_Planter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (LKey_Planter));
      BuildMenu.NativeFieldInfoPtr_actionWheelPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (actionWheelPart));
      BuildMenu.NativeFieldInfoPtr_VariationWheelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (VariationWheelSize));
      BuildMenu.NativeFieldInfoPtr_HideHUDElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (HideHUDElements));
      BuildMenu.NativeFieldInfoPtr_HideHUDElementsForInventoryBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (HideHUDElementsForInventoryBuildings));
      BuildMenu.NativeFieldInfoPtr_UiSoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (UiSoundMapping));
      BuildMenu.NativeFieldInfoPtr_CategoryClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (CategoryClickSound));
      BuildMenu.NativeFieldInfoPtr_FilterClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (FilterClickSound));
      BuildMenu.NativeFieldInfoPtr_StructureActiveClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (StructureActiveClickSound));
      BuildMenu.NativeFieldInfoPtr_StructureInactiveClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (StructureInactiveClickSound));
      BuildMenu.NativeFieldInfoPtr__Hovered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, "<Hovered>k__BackingField");
      BuildMenu.NativeFieldInfoPtr__BuildMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (_BuildMenuEntity));
      BuildMenu.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (_EntityManager));
      BuildMenu.NativeFieldInfoPtr_UsedErrorTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (UsedErrorTexts));
      BuildMenu.NativeFieldInfoPtr__AnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (_AnimationTime));
      BuildMenu.NativeFieldInfoPtr_AnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, nameof (AnimationSpeed));
      BuildMenu.NativeMethodInfoPtr_get_Hovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664817);
      BuildMenu.NativeMethodInfoPtr_set_Hovered_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664818);
      BuildMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664819);
      BuildMenu.NativeMethodInfoPtr_OnHudEnabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664820);
      BuildMenu.NativeMethodInfoPtr_OnHudDisabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664821);
      BuildMenu.NativeMethodInfoPtr_OnAddToEntity_Protected_Virtual_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664822);
      BuildMenu.NativeMethodInfoPtr_SetInventoryItemBuildMode_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664823);
      BuildMenu.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664824);
      BuildMenu.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664825);
      BuildMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664826);
      BuildMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, 100664827);
    }

    public BuildMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildMenu_StructureSelectionGroup StructureSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_StructureSelectionGroup));
        return pointer == System.IntPtr.Zero ? (BuildMenu_StructureSelectionGroup) null : new BuildMenu_StructureSelectionGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_StructureSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GenericSelectionGroup<BuildMenu_CategoryEntry, BuildMenu_CategoryEntry.Data> CategorySelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_CategorySelectionGroup));
        return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<BuildMenu_CategoryEntry, BuildMenu_CategoryEntry.Data>) null : new GenericSelectionGroup<BuildMenu_CategoryEntry, BuildMenu_CategoryEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_CategorySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GenericSelectionGroup<BuildMenu_TagEntry, BuildMenu_TagEntry.Data> TagSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_TagSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<BuildMenu_TagEntry, BuildMenu_TagEntry.Data>) null : new GenericSelectionGroup<BuildMenu_TagEntry, BuildMenu_TagEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_TagSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GenericSelectionGroup<BuildMenu_VariationEntry, BuildMenu_VariationEntry.Data> VariationSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_VariationSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<BuildMenu_VariationEntry, BuildMenu_VariationEntry.Data>) null : new GenericSelectionGroup<BuildMenu_VariationEntry, BuildMenu_VariationEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_VariationSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding Motion2DBinding
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_Motion2DBinding));
        return pointer == System.IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_Motion2DBinding), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<BuildMenuCompositionAsset> CompositionAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_CompositionAsset));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<BuildMenuCompositionAsset>) null : new WeakAssetReference<BuildMenuCompositionAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_CompositionAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> ItemBuildModeHiddenUI
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_ItemBuildModeHiddenUI));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_ItemBuildModeHiddenUI), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion2DInOut
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_Motion2DInOut));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_Motion2DInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut HoveredMotions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_HoveredMotions));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_HoveredMotions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_SelectFilter
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_SelectFilter));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_SelectFilter)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Group
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Group));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Group)) = value;
      }
    }

    public unsafe LocalizationKey LKey_SelectCategory
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_SelectCategory));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_SelectCategory)) = value;
      }
    }

    public unsafe LocalizationKey LKey_SelectStructure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_SelectStructure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_SelectStructure)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BuildStructure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BuildStructure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BuildStructure)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CancelBuilding
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CancelBuilding));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CancelBuilding)) = value;
      }
    }

    public unsafe LocalizationKey LKey_PickupStructure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_PickupStructure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_PickupStructure)) = value;
      }
    }

    public unsafe LocalizationKey LKey_DismantleStructure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_DismantleStructure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_DismantleStructure)) = value;
      }
    }

    public unsafe LocalizationKey Lkey_RepairStructure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_Lkey_RepairStructure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_Lkey_RepairStructure)) = value;
      }
    }

    public unsafe LocalizationKey LKey_PlaceStructure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_PlaceStructure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_PlaceStructure)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ReturnStructure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReturnStructure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReturnStructure)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RotateLeft
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RotateLeft));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RotateLeft)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RotateRight
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RotateRight));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RotateRight)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissingKnowledge
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_MissingKnowledge));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_MissingKnowledge)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CantDismantleStructure
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CantDismantleStructure));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CantDismantleStructure)) = value;
      }
    }

    public unsafe LocalizationKey LKey_EditVariation
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_EditVariation));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_EditVariation)) = value;
      }
    }

    public unsafe LocalizationKey LKey_UnableToInterWithEnemyStructures
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_UnableToInterWithEnemyStructures));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_UnableToInterWithEnemyStructures)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AlreadyEditedByAnoherPlayer
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_AlreadyEditedByAnoherPlayer));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_AlreadyEditedByAnoherPlayer)) = value;
      }
    }

    public unsafe LocalizationKey LKey_IsBeingDissmantled
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_IsBeingDissmantled));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_IsBeingDissmantled)) = value;
      }
    }

    public unsafe LocalizationKey LKey_OutsideCastleArea
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_OutsideCastleArea));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_OutsideCastleArea)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CloseToEnemyPlayer
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CloseToEnemyPlayer));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CloseToEnemyPlayer)) = value;
      }
    }

    public unsafe LocalizationKey LKey_EnemyCastleArea
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_EnemyCastleArea));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_EnemyCastleArea)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BlockedBy
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedBy));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedBy)) = value;
      }
    }

    public unsafe LocalizationKey LKey_DismantleBlockedBy
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_DismantleBlockedBy));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_DismantleBlockedBy)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Environment
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Environment));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Environment)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Road
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Road));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Road)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Unit
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Unit));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Unit)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Requires
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Requires));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Requires)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Wall
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Wall));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Wall)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Floor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Floor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Floor)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Pillar
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Pillar));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Pillar)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Entrance
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Entrance));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Entrance)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Ground
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Ground));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Ground)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BlockedByParent
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedByParent));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedByParent)) = value;
      }
    }

    public unsafe LocalizationKey LKey_OutOfRange
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_OutOfRange));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_OutOfRange)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CastleAttackedOrSieged
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CastleAttackedOrSieged));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CastleAttackedOrSieged)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ContainsServant
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ContainsServant));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ContainsServant)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ContainsPrisoner
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ContainsPrisoner));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ContainsPrisoner)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ThroneHasActiveMissions
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ThroneHasActiveMissions));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ThroneHasActiveMissions)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TeleporterPairExists
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_TeleporterPairExists));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_TeleporterPairExists)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CannotPlacedInMapZone
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CannotPlacedInMapZone));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CannotPlacedInMapZone)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresTerritoryLocation
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresTerritoryLocation));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresTerritoryLocation)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresUnclaimedTerritory
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresUnclaimedTerritory));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresUnclaimedTerritory)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresConnectedCastleHeart
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectedCastleHeart));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectedCastleHeart)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresNoConnectedFloors
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresNoConnectedFloors));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresNoConnectedFloors)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresConnectedFloors
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectedFloors));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectedFloors)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresGrounded
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresGrounded));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresGrounded)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresConnectionToGround
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectionToGround));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresConnectionToGround)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CanNotBeMoved
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CanNotBeMoved));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_CanNotBeMoved)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequireNoCastleItems
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequireNoCastleItems));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequireNoCastleItems)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MustMoveWithSameCastle
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_MustMoveWithSameCastle));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_MustMoveWithSameCastle)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresIntactCastleHeartConnection
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresIntactCastleHeartConnection));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresIntactCastleHeartConnection)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RequiresIntactConnectionToGround
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresIntactConnectionToGround));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_RequiresIntactConnectionToGround)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ReachedCastleLimit
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleLimit));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleLimit)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ReachedCastleTileLimit
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleTileLimit));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleTileLimit)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ReachedCastleHeightLimit
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleHeightLimit));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReachedCastleHeightLimit)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ReachedWorldHeightLimit
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReachedWorldHeightLimit));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_ReachedWorldHeightLimit)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BlockedByInteraction
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedByInteraction));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedByInteraction)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BlockedAbove
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedAbove));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedAbove)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BlockedBelow
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedBelow));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_BlockedBelow)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Wallpaper_PrimaryInputInfo
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_PrimaryInputInfo));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_PrimaryInputInfo)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Wallpaper_Error_SameBlueprint
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_Error_SameBlueprint));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_Error_SameBlueprint)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Wallpaper_Error_CannotAfford
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_Error_CannotAfford));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Wallpaper_Error_CannotAfford)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Planter
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Planter));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_LKey_Planter)) = value;
      }
    }

    public unsafe ActionWheelPart actionWheelPart
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_actionWheelPart));
        return pointer == System.IntPtr.Zero ? (ActionWheelPart) null : new ActionWheelPart(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_actionWheelPart), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float VariationWheelSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_VariationWheelSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_VariationWheelSize)) = value;
      }
    }

    public unsafe HUDElementType HideHUDElements
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_HideHUDElements));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_HideHUDElements)) = value;
      }
    }

    public unsafe HUDElementType HideHUDElementsForInventoryBuildings
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_HideHUDElementsForInventoryBuildings));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_HideHUDElementsForInventoryBuildings)) = value;
      }
    }

    public unsafe UISoundMapping UiSoundMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_UiSoundMapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_UiSoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType CategoryClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_CategoryClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_CategoryClickSound)) = value;
      }
    }

    public unsafe UISoundType FilterClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_FilterClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_FilterClickSound)) = value;
      }
    }

    public unsafe UISoundType StructureActiveClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_StructureActiveClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_StructureActiveClickSound)) = value;
      }
    }

    public unsafe UISoundType StructureInactiveClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_StructureInactiveClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_StructureInactiveClickSound)) = value;
      }
    }

    public unsafe bool _Hovered_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr__Hovered_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr__Hovered_k__BackingField)) = value;
      }
    }

    public unsafe Entity _BuildMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr__BuildMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr__BuildMenuEntity)) = value;
      }
    }

    public unsafe EntityManager _EntityManager
    {
      get
      {
        return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr__EntityManager));
      }
      [param: In] set
      {
        *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr__EntityManager)) = value;
      }
    }

    public unsafe List<LocalizationKey> UsedErrorTexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_UsedErrorTexts));
        return pointer == System.IntPtr.Zero ? (List<LocalizationKey>) null : new List<LocalizationKey>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_UsedErrorTexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _AnimationTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr__AnimationTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr__AnimationTime)) = value;
      }
    }

    public unsafe float AnimationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_AnimationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu.NativeFieldInfoPtr_AnimationSpeed)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__93_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__93_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__93_0_Internal_Void_InputContextEntry_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__93_1_Internal_Void_ErrorContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__93_0(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__93_0_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223560, XrefRangeEnd = 1223562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__93_1(
        ErrorContextEntry entry,
        ErrorContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__93_1_Internal_Void_ErrorContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr);
        BuildMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr, "<>9");
        BuildMenu.__c.NativeFieldInfoPtr___9__93_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr, "<>9__93_0");
        BuildMenu.__c.NativeFieldInfoPtr___9__93_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr, "<>9__93_1");
        BuildMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr, 100664829);
        BuildMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__93_0_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr, 100664830);
        BuildMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__93_1_Internal_Void_ErrorContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu.__c>.NativeClassPtr, 100664831);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe BuildMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (BuildMenu.__c) null : new BuildMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__93_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenu.__c.NativeFieldInfoPtr___9__93_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenu.__c.NativeFieldInfoPtr___9__93_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ErrorContextEntry, ErrorContextEntry.Data> __9__93_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenu.__c.NativeFieldInfoPtr___9__93_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ErrorContextEntry, ErrorContextEntry.Data>) null : new Il2CppSystem.Action<ErrorContextEntry, ErrorContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenu.__c.NativeFieldInfoPtr___9__93_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
