// Decompiled with JetBrains decompiler
// Type: ProjectM.GameBootstrap
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using ProjectM.Presentation;
using ProjectM.Sequencer;
using ProjectM.Shared;
using ProjectM.Terrain;
using ProjectM.UI;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Scenes;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class GameBootstrap : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectionBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFaction;
    private static readonly System.IntPtr NativeFieldInfoPtr_VampirePvPRespawnBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserCommandDataPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingCombatTextEventPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropItemPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayCyclePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTimePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedSequencePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathContainerPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrisonerInteractBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_VampirePvPBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDeathContainerAnyonePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDeathContainerClanMembersPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDeathContainerOnlySelfPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserMapZoneDataPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_FallTravelBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_BossWoundedBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCombatBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeToBlackPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewDataPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugSettingsPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugLogsPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupSlotPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideCharacterBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerTeamPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTeamPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeutralTeamPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitTeamPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanTeamPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanInvitePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TopDownCameraPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_OrbitCameraPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCameraPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeScalePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoomPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryManagerPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleRailingsAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleDebugPrefabsAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodFountainPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodHuntsDataPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomMapMarkerPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleBuffsSettingsPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDEntryCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseVBloodMenuSubTaskPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SCTCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneralGameplayCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSystemSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterCustomizationSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartingItemSets;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodMenuRequirementPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodMenuShardBearersRequirementPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_GenderCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterCreationScenePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertOnDemandRootPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameSettingPresets;
    private static readonly System.IntPtr NativeFieldInfoPtr_VFXReplacementSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlinkSequencePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoodManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldMapSubscene;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelSubScene;
    private static readonly System.IntPtr NativeFieldInfoPtr_HUDSubScene;
    private static readonly System.IntPtr NativeFieldInfoPtr_UIAssetsSubScene;
    private static readonly System.IntPtr NativeFieldInfoPtr_HUDConversionPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_FirstSpawnSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cursors;
    private static readonly System.IntPtr NativeFieldInfoPtr_MagicaPhysicsManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerHostData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientCreateData;
    private static readonly System.IntPtr NativeFieldInfoPtr__StartThreadCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParentProcess;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParentProcessLifetimeActive;
    private static readonly System.IntPtr NativeFieldInfoPtr__DedicatedServerProcess;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabConversionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__CheckForQuitThread;
    private static readonly System.IntPtr NativeFieldInfoPtr__AlreadyShutdown;
    private static readonly System.IntPtr NativeFieldInfoPtr__Quit;
    private static readonly System.IntPtr NativeFieldInfoPtr__StartupFailure;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldHaveDedicatedServerRunning_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalServer_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDedicatedServerRunning_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabConversionWorld_Public_get_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameDataBootstrap_Public_GameDataBootstrap_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServerSaveSettings_Private_Static_Void_String_ServerHostSettings_UInt64_byref_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WarmupSubScenes_Private_Void_GameDataBootstrap_SceneLoadSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCursors_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveAndShutdownServer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveOnExit_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_KillServerProcessIfExists_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupServerWorld_Public_Void_World_byref_ServerHostData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupClientWorld_Public_Void_World_byref_ClientCreateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupWorldShared_Private_Void_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Internal_Void_World_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateMagicaPhysics_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__97_0_Private_Void_0;

    public unsafe bool ShouldHaveDedicatedServerRunning
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 1006831, RefRangeEnd = 1006834, XrefRangeStart = 1006831, XrefRangeEnd = 1006831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_get_ShouldHaveDedicatedServerRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsLocalServer
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1006834, RefRangeEnd = 1006835, XrefRangeStart = 1006834, XrefRangeEnd = 1006834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_get_IsLocalServer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsDedicatedServerRunning
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006835, XrefRangeEnd = 1006842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_get_IsDedicatedServerRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe World PrefabConversionWorld
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_get_PrefabConversionWorld_Public_get_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006842, XrefRangeEnd = 1006863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1006866, RefRangeEnd = 1006870, XrefRangeStart = 1006863, XrefRangeEnd = 1006866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameDataBootstrap GetGameDataBootstrap(bool displayDialogOnError)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &displayDialogOnError;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_GetGameDataBootstrap_Public_GameDataBootstrap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameDataBootstrap) null : new GameDataBootstrap(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006870, XrefRangeEnd = 1007044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007044, XrefRangeEnd = 1007074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetServerSaveSettings(
      string serverSaveName,
      ServerHostSettings serverHostSettings,
      ulong platformId,
      out string saveDirectoryPath,
      out string saveToLoadOnStart)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(serverSaveName);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverHostSettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &platformId;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_GetServerSaveSettings_Private_Static_Void_String_ServerHostSettings_UInt64_byref_String_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      saveDirectoryPath = IL2CPP.Il2CppStringToManaged(zero1);
      saveToLoadOnStart = IL2CPP.Il2CppStringToManaged(zero2);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WarmupSubScenes(
      GameDataBootstrap gameDataBootstrap,
      SceneLoadSystem waitForSceneLoadSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataBootstrap);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) waitForSceneLoadSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_WarmupSubScenes_Private_Void_GameDataBootstrap_SceneLoadSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007074, XrefRangeEnd = 1007077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterCursors()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_RegisterCursors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007077, XrefRangeEnd = 1007086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007086, XrefRangeEnd = 1007093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007093, XrefRangeEnd = 1007100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnApplicationQuit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1007122, RefRangeEnd = 1007124, XrefRangeStart = 1007100, XrefRangeEnd = 1007122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveAndShutdownServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_SaveAndShutdownServer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1007142, RefRangeEnd = 1007143, XrefRangeStart = 1007124, XrefRangeEnd = 1007142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveOnExit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_SaveOnExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1007180, RefRangeEnd = 1007181, XrefRangeStart = 1007143, XrefRangeEnd = 1007180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void KillServerProcessIfExists()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_KillServerProcessIfExists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1007249, RefRangeEnd = 1007250, XrefRangeStart = 1007181, XrefRangeEnd = 1007249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupServerWorld(World world, ref ServerHostData serverHostData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverHostData);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_SetupServerWorld_Public_Void_World_byref_ServerHostData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerHostData local = ref serverHostData;
      System.IntPtr pointer = ptr;
      ServerHostData serverHostData1 = pointer == System.IntPtr.Zero ? (ServerHostData) null : new ServerHostData(pointer);
      local = serverHostData1;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1007251, RefRangeEnd = 1007252, XrefRangeStart = 1007250, XrefRangeEnd = 1007251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupClientWorld(World world, ref ClientCreateData clientCreateData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientCreateData);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_SetupClientWorld_Public_Void_World_byref_ClientCreateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ClientCreateData local = ref clientCreateData;
      System.IntPtr pointer = ptr;
      ClientCreateData clientCreateData1 = pointer == System.IntPtr.Zero ? (ClientCreateData) null : new ClientCreateData(pointer);
      local = clientCreateData1;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1007300, RefRangeEnd = 1007302, XrefRangeStart = 1007252, XrefRangeEnd = 1007300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupWorldShared(World world)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_SetupWorldShared_Private_Void_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1007343, RefRangeEnd = 1007347, XrefRangeStart = 1007302, XrefRangeEnd = 1007343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrUpdatePhysicsSingleton(World targetWorld, bool disableDynamicPhysics = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &disableDynamicPhysics;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Internal_Void_World_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1007359, RefRangeEnd = 1007360, XrefRangeStart = 1007347, XrefRangeEnd = 1007359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InstantiateMagicaPhysics()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr_InstantiateMagicaPhysics_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameBootstrap()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007360, XrefRangeEnd = 1007382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__97_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameBootstrap.NativeMethodInfoPtr__Start_b__97_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameBootstrap()
    {
      Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GameBootstrap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr);
      GameBootstrap.NativeFieldInfoPtr_CharacterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CharacterPrefab));
      GameBootstrap.NativeFieldInfoPtr_PvPProtectionBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (PvPProtectionBuff));
      GameBootstrap.NativeFieldInfoPtr_PlayerFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (PlayerFaction));
      GameBootstrap.NativeFieldInfoPtr_VampirePvPRespawnBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (VampirePvPRespawnBuffPrefab));
      GameBootstrap.NativeFieldInfoPtr_UserPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (UserPrefab));
      GameBootstrap.NativeFieldInfoPtr_UserCommandDataPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (UserCommandDataPrefab));
      GameBootstrap.NativeFieldInfoPtr_ProgressionPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ProgressionPrefabGuid));
      GameBootstrap.NativeFieldInfoPtr_ScrollingCombatTextEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ScrollingCombatTextEventPrefab));
      GameBootstrap.NativeFieldInfoPtr_DropItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (DropItemPrefab));
      GameBootstrap.NativeFieldInfoPtr_DayCyclePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (DayCyclePrefab));
      GameBootstrap.NativeFieldInfoPtr_ServerTimePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ServerTimePrefab));
      GameBootstrap.NativeFieldInfoPtr_NetworkedSequencePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (NetworkedSequencePrefab));
      GameBootstrap.NativeFieldInfoPtr_DeathContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (DeathContainerPrefab));
      GameBootstrap.NativeFieldInfoPtr_PrisonerInteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (PrisonerInteractBuff));
      GameBootstrap.NativeFieldInfoPtr_VampirePvPBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (VampirePvPBuff));
      GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerAnyonePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (PlayerDeathContainerAnyonePrefab));
      GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerClanMembersPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (PlayerDeathContainerClanMembersPrefab));
      GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerOnlySelfPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (PlayerDeathContainerOnlySelfPrefab));
      GameBootstrap.NativeFieldInfoPtr_UserMapZoneDataPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (UserMapZoneDataPrefab));
      GameBootstrap.NativeFieldInfoPtr_TeleportBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (TeleportBuffPrefab));
      GameBootstrap.NativeFieldInfoPtr_FallTravelBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (FallTravelBuffPrefab));
      GameBootstrap.NativeFieldInfoPtr_BossWoundedBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (BossWoundedBuffPrefab));
      GameBootstrap.NativeFieldInfoPtr_PlayerCombatBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (PlayerCombatBuffPrefab));
      GameBootstrap.NativeFieldInfoPtr_FadeToBlackPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (FadeToBlackPrefab));
      GameBootstrap.NativeFieldInfoPtr_ServerDebugViewDataPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ServerDebugViewDataPrefab));
      GameBootstrap.NativeFieldInfoPtr_ServerDebugSettingsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ServerDebugSettingsPrefab));
      GameBootstrap.NativeFieldInfoPtr_ServerDebugLogsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ServerDebugLogsPrefab));
      GameBootstrap.NativeFieldInfoPtr_AbilityGroupSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (AbilityGroupSlotPrefab));
      GameBootstrap.NativeFieldInfoPtr_HideCharacterBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (HideCharacterBuffPrefab));
      GameBootstrap.NativeFieldInfoPtr_PlayerTeamPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (PlayerTeamPrefab));
      GameBootstrap.NativeFieldInfoPtr_CastleTeamPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CastleTeamPrefab));
      GameBootstrap.NativeFieldInfoPtr_NeutralTeamPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (NeutralTeamPrefab));
      GameBootstrap.NativeFieldInfoPtr_UnitTeamPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (UnitTeamPrefab));
      GameBootstrap.NativeFieldInfoPtr_ClanTeamPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ClanTeamPrefab));
      GameBootstrap.NativeFieldInfoPtr_ClanInvitePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ClanInvitePrefab));
      GameBootstrap.NativeFieldInfoPtr_TopDownCameraPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (TopDownCameraPrefab));
      GameBootstrap.NativeFieldInfoPtr_OrbitCameraPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (OrbitCameraPrefab));
      GameBootstrap.NativeFieldInfoPtr_FreeCameraPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (FreeCameraPrefab));
      GameBootstrap.NativeFieldInfoPtr_TimeScalePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (TimeScalePrefab));
      GameBootstrap.NativeFieldInfoPtr_CastleRoomPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CastleRoomPrefab));
      GameBootstrap.NativeFieldInfoPtr_CastleTerritoryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CastleTerritoryPrefab));
      GameBootstrap.NativeFieldInfoPtr_CastleTerritoryManagerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CastleTerritoryManagerPrefab));
      GameBootstrap.NativeFieldInfoPtr_CastleRailingsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CastleRailingsAsset));
      GameBootstrap.NativeFieldInfoPtr_CastleDebugPrefabsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CastleDebugPrefabsAsset));
      GameBootstrap.NativeFieldInfoPtr_BloodFountainPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (BloodFountainPrefab));
      GameBootstrap.NativeFieldInfoPtr_BloodHuntsDataPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (BloodHuntsDataPrefab));
      GameBootstrap.NativeFieldInfoPtr_CustomMapMarkerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CustomMapMarkerPrefab));
      GameBootstrap.NativeFieldInfoPtr_CastleBuffsSettingsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CastleBuffsSettingsPrefab));
      GameBootstrap.NativeFieldInfoPtr_CharacterHUDEntryCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CharacterHUDEntryCollection));
      GameBootstrap.NativeFieldInfoPtr_UseVBloodMenuSubTaskPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (UseVBloodMenuSubTaskPrefab));
      GameBootstrap.NativeFieldInfoPtr_SCTCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (SCTCollection));
      GameBootstrap.NativeFieldInfoPtr_GeneralGameplayCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (GeneralGameplayCollection));
      GameBootstrap.NativeFieldInfoPtr_ClanSystemSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ClanSystemSettings));
      GameBootstrap.NativeFieldInfoPtr_CharacterCustomizationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CharacterCustomizationSettings));
      GameBootstrap.NativeFieldInfoPtr_StartingItemSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (StartingItemSets));
      GameBootstrap.NativeFieldInfoPtr_VBloodMenuRequirementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (VBloodMenuRequirementPrefab));
      GameBootstrap.NativeFieldInfoPtr_VBloodMenuShardBearersRequirementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (VBloodMenuShardBearersRequirementPrefab));
      GameBootstrap.NativeFieldInfoPtr_GenderCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (GenderCollection));
      GameBootstrap.NativeFieldInfoPtr_CharacterCreationScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (CharacterCreationScenePrefab));
      GameBootstrap.NativeFieldInfoPtr_ConvertOnDemandRootPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ConvertOnDemandRootPrefabs));
      GameBootstrap.NativeFieldInfoPtr_KnockbackBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (KnockbackBuff));
      GameBootstrap.NativeFieldInfoPtr_InterruptBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (InterruptBuff));
      GameBootstrap.NativeFieldInfoPtr_GameSettingPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (GameSettingPresets));
      GameBootstrap.NativeFieldInfoPtr_VFXReplacementSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (VFXReplacementSettings));
      GameBootstrap.NativeFieldInfoPtr_BlinkSequencePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (BlinkSequencePrefab));
      GameBootstrap.NativeFieldInfoPtr_MoodManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (MoodManager));
      GameBootstrap.NativeFieldInfoPtr_TerrainOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (TerrainOwner));
      GameBootstrap.NativeFieldInfoPtr_WorldMapSubscene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (WorldMapSubscene));
      GameBootstrap.NativeFieldInfoPtr_HybridModelSubScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (HybridModelSubScene));
      GameBootstrap.NativeFieldInfoPtr_HUDSubScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (HUDSubScene));
      GameBootstrap.NativeFieldInfoPtr_UIAssetsSubScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (UIAssetsSubScene));
      GameBootstrap.NativeFieldInfoPtr_HUDConversionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (HUDConversionPrefab));
      GameBootstrap.NativeFieldInfoPtr_FirstSpawnSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (FirstSpawnSettings));
      GameBootstrap.NativeFieldInfoPtr_Cursors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (Cursors));
      GameBootstrap.NativeFieldInfoPtr_MagicaPhysicsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (MagicaPhysicsManager));
      GameBootstrap.NativeFieldInfoPtr_ServerHostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ServerHostData));
      GameBootstrap.NativeFieldInfoPtr_ClientCreateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ClientCreateData));
      GameBootstrap.NativeFieldInfoPtr__StartThreadCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_StartThreadCount));
      GameBootstrap.NativeFieldInfoPtr__ParentProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_ParentProcess));
      GameBootstrap.NativeFieldInfoPtr__ParentProcessLifetimeActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_ParentProcessLifetimeActive));
      GameBootstrap.NativeFieldInfoPtr__DedicatedServerProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_DedicatedServerProcess));
      GameBootstrap.NativeFieldInfoPtr__PrefabConversionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_PrefabConversionWorld));
      GameBootstrap.NativeFieldInfoPtr__CheckForQuitThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_CheckForQuitThread));
      GameBootstrap.NativeFieldInfoPtr__AlreadyShutdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_AlreadyShutdown));
      GameBootstrap.NativeFieldInfoPtr__Quit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_Quit));
      GameBootstrap.NativeFieldInfoPtr__StartupFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (_StartupFailure));
      GameBootstrap.NativeMethodInfoPtr_get_ShouldHaveDedicatedServerRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678156);
      GameBootstrap.NativeMethodInfoPtr_get_IsLocalServer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678157);
      GameBootstrap.NativeMethodInfoPtr_get_IsDedicatedServerRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678158);
      GameBootstrap.NativeMethodInfoPtr_get_PrefabConversionWorld_Public_get_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678159);
      GameBootstrap.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678160);
      GameBootstrap.NativeMethodInfoPtr_GetGameDataBootstrap_Public_GameDataBootstrap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678161);
      GameBootstrap.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678162);
      GameBootstrap.NativeMethodInfoPtr_GetServerSaveSettings_Private_Static_Void_String_ServerHostSettings_UInt64_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678163);
      GameBootstrap.NativeMethodInfoPtr_WarmupSubScenes_Private_Void_GameDataBootstrap_SceneLoadSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678164);
      GameBootstrap.NativeMethodInfoPtr_RegisterCursors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678165);
      GameBootstrap.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678166);
      GameBootstrap.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678167);
      GameBootstrap.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678168);
      GameBootstrap.NativeMethodInfoPtr_SaveAndShutdownServer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678169);
      GameBootstrap.NativeMethodInfoPtr_SaveOnExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678170);
      GameBootstrap.NativeMethodInfoPtr_KillServerProcessIfExists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678171);
      GameBootstrap.NativeMethodInfoPtr_SetupServerWorld_Public_Void_World_byref_ServerHostData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678172);
      GameBootstrap.NativeMethodInfoPtr_SetupClientWorld_Public_Void_World_byref_ClientCreateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678173);
      GameBootstrap.NativeMethodInfoPtr_SetupWorldShared_Private_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678174);
      GameBootstrap.NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Internal_Void_World_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678175);
      GameBootstrap.NativeMethodInfoPtr_InstantiateMagicaPhysics_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678176);
      GameBootstrap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678177);
      GameBootstrap.NativeMethodInfoPtr__Start_b__97_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, 100678178);
    }

    public GameBootstrap(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<GameObject> CharacterPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CharacterPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CharacterPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> PvPProtectionBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PvPProtectionBuff));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PvPProtectionBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<FactionAsset> PlayerFaction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerFaction));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<FactionAsset>) null : new WeakAssetReference<FactionAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerFaction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> VampirePvPRespawnBuffPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VampirePvPRespawnBuffPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VampirePvPRespawnBuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> UserPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UserPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UserPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> UserCommandDataPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UserCommandDataPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UserCommandDataPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> ProgressionPrefabGuid
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ProgressionPrefabGuid));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ProgressionPrefabGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> ScrollingCombatTextEventPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ScrollingCombatTextEventPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ScrollingCombatTextEventPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> DropItemPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_DropItemPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_DropItemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> DayCyclePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_DayCyclePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_DayCyclePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> ServerTimePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerTimePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerTimePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> NetworkedSequencePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_NetworkedSequencePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_NetworkedSequencePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> DeathContainerPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_DeathContainerPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_DeathContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> PrisonerInteractBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PrisonerInteractBuff));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PrisonerInteractBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> VampirePvPBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VampirePvPBuff));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VampirePvPBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> PlayerDeathContainerAnyonePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerAnyonePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerAnyonePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> PlayerDeathContainerClanMembersPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerClanMembersPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerClanMembersPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> PlayerDeathContainerOnlySelfPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerOnlySelfPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerDeathContainerOnlySelfPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> UserMapZoneDataPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UserMapZoneDataPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UserMapZoneDataPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> TeleportBuffPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_TeleportBuffPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_TeleportBuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> FallTravelBuffPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_FallTravelBuffPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_FallTravelBuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> BossWoundedBuffPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_BossWoundedBuffPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_BossWoundedBuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> PlayerCombatBuffPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerCombatBuffPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerCombatBuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> FadeToBlackPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_FadeToBlackPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_FadeToBlackPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> ServerDebugViewDataPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerDebugViewDataPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerDebugViewDataPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> ServerDebugSettingsPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerDebugSettingsPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerDebugSettingsPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> ServerDebugLogsPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerDebugLogsPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerDebugLogsPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> AbilityGroupSlotPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_AbilityGroupSlotPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_AbilityGroupSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> HideCharacterBuffPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_HideCharacterBuffPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_HideCharacterBuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> PlayerTeamPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerTeamPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_PlayerTeamPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CastleTeamPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleTeamPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleTeamPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> NeutralTeamPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_NeutralTeamPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_NeutralTeamPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> UnitTeamPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UnitTeamPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UnitTeamPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> ClanTeamPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ClanTeamPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ClanTeamPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> ClanInvitePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ClanInvitePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ClanInvitePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> TopDownCameraPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_TopDownCameraPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_TopDownCameraPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> OrbitCameraPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_OrbitCameraPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_OrbitCameraPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> FreeCameraPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_FreeCameraPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_FreeCameraPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> TimeScalePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_TimeScalePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_TimeScalePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CastleRoomPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleRoomPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleRoomPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CastleTerritoryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleTerritoryPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleTerritoryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CastleTerritoryManagerPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleTerritoryManagerPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleTerritoryManagerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<ScriptableObject> CastleRailingsAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleRailingsAsset));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<ScriptableObject>) null : new WeakAssetReference<ScriptableObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleRailingsAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<ScriptableObject> CastleDebugPrefabsAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleDebugPrefabsAsset));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<ScriptableObject>) null : new WeakAssetReference<ScriptableObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleDebugPrefabsAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> BloodFountainPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_BloodFountainPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_BloodFountainPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> BloodHuntsDataPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_BloodHuntsDataPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_BloodHuntsDataPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CustomMapMarkerPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CustomMapMarkerPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CustomMapMarkerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CastleBuffsSettingsPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleBuffsSettingsPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CastleBuffsSettingsPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CharacterHUDEntryCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CharacterHUDEntryCollection));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CharacterHUDEntryCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> UseVBloodMenuSubTaskPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UseVBloodMenuSubTaskPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UseVBloodMenuSubTaskPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<SCTTypeCollectionAsset> SCTCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_SCTCollection));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<SCTTypeCollectionAsset>) null : new WeakAssetReference<SCTTypeCollectionAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_SCTCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GeneralGameplayCollectionAsset> GeneralGameplayCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_GeneralGameplayCollection));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GeneralGameplayCollectionAsset>) null : new WeakAssetReference<GeneralGameplayCollectionAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_GeneralGameplayCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<ProjectM.Gameplay.Clan.ClanSystemSettings> ClanSystemSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ClanSystemSettings));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<ProjectM.Gameplay.Clan.ClanSystemSettings>) null : new WeakAssetReference<ProjectM.Gameplay.Clan.ClanSystemSettings>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ClanSystemSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<ProjectM.CharacterCustomizationSettings> CharacterCustomizationSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CharacterCustomizationSettings));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<ProjectM.CharacterCustomizationSettings>) null : new WeakAssetReference<ProjectM.CharacterCustomizationSettings>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CharacterCustomizationSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<ItemSetAsset>> StartingItemSets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_StartingItemSets));
        return pointer == System.IntPtr.Zero ? (List<WeakAssetReference<ItemSetAsset>>) null : new List<WeakAssetReference<ItemSetAsset>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_StartingItemSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<RecipeDataAsset> VBloodMenuRequirementPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VBloodMenuRequirementPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<RecipeDataAsset>) null : new WeakAssetReference<RecipeDataAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VBloodMenuRequirementPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<RecipeDataAsset> VBloodMenuShardBearersRequirementPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VBloodMenuShardBearersRequirementPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<RecipeDataAsset>) null : new WeakAssetReference<RecipeDataAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VBloodMenuShardBearersRequirementPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<FeaturesCollection> GenderCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_GenderCollection));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<FeaturesCollection>) null : new WeakAssetReference<FeaturesCollection>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_GenderCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CharacterCreationScenePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CharacterCreationScenePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_CharacterCreationScenePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<UnityEngine.Object>> ConvertOnDemandRootPrefabs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ConvertOnDemandRootPrefabs));
        return pointer == System.IntPtr.Zero ? (List<WeakAssetReference<UnityEngine.Object>>) null : new List<WeakAssetReference<UnityEngine.Object>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ConvertOnDemandRootPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> KnockbackBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_KnockbackBuff));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_KnockbackBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> InterruptBuff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_InterruptBuff));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_InterruptBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TextAsset> GameSettingPresets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_GameSettingPresets));
        return pointer == System.IntPtr.Zero ? (List<TextAsset>) null : new List<TextAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_GameSettingPresets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VFXReplacementSettings VFXReplacementSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VFXReplacementSettings));
        return pointer == System.IntPtr.Zero ? (VFXReplacementSettings) null : new VFXReplacementSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_VFXReplacementSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<SequenceEditorObject> BlinkSequencePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_BlinkSequencePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<SequenceEditorObject>) null : new WeakAssetReference<SequenceEditorObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_BlinkSequencePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MoodManagerComponent MoodManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_MoodManager));
        return pointer == System.IntPtr.Zero ? (MoodManagerComponent) null : new MoodManagerComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_MoodManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorldBehaviour TerrainOwner
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_TerrainOwner));
        return pointer == System.IntPtr.Zero ? (WorldBehaviour) null : new WorldBehaviour(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_TerrainOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SubScene WorldMapSubscene
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_WorldMapSubscene));
        return pointer == System.IntPtr.Zero ? (SubScene) null : new SubScene(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_WorldMapSubscene), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SubScene HybridModelSubScene
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_HybridModelSubScene));
        return pointer == System.IntPtr.Zero ? (SubScene) null : new SubScene(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_HybridModelSubScene), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SubScene HUDSubScene
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_HUDSubScene));
        return pointer == System.IntPtr.Zero ? (SubScene) null : new SubScene(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_HUDSubScene), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SubScene UIAssetsSubScene
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UIAssetsSubScene));
        return pointer == System.IntPtr.Zero ? (SubScene) null : new SubScene(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_UIAssetsSubScene), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> HUDConversionPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_HUDConversionPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_HUDConversionPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FirstTimeSpawnServerSetting FirstSpawnSettings
    {
      get
      {
        return *(FirstTimeSpawnServerSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_FirstSpawnSettings));
      }
      [param: In] set
      {
        *(FirstTimeSpawnServerSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_FirstSpawnSettings)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<CursorData> Cursors
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_Cursors));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CursorData>) null : new Il2CppReferenceArray<CursorData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_Cursors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject MagicaPhysicsManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_MagicaPhysicsManager));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_MagicaPhysicsManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerHostData ServerHostData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerHostData));
        return pointer == System.IntPtr.Zero ? (ServerHostData) null : new ServerHostData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ServerHostData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClientCreateData ClientCreateData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ClientCreateData));
        return pointer == System.IntPtr.Zero ? (ClientCreateData) null : new ClientCreateData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr_ClientCreateData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _StartThreadCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__StartThreadCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__StartThreadCount)) = value;
      }
    }

    public unsafe StunProcess _ParentProcess
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__ParentProcess));
        return pointer == System.IntPtr.Zero ? (StunProcess) null : new StunProcess(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__ParentProcess), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _ParentProcessLifetimeActive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__ParentProcessLifetimeActive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__ParentProcessLifetimeActive)) = value;
      }
    }

    public unsafe StunProcess _DedicatedServerProcess
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__DedicatedServerProcess));
        return pointer == System.IntPtr.Zero ? (StunProcess) null : new StunProcess(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__DedicatedServerProcess), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe World _PrefabConversionWorld
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__PrefabConversionWorld));
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__PrefabConversionWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Thread _CheckForQuitThread
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__CheckForQuitThread));
        return pointer == System.IntPtr.Zero ? (Thread) null : new Thread(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__CheckForQuitThread), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _AlreadyShutdown
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__AlreadyShutdown));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__AlreadyShutdown)) = value;
      }
    }

    public unsafe bool _Quit
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__Quit));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__Quit)) = value;
      }
    }

    public unsafe bool _StartupFailure
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__StartupFailure));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameBootstrap.NativeFieldInfoPtr__StartupFailure)) = value;
      }
    }

    public class ConversionRoot : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ConversionRoot()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameBootstrap.ConversionRoot>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameBootstrap.ConversionRoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ConversionRoot()
      {
        Il2CppClassPointerStore<GameBootstrap.ConversionRoot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameBootstrap>.NativeClassPtr, nameof (ConversionRoot));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBootstrap.ConversionRoot>.NativeClassPtr);
        GameBootstrap.ConversionRoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBootstrap.ConversionRoot>.NativeClassPtr, 100678179);
      }

      public ConversionRoot(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
