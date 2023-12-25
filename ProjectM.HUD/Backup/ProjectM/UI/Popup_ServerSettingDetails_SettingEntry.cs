// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Popup_ServerSettingDetails_SettingEntry
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

#nullable disable
namespace ProjectM.UI
{
  public class Popup_ServerSettingDetails_SettingEntry : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HeaderEntry;
    private static readonly IntPtr NativeFieldInfoPtr_ValueEntry;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipHover;
    private static readonly IntPtr NativeMethodInfoPtr_SetTooltip_Public_Void_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286822, XrefRangeEnd = 1286825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTooltip(LocalizationKey mappingTooltip)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &mappingTooltip;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails_SettingEntry.NativeMethodInfoPtr_SetTooltip_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Popup_ServerSettingDetails_SettingEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Popup_ServerSettingDetails_SettingEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails_SettingEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Popup_ServerSettingDetails_SettingEntry()
    {
      Il2CppClassPointerStore<Popup_ServerSettingDetails_SettingEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (Popup_ServerSettingDetails_SettingEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Popup_ServerSettingDetails_SettingEntry>.NativeClassPtr);
      Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_HeaderEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails_SettingEntry>.NativeClassPtr, nameof (HeaderEntry));
      Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_ValueEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails_SettingEntry>.NativeClassPtr, nameof (ValueEntry));
      Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_TooltipHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails_SettingEntry>.NativeClassPtr, nameof (TooltipHover));
      Popup_ServerSettingDetails_SettingEntry.NativeMethodInfoPtr_SetTooltip_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails_SettingEntry>.NativeClassPtr, 100669483);
      Popup_ServerSettingDetails_SettingEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails_SettingEntry>.NativeClassPtr, 100669484);
    }

    public Popup_ServerSettingDetails_SettingEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText HeaderEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_HeaderEntry));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_HeaderEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ValueEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_ValueEntry));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_ValueEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton TooltipHover
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_TooltipHover));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails_SettingEntry.NativeFieldInfoPtr_TooltipHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
