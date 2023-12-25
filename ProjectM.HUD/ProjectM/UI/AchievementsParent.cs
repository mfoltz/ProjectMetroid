// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AchievementsParent
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
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class AchievementsParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AchievementEntries;
    private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;
    private static readonly IntPtr NativeFieldInfoPtr_NormalSprite;
    private static readonly IntPtr NativeFieldInfoPtr_HeaderParent;
    private static readonly IntPtr NativeFieldInfoPtr_HoverBackground;
    private static readonly IntPtr NativeFieldInfoPtr_BackgroundMotion2DInOut;
    private static readonly IntPtr NativeFieldInfoPtr_ColorCode_None;
    private static readonly IntPtr NativeFieldInfoPtr_ColorCode_Progress;
    private static readonly IntPtr NativeFieldInfoPtr_ColorCode_Completed;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardAbility;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardMaxLevel;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardExperience;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardWisdom;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardRecipe;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardBlueprint;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardPerk;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RewardEssence;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_HuntVBlood;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_VBloodFlavor;
    private static readonly IntPtr NativeFieldInfoPtr_DistanceSettings;
    private static readonly IntPtr NativeFieldInfoPtr_VbloodRespawnTimeDistance;
    private static readonly IntPtr NativeFieldInfoPtr_TimeKeys;
    private static readonly IntPtr NativeFieldInfoPtr_LocalizedTime;
    private static readonly IntPtr NativeFieldInfoPtr_Settings;
    private static readonly IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__State;
    private static readonly IntPtr NativeFieldInfoPtr__PreviouslyCompletedTasks;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsClaimButtonHovered_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_IsBackgroundHovered_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ClaimButtonEnter_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ClaimButtonExit_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryGetTrackingVBloodData_Private_Static_Boolean_EntityManager_PrefabLookupMap_GameDataSystem_Entity_PrefabGUID_byref_CharacterHUD_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryFillEntry_Private_Boolean_AchievementEntry_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsPrioritizationOrder_Private_Boolean_PrefabGUID_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_EntityManager_PrefabCollectionSystem_CommonClientDataSystem_AchievementState_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool IsClaimButtonHovered
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1213395, RefRangeEnd = 1213396, XrefRangeStart = 1213377, XrefRangeEnd = 1213395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_get_IsClaimButtonHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsBackgroundHovered
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1213412, RefRangeEnd = 1213413, XrefRangeStart = 1213396, XrefRangeEnd = 1213412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_get_IsBackgroundHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213413, XrefRangeEnd = 1213420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClaimButtonEnter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_ClaimButtonEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClaimButtonExit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_ClaimButtonExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213420, XrefRangeEnd = 1213560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1213576, RefRangeEnd = 1213580, XrefRangeStart = 1213560, XrefRangeEnd = 1213576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetTrackingVBloodData(
      EntityManager entityManager,
      PrefabLookupMap prefabLookupMap,
      GameDataSystem gameDataSystem,
      Entity progressionEntity,
      PrefabGUID vBloodTarget,
      out CharacterHUD charHUDComponent)
    {
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &progressionEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &vBloodTarget;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) ref charHUDComponent;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_TryGetTrackingVBloodData_Private_Static_Boolean_EntityManager_PrefabLookupMap_GameDataSystem_Entity_PrefabGUID_byref_CharacterHUD_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1213595, RefRangeEnd = 1213598, XrefRangeStart = 1213580, XrefRangeEnd = 1213595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFillEntry(
      AchievementEntry achievementEntry,
      int index,
      int progressionUnlocked = -1)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) achievementEntry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &progressionUnlocked;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_TryFillEntry_Private_Boolean_AchievementEntry_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1213601, RefRangeEnd = 1213602, XrefRangeStart = 1213598, XrefRangeEnd = 1213601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPrioritizationOrder(PrefabGUID achievementGUID, int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &achievementGUID;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_IsPrioritizationOrder_Private_Boolean_PrefabGUID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213602, XrefRangeEnd = 1213610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      CommonClientDataSystem commonClientDataSystem,
      AchievementState achievementState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commonClientDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) achievementState);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr_Initialize_Internal_Void_EntityManager_PrefabCollectionSystem_CommonClientDataSystem_AchievementState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementsParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementsParent()
    {
      Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AchievementsParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr);
      AchievementsParent.NativeFieldInfoPtr_AchievementEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (AchievementEntries));
      AchievementsParent.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LayoutGroup));
      AchievementsParent.NativeFieldInfoPtr_NormalSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (NormalSprite));
      AchievementsParent.NativeFieldInfoPtr_HeaderParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (HeaderParent));
      AchievementsParent.NativeFieldInfoPtr_HoverBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (HoverBackground));
      AchievementsParent.NativeFieldInfoPtr_BackgroundMotion2DInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (BackgroundMotion2DInOut));
      AchievementsParent.NativeFieldInfoPtr_ColorCode_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (ColorCode_None));
      AchievementsParent.NativeFieldInfoPtr_ColorCode_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (ColorCode_Progress));
      AchievementsParent.NativeFieldInfoPtr_ColorCode_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (ColorCode_Completed));
      AchievementsParent.NativeFieldInfoPtr_LKey_RewardAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_RewardAbility));
      AchievementsParent.NativeFieldInfoPtr_LKey_RewardMaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_RewardMaxLevel));
      AchievementsParent.NativeFieldInfoPtr_LKey_RewardExperience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_RewardExperience));
      AchievementsParent.NativeFieldInfoPtr_LKey_RewardWisdom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_RewardWisdom));
      AchievementsParent.NativeFieldInfoPtr_LKey_RewardRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_RewardRecipe));
      AchievementsParent.NativeFieldInfoPtr_LKey_RewardBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_RewardBlueprint));
      AchievementsParent.NativeFieldInfoPtr_LKey_RewardPerk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_RewardPerk));
      AchievementsParent.NativeFieldInfoPtr_LKey_RewardEssence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_RewardEssence));
      AchievementsParent.NativeFieldInfoPtr_LKey_HuntVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_HuntVBlood));
      AchievementsParent.NativeFieldInfoPtr_LKey_VBloodFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LKey_VBloodFlavor));
      AchievementsParent.NativeFieldInfoPtr_DistanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (DistanceSettings));
      AchievementsParent.NativeFieldInfoPtr_VbloodRespawnTimeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (VbloodRespawnTimeDistance));
      AchievementsParent.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (TimeKeys));
      AchievementsParent.NativeFieldInfoPtr_LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (LocalizedTime));
      AchievementsParent.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (Settings));
      AchievementsParent.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (_EntityManager));
      AchievementsParent.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      AchievementsParent.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (_GameDataSystem));
      AchievementsParent.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (_CommonClientDataSystem));
      AchievementsParent.NativeFieldInfoPtr__State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (_State));
      AchievementsParent.NativeFieldInfoPtr__PreviouslyCompletedTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, nameof (_PreviouslyCompletedTasks));
      AchievementsParent.NativeMethodInfoPtr_get_IsClaimButtonHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663947);
      AchievementsParent.NativeMethodInfoPtr_get_IsBackgroundHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663948);
      AchievementsParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663949);
      AchievementsParent.NativeMethodInfoPtr_ClaimButtonEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663950);
      AchievementsParent.NativeMethodInfoPtr_ClaimButtonExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663951);
      AchievementsParent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663952);
      AchievementsParent.NativeMethodInfoPtr_TryGetTrackingVBloodData_Private_Static_Boolean_EntityManager_PrefabLookupMap_GameDataSystem_Entity_PrefabGUID_byref_CharacterHUD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663953);
      AchievementsParent.NativeMethodInfoPtr_TryFillEntry_Private_Boolean_AchievementEntry_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663954);
      AchievementsParent.NativeMethodInfoPtr_IsPrioritizationOrder_Private_Boolean_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663955);
      AchievementsParent.NativeMethodInfoPtr_Initialize_Internal_Void_EntityManager_PrefabCollectionSystem_CommonClientDataSystem_AchievementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663956);
      AchievementsParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsParent>.NativeClassPtr, 100663957);
    }

    public AchievementsParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<AchievementEntry> AchievementEntries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_AchievementEntries));
        return pointer == IntPtr.Zero ? (List<AchievementEntry>) null : new List<AchievementEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_AchievementEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform LayoutGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LayoutGroup));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite NormalSprite
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_NormalSprite));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_NormalSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject HeaderParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_HeaderParent));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_HeaderParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image HoverBackground
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_HoverBackground));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_HoverBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut BackgroundMotion2DInOut
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_BackgroundMotion2DInOut));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_BackgroundMotion2DInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string ColorCode_None
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_ColorCode_None)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_ColorCode_None), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ColorCode_Progress
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_ColorCode_Progress)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_ColorCode_Progress), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ColorCode_Completed
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_ColorCode_Completed)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_ColorCode_Completed), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationKey LKey_RewardAbility
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardAbility));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardAbility)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardMaxLevel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardMaxLevel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardMaxLevel)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardExperience
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardExperience));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardExperience)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardWisdom
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardWisdom));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardWisdom)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardRecipe
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardRecipe));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardRecipe)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardBlueprint
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardBlueprint));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardBlueprint)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardPerk
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardPerk));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardPerk)) = value;
      }
    }

    public unsafe LocalizationKey LKey_RewardEssence
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardEssence));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_RewardEssence)) = value;
      }
    }

    public unsafe LocalizationKey LKey_HuntVBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_HuntVBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_HuntVBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_VBloodFlavor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_VBloodFlavor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LKey_VBloodFlavor)) = value;
      }
    }

    public unsafe VBloodDistanceSettings DistanceSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_DistanceSettings));
        return pointer == IntPtr.Zero ? (VBloodDistanceSettings) null : new VBloodDistanceSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_DistanceSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float VbloodRespawnTimeDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_VbloodRespawnTimeDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_VbloodRespawnTimeDistance)) = value;
      }
    }

    public unsafe LocalizationTimeKeys TimeKeys
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_TimeKeys));
        return pointer == IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedTimeBuilder LocalizedTime
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LocalizedTime);
        return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe JournalSettings Settings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_Settings));
        return pointer == IntPtr.Zero ? (JournalSettings) null : new JournalSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityManager _EntityManager
    {
      get
      {
        return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__EntityManager));
      }
      [param: In] set
      {
        *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__EntityManager)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__GameDataSystem));
        return pointer == IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AchievementState _State
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__State));
        return pointer == IntPtr.Zero ? (AchievementState) null : new AchievementState(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__State), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<PrefabGUID> _PreviouslyCompletedTasks
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__PreviouslyCompletedTasks));
        return pointer == IntPtr.Zero ? (HashSet<PrefabGUID>) null : new HashSet<PrefabGUID>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsParent.NativeFieldInfoPtr__PreviouslyCompletedTasks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
