// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ResearchstationSubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ResearchstationSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorsLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchstationName;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_VerticalLayoutGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button_Discover;
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonDiscoverText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DiscoverCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab_ResearchEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_Cost;
    private static readonly System.IntPtr NativeFieldInfoPtr_List_ResearchCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button_Research;
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StatusOutputFull;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Researchable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Learn;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Insertable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchCategories;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedReserach;
    private static readonly System.IntPtr NativeFieldInfoPtr__HoveredReserach;
    private static readonly System.IntPtr NativeFieldInfoPtr_StoredTreeEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedResearchCosts;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleCategory_Internal_Void_TechCateogry_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HoveredReserach_Public_Void_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSelected_Internal_Boolean_ResearchEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSelected_Internal_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SelectedResearch_Public_Void_ResearchEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearSelectedResearch_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedResearch_Public_ResearchEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTechTree_Public_Void_ResearchstationMenuMapper_Entity_Entity_GameDataSystem_PrefabCollectionSystem_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedResearch_Internal_Void_ResearchEntry_Entity_GameDataSystem_PrefabCollectionSystem_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForceRefreshLayout_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245443, XrefRangeEnd = 1245509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1245526, RefRangeEnd = 1245527, XrefRangeStart = 1245509, XrefRangeEnd = 1245526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1245543, RefRangeEnd = 1245544, XrefRangeStart = 1245527, XrefRangeEnd = 1245543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleCategory(TechCateogry teachCategory, bool enabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &teachCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_ToggleCategory_Internal_Void_TechCateogry_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1245545, RefRangeEnd = 1245546, XrefRangeStart = 1245544, XrefRangeEnd = 1245545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered(PrefabGUID researchGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &researchGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void HoveredReserach(PrefabGUID guid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &guid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_HoveredReserach_Public_Void_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245546, XrefRangeEnd = 1245550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSelected(ResearchEntry research)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) research);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_IsSelected_Internal_Boolean_ResearchEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1245554, RefRangeEnd = 1245555, XrefRangeStart = 1245550, XrefRangeEnd = 1245554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSelected(PrefabGUID research)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &research;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_IsSelected_Internal_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SelectedResearch(ResearchEntry research)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) research);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_SelectedResearch_Public_Void_ResearchEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1245556, RefRangeEnd = 1245557, XrefRangeStart = 1245555, XrefRangeEnd = 1245556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearSelectedResearch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_ClearSelectedResearch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe ResearchEntry GetSelectedResearch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_GetSelectedResearch_Public_ResearchEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ResearchEntry) null : new ResearchEntry(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1245701, RefRangeEnd = 1245702, XrefRangeStart = 1245557, XrefRangeEnd = 1245701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTechTree(
      ResearchstationMenuMapper researchstationMenuMapper,
      Entity localUser,
      Entity localPlayer,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      EntityManager entityManager,
      Entity researchstationEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) researchstationMenuMapper);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &researchstationEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_UpdateTechTree_Public_Void_ResearchstationMenuMapper_Entity_Entity_GameDataSystem_PrefabCollectionSystem_EntityManager_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1245733, RefRangeEnd = 1245734, XrefRangeStart = 1245702, XrefRangeEnd = 1245733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSelectedResearch(
      ResearchEntry entry,
      Entity localUser,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_SetSelectedResearch_Internal_Void_ResearchEntry_Entity_GameDataSystem_PrefabCollectionSystem_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1245742, RefRangeEnd = 1245743, XrefRangeStart = 1245734, XrefRangeEnd = 1245742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ForceRefreshLayout()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr_ForceRefreshLayout_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245743, XrefRangeEnd = 1245751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ResearchstationSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ResearchstationSubMenu()
    {
      Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ResearchstationSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr);
      ResearchstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (CastleFloorsLocalizationKeys));
      ResearchstationSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      ResearchstationSubMenu.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (TooltipAnchor));
      ResearchstationSubMenu.NativeFieldInfoPtr_ResearchstationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (ResearchstationName));
      ResearchstationSubMenu.NativeFieldInfoPtr_StationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (StationDescription));
      ResearchstationSubMenu.NativeFieldInfoPtr_VerticalLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (VerticalLayoutGroup));
      ResearchstationSubMenu.NativeFieldInfoPtr_Button_Discover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (Button_Discover));
      ResearchstationSubMenu.NativeFieldInfoPtr_ButtonDiscoverText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (ButtonDiscoverText));
      ResearchstationSubMenu.NativeFieldInfoPtr_DiscoverCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (DiscoverCost));
      ResearchstationSubMenu.NativeFieldInfoPtr_Prefab_ResearchEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (Prefab_ResearchEntry));
      ResearchstationSubMenu.NativeFieldInfoPtr_Parent_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (Parent_Cost));
      ResearchstationSubMenu.NativeFieldInfoPtr_List_ResearchCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (List_ResearchCost));
      ResearchstationSubMenu.NativeFieldInfoPtr_Button_Research = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (Button_Research));
      ResearchstationSubMenu.NativeFieldInfoPtr_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (ButtonText));
      ResearchstationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (LKey_StatusOutputFull));
      ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Researchable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (LKey_Researchable));
      ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Learn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (LKey_Learn));
      ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Insertable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (LKey_Insertable));
      ResearchstationSubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      ResearchstationSubMenu.NativeFieldInfoPtr_ResearchCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (ResearchCategories));
      ResearchstationSubMenu.NativeFieldInfoPtr__SelectedReserach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (_SelectedReserach));
      ResearchstationSubMenu.NativeFieldInfoPtr__HoveredReserach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (_HoveredReserach));
      ResearchstationSubMenu.NativeFieldInfoPtr_StoredTreeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (StoredTreeEntries));
      ResearchstationSubMenu.NativeFieldInfoPtr__CachedResearchCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, nameof (_CachedResearchCosts));
      ResearchstationSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666291);
      ResearchstationSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666292);
      ResearchstationSubMenu.NativeMethodInfoPtr_ToggleCategory_Internal_Void_TechCateogry_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666293);
      ResearchstationSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666294);
      ResearchstationSubMenu.NativeMethodInfoPtr_HoveredReserach_Public_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666295);
      ResearchstationSubMenu.NativeMethodInfoPtr_IsSelected_Internal_Boolean_ResearchEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666296);
      ResearchstationSubMenu.NativeMethodInfoPtr_IsSelected_Internal_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666297);
      ResearchstationSubMenu.NativeMethodInfoPtr_SelectedResearch_Public_Void_ResearchEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666298);
      ResearchstationSubMenu.NativeMethodInfoPtr_ClearSelectedResearch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666299);
      ResearchstationSubMenu.NativeMethodInfoPtr_GetSelectedResearch_Public_ResearchEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666300);
      ResearchstationSubMenu.NativeMethodInfoPtr_UpdateTechTree_Public_Void_ResearchstationMenuMapper_Entity_Entity_GameDataSystem_PrefabCollectionSystem_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666301);
      ResearchstationSubMenu.NativeMethodInfoPtr_SetSelectedResearch_Internal_Void_ResearchEntry_Entity_GameDataSystem_PrefabCollectionSystem_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666302);
      ResearchstationSubMenu.NativeMethodInfoPtr_ForceRefreshLayout_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666303);
      ResearchstationSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, 100666304);
    }

    public ResearchstationSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleFloorsLocalizationKeys CastleFloorsLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (CastleFloorsLocalizationKeys) null : new CastleFloorsLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ResearchstationName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ResearchstationName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ResearchstationName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StationDescription
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_StationDescription));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_StationDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VerticalLayoutGroup VerticalLayoutGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_VerticalLayoutGroup));
        return pointer == System.IntPtr.Zero ? (VerticalLayoutGroup) null : new VerticalLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_VerticalLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button_Discover
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_Button_Discover));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_Button_Discover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ButtonDiscoverText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ButtonDiscoverText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ButtonDiscoverText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorkstationRequirementEntry DiscoverCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_DiscoverCost));
        return pointer == System.IntPtr.Zero ? (WorkstationRequirementEntry) null : new WorkstationRequirementEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_DiscoverCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ResearchEntry Prefab_ResearchEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_Prefab_ResearchEntry));
        return pointer == System.IntPtr.Zero ? (ResearchEntry) null : new ResearchEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_Prefab_ResearchEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Parent_Cost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_Parent_Cost));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_Parent_Cost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WorkstationRequirementEntry> List_ResearchCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_List_ResearchCost));
        return pointer == System.IntPtr.Zero ? (List<WorkstationRequirementEntry>) null : new List<WorkstationRequirementEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_List_ResearchCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button_Research
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_Button_Research));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_Button_Research), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_StatusOutputFull
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_LKey_StatusOutputFull)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Researchable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Researchable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Researchable)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Learn
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Learn));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Learn)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Insertable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Insertable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_LKey_Insertable)) = value;
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ResearchGroupEntry> ResearchCategories
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ResearchCategories));
        return pointer == System.IntPtr.Zero ? (List<ResearchGroupEntry>) null : new List<ResearchGroupEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_ResearchCategories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ResearchEntry _SelectedReserach
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr__SelectedReserach));
        return pointer == System.IntPtr.Zero ? (ResearchEntry) null : new ResearchEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr__SelectedReserach), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID _HoveredReserach
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr__HoveredReserach));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr__HoveredReserach)) = value;
      }
    }

    public unsafe List<ResearchEntry> StoredTreeEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_StoredTreeEntries));
        return pointer == System.IntPtr.Zero ? (List<ResearchEntry>) null : new List<ResearchEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr_StoredTreeEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<PrefabGUID, List<CostData>> _CachedResearchCosts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr__CachedResearchCosts));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, List<CostData>>) null : new Dictionary<PrefabGUID, List<CostData>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.NativeFieldInfoPtr__CachedResearchCosts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.ResearchstationSubMenu/<>c__DisplayClass24_0")]
    public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_category;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__1_Internal_Void_ResearchEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass24_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchstationSubMenu.__c__DisplayClass24_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245441, XrefRangeEnd = 1245443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__1(
        ResearchEntry entry,
        ResearchEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.__c__DisplayClass24_0.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__1_Internal_Void_ResearchEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass24_0()
      {
        Il2CppClassPointerStore<ResearchstationSubMenu.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, "<>c__DisplayClass24_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchstationSubMenu.__c__DisplayClass24_0>.NativeClassPtr);
        ResearchstationSubMenu.__c__DisplayClass24_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu.__c__DisplayClass24_0>.NativeClassPtr, nameof (category));
        ResearchstationSubMenu.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu.__c__DisplayClass24_0>.NativeClassPtr, 100666305);
        ResearchstationSubMenu.__c__DisplayClass24_0.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__1_Internal_Void_ResearchEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu.__c__DisplayClass24_0>.NativeClassPtr, 100666306);
      }

      public __c__DisplayClass24_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ResearchGroupEntry category
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.__c__DisplayClass24_0.NativeFieldInfoPtr_category));
          return pointer == System.IntPtr.Zero ? (ResearchGroupEntry) null : new ResearchGroupEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationSubMenu.__c__DisplayClass24_0.NativeFieldInfoPtr_category), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ResearchstationSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__24_0_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchstationSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__24_0(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ResearchstationSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__24_0_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<ResearchstationSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchstationSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchstationSubMenu.__c>.NativeClassPtr);
        ResearchstationSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu.__c>.NativeClassPtr, "<>9");
        ResearchstationSubMenu.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationSubMenu.__c>.NativeClassPtr, "<>9__24_0");
        ResearchstationSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu.__c>.NativeClassPtr, 100666308);
        ResearchstationSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__24_0_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationSubMenu.__c>.NativeClassPtr, 100666309);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ResearchstationSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ResearchstationSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ResearchstationSubMenu.__c) null : new ResearchstationSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ResearchstationSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__24_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ResearchstationSubMenu.__c.NativeFieldInfoPtr___9__24_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ResearchstationSubMenu.__c.NativeFieldInfoPtr___9__24_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
