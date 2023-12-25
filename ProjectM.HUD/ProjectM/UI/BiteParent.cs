// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BiteParent
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
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class BiteParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Tooltip;
    private static readonly IntPtr NativeFieldInfoPtr_MotionInOut;
    private static readonly IntPtr NativeFieldInfoPtr_Feed;
    private static readonly IntPtr NativeFieldInfoPtr_Bite_Active;
    private static readonly IntPtr NativeFieldInfoPtr_Bite_Inactive;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeFieldInfoPtr_CooldownText;
    private static readonly IntPtr NativeFieldInfoPtr_Keybind;
    private static readonly IntPtr NativeFieldInfoPtr_TimeKeys;
    private static readonly IntPtr NativeFieldInfoPtr_CooldownTimeBuilder;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_BiteHeader;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Ability;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_BiteText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_BiteSubText;
    private static readonly IntPtr NativeFieldInfoPtr_IsHovered;
    private static readonly IntPtr NativeFieldInfoPtr__IconRect;
    private static readonly IntPtr NativeMethodInfoPtr_get_IconRect_Public_get_RectTransform_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe RectTransform IconRect
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217011, XrefRangeEnd = 1217019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BiteParent.NativeMethodInfoPtr_get_IconRect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
    }

    [CallerCount(0)]
    public unsafe void OnPointerEnter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BiteParent.NativeMethodInfoPtr_OnPointerEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnPointerExit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BiteParent.NativeMethodInfoPtr_OnPointerExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BiteParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BiteParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BiteParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BiteParent()
    {
      Il2CppClassPointerStore<BiteParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BiteParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BiteParent>.NativeClassPtr);
      BiteParent.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (Tooltip));
      BiteParent.NativeFieldInfoPtr_MotionInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (MotionInOut));
      BiteParent.NativeFieldInfoPtr_Feed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (Feed));
      BiteParent.NativeFieldInfoPtr_Bite_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (Bite_Active));
      BiteParent.NativeFieldInfoPtr_Bite_Inactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (Bite_Inactive));
      BiteParent.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (Icon));
      BiteParent.NativeFieldInfoPtr_CooldownText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (CooldownText));
      BiteParent.NativeFieldInfoPtr_Keybind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (Keybind));
      BiteParent.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (TimeKeys));
      BiteParent.NativeFieldInfoPtr_CooldownTimeBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (CooldownTimeBuilder));
      BiteParent.NativeFieldInfoPtr_LKey_BiteHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (LKey_BiteHeader));
      BiteParent.NativeFieldInfoPtr_LKey_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (LKey_Ability));
      BiteParent.NativeFieldInfoPtr_LKey_BiteText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (LKey_BiteText));
      BiteParent.NativeFieldInfoPtr_LKey_BiteSubText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (LKey_BiteSubText));
      BiteParent.NativeFieldInfoPtr_IsHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (IsHovered));
      BiteParent.NativeFieldInfoPtr__IconRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, nameof (_IconRect));
      BiteParent.NativeMethodInfoPtr_get_IconRect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, 100664249);
      BiteParent.NativeMethodInfoPtr_OnPointerEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, 100664250);
      BiteParent.NativeMethodInfoPtr_OnPointerExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, 100664251);
      BiteParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiteParent>.NativeClassPtr, 100664252);
    }

    public BiteParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FakeTooltip Tooltip
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Tooltip));
        return pointer == IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Tooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut MotionInOut
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_MotionInOut));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_MotionInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent Feed
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Feed));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Feed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Bite_Active
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Bite_Active));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Bite_Active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Bite_Inactive
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Bite_Inactive));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Bite_Inactive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CooldownText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_CooldownText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_CooldownText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Keybind
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Keybind));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_Keybind), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationTimeKeys TimeKeys
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_TimeKeys));
        return pointer == IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedTimeBuilder CooldownTimeBuilder
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_CooldownTimeBuilder);
        return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_CooldownTimeBuilder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe LocalizationKey LKey_BiteHeader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_LKey_BiteHeader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_LKey_BiteHeader)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Ability
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_LKey_Ability));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_LKey_Ability)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BiteText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_LKey_BiteText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_LKey_BiteText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BiteSubText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_LKey_BiteSubText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_LKey_BiteSubText)) = value;
      }
    }

    public unsafe bool IsHovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_IsHovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr_IsHovered)) = value;
      }
    }

    public unsafe RectTransform _IconRect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr__IconRect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BiteParent.NativeFieldInfoPtr__IconRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
