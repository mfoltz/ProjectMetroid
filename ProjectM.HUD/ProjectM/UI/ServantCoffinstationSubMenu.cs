// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServantCoffinstationSubMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ServantCoffinstationSubMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationBonusEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_Portrait;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeadColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_UnitName;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_ServantName;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_EditNameButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitInfo_ServantHasDied;
    private static readonly System.IntPtr NativeFieldInfoPtr_Profficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfficiencyOdds;
    private static readonly System.IntPtr NativeFieldInfoPtr_PowerLevelOdds;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverArea_Power;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverArea_Proficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverArea_PostPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverArea_PostProficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PreConvert_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PreConvert_Faction_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PreConvert_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PreConvert_Faction;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PostConvert_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PostConvert_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PostConvert_Faction;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PostConvert_BloodType_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkInfo_PostConvert_Faction_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkHoverArea_Faction;
    private static readonly System.IntPtr NativeFieldInfoPtr_PerkHoverArea_BloodType;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Proficiency;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ProficiencyDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Power;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PowerDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_EmptyCoffinInfo_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_NotFueledInfo_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivityInfo_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivityInfo_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivityInfo_SubDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameServant_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameServant_InputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameServant_InputFieldError;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomServantNameButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progressbar_Convert;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progressbar_Revive;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActionBox_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActionBox_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActionBox_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActionBox_Cost;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActionBox_ButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LargeButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_LargeButton_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmallButtons_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmallButton0;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmallButton0_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmallButton0_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmallButton0_Cost;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmallButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChangeNamePopupPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerminatePopupPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Terminate;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Convert;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_NoHumanCurrentlyCharmed;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ConvertToVampireServant;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_AbortConversion;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Complete;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Awaken;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Resurrect;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Summon;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ResurrectDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_SummonDescription;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ServantHasDied;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_OnAMission;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CurrentlyPatrollingCastleGrounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CurrentlyInCombat;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Recuperating;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleFloorsLocalizationKeys;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe bool AnyInputFieldFocused()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu.NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantCoffinstationSubMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantCoffinstationSubMenu()
    {
      Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServantCoffinstationSubMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr);
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (TooltipAnchor));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (FakeTooltip));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_StationBonusEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (StationBonusEntry));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_Portrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (Portrait));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_DeadColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (DeadColor));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (UnitInfo_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_UnitName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (UnitInfo_UnitName));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_ServantName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (UnitInfo_ServantName));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_EditNameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (UnitInfo_EditNameButton));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_ServantHasDied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (UnitInfo_ServantHasDied));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_Profficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (Profficiency));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_GearLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (GearLevel));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ProfficiencyOdds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ProfficiencyOdds));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PowerLevelOdds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PowerLevelOdds));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (HoverArea_Power));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_Proficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (HoverArea_Proficiency));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_PostPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (HoverArea_PostPower));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_PostProficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (HoverArea_PostProficiency));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PreConvert_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PreConvert_BloodType_Name));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Faction_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PreConvert_Faction_Name));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PreConvert_BloodType_Icon));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PreConvert_BloodQuality));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PreConvert_BloodType));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PreConvert_Faction));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PostConvert_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PostConvert_BloodType));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PostConvert_Faction));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_BloodType_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PostConvert_BloodType_Description));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Faction_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkInfo_PostConvert_Faction_Description));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkHoverArea_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkHoverArea_Faction));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkHoverArea_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (PerkHoverArea_BloodType));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_RandomLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (RandomLocalizationKeys));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Proficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Proficiency));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ProficiencyDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_ProficiencyDesc));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Power));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_PowerDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_PowerDesc));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_EmptyCoffinInfo_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (EmptyCoffinInfo_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_NotFueledInfo_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (NotFueledInfo_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ActivityInfo_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ActivityInfo_Description));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_SubDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ActivityInfo_SubDescription));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (NameServant_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (NameServant_InputField));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_InputFieldError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (NameServant_InputFieldError));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_RandomServantNameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (RandomServantNameButton));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_Progressbar_Convert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (Progressbar_Convert));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_Progressbar_Revive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (Progressbar_Revive));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ActionBox_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ActionBox_Button));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ActionBox_Text));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ActionBox_Cost));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ActionBox_ButtonText));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LargeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LargeButton));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LargeButton_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LargeButton_Text));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButtons_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (SmallButtons_Parent));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (SmallButton0));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (SmallButton0_Description));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (SmallButton0_Text));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (SmallButton0_Cost));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (SmallButton1));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ChangeNamePopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ChangeNamePopupPrefab));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_TerminatePopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (TerminatePopupPrefab));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Terminate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Terminate));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Convert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Convert));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_NoHumanCurrentlyCharmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_NoHumanCurrentlyCharmed));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ConvertToVampireServant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_ConvertToVampireServant));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_AbortConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_AbortConversion));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Complete));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Awaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Awaken));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Resurrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Resurrect));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Summon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Summon));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ResurrectDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_ResurrectDescription));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_SummonDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_SummonDescription));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_InvalidInput_AllSpaces));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ServantHasDied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_ServantHasDied));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_OnAMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_OnAMission));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_CurrentlyPatrollingCastleGrounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_CurrentlyPatrollingCastleGrounds));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_CurrentlyInCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_CurrentlyInCombat));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Recuperating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LKey_Recuperating));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (TimeKeys));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (LocalizedTime));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_ServantNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (ServantNames));
      ServantCoffinstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (CastleFloorsLocalizationKeys));
      ServantCoffinstationSubMenu.NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, 100666393);
      ServantCoffinstationSubMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, 100666394);
    }

    public ServantCoffinstationSubMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StationBonusEntry StationBonusEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_StationBonusEntry));
        return pointer == System.IntPtr.Zero ? (StationBonusEntry) null : new StationBonusEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_StationBonusEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Portrait
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_Portrait));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_Portrait), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color DeadColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_DeadColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_DeadColor)) = value;
      }
    }

    public unsafe RectTransform UnitInfo_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText UnitInfo_UnitName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_UnitName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_UnitName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText UnitInfo_ServantName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_ServantName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_ServantName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton UnitInfo_EditNameButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_EditNameButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_EditNameButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText UnitInfo_ServantHasDied
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_ServantHasDied));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_UnitInfo_ServantHasDied), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Profficiency
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_Profficiency));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_Profficiency), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText GearLevel
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_GearLevel));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_GearLevel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ProfficiencyOdds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ProfficiencyOdds));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ProfficiencyOdds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PowerLevelOdds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PowerLevelOdds));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PowerLevelOdds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry HoverArea_Power
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_Power));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_Power), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry HoverArea_Proficiency
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_Proficiency));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_Proficiency), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry HoverArea_PostPower
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_PostPower));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_PostPower), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry HoverArea_PostProficiency
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_PostProficiency));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_HoverArea_PostProficiency), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PerkInfo_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PerkInfo_PreConvert_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PerkInfo_PreConvert_BloodType_Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PerkInfo_PreConvert_Faction_Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Faction_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Faction_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image PerkInfo_PreConvert_BloodType_Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PerkInfo_PreConvert_BloodQuality
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodQuality));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodQuality), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu.BasicPerkInfo PerkInfo_PreConvert_BloodType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu.BasicPerkInfo) null : new ServantCoffinstationSubMenu.BasicPerkInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu.BasicPerkInfo PerkInfo_PreConvert_Faction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Faction));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu.BasicPerkInfo) null : new ServantCoffinstationSubMenu.BasicPerkInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PreConvert_Faction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PerkInfo_PostConvert_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu.BasicPerkInfo PerkInfo_PostConvert_BloodType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_BloodType));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu.BasicPerkInfo) null : new ServantCoffinstationSubMenu.BasicPerkInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu.BasicPerkInfo PerkInfo_PostConvert_Faction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Faction));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu.BasicPerkInfo) null : new ServantCoffinstationSubMenu.BasicPerkInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Faction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PerkInfo_PostConvert_BloodType_Description
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_BloodType_Description));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_BloodType_Description), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PerkInfo_PostConvert_Faction_Description
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Faction_Description));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkInfo_PostConvert_Faction_Description), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry PerkHoverArea_Faction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkHoverArea_Faction));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkHoverArea_Faction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry PerkHoverArea_BloodType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkHoverArea_BloodType));
        return pointer == System.IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_PerkHoverArea_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RandomLocalizationKeys RandomLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_RandomLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (RandomLocalizationKeys) null : new RandomLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_RandomLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Proficiency
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Proficiency));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Proficiency)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ProficiencyDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ProficiencyDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ProficiencyDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Power
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Power));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Power)) = value;
      }
    }

    public unsafe LocalizationKey LKey_PowerDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_PowerDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_PowerDesc)) = value;
      }
    }

    public unsafe RectTransform EmptyCoffinInfo_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_EmptyCoffinInfo_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_EmptyCoffinInfo_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform NotFueledInfo_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_NotFueledInfo_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_NotFueledInfo_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ActivityInfo_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ActivityInfo_Description
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_Description));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_Description), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ActivityInfo_SubDescription
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_SubDescription));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActivityInfo_SubDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform NameServant_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField NameServant_InputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_InputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_InputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NameServant_InputFieldError
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_InputFieldError));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_NameServant_InputFieldError), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton RandomServantNameButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_RandomServantNameButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_RandomServantNameButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu_ProgressBar Progressbar_Convert
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_Progressbar_Convert));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu_ProgressBar) null : new ServantCoffinstationSubMenu_ProgressBar(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_Progressbar_Convert), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu_ProgressBar Progressbar_Revive
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_Progressbar_Revive));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu_ProgressBar) null : new ServantCoffinstationSubMenu_ProgressBar(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_Progressbar_Revive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ActionBox_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ActionBox_Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ActionBox_Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorkstationRequirementEntry ActionBox_Cost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Cost));
        return pointer == System.IntPtr.Zero ? (WorkstationRequirementEntry) null : new WorkstationRequirementEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_Cost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ActionBox_ButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_ButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ActionBox_ButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton LargeButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LargeButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LargeButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText LargeButton_Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LargeButton_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LargeButton_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SmallButtons_Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButtons_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButtons_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SmallButton0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SmallButton0_Description
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Description));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Description), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SmallButton0_Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorkstationRequirementEntry SmallButton0_Cost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Cost));
        return pointer == System.IntPtr.Zero ? (WorkstationRequirementEntry) null : new WorkstationRequirementEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton0_Cost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SmallButton1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton1));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_SmallButton1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu_ChangeNamePopup ChangeNamePopupPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ChangeNamePopupPrefab));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu_ChangeNamePopup) null : new ServantCoffinstationSubMenu_ChangeNamePopup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ChangeNamePopupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServantCoffinstationSubMenu_TerminatePopup TerminatePopupPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_TerminatePopupPrefab));
        return pointer == System.IntPtr.Zero ? (ServantCoffinstationSubMenu_TerminatePopup) null : new ServantCoffinstationSubMenu_TerminatePopup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_TerminatePopupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Terminate
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Terminate));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Terminate)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Convert
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Convert));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Convert)) = value;
      }
    }

    public unsafe LocalizationKey LKey_NoHumanCurrentlyCharmed
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_NoHumanCurrentlyCharmed));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_NoHumanCurrentlyCharmed)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ConvertToVampireServant
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ConvertToVampireServant));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ConvertToVampireServant)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AbortConversion
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_AbortConversion));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_AbortConversion)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Complete
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Complete));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Complete)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Awaken
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Awaken));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Awaken)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Resurrect
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Resurrect));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Resurrect)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Summon
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Summon));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Summon)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ResurrectDescription
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ResurrectDescription));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ResurrectDescription)) = value;
      }
    }

    public unsafe LocalizationKey LKey_SummonDescription
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_SummonDescription));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_SummonDescription)) = value;
      }
    }

    public unsafe LocalizationKey LKey_InvalidInput_AllSpaces
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ServantHasDied
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ServantHasDied));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_ServantHasDied)) = value;
      }
    }

    public unsafe LocalizationKey LKey_OnAMission
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_OnAMission));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_OnAMission)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CurrentlyPatrollingCastleGrounds
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_CurrentlyPatrollingCastleGrounds));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_CurrentlyPatrollingCastleGrounds)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CurrentlyInCombat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_CurrentlyInCombat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_CurrentlyInCombat)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Recuperating
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Recuperating));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LKey_Recuperating)) = value;
      }
    }

    public unsafe LocalizationTimeKeys TimeKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_TimeKeys));
        return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedTimeBuilder LocalizedTime
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LocalizedTime);
        return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe TextAsset ServantNames
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ServantNames));
        return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_ServantNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleFloorsLocalizationKeys CastleFloorsLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (CastleFloorsLocalizationKeys) null : new CastleFloorsLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.NativeFieldInfoPtr_CastleFloorsLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class BasicPerkInfo : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_ID;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BasicPerkInfo()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantCoffinstationSubMenu.BasicPerkInfo>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu.BasicPerkInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BasicPerkInfo()
      {
        Il2CppClassPointerStore<ServantCoffinstationSubMenu.BasicPerkInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantCoffinstationSubMenu>.NativeClassPtr, nameof (BasicPerkInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantCoffinstationSubMenu.BasicPerkInfo>.NativeClassPtr);
        ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu.BasicPerkInfo>.NativeClassPtr, nameof (Text));
        ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu.BasicPerkInfo>.NativeClassPtr, nameof (Icon));
        ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu.BasicPerkInfo>.NativeClassPtr, nameof (ID));
        ServantCoffinstationSubMenu.BasicPerkInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu.BasicPerkInfo>.NativeClassPtr, 100666395);
      }

      public BasicPerkInfo(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe LocalizedText Text
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_Text));
          return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Image Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabGUID ID
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_ID));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu.BasicPerkInfo.NativeFieldInfoPtr_ID)) = value;
        }
      }
    }
  }
}
