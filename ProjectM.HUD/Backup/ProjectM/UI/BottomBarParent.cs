// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BottomBarParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class BottomBarParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly IntPtr NativeFieldInfoPtr_AbilityTooltip;
    private static readonly IntPtr NativeFieldInfoPtr_BloodOrb;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipPosition;
    private static readonly IntPtr NativeFieldInfoPtr_AbilityBar;
    private static readonly IntPtr NativeFieldInfoPtr_ActionBar;
    private static readonly IntPtr NativeFieldInfoPtr_Text_CurrentHealth;
    private static readonly IntPtr NativeFieldInfoPtr_BiteParent;
    private static readonly IntPtr NativeFieldInfoPtr_BuffBarParent;
    private static readonly IntPtr NativeFieldInfoPtr_Healthbar;
    private static readonly IntPtr NativeFieldInfoPtr_InventorySlotsInverted;
    private static readonly IntPtr NativeFieldInfoPtr_InventorySlotsFillImage;
    private static readonly IntPtr NativeFieldInfoPtr_InventorySlotsText;
    private static readonly IntPtr NativeFieldInfoPtr_EmptyAbilityEntryTooltipDataList;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BottomBarParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BottomBarParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BottomBarParent()
    {
      Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BottomBarParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr);
      BottomBarParent.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (FakeTooltip));
      BottomBarParent.NativeFieldInfoPtr_AbilityTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (AbilityTooltip));
      BottomBarParent.NativeFieldInfoPtr_BloodOrb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (BloodOrb));
      BottomBarParent.NativeFieldInfoPtr_TooltipPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (TooltipPosition));
      BottomBarParent.NativeFieldInfoPtr_AbilityBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (AbilityBar));
      BottomBarParent.NativeFieldInfoPtr_ActionBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (ActionBar));
      BottomBarParent.NativeFieldInfoPtr_Text_CurrentHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (Text_CurrentHealth));
      BottomBarParent.NativeFieldInfoPtr_BiteParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (BiteParent));
      BottomBarParent.NativeFieldInfoPtr_BuffBarParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (BuffBarParent));
      BottomBarParent.NativeFieldInfoPtr_Healthbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (Healthbar));
      BottomBarParent.NativeFieldInfoPtr_InventorySlotsInverted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (InventorySlotsInverted));
      BottomBarParent.NativeFieldInfoPtr_InventorySlotsFillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (InventorySlotsFillImage));
      BottomBarParent.NativeFieldInfoPtr_InventorySlotsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (InventorySlotsText));
      BottomBarParent.NativeFieldInfoPtr_EmptyAbilityEntryTooltipDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, nameof (EmptyAbilityEntryTooltipDataList));
      BottomBarParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BottomBarParent>.NativeClassPtr, 100663882);
    }

    public BottomBarParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_FakeTooltip));
        return pointer == IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityTooltip AbilityTooltip
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_AbilityTooltip));
        return pointer == IntPtr.Zero ? (AbilityTooltip) null : new AbilityTooltip(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_AbilityTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BloodOrbComponent BloodOrb
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_BloodOrb));
        return pointer == IntPtr.Zero ? (BloodOrbComponent) null : new BloodOrbComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_BloodOrb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipPosition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_TooltipPosition));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_TooltipPosition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AbilityBarParent AbilityBar
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_AbilityBar));
        return pointer == IntPtr.Zero ? (AbilityBarParent) null : new AbilityBarParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_AbilityBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ActionBarParent ActionBar
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_ActionBar));
        return pointer == IntPtr.Zero ? (ActionBarParent) null : new ActionBarParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_ActionBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_CurrentHealth
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_Text_CurrentHealth));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_Text_CurrentHealth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BiteParent BiteParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_BiteParent));
        return pointer == IntPtr.Zero ? (BiteParent) null : new BiteParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_BiteParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuffBarParent BuffBarParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_BuffBarParent));
        return pointer == IntPtr.Zero ? (BuffBarParent) null : new BuffBarParent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_BuffBarParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHUD_HealthComponent Healthbar
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_Healthbar));
        return pointer == IntPtr.Zero ? (CharacterHUD_HealthComponent) null : new CharacterHUD_HealthComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_Healthbar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool InventorySlotsInverted
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_InventorySlotsInverted));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_InventorySlotsInverted)) = value;
      }
    }

    public unsafe Image InventorySlotsFillImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_InventorySlotsFillImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_InventorySlotsFillImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText InventorySlotsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_InventorySlotsText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_InventorySlotsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<EmptyAbilityEntryTooltipData> EmptyAbilityEntryTooltipDataList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_EmptyAbilityEntryTooltipDataList));
        return pointer == IntPtr.Zero ? (List<EmptyAbilityEntryTooltipData>) null : new List<EmptyAbilityEntryTooltipData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BottomBarParent.NativeFieldInfoPtr_EmptyAbilityEntryTooltipDataList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
