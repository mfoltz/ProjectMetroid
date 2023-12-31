// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabCollectionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Core;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class PrefabCollectionSystem : PrefabCollectionSystem_Base
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterPrefabQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterPrefabInheritanceQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterPrefabWithoutSilentQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataWithoutSilentQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NameToPrefabGuidDictionary;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabGuidToNameDictionary;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnableNameToPrefabGuidDictionary;
    private static readonly System.IntPtr NativeFieldInfoPtr__AssetLabelLists;
    private static readonly System.IntPtr NativeFieldInfoPtr__EmptyPrefabList;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabDataLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabGuidToEntityMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabInheritanceBaseToVariantsLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImportedAssetCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsEditorWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextEventPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropItemPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedSequencePrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlinkSequencePrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathContainerPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDeathContainerAnyonePrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDeathContainerClanMembersPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDeathContainerOnlySelfPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserMapZoneDataPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBuffPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_FallTravelBuffPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BossWoundedBuffPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCombatBuffPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanTeamPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInvitePrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerTeamPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTeamPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupSlotPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideCharacterBuffGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoomPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRailingsCollectionGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodFountainGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodHuntsDataPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodMenuRequirementPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodMenuShardBearersRequirementPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseVBloodMenuSubtaskGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_TopDownCameraPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_OrbitCameraPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCameraPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_SCTCollectionGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneralGameplayCollectionGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDEntryCollectionGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSystemSettingsGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterCustomizationSettingsGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_VampirePvPRespawnBuffPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertOnDemandContext;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddToLookups_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddToLookups_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GroupEntityNameCollectionBuffers_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GroupEntityNameCollectionBuffers_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterPrefabsforFlags_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanUpDestroyedPrefabs_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterPrefabs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterPrefabs_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterPrefabsWithoutBurst_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterPrefabsWithoutBurst_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterPrefabInheritances_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterPrefabInheritances_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NameToPrefabGuidDictionary_Public_Virtual_get_Dictionary_2_String_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGuidToNameDictionary_Public_Virtual_get_Dictionary_2_PrefabGUID_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpawnableNameToPrefabGuidDictionary_Public_Virtual_get_Dictionary_2_String_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabDataLookup_Public_Virtual_get_NativeHashMap_2_PrefabGUID_ConvertedAssetData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabsForLabel_Public_Virtual_NativeList_1_PrefabGUID_ConvertedLabelFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabLookupMap_Public_Virtual_get_PrefabLookupMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabInheritanceBaseToVariantsLookupMap_Public_Virtual_get_NativeMultiHashMap_2_PrefabGUID_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GameDataInitialized_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ScrollingCombatTextEventPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DropItemPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NetworkedSequencePrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BlinkSequencePrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeathContainerPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerDeathContainerAnyonePrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerDeathContainerClanMembersPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerDeathContainerOnlySelfPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserMapZoneDataPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TeleportBuffPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FallTravelBuffPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BossWoundedBuffPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerCombatBuffPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClanTeamPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClanInvitePrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerTeamPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CastleTeamPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AbilityGroupSlotPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HideCharacterBuff_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CastleRoomPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CastleTerritoryPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CastleRailingsCollection_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BloodFountainPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BloodHuntsDataPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VBloodMenuRequirementPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VBloodMenuShardBearersRequirementPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseVBloodMenuSubtaskPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TopDownCameraPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OrbitCameraPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FreeCameraPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SCTCollection_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GeneralGameplayCollection_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterHUDEntryCollectionPrefab_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClanSystemSettings_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterCustomizationSettings_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VampirePvPRespawnBuff_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterGameData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrUpdatePrefabDatas_Public_Void_NativeArray_1_PrefabCollectionBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanUpDestroyedPrefabs_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPrefabs_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPrefabInheritances_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInitialized_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunConvertOnDemand_Public_Boolean_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAddToLookups_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGroupEntityNameCollectionBuffers_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabsWithoutBurst_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabInheritances_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;

    public override unsafe Dictionary<string, PrefabGUID> NameToPrefabGuidDictionary
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_get_NameToPrefabGuidDictionary_Public_Virtual_get_Dictionary_2_String_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<string, PrefabGUID>) null : new Dictionary<string, PrefabGUID>(pointer);
      }
    }

    public override unsafe Dictionary<PrefabGUID, string> PrefabGuidToNameDictionary
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22439, RefRangeEnd = 22440, XrefRangeStart = 22439, XrefRangeEnd = 22440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_get_PrefabGuidToNameDictionary_Public_Virtual_get_Dictionary_2_PrefabGUID_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, string>) null : new Dictionary<PrefabGUID, string>(pointer);
      }
    }

    public override unsafe Dictionary<string, PrefabGUID> SpawnableNameToPrefabGuidDictionary
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_get_SpawnableNameToPrefabGuidDictionary_Public_Virtual_get_Dictionary_2_String_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<string, PrefabGUID>) null : new Dictionary<string, PrefabGUID>(pointer);
      }
    }

    public override unsafe NativeHashMap<PrefabGUID, ConvertedAssetData> PrefabDataLookup
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_get_PrefabDataLookup_Public_Virtual_get_NativeHashMap_2_PrefabGUID_ConvertedAssetData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, ConvertedAssetData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756106, XrefRangeEnd = 756109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe NativeList<PrefabGUID> GetPrefabsForLabel(ConvertedLabelFlags labelFlags)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &labelFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_GetPrefabsForLabel_Public_Virtual_NativeList_1_PrefabGUID_ConvertedLabelFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<PrefabGUID>*) IL2CPP.il2cpp_object_unbox(num);
    }

    public override unsafe PrefabLookupMap PrefabLookupMap
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_get_PrefabLookupMap_Public_Virtual_get_PrefabLookupMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabLookupMap*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public override unsafe NativeMultiHashMap<PrefabGUID, PrefabGUID> PrefabInheritanceBaseToVariantsLookupMap
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_get_PrefabInheritanceBaseToVariantsLookupMap_Public_Virtual_get_NativeMultiHashMap_2_PrefabGUID_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeMultiHashMap<PrefabGUID, PrefabGUID>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool GameDataInitialized
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756112, RefRangeEnd = 756113, XrefRangeStart = 756109, XrefRangeEnd = 756112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_GameDataInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity ScrollingCombatTextEventPrefab
    {
      [CallerCount(26), CachedScanResults(RefRangeStart = 756114, RefRangeEnd = 756140, XrefRangeStart = 756113, XrefRangeEnd = 756114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_ScrollingCombatTextEventPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity DropItemPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756141, RefRangeEnd = 756142, XrefRangeStart = 756140, XrefRangeEnd = 756141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_DropItemPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity NetworkedSequencePrefab
    {
      [CallerCount(19), CachedScanResults(RefRangeStart = 756143, RefRangeEnd = 756162, XrefRangeStart = 756142, XrefRangeEnd = 756143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_NetworkedSequencePrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity BlinkSequencePrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756163, RefRangeEnd = 756164, XrefRangeStart = 756162, XrefRangeEnd = 756163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_BlinkSequencePrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity DeathContainerPrefab
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 756165, RefRangeEnd = 756168, XrefRangeStart = 756164, XrefRangeEnd = 756165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_DeathContainerPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity PlayerDeathContainerAnyonePrefab
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 756169, RefRangeEnd = 756171, XrefRangeStart = 756168, XrefRangeEnd = 756169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerDeathContainerAnyonePrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity PlayerDeathContainerClanMembersPrefab
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 756172, RefRangeEnd = 756174, XrefRangeStart = 756171, XrefRangeEnd = 756172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerDeathContainerClanMembersPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity PlayerDeathContainerOnlySelfPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756175, RefRangeEnd = 756176, XrefRangeStart = 756174, XrefRangeEnd = 756175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerDeathContainerOnlySelfPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity UserMapZoneDataPrefab
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 756177, RefRangeEnd = 756180, XrefRangeStart = 756176, XrefRangeEnd = 756177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_UserMapZoneDataPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity TeleportBuffPrefab
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756180, XrefRangeEnd = 756181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_TeleportBuffPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity FallTravelBuffPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756182, RefRangeEnd = 756183, XrefRangeStart = 756181, XrefRangeEnd = 756182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_FallTravelBuffPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity BossWoundedBuffPrefab
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756183, XrefRangeEnd = 756184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_BossWoundedBuffPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity PlayerCombatBuffPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756185, RefRangeEnd = 756186, XrefRangeStart = 756184, XrefRangeEnd = 756185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerCombatBuffPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity ClanTeamPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756187, RefRangeEnd = 756188, XrefRangeStart = 756186, XrefRangeEnd = 756187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_ClanTeamPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity ClanInvitePrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756189, RefRangeEnd = 756190, XrefRangeStart = 756188, XrefRangeEnd = 756189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_ClanInvitePrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity PlayerTeamPrefab
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 756191, RefRangeEnd = 756193, XrefRangeStart = 756190, XrefRangeEnd = 756191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerTeamPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity CastleTeamPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756194, RefRangeEnd = 756195, XrefRangeStart = 756193, XrefRangeEnd = 756194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_CastleTeamPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity AbilityGroupSlotPrefab
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 756196, RefRangeEnd = 756198, XrefRangeStart = 756195, XrefRangeEnd = 756196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_AbilityGroupSlotPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity HideCharacterBuff
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756199, RefRangeEnd = 756200, XrefRangeStart = 756198, XrefRangeEnd = 756199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_HideCharacterBuff_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity CastleRoomPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756201, RefRangeEnd = 756202, XrefRangeStart = 756200, XrefRangeEnd = 756201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_CastleRoomPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity CastleTerritoryPrefab
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756202, XrefRangeEnd = 756203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_CastleTerritoryPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity CastleRailingsCollection
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756203, XrefRangeEnd = 756204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_CastleRailingsCollection_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity BloodFountainPrefab
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756204, XrefRangeEnd = 756205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_BloodFountainPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity BloodHuntsDataPrefab
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 756206, RefRangeEnd = 756211, XrefRangeStart = 756205, XrefRangeEnd = 756206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_BloodHuntsDataPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity VBloodMenuRequirementPrefab
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756211, XrefRangeEnd = 756212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_VBloodMenuRequirementPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity VBloodMenuShardBearersRequirementPrefab
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756212, XrefRangeEnd = 756213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_VBloodMenuShardBearersRequirementPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity UseVBloodMenuSubtaskPrefab
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756213, XrefRangeEnd = 756214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_UseVBloodMenuSubtaskPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity TopDownCameraPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756215, RefRangeEnd = 756216, XrefRangeStart = 756214, XrefRangeEnd = 756215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_TopDownCameraPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity OrbitCameraPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756217, RefRangeEnd = 756218, XrefRangeStart = 756216, XrefRangeEnd = 756217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_OrbitCameraPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity FreeCameraPrefab
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756219, RefRangeEnd = 756220, XrefRangeStart = 756218, XrefRangeEnd = 756219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_FreeCameraPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity SCTCollection
    {
      [CallerCount(16), CachedScanResults(RefRangeStart = 756221, RefRangeEnd = 756237, XrefRangeStart = 756220, XrefRangeEnd = 756221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_SCTCollection_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity GeneralGameplayCollection
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 756238, RefRangeEnd = 756243, XrefRangeStart = 756237, XrefRangeEnd = 756238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_GeneralGameplayCollection_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity CharacterHUDEntryCollectionPrefab
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 756244, RefRangeEnd = 756246, XrefRangeStart = 756243, XrefRangeEnd = 756244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_CharacterHUDEntryCollectionPrefab_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity ClanSystemSettings
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 756247, RefRangeEnd = 756251, XrefRangeStart = 756246, XrefRangeEnd = 756247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_ClanSystemSettings_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity CharacterCustomizationSettings
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 756252, RefRangeEnd = 756256, XrefRangeStart = 756251, XrefRangeEnd = 756252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_CharacterCustomizationSettings_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity VampirePvPRespawnBuff
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 756257, RefRangeEnd = 756258, XrefRangeStart = 756256, XrefRangeEnd = 756257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_get_VampirePvPRespawnBuff_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756258, XrefRangeEnd = 756369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756369, XrefRangeEnd = 756412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756412, XrefRangeEnd = 756452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756518, RefRangeEnd = 756519, XrefRangeStart = 756452, XrefRangeEnd = 756518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterGameData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_RegisterGameData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756575, RefRangeEnd = 756576, XrefRangeStart = 756519, XrefRangeEnd = 756575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrUpdatePrefabDatas(NativeArray<PrefabCollectionBuffer> assetDatas)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &assetDatas;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_AddOrUpdatePrefabDatas_Public_Void_NativeArray_1_PrefabCollectionBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756593, RefRangeEnd = 756594, XrefRangeStart = 756576, XrefRangeEnd = 756593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CleanUpDestroyedPrefabs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_CleanUpDestroyedPrefabs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756622, RefRangeEnd = 756623, XrefRangeStart = 756594, XrefRangeEnd = 756622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterPrefabs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_RegisterPrefabs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756637, RefRangeEnd = 756638, XrefRangeStart = 756623, XrefRangeEnd = 756637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterPrefabInheritances()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_RegisterPrefabInheritances_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756638, XrefRangeEnd = 756670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInitialized()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_IsInitialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RunConvertOnDemand(
      string progressBarDisplayName,
      bool dumpConvertInfoInstantly)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(progressBarDisplayName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dumpConvertInfoInstantly;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_RunConvertOnDemand_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabCollectionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756670, XrefRangeEnd = 756826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrefabCollectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756848, RefRangeEnd = 756849, XrefRangeStart = 756826, XrefRangeEnd = 756848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAddToLookups_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddToLookups_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756871, RefRangeEnd = 756872, XrefRangeStart = 756849, XrefRangeEnd = 756871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGroupEntityNameCollectionBuffers_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForGroupEntityNameCollectionBuffers_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756872, XrefRangeEnd = 756891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterPrefabs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756891, XrefRangeEnd = 756910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterPrefabsWithoutBurst_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabsWithoutBurst_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756910, XrefRangeEnd = 756926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterPrefabInheritances_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabInheritances_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756930, RefRangeEnd = 756931, XrefRangeStart = 756926, XrefRangeEnd = 756930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756935, RefRangeEnd = 756936, XrefRangeStart = 756931, XrefRangeEnd = 756935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756940, RefRangeEnd = 756941, XrefRangeStart = 756936, XrefRangeEnd = 756940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756945, RefRangeEnd = 756946, XrefRangeStart = 756941, XrefRangeEnd = 756945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 756950, RefRangeEnd = 756951, XrefRangeStart = 756946, XrefRangeEnd = 756950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrefabCollectionSystem()
    {
      Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabCollectionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr);
      PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_RegisterPrefabQuery));
      PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabInheritanceQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_RegisterPrefabInheritanceQuery));
      PrefabCollectionSystem.NativeFieldInfoPtr__GameDataQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_GameDataQuery));
      PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabWithoutSilentQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_RegisterPrefabWithoutSilentQuery));
      PrefabCollectionSystem.NativeFieldInfoPtr__GameDataWithoutSilentQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_GameDataWithoutSilentQuery));
      PrefabCollectionSystem.NativeFieldInfoPtr__NameToPrefabGuidDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_NameToPrefabGuidDictionary));
      PrefabCollectionSystem.NativeFieldInfoPtr__PrefabGuidToNameDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_PrefabGuidToNameDictionary));
      PrefabCollectionSystem.NativeFieldInfoPtr__SpawnableNameToPrefabGuidDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_SpawnableNameToPrefabGuidDictionary));
      PrefabCollectionSystem.NativeFieldInfoPtr__AssetLabelLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_AssetLabelLists));
      PrefabCollectionSystem.NativeFieldInfoPtr__EmptyPrefabList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_EmptyPrefabList));
      PrefabCollectionSystem.NativeFieldInfoPtr__PrefabDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_PrefabDataLookup));
      PrefabCollectionSystem.NativeFieldInfoPtr__PrefabGuidToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_PrefabGuidToEntityMap));
      PrefabCollectionSystem.NativeFieldInfoPtr__GameDataInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_GameDataInitialized));
      PrefabCollectionSystem.NativeFieldInfoPtr__PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_PrefabLookupMap));
      PrefabCollectionSystem.NativeFieldInfoPtr__PrefabInheritanceBaseToVariantsLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_PrefabInheritanceBaseToVariantsLookupMap));
      PrefabCollectionSystem.NativeFieldInfoPtr_ImportedAssetCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (ImportedAssetCounter));
      PrefabCollectionSystem.NativeFieldInfoPtr__IsEditorWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (_IsEditorWorld));
      PrefabCollectionSystem.NativeFieldInfoPtr_ScrollingCombatTextEventPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (ScrollingCombatTextEventPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_DropItemPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (DropItemPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_NetworkedSequencePrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (NetworkedSequencePrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_BlinkSequencePrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (BlinkSequencePrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_DeathContainerPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (DeathContainerPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerAnyonePrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (PlayerDeathContainerAnyonePrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerClanMembersPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (PlayerDeathContainerClanMembersPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerOnlySelfPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (PlayerDeathContainerOnlySelfPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_UserMapZoneDataPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (UserMapZoneDataPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_TeleportBuffPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (TeleportBuffPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_FallTravelBuffPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (FallTravelBuffPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_BossWoundedBuffPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (BossWoundedBuffPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_PlayerCombatBuffPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (PlayerCombatBuffPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_ClanTeamPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (ClanTeamPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_ClanInvitePrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (ClanInvitePrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_PlayerTeamPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (PlayerTeamPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_CastleTeamPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (CastleTeamPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_AbilityGroupSlotPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (AbilityGroupSlotPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_HideCharacterBuffGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (HideCharacterBuffGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_CastleRoomPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (CastleRoomPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_CastleTerritoryPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (CastleTerritoryPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_CastleRailingsCollectionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (CastleRailingsCollectionGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_BloodFountainGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (BloodFountainGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_BloodHuntsDataPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (BloodHuntsDataPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_VBloodMenuRequirementPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (VBloodMenuRequirementPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_VBloodMenuShardBearersRequirementPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (VBloodMenuShardBearersRequirementPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_UseVBloodMenuSubtaskGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (UseVBloodMenuSubtaskGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_TopDownCameraPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (TopDownCameraPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_OrbitCameraPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (OrbitCameraPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_FreeCameraPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (FreeCameraPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_SCTCollectionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (SCTCollectionGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_GeneralGameplayCollectionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (GeneralGameplayCollectionGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_CharacterHUDEntryCollectionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (CharacterHUDEntryCollectionGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_ClanSystemSettingsGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (ClanSystemSettingsGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_CharacterCustomizationSettingsGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (CharacterCustomizationSettingsGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_VampirePvPRespawnBuffPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (VampirePvPRespawnBuffPrefabGUID));
      PrefabCollectionSystem.NativeFieldInfoPtr_ConvertOnDemandContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (ConvertOnDemandContext));
      PrefabCollectionSystem.NativeFieldInfoPtr___AddToLookups_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>AddToLookups_entityQuery");
      PrefabCollectionSystem.NativeFieldInfoPtr___AddToLookups_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>AddToLookups_profilerMarker");
      PrefabCollectionSystem.NativeFieldInfoPtr___GroupEntityNameCollectionBuffers_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>GroupEntityNameCollectionBuffers_entityQuery");
      PrefabCollectionSystem.NativeFieldInfoPtr___GroupEntityNameCollectionBuffers_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>GroupEntityNameCollectionBuffers_profilerMarker");
      PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsforFlags_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>RegisterPrefabsforFlags_profilerMarker");
      PrefabCollectionSystem.NativeFieldInfoPtr___CleanUpDestroyedPrefabs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>CleanUpDestroyedPrefabs_profilerMarker");
      PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>RegisterPrefabs_entityQuery");
      PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>RegisterPrefabs_profilerMarker");
      PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsWithoutBurst_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>RegisterPrefabsWithoutBurst_entityQuery");
      PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsWithoutBurst_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>RegisterPrefabsWithoutBurst_profilerMarker");
      PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabInheritances_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>RegisterPrefabInheritances_entityQuery");
      PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabInheritances_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>RegisterPrefabInheritances_profilerMarker");
      PrefabCollectionSystem.NativeMethodInfoPtr_get_NameToPrefabGuidDictionary_Public_Virtual_get_Dictionary_2_String_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666637);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PrefabGuidToNameDictionary_Public_Virtual_get_Dictionary_2_PrefabGUID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666638);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_SpawnableNameToPrefabGuidDictionary_Public_Virtual_get_Dictionary_2_String_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666639);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PrefabDataLookup_Public_Virtual_get_NativeHashMap_2_PrefabGUID_ConvertedAssetData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666640);
      PrefabCollectionSystem.NativeMethodInfoPtr_GetPrefabsForLabel_Public_Virtual_NativeList_1_PrefabGUID_ConvertedLabelFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666641);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PrefabLookupMap_Public_Virtual_get_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666642);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PrefabInheritanceBaseToVariantsLookupMap_Public_Virtual_get_NativeMultiHashMap_2_PrefabGUID_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666643);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_GameDataInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666644);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_ScrollingCombatTextEventPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666645);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_DropItemPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666646);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_NetworkedSequencePrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666647);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_BlinkSequencePrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666648);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_DeathContainerPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666649);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerDeathContainerAnyonePrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666650);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerDeathContainerClanMembersPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666651);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerDeathContainerOnlySelfPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666652);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_UserMapZoneDataPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666653);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_TeleportBuffPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666654);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_FallTravelBuffPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666655);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_BossWoundedBuffPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666656);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerCombatBuffPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666657);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_ClanTeamPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666658);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_ClanInvitePrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666659);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_PlayerTeamPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666660);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_CastleTeamPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666661);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_AbilityGroupSlotPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666662);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_HideCharacterBuff_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666663);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_CastleRoomPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666664);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_CastleTerritoryPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666665);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_CastleRailingsCollection_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666666);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_BloodFountainPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666667);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_BloodHuntsDataPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666668);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_VBloodMenuRequirementPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666669);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_VBloodMenuShardBearersRequirementPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666670);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_UseVBloodMenuSubtaskPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666671);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_TopDownCameraPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666672);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_OrbitCameraPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666673);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_FreeCameraPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666674);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_SCTCollection_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666675);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_GeneralGameplayCollection_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666676);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_CharacterHUDEntryCollectionPrefab_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666677);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_ClanSystemSettings_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666678);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_CharacterCustomizationSettings_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666679);
      PrefabCollectionSystem.NativeMethodInfoPtr_get_VampirePvPRespawnBuff_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666680);
      PrefabCollectionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666681);
      PrefabCollectionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666682);
      PrefabCollectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666683);
      PrefabCollectionSystem.NativeMethodInfoPtr_RegisterGameData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666684);
      PrefabCollectionSystem.NativeMethodInfoPtr_AddOrUpdatePrefabDatas_Public_Void_NativeArray_1_PrefabCollectionBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666685);
      PrefabCollectionSystem.NativeMethodInfoPtr_CleanUpDestroyedPrefabs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666686);
      PrefabCollectionSystem.NativeMethodInfoPtr_RegisterPrefabs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666687);
      PrefabCollectionSystem.NativeMethodInfoPtr_RegisterPrefabInheritances_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666688);
      PrefabCollectionSystem.NativeMethodInfoPtr_IsInitialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666689);
      PrefabCollectionSystem.NativeMethodInfoPtr_RunConvertOnDemand_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666690);
      PrefabCollectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666691);
      PrefabCollectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666692);
      PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddToLookups_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666693);
      PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForGroupEntityNameCollectionBuffers_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666694);
      PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666695);
      PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabsWithoutBurst_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666696);
      PrefabCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterPrefabInheritances_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666697);
      PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666698);
      PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666699);
      PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666700);
      PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666701);
      PrefabCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, 100666702);
    }

    public PrefabCollectionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _RegisterPrefabQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabQuery)) = value;
      }
    }

    public unsafe EntityQuery _RegisterPrefabInheritanceQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabInheritanceQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabInheritanceQuery)) = value;
      }
    }

    public unsafe EntityQuery _GameDataQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__GameDataQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__GameDataQuery)) = value;
      }
    }

    public unsafe EntityQuery _RegisterPrefabWithoutSilentQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabWithoutSilentQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__RegisterPrefabWithoutSilentQuery)) = value;
      }
    }

    public unsafe EntityQuery _GameDataWithoutSilentQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__GameDataWithoutSilentQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__GameDataWithoutSilentQuery)) = value;
      }
    }

    public unsafe Dictionary<string, PrefabGUID> _NameToPrefabGuidDictionary
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__NameToPrefabGuidDictionary));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, PrefabGUID>) null : new Dictionary<string, PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__NameToPrefabGuidDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<PrefabGUID, string> _PrefabGuidToNameDictionary
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabGuidToNameDictionary));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, string>) null : new Dictionary<PrefabGUID, string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabGuidToNameDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<string, PrefabGUID> _SpawnableNameToPrefabGuidDictionary
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__SpawnableNameToPrefabGuidDictionary));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, PrefabGUID>) null : new Dictionary<string, PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__SpawnableNameToPrefabGuidDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, NativeList<PrefabGUID>> _AssetLabelLists
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__AssetLabelLists));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, NativeList<PrefabGUID>>) null : new Dictionary<int, NativeList<PrefabGUID>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__AssetLabelLists), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<PrefabGUID> _EmptyPrefabList
    {
      get
      {
        return *(NativeList<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__EmptyPrefabList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__EmptyPrefabList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, ConvertedAssetData> _PrefabDataLookup
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, ConvertedAssetData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabDataLookup));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabDataLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ConvertedAssetData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, Entity> _PrefabGuidToEntityMap
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabGuidToEntityMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabGuidToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeReference<bool> _GameDataInitialized
    {
      get
      {
        return *(NativeReference<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__GameDataInitialized));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__GameDataInitialized), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabLookupMap _PrefabLookupMap
    {
      get
      {
        return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabLookupMap));
      }
      [param: In] set
      {
        *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabLookupMap)) = value;
      }
    }

    public unsafe NativeMultiHashMap<PrefabGUID, PrefabGUID> _PrefabInheritanceBaseToVariantsLookupMap
    {
      get
      {
        return *(NativeMultiHashMap<PrefabGUID, PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabInheritanceBaseToVariantsLookupMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__PrefabInheritanceBaseToVariantsLookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<PrefabGUID, PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int ImportedAssetCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ImportedAssetCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ImportedAssetCounter)) = value;
      }
    }

    public unsafe bool _IsEditorWorld
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__IsEditorWorld));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr__IsEditorWorld)) = value;
      }
    }

    public unsafe PrefabGUID ScrollingCombatTextEventPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ScrollingCombatTextEventPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ScrollingCombatTextEventPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID DropItemPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_DropItemPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_DropItemPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID NetworkedSequencePrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_NetworkedSequencePrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_NetworkedSequencePrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID BlinkSequencePrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_BlinkSequencePrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_BlinkSequencePrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID DeathContainerPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_DeathContainerPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_DeathContainerPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID PlayerDeathContainerAnyonePrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerAnyonePrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerAnyonePrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID PlayerDeathContainerClanMembersPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerClanMembersPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerClanMembersPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID PlayerDeathContainerOnlySelfPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerOnlySelfPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerDeathContainerOnlySelfPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID UserMapZoneDataPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_UserMapZoneDataPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_UserMapZoneDataPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID TeleportBuffPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_TeleportBuffPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_TeleportBuffPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID FallTravelBuffPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_FallTravelBuffPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_FallTravelBuffPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID BossWoundedBuffPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_BossWoundedBuffPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_BossWoundedBuffPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID PlayerCombatBuffPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerCombatBuffPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerCombatBuffPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID ClanTeamPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ClanTeamPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ClanTeamPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID ClanInvitePrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ClanInvitePrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ClanInvitePrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID PlayerTeamPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerTeamPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_PlayerTeamPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID CastleTeamPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CastleTeamPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CastleTeamPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID AbilityGroupSlotPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_AbilityGroupSlotPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_AbilityGroupSlotPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID HideCharacterBuffGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_HideCharacterBuffGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_HideCharacterBuffGUID)) = value;
      }
    }

    public unsafe PrefabGUID CastleRoomPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CastleRoomPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CastleRoomPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID CastleTerritoryPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CastleTerritoryPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CastleTerritoryPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID CastleRailingsCollectionGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CastleRailingsCollectionGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CastleRailingsCollectionGUID)) = value;
      }
    }

    public unsafe PrefabGUID BloodFountainGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_BloodFountainGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_BloodFountainGUID)) = value;
      }
    }

    public unsafe PrefabGUID BloodHuntsDataPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_BloodHuntsDataPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_BloodHuntsDataPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID VBloodMenuRequirementPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_VBloodMenuRequirementPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_VBloodMenuRequirementPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID VBloodMenuShardBearersRequirementPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_VBloodMenuShardBearersRequirementPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_VBloodMenuShardBearersRequirementPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID UseVBloodMenuSubtaskGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_UseVBloodMenuSubtaskGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_UseVBloodMenuSubtaskGUID)) = value;
      }
    }

    public unsafe PrefabGUID TopDownCameraPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_TopDownCameraPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_TopDownCameraPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID OrbitCameraPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_OrbitCameraPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_OrbitCameraPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID FreeCameraPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_FreeCameraPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_FreeCameraPrefabGUID)) = value;
      }
    }

    public unsafe PrefabGUID SCTCollectionGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_SCTCollectionGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_SCTCollectionGUID)) = value;
      }
    }

    public unsafe PrefabGUID GeneralGameplayCollectionGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_GeneralGameplayCollectionGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_GeneralGameplayCollectionGUID)) = value;
      }
    }

    public unsafe PrefabGUID CharacterHUDEntryCollectionGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CharacterHUDEntryCollectionGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CharacterHUDEntryCollectionGUID)) = value;
      }
    }

    public unsafe PrefabGUID ClanSystemSettingsGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ClanSystemSettingsGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ClanSystemSettingsGUID)) = value;
      }
    }

    public unsafe PrefabGUID CharacterCustomizationSettingsGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CharacterCustomizationSettingsGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_CharacterCustomizationSettingsGUID)) = value;
      }
    }

    public unsafe PrefabGUID VampirePvPRespawnBuffPrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_VampirePvPRespawnBuffPrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_VampirePvPRespawnBuffPrefabGUID)) = value;
      }
    }

    public unsafe ConvertOnDemandContext ConvertOnDemandContext
    {
      get
      {
        return *(ConvertOnDemandContext*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ConvertOnDemandContext));
      }
      [param: In] set
      {
        *(ConvertOnDemandContext*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr_ConvertOnDemandContext)) = value;
      }
    }

    public unsafe EntityQuery __AddToLookups_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___AddToLookups_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___AddToLookups_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AddToLookups_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___AddToLookups_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___AddToLookups_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GroupEntityNameCollectionBuffers_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___GroupEntityNameCollectionBuffers_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___GroupEntityNameCollectionBuffers_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GroupEntityNameCollectionBuffers_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___GroupEntityNameCollectionBuffers_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___GroupEntityNameCollectionBuffers_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterPrefabsforFlags_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsforFlags_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsforFlags_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __CleanUpDestroyedPrefabs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___CleanUpDestroyedPrefabs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___CleanUpDestroyedPrefabs_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterPrefabs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterPrefabs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabs_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterPrefabsWithoutBurst_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsWithoutBurst_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsWithoutBurst_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterPrefabsWithoutBurst_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsWithoutBurst_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabsWithoutBurst_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterPrefabInheritances_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabInheritances_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabInheritances_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterPrefabInheritances_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabInheritances_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.NativeFieldInfoPtr___RegisterPrefabInheritances_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Initialized
    {
      static Initialized()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.Initialized>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (Initialized));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.Initialized>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.Initialized>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PrefabAndFlags
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_LabelFlags;
      [FieldOffset(0)]
      public PrefabGUID PrefabGUID;
      [FieldOffset(4)]
      public ConvertedLabelFlags LabelFlags;

      static PrefabAndFlags()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.PrefabAndFlags>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, nameof (PrefabAndFlags));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.PrefabAndFlags>.NativeClassPtr);
        PrefabCollectionSystem.PrefabAndFlags.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.PrefabAndFlags>.NativeClassPtr, nameof (PrefabGUID));
        PrefabCollectionSystem.PrefabAndFlags.NativeFieldInfoPtr_LabelFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.PrefabAndFlags>.NativeClassPtr, nameof (LabelFlags));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.PrefabAndFlags>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/<>c__DisplayClass145_0")]
    public sealed class __c__DisplayClass145_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_namesToSet;
      private static readonly System.IntPtr NativeFieldInfoPtr_names;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterGameData_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_PrefabCollectionBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterGameData_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_EntityNameCollectionBuffer_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass145_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass145_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterGameData_b__0(
        Entity entity,
        [In] ref DynamicBuffer<PrefabCollectionBuffer> prefabs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabs;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass145_0.NativeMethodInfoPtr__RegisterGameData_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_PrefabCollectionBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterGameData_b__1(
        Entity entity,
        [In] ref DynamicBuffer<EntityNameCollectionBuffer> entities)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entities;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass145_0.NativeMethodInfoPtr__RegisterGameData_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_EntityNameCollectionBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass145_0()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass145_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr, "<>4__this");
        PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr_namesToSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr, nameof (namesToSet));
        PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr, nameof (names));
        PrefabCollectionSystem.__c__DisplayClass145_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr, 100666703);
        PrefabCollectionSystem.__c__DisplayClass145_0.NativeMethodInfoPtr__RegisterGameData_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_PrefabCollectionBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr, 100666704);
        PrefabCollectionSystem.__c__DisplayClass145_0.NativeMethodInfoPtr__RegisterGameData_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_EntityNameCollectionBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr, 100666705);
      }

      public __c__DisplayClass145_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass145_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass145_0>.NativeClassPtr, data));
      }

      public unsafe PrefabCollectionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeMultiHashMap<FixedString128, Entity> namesToSet
      {
        get
        {
          return *(NativeMultiHashMap<FixedString128, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr_namesToSet));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr_namesToSet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<FixedString128, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashSet<FixedString128> names
      {
        get
        {
          return *(NativeHashSet<FixedString128>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr_names));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass145_0.NativeFieldInfoPtr_names), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<FixedString128>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/<>c__DisplayClass147_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass147_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newAssetLabelsToProcess;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      [FieldOffset(0)]
      public NativeList<PrefabCollectionSystem.PrefabAndFlags> newAssetLabelsToProcess;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass147_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass147_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass147_0()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass147_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_0>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass147_0.NativeFieldInfoPtr_newAssetLabelsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_0>.NativeClassPtr, nameof (newAssetLabelsToProcess));
        PrefabCollectionSystem.__c__DisplayClass147_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_0>.NativeClassPtr, 100666706);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/<>c__DisplayClass147_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass147_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_flag;
      private static readonly System.IntPtr NativeFieldInfoPtr_flagList;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass147_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddOrUpdatePrefabDatas_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public int flag;
      [FieldOffset(8)]
      public NativeList<PrefabGUID> flagList;
      [FieldOffset(24)]
      public PrefabCollectionSystem.__c__DisplayClass147_0 field_Public___c__DisplayClass147_0_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass147_1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass147_1.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddOrUpdatePrefabDatas_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass147_1.NativeMethodInfoPtr__AddOrUpdatePrefabDatas_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass147_1()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass147_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_1>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass147_1.NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_1>.NativeClassPtr, nameof (flag));
        PrefabCollectionSystem.__c__DisplayClass147_1.NativeFieldInfoPtr_flagList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_1>.NativeClassPtr, nameof (flagList));
        PrefabCollectionSystem.__c__DisplayClass147_1.NativeFieldInfoPtr_field_Public___c__DisplayClass147_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_1>.NativeClassPtr, "CS$<>8__locals1");
        PrefabCollectionSystem.__c__DisplayClass147_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_1>.NativeClassPtr, 100666707);
        PrefabCollectionSystem.__c__DisplayClass147_1.NativeMethodInfoPtr__AddOrUpdatePrefabDatas_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_1>.NativeClassPtr, 100666708);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass147_1>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/<>c__DisplayClass148_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass148_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidHashToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidFromEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CleanUpDestroyedPrefabs_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, Entity> prefabGuidHashToEntityMap;
      [FieldOffset(16)]
      public ComponentDataFromEntity<PrefabGUID> prefabGuidFromEntity;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass148_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass148_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CleanUpDestroyedPrefabs_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass148_0.NativeMethodInfoPtr__CleanUpDestroyedPrefabs_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass148_0()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass148_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass148_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass148_0>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass148_0.NativeFieldInfoPtr_prefabGuidHashToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass148_0>.NativeClassPtr, nameof (prefabGuidHashToEntityMap));
        PrefabCollectionSystem.__c__DisplayClass148_0.NativeFieldInfoPtr_prefabGuidFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass148_0>.NativeClassPtr, nameof (prefabGuidFromEntity));
        PrefabCollectionSystem.__c__DisplayClass148_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass148_0>.NativeClassPtr, 100666709);
        PrefabCollectionSystem.__c__DisplayClass148_0.NativeMethodInfoPtr__CleanUpDestroyedPrefabs_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass148_0>.NativeClassPtr, 100666710);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass148_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/<>c__DisplayClass149_0")]
    public sealed class __c__DisplayClass149_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabDataLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidHashToEntityMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterPrefabs_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterPrefabs_b__1_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass149_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass149_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterPrefabs_b__0(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass149_0.NativeMethodInfoPtr__RegisterPrefabs_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterPrefabs_b__1(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass149_0.NativeMethodInfoPtr__RegisterPrefabs_b__1_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass149_0()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass149_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr_prefabDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr, nameof (prefabDataLookup));
        PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr, "<>4__this");
        PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr_prefabGuidHashToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr, nameof (prefabGuidHashToEntityMap));
        PrefabCollectionSystem.__c__DisplayClass149_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr, 100666711);
        PrefabCollectionSystem.__c__DisplayClass149_0.NativeMethodInfoPtr__RegisterPrefabs_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr, 100666712);
        PrefabCollectionSystem.__c__DisplayClass149_0.NativeMethodInfoPtr__RegisterPrefabs_b__1_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr, 100666713);
      }

      public __c__DisplayClass149_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass149_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass149_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<PrefabGUID, ConvertedAssetData> prefabDataLookup
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ConvertedAssetData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr_prefabDataLookup));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr_prefabDataLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ConvertedAssetData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PrefabCollectionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, Entity> prefabGuidHashToEntityMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr_prefabGuidHashToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass149_0.NativeFieldInfoPtr_prefabGuidHashToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/<>c__DisplayClass150_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass150_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_baseToVariantsMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterPrefabInheritances_b__0_Internal_Void_byref_RegisterPrefabInheritance_0;
      [FieldOffset(0)]
      public NativeMultiHashMap<PrefabGUID, PrefabGUID> baseToVariantsMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass150_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass150_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterPrefabInheritances_b__0(
        [In] ref RegisterPrefabInheritance prefabInheritance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref prefabInheritance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass150_0.NativeMethodInfoPtr__RegisterPrefabInheritances_b__0_Internal_Void_byref_RegisterPrefabInheritance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass150_0()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass150_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass150_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass150_0>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass150_0.NativeFieldInfoPtr_baseToVariantsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass150_0>.NativeClassPtr, nameof (baseToVariantsMap));
        PrefabCollectionSystem.__c__DisplayClass150_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass150_0>.NativeClassPtr, 100666714);
        PrefabCollectionSystem.__c__DisplayClass150_0.NativeMethodInfoPtr__RegisterPrefabInheritances_b__0_Internal_Void_byref_RegisterPrefabInheritance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass150_0>.NativeClassPtr, 100666715);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass150_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_AddToLookups")]
    public sealed class __c__DisplayClass_AddToLookups : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_PrefabCollectionBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass145_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755320, RefRangeEnd = 755321, XrefRangeStart = 755316, XrefRangeEnd = 755320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref DynamicBuffer<PrefabCollectionBuffer> prefabs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabs;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_PrefabCollectionBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(18)]
      [CachedScanResults(RefRangeStart = 755322, RefRangeEnd = 755340, XrefRangeStart = 755321, XrefRangeEnd = 755322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass145_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 755341, RefRangeEnd = 755365, XrefRangeStart = 755340, XrefRangeEnd = 755341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass145_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755365, XrefRangeEnd = 755367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755373, RefRangeEnd = 755374, XrefRangeStart = 755367, XrefRangeEnd = 755373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755376, RefRangeEnd = 755377, XrefRangeStart = 755374, XrefRangeEnd = 755376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PrefabCollectionSystem componentSystem,
        ref PrefabCollectionSystem.__c__DisplayClass145_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass145_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755377, XrefRangeEnd = 755383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AddToLookups()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass_AddToLookups");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, "<>4__this");
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, nameof (_runtimes));
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_PrefabCollectionBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, 100666716);
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, 100666717);
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, 100666718);
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, 100666719);
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, 100666720);
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass145_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, 100666721);
        PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, 100666722);
      }

      public __c__DisplayClass_AddToLookups(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_AddToLookups()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, data));
      }

      public unsafe PrefabCollectionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabs;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<PrefabCollectionBuffer> forParameter_prefabs;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755310, RefRangeEnd = 755311, XrefRangeStart = 755306, XrefRangeEnd = 755310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PrefabCollectionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755315, RefRangeEnd = 755316, XrefRangeStart = 755311, XrefRangeEnd = 755315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabs));
          PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders>.NativeClassPtr, 100666723);
          PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders>.NativeClassPtr, 100666724);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabs;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<PrefabCollectionBuffer>.Runtime runtime_prefabs;

          static Runtimes()
          {
            Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabs));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_AddToLookups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_GroupEntityNameCollectionBuffers")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GroupEntityNameCollectionBuffers
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_namesToSet;
      private static readonly System.IntPtr NativeFieldInfoPtr_names;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EntityNameCollectionBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass145_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeMultiHashMap<FixedString128, Entity> namesToSet;
      [FieldOffset(16)]
      public NativeHashSet<FixedString128> names;
      [FieldOffset(32)]
      public PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755468, XrefRangeEnd = 755494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref DynamicBuffer<EntityNameCollectionBuffer> entities)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entities;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EntityNameCollectionBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 755494, RefRangeEnd = 755501, XrefRangeStart = 755494, XrefRangeEnd = 755494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass145_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 755501, RefRangeEnd = 755508, XrefRangeStart = 755501, XrefRangeEnd = 755501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass145_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755508, XrefRangeEnd = 755510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755516, RefRangeEnd = 755517, XrefRangeStart = 755510, XrefRangeEnd = 755516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755519, RefRangeEnd = 755520, XrefRangeStart = 755517, XrefRangeEnd = 755519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PrefabCollectionSystem componentSystem,
        ref PrefabCollectionSystem.__c__DisplayClass145_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass145_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755520, XrefRangeEnd = 755524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755524, XrefRangeEnd = 755530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GroupEntityNameCollectionBuffers()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass_GroupEntityNameCollectionBuffers");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr_namesToSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, nameof (namesToSet));
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, nameof (names));
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, nameof (_runtimes));
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_EntityNameCollectionBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, 100666725);
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, 100666726);
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass145_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, 100666727);
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, 100666728);
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, 100666729);
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass145_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, 100666730);
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, 100666731);
        PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, 100666732);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entities;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<EntityNameCollectionBuffer> forParameter_entities;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755387, RefRangeEnd = 755388, XrefRangeStart = 755383, XrefRangeEnd = 755387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PrefabCollectionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755392, RefRangeEnd = 755393, XrefRangeStart = 755388, XrefRangeEnd = 755392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entities));
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders>.NativeClassPtr, 100666733);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders>.NativeClassPtr, 100666734);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entities;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<EntityNameCollectionBuffer>.Runtime runtime_entities;

          static Runtimes()
          {
            Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entities));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_GroupEntityNameCollectionBuffers/ProjectM.RunWithoutJobSystem_00000C22$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, "RunWithoutJobSystem_00000C22$PostfixBurstDelegate");
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666735);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666736);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666737);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666738);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_GroupEntityNameCollectionBuffers/ProjectM.RunWithoutJobSystem_00000C22$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755393, XrefRangeEnd = 755407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755407, XrefRangeEnd = 755425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755425, XrefRangeEnd = 755440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755467, RefRangeEnd = 755468, XrefRangeStart = 755440, XrefRangeEnd = 755467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers>.NativeClassPtr, "RunWithoutJobSystem_00000C22$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666739);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666740);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666741);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666742);
          PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666744);
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
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_GroupEntityNameCollectionBuffers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabsforFlags")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterPrefabsforFlags
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newAssetLabelsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr_flag;
      private static readonly System.IntPtr NativeFieldInfoPtr_flagList;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass147_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass147_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass147_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeList<PrefabCollectionSystem.PrefabAndFlags> newAssetLabelsToProcess;
      [FieldOffset(16)]
      public int flag;
      [FieldOffset(24)]
      public NativeList<PrefabGUID> flagList;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755605, XrefRangeEnd = 755618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755618, RefRangeEnd = 755619, XrefRangeStart = 755618, XrefRangeEnd = 755618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass147_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass147_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755619, RefRangeEnd = 755620, XrefRangeStart = 755619, XrefRangeEnd = 755619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass147_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass147_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755621, RefRangeEnd = 755622, XrefRangeStart = 755620, XrefRangeEnd = 755621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755623, RefRangeEnd = 755624, XrefRangeStart = 755622, XrefRangeEnd = 755623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PrefabCollectionSystem componentSystem,
        ref PrefabCollectionSystem.__c__DisplayClass147_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass147_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755624, XrefRangeEnd = 755628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755649, RefRangeEnd = 755650, XrefRangeStart = 755628, XrefRangeEnd = 755649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterPrefabsforFlags()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterPrefabsforFlags");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_newAssetLabelsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, nameof (newAssetLabelsToProcess));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, nameof (flag));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_flagList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, nameof (flagList));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, 100666745);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass147_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, 100666746);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass147_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, 100666747);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, 100666748);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass147_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, 100666749);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, 100666750);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, 100666751);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabsforFlags/ProjectM.RunWithoutJobSystem_00000C2A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, "RunWithoutJobSystem_00000C2A$PostfixBurstDelegate");
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666752);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666753);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666754);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666755);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabsforFlags/ProjectM.RunWithoutJobSystem_00000C2A$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755530, XrefRangeEnd = 755544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755544, XrefRangeEnd = 755562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755562, XrefRangeEnd = 755577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755604, RefRangeEnd = 755605, XrefRangeStart = 755577, XrefRangeEnd = 755604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags>.NativeClassPtr, "RunWithoutJobSystem_00000C2A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666756);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666757);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666758);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666759);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666761);
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
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsforFlags.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_CleanUpDestroyedPrefabs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CleanUpDestroyedPrefabs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidHashToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass148_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass148_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass148_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, Entity> prefabGuidHashToEntityMap;
      [FieldOffset(16)]
      public ComponentDataFromEntity<PrefabGUID> prefabGuidFromEntity;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755725, XrefRangeEnd = 755734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755734, RefRangeEnd = 755735, XrefRangeStart = 755734, XrefRangeEnd = 755734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass148_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass148_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755735, RefRangeEnd = 755736, XrefRangeStart = 755735, XrefRangeEnd = 755735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass148_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass148_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755737, RefRangeEnd = 755738, XrefRangeStart = 755736, XrefRangeEnd = 755737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755739, RefRangeEnd = 755740, XrefRangeStart = 755738, XrefRangeEnd = 755739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PrefabCollectionSystem componentSystem,
        ref PrefabCollectionSystem.__c__DisplayClass148_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass148_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755740, XrefRangeEnd = 755744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755771, RefRangeEnd = 755772, XrefRangeStart = 755744, XrefRangeEnd = 755771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CleanUpDestroyedPrefabs()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass_CleanUpDestroyedPrefabs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeFieldInfoPtr_prefabGuidHashToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, nameof (prefabGuidHashToEntityMap));
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeFieldInfoPtr_prefabGuidFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, nameof (prefabGuidFromEntity));
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, 100666762);
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass148_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, 100666763);
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass148_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, 100666764);
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, 100666765);
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass148_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, 100666766);
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, 100666767);
        PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, 100666768);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_CleanUpDestroyedPrefabs/ProjectM.RunWithoutJobSystem_00000C30$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, "RunWithoutJobSystem_00000C30$PostfixBurstDelegate");
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666769);
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666770);
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666771);
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100666772);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_CleanUpDestroyedPrefabs/ProjectM.RunWithoutJobSystem_00000C30$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755650, XrefRangeEnd = 755664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755664, XrefRangeEnd = 755682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755682, XrefRangeEnd = 755697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755724, RefRangeEnd = 755725, XrefRangeStart = 755697, XrefRangeEnd = 755724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs>.NativeClassPtr, "RunWithoutJobSystem_00000C30$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666773);
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666774);
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666775);
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666776);
          PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666778);
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
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_CleanUpDestroyedPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterPrefabs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabDataLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidHashToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Prefab_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass149_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, ConvertedAssetData> prefabDataLookup;
      [FieldOffset(16)]
      public NativeHashMap<PrefabGUID, Entity> prefabGuidHashToEntityMap;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Prefab> _ComponentDataFromEntity_Prefab_0;
      [FieldOffset(64)]
      public PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755861, XrefRangeEnd = 755900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref RegisterPrefab registerPrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755900, RefRangeEnd = 755901, XrefRangeStart = 755900, XrefRangeEnd = 755900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass149_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755901, RefRangeEnd = 755902, XrefRangeStart = 755901, XrefRangeEnd = 755901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass149_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755902, XrefRangeEnd = 755904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755912, RefRangeEnd = 755913, XrefRangeStart = 755904, XrefRangeEnd = 755912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755918, RefRangeEnd = 755919, XrefRangeStart = 755913, XrefRangeEnd = 755918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PrefabCollectionSystem componentSystem,
        ref PrefabCollectionSystem.__c__DisplayClass149_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass149_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755919, XrefRangeEnd = 755923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755923, XrefRangeEnd = 755929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterPrefabs()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterPrefabs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr_prefabDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, nameof (prefabDataLookup));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr_prefabGuidHashToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, nameof (prefabGuidHashToEntityMap));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr__ComponentDataFromEntity_Prefab_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Prefab_0));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, nameof (_runtimes));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, 100666779);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, 100666780);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, 100666781);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, 100666782);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, 100666783);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass149_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, 100666784);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, 100666785);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, 100666786);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerPrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefab> forParameter_registerPrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755778, RefRangeEnd = 755779, XrefRangeStart = 755772, XrefRangeEnd = 755778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PrefabCollectionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755785, RefRangeEnd = 755786, XrefRangeStart = 755779, XrefRangeEnd = 755785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerPrefab));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders>.NativeClassPtr, 100666787);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders>.NativeClassPtr, 100666788);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerPrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefab>.Runtime runtime_registerPrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerPrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabs/ProjectM.RunWithoutJobSystem_00000C37$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, "RunWithoutJobSystem_00000C37$PostfixBurstDelegate");
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666789);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666790);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666791);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666792);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabs/ProjectM.RunWithoutJobSystem_00000C37$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755786, XrefRangeEnd = 755800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755800, XrefRangeEnd = 755818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755818, XrefRangeEnd = 755833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755860, RefRangeEnd = 755861, XrefRangeStart = 755833, XrefRangeEnd = 755860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs>.NativeClassPtr, "RunWithoutJobSystem_00000C37$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666793);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666794);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666795);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666796);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666798);
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
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabsWithoutBurst")]
    public sealed class __c__DisplayClass_RegisterPrefabsWithoutBurst : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass149_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755948, RefRangeEnd = 755949, XrefRangeStart = 755943, XrefRangeEnd = 755948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755950, RefRangeEnd = 755951, XrefRangeStart = 755949, XrefRangeEnd = 755950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass149_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 755970, RefRangeEnd = 755972, XrefRangeStart = 755951, XrefRangeEnd = 755970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass149_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755972, XrefRangeEnd = 755974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755982, RefRangeEnd = 755983, XrefRangeStart = 755974, XrefRangeEnd = 755982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 755985, RefRangeEnd = 755986, XrefRangeStart = 755983, XrefRangeEnd = 755985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PrefabCollectionSystem componentSystem,
        ref PrefabCollectionSystem.__c__DisplayClass149_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass149_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755986, XrefRangeEnd = 755992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterPrefabsWithoutBurst()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterPrefabsWithoutBurst");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, "<>4__this");
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, nameof (_runtimes));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, 100666799);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, 100666800);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass149_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, 100666801);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, 100666802);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, 100666803);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass149_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, 100666804);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, 100666805);
      }

      public __c__DisplayClass_RegisterPrefabsWithoutBurst(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RegisterPrefabsWithoutBurst()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, data));
      }

      public unsafe PrefabCollectionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerPrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefab> forParameter_registerPrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755935, RefRangeEnd = 755936, XrefRangeStart = 755929, XrefRangeEnd = 755935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PrefabCollectionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755942, RefRangeEnd = 755943, XrefRangeStart = 755936, XrefRangeEnd = 755942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerPrefab));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders>.NativeClassPtr, 100666806);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders>.NativeClassPtr, 100666807);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerPrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefab>.Runtime runtime_registerPrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerPrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabsWithoutBurst.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabInheritances")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterPrefabInheritances
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_baseToVariantsMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabInheritance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass150_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass150_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass150_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeMultiHashMap<PrefabGUID, PrefabGUID> baseToVariantsMap;
      [FieldOffset(16)]
      public PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756075, XrefRangeEnd = 756085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref RegisterPrefabInheritance prefabInheritance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref prefabInheritance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabInheritance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass150_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass150_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PrefabCollectionSystem.__c__DisplayClass150_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass150_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756085, XrefRangeEnd = 756087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 756092, RefRangeEnd = 756093, XrefRangeStart = 756087, XrefRangeEnd = 756092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 756095, RefRangeEnd = 756096, XrefRangeStart = 756093, XrefRangeEnd = 756095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PrefabCollectionSystem componentSystem,
        ref PrefabCollectionSystem.__c__DisplayClass150_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass150_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756096, XrefRangeEnd = 756100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756100, XrefRangeEnd = 756106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterPrefabInheritances()
      {
        Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterPrefabInheritances");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr_baseToVariantsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, nameof (baseToVariantsMap));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, nameof (_runtimes));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabInheritance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, 100666808);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass150_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, 100666809);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass150_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, 100666810);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, 100666811);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, 100666812);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_byref___c__DisplayClass150_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, 100666813);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, 100666814);
        PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, 100666815);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabInheritance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabInheritance> forParameter_prefabInheritance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755995, RefRangeEnd = 755996, XrefRangeStart = 755992, XrefRangeEnd = 755995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PrefabCollectionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 755999, RefRangeEnd = 756000, XrefRangeStart = 755996, XrefRangeEnd = 755999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabInheritance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabInheritance));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders>.NativeClassPtr, 100666816);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders>.NativeClassPtr, 100666817);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabInheritance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabInheritance>.Runtime runtime_prefabInheritance;

          static Runtimes()
          {
            Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabInheritance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabInheritance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabInheritances/ProjectM.RunWithoutJobSystem_00000C49$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, "RunWithoutJobSystem_00000C49$PostfixBurstDelegate");
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666818);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666819);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666820);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666821);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.PrefabCollectionSystem/ProjectM.<>c__DisplayClass_RegisterPrefabInheritances/ProjectM.RunWithoutJobSystem_00000C49$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756000, XrefRangeEnd = 756014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756014, XrefRangeEnd = 756032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756032, XrefRangeEnd = 756047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 756074, RefRangeEnd = 756075, XrefRangeStart = 756047, XrefRangeEnd = 756074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances>.NativeClassPtr, "RunWithoutJobSystem_00000C49$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666822);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666823);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666824);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666825);
          PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666827);
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
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PrefabCollectionSystem.__c__DisplayClass_RegisterPrefabInheritances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
