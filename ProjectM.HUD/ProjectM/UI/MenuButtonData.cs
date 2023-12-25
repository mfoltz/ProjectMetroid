// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MenuButtonData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class MenuButtonData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Interactable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceHilight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnClick;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279185, XrefRangeEnd = 1279186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MenuButtonData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButtonData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MenuButtonData()
    {
      Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MenuButtonData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr);
      MenuButtonData.NativeFieldInfoPtr_EntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, nameof (EntryType));
      MenuButtonData.NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, nameof (Disabled));
      MenuButtonData.NativeFieldInfoPtr_Interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, nameof (Interactable));
      MenuButtonData.NativeFieldInfoPtr_ForceHilight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, nameof (ForceHilight));
      MenuButtonData.NativeFieldInfoPtr_Requirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, nameof (Requirement));
      MenuButtonData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, nameof (Settings));
      MenuButtonData.NativeFieldInfoPtr_LocalizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, nameof (LocalizationKey));
      MenuButtonData.NativeFieldInfoPtr_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, nameof (OnClick));
      MenuButtonData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButtonData>.NativeClassPtr, 100668885);
    }

    public MenuButtonData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MenuEntryType EntryType
    {
      get
      {
        return *(MenuEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_EntryType));
      }
      [param: In] set
      {
        *(MenuEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_EntryType)) = value;
      }
    }

    public unsafe bool Disabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_Disabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_Disabled)) = value;
      }
    }

    public unsafe bool Interactable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_Interactable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_Interactable)) = value;
      }
    }

    public unsafe bool ForceHilight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_ForceHilight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_ForceHilight)) = value;
      }
    }

    public unsafe MenuEntryRequirement Requirement
    {
      get
      {
        return *(MenuEntryRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_Requirement));
      }
      [param: In] set
      {
        *(MenuEntryRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_Requirement)) = value;
      }
    }

    public unsafe MenuButtonSettings Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_Settings));
        return pointer == System.IntPtr.Zero ? (MenuButtonSettings) null : new MenuButtonSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LocalizationKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_LocalizationKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_LocalizationKey)) = value;
      }
    }

    public unsafe SimpleStunButton.ButtonClickedEvent OnClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_OnClick));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton.ButtonClickedEvent) null : new SimpleStunButton.ButtonClickedEvent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonData.NativeFieldInfoPtr_OnClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
