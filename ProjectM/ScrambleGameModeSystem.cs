// Decompiled with JetBrains decompiler
// Type: ScrambleGameModeSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
public class ScrambleGameModeSystem : SystemBase
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_BLOOD_ALTAR_PREFABGUID;
  private static readonly System.IntPtr NativeFieldInfoPtr__HasAppliedScrambleSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_ScrambleSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_1;
  private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_2;
  private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_3;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewScrambleGameModeSettings_Private_Static_ScrambleGameModeSettings_PrefabLookupMap_ServerGameBalanceSettings_EntityManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateRemapping_Private_Static_RemappingData_byref_ScrambleGameModeSettings_PrefabGUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BuildTechMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_PrefabLookupMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BuildSpawnMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_PrefabLookupMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BuildAbilityMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_NativeList_1_PrefabGUID_PrefabLookupMap_EntityManager_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BuildShapeShiftMappings_Private_Static_Void_byref_ScrambleGameModeSettings_NativeList_1_PrefabGUID_PrefabLookupMap_EntityManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeVBloodSpawnMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_NativeList_1_PrefabGUID_PrefabLookupMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeVBloodTechMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_NativeList_1_PrefabGUID_PrefabLookupMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyTechs_Private_Static_Void_PrefabLookupMap_Entity_EntityCommandBuffer_EntityManager_PrefabGUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySpawnRelatedComponents_Private_Static_Void_PrefabLookupMap_Entity_EntityCommandBuffer_EntityManager_RemappingData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilities_Private_Static_Void_EntityManager_PrefabLookupMap_Entity_List_1_PrefabGUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUnitAbilities_Private_Static_Void_PrefabLookupMap_Entity_EntityManager_byref_OriginalData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetShapeShifts_Private_Static_Void_EntityManager_PrefabLookupMap_Entity_List_1_PrefabGUID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureEverythingConverted_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRemappings_Public_Static_Void_EntityManager_EntityCommandBuffer_PrefabLookupMap_ServerGameBalanceSettings_ScrambleGameModeSettings_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeScrambleSettings_Public_Void_ServerGameBalanceSettings_ScrambleGameModeSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_PrefabGUID_byref___c__DisplayClass10_0_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914149, XrefRangeEnd = 914164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScrambleGameModeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914164, XrefRangeEnd = 914192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScrambleGameModeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914234, RefRangeEnd = 914235, XrefRangeStart = 914192, XrefRangeEnd = 914234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScrambleGameModeSettings CreateNewScrambleGameModeSettings(
    PrefabLookupMap prefabLookupMap,
    ServerGameBalanceSettings settings,
    EntityManager entityManager)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_CreateNewScrambleGameModeSettings_Private_Static_ScrambleGameModeSettings_PrefabLookupMap_ServerGameBalanceSettings_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new ScrambleGameModeSettings(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 914253, RefRangeEnd = 914257, XrefRangeStart = 914235, XrefRangeEnd = 914253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScrambleGameModeSettings.RemappingData GetOrCreateRemapping(
    ref ScrambleGameModeSettings newSettings,
    PrefabGUID prefabGuid)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_GetOrCreateRemapping_Private_Static_RemappingData_byref_ScrambleGameModeSettings_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new ScrambleGameModeSettings.RemappingData(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914394, RefRangeEnd = 914395, XrefRangeStart = 914257, XrefRangeEnd = 914394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BuildTechMappings(
    ref ScrambleGameModeSettings newSettings,
    ref Unity.Mathematics.Random random,
    ServerGameBalanceSettings settings,
    PrefabLookupMap prefabLookupMap)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_BuildTechMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_PrefabLookupMap_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914498, RefRangeEnd = 914499, XrefRangeStart = 914395, XrefRangeEnd = 914498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BuildSpawnMappings(
    ref ScrambleGameModeSettings newSettings,
    ref Unity.Mathematics.Random random,
    ServerGameBalanceSettings settings,
    PrefabLookupMap prefabLookupMap)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_BuildSpawnMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_PrefabLookupMap_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 914598, RefRangeEnd = 914600, XrefRangeStart = 914499, XrefRangeEnd = 914598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BuildAbilityMappings(
    ref ScrambleGameModeSettings newSettings,
    ref Unity.Mathematics.Random random,
    NativeList<PrefabGUID> allVBloodUnits,
    PrefabLookupMap prefabLookupMap,
    EntityManager entityManager,
    bool includeOnlyUltimates)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allVBloodUnits;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &includeOnlyUltimates;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_BuildAbilityMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_NativeList_1_PrefabGUID_PrefabLookupMap_EntityManager_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914667, RefRangeEnd = 914668, XrefRangeStart = 914600, XrefRangeEnd = 914667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BuildShapeShiftMappings(
    ref ScrambleGameModeSettings newSettings,
    NativeList<PrefabGUID> allVBloodUnits,
    PrefabLookupMap prefabLookupMap,
    EntityManager entityManager)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allVBloodUnits;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_BuildShapeShiftMappings_Private_Static_Void_byref_ScrambleGameModeSettings_NativeList_1_PrefabGUID_PrefabLookupMap_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 914689, RefRangeEnd = 914692, XrefRangeStart = 914668, XrefRangeEnd = 914689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RandomizeVBloodSpawnMappings(
    ref ScrambleGameModeSettings newSettings,
    ref Unity.Mathematics.Random random,
    ServerGameBalanceSettings settings,
    NativeList<PrefabGUID> vBloodUnits,
    PrefabLookupMap prefabLookupMap)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &vBloodUnits;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_RandomizeVBloodSpawnMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_NativeList_1_PrefabGUID_PrefabLookupMap_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 914717, RefRangeEnd = 914727, XrefRangeStart = 914692, XrefRangeEnd = 914717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RandomizeVBloodTechMappings(
    ref ScrambleGameModeSettings newSettings,
    ref Unity.Mathematics.Random random,
    ServerGameBalanceSettings settings,
    NativeList<PrefabGUID> vBloodUnits,
    PrefabLookupMap prefabLookupMap)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &vBloodUnits;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_RandomizeVBloodTechMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_NativeList_1_PrefabGUID_PrefabLookupMap_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914764, RefRangeEnd = 914765, XrefRangeStart = 914727, XrefRangeEnd = 914764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyTechs(
    PrefabLookupMap prefabLookupMap,
    Entity fromPrefab,
    EntityCommandBuffer commandBuffer,
    EntityManager entityManager,
    PrefabGUID techTarget)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPrefab;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &techTarget;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_CopyTechs_Private_Static_Void_PrefabLookupMap_Entity_EntityCommandBuffer_EntityManager_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914804, RefRangeEnd = 914805, XrefRangeStart = 914765, XrefRangeEnd = 914804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopySpawnRelatedComponents(
    PrefabLookupMap prefabLookupMap,
    Entity fromPrefab,
    EntityCommandBuffer commandBuffer,
    EntityManager entityManager,
    ScrambleGameModeSettings.RemappingData remappingData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromPrefab;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) remappingData));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_CopySpawnRelatedComponents_Private_Static_Void_PrefabLookupMap_Entity_EntityCommandBuffer_EntityManager_RemappingData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914838, RefRangeEnd = 914839, XrefRangeStart = 914805, XrefRangeEnd = 914838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetAbilities(
    EntityManager entityManager,
    PrefabLookupMap prefabLookupMap,
    Entity unitPrefab,
    List<PrefabGUID> targetAbilities)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &unitPrefab;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetAbilities);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_SetAbilities_Private_Static_Void_EntityManager_PrefabLookupMap_Entity_List_1_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 914878, RefRangeEnd = 914879, XrefRangeStart = 914839, XrefRangeEnd = 914878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetUnitAbilities(
    PrefabLookupMap prefabLookupMap,
    Entity unitPrefab,
    EntityManager entityManager,
    ref ScrambleGameModeSystem.OriginalData originalData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unitPrefab;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) originalData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_GetUnitAbilities_Private_Static_Void_PrefabLookupMap_Entity_EntityManager_byref_OriginalData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914879, XrefRangeEnd = 914912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetShapeShifts(
    EntityManager entityManager,
    PrefabLookupMap prefabLookupMap,
    Entity target,
    List<PrefabGUID> shapeshifts)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shapeshifts);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_SetShapeShifts_Private_Static_Void_EntityManager_PrefabLookupMap_Entity_List_1_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnsureEverythingConverted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_EnsureEverythingConverted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 914982, RefRangeEnd = 914984, XrefRangeStart = 914912, XrefRangeEnd = 914982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ApplyRemappings(
    EntityManager entityManager,
    EntityCommandBuffer commandBuffer,
    PrefabLookupMap prefabLookupMap,
    ServerGameBalanceSettings serverGameBalanceSettings,
    ScrambleGameModeSettings scrambleSettings,
    ref bool hasBeenApplied)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &serverGameBalanceSettings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) scrambleSettings));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref hasBeenApplied;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_ApplyRemappings_Public_Static_Void_EntityManager_EntityCommandBuffer_PrefabLookupMap_ServerGameBalanceSettings_ScrambleGameModeSettings_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public virtual unsafe string PersistentIdentifier
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914984, XrefRangeEnd = 914986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914986, XrefRangeEnd = 914993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Serialize(ref NetBufferOut netBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref netBuffer;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914993, XrefRangeEnd = 915007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(ref NetBufferIn netBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref netBuffer;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 915023, RefRangeEnd = 915025, XrefRangeStart = 915007, XrefRangeEnd = 915023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitializeScrambleSettings(
    ServerGameBalanceSettings serverGameBalanceSettings,
    ScrambleGameModeSettings scrambleSettings)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &serverGameBalanceSettings;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) scrambleSettings));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_InitializeScrambleSettings_Public_Void_ServerGameBalanceSettings_ScrambleGameModeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(105)]
  [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScrambleGameModeSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 915029, RefRangeEnd = 915031, XrefRangeStart = 915025, XrefRangeEnd = 915029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Method_Internal_Static_Boolean_PrefabGUID_byref___c__DisplayClass10_0_0(
    PrefabGUID abilityGroupGuid,
    ref ScrambleGameModeSystem.__c__DisplayClass10_0 _param1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &abilityGroupGuid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref _param1;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrambleGameModeSystem.NativeMethodInfoPtr_Method_Internal_Static_Boolean_PrefabGUID_byref___c__DisplayClass10_0_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915031, XrefRangeEnd = 915051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateForCompiler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScrambleGameModeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScrambleGameModeSystem()
  {
    Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ScrambleGameModeSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr);
    ScrambleGameModeSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
    ScrambleGameModeSystem.NativeFieldInfoPtr_BLOOD_ALTAR_PREFABGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, nameof (BLOOD_ALTAR_PREFABGUID));
    ScrambleGameModeSystem.NativeFieldInfoPtr__HasAppliedScrambleSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, nameof (_HasAppliedScrambleSettings));
    ScrambleGameModeSystem.NativeFieldInfoPtr_ScrambleSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, nameof (ScrambleSettings));
    ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_1));
    ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerGameBalanceSettings_2));
    ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerGameBalanceSettings_3));
    ScrambleGameModeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663516);
    ScrambleGameModeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663517);
    ScrambleGameModeSystem.NativeMethodInfoPtr_CreateNewScrambleGameModeSettings_Private_Static_ScrambleGameModeSettings_PrefabLookupMap_ServerGameBalanceSettings_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663518);
    ScrambleGameModeSystem.NativeMethodInfoPtr_GetOrCreateRemapping_Private_Static_RemappingData_byref_ScrambleGameModeSettings_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663519);
    ScrambleGameModeSystem.NativeMethodInfoPtr_BuildTechMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663520);
    ScrambleGameModeSystem.NativeMethodInfoPtr_BuildSpawnMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663521);
    ScrambleGameModeSystem.NativeMethodInfoPtr_BuildAbilityMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_NativeList_1_PrefabGUID_PrefabLookupMap_EntityManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663522);
    ScrambleGameModeSystem.NativeMethodInfoPtr_BuildShapeShiftMappings_Private_Static_Void_byref_ScrambleGameModeSettings_NativeList_1_PrefabGUID_PrefabLookupMap_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663523);
    ScrambleGameModeSystem.NativeMethodInfoPtr_RandomizeVBloodSpawnMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_NativeList_1_PrefabGUID_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663524);
    ScrambleGameModeSystem.NativeMethodInfoPtr_RandomizeVBloodTechMappings_Private_Static_Void_byref_ScrambleGameModeSettings_byref_Random_ServerGameBalanceSettings_NativeList_1_PrefabGUID_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663525);
    ScrambleGameModeSystem.NativeMethodInfoPtr_CopyTechs_Private_Static_Void_PrefabLookupMap_Entity_EntityCommandBuffer_EntityManager_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663526);
    ScrambleGameModeSystem.NativeMethodInfoPtr_CopySpawnRelatedComponents_Private_Static_Void_PrefabLookupMap_Entity_EntityCommandBuffer_EntityManager_RemappingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663527);
    ScrambleGameModeSystem.NativeMethodInfoPtr_SetAbilities_Private_Static_Void_EntityManager_PrefabLookupMap_Entity_List_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663528);
    ScrambleGameModeSystem.NativeMethodInfoPtr_GetUnitAbilities_Private_Static_Void_PrefabLookupMap_Entity_EntityManager_byref_OriginalData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663529);
    ScrambleGameModeSystem.NativeMethodInfoPtr_SetShapeShifts_Private_Static_Void_EntityManager_PrefabLookupMap_Entity_List_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663530);
    ScrambleGameModeSystem.NativeMethodInfoPtr_EnsureEverythingConverted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663531);
    ScrambleGameModeSystem.NativeMethodInfoPtr_ApplyRemappings_Public_Static_Void_EntityManager_EntityCommandBuffer_PrefabLookupMap_ServerGameBalanceSettings_ScrambleGameModeSettings_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663532);
    ScrambleGameModeSystem.NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663533);
    ScrambleGameModeSystem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663534);
    ScrambleGameModeSystem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663535);
    ScrambleGameModeSystem.NativeMethodInfoPtr_InitializeScrambleSettings_Public_Void_ServerGameBalanceSettings_ScrambleGameModeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663536);
    ScrambleGameModeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663537);
    ScrambleGameModeSystem.NativeMethodInfoPtr_Method_Internal_Static_Boolean_PrefabGUID_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663539);
    ScrambleGameModeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, 100663540);
  }

  public ScrambleGameModeSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe PrefabCollectionSystem _PrefabCollectionSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
      return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe PrefabGUID BLOOD_ALTAR_PREFABGUID
  {
    get
    {
      PrefabGUID bloodAltarPrefabguid;
      IL2CPP.il2cpp_field_static_get_value(ScrambleGameModeSystem.NativeFieldInfoPtr_BLOOD_ALTAR_PREFABGUID, (void*) &bloodAltarPrefabguid);
      return bloodAltarPrefabguid;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScrambleGameModeSystem.NativeFieldInfoPtr_BLOOD_ALTAR_PREFABGUID, (void*) &value);
    }
  }

  public unsafe bool _HasAppliedScrambleSettings
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__HasAppliedScrambleSettings));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__HasAppliedScrambleSettings)) = value;
    }
  }

  public ScrambleGameModeSettings ScrambleSettings
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr_ScrambleSettings);
      return new ScrambleGameModeSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr_ScrambleSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScrambleGameModeSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_1
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_1));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_1)) = value;
    }
  }

  public unsafe EntityQuery _SingletonEntityQuery_ServerGameBalanceSettings_2
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_2));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_2)) = value;
    }
  }

  public unsafe EntityQuery _SingletonEntityQuery_ServerGameBalanceSettings_3
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_3));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_3)) = value;
    }
  }

  public sealed class OriginalData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityList;
    private static readonly System.IntPtr NativeFieldInfoPtr_Shapeshifts;

    static OriginalData()
    {
      Il2CppClassPointerStore<ScrambleGameModeSystem.OriginalData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, nameof (OriginalData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrambleGameModeSystem.OriginalData>.NativeClassPtr);
      ScrambleGameModeSystem.OriginalData.NativeFieldInfoPtr_AbilityList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem.OriginalData>.NativeClassPtr, nameof (AbilityList));
      ScrambleGameModeSystem.OriginalData.NativeFieldInfoPtr_Shapeshifts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem.OriginalData>.NativeClassPtr, nameof (Shapeshifts));
    }

    public OriginalData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public OriginalData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScrambleGameModeSystem.OriginalData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrambleGameModeSystem.OriginalData>.NativeClassPtr, data));
    }

    public unsafe List<PrefabGUID> AbilityList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.OriginalData.NativeFieldInfoPtr_AbilityList));
        return pointer == System.IntPtr.Zero ? (List<PrefabGUID>) null : new List<PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.OriginalData.NativeFieldInfoPtr_AbilityList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<PrefabGUID> Shapeshifts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.OriginalData.NativeFieldInfoPtr_Shapeshifts));
        return pointer == System.IntPtr.Zero ? (List<PrefabGUID>) null : new List<PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrambleGameModeSystem.OriginalData.NativeFieldInfoPtr_Shapeshifts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ScrambleGameModeSystem/<>c__DisplayClass10_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass10_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_includeOnlyUltimates;
    [FieldOffset(0)]
    public PrefabLookupMap prefabLookupMap;
    [FieldOffset(48)]
    public EntityManager entityManager;
    [FieldOffset(56)]
    public bool includeOnlyUltimates;

    static __c__DisplayClass10_0()
    {
      Il2CppClassPointerStore<ScrambleGameModeSystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrambleGameModeSystem>.NativeClassPtr, "<>c__DisplayClass10_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrambleGameModeSystem.__c__DisplayClass10_0>.NativeClassPtr);
      ScrambleGameModeSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (prefabLookupMap));
      ScrambleGameModeSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (entityManager));
      ScrambleGameModeSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_includeOnlyUltimates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrambleGameModeSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (includeOnlyUltimates));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrambleGameModeSystem.__c__DisplayClass10_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
