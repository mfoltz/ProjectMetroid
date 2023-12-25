// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodTrackingMenuMapperSystem
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
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.UI
{
  public class VBloodTrackingMenuMapperSystem : FullscreenMenuViewMapperSystem<VBloodTrackingMenu>
  {
    private static readonly IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__GetVBloodsPositionResponseSystem;
    private static readonly IntPtr NativeFieldInfoPtr__BloodAltarOnDemandSystem;
    private static readonly IntPtr NativeFieldInfoPtr__VBloods;
    private static readonly IntPtr NativeFieldInfoPtr__EntryChunks;
    private static readonly IntPtr NativeFieldInfoPtr__UnlockPowersData;
    private static readonly IntPtr NativeFieldInfoPtr__UnlockSpellsData;
    private static readonly IntPtr NativeFieldInfoPtr__UnlockStructuresData;
    private static readonly IntPtr NativeFieldInfoPtr__UnlockRecipesData;
    private static readonly IntPtr NativeFieldInfoPtr__VBloodTrackingChunkEntries;
    private static readonly IntPtr NativeFieldInfoPtr__ShardBossTrackingChunkEntries;
    private static readonly IntPtr NativeFieldInfoPtr__BuffQuery;
    private static readonly IntPtr NativeFieldInfoPtr__SelectedVBloodUnit;
    private static readonly IntPtr NativeFieldInfoPtr__ActiveTrackGuid;
    private static readonly IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly IntPtr NativeFieldInfoPtr__UIAssetSubSceneLoader;
    private static readonly IntPtr NativeFieldInfoPtr__VBloodPositionsRequestData;
    private static readonly IntPtr NativeFieldInfoPtr__SelectedTabIndex;
    private static readonly IntPtr NativeFieldInfoPtr__HighlightHelper;
    private static readonly IntPtr NativeFieldInfoPtr__MotionStartTime;
    private static readonly IntPtr NativeFieldInfoPtr_MIN_REQ_INTERVAL;
    private static readonly IntPtr NativeFieldInfoPtr_MAX_REQ_INTERVAL;
    private static readonly IntPtr NativeFieldInfoPtr__PrevSelectedUnit;
    private static readonly IntPtr NativeFieldInfoPtr__FirstTimeSeen;
    private static readonly IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNextAvailableVBloodEntry_Private_PrefabGUID_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPrevAvailableVBloodEntry_Private_PrefabGUID_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsVBloodEntryAvailable_Private_Boolean_GameDataSystem_Entity_Single_Int32_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPlayerLevel_Private_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetEntryIndex_Private_Int32_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_TrySendCompleteQuest_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnMenuDisabled_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_InitHighlightHelper_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RefreshVBloodRequest_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RefreshTabs_Private_Void_GameDataSystem_PrefabCollectionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectedUnit_Private_Void_GameDataSystem_PrefabCollectionSystem_GetVBloodsPositionResponseSystem_List_1_VBloodTrackingEntry_PrefabGUID_float2_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateVisualState_Private_Void_VBloodTrackingState_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetSpriteAndMaterial_Private_Void_ImageFadeSwap_SpriteMaterialCombo_0;
    private static readonly IntPtr NativeMethodInfoPtr_RefreshRewards_Private_Void_GameDataSystem_PrefabLookupMap_Entity_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_AlreadyAdded_Private_Boolean_List_1_Data_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnVBloodUnitEntryClicked_Private_Void_PrefabGUID_VBloodUnitTrackingState_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetSelectedVBloodUnit_Private_Void_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_ClearSelectedVBloodUnit_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ResetSelectedVBloodState_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateEntryChunks_Private_Static_Void_List_1_VBloodTrackingEntry_List_1_VBloodTrackerEntryChunk_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SortVBloodTrackingEntryByLevel_Private_Int32_VBloodTrackingEntry_VBloodTrackingEntry_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_0_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_1_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_2_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_3_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_4_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_5_Private_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__35_0_Private_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263871, XrefRangeEnd = 1263874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref blockInputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263874, XrefRangeEnd = 1263876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &inputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263876, XrefRangeEnd = 1263919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnMenuCreated()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263978, RefRangeEnd = 1263979, XrefRangeStart = 1263919, XrefRangeEnd = 1263978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263979, XrefRangeEnd = 1264006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnMenuEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1264017, RefRangeEnd = 1264018, XrefRangeStart = 1264006, XrefRangeEnd = 1264017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetNextAvailableVBloodEntry(PrefabGUID selectedVBloodUnit)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &selectedVBloodUnit;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetNextAvailableVBloodEntry_Private_PrefabGUID_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1264026, RefRangeEnd = 1264027, XrefRangeStart = 1264018, XrefRangeEnd = 1264026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrevAvailableVBloodEntry(PrefabGUID selectedVBloodUnit)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &selectedVBloodUnit;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetPrevAvailableVBloodEntry_Private_PrefabGUID_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1264033, RefRangeEnd = 1264037, XrefRangeStart = 1264027, XrefRangeEnd = 1264033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsVBloodEntryAvailable(
      GameDataSystem gameDataSystem,
      Entity progressionEntity,
      float playerLevel,
      int entryLevel,
      PrefabGUID entryId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &progressionEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &playerLevel;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &entryLevel;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &entryId;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_IsVBloodEntryAvailable_Private_Boolean_GameDataSystem_Entity_Single_Int32_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1264043, RefRangeEnd = 1264046, XrefRangeStart = 1264037, XrefRangeEnd = 1264043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetPlayerLevel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetPlayerLevel_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1264051, RefRangeEnd = 1264053, XrefRangeStart = 1264046, XrefRangeEnd = 1264051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetEntryIndex(PrefabGUID entryId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &entryId;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetEntryIndex_Private_Int32_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264053, XrefRangeEnd = 1264065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrySendCompleteQuest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_TrySendCompleteQuest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264065, XrefRangeEnd = 1264067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnMenuDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnMenuDisabled_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264067, XrefRangeEnd = 1264287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264287, XrefRangeEnd = 1264297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitHighlightHelper()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_InitHighlightHelper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264297, XrefRangeEnd = 1264300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshVBloodRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_RefreshVBloodRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1264319, RefRangeEnd = 1264320, XrefRangeStart = 1264300, XrefRangeEnd = 1264319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshTabs(
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_RefreshTabs_Private_Void_GameDataSystem_PrefabCollectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1222284, RefRangeEnd = 1222285, XrefRangeStart = 1222284, XrefRangeEnd = 1222285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetLocalPlayer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1264415, RefRangeEnd = 1264416, XrefRangeStart = 1264320, XrefRangeEnd = 1264415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSelectedUnit(
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      GetVBloodsPositionResponseSystem vBloodsPosition,
      List<VBloodTrackingEntry> vBloods,
      PrefabGUID selectedUnitPrefabGuid,
      float2 playerPosition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vBloodsPosition);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vBloods);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &selectedUnitPrefabGuid;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &playerPosition;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_UpdateSelectedUnit_Private_Void_GameDataSystem_PrefabCollectionSystem_GetVBloodsPositionResponseSystem_List_1_VBloodTrackingEntry_PrefabGUID_float2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1264427, RefRangeEnd = 1264429, XrefRangeStart = 1264416, XrefRangeEnd = 1264427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateVisualState(VBloodTrackingState state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &state;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_UpdateVisualState_Private_Void_VBloodTrackingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264429, XrefRangeEnd = 1264434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSpriteAndMaterial(ImageFadeSwap imageFadeSpawn, SpriteMaterialCombo combo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) imageFadeSpawn);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) combo));
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_SetSpriteAndMaterial_Private_Void_ImageFadeSwap_SpriteMaterialCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1264757, RefRangeEnd = 1264758, XrefRangeStart = 1264434, XrefRangeEnd = 1264757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshRewards(
      GameDataSystem gameDataSystem,
      PrefabLookupMap prefabLookupMap,
      Entity huntEntity,
      bool isUnlocked)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &huntEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &isUnlocked;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_RefreshRewards_Private_Void_GameDataSystem_PrefabLookupMap_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1264775, RefRangeEnd = 1264776, XrefRangeStart = 1264758, XrefRangeEnd = 1264775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AlreadyAdded(List<ResearchEntry.Data> unlockData, PrefabGUID guid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &guid;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_AlreadyAdded_Private_Boolean_List_1_Data_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264776, XrefRangeEnd = 1264777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnVBloodUnitEntryClicked(
      PrefabGUID unitPrefabGuid,
      VBloodUnitTrackingState unitState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &unitPrefabGuid;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &unitState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnVBloodUnitEntryClicked_Private_Void_PrefabGUID_VBloodUnitTrackingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1264788, RefRangeEnd = 1264792, XrefRangeStart = 1264777, XrefRangeEnd = 1264788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSelectedVBloodUnit(PrefabGUID unitPrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &unitPrefabGuid;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_SetSelectedVBloodUnit_Private_Void_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264792, XrefRangeEnd = 1264793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearSelectedVBloodUnit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_ClearSelectedVBloodUnit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264793, XrefRangeEnd = 1264804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetSelectedVBloodState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_ResetSelectedVBloodState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1264818, RefRangeEnd = 1264819, XrefRangeStart = 1264804, XrefRangeEnd = 1264818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateEntryChunks(
      List<VBloodTrackingEntry> vBloods,
      List<VBloodTrackerEntryChunk> entryChunks,
      int playerLevel)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vBloods);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entryChunks);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &playerLevel;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_UpdateEntryChunks_Private_Static_Void_List_1_VBloodTrackingEntry_List_1_VBloodTrackerEntryChunk_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int SortVBloodTrackingEntryByLevel(VBloodTrackingEntry x, VBloodTrackingEntry y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &x;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &y;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_SortVBloodTrackingEntryByLevel_Private_Int32_VBloodTrackingEntry_VBloodTrackingEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264819, XrefRangeEnd = 1264858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodTrackingMenuMapperSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__24_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264858, XrefRangeEnd = 1264879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__24_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264879, XrefRangeEnd = 1264881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__24_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264881, XrefRangeEnd = 1264883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__24_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264883, XrefRangeEnd = 1264885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__24_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Initialize_b__24_5(int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &itemIndex;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_5_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264885, XrefRangeEnd = 1264891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__35_0(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &index;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__OnUpdate_b__35_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264891, XrefRangeEnd = 1264894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodTrackingMenuMapperSystem()
    {
      Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodTrackingMenuMapperSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr);
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_UIDataSystem));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__GetVBloodsPositionResponseSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_GetVBloodsPositionResponseSystem));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__BloodAltarOnDemandSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_BloodAltarOnDemandSystem));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_VBloods));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__EntryChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_EntryChunks));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockPowersData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_UnlockPowersData));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockSpellsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_UnlockSpellsData));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockStructuresData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_UnlockStructuresData));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockRecipesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_UnlockRecipesData));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloodTrackingChunkEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_VBloodTrackingChunkEntries));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__ShardBossTrackingChunkEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_ShardBossTrackingChunkEntries));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__BuffQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_BuffQuery));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__SelectedVBloodUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_SelectedVBloodUnit));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__ActiveTrackGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_ActiveTrackGuid));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_InputSystem));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_UIAssetSubSceneLoader));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloodPositionsRequestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_VBloodPositionsRequestData));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__SelectedTabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_SelectedTabIndex));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__HighlightHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_HighlightHelper));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__MotionStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_MotionStartTime));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr_MIN_REQ_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (MIN_REQ_INTERVAL));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr_MAX_REQ_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (MAX_REQ_INTERVAL));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__PrevSelectedUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_PrevSelectedUnit));
      VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__FirstTimeSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, nameof (_FirstTimeSeen));
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667485);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667486);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnMenuCreated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667487);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667488);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667489);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetNextAvailableVBloodEntry_Private_PrefabGUID_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667490);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetPrevAvailableVBloodEntry_Private_PrefabGUID_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667491);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_IsVBloodEntryAvailable_Private_Boolean_GameDataSystem_Entity_Single_Int32_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667492);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetPlayerLevel_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667493);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetEntryIndex_Private_Int32_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667494);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_TrySendCompleteQuest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667495);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnMenuDisabled_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667496);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667497);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_InitHighlightHelper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667498);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_RefreshVBloodRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667499);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_RefreshTabs_Private_Void_GameDataSystem_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667500);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667501);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_UpdateSelectedUnit_Private_Void_GameDataSystem_PrefabCollectionSystem_GetVBloodsPositionResponseSystem_List_1_VBloodTrackingEntry_PrefabGUID_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667502);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_UpdateVisualState_Private_Void_VBloodTrackingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667503);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_SetSpriteAndMaterial_Private_Void_ImageFadeSwap_SpriteMaterialCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667504);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_RefreshRewards_Private_Void_GameDataSystem_PrefabLookupMap_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667505);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_AlreadyAdded_Private_Boolean_List_1_Data_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667506);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnVBloodUnitEntryClicked_Private_Void_PrefabGUID_VBloodUnitTrackingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667507);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_SetSelectedVBloodUnit_Private_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667508);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_ClearSelectedVBloodUnit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667509);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_ResetSelectedVBloodState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667510);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_UpdateEntryChunks_Private_Static_Void_List_1_VBloodTrackingEntry_List_1_VBloodTrackerEntryChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667511);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_SortVBloodTrackingEntryByLevel_Private_Int32_VBloodTrackingEntry_VBloodTrackingEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667512);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667513);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667514);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667515);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667516);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667517);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667518);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__Initialize_b__24_5_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667519);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr__OnUpdate_b__35_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667520);
      VBloodTrackingMenuMapperSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingMenuMapperSystem>.NativeClassPtr, 100667521);
    }

    public VBloodTrackingMenuMapperSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UIDataSystem));
        return pointer == IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GetVBloodsPositionResponseSystem _GetVBloodsPositionResponseSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__GetVBloodsPositionResponseSystem));
        return pointer == IntPtr.Zero ? (GetVBloodsPositionResponseSystem) null : new GetVBloodsPositionResponseSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__GetVBloodsPositionResponseSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BloodAltarSystem_ConvertVBloodsOnDemand _BloodAltarOnDemandSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__BloodAltarOnDemandSystem));
        return pointer == IntPtr.Zero ? (BloodAltarSystem_ConvertVBloodsOnDemand) null : new BloodAltarSystem_ConvertVBloodsOnDemand(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__BloodAltarOnDemandSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<VBloodTrackingEntry> _VBloods
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloods));
        return pointer == IntPtr.Zero ? (List<VBloodTrackingEntry>) null : new List<VBloodTrackingEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<VBloodTrackerEntryChunk> _EntryChunks
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__EntryChunks));
        return pointer == IntPtr.Zero ? (List<VBloodTrackerEntryChunk>) null : new List<VBloodTrackerEntryChunk>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__EntryChunks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ResearchEntry.Data> _UnlockPowersData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockPowersData));
        return pointer == IntPtr.Zero ? (List<ResearchEntry.Data>) null : new List<ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockPowersData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ResearchEntry.Data> _UnlockSpellsData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockSpellsData));
        return pointer == IntPtr.Zero ? (List<ResearchEntry.Data>) null : new List<ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockSpellsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ResearchEntry.Data> _UnlockStructuresData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockStructuresData));
        return pointer == IntPtr.Zero ? (List<ResearchEntry.Data>) null : new List<ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockStructuresData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ResearchEntry.Data> _UnlockRecipesData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockRecipesData));
        return pointer == IntPtr.Zero ? (List<ResearchEntry.Data>) null : new List<ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UnlockRecipesData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<VBloodTrackingChunkEntry> _VBloodTrackingChunkEntries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloodTrackingChunkEntries));
        return pointer == IntPtr.Zero ? (UI_Cache<VBloodTrackingChunkEntry>) null : new UI_Cache<VBloodTrackingChunkEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloodTrackingChunkEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<VBloodTrackingChunkEntry> _ShardBossTrackingChunkEntries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__ShardBossTrackingChunkEntries));
        return pointer == IntPtr.Zero ? (UI_Cache<VBloodTrackingChunkEntry>) null : new UI_Cache<VBloodTrackingChunkEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__ShardBossTrackingChunkEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _BuffQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__BuffQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__BuffQuery)) = value;
      }
    }

    public unsafe PrefabGUID _SelectedVBloodUnit
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__SelectedVBloodUnit));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__SelectedVBloodUnit)) = value;
      }
    }

    public unsafe PrefabGUID _ActiveTrackGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__ActiveTrackGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__ActiveTrackGuid)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__InputSystem));
        return pointer == IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIAssetSubSceneLoader_ClientWorld _UIAssetSubSceneLoader
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader));
        return pointer == IntPtr.Zero ? (UIAssetSubSceneLoader_ClientWorld) null : new UIAssetSubSceneLoader_ClientWorld(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VBloodPositionsRequestData _VBloodPositionsRequestData
    {
      get
      {
        return *(VBloodPositionsRequestData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloodPositionsRequestData));
      }
      [param: In] set
      {
        *(VBloodPositionsRequestData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__VBloodPositionsRequestData)) = value;
      }
    }

    public unsafe int _SelectedTabIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__SelectedTabIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__SelectedTabIndex)) = value;
      }
    }

    public unsafe UIHighlightHelper _HighlightHelper
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__HighlightHelper));
        return pointer == IntPtr.Zero ? (UIHighlightHelper) null : new UIHighlightHelper(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__HighlightHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _MotionStartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__MotionStartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__MotionStartTime)) = value;
      }
    }

    public static unsafe float MIN_REQ_INTERVAL
    {
      get
      {
        float minReqInterval;
        IL2CPP.il2cpp_field_static_get_value(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr_MIN_REQ_INTERVAL, (void*) &minReqInterval);
        return minReqInterval;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr_MIN_REQ_INTERVAL, (void*) &value);
      }
    }

    public static unsafe float MAX_REQ_INTERVAL
    {
      get
      {
        float maxReqInterval;
        IL2CPP.il2cpp_field_static_get_value(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr_MAX_REQ_INTERVAL, (void*) &maxReqInterval);
        return maxReqInterval;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr_MAX_REQ_INTERVAL, (void*) &value);
      }
    }

    public unsafe PrefabGUID _PrevSelectedUnit
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__PrevSelectedUnit));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__PrevSelectedUnit)) = value;
      }
    }

    public unsafe bool _FirstTimeSeen
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__FirstTimeSeen));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingMenuMapperSystem.NativeFieldInfoPtr__FirstTimeSeen)) = value;
      }
    }
  }
}
