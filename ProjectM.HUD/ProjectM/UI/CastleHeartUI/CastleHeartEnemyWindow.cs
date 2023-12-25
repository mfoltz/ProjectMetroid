// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartUI.CastleHeartEnemyWindow
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
  public class CastleHeartEnemyWindow : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CastleLevelValue;
    private static readonly IntPtr NativeFieldInfoPtr_EnemyInfo;
    private static readonly IntPtr NativeFieldInfoPtr_ExposedGroup;
    private static readonly IntPtr NativeFieldInfoPtr_ClaimPanel;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyPanel;
    private static readonly IntPtr NativeFieldInfoPtr_RaidPanel;
    private static readonly IntPtr NativeFieldInfoPtr_PvpTimePanel;
    private static readonly IntPtr NativeFieldInfoPtr_ServerSettingsDesc;
    private static readonly IntPtr NativeFieldInfoPtr_ServerSettingNoPvp;
    private static readonly IntPtr NativeFieldInfoPtr_ServerSettingPvpHours;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartEnemyWindow()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartEnemyWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartEnemyWindow()
    {
      Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI.CastleHeartUI", nameof (CastleHeartEnemyWindow));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr);
      CastleHeartEnemyWindow.NativeFieldInfoPtr_CastleLevelValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (CastleLevelValue));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_EnemyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (EnemyInfo));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_ExposedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (ExposedGroup));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_ClaimPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (ClaimPanel));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_DestroyPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (DestroyPanel));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_RaidPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (RaidPanel));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_PvpTimePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (PvpTimePanel));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingsDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (ServerSettingsDesc));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingNoPvp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (ServerSettingNoPvp));
      CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingPvpHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, nameof (ServerSettingPvpHours));
      CastleHeartEnemyWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartEnemyWindow>.NativeClassPtr, 100669837);
    }

    public CastleHeartEnemyWindow(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText CastleLevelValue
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_CastleLevelValue));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_CastleLevelValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform EnemyInfo
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_EnemyInfo));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_EnemyInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleHeartExposedGroup ExposedGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ExposedGroup));
        return pointer == IntPtr.Zero ? (CastleHeartExposedGroup) null : new CastleHeartExposedGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ExposedGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleHeartClaimPanel ClaimPanel
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ClaimPanel));
        return pointer == IntPtr.Zero ? (CastleHeartClaimPanel) null : new CastleHeartClaimPanel(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ClaimPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleHeartDestroyPanel DestroyPanel
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_DestroyPanel));
        return pointer == IntPtr.Zero ? (CastleHeartDestroyPanel) null : new CastleHeartDestroyPanel(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_DestroyPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleHeartRaidPanel RaidPanel
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_RaidPanel));
        return pointer == IntPtr.Zero ? (CastleHeartRaidPanel) null : new CastleHeartRaidPanel(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_RaidPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleHeartPvpTimePanel PvpTimePanel
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_PvpTimePanel));
        return pointer == IntPtr.Zero ? (CastleHeartPvpTimePanel) null : new CastleHeartPvpTimePanel(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_PvpTimePanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ServerSettingsDesc
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingsDesc));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingsDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey ServerSettingNoPvp
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingNoPvp));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingNoPvp)) = value;
      }
    }

    public unsafe LocalizationKey ServerSettingPvpHours
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingPvpHours));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartEnemyWindow.NativeFieldInfoPtr_ServerSettingPvpHours)) = value;
      }
    }
  }
}
