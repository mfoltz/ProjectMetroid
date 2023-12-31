// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DisableUISettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public static class DisableUISettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_HUD;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_CharacterHUDs;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_Minimap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_EdgeIcons;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_Achievements;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_Clan;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_Replay;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_SCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_Logs;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_MenuLinks;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_WakeupMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_VersionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_HUDMenus;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_Cursor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID_ItemTracker;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideHUD_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideHUD_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideCharacterHUDs_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideCharacterHUDs_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideMinimap_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideMinimap_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideEdgeIcons_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideEdgeIcons_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideAchievements_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideAchievements_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideClan_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideClan_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideReplay_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideReplay_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideSCT_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideSCT_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HideLogsDefaultValue_Private_Static_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideLogs_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideLogs_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideMenuLinks_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideMenuLinks_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideWakeupMenu_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideWakeupMenu_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideVersionData_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideVersionData_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideHUDMenus_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideHUDMenus_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideCursor_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideCursor_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHideItemTracker_Public_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHideItemTracker_Public_Static_Void_Boolean_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSetting_Private_Static_Void_String_Boolean_World_SetSettingDelegate_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794877, RefRangeEnd = 794878, XrefRangeStart = 794874, XrefRangeEnd = 794877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideHUD()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideHUD_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794895, RefRangeEnd = 794896, XrefRangeStart = 794878, XrefRangeEnd = 794895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideHUD(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideHUD_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794899, RefRangeEnd = 794900, XrefRangeStart = 794896, XrefRangeEnd = 794899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideCharacterHUDs()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideCharacterHUDs_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794917, RefRangeEnd = 794918, XrefRangeStart = 794900, XrefRangeEnd = 794917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideCharacterHUDs(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideCharacterHUDs_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794921, RefRangeEnd = 794922, XrefRangeStart = 794918, XrefRangeEnd = 794921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideMinimap()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideMinimap_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794939, RefRangeEnd = 794940, XrefRangeStart = 794922, XrefRangeEnd = 794939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideMinimap(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideMinimap_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794943, RefRangeEnd = 794944, XrefRangeStart = 794940, XrefRangeEnd = 794943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideEdgeIcons()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideEdgeIcons_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794961, RefRangeEnd = 794962, XrefRangeStart = 794944, XrefRangeEnd = 794961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideEdgeIcons(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideEdgeIcons_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794965, RefRangeEnd = 794966, XrefRangeStart = 794962, XrefRangeEnd = 794965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideAchievements()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideAchievements_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794983, RefRangeEnd = 794984, XrefRangeStart = 794966, XrefRangeEnd = 794983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideAchievements(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideAchievements_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794987, RefRangeEnd = 794988, XrefRangeStart = 794984, XrefRangeEnd = 794987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideClan()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideClan_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795005, RefRangeEnd = 795006, XrefRangeStart = 794988, XrefRangeEnd = 795005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideClan(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideClan_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795009, RefRangeEnd = 795010, XrefRangeStart = 795006, XrefRangeEnd = 795009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideReplay()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideReplay_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795027, RefRangeEnd = 795028, XrefRangeStart = 795010, XrefRangeEnd = 795027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideReplay(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideReplay_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795031, RefRangeEnd = 795032, XrefRangeStart = 795028, XrefRangeEnd = 795031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideSCT()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideSCT_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795049, RefRangeEnd = 795050, XrefRangeStart = 795032, XrefRangeEnd = 795049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideSCT(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideSCT_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public static unsafe int HideLogsDefaultValue
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795050, XrefRangeEnd = 795051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_get_HideLogsDefaultValue_Private_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795055, RefRangeEnd = 795056, XrefRangeStart = 795051, XrefRangeEnd = 795055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideLogs()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideLogs_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795073, RefRangeEnd = 795074, XrefRangeStart = 795056, XrefRangeEnd = 795073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideLogs(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideLogs_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795077, RefRangeEnd = 795078, XrefRangeStart = 795074, XrefRangeEnd = 795077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideMenuLinks()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideMenuLinks_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795095, RefRangeEnd = 795096, XrefRangeStart = 795078, XrefRangeEnd = 795095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideMenuLinks(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideMenuLinks_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 795099, RefRangeEnd = 795101, XrefRangeStart = 795096, XrefRangeEnd = 795099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideWakeupMenu()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideWakeupMenu_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795118, RefRangeEnd = 795119, XrefRangeStart = 795101, XrefRangeEnd = 795118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideWakeupMenu(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideWakeupMenu_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795122, RefRangeEnd = 795123, XrefRangeStart = 795119, XrefRangeEnd = 795122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideVersionData()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideVersionData_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795140, RefRangeEnd = 795141, XrefRangeStart = 795123, XrefRangeEnd = 795140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideVersionData(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideVersionData_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795144, RefRangeEnd = 795145, XrefRangeStart = 795141, XrefRangeEnd = 795144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideHUDMenus()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideHUDMenus_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795162, RefRangeEnd = 795163, XrefRangeStart = 795145, XrefRangeEnd = 795162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideHUDMenus(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideHUDMenus_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795163, XrefRangeEnd = 795166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideCursor()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideCursor_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795183, RefRangeEnd = 795184, XrefRangeStart = 795166, XrefRangeEnd = 795183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideCursor(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideCursor_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795184, XrefRangeEnd = 795187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetHideItemTracker()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_GetHideItemTracker_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795187, XrefRangeEnd = 795204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetHideItemTracker(bool newValue, World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetHideItemTracker_Public_Static_Void_Boolean_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 795230, RefRangeEnd = 795245, XrefRangeStart = 795204, XrefRangeEnd = 795230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetSetting(
      string disableConfigString,
      bool newValue,
      World clientWorld,
      DisableUISettings.SetSettingDelegate setSetting)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(disableConfigString);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) setSetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DisableUISettings.NativeMethodInfoPtr_SetSetting_Private_Static_Void_String_Boolean_World_SetSettingDelegate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DisableUISettings()
    {
      Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (DisableUISettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr);
      DisableUISettings.NativeFieldInfoPtr_ID_HUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_HUD));
      DisableUISettings.NativeFieldInfoPtr_ID_CharacterHUDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_CharacterHUDs));
      DisableUISettings.NativeFieldInfoPtr_ID_Minimap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_Minimap));
      DisableUISettings.NativeFieldInfoPtr_ID_EdgeIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_EdgeIcons));
      DisableUISettings.NativeFieldInfoPtr_ID_Achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_Achievements));
      DisableUISettings.NativeFieldInfoPtr_ID_Clan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_Clan));
      DisableUISettings.NativeFieldInfoPtr_ID_Replay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_Replay));
      DisableUISettings.NativeFieldInfoPtr_ID_SCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_SCT));
      DisableUISettings.NativeFieldInfoPtr_ID_Logs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_Logs));
      DisableUISettings.NativeFieldInfoPtr_ID_MenuLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_MenuLinks));
      DisableUISettings.NativeFieldInfoPtr_ID_WakeupMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_WakeupMenu));
      DisableUISettings.NativeFieldInfoPtr_ID_VersionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_VersionData));
      DisableUISettings.NativeFieldInfoPtr_ID_HUDMenus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_HUDMenus));
      DisableUISettings.NativeFieldInfoPtr_ID_Cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_Cursor));
      DisableUISettings.NativeFieldInfoPtr_ID_ItemTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (ID_ItemTracker));
      DisableUISettings.NativeMethodInfoPtr_GetHideHUD_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670089);
      DisableUISettings.NativeMethodInfoPtr_SetHideHUD_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670090);
      DisableUISettings.NativeMethodInfoPtr_GetHideCharacterHUDs_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670091);
      DisableUISettings.NativeMethodInfoPtr_SetHideCharacterHUDs_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670092);
      DisableUISettings.NativeMethodInfoPtr_GetHideMinimap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670093);
      DisableUISettings.NativeMethodInfoPtr_SetHideMinimap_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670094);
      DisableUISettings.NativeMethodInfoPtr_GetHideEdgeIcons_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670095);
      DisableUISettings.NativeMethodInfoPtr_SetHideEdgeIcons_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670096);
      DisableUISettings.NativeMethodInfoPtr_GetHideAchievements_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670097);
      DisableUISettings.NativeMethodInfoPtr_SetHideAchievements_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670098);
      DisableUISettings.NativeMethodInfoPtr_GetHideClan_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670099);
      DisableUISettings.NativeMethodInfoPtr_SetHideClan_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670100);
      DisableUISettings.NativeMethodInfoPtr_GetHideReplay_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670101);
      DisableUISettings.NativeMethodInfoPtr_SetHideReplay_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670102);
      DisableUISettings.NativeMethodInfoPtr_GetHideSCT_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670103);
      DisableUISettings.NativeMethodInfoPtr_SetHideSCT_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670104);
      DisableUISettings.NativeMethodInfoPtr_get_HideLogsDefaultValue_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670105);
      DisableUISettings.NativeMethodInfoPtr_GetHideLogs_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670106);
      DisableUISettings.NativeMethodInfoPtr_SetHideLogs_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670107);
      DisableUISettings.NativeMethodInfoPtr_GetHideMenuLinks_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670108);
      DisableUISettings.NativeMethodInfoPtr_SetHideMenuLinks_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670109);
      DisableUISettings.NativeMethodInfoPtr_GetHideWakeupMenu_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670110);
      DisableUISettings.NativeMethodInfoPtr_SetHideWakeupMenu_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670111);
      DisableUISettings.NativeMethodInfoPtr_GetHideVersionData_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670112);
      DisableUISettings.NativeMethodInfoPtr_SetHideVersionData_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670113);
      DisableUISettings.NativeMethodInfoPtr_GetHideHUDMenus_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670114);
      DisableUISettings.NativeMethodInfoPtr_SetHideHUDMenus_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670115);
      DisableUISettings.NativeMethodInfoPtr_GetHideCursor_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670116);
      DisableUISettings.NativeMethodInfoPtr_SetHideCursor_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670117);
      DisableUISettings.NativeMethodInfoPtr_GetHideItemTracker_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670118);
      DisableUISettings.NativeMethodInfoPtr_SetHideItemTracker_Public_Static_Void_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670119);
      DisableUISettings.NativeMethodInfoPtr_SetSetting_Private_Static_Void_String_Boolean_World_SetSettingDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, 100670120);
    }

    public DisableUISettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string ID_HUD
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_HUD, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_HUD, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_CharacterHUDs
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_CharacterHUDs, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_CharacterHUDs, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_Minimap
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_Minimap, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_Minimap, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_EdgeIcons
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_EdgeIcons, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_EdgeIcons, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_Achievements
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_Achievements, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_Achievements, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_Clan
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_Clan, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_Clan, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_Replay
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_Replay, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_Replay, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_SCT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_SCT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_SCT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_Logs
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_Logs, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_Logs, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_MenuLinks
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_MenuLinks, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_MenuLinks, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_WakeupMenu
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_WakeupMenu, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_WakeupMenu, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_VersionData
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_VersionData, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_VersionData, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_HUDMenus
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_HUDMenus, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_HUDMenus, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_Cursor
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_Cursor, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_Cursor, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ID_ItemTracker
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(DisableUISettings.NativeFieldInfoPtr_ID_ItemTracker, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DisableUISettings.NativeFieldInfoPtr_ID_ItemTracker, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public sealed class SetSettingDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_byref_DisableUISettingsSingleton_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_DisableUISettingsSingleton_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SetSettingDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableUISettings.SetSettingDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.SetSettingDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 794866, RefRangeEnd = 794867, XrefRangeStart = 794848, XrefRangeEnd = 794866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(bool valueToSet, ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.SetSettingDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794867, XrefRangeEnd = 794874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        bool valueToSet,
        ref DisableUISettingsSingleton settings,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettings.SetSettingDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_byref_DisableUISettingsSingleton_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref DisableUISettingsSingleton settings,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.SetSettingDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_DisableUISettingsSingleton_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SetSettingDelegate()
      {
        Il2CppClassPointerStore<DisableUISettings.SetSettingDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, nameof (SetSettingDelegate));
        DisableUISettings.SetSettingDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.SetSettingDelegate>.NativeClassPtr, 100670121);
        DisableUISettings.SetSettingDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.SetSettingDelegate>.NativeClassPtr, 100670122);
        DisableUISettings.SetSettingDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_byref_DisableUISettingsSingleton_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.SetSettingDelegate>.NativeClassPtr, 100670123);
        DisableUISettings.SetSettingDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_DisableUISettingsSingleton_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.SetSettingDelegate>.NativeClassPtr, 100670124);
      }

      public SetSettingDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("ProjectM.UI.DisableUISettings/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__20_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__28_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__31_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__34_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__37_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__40_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__43_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__46_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideHUD_b__2_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideCharacterHUDs_b__5_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideMinimap_b__8_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideEdgeIcons_b__11_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideAchievements_b__14_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideClan_b__17_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideReplay_b__20_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideSCT_b__23_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideLogs_b__28_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideMenuLinks_b__31_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideWakeupMenu_b__34_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideVersionData_b__37_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideHUDMenus_b__40_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideCursor_b__43_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetHideItemTracker_b__46_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideHUD_b__2_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideHUD_b__2_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideCharacterHUDs_b__5_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideCharacterHUDs_b__5_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideMinimap_b__8_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideMinimap_b__8_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideEdgeIcons_b__11_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideEdgeIcons_b__11_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideAchievements_b__14_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideAchievements_b__14_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideClan_b__17_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideClan_b__17_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideReplay_b__20_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideReplay_b__20_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideSCT_b__23_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideSCT_b__23_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideLogs_b__28_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideLogs_b__28_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideMenuLinks_b__31_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideMenuLinks_b__31_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideWakeupMenu_b__34_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideWakeupMenu_b__34_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideVersionData_b__37_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideVersionData_b__37_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideHUDMenus_b__40_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideHUDMenus_b__40_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideCursor_b__43_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideCursor_b__43_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _SetHideItemTracker_b__46_0(
        bool valueToSet,
        ref DisableUISettingsSingleton settings)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &valueToSet;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref settings;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DisableUISettings.__c.NativeMethodInfoPtr__SetHideItemTracker_b__46_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableUISettings>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr);
        DisableUISettings.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9");
        DisableUISettings.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__2_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__5_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__8_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__11_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__14_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__17_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__20_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__23_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__28_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__31_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__34_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__37_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__40_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__43_0");
        DisableUISettings.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, "<>9__46_0");
        DisableUISettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670126);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideHUD_b__2_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670127);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideCharacterHUDs_b__5_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670128);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideMinimap_b__8_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670129);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideEdgeIcons_b__11_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670130);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideAchievements_b__14_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670131);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideClan_b__17_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670132);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideReplay_b__20_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670133);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideSCT_b__23_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670134);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideLogs_b__28_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670135);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideMenuLinks_b__31_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670136);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideWakeupMenu_b__34_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670137);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideVersionData_b__37_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670138);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideHUDMenus_b__40_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670139);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideCursor_b__43_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670140);
        DisableUISettings.__c.NativeMethodInfoPtr__SetHideItemTracker_b__46_0_Internal_Void_Boolean_byref_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettings.__c>.NativeClassPtr, 100670141);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe DisableUISettings.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.__c) null : new DisableUISettings.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__8_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__11_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__14_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__14_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__14_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__17_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__17_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__17_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__20_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__20_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__20_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__23_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__23_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__23_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__28_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__28_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__28_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__31_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__31_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__31_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__34_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__34_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__34_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__37_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__37_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__37_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__40_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__40_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__40_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__43_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__43_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__43_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe DisableUISettings.SetSettingDelegate __9__46_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DisableUISettings.__c.NativeFieldInfoPtr___9__46_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DisableUISettings.SetSettingDelegate) null : new DisableUISettings.SetSettingDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DisableUISettings.__c.NativeFieldInfoPtr___9__46_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
