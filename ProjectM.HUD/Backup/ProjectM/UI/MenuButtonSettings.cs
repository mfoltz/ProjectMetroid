// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MenuButtonSettings
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class MenuButtonSettings : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ButtonHeight;
    private static readonly IntPtr NativeFieldInfoPtr_TextSize;
    private static readonly IntPtr NativeFieldInfoPtr_FontStandard;
    private static readonly IntPtr NativeFieldInfoPtr_FontHover;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279184, XrefRangeEnd = 1279185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MenuButtonSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuButtonSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButtonSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MenuButtonSettings()
    {
      Il2CppClassPointerStore<MenuButtonSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MenuButtonSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuButtonSettings>.NativeClassPtr);
      MenuButtonSettings.NativeFieldInfoPtr_ButtonHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonSettings>.NativeClassPtr, nameof (ButtonHeight));
      MenuButtonSettings.NativeFieldInfoPtr_TextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonSettings>.NativeClassPtr, nameof (TextSize));
      MenuButtonSettings.NativeFieldInfoPtr_FontStandard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonSettings>.NativeClassPtr, nameof (FontStandard));
      MenuButtonSettings.NativeFieldInfoPtr_FontHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButtonSettings>.NativeClassPtr, nameof (FontHover));
      MenuButtonSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButtonSettings>.NativeClassPtr, 100668884);
    }

    public MenuButtonSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float ButtonHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonSettings.NativeFieldInfoPtr_ButtonHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonSettings.NativeFieldInfoPtr_ButtonHeight)) = value;
      }
    }

    public unsafe float TextSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonSettings.NativeFieldInfoPtr_TextSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonSettings.NativeFieldInfoPtr_TextSize)) = value;
      }
    }

    public unsafe TMP_FontAsset FontStandard
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonSettings.NativeFieldInfoPtr_FontStandard));
        return pointer == IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonSettings.NativeFieldInfoPtr_FontStandard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset FontHover
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonSettings.NativeFieldInfoPtr_FontHover));
        return pointer == IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButtonSettings.NativeFieldInfoPtr_FontHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
