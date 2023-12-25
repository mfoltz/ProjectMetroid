// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodTrackingChunkEntry
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
  public class VBloodTrackingChunkEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Trunk_Trail_Active_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_Trunk_Trail_Active_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_Trunk_Trail_Active_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_Trunk_Trail_Disabled_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_Trunk_Trail_Disabled_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_Trunk_Trail_Disabled_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_Branch_Trail_Active_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_Branch_Trail_Active_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_Branch_Trail_Active_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_Branch_Trail_Disabled_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_Branch_Trail_Disabled_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_Branch_Trail_Disabled_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_BranchL_Trail_Image_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_BranchL_Trail_Image_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_BranchL_Trail_Image_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_BranchR_Trail_Image_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_BranchR_Trail_Image_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_BranchR_Trail_Image_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActBranchL_Trail_Image_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActBranchL_Trail_Image_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActBranchL_Trail_Image_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActBranchR_Trail_Image_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActBranchR_Trail_Image_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActBranchR_Trail_Image_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrunkL_Trail_Image_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrunkL_Trail_Image_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrunkL_Trail_Image_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrunkR_Trail_Image_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrunkR_Trail_Image_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrunkR_Trail_Image_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActTrunkL_Trail_Image_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActTrunkL_Trail_Image_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActTrunkL_Trail_Image_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActTrunkR_Trail_Image_01;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActTrunkR_Trail_Image_02;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActTrunkR_Trail_Image_03;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActFull;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowActNumberAsRoman;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodUnitPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowHiddenLevels;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrunkRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrunkLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelHeaderColorNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelValueColorNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelDividerColorNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelHeaderColorHidden;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelValueColorHidden;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelDividerColorHidden;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ActValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_LevelValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GearLevelDiffHigher;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GearLevelDiffLower;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GearLevelLow;
    private static readonly System.IntPtr NativeFieldInfoPtr_DifficultyKey_0;
    private static readonly System.IntPtr NativeFieldInfoPtr_DifficultyKey_1;
    private static readonly System.IntPtr NativeFieldInfoPtr_DifficultyKey_2;
    private static readonly System.IntPtr NativeFieldInfoPtr_DifficultyKey_3;
    private static readonly System.IntPtr NativeFieldInfoPtr_DifficultyKey_4;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodsGridSelectionGroupR;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodsGridSelectionGroupL;
    private static readonly System.IntPtr NativeFieldInfoPtr__VBloods;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActRomanNumeralText;
    private static readonly System.IntPtr NativeFieldInfoPtr__LevelText;
    private static readonly System.IntPtr NativeFieldInfoPtr__LevelDiffText;
    private static readonly System.IntPtr NativeFieldInfoPtr_levelTierLess;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelTierAbove1;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelTierAbove2;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLevelDiff_Private_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRightEntryClicked_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLeftEntryClicked_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryClicked_Private_Void_Int32_VBloodTrackingUnitEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActData_Public_Void_Int32_VBloodTrackerEntryChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_List_1_VBloodTrackingEntry_PrefabGUID_VBloodTrackerEntryChunk_GameDataSystem_UIAssetSubSceneLoader_ClientWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_List_1_VBloodTrackingEntry_PrefabGUID_VBloodTrackerEntryChunk_GameDataSystem_UIAssetSubSceneLoader_ClientWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263397, XrefRangeEnd = 1263464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int GetLevelDiff(int vbloodGroupLevel, int playerLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &vbloodGroupLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &playerLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr_GetLevelDiff_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263464, XrefRangeEnd = 1263470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnRightEntryClicked(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr_OnRightEntryClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263470, XrefRangeEnd = 1263476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnLeftEntryClicked(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr_OnLeftEntryClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263476, XrefRangeEnd = 1263479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnEntryClicked(int index, VBloodTrackingUnitEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr__OnEntryClicked_Private_Void_Int32_VBloodTrackingUnitEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263517, RefRangeEnd = 1263518, XrefRangeStart = 1263479, XrefRangeEnd = 1263517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetActData(int index, VBloodTrackerEntryChunk entryChunk)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entryChunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr_SetActData_Public_Void_Int32_VBloodTrackerEntryChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263703, RefRangeEnd = 1263704, XrefRangeStart = 1263518, XrefRangeEnd = 1263703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      int index,
      List<VBloodTrackingEntry> vBloods,
      PrefabGUID activeTrackGuid,
      VBloodTrackerEntryChunk entryChunk,
      GameDataSystem gameDataSystem,
      UIAssetSubSceneLoader_ClientWorld uiAssetSubSceneLoader)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vBloods);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &activeTrackGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entryChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) uiAssetSubSceneLoader);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr_SetData_Public_Void_Int32_List_1_VBloodTrackingEntry_PrefabGUID_VBloodTrackerEntryChunk_GameDataSystem_UIAssetSubSceneLoader_ClientWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263740, RefRangeEnd = 1263741, XrefRangeStart = 1263704, XrefRangeEnd = 1263740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      List<VBloodTrackingEntry> vBloods,
      PrefabGUID activeTrackGuid,
      VBloodTrackerEntryChunk entryChunk,
      GameDataSystem gameDataSystem,
      UIAssetSubSceneLoader_ClientWorld uiAssetSubSceneLoader)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vBloods);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeTrackGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entryChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) uiAssetSubSceneLoader);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr_SetData_Public_Void_List_1_VBloodTrackingEntry_PrefabGUID_VBloodTrackerEntryChunk_GameDataSystem_UIAssetSubSceneLoader_ClientWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263741, XrefRangeEnd = 1263749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodTrackingChunkEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodTrackingChunkEntry()
    {
      Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodTrackingChunkEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr);
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Trunk_Trail_Active_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Trunk_Trail_Active_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Trunk_Trail_Active_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Trunk_Trail_Disabled_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Trunk_Trail_Disabled_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Trunk_Trail_Disabled_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Branch_Trail_Active_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Branch_Trail_Active_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Branch_Trail_Active_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Branch_Trail_Disabled_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Branch_Trail_Disabled_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (Branch_Trail_Disabled_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (BranchL_Trail_Image_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (BranchL_Trail_Image_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (BranchL_Trail_Image_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (BranchR_Trail_Image_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (BranchR_Trail_Image_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (BranchR_Trail_Image_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActBranchL_Trail_Image_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActBranchL_Trail_Image_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActBranchL_Trail_Image_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActBranchR_Trail_Image_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActBranchR_Trail_Image_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActBranchR_Trail_Image_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (TrunkL_Trail_Image_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (TrunkL_Trail_Image_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (TrunkL_Trail_Image_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (TrunkR_Trail_Image_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (TrunkR_Trail_Image_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (TrunkR_Trail_Image_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActTrunkL_Trail_Image_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActTrunkL_Trail_Image_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActTrunkL_Trail_Image_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActTrunkR_Trail_Image_01));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActTrunkR_Trail_Image_02));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActTrunkR_Trail_Image_03));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ActFull));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ShowActNumberAsRoman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ShowActNumberAsRoman));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodUnitPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (VBloodUnitPrefab));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ShowHiddenLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ShowHiddenLevels));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (TrunkRight));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (TrunkLeft));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelHeaderColorNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LevelHeaderColorNormal));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelValueColorNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LevelValueColorNormal));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelDividerColorNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LevelDividerColorNormal));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelHeaderColorHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LevelHeaderColorHidden));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelValueColorHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LevelValueColorHidden));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelDividerColorHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LevelDividerColorHidden));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_ColorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (ColorSettings));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_ActValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LK_ActValue));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_LevelValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LK_LevelValue));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelDiffHigher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LK_GearLevelDiffHigher));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelDiffLower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LK_GearLevelDiffLower));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LK_GearLevelLow));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (DifficultyKey_0));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (DifficultyKey_1));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (DifficultyKey_2));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (DifficultyKey_3));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (DifficultyKey_4));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_OnEntryClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (OnEntryClicked));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodsGridSelectionGroupR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (VBloodsGridSelectionGroupR));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodsGridSelectionGroupL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (VBloodsGridSelectionGroupL));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr__VBloods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (_VBloods));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr__ActRomanNumeralText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (_ActRomanNumeralText));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr__LevelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (_LevelText));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr__LevelDiffText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (_LevelDiffText));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_levelTierLess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (levelTierLess));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelTierAbove1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LevelTierAbove1));
      VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelTierAbove2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, nameof (LevelTierAbove2));
      VBloodTrackingChunkEntry.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667460);
      VBloodTrackingChunkEntry.NativeMethodInfoPtr_GetLevelDiff_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667461);
      VBloodTrackingChunkEntry.NativeMethodInfoPtr_OnRightEntryClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667462);
      VBloodTrackingChunkEntry.NativeMethodInfoPtr_OnLeftEntryClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667463);
      VBloodTrackingChunkEntry.NativeMethodInfoPtr__OnEntryClicked_Private_Void_Int32_VBloodTrackingUnitEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667464);
      VBloodTrackingChunkEntry.NativeMethodInfoPtr_SetActData_Public_Void_Int32_VBloodTrackerEntryChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667465);
      VBloodTrackingChunkEntry.NativeMethodInfoPtr_SetData_Public_Void_Int32_List_1_VBloodTrackingEntry_PrefabGUID_VBloodTrackerEntryChunk_GameDataSystem_UIAssetSubSceneLoader_ClientWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667466);
      VBloodTrackingChunkEntry.NativeMethodInfoPtr_SetData_Public_Void_List_1_VBloodTrackingEntry_PrefabGUID_VBloodTrackerEntryChunk_GameDataSystem_UIAssetSubSceneLoader_ClientWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667467);
      VBloodTrackingChunkEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, 100667468);
    }

    public VBloodTrackingChunkEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Sprite Trunk_Trail_Active_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_01));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Trunk_Trail_Active_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_02));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Trunk_Trail_Active_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_03));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Active_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Trunk_Trail_Disabled_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_01));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Trunk_Trail_Disabled_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_02));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Trunk_Trail_Disabled_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_03));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Trunk_Trail_Disabled_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Branch_Trail_Active_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_01));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Branch_Trail_Active_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_02));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Branch_Trail_Active_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_03));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Active_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Branch_Trail_Disabled_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_01));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Branch_Trail_Disabled_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_02));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Branch_Trail_Disabled_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_03));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_Branch_Trail_Disabled_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BranchL_Trail_Image_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_01));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BranchL_Trail_Image_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_02));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BranchL_Trail_Image_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_03));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchL_Trail_Image_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BranchR_Trail_Image_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_01));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BranchR_Trail_Image_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_02));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BranchR_Trail_Image_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_03));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_BranchR_Trail_Image_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActBranchL_Trail_Image_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_01));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActBranchL_Trail_Image_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_02));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActBranchL_Trail_Image_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_03));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchL_Trail_Image_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActBranchR_Trail_Image_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_01));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActBranchR_Trail_Image_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_02));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActBranchR_Trail_Image_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_03));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActBranchR_Trail_Image_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image TrunkL_Trail_Image_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_01));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image TrunkL_Trail_Image_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_02));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image TrunkL_Trail_Image_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_03));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkL_Trail_Image_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image TrunkR_Trail_Image_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_01));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image TrunkR_Trail_Image_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_02));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image TrunkR_Trail_Image_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_03));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkR_Trail_Image_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActTrunkL_Trail_Image_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_01));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActTrunkL_Trail_Image_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_02));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActTrunkL_Trail_Image_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_03));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkL_Trail_Image_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActTrunkR_Trail_Image_01
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_01));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_01), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActTrunkR_Trail_Image_02
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_02));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_02), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ActTrunkR_Trail_Image_03
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_03));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActTrunkR_Trail_Image_03), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ActData ActFull
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActFull);
        return new ActData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ActFull), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ActData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool ShowActNumberAsRoman
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ShowActNumberAsRoman));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ShowActNumberAsRoman)) = value;
      }
    }

    public unsafe VBloodTrackingUnitEntry VBloodUnitPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodUnitPrefab));
        return pointer == System.IntPtr.Zero ? (VBloodTrackingUnitEntry) null : new VBloodTrackingUnitEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodUnitPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool ShowHiddenLevels
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ShowHiddenLevels));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ShowHiddenLevels)) = value;
      }
    }

    public TrunkData TrunkRight
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkRight);
        return new TrunkData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkRight), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TrunkData TrunkLeft
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkLeft);
        return new TrunkData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_TrunkLeft), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TrunkData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Color LevelHeaderColorNormal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelHeaderColorNormal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelHeaderColorNormal)) = value;
      }
    }

    public unsafe Color LevelValueColorNormal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelValueColorNormal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelValueColorNormal)) = value;
      }
    }

    public unsafe Color LevelDividerColorNormal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelDividerColorNormal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelDividerColorNormal)) = value;
      }
    }

    public unsafe Color LevelHeaderColorHidden
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelHeaderColorHidden));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelHeaderColorHidden)) = value;
      }
    }

    public unsafe Color LevelValueColorHidden
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelValueColorHidden));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelValueColorHidden)) = value;
      }
    }

    public unsafe Color LevelDividerColorHidden
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelDividerColorHidden));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelDividerColorHidden)) = value;
      }
    }

    public unsafe CharacterHUDSettings ColorSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ColorSettings));
        return pointer == System.IntPtr.Zero ? (CharacterHUDSettings) null : new CharacterHUDSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_ColorSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_ActValue
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_ActValue));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_ActValue)) = value;
      }
    }

    public unsafe LocalizationKey LK_LevelValue
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_LevelValue));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_LevelValue)) = value;
      }
    }

    public unsafe LocalizationKey LK_GearLevelDiffHigher
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelDiffHigher));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelDiffHigher)) = value;
      }
    }

    public unsafe LocalizationKey LK_GearLevelDiffLower
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelDiffLower));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelDiffLower)) = value;
      }
    }

    public unsafe LocalizationKey LK_GearLevelLow
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelLow));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LK_GearLevelLow)) = value;
      }
    }

    public unsafe LocalizationKey DifficultyKey_0
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_0));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_0)) = value;
      }
    }

    public unsafe LocalizationKey DifficultyKey_1
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_1));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_1)) = value;
      }
    }

    public unsafe LocalizationKey DifficultyKey_2
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_2));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_2)) = value;
      }
    }

    public unsafe LocalizationKey DifficultyKey_3
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_3));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_3)) = value;
      }
    }

    public unsafe LocalizationKey DifficultyKey_4
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_4));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_DifficultyKey_4)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<PrefabGUID, VBloodUnitTrackingState> OnEntryClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_OnEntryClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<PrefabGUID, VBloodUnitTrackingState>) null : new Il2CppSystem.Action<PrefabGUID, VBloodUnitTrackingState>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_OnEntryClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data> VBloodsGridSelectionGroupR
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodsGridSelectionGroupR));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data>) null : new GridSelectionGroup<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodsGridSelectionGroupR), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data> VBloodsGridSelectionGroupL
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodsGridSelectionGroupL));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data>) null : new GridSelectionGroup<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_VBloodsGridSelectionGroupL), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<VBloodTrackingUnitEntry.Data> _VBloods
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr__VBloods));
        return pointer == System.IntPtr.Zero ? (List<VBloodTrackingUnitEntry.Data>) null : new List<VBloodTrackingUnitEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr__VBloods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public MemoizedRomanNumeralText _ActRomanNumeralText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr__ActRomanNumeralText);
        return new MemoizedRomanNumeralText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr__ActRomanNumeralText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedRomanNumeralText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MemoizedIntegerText _LevelText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr__LevelText);
        return new MemoizedIntegerText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr__LevelText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MemoizedIntegerText _LevelDiffText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr__LevelDiffText);
        return new MemoizedIntegerText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr__LevelDiffText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedIntegerText>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int levelTierLess
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_levelTierLess));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_levelTierLess)) = value;
      }
    }

    public unsafe int LevelTierAbove1
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelTierAbove1));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelTierAbove1)) = value;
      }
    }

    public unsafe int LevelTierAbove2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelTierAbove2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingChunkEntry.NativeFieldInfoPtr_LevelTierAbove2)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.VBloodTrackingChunkEntry/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__69_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__69_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__69_0_Internal_Void_VBloodTrackingUnitEntry_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__InitializeUI_b__69_1_Internal_Void_VBloodTrackingUnitEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263396, XrefRangeEnd = 1263397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _InitializeUI_b__69_0(
        VBloodTrackingUnitEntry entry,
        VBloodTrackingUnitEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.__c.NativeMethodInfoPtr__InitializeUI_b__69_0_Internal_Void_VBloodTrackingUnitEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _InitializeUI_b__69_1(
        VBloodTrackingUnitEntry entry,
        VBloodTrackingUnitEntry.Data data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodTrackingChunkEntry.__c.NativeMethodInfoPtr__InitializeUI_b__69_1_Internal_Void_VBloodTrackingUnitEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodTrackingChunkEntry>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr);
        VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr, "<>9");
        VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9__69_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr, "<>9__69_0");
        VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9__69_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr, "<>9__69_1");
        VBloodTrackingChunkEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr, 100667470);
        VBloodTrackingChunkEntry.__c.NativeMethodInfoPtr__InitializeUI_b__69_0_Internal_Void_VBloodTrackingUnitEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr, 100667471);
        VBloodTrackingChunkEntry.__c.NativeMethodInfoPtr__InitializeUI_b__69_1_Internal_Void_VBloodTrackingUnitEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingChunkEntry.__c>.NativeClassPtr, 100667472);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe VBloodTrackingChunkEntry.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VBloodTrackingChunkEntry.__c) null : new VBloodTrackingChunkEntry.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data> __9__69_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9__69_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data>) null : new Il2CppSystem.Action<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9__69_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data> __9__69_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9__69_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data>) null : new Il2CppSystem.Action<VBloodTrackingUnitEntry, VBloodTrackingUnitEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VBloodTrackingChunkEntry.__c.NativeFieldInfoPtr___9__69_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
