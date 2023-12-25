// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AnnouncementHUDParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class AnnouncementHUDParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementDay;
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementNight;
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementBloodMoon;
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementAchievement;
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementBasic;
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementDay_DayNumber;
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementNight_DayNumber;
    private static readonly IntPtr NativeFieldInfoPtr_AnnouncementBloodMoon_DayNumber;
    private static readonly IntPtr NativeFieldInfoPtr_DayX;
    private static readonly IntPtr NativeFieldInfoPtr_Achievement_Header;
    private static readonly IntPtr NativeFieldInfoPtr_Achievement_SubHeader;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementAbility;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementPerk;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementMaxLevels;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementMaxLevelsText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementExperience;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementExperienceText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementWisdom;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementWisdomText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementEssence;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementEssenceText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementRecipe;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementBlueprint;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementUnlocks;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AchievementShapeshift;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_VBloodUnlocks;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_NewFeatureUnlocked;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_LevelUpHeader;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_LevelUpText;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_AreaDiscovered;
    private static readonly IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr_UiPopupNewAreaSound;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_EntityManager_PrefabCollectionSystem_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShowLevelUpAnnouncement_Public_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShowBasicAnnouncement_Public_Void_LocalizationKey_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShowAreaDiscovered_Public_Void_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr_FetchTechRewards_Private_Void_DynamicBuffer_1_ProgressionBookTechElement_byref_DynamicBuffer_1_TechUnlockRecipeBuffer_byref_DynamicBuffer_1_TechUnlockBlueprintBuffer_byref_DynamicBuffer_1_ProgressionBookShapeshiftElement_byref_LocalizationKey_byref_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShowAchievementAnnouncement_Public_Void_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215698, XrefRangeEnd = 1215701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnnouncementHUDParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1215709, RefRangeEnd = 1215710, XrefRangeStart = 1215701, XrefRangeEnd = 1215709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &entity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnnouncementHUDParent.NativeMethodInfoPtr_Initialize_Public_Void_EntityManager_PrefabCollectionSystem_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215710, XrefRangeEnd = 1215723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowLevelUpAnnouncement(int points)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &points;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnnouncementHUDParent.NativeMethodInfoPtr_ShowLevelUpAnnouncement_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1215729, RefRangeEnd = 1215730, XrefRangeStart = 1215723, XrefRangeEnd = 1215729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowBasicAnnouncement(
      LocalizationKey headerKey,
      LocalizationKey subHeaderKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &headerKey;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &subHeaderKey;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnnouncementHUDParent.NativeMethodInfoPtr_ShowBasicAnnouncement_Public_Void_LocalizationKey_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1215743, RefRangeEnd = 1215744, XrefRangeStart = 1215730, XrefRangeEnd = 1215743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowAreaDiscovered(LocalizationKey areaNameKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &areaNameKey;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnnouncementHUDParent.NativeMethodInfoPtr_ShowAreaDiscovered_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1215766, RefRangeEnd = 1215767, XrefRangeStart = 1215744, XrefRangeEnd = 1215766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FetchTechRewards(
      DynamicBuffer<ProgressionBookTechElement> unlocksTechs,
      out DynamicBuffer<TechUnlockRecipeBuffer> techRecipe,
      out DynamicBuffer<TechUnlockBlueprintBuffer> techBlueprint,
      out DynamicBuffer<ProgressionBookShapeshiftElement> techShapeshifts,
      out LocalizationKey rewardString,
      out bool displayAsGenericUnlock)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) &unlocksTechs;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref techRecipe;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref techBlueprint;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref techShapeshifts;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) ref rewardString;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) ref displayAsGenericUnlock;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnnouncementHUDParent.NativeMethodInfoPtr_FetchTechRewards_Private_Void_DynamicBuffer_1_ProgressionBookTechElement_byref_DynamicBuffer_1_TechUnlockRecipeBuffer_byref_DynamicBuffer_1_TechUnlockBlueprintBuffer_byref_DynamicBuffer_1_ProgressionBookShapeshiftElement_byref_LocalizationKey_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1216059, RefRangeEnd = 1216061, XrefRangeStart = 1215767, XrefRangeEnd = 1216059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowAchievementAnnouncement(PrefabGUID prefabGUID)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &prefabGUID;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnnouncementHUDParent.NativeMethodInfoPtr_ShowAchievementAnnouncement_Public_Void_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnnouncementHUDParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnnouncementHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AnnouncementHUDParent()
    {
      Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AnnouncementHUDParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr);
      AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (AnnouncementDay));
      AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (AnnouncementNight));
      AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBloodMoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (AnnouncementBloodMoon));
      AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (AnnouncementAchievement));
      AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBasic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (AnnouncementBasic));
      AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementDay_DayNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (AnnouncementDay_DayNumber));
      AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementNight_DayNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (AnnouncementNight_DayNumber));
      AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBloodMoon_DayNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (AnnouncementBloodMoon_DayNumber));
      AnnouncementHUDParent.NativeFieldInfoPtr_DayX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (DayX));
      AnnouncementHUDParent.NativeFieldInfoPtr_Achievement_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (Achievement_Header));
      AnnouncementHUDParent.NativeFieldInfoPtr_Achievement_SubHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (Achievement_SubHeader));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementAbility));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementPerk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementPerk));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementMaxLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementMaxLevels));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementMaxLevelsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementMaxLevelsText));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementExperience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementExperience));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementExperienceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementExperienceText));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementWisdom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementWisdom));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementWisdomText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementWisdomText));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementEssence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementEssence));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementEssenceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementEssenceText));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementRecipe));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementBlueprint));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementUnlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementUnlocks));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementShapeshift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AchievementShapeshift));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_VBloodUnlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_VBloodUnlocks));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_NewFeatureUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_NewFeatureUnlocked));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_LevelUpHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_LevelUpHeader));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_LevelUpText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_LevelUpText));
      AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AreaDiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (LKey_AreaDiscovered));
      AnnouncementHUDParent.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (_EntityManager));
      AnnouncementHUDParent.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      AnnouncementHUDParent.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (_GameDataSystem));
      AnnouncementHUDParent.NativeFieldInfoPtr_UiPopupNewAreaSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, nameof (UiPopupNewAreaSound));
      AnnouncementHUDParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, 100664132);
      AnnouncementHUDParent.NativeMethodInfoPtr_Initialize_Public_Void_EntityManager_PrefabCollectionSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, 100664133);
      AnnouncementHUDParent.NativeMethodInfoPtr_ShowLevelUpAnnouncement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, 100664134);
      AnnouncementHUDParent.NativeMethodInfoPtr_ShowBasicAnnouncement_Public_Void_LocalizationKey_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, 100664135);
      AnnouncementHUDParent.NativeMethodInfoPtr_ShowAreaDiscovered_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, 100664136);
      AnnouncementHUDParent.NativeMethodInfoPtr_FetchTechRewards_Private_Void_DynamicBuffer_1_ProgressionBookTechElement_byref_DynamicBuffer_1_TechUnlockRecipeBuffer_byref_DynamicBuffer_1_TechUnlockBlueprintBuffer_byref_DynamicBuffer_1_ProgressionBookShapeshiftElement_byref_LocalizationKey_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, 100664137);
      AnnouncementHUDParent.NativeMethodInfoPtr_ShowAchievementAnnouncement_Public_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, 100664138);
      AnnouncementHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementHUDParent>.NativeClassPtr, 100664139);
    }

    public AnnouncementHUDParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Motion2DBinding AnnouncementDay
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementDay));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementDay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding AnnouncementNight
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementNight));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementNight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding AnnouncementBloodMoon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBloodMoon));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBloodMoon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding AnnouncementAchievement
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementAchievement));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementAchievement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding AnnouncementBasic
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBasic));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBasic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText AnnouncementDay_DayNumber
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementDay_DayNumber));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementDay_DayNumber), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText AnnouncementNight_DayNumber
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementNight_DayNumber));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementNight_DayNumber), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText AnnouncementBloodMoon_DayNumber
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBloodMoon_DayNumber));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_AnnouncementBloodMoon_DayNumber), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey DayX
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_DayX));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_DayX)) = value;
      }
    }

    public unsafe LocalizedText Achievement_Header
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_Achievement_Header));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_Achievement_Header), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Achievement_SubHeader
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_Achievement_SubHeader));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_Achievement_SubHeader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_AchievementAbility
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementAbility));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementAbility)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementPerk
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementPerk));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementPerk)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementMaxLevels
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementMaxLevels));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementMaxLevels)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementMaxLevelsText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementMaxLevelsText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementMaxLevelsText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementExperience
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementExperience));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementExperience)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementExperienceText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementExperienceText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementExperienceText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementWisdom
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementWisdom));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementWisdom)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementWisdomText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementWisdomText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementWisdomText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementEssence
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementEssence));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementEssence)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementEssenceText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementEssenceText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementEssenceText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementRecipe
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementRecipe));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementRecipe)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementBlueprint
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementBlueprint));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementBlueprint)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementUnlocks
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementUnlocks));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementUnlocks)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AchievementShapeshift
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementShapeshift));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AchievementShapeshift)) = value;
      }
    }

    public unsafe LocalizationKey LKey_VBloodUnlocks
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_VBloodUnlocks));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_VBloodUnlocks)) = value;
      }
    }

    public unsafe LocalizationKey LKey_NewFeatureUnlocked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_NewFeatureUnlocked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_NewFeatureUnlocked)) = value;
      }
    }

    public unsafe LocalizationKey LKey_LevelUpHeader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_LevelUpHeader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_LevelUpHeader)) = value;
      }
    }

    public unsafe LocalizationKey LKey_LevelUpText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_LevelUpText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_LevelUpText)) = value;
      }
    }

    public unsafe LocalizationKey LKey_AreaDiscovered
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AreaDiscovered));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_LKey_AreaDiscovered)) = value;
      }
    }

    public unsafe EntityManager _EntityManager
    {
      get
      {
        return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr__EntityManager));
      }
      [param: In] set
      {
        *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr__EntityManager)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr__GameDataSystem));
        return pointer == IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public FmodEvent UiPopupNewAreaSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_UiPopupNewAreaSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnnouncementHUDParent.NativeFieldInfoPtr_UiPopupNewAreaSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
