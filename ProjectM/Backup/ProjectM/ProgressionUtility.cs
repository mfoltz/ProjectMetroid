// Decompiled with JetBrains decompiler
// Type: ProjectM.ProgressionUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using ProjectM.Shared;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class ProgressionUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Shapeshift_NormalFormGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr__VBloodUnlockedCache;
    private static readonly System.IntPtr NativeFieldInfoPtr_SHAPESHIFT_ABILITY_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_EMOTE_ABILITY_COUNT;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUnlockedBuffers_Public_Static_Void_Entity_DynamicBuffer_1_UnlockedProgressionElement_byref_UpdateUnlockedJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUnlockedBuffers_Public_Static_Void_Entity_DynamicBuffer_1_UnlockedProgressionElement_UserContentFlags_byref_UpdateUnlockedJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlockedAbilityCount_Public_Static_Int32_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnlockedShapeshift_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_byref_ProgressionNotUnlockedReason_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetProgressionEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetProgressionEntity_Public_Static_Boolean_Entity_ComponentDataFromEntity_1_ProgressionMapper_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDiscoveredMapZones_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_DiscoveredMapZoneElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasDiscoveredMapZone_Public_Static_Boolean_EntityManager_Entity_MapZoneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasDiscoveredMapZone_Public_Static_Boolean_MapZoneId_DynamicBuffer_1_DiscoveredMapZoneElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnlockedProgressionOrDefault_Public_Static_Boolean_EntityManager_ComponentSystemBase_Entity_PrefabGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnlockedProgression_Public_Static_Boolean_EntityManager_ComponentSystemBase_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnlockedProgression_Public_Static_Boolean_EntityManager_byref_SyncedServerDebugSettings_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnlockedRecipeForItem_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_byref_Nullable_Unboxed_1_RecipeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMappedShapeshiftAbilities_Public_Static_Void_byref_NativeList_1_PrefabGUID_EntityManager_Entity_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMappedShapeshiftAbility_Private_Static_PrefabGUID_Int32_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearMappedShapeshiftAbilities_Public_Static_Void_EntityManager_Entity_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShapeshiftSettingsKey_Private_Static_String_Int32_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMappedShapeshiftAbility_Public_Static_Void_Int32_EntityManager_Entity_GameDataSystem_PrefabGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMappedEmoteAbilities_Public_Static_Void_byref_NativeList_1_PrefabGUID_EntityManager_Entity_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMappedEmoteAbility_Private_Static_PrefabGUID_Int32_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEmoteSettingsKey_Private_Static_String_Int32_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMappedEmoteAbility_Public_Static_Void_Int32_EntityManager_Entity_GameDataSystem_PrefabGUID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AlwaysUnlocked_Public_Static_Boolean_byref_RecipeData_EntityManager_NativeHashMap_2_PrefabGUID_PrefabGUID_PrefabLookupMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HideInStation_Public_Static_Boolean_byref_RefinementstationRecipesBuffer_EntityManager_NativeHashMap_2_PrefabGUID_PrefabGUID_PrefabLookupMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UserOwnsRequiredContent_Public_Static_Boolean_byref_RecipeData_UserContentFlags_NativeHashMap_2_PrefabGUID_UserContentFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GatherUnlockedRecipes_Public_Static_Void_EntityManager_Entity_NativeHashSet_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearCachedUnlockedVBloods_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCachedUnlockedVBlood_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1029352, RefRangeEnd = 1029360, XrefRangeStart = 1029342, XrefRangeEnd = 1029352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateUnlockedBuffers(
      Entity progressionEntity,
      DynamicBuffer<UnlockedProgressionElement> unlockedProgressionElements,
      [In] ref ProgressionUtility.UpdateUnlockedJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unlockedProgressionElements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_UpdateUnlockedBuffers_Public_Static_Void_Entity_DynamicBuffer_1_UnlockedProgressionElement_byref_UpdateUnlockedJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1029616, RefRangeEnd = 1029620, XrefRangeStart = 1029360, XrefRangeEnd = 1029616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateUnlockedBuffers(
      Entity progressionEntity,
      DynamicBuffer<UnlockedProgressionElement> unlockedProgressionElements,
      UserContentFlags userContentFlags,
      [In] ref ProgressionUtility.UpdateUnlockedJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unlockedProgressionElements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userContentFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_UpdateUnlockedBuffers_Public_Static_Void_Entity_DynamicBuffer_1_UnlockedProgressionElement_UserContentFlags_byref_UpdateUnlockedJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1029629, RefRangeEnd = 1029630, XrefRangeStart = 1029620, XrefRangeEnd = 1029629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetUnlockedAbilityCount(
      EntityManager entityManager,
      Entity progressionEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GetUnlockedAbilityCount_Public_Static_Int32_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1029659, RefRangeEnd = 1029666, XrefRangeStart = 1029630, XrefRangeEnd = 1029659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasUnlockedShapeshift(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Entity user,
      PrefabGUID shapeShift,
      out ProgressionUtility.ProgressionNotUnlockedReason notUnlockedReason)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &shapeShift;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref notUnlockedReason;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_HasUnlockedShapeshift_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_byref_ProgressionNotUnlockedReason_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(39)]
    [CachedScanResults(RefRangeStart = 1029670, RefRangeEnd = 1029709, XrefRangeStart = 1029666, XrefRangeEnd = 1029670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetProgressionEntity(
      EntityManager entityManager,
      Entity user,
      out Entity progressionEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref progressionEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_TryGetProgressionEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1029716, RefRangeEnd = 1029717, XrefRangeStart = 1029709, XrefRangeEnd = 1029716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetProgressionEntity(
      Entity user,
      ComponentDataFromEntity<ProgressionMapper> getProgressionMapper,
      out Entity progressionEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getProgressionMapper;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref progressionEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_TryGetProgressionEntity_Public_Static_Boolean_Entity_ComponentDataFromEntity_1_ProgressionMapper_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1029727, RefRangeEnd = 1029728, XrefRangeStart = 1029717, XrefRangeEnd = 1029727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetDiscoveredMapZones(
      EntityManager entityManager,
      Entity user,
      out DynamicBuffer<DiscoveredMapZoneElement> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_TryGetDiscoveredMapZones_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_DiscoveredMapZoneElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1029751, RefRangeEnd = 1029753, XrefRangeStart = 1029728, XrefRangeEnd = 1029751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasDiscoveredMapZone(
      EntityManager entityManager,
      Entity user,
      MapZoneId zoneId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &zoneId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_HasDiscoveredMapZone_Public_Static_Boolean_EntityManager_Entity_MapZoneId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1029762, RefRangeEnd = 1029763, XrefRangeStart = 1029753, XrefRangeEnd = 1029762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasDiscoveredMapZone(
      MapZoneId zoneId,
      DynamicBuffer<DiscoveredMapZoneElement> discoveredMapZones)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &zoneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &discoveredMapZones;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_HasDiscoveredMapZone_Public_Static_Boolean_MapZoneId_DynamicBuffer_1_DiscoveredMapZoneElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1029769, RefRangeEnd = 1029775, XrefRangeStart = 1029763, XrefRangeEnd = 1029769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasUnlockedProgressionOrDefault(
      EntityManager entityManager,
      ComponentSystemBase system,
      Entity progressionEntity,
      PrefabGUID progression,
      bool resultIfProgressionGuidDefault)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &progression;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &resultIfProgressionGuidDefault;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_HasUnlockedProgressionOrDefault_Public_Static_Boolean_EntityManager_ComponentSystemBase_Entity_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 1029780, RefRangeEnd = 1029796, XrefRangeStart = 1029775, XrefRangeEnd = 1029780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasUnlockedProgression(
      EntityManager entityManager,
      ComponentSystemBase system,
      Entity progressionEntity,
      PrefabGUID progression)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &progression;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_HasUnlockedProgression_Public_Static_Boolean_EntityManager_ComponentSystemBase_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1029872, RefRangeEnd = 1029877, XrefRangeStart = 1029796, XrefRangeEnd = 1029872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasUnlockedProgression(
      EntityManager entityManager,
      ref SyncedServerDebugSettings syncedServerDebugSettings,
      Entity progressionEntity,
      PrefabGUID progression)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref syncedServerDebugSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &progression;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_HasUnlockedProgression_Public_Static_Boolean_EntityManager_byref_SyncedServerDebugSettings_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1029908, RefRangeEnd = 1029909, XrefRangeStart = 1029877, XrefRangeEnd = 1029908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasUnlockedRecipeForItem(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Entity progressionEntity,
      PrefabGUID item,
      out Nullable_Unboxed<RecipeData> recipeData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &item;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref recipeData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_HasUnlockedRecipeForItem_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_byref_Nullable_Unboxed_1_RecipeData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1029965, RefRangeEnd = 1029969, XrefRangeStart = 1029909, XrefRangeEnd = 1029965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetMappedShapeshiftAbilities(
      ref NativeList<PrefabGUID> output,
      EntityManager entityManager,
      Entity userEntity,
      GameDataSystem gameDataSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref output;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GetMappedShapeshiftAbilities_Public_Static_Void_byref_NativeList_1_PrefabGUID_EntityManager_Entity_GameDataSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1029974, RefRangeEnd = 1029976, XrefRangeStart = 1029969, XrefRangeEnd = 1029974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PrefabGUID GetMappedShapeshiftAbility(int slot, User user)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &slot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GetMappedShapeshiftAbility_Private_Static_PrefabGUID_Int32_User_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029976, XrefRangeEnd = 1029985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearMappedShapeshiftAbilities(
      EntityManager entityManager,
      Entity userEntity,
      GameDataSystem gameDataSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_ClearMappedShapeshiftAbilities_Public_Static_Void_EntityManager_Entity_GameDataSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1029994, RefRangeEnd = 1029996, XrefRangeStart = 1029985, XrefRangeEnd = 1029994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetShapeshiftSettingsKey(int slot, User user)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &slot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GetShapeshiftSettingsKey_Private_Static_String_Int32_User_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1030024, RefRangeEnd = 1030028, XrefRangeStart = 1029996, XrefRangeEnd = 1030024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetMappedShapeshiftAbility(
      int slot,
      EntityManager entityManager,
      Entity userEntity,
      GameDataSystem gameDataSystem,
      PrefabGUID prefabGuid,
      bool clearPrevious = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &slot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &clearPrevious;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_SetMappedShapeshiftAbility_Public_Static_Void_Int32_EntityManager_Entity_GameDataSystem_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1030081, RefRangeEnd = 1030085, XrefRangeStart = 1030028, XrefRangeEnd = 1030081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetMappedEmoteAbilities(
      ref NativeList<PrefabGUID> output,
      EntityManager entityManager,
      Entity userEntity,
      GameDataSystem gameDataSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref output;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GetMappedEmoteAbilities_Public_Static_Void_byref_NativeList_1_PrefabGUID_EntityManager_Entity_GameDataSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1030090, RefRangeEnd = 1030092, XrefRangeStart = 1030085, XrefRangeEnd = 1030090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PrefabGUID GetMappedEmoteAbility(int slot, User user)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &slot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GetMappedEmoteAbility_Private_Static_PrefabGUID_Int32_User_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1030101, RefRangeEnd = 1030103, XrefRangeStart = 1030092, XrefRangeEnd = 1030101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetEmoteSettingsKey(int slot, User user)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &slot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GetEmoteSettingsKey_Private_Static_String_Int32_User_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1030131, RefRangeEnd = 1030134, XrefRangeStart = 1030103, XrefRangeEnd = 1030131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetMappedEmoteAbility(
      int slot,
      EntityManager entityManager,
      Entity userEntity,
      GameDataSystem gameDataSystem,
      PrefabGUID prefabGuid,
      bool clearPrevious = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &slot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &clearPrevious;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_SetMappedEmoteAbility_Public_Static_Void_Int32_EntityManager_Entity_GameDataSystem_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1030138, RefRangeEnd = 1030145, XrefRangeStart = 1030134, XrefRangeEnd = 1030138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AlwaysUnlocked(
      [In] ref RecipeData recipeData,
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, PrefabGUID> progressionDependencyMap,
      PrefabLookupMap prefabLookupMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref recipeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionDependencyMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_AlwaysUnlocked_Public_Static_Boolean_byref_RecipeData_EntityManager_NativeHashMap_2_PrefabGUID_PrefabGUID_PrefabLookupMap_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1030153, RefRangeEnd = 1030154, XrefRangeStart = 1030145, XrefRangeEnd = 1030153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HideInStation(
      [In] ref RefinementstationRecipesBuffer recipeData,
      EntityManager entityManager,
      NativeHashMap<PrefabGUID, PrefabGUID> progressionDependencyMap,
      PrefabLookupMap prefabLookupMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref recipeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionDependencyMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_HideInStation_Public_Static_Boolean_byref_RefinementstationRecipesBuffer_EntityManager_NativeHashMap_2_PrefabGUID_PrefabGUID_PrefabLookupMap_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1030157, RefRangeEnd = 1030163, XrefRangeStart = 1030154, XrefRangeEnd = 1030157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool UserOwnsRequiredContent(
      [In] ref RecipeData recipeData,
      UserContentFlags userContentFlags,
      NativeHashMap<PrefabGUID, UserContentFlags> userContentDependencies)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref recipeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userContentFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userContentDependencies;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_UserOwnsRequiredContent_Public_Static_Boolean_byref_RecipeData_UserContentFlags_NativeHashMap_2_PrefabGUID_UserContentFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1030198, RefRangeEnd = 1030201, XrefRangeStart = 1030163, XrefRangeEnd = 1030198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GatherUnlockedRecipes(
      EntityManager entityManager,
      Entity progressionEntity,
      NativeHashSet<PrefabGUID> unlockedRecipes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &unlockedRecipes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GatherUnlockedRecipes_Public_Static_Void_EntityManager_Entity_NativeHashSet_1_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1030209, RefRangeEnd = 1030211, XrefRangeStart = 1030201, XrefRangeEnd = 1030209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearCachedUnlockedVBloods()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_ClearCachedUnlockedVBloods_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1030225, RefRangeEnd = 1030230, XrefRangeStart = 1030211, XrefRangeEnd = 1030225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetCachedUnlockedVBlood(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Entity progressionEntity,
      PrefabGUID huntBloodHuntTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &progressionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &huntBloodHuntTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.NativeMethodInfoPtr_GetCachedUnlockedVBlood_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ProgressionUtility()
    {
      Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProgressionUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr);
      ProgressionUtility.NativeFieldInfoPtr_Shapeshift_NormalFormGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, nameof (Shapeshift_NormalFormGUID));
      ProgressionUtility.NativeFieldInfoPtr__VBloodUnlockedCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, nameof (_VBloodUnlockedCache));
      ProgressionUtility.NativeFieldInfoPtr_SHAPESHIFT_ABILITY_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, nameof (SHAPESHIFT_ABILITY_COUNT));
      ProgressionUtility.NativeFieldInfoPtr_EMOTE_ABILITY_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, nameof (EMOTE_ABILITY_COUNT));
      ProgressionUtility.NativeMethodInfoPtr_UpdateUnlockedBuffers_Public_Static_Void_Entity_DynamicBuffer_1_UnlockedProgressionElement_byref_UpdateUnlockedJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680356);
      ProgressionUtility.NativeMethodInfoPtr_UpdateUnlockedBuffers_Public_Static_Void_Entity_DynamicBuffer_1_UnlockedProgressionElement_UserContentFlags_byref_UpdateUnlockedJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680357);
      ProgressionUtility.NativeMethodInfoPtr_GetUnlockedAbilityCount_Public_Static_Int32_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680358);
      ProgressionUtility.NativeMethodInfoPtr_HasUnlockedShapeshift_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_byref_ProgressionNotUnlockedReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680359);
      ProgressionUtility.NativeMethodInfoPtr_TryGetProgressionEntity_Public_Static_Boolean_EntityManager_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680360);
      ProgressionUtility.NativeMethodInfoPtr_TryGetProgressionEntity_Public_Static_Boolean_Entity_ComponentDataFromEntity_1_ProgressionMapper_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680361);
      ProgressionUtility.NativeMethodInfoPtr_TryGetDiscoveredMapZones_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_DiscoveredMapZoneElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680362);
      ProgressionUtility.NativeMethodInfoPtr_HasDiscoveredMapZone_Public_Static_Boolean_EntityManager_Entity_MapZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680363);
      ProgressionUtility.NativeMethodInfoPtr_HasDiscoveredMapZone_Public_Static_Boolean_MapZoneId_DynamicBuffer_1_DiscoveredMapZoneElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680364);
      ProgressionUtility.NativeMethodInfoPtr_HasUnlockedProgressionOrDefault_Public_Static_Boolean_EntityManager_ComponentSystemBase_Entity_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680365);
      ProgressionUtility.NativeMethodInfoPtr_HasUnlockedProgression_Public_Static_Boolean_EntityManager_ComponentSystemBase_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680366);
      ProgressionUtility.NativeMethodInfoPtr_HasUnlockedProgression_Public_Static_Boolean_EntityManager_byref_SyncedServerDebugSettings_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680367);
      ProgressionUtility.NativeMethodInfoPtr_HasUnlockedRecipeForItem_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_byref_Nullable_Unboxed_1_RecipeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680368);
      ProgressionUtility.NativeMethodInfoPtr_GetMappedShapeshiftAbilities_Public_Static_Void_byref_NativeList_1_PrefabGUID_EntityManager_Entity_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680369);
      ProgressionUtility.NativeMethodInfoPtr_GetMappedShapeshiftAbility_Private_Static_PrefabGUID_Int32_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680370);
      ProgressionUtility.NativeMethodInfoPtr_ClearMappedShapeshiftAbilities_Public_Static_Void_EntityManager_Entity_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680371);
      ProgressionUtility.NativeMethodInfoPtr_GetShapeshiftSettingsKey_Private_Static_String_Int32_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680372);
      ProgressionUtility.NativeMethodInfoPtr_SetMappedShapeshiftAbility_Public_Static_Void_Int32_EntityManager_Entity_GameDataSystem_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680373);
      ProgressionUtility.NativeMethodInfoPtr_GetMappedEmoteAbilities_Public_Static_Void_byref_NativeList_1_PrefabGUID_EntityManager_Entity_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680374);
      ProgressionUtility.NativeMethodInfoPtr_GetMappedEmoteAbility_Private_Static_PrefabGUID_Int32_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680375);
      ProgressionUtility.NativeMethodInfoPtr_GetEmoteSettingsKey_Private_Static_String_Int32_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680376);
      ProgressionUtility.NativeMethodInfoPtr_SetMappedEmoteAbility_Public_Static_Void_Int32_EntityManager_Entity_GameDataSystem_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680377);
      ProgressionUtility.NativeMethodInfoPtr_AlwaysUnlocked_Public_Static_Boolean_byref_RecipeData_EntityManager_NativeHashMap_2_PrefabGUID_PrefabGUID_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680378);
      ProgressionUtility.NativeMethodInfoPtr_HideInStation_Public_Static_Boolean_byref_RefinementstationRecipesBuffer_EntityManager_NativeHashMap_2_PrefabGUID_PrefabGUID_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680379);
      ProgressionUtility.NativeMethodInfoPtr_UserOwnsRequiredContent_Public_Static_Boolean_byref_RecipeData_UserContentFlags_NativeHashMap_2_PrefabGUID_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680380);
      ProgressionUtility.NativeMethodInfoPtr_GatherUnlockedRecipes_Public_Static_Void_EntityManager_Entity_NativeHashSet_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680381);
      ProgressionUtility.NativeMethodInfoPtr_ClearCachedUnlockedVBloods_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680382);
      ProgressionUtility.NativeMethodInfoPtr_GetCachedUnlockedVBlood_Public_Static_Boolean_EntityManager_GameDataSystem_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, 100680383);
    }

    public ProgressionUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int Shapeshift_NormalFormGUID
    {
      get
      {
        int shapeshiftNormalFormGuid;
        IL2CPP.il2cpp_field_static_get_value(ProgressionUtility.NativeFieldInfoPtr_Shapeshift_NormalFormGUID, (void*) &shapeshiftNormalFormGuid);
        return shapeshiftNormalFormGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionUtility.NativeFieldInfoPtr_Shapeshift_NormalFormGUID, (void*) &value);
      }
    }

    public static unsafe Dictionary<PrefabGUID, bool> _VBloodUnlockedCache
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ProgressionUtility.NativeFieldInfoPtr__VBloodUnlockedCache, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, bool>) null : new Dictionary<PrefabGUID, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionUtility.NativeFieldInfoPtr__VBloodUnlockedCache, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int SHAPESHIFT_ABILITY_COUNT
    {
      get
      {
        int shapeshiftAbilityCount;
        IL2CPP.il2cpp_field_static_get_value(ProgressionUtility.NativeFieldInfoPtr_SHAPESHIFT_ABILITY_COUNT, (void*) &shapeshiftAbilityCount);
        return shapeshiftAbilityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionUtility.NativeFieldInfoPtr_SHAPESHIFT_ABILITY_COUNT, (void*) &value);
      }
    }

    public static unsafe int EMOTE_ABILITY_COUNT
    {
      get
      {
        int emoteAbilityCount;
        IL2CPP.il2cpp_field_static_get_value(ProgressionUtility.NativeFieldInfoPtr_EMOTE_ABILITY_COUNT, (void*) &emoteAbilityCount);
        return emoteAbilityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionUtility.NativeFieldInfoPtr_EMOTE_ABILITY_COUNT, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateUnlockedJobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionDependencyMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionUserContentFlagsDependencyMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionBookRecipesFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionBookBlueprintsFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_RecipesFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlueprintsFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilitiesFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_PassivesFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionBookShapeshiftFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRecipeDataFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBlueprintDataFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetVBloodAbilityDataFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachedFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_UserFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedRecipesFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedBlueprintsFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedShapeshiftFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedPassiveFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedAbilityFromEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_UpdateUnlockedJobData_ComponentSystemBase_PrefabCollectionSystem_ProgressionDependencySystem_0;
      [FieldOffset(0)]
      public PrefabLookupMap PrefabLookupMap;
      [FieldOffset(48)]
      public NativeMultiHashMap<PrefabGUID, PrefabGUID> ProgressionDependencyMap;
      [FieldOffset(64)]
      public NativeHashMap<PrefabGUID, UserContentFlags> ProgressionUserContentFlagsDependencyMap;
      [FieldOffset(80)]
      public BufferFromEntity<ProgressionBookRecipeElement> ProgressionBookRecipesFromEntity;
      [FieldOffset(120)]
      public BufferFromEntity<ProgressionBookBlueprintElement> ProgressionBookBlueprintsFromEntity;
      [FieldOffset(160)]
      public BufferFromEntity<TechUnlockRecipeBuffer> RecipesFromEntity;
      [FieldOffset(200)]
      public BufferFromEntity<TechUnlockBlueprintBuffer> BlueprintsFromEntity;
      [FieldOffset(240)]
      public BufferFromEntity<TechUnlockAbilityBuffer> AbilitiesFromEntity;
      [FieldOffset(280)]
      public BufferFromEntity<TechUnlockPassiveBuffer> PassivesFromEntity;
      [FieldOffset(320)]
      public BufferFromEntity<ProgressionBookShapeshiftElement> ProgressionBookShapeshiftFromEntity;
      [FieldOffset(360)]
      public ComponentDataFromEntity<RecipeData> GetRecipeDataFromEntity;
      [FieldOffset(392)]
      public ComponentDataFromEntity<BlueprintData> GetBlueprintDataFromEntity;
      [FieldOffset(424)]
      public ComponentDataFromEntity<VBloodAbilityData> GetVBloodAbilityDataFromEntity;
      [FieldOffset(456)]
      public ComponentDataFromEntity<Attached> AttachedFromEntity;
      [FieldOffset(488)]
      public ComponentDataFromEntity<User> UserFromEntity;
      [FieldOffset(520)]
      public BufferFromEntity<UnlockedRecipeElement> UnlockedRecipesFromEntity;
      [FieldOffset(560)]
      public BufferFromEntity<UnlockedBlueprintElement> UnlockedBlueprintsFromEntity;
      [FieldOffset(600)]
      public BufferFromEntity<UnlockedShapeshiftElement> UnlockedShapeshiftFromEntity;
      [FieldOffset(640)]
      public BufferFromEntity<UnlockedPassiveElement> UnlockedPassiveFromEntity;
      [FieldOffset(680)]
      public BufferFromEntity<UnlockedAbilityElement> UnlockedAbilityFromEntity;

      [CallerCount(14)]
      [CachedScanResults(RefRangeStart = 1029328, RefRangeEnd = 1029342, XrefRangeStart = 1029276, XrefRangeEnd = 1029328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe ProgressionUtility.UpdateUnlockedJobData Create(
        ComponentSystemBase system,
        PrefabCollectionSystem prefabCollectionSystem,
        ProgressionDependencySystem progressionDependencySystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) progressionDependencySystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionUtility.UpdateUnlockedJobData.NativeMethodInfoPtr_Create_Public_Static_UpdateUnlockedJobData_ComponentSystemBase_PrefabCollectionSystem_ProgressionDependencySystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ProgressionUtility.UpdateUnlockedJobData*) IL2CPP.il2cpp_object_unbox(num);
      }

      static UpdateUnlockedJobData()
      {
        Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProgressionUtility>.NativeClassPtr, nameof (UpdateUnlockedJobData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr);
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (PrefabLookupMap));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_ProgressionDependencyMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (ProgressionDependencyMap));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_ProgressionUserContentFlagsDependencyMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (ProgressionUserContentFlagsDependencyMap));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_ProgressionBookRecipesFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (ProgressionBookRecipesFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_ProgressionBookBlueprintsFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (ProgressionBookBlueprintsFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_RecipesFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (RecipesFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_BlueprintsFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (BlueprintsFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_AbilitiesFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (AbilitiesFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_PassivesFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (PassivesFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_ProgressionBookShapeshiftFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (ProgressionBookShapeshiftFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_GetRecipeDataFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (GetRecipeDataFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_GetBlueprintDataFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (GetBlueprintDataFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_GetVBloodAbilityDataFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (GetVBloodAbilityDataFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_AttachedFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (AttachedFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_UserFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (UserFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_UnlockedRecipesFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (UnlockedRecipesFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_UnlockedBlueprintsFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (UnlockedBlueprintsFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_UnlockedShapeshiftFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (UnlockedShapeshiftFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_UnlockedPassiveFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (UnlockedPassiveFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeFieldInfoPtr_UnlockedAbilityFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, nameof (UnlockedAbilityFromEntity));
        ProgressionUtility.UpdateUnlockedJobData.NativeMethodInfoPtr_Create_Public_Static_UpdateUnlockedJobData_ComponentSystemBase_PrefabCollectionSystem_ProgressionDependencySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, 100680385);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProgressionUtility.UpdateUnlockedJobData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum ProgressionNotUnlockedReason
    {
      RequiredContentFlagsMissing,
      NotProgressedFarEnough,
      ProgressionDataNotAvailable,
    }
  }
}
