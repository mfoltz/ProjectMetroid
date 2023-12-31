// Decompiled with JetBrains decompiler
// Type: ProjectM.TeamUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding;
using ProjectM.Network;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class TeamUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTeam_Public_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateTeamModification_Public_Static_ModificationId_EntityManager_ModificationStructure_Entity_Entity_TeamReference_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTeamModification_Public_Static_Void_EntityManager_Entity_TeamReference_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModification_Public_Static_Void_EntityManager_Entity_ModificationId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAlliedUsers_Public_Static_Void_EntityManager_TeamReference_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClanMembers_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddUserToClan_Public_Static_Void_EntityManager_Entity_Entity_byref_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ForfeitCastle_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClaimCastle_Public_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTeamForTerritory_Public_Static_Void_EntityManager_Entity_CastleTerritory_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTeamForTerritory_Public_Static_Void_EntityManager_Entity_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UserCastleHeartCount_Public_Static_Int32_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveFromTeamAllies_Public_Static_Boolean_EntityManager_DynamicBuffer_1_TeamAllies_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddFromTeamAllies_Public_Static_Boolean_EntityManager_DynamicBuffer_1_TeamAllies_Entity_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731098, RefRangeEnd = 731099, XrefRangeStart = 731079, XrefRangeEnd = 731098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTeam(
      EntityManager entityManager,
      Entity target,
      Entity teamReferenceEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &teamReferenceEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_SetTeam_Public_Static_Void_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731121, RefRangeEnd = 731122, XrefRangeStart = 731099, XrefRangeEnd = 731121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ModificationId CreateTeamModification(
      EntityManager entityManager,
      ModificationStructure modificationStruct,
      Entity self,
      Entity target,
      TeamReference newTeamReference)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationStruct;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newTeamReference;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_CreateTeamModification_Public_Static_ModificationId_EntityManager_ModificationStructure_Entity_Entity_TeamReference_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731145, RefRangeEnd = 731146, XrefRangeStart = 731122, XrefRangeEnd = 731145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateTeamModification(
      EntityManager entityManager,
      Entity target,
      TeamReference newTeamReference,
      ModificationId modificationId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newTeamReference;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_UpdateTeamModification_Public_Static_Void_EntityManager_Entity_TeamReference_ModificationId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731168, RefRangeEnd = 731169, XrefRangeStart = 731146, XrefRangeEnd = 731168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveModification(
      EntityManager entityManager,
      Entity target,
      ModificationId modificationId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_RemoveModification_Public_Static_Void_EntityManager_Entity_ModificationId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 731216, RefRangeEnd = 731224, XrefRangeStart = 731169, XrefRangeEnd = 731216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAlliedUsers(
      EntityManager entityManager,
      TeamReference teamReference,
      NativeList<Entity> output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &teamReference;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_GetAlliedUsers_Public_Static_Void_EntityManager_TeamReference_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 731248, RefRangeEnd = 731253, XrefRangeStart = 731224, XrefRangeEnd = 731248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetClanMembers(
      EntityManager entityManager,
      Entity clanTeamEntity,
      NativeList<Entity> output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clanTeamEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_GetClanMembers_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 731370, RefRangeEnd = 731373, XrefRangeStart = 731253, XrefRangeEnd = 731370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddUserToClan(
      EntityManager entityManager,
      Entity clanTeamEntity,
      Entity userEntity,
      ref User user)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clanTeamEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_AddUserToClan_Public_Static_Void_EntityManager_Entity_Entity_byref_User_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731422, RefRangeEnd = 731423, XrefRangeStart = 731373, XrefRangeEnd = 731422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ForfeitCastle(EntityManager entityManager, Entity castleHeartEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_ForfeitCastle_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 731547, RefRangeEnd = 731549, XrefRangeStart = 731423, XrefRangeEnd = 731547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClaimCastle(
      EntityManager entityManager,
      Entity userEntity,
      Entity castleHeartEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_ClaimCastle_Public_Static_Void_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731555, RefRangeEnd = 731556, XrefRangeStart = 731549, XrefRangeEnd = 731555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateTeamForTerritory(
      EntityManager entityManager,
      Entity territorySingletonEntity,
      CastleTerritory castleTerritory,
      int team)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &territorySingletonEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleTerritory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &team;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_UpdateTeamForTerritory_Public_Static_Void_EntityManager_Entity_CastleTerritory_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 731568, RefRangeEnd = 731570, XrefRangeStart = 731556, XrefRangeEnd = 731568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateTeamForTerritory(
      EntityManager entityManager,
      Entity territorySingletonEntity,
      Entity castleHeartEntity,
      int team)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &territorySingletonEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &team;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_UpdateTeamForTerritory_Public_Static_Void_EntityManager_Entity_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 731598, RefRangeEnd = 731602, XrefRangeStart = 731570, XrefRangeEnd = 731598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int UserCastleHeartCount(EntityManager entityManager, Entity userEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_UserCastleHeartCount_Public_Static_Int32_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 731619, RefRangeEnd = 731625, XrefRangeStart = 731602, XrefRangeEnd = 731619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryRemoveFromTeamAllies(
      EntityManager entityManager,
      DynamicBuffer<TeamAllies> teamAllies,
      Entity toRemove)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &teamAllies;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toRemove;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_TryRemoveFromTeamAllies_Public_Static_Boolean_EntityManager_DynamicBuffer_1_TeamAllies_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 731644, RefRangeEnd = 731648, XrefRangeStart = 731625, XrefRangeEnd = 731644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryAddFromTeamAllies(
      EntityManager entityManager,
      DynamicBuffer<TeamAllies> teamAllies,
      Entity toAdd)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &teamAllies;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toAdd;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TeamUtility.NativeMethodInfoPtr_TryAddFromTeamAllies_Public_Static_Boolean_EntityManager_DynamicBuffer_1_TeamAllies_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TeamUtility()
    {
      Il2CppClassPointerStore<TeamUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TeamUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr);
      TeamUtility.NativeMethodInfoPtr_SetTeam_Public_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664635);
      TeamUtility.NativeMethodInfoPtr_CreateTeamModification_Public_Static_ModificationId_EntityManager_ModificationStructure_Entity_Entity_TeamReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664636);
      TeamUtility.NativeMethodInfoPtr_UpdateTeamModification_Public_Static_Void_EntityManager_Entity_TeamReference_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664637);
      TeamUtility.NativeMethodInfoPtr_RemoveModification_Public_Static_Void_EntityManager_Entity_ModificationId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664638);
      TeamUtility.NativeMethodInfoPtr_GetAlliedUsers_Public_Static_Void_EntityManager_TeamReference_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664639);
      TeamUtility.NativeMethodInfoPtr_GetClanMembers_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664640);
      TeamUtility.NativeMethodInfoPtr_AddUserToClan_Public_Static_Void_EntityManager_Entity_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664641);
      TeamUtility.NativeMethodInfoPtr_ForfeitCastle_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664642);
      TeamUtility.NativeMethodInfoPtr_ClaimCastle_Public_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664643);
      TeamUtility.NativeMethodInfoPtr_UpdateTeamForTerritory_Public_Static_Void_EntityManager_Entity_CastleTerritory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664644);
      TeamUtility.NativeMethodInfoPtr_UpdateTeamForTerritory_Public_Static_Void_EntityManager_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664645);
      TeamUtility.NativeMethodInfoPtr_UserCastleHeartCount_Public_Static_Int32_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664646);
      TeamUtility.NativeMethodInfoPtr_TryRemoveFromTeamAllies_Public_Static_Boolean_EntityManager_DynamicBuffer_1_TeamAllies_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664647);
      TeamUtility.NativeMethodInfoPtr_TryAddFromTeamAllies_Public_Static_Boolean_EntityManager_DynamicBuffer_1_TeamAllies_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeamUtility>.NativeClassPtr, 100664648);
    }

    public TeamUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
