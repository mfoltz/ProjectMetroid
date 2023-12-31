// Decompiled with JetBrains decompiler
// Type: ProjectM.InterfaceSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class InterfaceSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Language;
    private static readonly System.IntPtr NativeFieldInfoPtr_VideoPlayMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_StreamerMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowGlobalChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowChatTimeStamps;
    private static readonly System.IntPtr NativeFieldInfoPtr_LockMinimapRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetMapOnOpen;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildMenuFadeOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowMenuShortcuts;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChatSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_SteamRichPresenceEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToggleEquipMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowFriendsToJoinThroughSteam;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemTrackingFeature;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowPasswords;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowMiniMapPlayerPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowClanNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysShowVampireHuds;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisplayBugAnnouncementsInChat;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ActuallyShowPassword_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool ActuallyShowPassword
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 748680, RefRangeEnd = 748687, XrefRangeStart = 748680, XrefRangeEnd = 748680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InterfaceSettings.NativeMethodInfoPtr_get_ActuallyShowPassword_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748688, RefRangeEnd = 748689, XrefRangeStart = 748687, XrefRangeEnd = 748688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InterfaceSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InterfaceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InterfaceSettings()
    {
      Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InterfaceSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr);
      InterfaceSettings.NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (Language));
      InterfaceSettings.NativeFieldInfoPtr_VideoPlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (VideoPlayMode));
      InterfaceSettings.NativeFieldInfoPtr_StreamerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (StreamerMode));
      InterfaceSettings.NativeFieldInfoPtr_ShowGlobalChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ShowGlobalChat));
      InterfaceSettings.NativeFieldInfoPtr_ShowChatTimeStamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ShowChatTimeStamps));
      InterfaceSettings.NativeFieldInfoPtr_LockMinimapRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (LockMinimapRotation));
      InterfaceSettings.NativeFieldInfoPtr_ResetMapOnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ResetMapOnOpen));
      InterfaceSettings.NativeFieldInfoPtr_BuildMenuFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (BuildMenuFadeOut));
      InterfaceSettings.NativeFieldInfoPtr_ShowMenuShortcuts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ShowMenuShortcuts));
      InterfaceSettings.NativeFieldInfoPtr_ChatSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ChatSize));
      InterfaceSettings.NativeFieldInfoPtr_SteamRichPresenceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (SteamRichPresenceEnabled));
      InterfaceSettings.NativeFieldInfoPtr_ToggleEquipMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ToggleEquipMode));
      InterfaceSettings.NativeFieldInfoPtr_AllowFriendsToJoinThroughSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (AllowFriendsToJoinThroughSteam));
      InterfaceSettings.NativeFieldInfoPtr_ItemTrackingFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ItemTrackingFeature));
      InterfaceSettings.NativeFieldInfoPtr_ShowPasswords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ShowPasswords));
      InterfaceSettings.NativeFieldInfoPtr_ShowMiniMapPlayerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ShowMiniMapPlayerPath));
      InterfaceSettings.NativeFieldInfoPtr_ShowClanNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (ShowClanNames));
      InterfaceSettings.NativeFieldInfoPtr_AlwaysShowVampireHuds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (AlwaysShowVampireHuds));
      InterfaceSettings.NativeFieldInfoPtr_DisplayBugAnnouncementsInChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, nameof (DisplayBugAnnouncementsInChat));
      InterfaceSettings.NativeMethodInfoPtr_get_ActuallyShowPassword_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, 100665917);
      InterfaceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceSettings>.NativeClassPtr, 100665918);
    }

    public InterfaceSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Language
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_Language)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_Language), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe byte VideoPlayMode
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_VideoPlayMode));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_VideoPlayMode)) = value;
      }
    }

    public unsafe bool StreamerMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_StreamerMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_StreamerMode)) = value;
      }
    }

    public unsafe bool ShowGlobalChat
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowGlobalChat));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowGlobalChat)) = value;
      }
    }

    public unsafe bool ShowChatTimeStamps
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowChatTimeStamps));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowChatTimeStamps)) = value;
      }
    }

    public unsafe bool LockMinimapRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_LockMinimapRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_LockMinimapRotation)) = value;
      }
    }

    public unsafe bool ResetMapOnOpen
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ResetMapOnOpen));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ResetMapOnOpen)) = value;
      }
    }

    public unsafe bool BuildMenuFadeOut
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_BuildMenuFadeOut));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_BuildMenuFadeOut)) = value;
      }
    }

    public unsafe bool ShowMenuShortcuts
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowMenuShortcuts));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowMenuShortcuts)) = value;
      }
    }

    public unsafe float ChatSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ChatSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ChatSize)) = value;
      }
    }

    public unsafe bool SteamRichPresenceEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_SteamRichPresenceEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_SteamRichPresenceEnabled)) = value;
      }
    }

    public unsafe bool ToggleEquipMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ToggleEquipMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ToggleEquipMode)) = value;
      }
    }

    public unsafe bool AllowFriendsToJoinThroughSteam
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_AllowFriendsToJoinThroughSteam));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_AllowFriendsToJoinThroughSteam)) = value;
      }
    }

    public unsafe bool ItemTrackingFeature
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ItemTrackingFeature));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ItemTrackingFeature)) = value;
      }
    }

    public unsafe bool ShowPasswords
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowPasswords));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowPasswords)) = value;
      }
    }

    public unsafe bool ShowMiniMapPlayerPath
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowMiniMapPlayerPath));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowMiniMapPlayerPath)) = value;
      }
    }

    public unsafe bool ShowClanNames
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowClanNames));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_ShowClanNames)) = value;
      }
    }

    public unsafe bool AlwaysShowVampireHuds
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_AlwaysShowVampireHuds));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_AlwaysShowVampireHuds)) = value;
      }
    }

    public unsafe bool DisplayBugAnnouncementsInChat
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_DisplayBugAnnouncementsInChat));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InterfaceSettings.NativeFieldInfoPtr_DisplayBugAnnouncementsInChat)) = value;
      }
    }
  }
}
