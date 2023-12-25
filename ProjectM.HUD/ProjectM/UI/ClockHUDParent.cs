// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClockHUDParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ClockHUDParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TransitionTreshhold;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_Night;
    private static readonly IntPtr NativeFieldInfoPtr_IconColor_Night;
    private static readonly IntPtr NativeFieldInfoPtr_IconColor_BloodMoon;
    private static readonly IntPtr NativeFieldInfoPtr_TextColor_Night;
    private static readonly IntPtr NativeFieldInfoPtr_TextColor_BloodMoon;
    private static readonly IntPtr NativeFieldInfoPtr_TextColor_Day;
    private static readonly IntPtr NativeFieldInfoPtr_DayStartIndex;
    private static readonly IntPtr NativeFieldInfoPtr_ClockNumbers;
    private static readonly IntPtr NativeFieldInfoPtr_ClockParent;
    private static readonly IntPtr NativeFieldInfoPtr_MotionBinding;
    private static readonly IntPtr NativeFieldInfoPtr_FontMaterial_Normal;
    private static readonly IntPtr NativeFieldInfoPtr_FontMaterial_HighlightDay;
    private static readonly IntPtr NativeFieldInfoPtr_CastleStatusParent;
    private static readonly IntPtr NativeFieldInfoPtr_CastleStatusText;
    private static readonly IntPtr NativeFieldInfoPtr_FontMaterial_HighlightNight;
    private static readonly IntPtr NativeFieldInfoPtr_FontMaterial_HighlightBloodMoon;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_CastleRaid;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_CastleSiege;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Decay;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Attacked;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_LowEssence;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClockHUDParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClockHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClockHUDParent()
    {
      Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClockHUDParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr);
      ClockHUDParent.NativeFieldInfoPtr_TransitionTreshhold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (TransitionTreshhold));
      ClockHUDParent.NativeFieldInfoPtr_Icon_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (Icon_Night));
      ClockHUDParent.NativeFieldInfoPtr_IconColor_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (IconColor_Night));
      ClockHUDParent.NativeFieldInfoPtr_IconColor_BloodMoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (IconColor_BloodMoon));
      ClockHUDParent.NativeFieldInfoPtr_TextColor_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (TextColor_Night));
      ClockHUDParent.NativeFieldInfoPtr_TextColor_BloodMoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (TextColor_BloodMoon));
      ClockHUDParent.NativeFieldInfoPtr_TextColor_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (TextColor_Day));
      ClockHUDParent.NativeFieldInfoPtr_DayStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (DayStartIndex));
      ClockHUDParent.NativeFieldInfoPtr_ClockNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (ClockNumbers));
      ClockHUDParent.NativeFieldInfoPtr_ClockParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (ClockParent));
      ClockHUDParent.NativeFieldInfoPtr_MotionBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (MotionBinding));
      ClockHUDParent.NativeFieldInfoPtr_FontMaterial_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (FontMaterial_Normal));
      ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (FontMaterial_HighlightDay));
      ClockHUDParent.NativeFieldInfoPtr_CastleStatusParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (CastleStatusParent));
      ClockHUDParent.NativeFieldInfoPtr_CastleStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (CastleStatusText));
      ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (FontMaterial_HighlightNight));
      ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightBloodMoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (FontMaterial_HighlightBloodMoon));
      ClockHUDParent.NativeFieldInfoPtr_LKey_CastleRaid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (LKey_CastleRaid));
      ClockHUDParent.NativeFieldInfoPtr_LKey_CastleSiege = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (LKey_CastleSiege));
      ClockHUDParent.NativeFieldInfoPtr_LKey_Decay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (LKey_Decay));
      ClockHUDParent.NativeFieldInfoPtr_LKey_Attacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (LKey_Attacked));
      ClockHUDParent.NativeFieldInfoPtr_LKey_LowEssence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, nameof (LKey_LowEssence));
      ClockHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockHUDParent>.NativeClassPtr, 100664713);
    }

    public ClockHUDParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TransitionTreshhold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_TransitionTreshhold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_TransitionTreshhold)) = value;
      }
    }

    public unsafe Image Icon_Night
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_Icon_Night));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_Icon_Night), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color IconColor_Night
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_IconColor_Night));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_IconColor_Night)) = value;
      }
    }

    public unsafe Color IconColor_BloodMoon
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_IconColor_BloodMoon));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_IconColor_BloodMoon)) = value;
      }
    }

    public unsafe Color TextColor_Night
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_TextColor_Night));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_TextColor_Night)) = value;
      }
    }

    public unsafe Color TextColor_BloodMoon
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_TextColor_BloodMoon));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_TextColor_BloodMoon)) = value;
      }
    }

    public unsafe Color TextColor_Day
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_TextColor_Day));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_TextColor_Day)) = value;
      }
    }

    public unsafe int DayStartIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_DayStartIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_DayStartIndex)) = value;
      }
    }

    public unsafe List<LocalizedText> ClockNumbers
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_ClockNumbers));
        return pointer == IntPtr.Zero ? (List<LocalizedText>) null : new List<LocalizedText>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_ClockNumbers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ClockParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_ClockParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_ClockParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding MotionBinding
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_MotionBinding));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_MotionBinding), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material FontMaterial_Normal
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_FontMaterial_Normal));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_FontMaterial_Normal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material FontMaterial_HighlightDay
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightDay));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightDay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut CastleStatusParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_CastleStatusParent));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_CastleStatusParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CastleStatusText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_CastleStatusText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_CastleStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material FontMaterial_HighlightNight
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightNight));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightNight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material FontMaterial_HighlightBloodMoon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightBloodMoon));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_FontMaterial_HighlightBloodMoon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_CastleRaid
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_CastleRaid));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_CastleRaid)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CastleSiege
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_CastleSiege));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_CastleSiege)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Decay
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_Decay));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_Decay)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Attacked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_Attacked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_Attacked)) = value;
      }
    }

    public unsafe LocalizationKey LKey_LowEssence
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_LowEssence));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClockHUDParent.NativeFieldInfoPtr_LKey_LowEssence)) = value;
      }
    }
  }
}
