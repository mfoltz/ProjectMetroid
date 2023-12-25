// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartUI.CastleHeartPvpTimePanel
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI.CastleHeartUI
{
  public class CastleHeartPvpTimePanel : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_WeekdayText;
    private static readonly IntPtr NativeFieldInfoPtr_WeekendText;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartPvpTimePanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartPvpTimePanel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartPvpTimePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartPvpTimePanel()
    {
      Il2CppClassPointerStore<CastleHeartPvpTimePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI.CastleHeartUI", nameof (CastleHeartPvpTimePanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartPvpTimePanel>.NativeClassPtr);
      CastleHeartPvpTimePanel.NativeFieldInfoPtr_WeekdayText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartPvpTimePanel>.NativeClassPtr, nameof (WeekdayText));
      CastleHeartPvpTimePanel.NativeFieldInfoPtr_WeekendText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartPvpTimePanel>.NativeClassPtr, nameof (WeekendText));
      CastleHeartPvpTimePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartPvpTimePanel>.NativeClassPtr, 100669840);
    }

    public CastleHeartPvpTimePanel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText WeekdayText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartPvpTimePanel.NativeFieldInfoPtr_WeekdayText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartPvpTimePanel.NativeFieldInfoPtr_WeekdayText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText WeekendText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartPvpTimePanel.NativeFieldInfoPtr_WeekendText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartPvpTimePanel.NativeFieldInfoPtr_WeekendText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
