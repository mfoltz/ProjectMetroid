// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerHostSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ServerHostSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Description;
    private static readonly IntPtr NativeFieldInfoPtr_Port;
    private static readonly IntPtr NativeFieldInfoPtr_QueryPort;
    private static readonly IntPtr NativeFieldInfoPtr_Address;
    private static readonly IntPtr NativeFieldInfoPtr_MaxConnectedUsers;
    private static readonly IntPtr NativeFieldInfoPtr_MaxConnectedAdmins;
    private static readonly IntPtr NativeFieldInfoPtr_MinFreeSlotsNeededForNewUsers;
    private static readonly IntPtr NativeFieldInfoPtr_ServerFps;
    private static readonly IntPtr NativeFieldInfoPtr_AIUpdatesPerFrame;
    private static readonly IntPtr NativeFieldInfoPtr_Password;
    private static readonly IntPtr NativeFieldInfoPtr_Secure;
    private static readonly IntPtr NativeFieldInfoPtr_Authenticate;
    private static readonly IntPtr NativeFieldInfoPtr_ListOnSteam;
    private static readonly IntPtr NativeFieldInfoPtr_ServerBranch;
    private static readonly IntPtr NativeFieldInfoPtr_GameSettingsPreset;
    private static readonly IntPtr NativeFieldInfoPtr_SaveName;
    private static readonly IntPtr NativeFieldInfoPtr_AutoSaveCount;
    private static readonly IntPtr NativeFieldInfoPtr_AutoSaveInterval;
    private static readonly IntPtr NativeFieldInfoPtr_CompressSaveFiles;
    private static readonly IntPtr NativeFieldInfoPtr_AutoSaveSmartKeep;
    private static readonly IntPtr NativeFieldInfoPtr__AutoSaveSmartKeepParsed;
    private static readonly IntPtr NativeFieldInfoPtr_RunPersistenceTestsOnSave;
    private static readonly IntPtr NativeFieldInfoPtr_StorePersistenceDebugData;
    private static readonly IntPtr NativeFieldInfoPtr_GiveStarterItems;
    private static readonly IntPtr NativeFieldInfoPtr_LogAllNetworkEvents;
    private static readonly IntPtr NativeFieldInfoPtr_LogAdminEvents;
    private static readonly IntPtr NativeFieldInfoPtr_LogDebugEvents;
    private static readonly IntPtr NativeFieldInfoPtr_AdminOnlyDebugEvents;
    private static readonly IntPtr NativeFieldInfoPtr_EveryoneIsAdmin;
    private static readonly IntPtr NativeFieldInfoPtr_DisableDebugEvents;
    private static readonly IntPtr NativeFieldInfoPtr_EnableDangerousDebugEvents;
    private static readonly IntPtr NativeFieldInfoPtr_TrackArchetypeCreationsOnStartup;
    private static readonly IntPtr NativeFieldInfoPtr_ServerStartTimeOffset;
    private static readonly IntPtr NativeFieldInfoPtr_PersistenceVersionOverride;
    private static readonly IntPtr NativeFieldInfoPtr_LanMode;
    private static readonly IntPtr NativeFieldInfoPtr_LowerFPSWhenEmpty;
    private static readonly IntPtr NativeFieldInfoPtr_LowerFPSWhenEmptyValue;
    private static readonly IntPtr NativeFieldInfoPtr_UseTeleportPlayersOutOfCollisionFix;
    private static readonly IntPtr NativeFieldInfoPtr_RemoteBansURL;
    private static readonly IntPtr NativeFieldInfoPtr_RemoteAdminsURL;
    private static readonly IntPtr NativeFieldInfoPtr_ResetDaysInterval;
    private static readonly IntPtr NativeFieldInfoPtr_DayOfReset;
    private static readonly IntPtr NativeFieldInfoPtr_AFKKickType;
    private static readonly IntPtr NativeFieldInfoPtr_AFKKickDuration;
    private static readonly IntPtr NativeFieldInfoPtr_AFKKickWarningDuration;
    private static readonly IntPtr NativeFieldInfoPtr_AFKKickPlayerRatio;
    private static readonly IntPtr NativeFieldInfoPtr_ListOnEOS;
    private static readonly IntPtr NativeFieldInfoPtr_EnableBacktraceANR;
    private static readonly IntPtr NativeFieldInfoPtr_API;
    private static readonly IntPtr NativeFieldInfoPtr_Rcon;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AutoSaveSmartKeepParsed_Public_get_List_1_AutoSaveSmartKeepEntry_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasPassword_Public_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ResetParsedAutoSaveSmartKeep_Private_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryParseAutoSaveSmartKeep_Public_Boolean_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 749316, RefRangeEnd = 749321, XrefRangeStart = 749273, XrefRangeEnd = 749316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerHostSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerHostSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749321, XrefRangeEnd = 749364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerHostSettings(bool loadDefault)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &loadDefault;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerHostSettings.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe List<AutoSaveSmartKeepEntry> AutoSaveSmartKeepParsed
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerHostSettings.NativeMethodInfoPtr_get_AutoSaveSmartKeepParsed_Public_get_List_1_AutoSaveSmartKeepEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<AutoSaveSmartKeepEntry>) null : new List<AutoSaveSmartKeepEntry>(pointer);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749365, RefRangeEnd = 749367, XrefRangeStart = 749364, XrefRangeEnd = 749365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasPassword()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerHostSettings.NativeMethodInfoPtr_HasPassword_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749374, RefRangeEnd = 749375, XrefRangeStart = 749367, XrefRangeEnd = 749374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ResetParsedAutoSaveSmartKeep(bool returnValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &returnValue;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerHostSettings.NativeMethodInfoPtr_ResetParsedAutoSaveSmartKeep_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749400, RefRangeEnd = 749401, XrefRangeStart = 749375, XrefRangeEnd = 749400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryParseAutoSaveSmartKeep()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerHostSettings.NativeMethodInfoPtr_TryParseAutoSaveSmartKeep_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerHostSettings()
    {
      Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerHostSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr);
      ServerHostSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (DefaultPath));
      ServerHostSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (LocalPath));
      ServerHostSettings.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (Name));
      ServerHostSettings.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (Description));
      ServerHostSettings.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (Port));
      ServerHostSettings.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (QueryPort));
      ServerHostSettings.NativeFieldInfoPtr_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (Address));
      ServerHostSettings.NativeFieldInfoPtr_MaxConnectedUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (MaxConnectedUsers));
      ServerHostSettings.NativeFieldInfoPtr_MaxConnectedAdmins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (MaxConnectedAdmins));
      ServerHostSettings.NativeFieldInfoPtr_MinFreeSlotsNeededForNewUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (MinFreeSlotsNeededForNewUsers));
      ServerHostSettings.NativeFieldInfoPtr_ServerFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (ServerFps));
      ServerHostSettings.NativeFieldInfoPtr_AIUpdatesPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AIUpdatesPerFrame));
      ServerHostSettings.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (Password));
      ServerHostSettings.NativeFieldInfoPtr_Secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (Secure));
      ServerHostSettings.NativeFieldInfoPtr_Authenticate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (Authenticate));
      ServerHostSettings.NativeFieldInfoPtr_ListOnSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (ListOnSteam));
      ServerHostSettings.NativeFieldInfoPtr_ServerBranch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (ServerBranch));
      ServerHostSettings.NativeFieldInfoPtr_GameSettingsPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (GameSettingsPreset));
      ServerHostSettings.NativeFieldInfoPtr_SaveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (SaveName));
      ServerHostSettings.NativeFieldInfoPtr_AutoSaveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AutoSaveCount));
      ServerHostSettings.NativeFieldInfoPtr_AutoSaveInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AutoSaveInterval));
      ServerHostSettings.NativeFieldInfoPtr_CompressSaveFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (CompressSaveFiles));
      ServerHostSettings.NativeFieldInfoPtr_AutoSaveSmartKeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AutoSaveSmartKeep));
      ServerHostSettings.NativeFieldInfoPtr__AutoSaveSmartKeepParsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (_AutoSaveSmartKeepParsed));
      ServerHostSettings.NativeFieldInfoPtr_RunPersistenceTestsOnSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (RunPersistenceTestsOnSave));
      ServerHostSettings.NativeFieldInfoPtr_StorePersistenceDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (StorePersistenceDebugData));
      ServerHostSettings.NativeFieldInfoPtr_GiveStarterItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (GiveStarterItems));
      ServerHostSettings.NativeFieldInfoPtr_LogAllNetworkEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (LogAllNetworkEvents));
      ServerHostSettings.NativeFieldInfoPtr_LogAdminEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (LogAdminEvents));
      ServerHostSettings.NativeFieldInfoPtr_LogDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (LogDebugEvents));
      ServerHostSettings.NativeFieldInfoPtr_AdminOnlyDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AdminOnlyDebugEvents));
      ServerHostSettings.NativeFieldInfoPtr_EveryoneIsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (EveryoneIsAdmin));
      ServerHostSettings.NativeFieldInfoPtr_DisableDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (DisableDebugEvents));
      ServerHostSettings.NativeFieldInfoPtr_EnableDangerousDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (EnableDangerousDebugEvents));
      ServerHostSettings.NativeFieldInfoPtr_TrackArchetypeCreationsOnStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (TrackArchetypeCreationsOnStartup));
      ServerHostSettings.NativeFieldInfoPtr_ServerStartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (ServerStartTimeOffset));
      ServerHostSettings.NativeFieldInfoPtr_PersistenceVersionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (PersistenceVersionOverride));
      ServerHostSettings.NativeFieldInfoPtr_LanMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (LanMode));
      ServerHostSettings.NativeFieldInfoPtr_LowerFPSWhenEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (LowerFPSWhenEmpty));
      ServerHostSettings.NativeFieldInfoPtr_LowerFPSWhenEmptyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (LowerFPSWhenEmptyValue));
      ServerHostSettings.NativeFieldInfoPtr_UseTeleportPlayersOutOfCollisionFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (UseTeleportPlayersOutOfCollisionFix));
      ServerHostSettings.NativeFieldInfoPtr_RemoteBansURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (RemoteBansURL));
      ServerHostSettings.NativeFieldInfoPtr_RemoteAdminsURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (RemoteAdminsURL));
      ServerHostSettings.NativeFieldInfoPtr_ResetDaysInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (ResetDaysInterval));
      ServerHostSettings.NativeFieldInfoPtr_DayOfReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (DayOfReset));
      ServerHostSettings.NativeFieldInfoPtr_AFKKickType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AFKKickType));
      ServerHostSettings.NativeFieldInfoPtr_AFKKickDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AFKKickDuration));
      ServerHostSettings.NativeFieldInfoPtr_AFKKickWarningDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AFKKickWarningDuration));
      ServerHostSettings.NativeFieldInfoPtr_AFKKickPlayerRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (AFKKickPlayerRatio));
      ServerHostSettings.NativeFieldInfoPtr_ListOnEOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (ListOnEOS));
      ServerHostSettings.NativeFieldInfoPtr_EnableBacktraceANR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (EnableBacktraceANR));
      ServerHostSettings.NativeFieldInfoPtr_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (API));
      ServerHostSettings.NativeFieldInfoPtr_Rcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, nameof (Rcon));
      ServerHostSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, 100665998);
      ServerHostSettings.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, 100665999);
      ServerHostSettings.NativeMethodInfoPtr_get_AutoSaveSmartKeepParsed_Public_get_List_1_AutoSaveSmartKeepEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, 100666000);
      ServerHostSettings.NativeMethodInfoPtr_HasPassword_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, 100666001);
      ServerHostSettings.NativeMethodInfoPtr_ResetParsedAutoSaveSmartKeep_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, 100666002);
      ServerHostSettings.NativeMethodInfoPtr_TryParseAutoSaveSmartKeep_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHostSettings>.NativeClassPtr, 100666003);
    }

    public ServerHostSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerHostSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerHostSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerHostSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerHostSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Description
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Description)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int Port
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Port));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Port)) = value;
      }
    }

    public unsafe int QueryPort
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_QueryPort));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_QueryPort)) = value;
      }
    }

    public unsafe string Address
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Address)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Address), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int MaxConnectedUsers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_MaxConnectedUsers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_MaxConnectedUsers)) = value;
      }
    }

    public unsafe int MaxConnectedAdmins
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_MaxConnectedAdmins));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_MaxConnectedAdmins)) = value;
      }
    }

    public unsafe int MinFreeSlotsNeededForNewUsers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_MinFreeSlotsNeededForNewUsers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_MinFreeSlotsNeededForNewUsers)) = value;
      }
    }

    public unsafe int ServerFps
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ServerFps));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ServerFps)) = value;
      }
    }

    public unsafe int AIUpdatesPerFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AIUpdatesPerFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AIUpdatesPerFrame)) = value;
      }
    }

    public unsafe string Password
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Password)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool Secure
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Secure));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Secure)) = value;
      }
    }

    public unsafe bool Authenticate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Authenticate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Authenticate)) = value;
      }
    }

    public unsafe bool ListOnSteam
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ListOnSteam));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ListOnSteam)) = value;
      }
    }

    public unsafe string ServerBranch
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ServerBranch)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ServerBranch), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string GameSettingsPreset
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_GameSettingsPreset)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_GameSettingsPreset), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string SaveName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_SaveName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_SaveName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int AutoSaveCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AutoSaveCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AutoSaveCount)) = value;
      }
    }

    public unsafe int AutoSaveInterval
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AutoSaveInterval));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AutoSaveInterval)) = value;
      }
    }

    public unsafe bool CompressSaveFiles
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_CompressSaveFiles));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_CompressSaveFiles)) = value;
      }
    }

    public unsafe string AutoSaveSmartKeep
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AutoSaveSmartKeep)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AutoSaveSmartKeep), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<AutoSaveSmartKeepEntry> _AutoSaveSmartKeepParsed
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr__AutoSaveSmartKeepParsed));
        return pointer == IntPtr.Zero ? (List<AutoSaveSmartKeepEntry>) null : new List<AutoSaveSmartKeepEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr__AutoSaveSmartKeepParsed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool RunPersistenceTestsOnSave
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_RunPersistenceTestsOnSave));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_RunPersistenceTestsOnSave)) = value;
      }
    }

    public unsafe bool StorePersistenceDebugData
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_StorePersistenceDebugData));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_StorePersistenceDebugData)) = value;
      }
    }

    public unsafe bool GiveStarterItems
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_GiveStarterItems));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_GiveStarterItems)) = value;
      }
    }

    public unsafe bool LogAllNetworkEvents
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LogAllNetworkEvents));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LogAllNetworkEvents)) = value;
      }
    }

    public unsafe bool LogAdminEvents
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LogAdminEvents));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LogAdminEvents)) = value;
      }
    }

    public unsafe bool LogDebugEvents
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LogDebugEvents));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LogDebugEvents)) = value;
      }
    }

    public unsafe bool AdminOnlyDebugEvents
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AdminOnlyDebugEvents));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AdminOnlyDebugEvents)) = value;
      }
    }

    public unsafe bool EveryoneIsAdmin
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_EveryoneIsAdmin));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_EveryoneIsAdmin)) = value;
      }
    }

    public unsafe bool DisableDebugEvents
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_DisableDebugEvents));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_DisableDebugEvents)) = value;
      }
    }

    public unsafe bool EnableDangerousDebugEvents
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_EnableDangerousDebugEvents));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_EnableDangerousDebugEvents)) = value;
      }
    }

    public unsafe bool TrackArchetypeCreationsOnStartup
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_TrackArchetypeCreationsOnStartup));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_TrackArchetypeCreationsOnStartup)) = value;
      }
    }

    public unsafe double ServerStartTimeOffset
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ServerStartTimeOffset));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ServerStartTimeOffset)) = value;
      }
    }

    public unsafe int PersistenceVersionOverride
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_PersistenceVersionOverride));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_PersistenceVersionOverride)) = value;
      }
    }

    public unsafe bool LanMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LanMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LanMode)) = value;
      }
    }

    public unsafe bool LowerFPSWhenEmpty
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LowerFPSWhenEmpty));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LowerFPSWhenEmpty)) = value;
      }
    }

    public unsafe int LowerFPSWhenEmptyValue
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LowerFPSWhenEmptyValue));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_LowerFPSWhenEmptyValue)) = value;
      }
    }

    public unsafe bool UseTeleportPlayersOutOfCollisionFix
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_UseTeleportPlayersOutOfCollisionFix));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_UseTeleportPlayersOutOfCollisionFix)) = value;
      }
    }

    public unsafe string RemoteBansURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_RemoteBansURL)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_RemoteBansURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string RemoteAdminsURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_RemoteAdminsURL)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_RemoteAdminsURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int ResetDaysInterval
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ResetDaysInterval));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ResetDaysInterval)) = value;
      }
    }

    public unsafe ResetDayEnum DayOfReset
    {
      get
      {
        return *(ResetDayEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_DayOfReset));
      }
      [param: In] set
      {
        *(ResetDayEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_DayOfReset)) = value;
      }
    }

    public unsafe AFKKickType AFKKickType
    {
      get
      {
        return *(AFKKickType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AFKKickType));
      }
      [param: In] set
      {
        *(AFKKickType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AFKKickType)) = value;
      }
    }

    public unsafe int AFKKickDuration
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AFKKickDuration));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AFKKickDuration)) = value;
      }
    }

    public unsafe int AFKKickWarningDuration
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AFKKickWarningDuration));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AFKKickWarningDuration)) = value;
      }
    }

    public unsafe float AFKKickPlayerRatio
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AFKKickPlayerRatio));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_AFKKickPlayerRatio)) = value;
      }
    }

    public unsafe bool ListOnEOS
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ListOnEOS));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_ListOnEOS)) = value;
      }
    }

    public unsafe bool EnableBacktraceANR
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_EnableBacktraceANR));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_EnableBacktraceANR)) = value;
      }
    }

    public unsafe WebApiSettings API
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_API));
        return pointer == IntPtr.Zero ? (WebApiSettings) null : new WebApiSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_API), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RconSettings Rcon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Rcon));
        return pointer == IntPtr.Zero ? (RconSettings) null : new RconSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHostSettings.NativeFieldInfoPtr_Rcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
