// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.JournalSettings
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class JournalSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_LKey_UnlocksReward;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardAbility;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardShapeshift;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardMaxLevel;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardExperience;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardWisdom;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardRecipe;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardBlueprint;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardPerk;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardEssence;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_HuntVBlood;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_VBloodFlavor;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackVBlood;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackVBloodDist;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackVBloodTime;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackVBloodFlavor;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackHiddenVBloodFlavor;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackHiddenVBlood;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackHiddenVBloodDistText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackHiddenVBloodDist;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackHiddenVBloodTimeText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TrackHiddenVBloodTime;
    private static readonly IntPtr NativeFieldInfoPtr_FlavorColor;
    private static readonly IntPtr NativeFieldInfoPtr_RewardColor;
    private static readonly IntPtr NativeFieldInfoPtr_ClaimedColor;
    private static readonly IntPtr NativeFieldInfoPtr_ColorCode_None;
    private static readonly IntPtr NativeFieldInfoPtr_ColorCode_Progress;
    private static readonly IntPtr NativeFieldInfoPtr_ColorCode_Completed;
    private static readonly IntPtr NativeFieldInfoPtr_ColorCode_Claimed;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JournalSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JournalSettings()
    {
      Il2CppClassPointerStore<JournalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (JournalSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr);
      JournalSettings.NativeFieldInfoPtr_LKey_UnlocksReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_UnlocksReward));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardAbility));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardShapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardShapeshift));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardMaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardMaxLevel));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardExperience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardExperience));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardWisdom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardWisdom));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardRecipe));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardBlueprint));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardPerk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardPerk));
      JournalSettings.NativeFieldInfoPtr_LKey_RewardEssence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_RewardEssence));
      JournalSettings.NativeFieldInfoPtr_LKey_HuntVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_HuntVBlood));
      JournalSettings.NativeFieldInfoPtr_LKey_VBloodFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_VBloodFlavor));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackVBlood));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackVBloodDist));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackVBloodTime));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackVBloodFlavor));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackHiddenVBloodFlavor));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackHiddenVBlood));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodDistText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackHiddenVBloodDistText));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackHiddenVBloodDist));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodTimeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackHiddenVBloodTimeText));
      JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (LKey_TrackHiddenVBloodTime));
      JournalSettings.NativeFieldInfoPtr_FlavorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (FlavorColor));
      JournalSettings.NativeFieldInfoPtr_RewardColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (RewardColor));
      JournalSettings.NativeFieldInfoPtr_ClaimedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (ClaimedColor));
      JournalSettings.NativeFieldInfoPtr_ColorCode_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (ColorCode_None));
      JournalSettings.NativeFieldInfoPtr_ColorCode_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (ColorCode_Progress));
      JournalSettings.NativeFieldInfoPtr_ColorCode_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (ColorCode_Completed));
      JournalSettings.NativeFieldInfoPtr_ColorCode_Claimed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, nameof (ColorCode_Claimed));
      JournalSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalSettings>.NativeClassPtr, 100664086);
    }

    public JournalSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey LKey_UnlocksReward
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_UnlocksReward));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_UnlocksReward)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardAbility
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardAbility));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardAbility)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardShapeshift
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardShapeshift));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardShapeshift)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardMaxLevel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardMaxLevel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardMaxLevel)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardExperience
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardExperience));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardExperience)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardWisdom
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardWisdom));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardWisdom)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardRecipe
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardRecipe));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardRecipe)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardBlueprint
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardBlueprint));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardBlueprint)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardPerk
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardPerk));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardPerk)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardEssence
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardEssence));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_RewardEssence)) = value;
      }
    }

    public unsafe LocalizationKey LKey_HuntVBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_HuntVBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_HuntVBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_VBloodFlavor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_VBloodFlavor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_VBloodFlavor)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackVBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackVBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackVBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackVBloodDist
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodDist));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodDist)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackVBloodTime
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodTime));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodTime)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackVBloodFlavor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodFlavor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackVBloodFlavor)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackHiddenVBloodFlavor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodFlavor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodFlavor)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackHiddenVBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackHiddenVBloodDistText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodDistText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodDistText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackHiddenVBloodDist
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodDist));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodDist)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackHiddenVBloodTimeText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodTimeText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodTimeText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TrackHiddenVBloodTime
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodTime));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_LKey_TrackHiddenVBloodTime)) = value;
      }
    }

    public unsafe Color FlavorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_FlavorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_FlavorColor)) = value;
      }
    }

    public unsafe Color RewardColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_RewardColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_RewardColor)) = value;
      }
    }

    public unsafe Color ClaimedColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ClaimedColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ClaimedColor)) = value;
      }
    }

    public unsafe string ColorCode_None
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ColorCode_None)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ColorCode_None), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ColorCode_Progress
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ColorCode_Progress)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ColorCode_Progress), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ColorCode_Completed
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ColorCode_Completed)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ColorCode_Completed), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ColorCode_Claimed
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ColorCode_Claimed)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalSettings.NativeFieldInfoPtr_ColorCode_Claimed), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
