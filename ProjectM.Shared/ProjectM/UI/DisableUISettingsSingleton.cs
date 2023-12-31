// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DisableUISettingsSingleton
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DisableUISettingsSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUD;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideCharacterHUDs;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideMinimap;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideEdgeIcons;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideAchievements;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideClan;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideReplay;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideSCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideLogs;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideMenuLinks;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideWakeupMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideVersionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUDMenus;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideCursor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideItemTracker;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFromPlayerSettings_Public_Static_DisableUISettingsSingleton_0;
    [FieldOffset(0)]
    public bool HideHUD;
    [FieldOffset(1)]
    public bool HideCharacterHUDs;
    [FieldOffset(2)]
    public bool HideMinimap;
    [FieldOffset(3)]
    public bool HideEdgeIcons;
    [FieldOffset(4)]
    public bool HideAchievements;
    [FieldOffset(5)]
    public bool HideClan;
    [FieldOffset(6)]
    public bool HideReplay;
    [FieldOffset(7)]
    public bool HideSCT;
    [FieldOffset(8)]
    public bool HideLogs;
    [FieldOffset(9)]
    public bool HideMenuLinks;
    [FieldOffset(10)]
    public bool HideWakeupMenu;
    [FieldOffset(11)]
    public bool HideVersionData;
    [FieldOffset(12)]
    public bool HideHUDMenus;
    [FieldOffset(13)]
    public bool HideCursor;
    [FieldOffset(14)]
    public bool HideItemTracker;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 795291, RefRangeEnd = 795294, XrefRangeStart = 795245, XrefRangeEnd = 795291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DisableUISettingsSingleton CreateFromPlayerSettings()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DisableUISettingsSingleton.NativeMethodInfoPtr_CreateFromPlayerSettings_Public_Static_DisableUISettingsSingleton_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DisableUISettingsSingleton*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DisableUISettingsSingleton()
    {
      Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (DisableUISettingsSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr);
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideHUD));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideCharacterHUDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideCharacterHUDs));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideMinimap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideMinimap));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideEdgeIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideEdgeIcons));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideAchievements));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideClan));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideReplay));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideSCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideSCT));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideLogs));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideMenuLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideMenuLinks));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideWakeupMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideWakeupMenu));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideVersionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideVersionData));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideHUDMenus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideHUDMenus));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideCursor));
      DisableUISettingsSingleton.NativeFieldInfoPtr_HideItemTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, nameof (HideItemTracker));
      DisableUISettingsSingleton.NativeMethodInfoPtr_CreateFromPlayerSettings_Public_Static_DisableUISettingsSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, 100670142);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableUISettingsSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
