// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantHelper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class ServantHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMissionSetting_Public_Static_Boolean_byref_DynamicBuffer_1_ServantMissionSetting_Int32_byref_ServantMissionSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionSuccessChanceForServant_Public_Static_Single_EntityManager_PrefabLookupMap_byref_ServantMissionSettingsSingleton_PrefabGUID_Entity_NativeList_1_Entity_Single_byref_Int32_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindFactionPerk_Public_Static_Boolean_EntityManager_Entity_Entity_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindBloodTypePerk_Public_Static_Boolean_EntityManager_Entity_Entity_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllServants_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_Boolean_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRandomizedLootFromMission_Public_Static_Void_DropUtilsData_NativeHashMap_2_PrefabGUID_ItemData_PrefabLookupMap_PrefabGUID_byref_ServantMissionSettingsSingleton_ServantMissionSetting_Entity_Single_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetActiveMissionsForThrone_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_ActiveServantMission_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1033800, RefRangeEnd = 1033802, XrefRangeStart = 1033796, XrefRangeEnd = 1033800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetMissionSetting(
      [In] ref DynamicBuffer<ServantMissionSetting> missionList,
      int missionDataID,
      out ServantMissionSetting mission)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref missionList;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &missionDataID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mission;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.NativeMethodInfoPtr_TryGetMissionSetting_Public_Static_Boolean_byref_DynamicBuffer_1_ServantMissionSetting_Int32_byref_ServantMissionSetting_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1033877, RefRangeEnd = 1033879, XrefRangeStart = 1033802, XrefRangeEnd = 1033877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetMissionSuccessChanceForServant(
      EntityManager entityManager,
      PrefabLookupMap prefabLookupMap,
      [In] ref ServantMissionSettingsSingleton servantMissionSettings,
      PrefabGUID selectedMission,
      Entity currentServant,
      NativeList<Entity> allAssignedServants,
      float missionStability,
      out int partyPower,
      out float perkLootBonus)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantMissionSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &selectedMission;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &currentServant;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &allAssignedServants;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &missionStability;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref partyPower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref perkLootBonus;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.NativeMethodInfoPtr_GetMissionSuccessChanceForServant_Public_Static_Single_EntityManager_PrefabLookupMap_byref_ServantMissionSettingsSingleton_PrefabGUID_Entity_NativeList_1_Entity_Single_byref_Int32_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1033914, RefRangeEnd = 1033915, XrefRangeStart = 1033879, XrefRangeEnd = 1033914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindFactionPerk(
      EntityManager entityManager,
      Entity perkCollectionEntity,
      Entity unitEntity,
      out PrefabGUID perk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &perkCollectionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &unitEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref perk;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.NativeMethodInfoPtr_TryFindFactionPerk_Public_Static_Boolean_EntityManager_Entity_Entity_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1033940, RefRangeEnd = 1033941, XrefRangeStart = 1033915, XrefRangeEnd = 1033940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindBloodTypePerk(
      EntityManager entityManager,
      Entity perkCollectionEntity,
      Entity unitEntity,
      out PrefabGUID perk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &perkCollectionEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &unitEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref perk;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.NativeMethodInfoPtr_TryFindBloodTypePerk_Public_Static_Boolean_EntityManager_Entity_Entity_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1033989, RefRangeEnd = 1033991, XrefRangeStart = 1033941, XrefRangeEnd = 1033989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAllServants(
      EntityManager entityManager,
      Entity throneEntity,
      NativeList<Entity> servantCoffinList,
      bool castleHeartConnectionRequirementDisabled,
      NativeList<Entity> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &throneEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &servantCoffinList;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartConnectionRequirementDisabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantHelper.NativeMethodInfoPtr_GetAllServants_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_Boolean_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1034056, RefRangeEnd = 1034057, XrefRangeStart = 1033991, XrefRangeEnd = 1034056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddRandomizedLootFromMission(
      DropUtils.DropUtilsData dropUtilsData,
      NativeHashMap<PrefabGUID, ItemData> itemMap,
      PrefabLookupMap prefabMapping,
      PrefabGUID selectedMission,
      [In] ref ServantMissionSettingsSingleton servantMissionSettings,
      ServantMissionSetting servantMissionSetting,
      Entity servant,
      float perkLootBonus,
      ServerGameBalanceSettings serverGameBalanceSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &dropUtilsData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMapping;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &selectedMission;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantMissionSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &servantMissionSetting;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &servant;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &perkLootBonus;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &serverGameBalanceSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantHelper.NativeMethodInfoPtr_AddRandomizedLootFromMission_Public_Static_Void_DropUtilsData_NativeHashMap_2_PrefabGUID_ItemData_PrefabLookupMap_PrefabGUID_byref_ServantMissionSettingsSingleton_ServantMissionSetting_Entity_Single_ServerGameBalanceSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1034064, RefRangeEnd = 1034069, XrefRangeStart = 1034057, XrefRangeEnd = 1034064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetActiveMissionsForThrone(
      EntityManager entityManager,
      Entity throneEntity,
      out DynamicBuffer<ActiveServantMission> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &throneEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.NativeMethodInfoPtr_TryGetActiveMissionsForThrone_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_ActiveServantMission_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServantHelper()
    {
      Il2CppClassPointerStore<ServantHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr);
      ServantHelper.NativeMethodInfoPtr_TryGetMissionSetting_Public_Static_Boolean_byref_DynamicBuffer_1_ServantMissionSetting_Int32_byref_ServantMissionSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr, 100680780);
      ServantHelper.NativeMethodInfoPtr_GetMissionSuccessChanceForServant_Public_Static_Single_EntityManager_PrefabLookupMap_byref_ServantMissionSettingsSingleton_PrefabGUID_Entity_NativeList_1_Entity_Single_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr, 100680781);
      ServantHelper.NativeMethodInfoPtr_TryFindFactionPerk_Public_Static_Boolean_EntityManager_Entity_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr, 100680782);
      ServantHelper.NativeMethodInfoPtr_TryFindBloodTypePerk_Public_Static_Boolean_EntityManager_Entity_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr, 100680783);
      ServantHelper.NativeMethodInfoPtr_GetAllServants_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_Boolean_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr, 100680784);
      ServantHelper.NativeMethodInfoPtr_AddRandomizedLootFromMission_Public_Static_Void_DropUtilsData_NativeHashMap_2_PrefabGUID_ItemData_PrefabLookupMap_PrefabGUID_byref_ServantMissionSettingsSingleton_ServantMissionSetting_Entity_Single_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr, 100680785);
      ServantHelper.NativeMethodInfoPtr_TryGetActiveMissionsForThrone_Public_Static_Boolean_EntityManager_Entity_byref_DynamicBuffer_1_ActiveServantMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr, 100680786);
    }

    public ServantHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static class ActiveMissionExtensions : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_ContainsServant_Public_Static_Boolean_byref_ActiveServantMission_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValidServants_Public_Static_Void_byref_ActiveServantMission_NativeList_1_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetCompletionTicks_Public_Static_Int64_byref_ActiveServantMission_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetSecondsUntilCompletion_Public_Static_Double_byref_ActiveServantMission_Int64_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsServantOnMission_Public_Static_Boolean_Entity_NativeArray_1_Entity_EntityManager_byref_Double_0;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1033750, RefRangeEnd = 1033754, XrefRangeStart = 1033742, XrefRangeEnd = 1033750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool ContainsServant(
        [In] ref ActiveServantMission activeMission,
        Entity servant)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref activeMission;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &servant;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_ContainsServant_Public_Static_Boolean_byref_ActiveServantMission_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1033773, RefRangeEnd = 1033774, XrefRangeStart = 1033754, XrefRangeEnd = 1033773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void GetValidServants(
        [In] ref ActiveServantMission activeMission,
        NativeList<Entity> result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref activeMission;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_GetValidServants_Public_Static_Void_byref_ActiveServantMission_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1033775, RefRangeEnd = 1033776, XrefRangeStart = 1033774, XrefRangeEnd = 1033775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe long GetCompletionTicks([In] ref ActiveServantMission activeMission)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeMission;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_GetCompletionTicks_Public_Static_Int64_byref_ActiveServantMission_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1033778, RefRangeEnd = 1033779, XrefRangeStart = 1033776, XrefRangeEnd = 1033778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe double GetSecondsUntilCompletion(
        [In] ref ActiveServantMission activeMission,
        long currentTicks)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref activeMission;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentTicks;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_GetSecondsUntilCompletion_Public_Static_Double_byref_ActiveServantMission_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(double*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1033794, RefRangeEnd = 1033796, XrefRangeStart = 1033779, XrefRangeEnd = 1033794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool IsServantOnMission(
        Entity servantEntity,
        NativeArray<Entity> activeServantMissionOwnerEntities,
        EntityManager entityManager,
        out double timeUntilCompletion)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &servantEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeServantMissionOwnerEntities;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref timeUntilCompletion;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_IsServantOnMission_Public_Static_Boolean_Entity_NativeArray_1_Entity_EntityManager_byref_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ActiveMissionExtensions()
      {
        Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantHelper>.NativeClassPtr, nameof (ActiveMissionExtensions));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions>.NativeClassPtr);
        ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_ContainsServant_Public_Static_Boolean_byref_ActiveServantMission_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions>.NativeClassPtr, 100680787);
        ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_GetValidServants_Public_Static_Void_byref_ActiveServantMission_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions>.NativeClassPtr, 100680788);
        ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_GetCompletionTicks_Public_Static_Int64_byref_ActiveServantMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions>.NativeClassPtr, 100680789);
        ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_GetSecondsUntilCompletion_Public_Static_Double_byref_ActiveServantMission_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions>.NativeClassPtr, 100680790);
        ServantHelper.ActiveMissionExtensions.NativeMethodInfoPtr_IsServantOnMission_Public_Static_Boolean_Entity_NativeArray_1_Entity_EntityManager_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions>.NativeClassPtr, 100680791);
      }

      public ActiveMissionExtensions(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static class TickHelper : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_TICKS_PER_SECOND;
        private static readonly System.IntPtr NativeMethodInfoPtr_TicksToSeconds_Public_Static_Double_Int64_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_SecondsToTicks_Public_Static_Int64_Single_0;

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 1033733, RefRangeEnd = 1033737, XrefRangeStart = 1033733, XrefRangeEnd = 1033733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe double TicksToSeconds(long ticks)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &ticks;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.ActiveMissionExtensions.TickHelper.NativeMethodInfoPtr_TicksToSeconds_Public_Static_Double_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(double*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(5)]
        [CachedScanResults(RefRangeStart = 1033737, RefRangeEnd = 1033742, XrefRangeStart = 1033737, XrefRangeEnd = 1033737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe long SecondsToTicks(float seconds)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &seconds;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantHelper.ActiveMissionExtensions.TickHelper.NativeMethodInfoPtr_SecondsToTicks_Public_Static_Int64_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(long*) IL2CPP.il2cpp_object_unbox(num);
        }

        static TickHelper()
        {
          Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions.TickHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions>.NativeClassPtr, nameof (TickHelper));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions.TickHelper>.NativeClassPtr);
          ServantHelper.ActiveMissionExtensions.TickHelper.NativeFieldInfoPtr_TICKS_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions.TickHelper>.NativeClassPtr, nameof (TICKS_PER_SECOND));
          ServantHelper.ActiveMissionExtensions.TickHelper.NativeMethodInfoPtr_TicksToSeconds_Public_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions.TickHelper>.NativeClassPtr, 100680792);
          ServantHelper.ActiveMissionExtensions.TickHelper.NativeMethodInfoPtr_SecondsToTicks_Public_Static_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantHelper.ActiveMissionExtensions.TickHelper>.NativeClassPtr, 100680793);
        }

        public TickHelper(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public static unsafe long TICKS_PER_SECOND
        {
          get
          {
            long ticksPerSecond;
            IL2CPP.il2cpp_field_static_get_value(ServantHelper.ActiveMissionExtensions.TickHelper.NativeFieldInfoPtr_TICKS_PER_SECOND, (void*) &ticksPerSecond);
            return ticksPerSecond;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServantHelper.ActiveMissionExtensions.TickHelper.NativeFieldInfoPtr_TICKS_PER_SECOND, (void*) &value);
          }
        }
      }
    }
  }
}
