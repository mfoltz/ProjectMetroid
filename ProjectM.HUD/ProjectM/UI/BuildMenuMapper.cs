// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Tiles;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.UI
{
  public class BuildMenuMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedItemHashes;
    private static readonly System.IntPtr NativeFieldInfoPtr__Structures;
    private static readonly System.IntPtr NativeFieldInfoPtr__Requirements;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventoryContextEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventoryErrorEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildingCategoryData;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildingTagData;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildingVariationData;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedBlueprints;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildMenuQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildMenuOperation;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviewBuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputState;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputStateInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__ControllerLocalMousePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr__ControllerWorldMousePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIAssetSubSceneLoader;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedCategoryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedTagIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedVariationIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__CategoryPreviouslySelectedTag;
    private static readonly System.IntPtr NativeFieldInfoPtr__VariationSelectionWheel;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildingFromInventoryItem;
    private static readonly System.IntPtr NativeFieldInfoPtr__WallpaperOperationEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__WallpaperOperationEntityArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__CompositionPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr__HighlightHelper;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoredBlockReasons;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockReasonPriorities;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TempUpdatePick_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TempUpdatePick_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryFindBuildMenu_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryFindBuildMenu_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DoPlacementRequest_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DoPlacementRequestWithDebug_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_10;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_11;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_BuildMenuPickedEntity_12;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedCategory_Private_byref_BuildMenuCategoryBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedTag_Private_byref_BuildMenuTagBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetManagedCompositionData_Private_Boolean_byref_ManagedBuildMenuCompositionData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetManagedTagData_Private_Boolean_Int32_Int32_byref_ManagedBuildMenuTagData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetManagedCategoryData_Private_Boolean_Int32_byref_ManagedBuildMenuCategoryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCompositionBlob_Private_byref_BuildMenuCompositionBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleActionWheelInputDown_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleActionWheelInputUp_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateActionWheel_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWallpaperSelected_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTooltip_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartOrUpdateWallpaperOperation_Private_Void_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndWallpaperOperation_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TempUpdatePick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAtStartOfFrame_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedCategory_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedTag_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateViewedStructures_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnsureBuildMenuTagConverted_Private_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindBuildMenu_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBuildMenuEnabled_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBuildMenuDisabled_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableBuildingFromInventoryItem_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateControllerMousePosition_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindTransformTarget_Private_Void_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHoverTarget_Private_Void_Entity_byref_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEditableModelEffect_Private_Void_Entity_Entity_ObjectEditOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySelectHoverTarget_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetEditingEntity_Private_Boolean_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePreviewPlacementBuff_Private_Entity_Entity_Boolean_Boolean_Entity_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemovePreviewPlacementBuff_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoLineOfSightRequirementChecks_Private_Void_Entity_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlacementResult_Private_Void_Entity_Entity_IdentifiedPlacementOperation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryIdentifyPlacementOperation_Private_Boolean_Entity_Entity_ObjectEditOptions_byref_IdentifiedPlacementOperation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetColorCollection_Private_Boolean_Entity_byref_IColorCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWallpaperOrientation_Private_Boolean_Entity_byref_WallpaperOrientation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDyeableEntity_Private_Boolean_Entity_Boolean_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddStructureToUi_Private_Void_byref_BuildMenuStructureBlob_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBlueprintRequirements_Private_Void_Entity_Entity_PlacementResult_byref_MapZoneCollection_byref_ServerGameBalanceSettings_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildMenuSortingOrder_Private_Int32_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StructureContainsBlueprint_Private_Boolean_byref_BuildMenuStructureBlob_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StructureContainsBlueprint_Private_Boolean_byref_BuildMenuStructureBlob_NativeHashSet_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUnlockedBlueprints_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddResourceCosts_Private_Void_Entity_PlacementResult_Boolean_Double_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoInputs_Private_Void_Entity_ObjectEditOptions_BuildMenuPlacementOperation_Boolean_Entity_Entity_Boolean_PrefabGUID_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasItemBuildingInInventory_Public_Static_Boolean_EntityManager_PrefabLookupMap_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExitBuildModeWhenBuilt_Private_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlacementIfPrefabChanged_Private_Void_byref_PreviewPlacementBuff_Boolean_Entity_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCanMoveRotateOrDismantle_Private_Void_PreviewPlacementBuff_byref_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CancelEditing_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearEditing_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddStandardPlaceCancelRotateInputContexts_Private_Void_byref_PlacementResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInputContext_Private_Void_Entity_Entity_Boolean_Boolean_Boolean_PlacementResult_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdaterPlacementErrorText_Private_Void_PlacementResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddStandardBuildMenuError_Private_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePreviewPlacementSequences_Private_Void_PlacementResult_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareQuaternionAsTileRotation_Private_Static_Boolean_quaternion_quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Float4AlmostEquals_Private_Static_Boolean_float4_float4_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Float3AlmostEquals_Private_Static_Boolean_float3_float3_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FloatAlmostEquals_Private_Static_Boolean_Single_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBuildingCategories_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowCategory_Private_Boolean_byref_BuildMenuCategoryBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBuildingTags_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVariations_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowTag_Private_Boolean_byref_BuildMenuTagBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldHighlightButton_Private_Boolean_byref_BuildMenuTagBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldHighlightButton_Private_Boolean_byref_BuildMenuCategoryBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStartBuildingFromInventoryItem_Public_Void_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__51_0_Private_Void_Entity_byref_UICanvasBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryFindBuildMenu_b__64_0_Private_Void_Entity_BuildMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryFindBuildMenu_b__64_1_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryFindBuildMenu_b__64_2_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryFindBuildMenu_b__64_3_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_Entity_byref_IColorCollection_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_Entity_byref_IColorCollection_PDM_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTempUpdatePick_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTryFindBuildMenu_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedBlueprints_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedBlueprints_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224106, XrefRangeEnd = 1224110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BuildMenuCategoryBlob GetSelectedCategory()
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224110, XrefRangeEnd = 1224117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BuildMenuTagBlob GetSelectedTag()
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224117, XrefRangeEnd = 1224121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetManagedCompositionData(out ManagedBuildMenuCompositionData result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryGetManagedCompositionData_Private_Boolean_byref_ManagedBuildMenuCompositionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ManagedBuildMenuCompositionData local = ref result;
      System.IntPtr pointer = zero;
      ManagedBuildMenuCompositionData menuCompositionData = pointer == System.IntPtr.Zero ? (ManagedBuildMenuCompositionData) null : new ManagedBuildMenuCompositionData(pointer);
      local = menuCompositionData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224126, RefRangeEnd = 1224127, XrefRangeStart = 1224121, XrefRangeEnd = 1224126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetManagedTagData(
      int categoryIndex,
      int tagIndex,
      out ManagedBuildMenuTagData result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &categoryIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tagIndex;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryGetManagedTagData_Private_Boolean_Int32_Int32_byref_ManagedBuildMenuTagData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ManagedBuildMenuTagData local = ref result;
      System.IntPtr pointer = zero;
      ManagedBuildMenuTagData buildMenuTagData = pointer == System.IntPtr.Zero ? (ManagedBuildMenuTagData) null : new ManagedBuildMenuTagData(pointer);
      local = buildMenuTagData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224132, RefRangeEnd = 1224133, XrefRangeStart = 1224127, XrefRangeEnd = 1224132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetManagedCategoryData(
      int categoryIndex,
      out ManagedBuildMenuCategoryData result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &categoryIndex;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryGetManagedCategoryData_Private_Boolean_Int32_byref_ManagedBuildMenuCategoryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ManagedBuildMenuCategoryData local = ref result;
      System.IntPtr pointer = zero;
      ManagedBuildMenuCategoryData menuCategoryData = pointer == System.IntPtr.Zero ? (ManagedBuildMenuCategoryData) null : new ManagedBuildMenuCategoryData(pointer);
      local = menuCategoryData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1224141, RefRangeEnd = 1224151, XrefRangeStart = 1224133, XrefRangeEnd = 1224141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BuildMenuCompositionBlob GetCompositionBlob()
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224151, XrefRangeEnd = 1224182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224182, XrefRangeEnd = 1224228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleActionWheelInputDown()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_HandleActionWheelInputDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1224244, RefRangeEnd = 1224246, XrefRangeStart = 1224228, XrefRangeEnd = 1224244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleActionWheelInputUp()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_HandleActionWheelInputUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224246, XrefRangeEnd = 1224250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateActionWheel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateActionWheel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224250, XrefRangeEnd = 1224322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224322, XrefRangeEnd = 1224336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224336, XrefRangeEnd = 1224393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224393, XrefRangeEnd = 1224422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224422, XrefRangeEnd = 1224588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224588, XrefRangeEnd = 1224590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsWallpaperSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_IsWallpaperSelected_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224618, RefRangeEnd = 1224619, XrefRangeStart = 1224590, XrefRangeEnd = 1224618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTooltip(Entity localControlled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localControlled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateTooltip_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224619, XrefRangeEnd = 1224632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartOrUpdateWallpaperOperation(PrefabGUID wallpaperBlueprint)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &wallpaperBlueprint;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_StartOrUpdateWallpaperOperation_Private_Void_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1224638, RefRangeEnd = 1224644, XrefRangeStart = 1224632, XrefRangeEnd = 1224638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndWallpaperOperation()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_EndWallpaperOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224658, RefRangeEnd = 1224659, XrefRangeStart = 1224644, XrefRangeEnd = 1224658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TempUpdatePick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TempUpdatePick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224659, XrefRangeEnd = 1224668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAtStartOfFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateAtStartOfFrame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1224688, RefRangeEnd = 1224691, XrefRangeStart = 1224668, XrefRangeEnd = 1224688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSelectedCategory(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_SetSelectedCategory_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224691, XrefRangeEnd = 1224695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSelectedTag(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_SetSelectedTag_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1224715, RefRangeEnd = 1224719, XrefRangeStart = 1224695, XrefRangeEnd = 1224715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateViewedStructures()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateViewedStructures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EnsureBuildMenuTagConverted(int categoryIndex, int tagIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &categoryIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tagIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_EnsureBuildMenuTagConverted_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224791, RefRangeEnd = 1224792, XrefRangeStart = 1224719, XrefRangeEnd = 1224791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindBuildMenu()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryFindBuildMenu_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224792, XrefRangeEnd = 1224796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnBuildMenuEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_OnBuildMenuEnabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224796, XrefRangeEnd = 1224802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnBuildMenuDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_OnBuildMenuDisabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224802, XrefRangeEnd = 1224804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableBuildingFromInventoryItem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_DisableBuildingFromInventoryItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224840, RefRangeEnd = 1224841, XrefRangeStart = 1224804, XrefRangeEnd = 1224840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateControllerMousePosition(Entity localControlled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localControlled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateControllerMousePosition_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224888, RefRangeEnd = 1224889, XrefRangeStart = 1224841, XrefRangeEnd = 1224888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryFindTransformTarget(Entity localControlled, out Entity transformTarget)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref transformTarget;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryFindTransformTarget_Private_Void_Entity_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1224910, RefRangeEnd = 1224912, XrefRangeStart = 1224889, XrefRangeEnd = 1224910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryGetHoverTarget(
      Entity localControlled,
      out Entity hoverBlueprintTarget,
      out Entity hoverEffectTarget)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hoverBlueprintTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hoverEffectTarget;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryGetHoverTarget_Private_Void_Entity_byref_Entity_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224912, XrefRangeEnd = 1224922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateEditableModelEffect(
      Entity hoverBlueprintTarget,
      Entity hoverEffectTarget,
      BuildMenuUtilities.ObjectEditOptions editOptions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &hoverBlueprintTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hoverEffectTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &editOptions;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateEditableModelEffect_Private_Void_Entity_Entity_ObjectEditOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224954, RefRangeEnd = 1224955, XrefRangeStart = 1224922, XrefRangeEnd = 1224954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrySelectHoverTarget(Entity hoverTarget)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hoverTarget;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TrySelectHoverTarget_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224955, XrefRangeEnd = 1224961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetEditingEntity(Entity localControlled, out Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryGetEditingEntity_Private_Boolean_Entity_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1224985, RefRangeEnd = 1224986, XrefRangeStart = 1224961, XrefRangeEnd = 1224985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity CreatePreviewPlacementBuff(
      Entity localControlled,
      bool hasEditingEntity,
      bool isNewBuildingSelected,
      Entity editingEntity,
      Entity transformTarget,
      PrefabGUID newBuildingPrefabGUID)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hasEditingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isNewBuildingSelected;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &editingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &transformTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &newBuildingPrefabGUID;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_CreatePreviewPlacementBuff_Private_Entity_Entity_Boolean_Boolean_Entity_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1224997, RefRangeEnd = 1224999, XrefRangeStart = 1224986, XrefRangeEnd = 1224997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemovePreviewPlacementBuff()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_RemovePreviewPlacementBuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225029, RefRangeEnd = 1225030, XrefRangeStart = 1224999, XrefRangeEnd = 1225029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoLineOfSightRequirementChecks(
      Entity localControlled,
      out bool lineOfSightRequirementPassed)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lineOfSightRequirementPassed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_DoLineOfSightRequirementChecks_Private_Void_Entity_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225069, RefRangeEnd = 1225070, XrefRangeStart = 1225030, XrefRangeEnd = 1225069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePlacementResult(
      Entity localControlled,
      Entity previewBuffEntity,
      BuildMenuMapper.IdentifiedPlacementOperation placementOperation)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &previewBuffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &placementOperation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdatePlacementResult_Private_Void_Entity_Entity_IdentifiedPlacementOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225070, XrefRangeEnd = 1225084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryIdentifyPlacementOperation(
      Entity transformTarget,
      Entity hoveredEntity,
      BuildMenuUtilities.ObjectEditOptions hoveredEditOptions,
      out BuildMenuMapper.IdentifiedPlacementOperation result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &transformTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hoveredEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hoveredEditOptions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryIdentifyPlacementOperation_Private_Boolean_Entity_Entity_ObjectEditOptions_byref_IdentifiedPlacementOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1225110, RefRangeEnd = 1225113, XrefRangeStart = 1225084, XrefRangeEnd = 1225110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetColorCollection(Entity dyeableEntity, out IColorCollection result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &dyeableEntity;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryGetColorCollection_Private_Boolean_Entity_byref_IColorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref IColorCollection local = ref result;
      System.IntPtr pointer = zero;
      IColorCollection icolorCollection = pointer == System.IntPtr.Zero ? (IColorCollection) null : new IColorCollection(pointer);
      local = icolorCollection;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1225148, RefRangeEnd = 1225150, XrefRangeStart = 1225113, XrefRangeEnd = 1225148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetWallpaperOrientation(Entity entity, out WallpaperOrientation result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryGetWallpaperOrientation_Private_Boolean_Entity_byref_WallpaperOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1225183, RefRangeEnd = 1225186, XrefRangeStart = 1225150, XrefRangeEnd = 1225183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetDyeableEntity(
      Entity entity,
      bool searchWallpaperInstances,
      out Entity result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &searchWallpaperInstances;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryGetDyeableEntity_Private_Boolean_Entity_Boolean_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225257, RefRangeEnd = 1225258, XrefRangeStart = 1225186, XrefRangeEnd = 1225257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddStructureToUi(
      ref BuildMenuStructureBlob structure,
      int index,
      Entity localCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref structure;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_AddStructureToUi_Private_Void_byref_BuildMenuStructureBlob_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225375, RefRangeEnd = 1225376, XrefRangeStart = 1225258, XrefRangeEnd = 1225375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateBlueprintRequirements(
      Entity localControlled,
      Entity localUserEntity,
      PlacementResult placementResult,
      [In] ref MapZoneCollection mapZoneCollection,
      ref ServerGameBalanceSettings serverSettings,
      out bool allRequirementsMet)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUserEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &placementResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref allRequirementsMet;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateBlueprintRequirements_Private_Void_Entity_Entity_PlacementResult_byref_MapZoneCollection_byref_ServerGameBalanceSettings_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225376, XrefRangeEnd = 1225392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetBuildMenuSortingOrder(PrefabGUID structurePrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &structurePrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_GetBuildMenuSortingOrder_Private_Int32_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225392, XrefRangeEnd = 1225397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool StructureContainsBlueprint(
      ref BuildMenuStructureBlob structure,
      PrefabGUID blueprintPrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref structure;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &blueprintPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_StructureContainsBlueprint_Private_Boolean_byref_BuildMenuStructureBlob_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1225405, RefRangeEnd = 1225408, XrefRangeStart = 1225397, XrefRangeEnd = 1225405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool StructureContainsBlueprint(
      ref BuildMenuStructureBlob structure,
      NativeHashSet<PrefabGUID> blueprintGuids)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref structure;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &blueprintGuids;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_StructureContainsBlueprint_Private_Boolean_byref_BuildMenuStructureBlob_NativeHashSet_1_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225493, RefRangeEnd = 1225494, XrefRangeStart = 1225408, XrefRangeEnd = 1225493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateUnlockedBlueprints(Entity localUserEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localUserEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateUnlockedBlueprints_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225526, RefRangeEnd = 1225527, XrefRangeStart = 1225494, XrefRangeEnd = 1225526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddResourceCosts(
      Entity localControlled,
      PlacementResult placementResult,
      bool buildCostsDisabled,
      double serverTime,
      ref bool allRequirementsMet)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &placementResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buildCostsDisabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref allRequirementsMet;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_AddResourceCosts_Private_Void_Entity_PlacementResult_Boolean_Double_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225682, RefRangeEnd = 1225683, XrefRangeStart = 1225527, XrefRangeEnd = 1225682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoInputs(
      Entity hoveredEntity,
      BuildMenuUtilities.ObjectEditOptions targetEditOptions,
      BuildMenuPlacementOperation placementOperation,
      bool hasEditingEntity,
      Entity editingEntity,
      Entity transformedEntity,
      bool isNewBuildingSelected,
      PrefabGUID newBuildingPrefabGUID,
      bool allRequirementsMet,
      bool lineOfSightRequirementPassed)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &hoveredEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEditOptions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) placementOperation);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hasEditingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &editingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &transformedEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &isNewBuildingSelected;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &newBuildingPrefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &allRequirementsMet;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &lineOfSightRequirementPassed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_DoInputs_Private_Void_Entity_ObjectEditOptions_BuildMenuPlacementOperation_Boolean_Entity_Entity_Boolean_PrefabGUID_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225683, XrefRangeEnd = 1225691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasItemBuildingInInventory(
      EntityManager entityManager,
      PrefabLookupMap prefabLookupMap,
      NativeArray<InventoryBuffer> inventory,
      PrefabGUID itemBuildingType,
      int stacks,
      out int amount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemBuildingType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref amount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_HasItemBuildingInInventory_Public_Static_Boolean_EntityManager_PrefabLookupMap_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225691, XrefRangeEnd = 1225700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetExitBuildModeWhenBuilt(PrefabGUID blueprintPrefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &blueprintPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_GetExitBuildModeWhenBuilt_Private_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225700, XrefRangeEnd = 1225707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePlacementIfPrefabChanged(
      ref PreviewPlacementBuff previewBuff,
      bool hasEditingEntity,
      Entity editingEntity,
      bool isNewBuildingSelected,
      PrefabGUID newBuildingPrefabGUID)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref previewBuff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hasEditingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &editingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isNewBuildingSelected;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newBuildingPrefabGUID;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdatePlacementIfPrefabChanged_Private_Void_byref_PreviewPlacementBuff_Boolean_Entity_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225707, XrefRangeEnd = 1225721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetCanMoveRotateOrDismantle(
      PreviewPlacementBuff previewBuff,
      out bool canMove,
      out bool canRotate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &previewBuff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref canMove;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref canRotate;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_GetCanMoveRotateOrDismantle_Private_Void_PreviewPlacementBuff_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1225742, RefRangeEnd = 1225745, XrefRangeStart = 1225721, XrefRangeEnd = 1225742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CancelEditing()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_CancelEditing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1225757, RefRangeEnd = 1225759, XrefRangeStart = 1225745, XrefRangeEnd = 1225757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearEditing()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_ClearEditing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225764, RefRangeEnd = 1225765, XrefRangeStart = 1225759, XrefRangeEnd = 1225764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddStandardPlaceCancelRotateInputContexts([In] ref PlacementResult placementResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref placementResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_AddStandardPlaceCancelRotateInputContexts_Private_Void_byref_PlacementResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1225921, RefRangeEnd = 1225922, XrefRangeStart = 1225765, XrefRangeEnd = 1225921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateInputContext(
      Entity localControlled,
      Entity hoverTarget,
      bool hasEditingEntity,
      bool isNewBuildingSelected,
      bool allResourceRequirementsMet,
      PlacementResult placementResult,
      GameDataSystem gameDataSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &localControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hoverTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hasEditingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isNewBuildingSelected;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &allResourceRequirementsMet;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &placementResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateInputContext_Private_Void_Entity_Entity_Boolean_Boolean_Boolean_PlacementResult_GameDataSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1226184, RefRangeEnd = 1226187, XrefRangeStart = 1225922, XrefRangeEnd = 1226184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdaterPlacementErrorText(PlacementResult placementResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &placementResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdaterPlacementErrorText_Private_Void_PlacementResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1226195, RefRangeEnd = 1226198, XrefRangeStart = 1226187, XrefRangeEnd = 1226195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddStandardBuildMenuError(LocalizationKey localizationKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localizationKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_AddStandardBuildMenuError_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226373, RefRangeEnd = 1226374, XrefRangeStart = 1226198, XrefRangeEnd = 1226373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePreviewPlacementSequences(
      PlacementResult placementResult,
      bool allRequirementsMet,
      bool lineOfSightRequirementPassed)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &placementResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allRequirementsMet;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lineOfSightRequirementPassed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdatePreviewPlacementSequences_Private_Void_PlacementResult_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1226383, RefRangeEnd = 1226386, XrefRangeStart = 1226374, XrefRangeEnd = 1226383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CompareQuaternionAsTileRotation(
      quaternion rotationA,
      quaternion rotationB)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rotationA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotationB;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_CompareQuaternionAsTileRotation_Private_Static_Boolean_quaternion_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226386, XrefRangeEnd = 1226399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Float4AlmostEquals(float4 valueA, float4 valueB, int decimals = 6)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &valueA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_Float4AlmostEquals_Private_Static_Boolean_float4_float4_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1226409, RefRangeEnd = 1226412, XrefRangeStart = 1226399, XrefRangeEnd = 1226409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Float3AlmostEquals(float3 valueA, float3 valueB, int decimals = 6)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &valueA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_Float3AlmostEquals_Private_Static_Boolean_float3_float3_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1226417, RefRangeEnd = 1226424, XrefRangeStart = 1226412, XrefRangeEnd = 1226417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FloatAlmostEquals(float valueA, float valueB, int decimals = 6)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &valueA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_FloatAlmostEquals_Private_Static_Boolean_Single_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226445, RefRangeEnd = 1226446, XrefRangeStart = 1226424, XrefRangeEnd = 1226445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateBuildingCategories()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateBuildingCategories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1226459, RefRangeEnd = 1226462, XrefRangeStart = 1226446, XrefRangeEnd = 1226459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldShowCategory(ref BuildMenuCategoryBlob category)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref category;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_ShouldShowCategory_Private_Boolean_byref_BuildMenuCategoryBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226482, RefRangeEnd = 1226483, XrefRangeStart = 1226462, XrefRangeEnd = 1226482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateBuildingTags()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateBuildingTags_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226515, RefRangeEnd = 1226516, XrefRangeStart = 1226483, XrefRangeEnd = 1226515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateVariations()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_UpdateVariations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1226521, RefRangeEnd = 1226523, XrefRangeStart = 1226516, XrefRangeEnd = 1226521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldShowTag(ref BuildMenuTagBlob tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref tag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_ShouldShowTag_Private_Boolean_byref_BuildMenuTagBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1226535, RefRangeEnd = 1226537, XrefRangeStart = 1226523, XrefRangeEnd = 1226535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldHighlightButton(ref BuildMenuTagBlob tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref tag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_ShouldHighlightButton_Private_Boolean_byref_BuildMenuTagBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226542, RefRangeEnd = 1226543, XrefRangeStart = 1226537, XrefRangeEnd = 1226542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldHighlightButton(ref BuildMenuCategoryBlob category)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref category;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_ShouldHighlightButton_Private_Boolean_byref_BuildMenuCategoryBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226570, RefRangeEnd = 1226571, XrefRangeStart = 1226543, XrefRangeEnd = 1226570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryStartBuildingFromInventoryItem(PrefabGUID itemId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_TryStartBuildingFromInventoryItem_Public_Void_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226571, XrefRangeEnd = 1226634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226639, RefRangeEnd = 1226640, XrefRangeStart = 1226634, XrefRangeEnd = 1226639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__51_0(Entity entity, [In] ref UICanvasBase canvasBase)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvasBase);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__51_0_Private_Void_Entity_byref_UICanvasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref UICanvasBase local = ref canvasBase;
      System.IntPtr pointer = ptr;
      UICanvasBase uiCanvasBase = pointer == System.IntPtr.Zero ? (UICanvasBase) null : new UICanvasBase(pointer);
      local = uiCanvasBase;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226643, RefRangeEnd = 1226644, XrefRangeStart = 1226640, XrefRangeEnd = 1226643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TryFindBuildMenu_b__64_0(Entity entity, BuildMenu menu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr__TryFindBuildMenu_b__64_0_Private_Void_Entity_BuildMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226644, XrefRangeEnd = 1226648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TryFindBuildMenu_b__64_1(int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr__TryFindBuildMenu_b__64_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226648, XrefRangeEnd = 1226654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TryFindBuildMenu_b__64_2(int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr__TryFindBuildMenu_b__64_2_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _TryFindBuildMenu_b__64_3(int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr__TryFindBuildMenu_b__64_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226654, XrefRangeEnd = 1226665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Method_Private_Boolean_Entity_byref_IColorCollection_PDM_0(
      Entity e,
      out IColorCollection r)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &e;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_Method_Private_Boolean_Entity_byref_IColorCollection_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref IColorCollection local = ref r;
      System.IntPtr pointer = zero;
      IColorCollection icolorCollection = pointer == System.IntPtr.Zero ? (IColorCollection) null : new IColorCollection(pointer);
      local = icolorCollection;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226665, XrefRangeEnd = 1226679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Method_Private_Boolean_Entity_byref_IColorCollection_PDM_1(
      Entity e,
      out IColorCollection r)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &e;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_Method_Private_Boolean_Entity_byref_IColorCollection_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref IColorCollection local = ref r;
      System.IntPtr pointer = zero;
      IColorCollection icolorCollection = pointer == System.IntPtr.Zero ? (IColorCollection) null : new IColorCollection(pointer);
      local = icolorCollection;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226679, XrefRangeEnd = 1226846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226846, XrefRangeEnd = 1226862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnStartRunning_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226862, XrefRangeEnd = 1226881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTempUpdatePick_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForTempUpdatePick_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226881, XrefRangeEnd = 1226897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTryFindBuildMenu_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForTryFindBuildMenu_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226919, RefRangeEnd = 1226920, XrefRangeStart = 1226897, XrefRangeEnd = 1226919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateUnlockedBlueprints_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedBlueprints_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226942, RefRangeEnd = 1226943, XrefRangeStart = 1226920, XrefRangeEnd = 1226942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateUnlockedBlueprints_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedBlueprints_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226947, RefRangeEnd = 1226948, XrefRangeStart = 1226943, XrefRangeEnd = 1226947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226952, RefRangeEnd = 1226953, XrefRangeStart = 1226948, XrefRangeEnd = 1226952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1226957, RefRangeEnd = 1226958, XrefRangeStart = 1226953, XrefRangeEnd = 1226957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenuMapper()
    {
      Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr);
      BuildMenuMapper.NativeFieldInfoPtr__AddedItemHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_AddedItemHashes));
      BuildMenuMapper.NativeFieldInfoPtr__Structures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_Structures));
      BuildMenuMapper.NativeFieldInfoPtr__Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_Requirements));
      BuildMenuMapper.NativeFieldInfoPtr__InventoryContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_InventoryContextEntriesCache));
      BuildMenuMapper.NativeFieldInfoPtr__InventoryErrorEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_InventoryErrorEntriesCache));
      BuildMenuMapper.NativeFieldInfoPtr__BuildingCategoryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_BuildingCategoryData));
      BuildMenuMapper.NativeFieldInfoPtr__BuildingTagData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_BuildingTagData));
      BuildMenuMapper.NativeFieldInfoPtr__BuildingVariationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_BuildingVariationData));
      BuildMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      BuildMenuMapper.NativeFieldInfoPtr__UnlockedBlueprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_UnlockedBlueprints));
      BuildMenuMapper.NativeFieldInfoPtr__BuildMenuQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_BuildMenuQuery));
      BuildMenuMapper.NativeFieldInfoPtr__BuildMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_BuildMenu));
      BuildMenuMapper.NativeFieldInfoPtr__BuildMenuOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_BuildMenuOperation));
      BuildMenuMapper.NativeFieldInfoPtr__PreviewBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_PreviewBuffEntity));
      BuildMenuMapper.NativeFieldInfoPtr__InputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_InputState));
      BuildMenuMapper.NativeFieldInfoPtr__InputStateInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_InputStateInitialized));
      BuildMenuMapper.NativeFieldInfoPtr__ControllerLocalMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_ControllerLocalMousePosition));
      BuildMenuMapper.NativeFieldInfoPtr__ControllerWorldMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_ControllerWorldMousePosition));
      BuildMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      BuildMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BuildMenuMapper.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_TileWorldSystem));
      BuildMenuMapper.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_CollisionSystem));
      BuildMenuMapper.NativeFieldInfoPtr__MapZoneCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_MapZoneCollectionSystem));
      BuildMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      BuildMenuMapper.NativeFieldInfoPtr__UIAssetSubSceneLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_UIAssetSubSceneLoader));
      BuildMenuMapper.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_PlacementSystemData));
      BuildMenuMapper.NativeFieldInfoPtr__SelectedCategoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_SelectedCategoryIndex));
      BuildMenuMapper.NativeFieldInfoPtr__SelectedTagIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_SelectedTagIndex));
      BuildMenuMapper.NativeFieldInfoPtr__SelectedVariationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_SelectedVariationIndex));
      BuildMenuMapper.NativeFieldInfoPtr__CategoryPreviouslySelectedTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_CategoryPreviouslySelectedTag));
      BuildMenuMapper.NativeFieldInfoPtr__VariationSelectionWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_VariationSelectionWheel));
      BuildMenuMapper.NativeFieldInfoPtr__BuildingFromInventoryItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_BuildingFromInventoryItem));
      BuildMenuMapper.NativeFieldInfoPtr__WallpaperOperationEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_WallpaperOperationEntity));
      BuildMenuMapper.NativeFieldInfoPtr__WallpaperOperationEntityArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_WallpaperOperationEntityArchetype));
      BuildMenuMapper.NativeFieldInfoPtr__ServerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_ServerSettings));
      BuildMenuMapper.NativeFieldInfoPtr__CompositionPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_CompositionPrefabGuid));
      BuildMenuMapper.NativeFieldInfoPtr__HighlightHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_HighlightHelper));
      BuildMenuMapper.NativeFieldInfoPtr_IgnoredBlockReasons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (IgnoredBlockReasons));
      BuildMenuMapper.NativeFieldInfoPtr_BlockReasonPriorities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (BlockReasonPriorities));
      BuildMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>OnStartRunning_LambdaJob0_entityQuery");
      BuildMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>OnStartRunning_LambdaJob0_profilerMarker");
      BuildMenuMapper.NativeFieldInfoPtr___TempUpdatePick_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>TempUpdatePick_LambdaJob0_entityQuery");
      BuildMenuMapper.NativeFieldInfoPtr___TempUpdatePick_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>TempUpdatePick_LambdaJob0_profilerMarker");
      BuildMenuMapper.NativeFieldInfoPtr___TryFindBuildMenu_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>TryFindBuildMenu_LambdaJob0_entityQuery");
      BuildMenuMapper.NativeFieldInfoPtr___TryFindBuildMenu_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>TryFindBuildMenu_LambdaJob0_profilerMarker");
      BuildMenuMapper.NativeFieldInfoPtr___DoPlacementRequest_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>DoPlacementRequest_profilerMarker");
      BuildMenuMapper.NativeFieldInfoPtr___DoPlacementRequestWithDebug_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>DoPlacementRequestWithDebug_profilerMarker");
      BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>UpdateUnlockedBlueprints_LambdaJob0_entityQuery");
      BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>UpdateUnlockedBlueprints_LambdaJob0_profilerMarker");
      BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>UpdateUnlockedBlueprints_LambdaJob1_entityQuery");
      BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>UpdateUnlockedBlueprints_LambdaJob1_profilerMarker");
      BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_SingletonEntityQuery_HybridCameraData_10));
      BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_11));
      BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_BuildMenuPickedEntity_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (_SingletonEntityQuery_BuildMenuPickedEntity_12));
      BuildMenuMapper.NativeMethodInfoPtr_GetSelectedCategory_Private_byref_BuildMenuCategoryBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664832);
      BuildMenuMapper.NativeMethodInfoPtr_GetSelectedTag_Private_byref_BuildMenuTagBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664833);
      BuildMenuMapper.NativeMethodInfoPtr_TryGetManagedCompositionData_Private_Boolean_byref_ManagedBuildMenuCompositionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664834);
      BuildMenuMapper.NativeMethodInfoPtr_TryGetManagedTagData_Private_Boolean_Int32_Int32_byref_ManagedBuildMenuTagData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664835);
      BuildMenuMapper.NativeMethodInfoPtr_TryGetManagedCategoryData_Private_Boolean_Int32_byref_ManagedBuildMenuCategoryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664836);
      BuildMenuMapper.NativeMethodInfoPtr_GetCompositionBlob_Private_byref_BuildMenuCompositionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664837);
      BuildMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664838);
      BuildMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664839);
      BuildMenuMapper.NativeMethodInfoPtr_HandleActionWheelInputDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664840);
      BuildMenuMapper.NativeMethodInfoPtr_HandleActionWheelInputUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664841);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateActionWheel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664842);
      BuildMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664843);
      BuildMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664844);
      BuildMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664845);
      BuildMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664846);
      BuildMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664847);
      BuildMenuMapper.NativeMethodInfoPtr_IsWallpaperSelected_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664848);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateTooltip_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664849);
      BuildMenuMapper.NativeMethodInfoPtr_StartOrUpdateWallpaperOperation_Private_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664850);
      BuildMenuMapper.NativeMethodInfoPtr_EndWallpaperOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664851);
      BuildMenuMapper.NativeMethodInfoPtr_TempUpdatePick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664852);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateAtStartOfFrame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664853);
      BuildMenuMapper.NativeMethodInfoPtr_SetSelectedCategory_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664854);
      BuildMenuMapper.NativeMethodInfoPtr_SetSelectedTag_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664855);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateViewedStructures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664856);
      BuildMenuMapper.NativeMethodInfoPtr_EnsureBuildMenuTagConverted_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664857);
      BuildMenuMapper.NativeMethodInfoPtr_TryFindBuildMenu_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664858);
      BuildMenuMapper.NativeMethodInfoPtr_OnBuildMenuEnabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664859);
      BuildMenuMapper.NativeMethodInfoPtr_OnBuildMenuDisabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664860);
      BuildMenuMapper.NativeMethodInfoPtr_DisableBuildingFromInventoryItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664861);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateControllerMousePosition_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664862);
      BuildMenuMapper.NativeMethodInfoPtr_TryFindTransformTarget_Private_Void_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664863);
      BuildMenuMapper.NativeMethodInfoPtr_TryGetHoverTarget_Private_Void_Entity_byref_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664864);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateEditableModelEffect_Private_Void_Entity_Entity_ObjectEditOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664865);
      BuildMenuMapper.NativeMethodInfoPtr_TrySelectHoverTarget_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664866);
      BuildMenuMapper.NativeMethodInfoPtr_TryGetEditingEntity_Private_Boolean_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664867);
      BuildMenuMapper.NativeMethodInfoPtr_CreatePreviewPlacementBuff_Private_Entity_Entity_Boolean_Boolean_Entity_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664868);
      BuildMenuMapper.NativeMethodInfoPtr_RemovePreviewPlacementBuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664869);
      BuildMenuMapper.NativeMethodInfoPtr_DoLineOfSightRequirementChecks_Private_Void_Entity_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664870);
      BuildMenuMapper.NativeMethodInfoPtr_UpdatePlacementResult_Private_Void_Entity_Entity_IdentifiedPlacementOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664871);
      BuildMenuMapper.NativeMethodInfoPtr_TryIdentifyPlacementOperation_Private_Boolean_Entity_Entity_ObjectEditOptions_byref_IdentifiedPlacementOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664872);
      BuildMenuMapper.NativeMethodInfoPtr_TryGetColorCollection_Private_Boolean_Entity_byref_IColorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664873);
      BuildMenuMapper.NativeMethodInfoPtr_TryGetWallpaperOrientation_Private_Boolean_Entity_byref_WallpaperOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664874);
      BuildMenuMapper.NativeMethodInfoPtr_TryGetDyeableEntity_Private_Boolean_Entity_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664875);
      BuildMenuMapper.NativeMethodInfoPtr_AddStructureToUi_Private_Void_byref_BuildMenuStructureBlob_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664876);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateBlueprintRequirements_Private_Void_Entity_Entity_PlacementResult_byref_MapZoneCollection_byref_ServerGameBalanceSettings_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664877);
      BuildMenuMapper.NativeMethodInfoPtr_GetBuildMenuSortingOrder_Private_Int32_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664878);
      BuildMenuMapper.NativeMethodInfoPtr_StructureContainsBlueprint_Private_Boolean_byref_BuildMenuStructureBlob_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664879);
      BuildMenuMapper.NativeMethodInfoPtr_StructureContainsBlueprint_Private_Boolean_byref_BuildMenuStructureBlob_NativeHashSet_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664880);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateUnlockedBlueprints_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664881);
      BuildMenuMapper.NativeMethodInfoPtr_AddResourceCosts_Private_Void_Entity_PlacementResult_Boolean_Double_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664882);
      BuildMenuMapper.NativeMethodInfoPtr_DoInputs_Private_Void_Entity_ObjectEditOptions_BuildMenuPlacementOperation_Boolean_Entity_Entity_Boolean_PrefabGUID_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664883);
      BuildMenuMapper.NativeMethodInfoPtr_HasItemBuildingInInventory_Public_Static_Boolean_EntityManager_PrefabLookupMap_NativeArray_1_InventoryBuffer_PrefabGUID_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664884);
      BuildMenuMapper.NativeMethodInfoPtr_GetExitBuildModeWhenBuilt_Private_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664885);
      BuildMenuMapper.NativeMethodInfoPtr_UpdatePlacementIfPrefabChanged_Private_Void_byref_PreviewPlacementBuff_Boolean_Entity_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664886);
      BuildMenuMapper.NativeMethodInfoPtr_GetCanMoveRotateOrDismantle_Private_Void_PreviewPlacementBuff_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664887);
      BuildMenuMapper.NativeMethodInfoPtr_CancelEditing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664888);
      BuildMenuMapper.NativeMethodInfoPtr_ClearEditing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664889);
      BuildMenuMapper.NativeMethodInfoPtr_AddStandardPlaceCancelRotateInputContexts_Private_Void_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664890);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateInputContext_Private_Void_Entity_Entity_Boolean_Boolean_Boolean_PlacementResult_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664891);
      BuildMenuMapper.NativeMethodInfoPtr_UpdaterPlacementErrorText_Private_Void_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664892);
      BuildMenuMapper.NativeMethodInfoPtr_AddStandardBuildMenuError_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664893);
      BuildMenuMapper.NativeMethodInfoPtr_UpdatePreviewPlacementSequences_Private_Void_PlacementResult_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664894);
      BuildMenuMapper.NativeMethodInfoPtr_CompareQuaternionAsTileRotation_Private_Static_Boolean_quaternion_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664895);
      BuildMenuMapper.NativeMethodInfoPtr_Float4AlmostEquals_Private_Static_Boolean_float4_float4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664896);
      BuildMenuMapper.NativeMethodInfoPtr_Float3AlmostEquals_Private_Static_Boolean_float3_float3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664897);
      BuildMenuMapper.NativeMethodInfoPtr_FloatAlmostEquals_Private_Static_Boolean_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664898);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateBuildingCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664899);
      BuildMenuMapper.NativeMethodInfoPtr_ShouldShowCategory_Private_Boolean_byref_BuildMenuCategoryBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664900);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateBuildingTags_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664901);
      BuildMenuMapper.NativeMethodInfoPtr_UpdateVariations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664902);
      BuildMenuMapper.NativeMethodInfoPtr_ShouldShowTag_Private_Boolean_byref_BuildMenuTagBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664903);
      BuildMenuMapper.NativeMethodInfoPtr_ShouldHighlightButton_Private_Boolean_byref_BuildMenuTagBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664904);
      BuildMenuMapper.NativeMethodInfoPtr_ShouldHighlightButton_Private_Boolean_byref_BuildMenuCategoryBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664905);
      BuildMenuMapper.NativeMethodInfoPtr_TryStartBuildingFromInventoryItem_Public_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664906);
      BuildMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664907);
      BuildMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__51_0_Private_Void_Entity_byref_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664909);
      BuildMenuMapper.NativeMethodInfoPtr__TryFindBuildMenu_b__64_0_Private_Void_Entity_BuildMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664910);
      BuildMenuMapper.NativeMethodInfoPtr__TryFindBuildMenu_b__64_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664911);
      BuildMenuMapper.NativeMethodInfoPtr__TryFindBuildMenu_b__64_2_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664912);
      BuildMenuMapper.NativeMethodInfoPtr__TryFindBuildMenu_b__64_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664913);
      BuildMenuMapper.NativeMethodInfoPtr_Method_Private_Boolean_Entity_byref_IColorCollection_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664914);
      BuildMenuMapper.NativeMethodInfoPtr_Method_Private_Boolean_Entity_byref_IColorCollection_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664915);
      BuildMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664916);
      BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664917);
      BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForTempUpdatePick_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664918);
      BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForTryFindBuildMenu_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664919);
      BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedBlueprints_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664920);
      BuildMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUnlockedBlueprints_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664921);
      BuildMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664922);
      BuildMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664923);
      BuildMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, 100664924);
    }

    public BuildMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<int> _AddedItemHashes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__AddedItemHashes));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__AddedItemHashes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BuildMenu_TopStructureEntry_Data> _Structures
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__Structures));
        return pointer == System.IntPtr.Zero ? (List<BuildMenu_TopStructureEntry_Data>) null : new List<BuildMenu_TopStructureEntry_Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__Structures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BlueprintRequirementEntry.Data> _Requirements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__Requirements));
        return pointer == System.IntPtr.Zero ? (List<BlueprintRequirementEntry.Data>) null : new List<BlueprintRequirementEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__Requirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InputContextEntry.Data> _InventoryContextEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InventoryContextEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InventoryContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ErrorContextEntry.Data> _InventoryErrorEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InventoryErrorEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<ErrorContextEntry.Data>) null : new List<ErrorContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InventoryErrorEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BuildMenu_CategoryEntry.Data> _BuildingCategoryData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildingCategoryData));
        return pointer == System.IntPtr.Zero ? (List<BuildMenu_CategoryEntry.Data>) null : new List<BuildMenu_CategoryEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildingCategoryData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BuildMenu_TagEntry.Data> _BuildingTagData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildingTagData));
        return pointer == System.IntPtr.Zero ? (List<BuildMenu_TagEntry.Data>) null : new List<BuildMenu_TagEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildingTagData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BuildMenu_VariationEntry.Data> _BuildingVariationData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildingVariationData));
        return pointer == System.IntPtr.Zero ? (List<BuildMenu_VariationEntry.Data>) null : new List<BuildMenu_VariationEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildingVariationData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashSet<PrefabGUID> _UnlockedBlueprints
    {
      get
      {
        return *(NativeHashSet<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__UnlockedBlueprints));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__UnlockedBlueprints), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _BuildMenuQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildMenuQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildMenuQuery)) = value;
      }
    }

    public unsafe BuildMenu _BuildMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildMenu));
        return pointer == System.IntPtr.Zero ? (BuildMenu) null : new BuildMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _BuildMenuOperation
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildMenuOperation));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildMenuOperation)) = value;
      }
    }

    public unsafe Entity _PreviewBuffEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__PreviewBuffEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__PreviewBuffEntity)) = value;
      }
    }

    public unsafe InputState _InputState
    {
      get
      {
        return *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InputState));
      }
      [param: In] set
      {
        *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InputState)) = value;
      }
    }

    public unsafe bool _InputStateInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InputStateInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__InputStateInitialized)) = value;
      }
    }

    public unsafe float3 _ControllerLocalMousePosition
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__ControllerLocalMousePosition));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__ControllerLocalMousePosition)) = value;
      }
    }

    public unsafe float3 _ControllerWorldMousePosition
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__ControllerWorldMousePosition));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__ControllerWorldMousePosition)) = value;
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapZoneCollectionSystem _MapZoneCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__MapZoneCollectionSystem));
        return pointer == System.IntPtr.Zero ? (MapZoneCollectionSystem) null : new MapZoneCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__MapZoneCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIAssetSubSceneLoader_ClientWorld _UIAssetSubSceneLoader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__UIAssetSubSceneLoader));
        return pointer == System.IntPtr.Zero ? (UIAssetSubSceneLoader_ClientWorld) null : new UIAssetSubSceneLoader_ClientWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__UIAssetSubSceneLoader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _SelectedCategoryIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SelectedCategoryIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SelectedCategoryIndex)) = value;
      }
    }

    public unsafe int _SelectedTagIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SelectedTagIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SelectedTagIndex)) = value;
      }
    }

    public unsafe byte _SelectedVariationIndex
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SelectedVariationIndex));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SelectedVariationIndex)) = value;
      }
    }

    public unsafe NativeHashMap<int, int> _CategoryPreviouslySelectedTag
    {
      get
      {
        return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__CategoryPreviouslySelectedTag));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__CategoryPreviouslySelectedTag), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BuildMenuMapper.VariationSelectionWheel _VariationSelectionWheel
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__VariationSelectionWheel));
        return pointer == System.IntPtr.Zero ? (BuildMenuMapper.VariationSelectionWheel) null : new BuildMenuMapper.VariationSelectionWheel(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__VariationSelectionWheel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<PrefabGUID> _BuildingFromInventoryItem
    {
      get
      {
        return *(Nullable_Unboxed<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildingFromInventoryItem));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__BuildingFromInventoryItem), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Entity _WallpaperOperationEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__WallpaperOperationEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__WallpaperOperationEntity)) = value;
      }
    }

    public unsafe EntityArchetype _WallpaperOperationEntityArchetype
    {
      get
      {
        return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__WallpaperOperationEntityArchetype));
      }
      [param: In] set
      {
        *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__WallpaperOperationEntityArchetype)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__ServerSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__ServerSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabGUID _CompositionPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__CompositionPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__CompositionPrefabGuid)) = value;
      }
    }

    public unsafe UIHighlightHelper _HighlightHelper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__HighlightHelper));
        return pointer == System.IntPtr.Zero ? (UIHighlightHelper) null : new UIHighlightHelper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__HighlightHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe HashSet<BlockReason> IgnoredBlockReasons
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.NativeFieldInfoPtr_IgnoredBlockReasons, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (HashSet<BlockReason>) null : new HashSet<BlockReason>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.NativeFieldInfoPtr_IgnoredBlockReasons, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Dictionary<BlockReason, int> BlockReasonPriorities
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.NativeFieldInfoPtr_BlockReasonPriorities, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<BlockReason, int>) null : new Dictionary<BlockReason, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.NativeFieldInfoPtr_BlockReasonPriorities, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnStartRunning_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnStartRunning_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TempUpdatePick_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___TempUpdatePick_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___TempUpdatePick_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TempUpdatePick_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___TempUpdatePick_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___TempUpdatePick_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TryFindBuildMenu_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___TryFindBuildMenu_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___TryFindBuildMenu_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TryFindBuildMenu_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___TryFindBuildMenu_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___TryFindBuildMenu_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __DoPlacementRequest_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___DoPlacementRequest_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___DoPlacementRequest_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __DoPlacementRequestWithDebug_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___DoPlacementRequestWithDebug_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___DoPlacementRequestWithDebug_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateUnlockedBlueprints_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateUnlockedBlueprints_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateUnlockedBlueprints_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateUnlockedBlueprints_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr___UpdateUnlockedBlueprints_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_HybridCameraData_10
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_10));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_10)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_11
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_11));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_11)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_BuildMenuPickedEntity_12
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_BuildMenuPickedEntity_12));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_BuildMenuPickedEntity_12)) = value;
      }
    }

    public class VariationSelectionWheel : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Wheel;
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      private static readonly System.IntPtr NativeFieldInfoPtr_WallpaperOrientation;
      private static readonly System.IntPtr NativeFieldInfoPtr_Datas;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Active_Internal_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      public unsafe bool Active
      {
        [CallerCount(4), CachedScanResults(RefRangeStart = 750608, RefRangeEnd = 750612, XrefRangeStart = 750608, XrefRangeEnd = 750612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.VariationSelectionWheel.NativeMethodInfoPtr_get_Active_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223680, RefRangeEnd = 1223681, XrefRangeStart = 1223672, XrefRangeEnd = 1223680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VariationSelectionWheel()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.VariationSelectionWheel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static VariationSelectionWheel()
      {
        Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (VariationSelectionWheel));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr);
        BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr, nameof (Wheel));
        BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr, nameof (Target));
        BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_WallpaperOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr, nameof (WallpaperOrientation));
        BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr, nameof (Datas));
        BuildMenuMapper.VariationSelectionWheel.NativeMethodInfoPtr_get_Active_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr, 100664925);
        BuildMenuMapper.VariationSelectionWheel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.VariationSelectionWheel>.NativeClassPtr, 100664926);
      }

      public VariationSelectionWheel(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ActionWheel Wheel
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Wheel));
          return pointer == System.IntPtr.Zero ? (ActionWheel) null : new ActionWheel(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Wheel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity Target
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Target));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Target)) = value;
        }
      }

      public unsafe WallpaperOrientation WallpaperOrientation
      {
        get
        {
          return *(WallpaperOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_WallpaperOrientation));
        }
        [param: In] set
        {
          *(WallpaperOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_WallpaperOrientation)) = value;
        }
      }

      public unsafe List<ActionWheelData> Datas
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Datas));
          return pointer == System.IntPtr.Zero ? (List<ActionWheelData>) null : new List<ActionWheelData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.VariationSelectionWheel.NativeFieldInfoPtr_Datas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct IdentifiedPlacementOperation
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Operation;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementExistingEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_CheckIfCanDismantle;
      [FieldOffset(0)]
      public PlacementOperation Operation;
      [FieldOffset(4)]
      public Entity PlacementExistingEntity;
      [FieldOffset(12)]
      public bool CheckIfCanDismantle;

      static IdentifiedPlacementOperation()
      {
        Il2CppClassPointerStore<BuildMenuMapper.IdentifiedPlacementOperation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, nameof (IdentifiedPlacementOperation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.IdentifiedPlacementOperation>.NativeClassPtr);
        BuildMenuMapper.IdentifiedPlacementOperation.NativeFieldInfoPtr_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.IdentifiedPlacementOperation>.NativeClassPtr, nameof (Operation));
        BuildMenuMapper.IdentifiedPlacementOperation.NativeFieldInfoPtr_PlacementExistingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.IdentifiedPlacementOperation>.NativeClassPtr, nameof (PlacementExistingEntity));
        BuildMenuMapper.IdentifiedPlacementOperation.NativeFieldInfoPtr_CheckIfCanDismantle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.IdentifiedPlacementOperation>.NativeClassPtr, nameof (CheckIfCanDismantle));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.IdentifiedPlacementOperation>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/<>c__DisplayClass58_0")]
    public sealed class __c__DisplayClass58_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_mousePos;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TempUpdatePick_b__0_Internal_Void_byref_Translation_byref_BuildMenuWallpaperOperation_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass58_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TempUpdatePick_b__0(
        ref Translation translation,
        ref BuildMenuWallpaperOperation operation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref operation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass58_0.NativeMethodInfoPtr__TempUpdatePick_b__0_Internal_Void_byref_Translation_byref_BuildMenuWallpaperOperation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass58_0()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass58_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr, "<>4__this");
        BuildMenuMapper.__c__DisplayClass58_0.NativeFieldInfoPtr_mousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr, nameof (mousePos));
        BuildMenuMapper.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr, 100664927);
        BuildMenuMapper.__c__DisplayClass58_0.NativeMethodInfoPtr__TempUpdatePick_b__0_Internal_Void_byref_Translation_byref_BuildMenuWallpaperOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr, 100664928);
      }

      public __c__DisplayClass58_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass58_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass58_0>.NativeClassPtr, data));
      }

      public unsafe BuildMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BuildMenuMapper) null : new BuildMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float3 mousePos
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass58_0.NativeFieldInfoPtr_mousePos));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass58_0.NativeFieldInfoPtr_mousePos)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/<>c__DisplayClass77_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass77_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newPlacementResult;
      private static readonly System.IntPtr NativeFieldInfoPtr_operation;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobData;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdatePlacementResult_b__0_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdatePlacementResult_b__1_Internal_Void_0;
      [FieldOffset(0)]
      public PlacementResult newPlacementResult;
      [FieldOffset(144)]
      public GetPlacementResult.Operation operation;
      [FieldOffset(208)]
      public GetPlacementResult.JobData jobData;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass77_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdatePlacementResult_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass77_0.NativeMethodInfoPtr__UpdatePlacementResult_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdatePlacementResult_b__1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass77_0.NativeMethodInfoPtr__UpdatePlacementResult_b__1_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass77_0()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass77_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass77_0.NativeFieldInfoPtr_newPlacementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr, nameof (newPlacementResult));
        BuildMenuMapper.__c__DisplayClass77_0.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr, nameof (operation));
        BuildMenuMapper.__c__DisplayClass77_0.NativeFieldInfoPtr_jobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr, nameof (jobData));
        BuildMenuMapper.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr, 100664929);
        BuildMenuMapper.__c__DisplayClass77_0.NativeMethodInfoPtr__UpdatePlacementResult_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr, 100664930);
        BuildMenuMapper.__c__DisplayClass77_0.NativeMethodInfoPtr__UpdatePlacementResult_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr, 100664931);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass77_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__84_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateBlueprintRequirements_b__84_0_Internal_Int32_BuildMenu_TopStructureEntry_Data_BuildMenu_TopStructureEntry_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuMapper.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223681, XrefRangeEnd = 1223682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _UpdateBlueprintRequirements_b__84_0(
        BuildMenu_TopStructureEntry_Data a,
        BuildMenu_TopStructureEntry_Data b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c.NativeMethodInfoPtr__UpdateBlueprintRequirements_b__84_0_Internal_Int32_BuildMenu_TopStructureEntry_Data_BuildMenu_TopStructureEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c>.NativeClassPtr);
        BuildMenuMapper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c>.NativeClassPtr, "<>9");
        BuildMenuMapper.__c.NativeFieldInfoPtr___9__84_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c>.NativeClassPtr, "<>9__84_0");
        BuildMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c>.NativeClassPtr, 100664933);
        BuildMenuMapper.__c.NativeMethodInfoPtr__UpdateBlueprintRequirements_b__84_0_Internal_Int32_BuildMenu_TopStructureEntry_Data_BuildMenu_TopStructureEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c>.NativeClassPtr, 100664934);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe BuildMenuMapper.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (BuildMenuMapper.__c) null : new BuildMenuMapper.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<BuildMenu_TopStructureEntry_Data> __9__84_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c.NativeFieldInfoPtr___9__84_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<BuildMenu_TopStructureEntry_Data>) null : new Il2CppSystem.Comparison<BuildMenu_TopStructureEntry_Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c.NativeFieldInfoPtr___9__84_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/<>c__DisplayClass88_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass88_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_unlockedBlueprints;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateUnlockedBlueprints_b__0_Internal_Void_byref_BlueprintData_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateUnlockedBlueprints_b__1_Internal_Void_byref_BlueprintData_byref_DynamicBuffer_1_ProgressionDependencyElement_0;
      [FieldOffset(0)]
      public NativeHashSet<PrefabGUID> unlockedBlueprints;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass88_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateUnlockedBlueprints_b__0(
        [In] ref BlueprintData blueprintData,
        [In] ref PrefabGUID prefabGuid)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref blueprintData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass88_0.NativeMethodInfoPtr__UpdateUnlockedBlueprints_b__0_Internal_Void_byref_BlueprintData_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateUnlockedBlueprints_b__1(
        [In] ref BlueprintData blueprintData,
        [In] ref DynamicBuffer<ProgressionDependencyElement> dependencyBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref blueprintData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dependencyBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass88_0.NativeMethodInfoPtr__UpdateUnlockedBlueprints_b__1_Internal_Void_byref_BlueprintData_byref_DynamicBuffer_1_ProgressionDependencyElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass88_0()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass88_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass88_0>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass88_0.NativeFieldInfoPtr_unlockedBlueprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass88_0>.NativeClassPtr, nameof (unlockedBlueprints));
        BuildMenuMapper.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass88_0>.NativeClassPtr, 100664935);
        BuildMenuMapper.__c__DisplayClass88_0.NativeMethodInfoPtr__UpdateUnlockedBlueprints_b__0_Internal_Void_byref_BlueprintData_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass88_0>.NativeClassPtr, 100664936);
        BuildMenuMapper.__c__DisplayClass88_0.NativeMethodInfoPtr__UpdateUnlockedBlueprints_b__1_Internal_Void_byref_BlueprintData_byref_DynamicBuffer_1_ProgressionDependencyElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass88_0>.NativeClassPtr, 100664937);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass88_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_OnStartRunning_LambdaJob0")]
    public sealed class __c__DisplayClass_OnStartRunning_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_UICanvasBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223695, RefRangeEnd = 1223696, XrefRangeStart = 1223693, XrefRangeEnd = 1223695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref UICanvasBase canvasBase)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
        numPtr1[0] = (System.IntPtr) &entity;
        System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvasBase);
        System.IntPtr* numPtr2 = &ptr;
        *(System.IntPtr*) num = (System.IntPtr) numPtr2;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_UICanvasBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UICanvasBase local = ref canvasBase;
        System.IntPtr pointer = ptr;
        UICanvasBase uiCanvasBase = pointer == System.IntPtr.Zero ? (UICanvasBase) null : new UICanvasBase(pointer);
        local = uiCanvasBase;
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223696, XrefRangeEnd = 1223698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223704, RefRangeEnd = 1223705, XrefRangeStart = 1223698, XrefRangeEnd = 1223704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223707, RefRangeEnd = 1223708, XrefRangeStart = 1223705, XrefRangeEnd = 1223707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(BuildMenuMapper componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223708, XrefRangeEnd = 1223714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnStartRunning_LambdaJob0()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnStartRunning_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100664938);
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100664939);
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100664940);
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100664941);
        BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100664942);
      }

      public __c__DisplayClass_OnStartRunning_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnStartRunning_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe BuildMenuMapper hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (BuildMenuMapper) null : new BuildMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_canvasBase;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase> forParameter_canvasBase;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223686, RefRangeEnd = 1223687, XrefRangeStart = 1223682, XrefRangeEnd = 1223686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BuildMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223692, RefRangeEnd = 1223693, XrefRangeStart = 1223687, XrefRangeEnd = 1223692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_canvasBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_canvasBase));
          BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664943);
          BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664944);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_canvasBase;

          static Runtimes()
          {
            Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvasBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_canvasBase));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime runtime_canvasBase
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvasBase);
              return new LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvasBase), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_TempUpdatePick_LambdaJob0")]
    public sealed class __c__DisplayClass_TempUpdatePick_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_mousePos;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_BuildMenuWallpaperOperation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass58_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass58_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass58_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223728, RefRangeEnd = 1223729, XrefRangeStart = 1223728, XrefRangeEnd = 1223728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref Translation translation,
        ref BuildMenuWallpaperOperation operation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref operation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_BuildMenuWallpaperOperation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1223730, RefRangeEnd = 1223732, XrefRangeStart = 1223729, XrefRangeEnd = 1223730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass58_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass58_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1223733, RefRangeEnd = 1223735, XrefRangeStart = 1223732, XrefRangeEnd = 1223733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass58_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass58_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223735, XrefRangeEnd = 1223737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223745, RefRangeEnd = 1223746, XrefRangeStart = 1223737, XrefRangeEnd = 1223745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223748, RefRangeEnd = 1223749, XrefRangeStart = 1223746, XrefRangeEnd = 1223748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BuildMenuMapper componentSystem,
        ref BuildMenuMapper.__c__DisplayClass58_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass58_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223749, XrefRangeEnd = 1223755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TempUpdatePick_LambdaJob0()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass_TempUpdatePick_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, "<>4__this");
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr_mousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, nameof (mousePos));
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Translation_byref_BuildMenuWallpaperOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, 100664945);
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass58_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, 100664946);
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass58_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, 100664947);
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, 100664948);
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, 100664949);
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass58_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, 100664950);
        BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, 100664951);
      }

      public __c__DisplayClass_TempUpdatePick_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_TempUpdatePick_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe BuildMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BuildMenuMapper) null : new BuildMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float3 mousePos
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr_mousePos));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr_mousePos)) = value;
        }
      }

      public unsafe BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_operation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<BuildMenuWallpaperOperation> forParameter_operation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223720, RefRangeEnd = 1223721, XrefRangeStart = 1223714, XrefRangeEnd = 1223720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BuildMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223727, RefRangeEnd = 1223728, XrefRangeStart = 1223721, XrefRangeEnd = 1223727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_operation));
          BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664952);
          BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664953);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_operation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<BuildMenuWallpaperOperation>.Runtime runtime_operation;

          static Runtimes()
          {
            Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_operation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TempUpdatePick_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_TryFindBuildMenu_LambdaJob0")]
    public sealed class __c__DisplayClass_TryFindBuildMenu_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_BuildMenu_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223768, RefRangeEnd = 1223769, XrefRangeStart = 1223766, XrefRangeEnd = 1223768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, BuildMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_BuildMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223769, XrefRangeEnd = 1223771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223777, RefRangeEnd = 1223778, XrefRangeStart = 1223771, XrefRangeEnd = 1223777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223780, RefRangeEnd = 1223781, XrefRangeStart = 1223778, XrefRangeEnd = 1223780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(BuildMenuMapper componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223781, XrefRangeEnd = 1223787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TryFindBuildMenu_LambdaJob0()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass_TryFindBuildMenu_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_BuildMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, 100664954);
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, 100664955);
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, 100664956);
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, 100664957);
        BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, 100664958);
      }

      public __c__DisplayClass_TryFindBuildMenu_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_TryFindBuildMenu_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe BuildMenuMapper hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (BuildMenuMapper) null : new BuildMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menu;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<BuildMenu> forParameter_menu;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223759, RefRangeEnd = 1223760, XrefRangeStart = 1223755, XrefRangeEnd = 1223759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BuildMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223765, RefRangeEnd = 1223766, XrefRangeStart = 1223760, XrefRangeEnd = 1223765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menu));
          BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664959);
          BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664960);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menu;

          static Runtimes()
          {
            Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menu));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<BuildMenu>.Runtime runtime_menu
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu);
              return new LambdaParameterValueProvider_ManagedComponentData<BuildMenu>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<BuildMenu>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuMapper.__c__DisplayClass_TryFindBuildMenu_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<BuildMenu>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_DoPlacementRequest")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DoPlacementRequest
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_operation;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_newPlacementResult;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass77_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public GetPlacementResult.Operation operation;
      [FieldOffset(64)]
      public GetPlacementResult.JobData jobData;
      [FieldOffset(3768)]
      public PlacementResult newPlacementResult;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136623, RefRangeEnd = 1136627, XrefRangeStart = 1136623, XrefRangeEnd = 1136627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136628, RefRangeEnd = 1136632, XrefRangeStart = 1136628, XrefRangeEnd = 1136632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass77_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136633, RefRangeEnd = 1136635, XrefRangeStart = 1136633, XrefRangeEnd = 1136635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass77_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136636, RefRangeEnd = 1136640, XrefRangeStart = 1136636, XrefRangeEnd = 1136640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136641, RefRangeEnd = 1136643, XrefRangeStart = 1136641, XrefRangeEnd = 1136643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BuildMenuMapper componentSystem,
        ref BuildMenuMapper.__c__DisplayClass77_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass77_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223862, XrefRangeEnd = 1223866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136734, RefRangeEnd = 1136736, XrefRangeStart = 1136734, XrefRangeEnd = 1136736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DoPlacementRequest()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass_DoPlacementRequest");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (operation));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_jobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (jobData));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_newPlacementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (newPlacementResult));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100664961);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100664962);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100664963);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100664964);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass77_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100664965);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100664966);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100664967);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_DoPlacementRequest/ProjectM.UI.RunWithoutJobSystem_0000059F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, "RunWithoutJobSystem_0000059F$PostfixBurstDelegate");
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664968);
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664969);
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664970);
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664971);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_DoPlacementRequest/ProjectM.UI.RunWithoutJobSystem_0000059F$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223787, XrefRangeEnd = 1223801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223801, XrefRangeEnd = 1223819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223819, XrefRangeEnd = 1223834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223861, RefRangeEnd = 1223862, XrefRangeStart = 1223834, XrefRangeEnd = 1223861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, "RunWithoutJobSystem_0000059F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664972);
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664973);
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664974);
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664975);
          BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664977);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_DoPlacementRequestWithDebug")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DoPlacementRequestWithDebug
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_operation;
      private static readonly System.IntPtr NativeFieldInfoPtr_jobData;
      private static readonly System.IntPtr NativeFieldInfoPtr_newPlacementResult;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass77_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public GetPlacementResult.Operation operation;
      [FieldOffset(64)]
      public GetPlacementResult.JobData jobData;
      [FieldOffset(3768)]
      public PlacementResult newPlacementResult;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136623, RefRangeEnd = 1136627, XrefRangeStart = 1136623, XrefRangeEnd = 1136627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136628, RefRangeEnd = 1136632, XrefRangeStart = 1136628, XrefRangeEnd = 1136632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass77_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136633, RefRangeEnd = 1136635, XrefRangeStart = 1136633, XrefRangeEnd = 1136635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass77_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136636, RefRangeEnd = 1136640, XrefRangeStart = 1136636, XrefRangeEnd = 1136640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136641, RefRangeEnd = 1136643, XrefRangeStart = 1136641, XrefRangeEnd = 1136643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BuildMenuMapper componentSystem,
        ref BuildMenuMapper.__c__DisplayClass77_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass77_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136734, RefRangeEnd = 1136736, XrefRangeStart = 1136734, XrefRangeEnd = 1136736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DoPlacementRequestWithDebug()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass_DoPlacementRequestWithDebug");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, nameof (operation));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeFieldInfoPtr_jobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, nameof (jobData));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeFieldInfoPtr_newPlacementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, nameof (newPlacementResult));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, 100664978);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, 100664979);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass77_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, 100664980);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, 100664981);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass77_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, 100664982);
        BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, 100664983);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_DoPlacementRequestWithDebug.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_unlockedBlueprints;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass88_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<PrefabGUID> unlockedBlueprints;
      [FieldOffset(16)]
      public BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223955, XrefRangeEnd = 1223958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref BlueprintData blueprintData,
        [In] ref PrefabGUID prefabGuid)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref blueprintData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass88_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass88_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223958, XrefRangeEnd = 1223960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223968, RefRangeEnd = 1223969, XrefRangeStart = 1223960, XrefRangeEnd = 1223968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1223971, RefRangeEnd = 1223972, XrefRangeStart = 1223969, XrefRangeEnd = 1223971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BuildMenuMapper componentSystem,
        ref BuildMenuMapper.__c__DisplayClass88_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass88_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223972, XrefRangeEnd = 1223976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223976, XrefRangeEnd = 1223982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr_unlockedBlueprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, nameof (unlockedBlueprints));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, 100664984);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, 100664985);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, 100664986);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, 100664987);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, 100664988);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass88_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, 100664989);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, 100664990);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, 100664991);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blueprintData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGuid;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BlueprintData> forParameter_blueprintData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGuid;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223872, RefRangeEnd = 1223873, XrefRangeStart = 1223866, XrefRangeEnd = 1223872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BuildMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223879, RefRangeEnd = 1223880, XrefRangeStart = 1223873, XrefRangeEnd = 1223879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blueprintData));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGuid));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664992);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664993);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blueprintData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGuid;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BlueprintData>.Runtime runtime_blueprintData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGuid;

          static Runtimes()
          {
            Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blueprintData));
            BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGuid));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0/ProjectM.UI.RunWithoutJobSystem_000005AC$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000005AC$PostfixBurstDelegate");
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664994);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664995);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664996);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664997);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0/ProjectM.UI.RunWithoutJobSystem_000005AC$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223880, XrefRangeEnd = 1223894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223894, XrefRangeEnd = 1223912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223912, XrefRangeEnd = 1223927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223954, RefRangeEnd = 1223955, XrefRangeStart = 1223927, XrefRangeEnd = 1223954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000005AC$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664998);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664999);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665000);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665001);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665003);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_unlockedBlueprints;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_DynamicBuffer_1_ProgressionDependencyElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass88_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<PrefabGUID> unlockedBlueprints;
      [FieldOffset(16)]
      public BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224071, XrefRangeEnd = 1224082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref BlueprintData blueprintData,
        [In] ref DynamicBuffer<ProgressionDependencyElement> dependencyBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref blueprintData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dependencyBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_DynamicBuffer_1_ProgressionDependencyElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass88_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BuildMenuMapper.__c__DisplayClass88_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224082, XrefRangeEnd = 1224084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1224092, RefRangeEnd = 1224093, XrefRangeStart = 1224084, XrefRangeEnd = 1224092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1224095, RefRangeEnd = 1224096, XrefRangeStart = 1224093, XrefRangeEnd = 1224095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BuildMenuMapper componentSystem,
        ref BuildMenuMapper.__c__DisplayClass88_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass88_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224096, XrefRangeEnd = 1224100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224100, XrefRangeEnd = 1224106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1()
      {
        Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper>.NativeClassPtr, "<>c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr_unlockedBlueprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, nameof (unlockedBlueprints));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_DynamicBuffer_1_ProgressionDependencyElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, 100665004);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, 100665005);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass88_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, 100665006);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, 100665007);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, 100665008);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_byref___c__DisplayClass88_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, 100665009);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, 100665010);
        BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, 100665011);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blueprintData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dependencyBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BlueprintData> forParameter_blueprintData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<ProgressionDependencyElement> forParameter_dependencyBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223988, RefRangeEnd = 1223989, XrefRangeStart = 1223982, XrefRangeEnd = 1223988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BuildMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1223995, RefRangeEnd = 1223996, XrefRangeStart = 1223989, XrefRangeEnd = 1223995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blueprintData));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dependencyBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dependencyBuffer));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100665012);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100665013);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blueprintData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dependencyBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BlueprintData>.Runtime runtime_blueprintData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<ProgressionDependencyElement>.Runtime runtime_dependencyBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blueprintData));
            BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dependencyBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dependencyBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1/ProjectM.UI.RunWithoutJobSystem_000005B5$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000005B5$PostfixBurstDelegate");
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665014);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665015);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665016);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665017);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.BuildMenuMapper/ProjectM.UI.<>c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1/ProjectM.UI.RunWithoutJobSystem_000005B5$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223996, XrefRangeEnd = 1224010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224010, XrefRangeEnd = 1224028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224028, XrefRangeEnd = 1224043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1224070, RefRangeEnd = 1224071, XrefRangeStart = 1224043, XrefRangeEnd = 1224070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000005B5$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665018);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665019);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665020);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665021);
          BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665023);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BuildMenuMapper.__c__DisplayClass_UpdateUnlockedBlueprints_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
