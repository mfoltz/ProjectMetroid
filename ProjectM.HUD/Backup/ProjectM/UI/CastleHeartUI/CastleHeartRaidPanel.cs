// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartUI.CastleHeartRaidPanel
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI.CastleHeartUI
{
  public class CastleHeartRaidPanel : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RaidButton;
    private static readonly IntPtr NativeFieldInfoPtr_RaidInfoGroup;
    private static readonly IntPtr NativeFieldInfoPtr_RaidTimerGroup;
    private static readonly IntPtr NativeFieldInfoPtr_RaidProtectionTimerGroup;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly IntPtr NativeFieldInfoPtr_RaidCostLayout;
    private static readonly IntPtr NativeFieldInfoPtr_RaidTimer;
    private static readonly IntPtr NativeFieldInfoPtr_RaidCooldownTimer;
    private static readonly IntPtr NativeFieldInfoPtr_RaidCost;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartRaidPanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartRaidPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartRaidPanel()
    {
      Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI.CastleHeartUI", nameof (CastleHeartRaidPanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr);
      CastleHeartRaidPanel.NativeFieldInfoPtr_RaidButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (RaidButton));
      CastleHeartRaidPanel.NativeFieldInfoPtr_RaidInfoGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (RaidInfoGroup));
      CastleHeartRaidPanel.NativeFieldInfoPtr_RaidTimerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (RaidTimerGroup));
      CastleHeartRaidPanel.NativeFieldInfoPtr_RaidProtectionTimerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (RaidProtectionTimerGroup));
      CastleHeartRaidPanel.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (TooltipAnchor));
      CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCostLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (RaidCostLayout));
      CastleHeartRaidPanel.NativeFieldInfoPtr_RaidTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (RaidTimer));
      CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCooldownTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (RaidCooldownTimer));
      CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, nameof (RaidCost));
      CastleHeartRaidPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartRaidPanel>.NativeClassPtr, 100669841);
    }

    public CastleHeartRaidPanel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton RaidButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RaidInfoGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidInfoGroup));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidInfoGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RaidTimerGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidTimerGroup));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidTimerGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RaidProtectionTimerGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidProtectionTimerGroup));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidProtectionTimerGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RaidCostLayout
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCostLayout));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCostLayout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText RaidTimer
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidTimer));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText RaidCooldownTimer
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCooldownTimer));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCooldownTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CastleHeartShortMenuEntry> RaidCost
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCost));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CastleHeartShortMenuEntry>) null : new Il2CppReferenceArray<CastleHeartShortMenuEntry>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartRaidPanel.NativeFieldInfoPtr_RaidCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
