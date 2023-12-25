// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UICanvasBase
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public class UICanvasBase : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Canvas;
    private static readonly IntPtr NativeFieldInfoPtr_HUDMenus;
    private static readonly IntPtr NativeFieldInfoPtr_DebugMenuPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_FadeToBlack;
    private static readonly IntPtr NativeFieldInfoPtr_HUDParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDMenuParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDDebugMenuParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDDragAndDropParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDLinksParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDMinimapParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDAchievementsParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDClanParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDWheelParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDEdgeIconsParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDTutorialParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDRecipeTrackerParent;
    private static readonly IntPtr NativeFieldInfoPtr_VersionParent;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipsParent;
    private static readonly IntPtr NativeFieldInfoPtr_CharacterHUDs;
    private static readonly IntPtr NativeFieldInfoPtr_SCTParent;
    private static readonly IntPtr NativeFieldInfoPtr_DebugLogsParent;
    private static readonly IntPtr NativeFieldInfoPtr_HUDChatParent;
    private static readonly IntPtr NativeFieldInfoPtr_DebugViewParent;
    private static readonly IntPtr NativeFieldInfoPtr_SlowConnectionParent;
    private static readonly IntPtr NativeFieldInfoPtr_TargetInfoPanelParent;
    private static readonly IntPtr NativeFieldInfoPtr_PopupParent;
    private static readonly IntPtr NativeFieldInfoPtr_BottomBarParent;
    private static readonly IntPtr NativeFieldInfoPtr_ScreenCraftingParent;
    private static readonly IntPtr NativeFieldInfoPtr_ReplayParent;
    private static readonly IntPtr NativeFieldInfoPtr_SCTPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_InteractHUD_Big;
    private static readonly IntPtr NativeFieldInfoPtr_InteractHUD_Slim;
    private static readonly IntPtr NativeFieldInfoPtr_ClockHUDParent;
    private static readonly IntPtr NativeFieldInfoPtr_ReplayHUDParent;
    private static readonly IntPtr NativeFieldInfoPtr_AchievementsParent;
    private static readonly IntPtr NativeFieldInfoPtr_ClanParent;
    private static readonly IntPtr NativeFieldInfoPtr_TutorialParent;
    private static readonly IntPtr NativeFieldInfoPtr_RecipeTracker;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityParent;
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementHUDParent;
    private static readonly IntPtr NativeFieldInfoPtr_ScreenCraftingParentPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_DangerTextParent;
    private static readonly IntPtr NativeFieldInfoPtr_FeedInteractionProgress;
    private static readonly IntPtr NativeFieldInfoPtr_ReviveCancel;
    private static readonly IntPtr NativeFieldInfoPtr_LinksHUDParent;
    private static readonly IntPtr NativeFieldInfoPtr_MiniMapHUDParent;
    private static readonly IntPtr NativeFieldInfoPtr_DebugStats;
    private static readonly IntPtr NativeFieldInfoPtr_BottomBarParentPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_DragAndDropParent;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipsParentPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_DebugLogsViewPrefabs;
    private static readonly IntPtr NativeFieldInfoPtr_ChatWindowPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ActionWheel;
    private static readonly IntPtr NativeFieldInfoPtr_TargetInfoParent;
    private static readonly IntPtr NativeFieldInfoPtr_EventSystemPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ScreenEdgeIconPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_MapZoneHelperDataPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_SlowConnectionIconPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_DisconnectedPopupPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_LK_ExitGame;
    private static readonly IntPtr NativeFieldInfoPtr_LK_LostConnection;
    private static readonly IntPtr NativeFieldInfoPtr_LK_LeaveGame;
    private static readonly IntPtr NativeFieldInfoPtr_LocalizedStatusMessages;
    private static readonly IntPtr NativeFieldInfoPtr_SoundMapping;
    private static readonly IntPtr NativeFieldInfoPtr_HUDElementComponents;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287995, XrefRangeEnd = 1288003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UICanvasBase.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UICanvasBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UICanvasBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UICanvasBase()
    {
      Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UICanvasBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr);
      UICanvasBase.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (Canvas));
      UICanvasBase.NativeFieldInfoPtr_HUDMenus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDMenus));
      UICanvasBase.NativeFieldInfoPtr_DebugMenuPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DebugMenuPrefab));
      UICanvasBase.NativeFieldInfoPtr_FadeToBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (FadeToBlack));
      UICanvasBase.NativeFieldInfoPtr_HUDParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDParent));
      UICanvasBase.NativeFieldInfoPtr_HUDMenuParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDMenuParent));
      UICanvasBase.NativeFieldInfoPtr_HUDDebugMenuParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDDebugMenuParent));
      UICanvasBase.NativeFieldInfoPtr_HUDDragAndDropParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDDragAndDropParent));
      UICanvasBase.NativeFieldInfoPtr_HUDLinksParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDLinksParent));
      UICanvasBase.NativeFieldInfoPtr_HUDMinimapParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDMinimapParent));
      UICanvasBase.NativeFieldInfoPtr_HUDAchievementsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDAchievementsParent));
      UICanvasBase.NativeFieldInfoPtr_HUDClanParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDClanParent));
      UICanvasBase.NativeFieldInfoPtr_HUDWheelParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDWheelParent));
      UICanvasBase.NativeFieldInfoPtr_HUDEdgeIconsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDEdgeIconsParent));
      UICanvasBase.NativeFieldInfoPtr_HUDTutorialParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDTutorialParent));
      UICanvasBase.NativeFieldInfoPtr_HUDRecipeTrackerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDRecipeTrackerParent));
      UICanvasBase.NativeFieldInfoPtr_VersionParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (VersionParent));
      UICanvasBase.NativeFieldInfoPtr_TooltipsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (TooltipsParent));
      UICanvasBase.NativeFieldInfoPtr_CharacterHUDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (CharacterHUDs));
      UICanvasBase.NativeFieldInfoPtr_SCTParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (SCTParent));
      UICanvasBase.NativeFieldInfoPtr_DebugLogsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DebugLogsParent));
      UICanvasBase.NativeFieldInfoPtr_HUDChatParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDChatParent));
      UICanvasBase.NativeFieldInfoPtr_DebugViewParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DebugViewParent));
      UICanvasBase.NativeFieldInfoPtr_SlowConnectionParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (SlowConnectionParent));
      UICanvasBase.NativeFieldInfoPtr_TargetInfoPanelParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (TargetInfoPanelParent));
      UICanvasBase.NativeFieldInfoPtr_PopupParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (PopupParent));
      UICanvasBase.NativeFieldInfoPtr_BottomBarParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (BottomBarParent));
      UICanvasBase.NativeFieldInfoPtr_ScreenCraftingParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ScreenCraftingParent));
      UICanvasBase.NativeFieldInfoPtr_ReplayParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ReplayParent));
      UICanvasBase.NativeFieldInfoPtr_SCTPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (SCTPrefab));
      UICanvasBase.NativeFieldInfoPtr_InteractHUD_Big = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (InteractHUD_Big));
      UICanvasBase.NativeFieldInfoPtr_InteractHUD_Slim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (InteractHUD_Slim));
      UICanvasBase.NativeFieldInfoPtr_ClockHUDParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ClockHUDParent));
      UICanvasBase.NativeFieldInfoPtr_ReplayHUDParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ReplayHUDParent));
      UICanvasBase.NativeFieldInfoPtr_AchievementsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (AchievementsParent));
      UICanvasBase.NativeFieldInfoPtr_ClanParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ClanParent));
      UICanvasBase.NativeFieldInfoPtr_TutorialParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (TutorialParent));
      UICanvasBase.NativeFieldInfoPtr_RecipeTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (RecipeTracker));
      UICanvasBase.NativeFieldInfoPtr_DurabilityParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DurabilityParent));
      UICanvasBase.NativeFieldInfoPtr_AnnouncementHUDParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (AnnouncementHUDParent));
      UICanvasBase.NativeFieldInfoPtr_ScreenCraftingParentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ScreenCraftingParentPrefab));
      UICanvasBase.NativeFieldInfoPtr_DangerTextParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DangerTextParent));
      UICanvasBase.NativeFieldInfoPtr_FeedInteractionProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (FeedInteractionProgress));
      UICanvasBase.NativeFieldInfoPtr_ReviveCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ReviveCancel));
      UICanvasBase.NativeFieldInfoPtr_LinksHUDParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (LinksHUDParent));
      UICanvasBase.NativeFieldInfoPtr_MiniMapHUDParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (MiniMapHUDParent));
      UICanvasBase.NativeFieldInfoPtr_DebugStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DebugStats));
      UICanvasBase.NativeFieldInfoPtr_BottomBarParentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (BottomBarParentPrefab));
      UICanvasBase.NativeFieldInfoPtr_DragAndDropParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DragAndDropParent));
      UICanvasBase.NativeFieldInfoPtr_TooltipsParentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (TooltipsParentPrefab));
      UICanvasBase.NativeFieldInfoPtr_DebugLogsViewPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DebugLogsViewPrefabs));
      UICanvasBase.NativeFieldInfoPtr_ChatWindowPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ChatWindowPrefab));
      UICanvasBase.NativeFieldInfoPtr_ActionWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ActionWheel));
      UICanvasBase.NativeFieldInfoPtr_TargetInfoParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (TargetInfoParent));
      UICanvasBase.NativeFieldInfoPtr_EventSystemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (EventSystemPrefab));
      UICanvasBase.NativeFieldInfoPtr_ScreenEdgeIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (ScreenEdgeIconPrefab));
      UICanvasBase.NativeFieldInfoPtr_MapZoneHelperDataPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (MapZoneHelperDataPrefab));
      UICanvasBase.NativeFieldInfoPtr_SlowConnectionIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (SlowConnectionIconPrefab));
      UICanvasBase.NativeFieldInfoPtr_DisconnectedPopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (DisconnectedPopupPrefab));
      UICanvasBase.NativeFieldInfoPtr_LK_ExitGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (LK_ExitGame));
      UICanvasBase.NativeFieldInfoPtr_LK_LostConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (LK_LostConnection));
      UICanvasBase.NativeFieldInfoPtr_LK_LeaveGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (LK_LeaveGame));
      UICanvasBase.NativeFieldInfoPtr_LocalizedStatusMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (LocalizedStatusMessages));
      UICanvasBase.NativeFieldInfoPtr_SoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (SoundMapping));
      UICanvasBase.NativeFieldInfoPtr_HUDElementComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, nameof (HUDElementComponents));
      UICanvasBase.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, 100669615);
      UICanvasBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICanvasBase>.NativeClassPtr, 100669616);
    }

    public UICanvasBase(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Canvas Canvas
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_Canvas));
        return pointer == IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HUDMenuMapping> HUDMenus
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDMenus));
        return pointer == IntPtr.Zero ? (List<HUDMenuMapping>) null : new List<HUDMenuMapping>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDMenus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDMenu DebugMenuPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugMenuPrefab));
        return pointer == IntPtr.Zero ? (HUDMenu) null : new HUDMenu(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugMenuPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CanvasGroup FadeToBlack
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_FadeToBlack));
        return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_FadeToBlack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDMenuParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDMenuParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDMenuParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDDebugMenuParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDDebugMenuParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDDebugMenuParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDDragAndDropParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDDragAndDropParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDDragAndDropParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDLinksParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDLinksParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDLinksParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDMinimapParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDMinimapParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDMinimapParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDAchievementsParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDAchievementsParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDAchievementsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDClanParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDClanParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDClanParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDWheelParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDWheelParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDWheelParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDEdgeIconsParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDEdgeIconsParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDEdgeIconsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDTutorialParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDTutorialParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDTutorialParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDRecipeTrackerParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDRecipeTrackerParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDRecipeTrackerParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform VersionParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_VersionParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_VersionParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipsParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TooltipsParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TooltipsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform CharacterHUDs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_CharacterHUDs));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_CharacterHUDs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SCTParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SCTParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SCTParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform DebugLogsParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugLogsParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugLogsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform HUDChatParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDChatParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDChatParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform DebugViewParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugViewParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugViewParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SlowConnectionParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SlowConnectionParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SlowConnectionParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TargetInfoPanelParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TargetInfoPanelParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TargetInfoPanelParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PopupParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_PopupParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_PopupParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform BottomBarParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_BottomBarParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_BottomBarParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ScreenCraftingParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ScreenCraftingParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ScreenCraftingParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ReplayParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ReplayParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ReplayParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCTText SCTPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SCTPrefab));
        return pointer == IntPtr.Zero ? (SCTText) null : new SCTText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SCTPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InteractHUDParent InteractHUD_Big
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_InteractHUD_Big));
        return pointer == IntPtr.Zero ? (InteractHUDParent) null : new InteractHUDParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_InteractHUD_Big), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InteractHUDParent InteractHUD_Slim
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_InteractHUD_Slim));
        return pointer == IntPtr.Zero ? (InteractHUDParent) null : new InteractHUDParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_InteractHUD_Slim), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClockHUDParent ClockHUDParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ClockHUDParent));
        return pointer == IntPtr.Zero ? (ClockHUDParent) null : new ClockHUDParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ClockHUDParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ReplayHUDParent ReplayHUDParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ReplayHUDParent));
        return pointer == IntPtr.Zero ? (ReplayHUDParent) null : new ReplayHUDParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ReplayHUDParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AchievementsParent AchievementsParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_AchievementsParent));
        return pointer == IntPtr.Zero ? (AchievementsParent) null : new AchievementsParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_AchievementsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClanParent ClanParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ClanParent));
        return pointer == IntPtr.Zero ? (ClanParent) null : new ClanParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ClanParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TutorialParent TutorialParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TutorialParent));
        return pointer == IntPtr.Zero ? (TutorialParent) null : new TutorialParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TutorialParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDRecipeTracker RecipeTracker
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_RecipeTracker));
        return pointer == IntPtr.Zero ? (HUDRecipeTracker) null : new HUDRecipeTracker(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_RecipeTracker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DurabilityParent DurabilityParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DurabilityParent));
        return pointer == IntPtr.Zero ? (DurabilityParent) null : new DurabilityParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DurabilityParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnnouncementHUDParent AnnouncementHUDParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_AnnouncementHUDParent));
        return pointer == IntPtr.Zero ? (AnnouncementHUDParent) null : new AnnouncementHUDParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_AnnouncementHUDParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProjectM.UI.ScreenCraftingParent ScreenCraftingParentPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ScreenCraftingParentPrefab));
        return pointer == IntPtr.Zero ? (ProjectM.UI.ScreenCraftingParent) null : new ProjectM.UI.ScreenCraftingParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ScreenCraftingParentPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DangerTextParent DangerTextParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DangerTextParent));
        return pointer == IntPtr.Zero ? (DangerTextParent) null : new DangerTextParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DangerTextParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeedInteractionProgress FeedInteractionProgress
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_FeedInteractionProgress));
        return pointer == IntPtr.Zero ? (FeedInteractionProgress) null : new FeedInteractionProgress(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_FeedInteractionProgress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ReviveCancelAuthoring ReviveCancel
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ReviveCancel));
        return pointer == IntPtr.Zero ? (ReviveCancelAuthoring) null : new ReviveCancelAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ReviveCancel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LinksHUDParent LinksHUDParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LinksHUDParent));
        return pointer == IntPtr.Zero ? (LinksHUDParent) null : new LinksHUDParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LinksHUDParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MiniMapHUDParent MiniMapHUDParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_MiniMapHUDParent));
        return pointer == IntPtr.Zero ? (MiniMapHUDParent) null : new MiniMapHUDParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_MiniMapHUDParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DebugView DebugStats
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugStats));
        return pointer == IntPtr.Zero ? (DebugView) null : new DebugView(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugStats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProjectM.UI.BottomBarParent BottomBarParentPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_BottomBarParentPrefab));
        return pointer == IntPtr.Zero ? (ProjectM.UI.BottomBarParent) null : new ProjectM.UI.BottomBarParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_BottomBarParentPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DragAndDropView DragAndDropParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DragAndDropParent));
        return pointer == IntPtr.Zero ? (DragAndDropView) null : new DragAndDropView(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DragAndDropParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProjectM.UI.TooltipsParent TooltipsParentPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TooltipsParentPrefab));
        return pointer == IntPtr.Zero ? (ProjectM.UI.TooltipsParent) null : new ProjectM.UI.TooltipsParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TooltipsParentPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DebugLogsView DebugLogsViewPrefabs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugLogsViewPrefabs));
        return pointer == IntPtr.Zero ? (DebugLogsView) null : new DebugLogsView(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DebugLogsViewPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDChatWindow ChatWindowPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ChatWindowPrefab));
        return pointer == IntPtr.Zero ? (HUDChatWindow) null : new HUDChatWindow(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ChatWindowPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ActionWheel ActionWheel
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ActionWheel));
        return pointer == IntPtr.Zero ? (ActionWheel) null : new ActionWheel(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ActionWheel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TargetInfoParent TargetInfoParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TargetInfoParent));
        return pointer == IntPtr.Zero ? (TargetInfoParent) null : new TargetInfoParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_TargetInfoParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EventSystem EventSystemPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_EventSystemPrefab));
        return pointer == IntPtr.Zero ? (EventSystem) null : new EventSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_EventSystemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ScreenEdgeIconEntry ScreenEdgeIconPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ScreenEdgeIconPrefab));
        return pointer == IntPtr.Zero ? (ScreenEdgeIconEntry) null : new ScreenEdgeIconEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_ScreenEdgeIconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapZoneHelperData MapZoneHelperDataPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_MapZoneHelperDataPrefab));
        return pointer == IntPtr.Zero ? (MapZoneHelperData) null : new MapZoneHelperData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_MapZoneHelperDataPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SlowConnectionIcon SlowConnectionIconPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SlowConnectionIconPrefab));
        return pointer == IntPtr.Zero ? (SlowConnectionIcon) null : new SlowConnectionIcon(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SlowConnectionIconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimplePopup DisconnectedPopupPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DisconnectedPopupPrefab));
        return pointer == IntPtr.Zero ? (SimplePopup) null : new SimplePopup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_DisconnectedPopupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_ExitGame
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LK_ExitGame));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LK_ExitGame)) = value;
      }
    }

    public unsafe LocalizationKey LK_LostConnection
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LK_LostConnection));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LK_LostConnection)) = value;
      }
    }

    public unsafe LocalizationKey LK_LeaveGame
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LK_LeaveGame));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LK_LeaveGame)) = value;
      }
    }

    public unsafe LocalizedStatusMessagesAsset LocalizedStatusMessages
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LocalizedStatusMessages));
        return pointer == IntPtr.Zero ? (LocalizedStatusMessagesAsset) null : new LocalizedStatusMessagesAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_LocalizedStatusMessages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundMapping SoundMapping
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SoundMapping));
        return pointer == IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_SoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HUDElementComponent> HUDElementComponents
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDElementComponents));
        return pointer == IntPtr.Zero ? (List<HUDElementComponent>) null : new List<HUDElementComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICanvasBase.NativeFieldInfoPtr_HUDElementComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
