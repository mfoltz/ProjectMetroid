// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServantMissionSubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
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
  public class ServantMissionSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentMapZoneDataEntity_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor_Servants;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_Main;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motion2DInOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_MissionName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_MissionDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_MissionDifficulty;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image_MissionImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab_MissionPerkEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_Grid_MissionPerk;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionPerkGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab_MissionServantEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_Grid_MissionServantEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionAssignedServantGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_MissionLength_ToBeSent;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_CurrentMissionLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_CurrentInjuredChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_RaidStability;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sider_MissionLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slider_Easy;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slider_Hard;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RaidReckless;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RaidPrepared;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_RaidNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_DontStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_MissionLength_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_NoSelectedServants;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image_MissionProgressRemaining;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text_MissionTimeRemaning;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab_MissionLootResultEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_Grid_MissionLootResultEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionLootResultGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent_SelectServant;
    private static readonly System.IntPtr NativeFieldInfoPtr_Grid_SelectServant;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab_AllServantEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_ListOfAllServantsGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_CancelButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneColor_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneColor_Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapZoneColor_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedMissionServantIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AssignedServantRemoveButtonClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowPanel;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentMapZoneDataEntity_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentMapZoneDataEntity_Public_set_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Close_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_0_Private_Void_MissionPerkEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_1_Private_Void_MissionServantEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_2_Private_Void_MissionServantEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_3_Private_Void_MissionLootResultEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_4_Private_Void_ServantSelectEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_6_Private_Void_0;

    public unsafe Entity CurrentMapZoneDataEntity
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22439, RefRangeEnd = 22440, XrefRangeStart = 22439, XrefRangeEnd = 22440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr_get_CurrentMapZoneDataEntity_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr_set_CurrentMapZoneDataEntity_Public_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249504, XrefRangeEnd = 1249606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249606, XrefRangeEnd = 1249615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1249631, RefRangeEnd = 1249632, XrefRangeStart = 1249615, XrefRangeEnd = 1249631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1249633, RefRangeEnd = 1249634, XrefRangeStart = 1249632, XrefRangeEnd = 1249633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Close()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr_Close_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249634, XrefRangeEnd = 1249636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantMissionSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249636, XrefRangeEnd = 1249638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__54_0(
      MissionPerkEntry entry,
      MissionPerkEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_0_Private_Void_MissionPerkEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249638, XrefRangeEnd = 1249640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__54_1(
      MissionServantEntry entry,
      MissionServantEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_1_Private_Void_MissionServantEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249640, XrefRangeEnd = 1249654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__54_2(
      MissionServantEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_2_Private_Void_MissionServantEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249654, XrefRangeEnd = 1249656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__54_3(
      MissionLootResultEntry entry,
      MissionLootResultEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_3_Private_Void_MissionLootResultEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249656, XrefRangeEnd = 1249658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__54_4(
      ServantSelectEntry entry,
      ServantSelectEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_4_Private_Void_ServantSelectEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249658, XrefRangeEnd = 1249667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__54_6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantMissionSubMenu()
    {
      Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServantMissionSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr);
      ServantMissionSubMenu.NativeFieldInfoPtr__CurrentMapZoneDataEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, "<CurrentMapZoneDataEntity>k__BackingField");
      ServantMissionSubMenu.NativeFieldInfoPtr_InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (InteractBuff));
      ServantMissionSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      ServantMissionSubMenu.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (TooltipAnchor));
      ServantMissionSubMenu.NativeFieldInfoPtr_TooltipAnchor_Servants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (TooltipAnchor_Servants));
      ServantMissionSubMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      ServantMissionSubMenu.NativeFieldInfoPtr_Parent_Main = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Parent_Main));
      ServantMissionSubMenu.NativeFieldInfoPtr_ExitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (ExitButton));
      ServantMissionSubMenu.NativeFieldInfoPtr_SendButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (SendButton));
      ServantMissionSubMenu.NativeFieldInfoPtr_Motion2DInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Motion2DInOut));
      ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Text_MissionName));
      ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Text_MissionDesc));
      ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Text_MissionDifficulty));
      ServantMissionSubMenu.NativeFieldInfoPtr_Image_MissionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Image_MissionImage));
      ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionPerkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Prefab_MissionPerkEntry));
      ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionPerk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Grid_MissionPerk));
      ServantMissionSubMenu.NativeFieldInfoPtr_MissionPerkGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (MissionPerkGroup));
      ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionServantEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Prefab_MissionServantEntry));
      ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionServantEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Grid_MissionServantEntry));
      ServantMissionSubMenu.NativeFieldInfoPtr_MissionAssignedServantGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (MissionAssignedServantGroup));
      ServantMissionSubMenu.NativeFieldInfoPtr_Parent_MissionLength_ToBeSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Parent_MissionLength_ToBeSent));
      ServantMissionSubMenu.NativeFieldInfoPtr_Text_CurrentMissionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Text_CurrentMissionLength));
      ServantMissionSubMenu.NativeFieldInfoPtr_Text_CurrentInjuredChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Text_CurrentInjuredChance));
      ServantMissionSubMenu.NativeFieldInfoPtr_Text_RaidStability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Text_RaidStability));
      ServantMissionSubMenu.NativeFieldInfoPtr_Sider_MissionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Sider_MissionLength));
      ServantMissionSubMenu.NativeFieldInfoPtr_Slider_Easy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Slider_Easy));
      ServantMissionSubMenu.NativeFieldInfoPtr_Slider_Hard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Slider_Hard));
      ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidReckless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (LKey_RaidReckless));
      ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidPrepared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (LKey_RaidPrepared));
      ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (LKey_RaidNormal));
      ServantMissionSubMenu.NativeFieldInfoPtr_LKey_DontStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (LKey_DontStack));
      ServantMissionSubMenu.NativeFieldInfoPtr_Parent_MissionLength_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Parent_MissionLength_Active));
      ServantMissionSubMenu.NativeFieldInfoPtr_Text_NoSelectedServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Text_NoSelectedServants));
      ServantMissionSubMenu.NativeFieldInfoPtr_Image_MissionProgressRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Image_MissionProgressRemaining));
      ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionTimeRemaning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Text_MissionTimeRemaning));
      ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionLootResultEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Prefab_MissionLootResultEntry));
      ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionLootResultEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Grid_MissionLootResultEntry));
      ServantMissionSubMenu.NativeFieldInfoPtr_MissionLootResultGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (MissionLootResultGroup));
      ServantMissionSubMenu.NativeFieldInfoPtr_Parent_SelectServant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Parent_SelectServant));
      ServantMissionSubMenu.NativeFieldInfoPtr_Grid_SelectServant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Grid_SelectServant));
      ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_AllServantEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (Prefab_AllServantEntry));
      ServantMissionSubMenu.NativeFieldInfoPtr_ListOfAllServantsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (ListOfAllServantsGroup));
      ServantMissionSubMenu.NativeFieldInfoPtr_SelectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (SelectButton));
      ServantMissionSubMenu.NativeFieldInfoPtr_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (CancelButton));
      ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (MapZoneColor_Active));
      ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (MapZoneColor_Selected));
      ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (MapZoneColor_Normal));
      ServantMissionSubMenu.NativeFieldInfoPtr_SelectedMissionServantIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (SelectedMissionServantIndex));
      ServantMissionSubMenu.NativeFieldInfoPtr_AssignedServantRemoveButtonClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (AssignedServantRemoveButtonClicked));
      ServantMissionSubMenu.NativeFieldInfoPtr_GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (GameDataSystem));
      ServantMissionSubMenu.NativeFieldInfoPtr_ShowPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, nameof (ShowPanel));
      ServantMissionSubMenu.NativeMethodInfoPtr_get_CurrentMapZoneDataEntity_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666522);
      ServantMissionSubMenu.NativeMethodInfoPtr_set_CurrentMapZoneDataEntity_Public_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666523);
      ServantMissionSubMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666524);
      ServantMissionSubMenu.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666525);
      ServantMissionSubMenu.NativeMethodInfoPtr_IsHovered_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666526);
      ServantMissionSubMenu.NativeMethodInfoPtr_Close_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666527);
      ServantMissionSubMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666528);
      ServantMissionSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666529);
      ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_0_Private_Void_MissionPerkEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666530);
      ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_1_Private_Void_MissionServantEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666531);
      ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_2_Private_Void_MissionServantEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666532);
      ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_3_Private_Void_MissionLootResultEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666533);
      ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_4_Private_Void_ServantSelectEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666534);
      ServantMissionSubMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, 100666535);
    }

    public ServantMissionSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity _CurrentMapZoneDataEntity_k__BackingField
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr__CurrentMapZoneDataEntity_k__BackingField));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr__CurrentMapZoneDataEntity_k__BackingField)) = value;
      }
    }

    public unsafe PrefabGuidComponent InteractBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_InteractBuff));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_InteractBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipAnchor_Servants
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_TooltipAnchor_Servants));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_TooltipAnchor_Servants), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextsCollection ControllerInputContexts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return pointer == System.IntPtr.Zero ? (InputContextsCollection) null : new InputContextsCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Parent_Main
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Parent_Main));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Parent_Main), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ExitButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_ExitButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_ExitButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SendButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_SendButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_SendButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion2DInOut
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Motion2DInOut));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Motion2DInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_MissionName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_MissionDesc
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionDesc));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_MissionDifficulty
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionDifficulty));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionDifficulty), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_MissionImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Image_MissionImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Image_MissionImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MissionPerkEntry Prefab_MissionPerkEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionPerkEntry));
        return pointer == System.IntPtr.Zero ? (MissionPerkEntry) null : new MissionPerkEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionPerkEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup Grid_MissionPerk
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionPerk));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionPerk), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data> MissionPerkGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MissionPerkGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data>) null : new GridSelectionGroup<MissionPerkEntry, MissionPerkEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MissionPerkGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MissionServantEntry Prefab_MissionServantEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionServantEntry));
        return pointer == System.IntPtr.Zero ? (MissionServantEntry) null : new MissionServantEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionServantEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup Grid_MissionServantEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionServantEntry));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionServantEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<MissionServantEntry, MissionServantEntry.Data> MissionAssignedServantGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MissionAssignedServantGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<MissionServantEntry, MissionServantEntry.Data>) null : new GridSelectionGroup<MissionServantEntry, MissionServantEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MissionAssignedServantGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Parent_MissionLength_ToBeSent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Parent_MissionLength_ToBeSent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Parent_MissionLength_ToBeSent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_CurrentMissionLength
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_CurrentMissionLength));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_CurrentMissionLength), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_CurrentInjuredChance
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_CurrentInjuredChance));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_CurrentInjuredChance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_RaidStability
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_RaidStability));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_RaidStability), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Slider Sider_MissionLength
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Sider_MissionLength));
        return pointer == System.IntPtr.Zero ? (Slider) null : new Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Sider_MissionLength), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Slider_Easy
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Slider_Easy));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Slider_Easy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Slider_Hard
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Slider_Hard));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Slider_Hard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_RaidReckless
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidReckless));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidReckless)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RaidPrepared
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidPrepared));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidPrepared)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RaidNormal
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidNormal));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_LKey_RaidNormal)) = value;
      }
    }

    public unsafe LocalizationKey LKey_DontStack
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_LKey_DontStack));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_LKey_DontStack)) = value;
      }
    }

    public unsafe GameObject Parent_MissionLength_Active
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Parent_MissionLength_Active));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Parent_MissionLength_Active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_NoSelectedServants
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_NoSelectedServants));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_NoSelectedServants), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_MissionProgressRemaining
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Image_MissionProgressRemaining));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Image_MissionProgressRemaining), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_MissionTimeRemaning
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionTimeRemaning));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Text_MissionTimeRemaning), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MissionLootResultEntry Prefab_MissionLootResultEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionLootResultEntry));
        return pointer == System.IntPtr.Zero ? (MissionLootResultEntry) null : new MissionLootResultEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_MissionLootResultEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup Grid_MissionLootResultEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionLootResultEntry));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Grid_MissionLootResultEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<MissionLootResultEntry, MissionLootResultEntry.Data> MissionLootResultGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MissionLootResultGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<MissionLootResultEntry, MissionLootResultEntry.Data>) null : new GridSelectionGroup<MissionLootResultEntry, MissionLootResultEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MissionLootResultGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Parent_SelectServant
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Parent_SelectServant));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Parent_SelectServant), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup Grid_SelectServant
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Grid_SelectServant));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Grid_SelectServant), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantSelectEntry Prefab_AllServantEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_AllServantEntry));
        return pointer == System.IntPtr.Zero ? (ServantSelectEntry) null : new ServantSelectEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_Prefab_AllServantEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ServantSelectEntry, ServantSelectEntry.Data> ListOfAllServantsGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_ListOfAllServantsGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ServantSelectEntry, ServantSelectEntry.Data>) null : new GridSelectionGroup<ServantSelectEntry, ServantSelectEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_ListOfAllServantsGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_SelectButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_SelectButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CancelButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_CancelButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_CancelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color MapZoneColor_Active
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Active));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Active)) = value;
      }
    }

    public unsafe Color MapZoneColor_Selected
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Selected));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Selected)) = value;
      }
    }

    public unsafe Color MapZoneColor_Normal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Normal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_MapZoneColor_Normal)) = value;
      }
    }

    public unsafe int SelectedMissionServantIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_SelectedMissionServantIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_SelectedMissionServantIndex)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<int> AssignedServantRemoveButtonClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_AssignedServantRemoveButtonClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_AssignedServantRemoveButtonClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool ShowPanel
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_ShowPanel));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.NativeFieldInfoPtr_ShowPanel)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.ServantMissionSubMenu/<>c__DisplayClass54_0")]
    public sealed class __c__DisplayClass54_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass54_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSubMenu.__c__DisplayClass54_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249501, XrefRangeEnd = 1249504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__7()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.__c__DisplayClass54_0.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass54_0()
      {
        Il2CppClassPointerStore<ServantMissionSubMenu.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, "<>c__DisplayClass54_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenu.__c__DisplayClass54_0>.NativeClassPtr);
        ServantMissionSubMenu.__c__DisplayClass54_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu.__c__DisplayClass54_0>.NativeClassPtr, nameof (entry));
        ServantMissionSubMenu.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu.__c__DisplayClass54_0>.NativeClassPtr, "<>4__this");
        ServantMissionSubMenu.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu.__c__DisplayClass54_0>.NativeClassPtr, 100666536);
        ServantMissionSubMenu.__c__DisplayClass54_0.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu.__c__DisplayClass54_0>.NativeClassPtr, 100666537);
      }

      public __c__DisplayClass54_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe MissionServantEntry entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.__c__DisplayClass54_0.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (MissionServantEntry) null : new MissionServantEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.__c__DisplayClass54_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServantMissionSubMenu __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantMissionSubMenu) null : new ServantMissionSubMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenu.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServantMissionSubMenu/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__54_5;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_5_Internal_Void_InputContextEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSubMenu.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__54_5(
        InputContextEntry entry,
        InputContextEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_5_Internal_Void_InputContextEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<ServantMissionSubMenu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenu>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenu.__c>.NativeClassPtr);
        ServantMissionSubMenu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu.__c>.NativeClassPtr, "<>9");
        ServantMissionSubMenu.__c.NativeFieldInfoPtr___9__54_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenu.__c>.NativeClassPtr, "<>9__54_5");
        ServantMissionSubMenu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu.__c>.NativeClassPtr, 100666539);
        ServantMissionSubMenu.__c.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__54_5_Internal_Void_InputContextEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenu.__c>.NativeClassPtr, 100666540);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ServantMissionSubMenu.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenu.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ServantMissionSubMenu.__c) null : new ServantMissionSubMenu.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenu.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data> __9__54_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenu.__c.NativeFieldInfoPtr___9__54_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>) null : new Il2CppSystem.Action<InputContextEntry, InputContextEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenu.__c.NativeFieldInfoPtr___9__54_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
