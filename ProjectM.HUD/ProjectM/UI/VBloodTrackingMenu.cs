// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodTrackingMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Fmod;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class VBloodTrackingMenu : FullscreenMenuView
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollRoots;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopTrackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodTreeRootNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodEntriesNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShardBossEntriesNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodChunkPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShardBossChunkPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedUnitParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedUnitNameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedUnitDescText;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedUnitLevelText;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedUnitImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrevEntryButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextEntryButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_TreeBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_Large_VBloodIcon_Material_Standard;
    private static readonly System.IntPtr NativeFieldInfoPtr_Large_VBloodIcon_Material_Effect;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatusText;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatusTextNormalColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatusTextErrorColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedDistanceText;
    private static readonly System.IntPtr NativeFieldInfoPtr_RewardsRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockPowersParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockPowersRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockSpellsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockSpellsRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockRecipesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockRecipesRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockBlueprintsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockBlueprintsRoot;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnknownIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Back;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_StartTracking;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_StopTracking;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_TrackingNotUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_NotTrackable;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Distance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_DirectionAndDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_StandardVBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ShardBossVBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VbloodLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_PlayerLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_RewardsMotionsStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_RewardsMotionsStepTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellsBindings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PowersBindings;
    private static readonly System.IntPtr NativeFieldInfoPtr_StructuresBindings;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipesBindings;
    private static readonly System.IntPtr NativeFieldInfoPtr_FE_UnlockStep;
    private static readonly System.IntPtr NativeFieldInfoPtr_FE_UnlockSpells;
    private static readonly System.IntPtr NativeFieldInfoPtr_FE_UnlockPowers;
    private static readonly System.IntPtr NativeFieldInfoPtr_FE_UnlockStructurs;
    private static readonly System.IntPtr NativeFieldInfoPtr_FE_UnlockRecipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectionKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_FakeTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_Passive;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLevelText;
    private static readonly System.IntPtr NativeFieldInfoPtr_GearLevelInfoParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockPowersSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockSpellsSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockRecipesSelectionGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockBlueprintsSelectionGroup;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTrackButton_Public_Void_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStatusText_Private_Void_LocalizationKey_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedDistanceText_Public_Void_CardinalDirection_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDirection_Public_Void_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__73_0_Private_Void_ResearchEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__73_1_Private_Void_ResearchEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__73_2_Private_Void_ResearchEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__73_3_Private_Void_ResearchEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__73_4_Private_Void_Object_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263749, XrefRangeEnd = 1263758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTrackButton(bool trackingUnlocked, bool canBeTracked, bool isTracking)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &trackingUnlocked;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &canBeTracked;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isTracking;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr_UpdateTrackButton_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263758, XrefRangeEnd = 1263761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetStatusText(LocalizationKey localizationKey, bool isError)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &localizationKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isError;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr_SetStatusText_Private_Void_LocalizationKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263761, XrefRangeEnd = 1263828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263843, RefRangeEnd = 1263844, XrefRangeStart = 1263828, XrefRangeEnd = 1263843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSelectedDistanceText(CardinalDirection direction, int distance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &direction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &distance;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr_SetSelectedDistanceText_Public_Void_CardinalDirection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263844, XrefRangeEnd = 1263853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetDirection(float2 playerPos, float2 targetPos)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &playerPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPos;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr_GetDirection_Public_Void_float2_float2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263853, XrefRangeEnd = 1263854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodTrackingMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263854, XrefRangeEnd = 1263856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__73_0(ResearchEntry entry, ResearchEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_0_Private_Void_ResearchEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263856, XrefRangeEnd = 1263858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__73_1(ResearchEntry entry, ResearchEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_1_Private_Void_ResearchEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263858, XrefRangeEnd = 1263860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__73_2(ResearchEntry entry, ResearchEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_2_Private_Void_ResearchEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263860, XrefRangeEnd = 1263862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__73_3(ResearchEntry entry, ResearchEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_3_Private_Void_ResearchEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263862, XrefRangeEnd = 1263869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__73_4(Il2CppSystem.Object data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_4_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodTrackingMenu()
    {
      Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodTrackingMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr);
      VBloodTrackingMenu.NativeFieldInfoPtr_ActSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (ActSettings));
      VBloodTrackingMenu.NativeFieldInfoPtr_DistanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (DistanceSettings));
      VBloodTrackingMenu.NativeFieldInfoPtr_ScrollRoots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (ScrollRoots));
      VBloodTrackingMenu.NativeFieldInfoPtr_StopTrackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (StopTrackButton));
      VBloodTrackingMenu.NativeFieldInfoPtr_VBloodTreeRootNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (VBloodTreeRootNode));
      VBloodTrackingMenu.NativeFieldInfoPtr_VBloodEntriesNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (VBloodEntriesNode));
      VBloodTrackingMenu.NativeFieldInfoPtr_ShardBossEntriesNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (ShardBossEntriesNode));
      VBloodTrackingMenu.NativeFieldInfoPtr_VBloodChunkPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (VBloodChunkPrefab));
      VBloodTrackingMenu.NativeFieldInfoPtr_ShardBossChunkPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (ShardBossChunkPrefab));
      VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (SelectedUnitParent));
      VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (SelectedUnitNameText));
      VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitDescText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (SelectedUnitDescText));
      VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitLevelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (SelectedUnitLevelText));
      VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (SelectedUnitImage));
      VBloodTrackingMenu.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (BackButton));
      VBloodTrackingMenu.NativeFieldInfoPtr_TrackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (TrackButton));
      VBloodTrackingMenu.NativeFieldInfoPtr_TrackButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (TrackButtonText));
      VBloodTrackingMenu.NativeFieldInfoPtr_PrevEntryButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (PrevEntryButton));
      VBloodTrackingMenu.NativeFieldInfoPtr_NextEntryButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (NextEntryButton));
      VBloodTrackingMenu.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (BackgroundImage));
      VBloodTrackingMenu.NativeFieldInfoPtr_TreeBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (TreeBackground));
      VBloodTrackingMenu.NativeFieldInfoPtr_SelectedBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (SelectedBackground));
      VBloodTrackingMenu.NativeFieldInfoPtr_Large_VBloodIcon_Material_Standard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (Large_VBloodIcon_Material_Standard));
      VBloodTrackingMenu.NativeFieldInfoPtr_Large_VBloodIcon_Material_Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (Large_VBloodIcon_Material_Effect));
      VBloodTrackingMenu.NativeFieldInfoPtr_StatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (StatusText));
      VBloodTrackingMenu.NativeFieldInfoPtr_StatusTextNormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (StatusTextNormalColor));
      VBloodTrackingMenu.NativeFieldInfoPtr_StatusTextErrorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (StatusTextErrorColor));
      VBloodTrackingMenu.NativeFieldInfoPtr_SelectedDistanceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (SelectedDistanceText));
      VBloodTrackingMenu.NativeFieldInfoPtr_RewardsRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (RewardsRoot));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockPowersParent));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockPowersRoot));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockSpellsParent));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockSpellsRoot));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockRecipesParent));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockRecipesRoot));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockBlueprintsParent));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockBlueprintsRoot));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockPrefab));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnknownIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnknownIcon));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_Back));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_StartTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_StartTracking));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_StopTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_StopTracking));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_TrackingNotUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_TrackingNotUnlocked));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_NotTrackable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_NotTrackable));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_Distance));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_DirectionAndDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_DirectionAndDistance));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_StandardVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_StandardVBlood));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_ShardBossVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_ShardBossVBlood));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_VbloodLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_VbloodLevel));
      VBloodTrackingMenu.NativeFieldInfoPtr_LK_PlayerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (LK_PlayerLevel));
      VBloodTrackingMenu.NativeFieldInfoPtr_RewardsMotionsStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (RewardsMotionsStartTime));
      VBloodTrackingMenu.NativeFieldInfoPtr_RewardsMotionsStepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (RewardsMotionsStepTime));
      VBloodTrackingMenu.NativeFieldInfoPtr_SpellsBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (SpellsBindings));
      VBloodTrackingMenu.NativeFieldInfoPtr_PowersBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (PowersBindings));
      VBloodTrackingMenu.NativeFieldInfoPtr_StructuresBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (StructuresBindings));
      VBloodTrackingMenu.NativeFieldInfoPtr_RecipesBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (RecipesBindings));
      VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (FE_UnlockStep));
      VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockSpells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (FE_UnlockSpells));
      VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockPowers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (FE_UnlockPowers));
      VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockStructurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (FE_UnlockStructurs));
      VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (FE_UnlockRecipes));
      VBloodTrackingMenu.NativeFieldInfoPtr_DirectionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (DirectionKeys));
      VBloodTrackingMenu.NativeFieldInfoPtr_TooltipNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (TooltipNode));
      VBloodTrackingMenu.NativeFieldInfoPtr_FakeTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (FakeTooltip));
      VBloodTrackingMenu.NativeFieldInfoPtr_Sprite_Passive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (Sprite_Passive));
      VBloodTrackingMenu.NativeFieldInfoPtr_PlayerLevelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (PlayerLevelText));
      VBloodTrackingMenu.NativeFieldInfoPtr_GearLevelInfoParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (GearLevelInfoParent));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockPowersSelectionGroup));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockSpellsSelectionGroup));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockRecipesSelectionGroup));
      VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, nameof (UnlockBlueprintsSelectionGroup));
      VBloodTrackingMenu.NativeMethodInfoPtr_UpdateTrackButton_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667473);
      VBloodTrackingMenu.NativeMethodInfoPtr_SetStatusText_Private_Void_LocalizationKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667474);
      VBloodTrackingMenu.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667475);
      VBloodTrackingMenu.NativeMethodInfoPtr_SetSelectedDistanceText_Public_Void_CardinalDirection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667476);
      VBloodTrackingMenu.NativeMethodInfoPtr_GetDirection_Public_Void_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667477);
      VBloodTrackingMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667478);
      VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_0_Private_Void_ResearchEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667479);
      VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_1_Private_Void_ResearchEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667480);
      VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_2_Private_Void_ResearchEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667481);
      VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_3_Private_Void_ResearchEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667482);
      VBloodTrackingMenu.NativeMethodInfoPtr__InitializeUI_b__73_4_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenu>.NativeClassPtr, 100667483);
    }

    public VBloodTrackingMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe VBloodActSettings ActSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_ActSettings));
        return pointer == System.IntPtr.Zero ? (VBloodActSettings) null : new VBloodActSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_ActSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VBloodDistanceSettings DistanceSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_DistanceSettings));
        return pointer == System.IntPtr.Zero ? (VBloodDistanceSettings) null : new VBloodDistanceSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_DistanceSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> ScrollRoots
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_ScrollRoots));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_ScrollRoots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton StopTrackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StopTrackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StopTrackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform VBloodTreeRootNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_VBloodTreeRootNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_VBloodTreeRootNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform VBloodEntriesNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_VBloodEntriesNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_VBloodEntriesNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ShardBossEntriesNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_ShardBossEntriesNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_ShardBossEntriesNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VBloodTrackingChunkEntry VBloodChunkPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_VBloodChunkPrefab));
        return pointer == System.IntPtr.Zero ? (VBloodTrackingChunkEntry) null : new VBloodTrackingChunkEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_VBloodChunkPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VBloodTrackingChunkEntry ShardBossChunkPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_ShardBossChunkPrefab));
        return pointer == System.IntPtr.Zero ? (VBloodTrackingChunkEntry) null : new VBloodTrackingChunkEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_ShardBossChunkPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SelectedUnitParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedUnitNameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitNameText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedUnitDescText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitDescText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitDescText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectedUnitLevelText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitLevelText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitLevelText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ImageFadeIn SelectedUnitImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitImage));
        return pointer == System.IntPtr.Zero ? (ImageFadeIn) null : new ImageFadeIn(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedUnitImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton BackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_BackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton TrackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_TrackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_TrackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText TrackButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_TrackButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_TrackButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton PrevEntryButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_PrevEntryButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_PrevEntryButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton NextEntryButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_NextEntryButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_NextEntryButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ImageFadeSwap BackgroundImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_BackgroundImage));
        return pointer == System.IntPtr.Zero ? (ImageFadeSwap) null : new ImageFadeSwap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public SpriteMaterialCombo TreeBackground
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_TreeBackground);
        return new SpriteMaterialCombo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_TreeBackground), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public SpriteMaterialCombo SelectedBackground
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedBackground);
        return new SpriteMaterialCombo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedBackground), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Material Large_VBloodIcon_Material_Standard
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_Large_VBloodIcon_Material_Standard));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_Large_VBloodIcon_Material_Standard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material Large_VBloodIcon_Material_Effect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_Large_VBloodIcon_Material_Effect));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_Large_VBloodIcon_Material_Effect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText StatusText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StatusText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color StatusTextNormalColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StatusTextNormalColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StatusTextNormalColor)) = value;
      }
    }

    public unsafe Color StatusTextErrorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StatusTextErrorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StatusTextErrorColor)) = value;
      }
    }

    public unsafe LocalizedText SelectedDistanceText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedDistanceText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SelectedDistanceText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform RewardsRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_RewardsRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_RewardsRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UnlockPowersParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnlockPowersRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UnlockSpellsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnlockSpellsRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UnlockRecipesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnlockRecipesRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup UnlockBlueprintsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform UnlockBlueprintsRoot
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsRoot));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ResearchEntry UnlockPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPrefab));
        return pointer == System.IntPtr.Zero ? (ResearchEntry) null : new ResearchEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite UnknownIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnknownIcon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnknownIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_Back
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_Back));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_Back)) = value;
      }
    }

    public unsafe LocalizationKey LK_StartTracking
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_StartTracking));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_StartTracking)) = value;
      }
    }

    public unsafe LocalizationKey LK_StopTracking
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_StopTracking));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_StopTracking)) = value;
      }
    }

    public unsafe LocalizationKey LK_TrackingNotUnlocked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_TrackingNotUnlocked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_TrackingNotUnlocked)) = value;
      }
    }

    public unsafe LocalizationKey LK_NotTrackable
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_NotTrackable));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_NotTrackable)) = value;
      }
    }

    public unsafe LocalizationKey LK_Distance
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_Distance));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_Distance)) = value;
      }
    }

    public unsafe LocalizationKey LK_DirectionAndDistance
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_DirectionAndDistance));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_DirectionAndDistance)) = value;
      }
    }

    public unsafe LocalizationKey LK_StandardVBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_StandardVBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_StandardVBlood)) = value;
      }
    }

    public unsafe LocalizationKey LK_ShardBossVBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_ShardBossVBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_ShardBossVBlood)) = value;
      }
    }

    public unsafe LocalizationKey LK_VbloodLevel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_VbloodLevel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_VbloodLevel)) = value;
      }
    }

    public unsafe LocalizationKey LK_PlayerLevel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_PlayerLevel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_LK_PlayerLevel)) = value;
      }
    }

    public unsafe float RewardsMotionsStartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_RewardsMotionsStartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_RewardsMotionsStartTime)) = value;
      }
    }

    public unsafe float RewardsMotionsStepTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_RewardsMotionsStepTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_RewardsMotionsStepTime)) = value;
      }
    }

    public unsafe Motion2DBinding SpellsBindings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SpellsBindings));
        return pointer == System.IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_SpellsBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding PowersBindings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_PowersBindings));
        return pointer == System.IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_PowersBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding StructuresBindings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StructuresBindings));
        return pointer == System.IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_StructuresBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding RecipesBindings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_RecipesBindings));
        return pointer == System.IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_RecipesBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public FmodEvent FE_UnlockStep
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockStep);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockStep), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public FmodEvent FE_UnlockSpells
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockSpells);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockSpells), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public FmodEvent FE_UnlockPowers
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockPowers);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockPowers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public FmodEvent FE_UnlockStructurs
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockStructurs);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockStructurs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public FmodEvent FE_UnlockRecipes
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockRecipes);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FE_UnlockRecipes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe DirectionKeysAsset DirectionKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_DirectionKeys));
        return pointer == System.IntPtr.Zero ? (DirectionKeysAsset) null : new DirectionKeysAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_DirectionKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform TooltipNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_TooltipNode));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_TooltipNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FakeTooltip FakeTooltip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FakeTooltip));
        return pointer == System.IntPtr.Zero ? (FakeTooltip) null : new FakeTooltip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_FakeTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_Passive
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_Sprite_Passive));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_Sprite_Passive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PlayerLevelText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_PlayerLevelText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_PlayerLevelText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform GearLevelInfoParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_GearLevelInfoParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_GearLevelInfoParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ResearchEntry, ResearchEntry.Data> UnlockPowersSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ResearchEntry, ResearchEntry.Data>) null : new GridSelectionGroup<ResearchEntry, ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockPowersSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ResearchEntry, ResearchEntry.Data> UnlockSpellsSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ResearchEntry, ResearchEntry.Data>) null : new GridSelectionGroup<ResearchEntry, ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockSpellsSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ResearchEntry, ResearchEntry.Data> UnlockRecipesSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ResearchEntry, ResearchEntry.Data>) null : new GridSelectionGroup<ResearchEntry, ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockRecipesSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ResearchEntry, ResearchEntry.Data> UnlockBlueprintsSelectionGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsSelectionGroup));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ResearchEntry, ResearchEntry.Data>) null : new GridSelectionGroup<ResearchEntry, ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenu.NativeFieldInfoPtr_UnlockBlueprintsSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
