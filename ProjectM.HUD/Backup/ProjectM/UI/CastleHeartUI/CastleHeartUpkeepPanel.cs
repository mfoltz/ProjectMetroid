// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartUI.CastleHeartUpkeepPanel
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
namespace ProjectM.UI.CastleHeartUI
{
  public class CastleHeartUpkeepPanel : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage;
    private static readonly IntPtr NativeFieldInfoPtr_DecayBloodEssenceSlotHighlight;
    private static readonly IntPtr NativeFieldInfoPtr_BackgroundProcessing;
    private static readonly IntPtr NativeFieldInfoPtr_BackgroundDecaying;
    private static readonly IntPtr NativeFieldInfoPtr_ProgressBar;
    private static readonly IntPtr NativeFieldInfoPtr_ProgressIcon;
    private static readonly IntPtr NativeFieldInfoPtr_ProcessingDesc;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly IntPtr NativeFieldInfoPtr_TotalProcessingTime;
    private static readonly IntPtr NativeFieldInfoPtr_ProcessingTime;
    private static readonly IntPtr NativeFieldInfoPtr_WarningText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_NoInput;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Processing;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Deactivated;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Warning_Decay;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Warning_Attacked;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Warning_Sieged;
    private static readonly IntPtr NativeFieldInfoPtr_ProcessingInputsParent;
    private static readonly IntPtr NativeFieldInfoPtr_ProcessingInputEntryPrefab;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartUpkeepPanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartUpkeepPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartUpkeepPanel()
    {
      Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI.CastleHeartUI", nameof (CastleHeartUpkeepPanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr);
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (BackgroundImage));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_DecayBloodEssenceSlotHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (DecayBloodEssenceSlotHighlight));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (BackgroundProcessing));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundDecaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (BackgroundDecaying));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (ProgressBar));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProgressIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (ProgressIcon));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (ProcessingDesc));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (TooltipAnchor));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_TotalProcessingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (TotalProcessingTime));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (ProcessingTime));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_WarningText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (WarningText));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_NoInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (LKey_NoInput));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Processing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (LKey_Processing));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Deactivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (LKey_Deactivated));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Decay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (LKey_Warning_Decay));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Attacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (LKey_Warning_Attacked));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Sieged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (LKey_Warning_Sieged));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingInputsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (ProcessingInputsParent));
      CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingInputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, nameof (ProcessingInputEntryPrefab));
      CastleHeartUpkeepPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartUpkeepPanel>.NativeClassPtr, 100669848);
    }

    public CastleHeartUpkeepPanel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image BackgroundImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image DecayBloodEssenceSlotHighlight
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_DecayBloodEssenceSlotHighlight));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_DecayBloodEssenceSlotHighlight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite BackgroundProcessing
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundProcessing));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundProcessing), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite BackgroundDecaying
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundDecaying));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_BackgroundDecaying), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ProgressBar
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProgressBar));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProgressBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ProgressIcon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProgressIcon));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProgressIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ProcessingDesc
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingDesc));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingDesc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText TotalProcessingTime
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_TotalProcessingTime));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_TotalProcessingTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ProcessingTime
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingTime));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText WarningText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_WarningText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_WarningText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_NoInput
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_NoInput));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_NoInput)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Processing
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Processing));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Processing)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Deactivated
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Deactivated));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Deactivated)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Warning_Decay
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Decay));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Decay)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Warning_Attacked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Attacked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Attacked)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Warning_Sieged
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Sieged));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_LKey_Warning_Sieged)) = value;
      }
    }

    public unsafe GridLayoutGroup ProcessingInputsParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingInputsParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingInputsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemGridSelectionEntry ProcessingInputEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingInputEntryPrefab));
        return pointer == IntPtr.Zero ? (ItemGridSelectionEntry) null : new ItemGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpkeepPanel.NativeFieldInfoPtr_ProcessingInputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
