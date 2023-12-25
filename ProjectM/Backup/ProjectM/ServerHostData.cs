// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerHostData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ServerHostData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableAiDebug;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuickStartup;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDedicated;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerPort;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryPort;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerMaxConnectedUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerMaxConnectedAdmins;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerMinFreeSlotsNeededForNewUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr_OwnerPlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitializeTerrainFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugViewData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugLogs;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserCommandDataPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectionBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFaction;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayCyclePrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTimePrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTerritoryManagerGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeToBlackPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerTeamPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeutralTeamPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitTeamPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeScalePrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomMapMarkerPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleBuffsSettingsPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrisonerInteractBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_VampirePvPBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartingItemSets;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingPresetHashes;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerHostData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerHostData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerHostData()
    {
      Il2CppClassPointerStore<ServerHostData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerHostData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr);
      ServerHostData.NativeFieldInfoPtr_EnableAiDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (EnableAiDebug));
      ServerHostData.NativeFieldInfoPtr_QuickStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (QuickStartup));
      ServerHostData.NativeFieldInfoPtr_IsDedicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (IsDedicated));
      ServerHostData.NativeFieldInfoPtr_ServerPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerPort));
      ServerHostData.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (QueryPort));
      ServerHostData.NativeFieldInfoPtr_ServerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerAddress));
      ServerHostData.NativeFieldInfoPtr_ServerMaxConnectedUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerMaxConnectedUsers));
      ServerHostData.NativeFieldInfoPtr_ServerMaxConnectedAdmins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerMaxConnectedAdmins));
      ServerHostData.NativeFieldInfoPtr_ServerMinFreeSlotsNeededForNewUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerMinFreeSlotsNeededForNewUsers));
      ServerHostData.NativeFieldInfoPtr_OwnerPlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (OwnerPlatformId));
      ServerHostData.NativeFieldInfoPtr_InitializeTerrainFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (InitializeTerrainFlags));
      ServerHostData.NativeFieldInfoPtr_ServerDebugViewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerDebugViewData));
      ServerHostData.NativeFieldInfoPtr_ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerDebugSettings));
      ServerHostData.NativeFieldInfoPtr_ServerDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerDebugLogs));
      ServerHostData.NativeFieldInfoPtr_UserPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (UserPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_UserCommandDataPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (UserCommandDataPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_ProgressionPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ProgressionPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_CharacterPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (CharacterPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_PvPProtectionBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (PvPProtectionBuff));
      ServerHostData.NativeFieldInfoPtr_PlayerFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (PlayerFaction));
      ServerHostData.NativeFieldInfoPtr_DayCyclePrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (DayCyclePrefabGuid));
      ServerHostData.NativeFieldInfoPtr_ServerTimePrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (ServerTimePrefabGuid));
      ServerHostData.NativeFieldInfoPtr_CastleTerritoryManagerGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (CastleTerritoryManagerGuid));
      ServerHostData.NativeFieldInfoPtr_FadeToBlackPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (FadeToBlackPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_PlayerTeamPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (PlayerTeamPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_NeutralTeamPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (NeutralTeamPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_UnitTeamPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (UnitTeamPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_TimeScalePrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (TimeScalePrefabGuid));
      ServerHostData.NativeFieldInfoPtr_CustomMapMarkerPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (CustomMapMarkerPrefabGuid));
      ServerHostData.NativeFieldInfoPtr_CastleBuffsSettingsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (CastleBuffsSettingsPrefab));
      ServerHostData.NativeFieldInfoPtr_PrisonerInteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (PrisonerInteractBuff));
      ServerHostData.NativeFieldInfoPtr_VampirePvPBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (VampirePvPBuff));
      ServerHostData.NativeFieldInfoPtr_StartingItemSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (StartingItemSets));
      ServerHostData.NativeFieldInfoPtr_SettingPresetHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, nameof (SettingPresetHashes));
      ServerHostData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHostData>.NativeClassPtr, 100675663);
    }

    public ServerHostData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool EnableAiDebug
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_EnableAiDebug));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_EnableAiDebug)) = value;
      }
    }

    public unsafe bool QuickStartup
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_QuickStartup));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_QuickStartup)) = value;
      }
    }

    public unsafe bool IsDedicated
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_IsDedicated));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_IsDedicated)) = value;
      }
    }

    public unsafe int ServerPort
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerPort));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerPort)) = value;
      }
    }

    public unsafe int QueryPort
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_QueryPort));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_QueryPort)) = value;
      }
    }

    public unsafe string ServerAddress
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerAddress)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerAddress), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int ServerMaxConnectedUsers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerMaxConnectedUsers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerMaxConnectedUsers)) = value;
      }
    }

    public unsafe int ServerMaxConnectedAdmins
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerMaxConnectedAdmins));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerMaxConnectedAdmins)) = value;
      }
    }

    public unsafe int ServerMinFreeSlotsNeededForNewUsers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerMinFreeSlotsNeededForNewUsers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerMinFreeSlotsNeededForNewUsers)) = value;
      }
    }

    public unsafe ulong OwnerPlatformId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_OwnerPlatformId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_OwnerPlatformId)) = value;
      }
    }

    public unsafe InitializeTerrainFlags InitializeTerrainFlags
    {
      get
      {
        return *(InitializeTerrainFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_InitializeTerrainFlags));
      }
      [param: In] set
      {
        *(InitializeTerrainFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_InitializeTerrainFlags)) = value;
      }
    }

    public unsafe PrefabGUID ServerDebugViewData
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerDebugViewData));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerDebugViewData)) = value;
      }
    }

    public unsafe PrefabGUID ServerDebugSettings
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerDebugSettings));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerDebugSettings)) = value;
      }
    }

    public unsafe PrefabGUID ServerDebugLogs
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerDebugLogs));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerDebugLogs)) = value;
      }
    }

    public unsafe PrefabGUID UserPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_UserPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_UserPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID UserCommandDataPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_UserCommandDataPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_UserCommandDataPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID ProgressionPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ProgressionPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ProgressionPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID CharacterPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_CharacterPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_CharacterPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID PvPProtectionBuff
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_PvPProtectionBuff));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_PvPProtectionBuff)) = value;
      }
    }

    public unsafe PrefabGUID PlayerFaction
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_PlayerFaction));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_PlayerFaction)) = value;
      }
    }

    public unsafe PrefabGUID DayCyclePrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_DayCyclePrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_DayCyclePrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID ServerTimePrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerTimePrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_ServerTimePrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID CastleTerritoryManagerGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_CastleTerritoryManagerGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_CastleTerritoryManagerGuid)) = value;
      }
    }

    public unsafe PrefabGUID FadeToBlackPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_FadeToBlackPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_FadeToBlackPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID PlayerTeamPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_PlayerTeamPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_PlayerTeamPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID NeutralTeamPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_NeutralTeamPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_NeutralTeamPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID UnitTeamPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_UnitTeamPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_UnitTeamPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID TimeScalePrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_TimeScalePrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_TimeScalePrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID CustomMapMarkerPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_CustomMapMarkerPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_CustomMapMarkerPrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID CastleBuffsSettingsPrefab
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_CastleBuffsSettingsPrefab));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_CastleBuffsSettingsPrefab)) = value;
      }
    }

    public unsafe PrefabGUID PrisonerInteractBuff
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_PrisonerInteractBuff));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_PrisonerInteractBuff)) = value;
      }
    }

    public unsafe PrefabGUID VampirePvPBuff
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_VampirePvPBuff));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_VampirePvPBuff)) = value;
      }
    }

    public unsafe List<PrefabGUID> StartingItemSets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_StartingItemSets));
        return pointer == System.IntPtr.Zero ? (List<PrefabGUID>) null : new List<PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_StartingItemSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> SettingPresetHashes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_SettingPresetHashes));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostData.NativeFieldInfoPtr_SettingPresetHashes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
