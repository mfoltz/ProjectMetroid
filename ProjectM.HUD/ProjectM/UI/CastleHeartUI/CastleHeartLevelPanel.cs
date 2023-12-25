// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartUI.CastleHeartLevelPanel
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
using UnityEngine;

#nullable disable
namespace ProjectM.UI.CastleHeartUI
{
  public class CastleHeartLevelPanel : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CastleLevelValue;
    private static readonly IntPtr NativeFieldInfoPtr_ServantLimit;
    private static readonly IntPtr NativeFieldInfoPtr_FloorLimit;
    private static readonly IntPtr NativeFieldInfoPtr_UpgradeButton;
    private static readonly IntPtr NativeFieldInfoPtr_AbandonButton;
    private static readonly IntPtr NativeFieldInfoPtr_ExposeButton;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AbandonName;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AbandonDesc;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ExposeName;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_ExposeDesc;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartLevelPanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartLevelPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartLevelPanel()
    {
      Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI.CastleHeartUI", nameof (CastleHeartLevelPanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr);
      CastleHeartLevelPanel.NativeFieldInfoPtr_CastleLevelValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (CastleLevelValue));
      CastleHeartLevelPanel.NativeFieldInfoPtr_ServantLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (ServantLimit));
      CastleHeartLevelPanel.NativeFieldInfoPtr_FloorLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (FloorLimit));
      CastleHeartLevelPanel.NativeFieldInfoPtr_UpgradeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (UpgradeButton));
      CastleHeartLevelPanel.NativeFieldInfoPtr_AbandonButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (AbandonButton));
      CastleHeartLevelPanel.NativeFieldInfoPtr_ExposeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (ExposeButton));
      CastleHeartLevelPanel.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (TooltipAnchor));
      CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_AbandonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (LKey_AbandonName));
      CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_AbandonDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (LKey_AbandonDesc));
      CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_ExposeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (LKey_ExposeName));
      CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_ExposeDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, nameof (LKey_ExposeDesc));
      CastleHeartLevelPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartLevelPanel>.NativeClassPtr, 100669839);
    }

    public CastleHeartLevelPanel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText CastleLevelValue
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_CastleLevelValue));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_CastleLevelValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ServantLimit
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_ServantLimit));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_ServantLimit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText FloorLimit
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_FloorLimit));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_FloorLimit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleHeartUpgradeButton UpgradeButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_UpgradeButton));
        return pointer == IntPtr.Zero ? (CastleHeartUpgradeButton) null : new CastleHeartUpgradeButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_UpgradeButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AbandonButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_AbandonButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_AbandonButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ExposeButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_ExposeButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_ExposeButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_AbandonName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_AbandonName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_AbandonName)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AbandonDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_AbandonDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_AbandonDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ExposeName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_ExposeName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_ExposeName)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ExposeDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_ExposeDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartLevelPanel.NativeFieldInfoPtr_LKey_ExposeDesc)) = value;
      }
    }
  }
}
