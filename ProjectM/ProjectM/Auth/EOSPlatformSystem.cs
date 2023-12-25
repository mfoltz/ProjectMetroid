// Decompiled with JetBrains decompiler
// Type: ProjectM.Auth.EOSPlatformSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using ProjectM.EOS;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Auth
{
  public class EOSPlatformSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ProductName;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProductVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr__SteamPlatformSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformInterface;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerSettingsSerializationNetBufferData;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitState;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitDone;
    private static readonly System.IntPtr NativeFieldInfoPtr_activeSessions;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoggedInUserID_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__NeedsLogin;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsLoggingIn_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__FailedLoginAttempts;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextLoginAttemptTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__CanAccessAPI_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__MyPublicIP;
    private static readonly System.IntPtr NativeFieldInfoPtr_authExpirationCallbackHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerNameKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAvailableKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerNameLowerInvariantKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerNameSortingValueKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCountKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenPlayerSlotsKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasPasswordKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDedicatedKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_TagsKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasScheduledWipesKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsesStandardSettingsKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_DaysRunningKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_DaysUntilResetKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionGuidKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_VersionKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_Branchkey;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodBoundEnabledKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartDamageModeKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameSettingsHashKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSizeKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHardcoreKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameModeKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionCreationTimeKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_AppIdKey;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsClient_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsServer_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LoggedInUserID_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LoggedInUserID_Private_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLoggedIn_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLoggingIn_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLoggingIn_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CanAccessAPI_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CanAccessAPI_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MyPublicIP_Public_get_IPAddress_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MyPublicIPUInt_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSystem_Public_Static_EOSPlatformSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAuthExpirationNotification_Private_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TickLoginReattemptLogic_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExponentialBackoffReattemptDelay_Private_Single_UInt32_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogInWithSteam_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInitResult_Public_Boolean_byref_PlatformInitState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSessionDataFromMatchmakingServerData_Private_Void_byref_MatchmakingServerData_String_Boolean_byref_SessionData_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IPFromString_Private_Boolean_String_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PortFromString_Private_Boolean_String_byref_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IPPortFromString_Private_Boolean_String_byref_UInt32_byref_Il2CppStructArray_1_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertSessionToListEntryData_Public_Boolean_Session_byref_ServerListEntryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSession_Public_Session_MatchmakingServerData_IPAddress_UInt16_UInt16_Boolean_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSession_Public_Session_MatchmakingServerData_IPAddress_UInt16_UInt16_UInt64_Boolean_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSessionInternal_Private_Session_MatchmakingServerData_String_Boolean_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifySession_Public_Void_byref_Session_MatchmakingServerData_Boolean_UInt32_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServerSettingsSerialized_Private_String_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SearchSessionsDebug_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServers_Public_SessionSearch_Il2CppReferenceArray_1_SearchCriteron_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllServers_Public_SessionSearchPaginated_Il2CppReferenceArray_1_SearchCriteron_EOSSessionSearchPaginatedResultsUpdatedHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Il2CppStructArray_1_Byte_PlatformError_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe bool IsClient
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139302, XrefRangeEnd = 1139303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_get_IsClient_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsServer
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139303, XrefRangeEnd = 1139304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_get_IsServer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ProductUserId LoggedInUserID
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_get_LoggedInUserID_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_set_LoggedInUserID_Private_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsLoggedIn
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1121947, RefRangeEnd = 1121948, XrefRangeStart = 1121947, XrefRangeEnd = 1121948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_get_IsLoggedIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsLoggingIn
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_get_IsLoggingIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_set_IsLoggingIn_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool CanAccessAPI
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_get_CanAccessAPI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_set_CanAccessAPI_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe IPAddress MyPublicIP
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1139306, RefRangeEnd = 1139308, XrefRangeStart = 1139304, XrefRangeEnd = 1139306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_get_MyPublicIP_Public_get_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IPAddress) null : new IPAddress(pointer);
      }
    }

    public unsafe uint MyPublicIPUInt
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139308, XrefRangeEnd = 1139311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_get_MyPublicIPUInt_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1139315, RefRangeEnd = 1139317, XrefRangeStart = 1139311, XrefRangeEnd = 1139315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EOSPlatformSystem GetSystem()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_GetSystem_Public_Static_EOSPlatformSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EOSPlatformSystem) null : new EOSPlatformSystem(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139317, XrefRangeEnd = 1139349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EOSPlatformSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139349, XrefRangeEnd = 1139362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAuthExpirationNotification(ProductUserId userId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_OnAuthExpirationNotification_Private_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139362, XrefRangeEnd = 1139422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EOSPlatformSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139422, XrefRangeEnd = 1139433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EOSPlatformSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139433, XrefRangeEnd = 1139442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TickLoginReattemptLogic()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_TickLoginReattemptLogic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139442, XrefRangeEnd = 1139445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetExponentialBackoffReattemptDelay(
      uint reattemptCount,
      float firstReattemptWait = 0.5f,
      float maximumReattemptWait = 30f,
      float jitter = 0.1f,
      float reattemptTimeMultiplier = 2f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &reattemptCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &firstReattemptWait;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maximumReattemptWait;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &jitter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &reattemptTimeMultiplier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_GetExponentialBackoffReattemptDelay_Private_Single_UInt32_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1139481, RefRangeEnd = 1139483, XrefRangeStart = 1139445, XrefRangeEnd = 1139481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogInWithSteam()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_LogInWithSteam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1139483, RefRangeEnd = 1139484, XrefRangeStart = 1139483, XrefRangeEnd = 1139483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetInitResult(out PlatformInitState initState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref initState;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_TryGetInitResult_Public_Boolean_byref_PlatformInitState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1139688, RefRangeEnd = 1139690, XrefRangeStart = 1139484, XrefRangeEnd = 1139688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateSessionDataFromMatchmakingServerData(
      ref ServerBootstrapSystem.MatchmakingServerData data,
      string address,
      bool isDedicated,
      out SessionData sessionData,
      uint playerCount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(address);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isDedicated;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &playerCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_CreateSessionDataFromMatchmakingServerData_Private_Void_byref_MatchmakingServerData_String_Boolean_byref_SessionData_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionData local = ref sessionData;
      System.IntPtr pointer = zero;
      SessionData sessionData1 = pointer == System.IntPtr.Zero ? (SessionData) null : new SessionData(pointer);
      local = sessionData1;
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1139700, RefRangeEnd = 1139703, XrefRangeStart = 1139690, XrefRangeEnd = 1139700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IPFromString(string ipString, out uint ip)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(ipString);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ip;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_IPFromString_Private_Boolean_String_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139703, XrefRangeEnd = 1139704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool PortFromString(string portString, out ushort port)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(portString);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref port;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_PortFromString_Private_Boolean_String_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139704, XrefRangeEnd = 1139716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IPPortFromString(
      string ipPortString,
      out uint ip,
      out Il2CppStructArray<ushort> ports)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(ipPortString);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ip;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_IPPortFromString_Private_Boolean_String_byref_UInt32_byref_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppStructArray<ushort> local = ref ports;
      System.IntPtr nativeObject = zero;
      Il2CppStructArray<> il2CppStructArray = nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<>) null : new Il2CppStructArray<>(nativeObject);
      local = (Il2CppStructArray<ushort>) il2CppStructArray;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1139919, RefRangeEnd = 1139920, XrefRangeStart = 1139716, XrefRangeEnd = 1139919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryConvertSessionToListEntryData(
      Session session,
      out ServerListEntryData serverListEntryData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) session);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_TryConvertSessionToListEntryData_Public_Boolean_Session_byref_ServerListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerListEntryData local = ref serverListEntryData;
      System.IntPtr pointer = zero;
      ServerListEntryData serverListEntryData1 = pointer == System.IntPtr.Zero ? (ServerListEntryData) null : new ServerListEntryData(pointer);
      local = serverListEntryData1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1139943, RefRangeEnd = 1139944, XrefRangeStart = 1139920, XrefRangeEnd = 1139943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Session CreateSession(
      ServerBootstrapSystem.MatchmakingServerData data,
      IPAddress ip,
      ushort port,
      ushort queryPort,
      bool isDedicated,
      EOSOperationCompleteHandler finishedCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ip);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &queryPort;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isDedicated;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finishedCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_CreateSession_Public_Session_MatchmakingServerData_IPAddress_UInt16_UInt16_Boolean_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139944, XrefRangeEnd = 1139976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Session CreateSession(
      ServerBootstrapSystem.MatchmakingServerData data,
      IPAddress ip,
      ushort port,
      ushort queryPort,
      ulong steamUserId,
      bool isDedicated,
      EOSOperationCompleteHandler finishedCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ip);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &queryPort;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &steamUserId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &isDedicated;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finishedCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_CreateSession_Public_Session_MatchmakingServerData_IPAddress_UInt16_UInt16_UInt64_Boolean_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1140008, RefRangeEnd = 1140010, XrefRangeStart = 1139976, XrefRangeEnd = 1140008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Session CreateSessionInternal(
      ServerBootstrapSystem.MatchmakingServerData data,
      string address,
      bool isDedicated,
      EOSOperationCompleteHandler finishedCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(address);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isDedicated;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finishedCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_CreateSessionInternal_Private_Session_MatchmakingServerData_String_Boolean_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1140033, RefRangeEnd = 1140034, XrefRangeStart = 1140010, XrefRangeEnd = 1140033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ModifySession(
      ref Session session,
      ServerBootstrapSystem.MatchmakingServerData data,
      bool isDedicated,
      uint playerCount,
      EOSOperationCompleteHandler finishedCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) session);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isDedicated;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &playerCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finishedCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_ModifySession_Public_Void_byref_Session_MatchmakingServerData_Boolean_UInt32_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Session local = ref session;
      System.IntPtr pointer = ptr;
      Session session1 = pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
      local = session1;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140034, XrefRangeEnd = 1140049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetServerSettingsSerialized(ServerGameBalanceSettings settings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &settings;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_GetServerSettingsSerialized_Private_String_ServerGameBalanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140049, XrefRangeEnd = 1140073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SearchSessionsDebug()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_SearchSessionsDebug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140073, XrefRangeEnd = 1140077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionSearch GetServers(
      Il2CppReferenceArray<SearchCriteron> searchCriteria,
      EOSOperationCompleteHandler searchSessionsCompleteCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) searchCriteria);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) searchSessionsCompleteCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_GetServers_Public_SessionSearch_Il2CppReferenceArray_1_SearchCriteron_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SessionSearch) null : new SessionSearch(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1140081, RefRangeEnd = 1140082, XrefRangeStart = 1140077, XrefRangeEnd = 1140081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionSearchPaginated GetAllServers(
      Il2CppReferenceArray<SearchCriteron> searchCriteria,
      EOSSessionSearchPaginatedResultsUpdatedHandler resultsUpdatedCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) searchCriteria);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultsUpdatedCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_GetAllServers_Public_SessionSearchPaginated_Il2CppReferenceArray_1_SearchCriteron_EOSSessionSearchPaginatedResultsUpdatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SessionSearchPaginated) null : new SessionSearchPaginated(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140082, XrefRangeEnd = 1140103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EOSPlatformSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140103, XrefRangeEnd = 1140133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_Il2CppStructArray_1_Byte_PlatformError_PDM_0(
      Il2CppStructArray<byte> appTicket,
      SteamPlatformSystem.PlatformError errorCode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) appTicket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &errorCode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_Il2CppStructArray_1_Byte_PlatformError_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1140154, RefRangeEnd = 1140155, XrefRangeStart = 1140133, XrefRangeEnd = 1140154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_Boolean_ProductUserId_0(
      bool success,
      ProductUserId userId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &success;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_Boolean_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Method_Private_Void_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EOSPlatformSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EOSPlatformSystem()
    {
      Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Auth", nameof (EOSPlatformSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr);
      EOSPlatformSystem.NativeFieldInfoPtr__ProductName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_ProductName));
      EOSPlatformSystem.NativeFieldInfoPtr__ProductVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_ProductVersion));
      EOSPlatformSystem.NativeFieldInfoPtr__SteamPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_SteamPlatformSystem));
      EOSPlatformSystem.NativeFieldInfoPtr__PlatformInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_PlatformInterface));
      EOSPlatformSystem.NativeFieldInfoPtr__ServerSettingsSerializationNetBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_ServerSettingsSerializationNetBufferData));
      EOSPlatformSystem.NativeFieldInfoPtr__InitState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_InitState));
      EOSPlatformSystem.NativeFieldInfoPtr__InitDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_InitDone));
      EOSPlatformSystem.NativeFieldInfoPtr_activeSessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (activeSessions));
      EOSPlatformSystem.NativeFieldInfoPtr_LogHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (LogHeader));
      EOSPlatformSystem.NativeFieldInfoPtr__LoggedInUserID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, "<LoggedInUserID>k__BackingField");
      EOSPlatformSystem.NativeFieldInfoPtr__NeedsLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_NeedsLogin));
      EOSPlatformSystem.NativeFieldInfoPtr__IsLoggingIn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, "<IsLoggingIn>k__BackingField");
      EOSPlatformSystem.NativeFieldInfoPtr__FailedLoginAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_FailedLoginAttempts));
      EOSPlatformSystem.NativeFieldInfoPtr__NextLoginAttemptTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_NextLoginAttemptTime));
      EOSPlatformSystem.NativeFieldInfoPtr__CanAccessAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, "<CanAccessAPI>k__BackingField");
      EOSPlatformSystem.NativeFieldInfoPtr__MyPublicIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (_MyPublicIP));
      EOSPlatformSystem.NativeFieldInfoPtr_authExpirationCallbackHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (authExpirationCallbackHandle));
      EOSPlatformSystem.NativeFieldInfoPtr_ServerNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (ServerNameKey));
      EOSPlatformSystem.NativeFieldInfoPtr_IsAvailableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (IsAvailableKey));
      EOSPlatformSystem.NativeFieldInfoPtr_ServerNameLowerInvariantKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (ServerNameLowerInvariantKey));
      EOSPlatformSystem.NativeFieldInfoPtr_ServerNameSortingValueKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (ServerNameSortingValueKey));
      EOSPlatformSystem.NativeFieldInfoPtr_PlayerCountKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (PlayerCountKey));
      EOSPlatformSystem.NativeFieldInfoPtr_OpenPlayerSlotsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (OpenPlayerSlotsKey));
      EOSPlatformSystem.NativeFieldInfoPtr_HasPasswordKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (HasPasswordKey));
      EOSPlatformSystem.NativeFieldInfoPtr_IsDedicatedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (IsDedicatedKey));
      EOSPlatformSystem.NativeFieldInfoPtr_TagsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (TagsKey));
      EOSPlatformSystem.NativeFieldInfoPtr_HasScheduledWipesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (HasScheduledWipesKey));
      EOSPlatformSystem.NativeFieldInfoPtr_UsesStandardSettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (UsesStandardSettingsKey));
      EOSPlatformSystem.NativeFieldInfoPtr_DaysRunningKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (DaysRunningKey));
      EOSPlatformSystem.NativeFieldInfoPtr_DaysUntilResetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (DaysUntilResetKey));
      EOSPlatformSystem.NativeFieldInfoPtr_SessionGuidKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (SessionGuidKey));
      EOSPlatformSystem.NativeFieldInfoPtr_VersionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (VersionKey));
      EOSPlatformSystem.NativeFieldInfoPtr_Branchkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (Branchkey));
      EOSPlatformSystem.NativeFieldInfoPtr_DescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (DescriptionKey));
      EOSPlatformSystem.NativeFieldInfoPtr_BloodBoundEnabledKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (BloodBoundEnabledKey));
      EOSPlatformSystem.NativeFieldInfoPtr_CastleHeartDamageModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (CastleHeartDamageModeKey));
      EOSPlatformSystem.NativeFieldInfoPtr_GameSettingsHashKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (GameSettingsHashKey));
      EOSPlatformSystem.NativeFieldInfoPtr_SettingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (SettingsKey));
      EOSPlatformSystem.NativeFieldInfoPtr_ClanSizeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (ClanSizeKey));
      EOSPlatformSystem.NativeFieldInfoPtr_IsHardcoreKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (IsHardcoreKey));
      EOSPlatformSystem.NativeFieldInfoPtr_GameModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (GameModeKey));
      EOSPlatformSystem.NativeFieldInfoPtr_SessionCreationTimeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (SessionCreationTimeKey));
      EOSPlatformSystem.NativeFieldInfoPtr_AppIdKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, nameof (AppIdKey));
      EOSPlatformSystem.NativeMethodInfoPtr_get_IsClient_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690148);
      EOSPlatformSystem.NativeMethodInfoPtr_get_IsServer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690149);
      EOSPlatformSystem.NativeMethodInfoPtr_get_LoggedInUserID_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690150);
      EOSPlatformSystem.NativeMethodInfoPtr_set_LoggedInUserID_Private_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690151);
      EOSPlatformSystem.NativeMethodInfoPtr_get_IsLoggedIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690152);
      EOSPlatformSystem.NativeMethodInfoPtr_get_IsLoggingIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690153);
      EOSPlatformSystem.NativeMethodInfoPtr_set_IsLoggingIn_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690154);
      EOSPlatformSystem.NativeMethodInfoPtr_get_CanAccessAPI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690155);
      EOSPlatformSystem.NativeMethodInfoPtr_set_CanAccessAPI_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690156);
      EOSPlatformSystem.NativeMethodInfoPtr_get_MyPublicIP_Public_get_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690157);
      EOSPlatformSystem.NativeMethodInfoPtr_get_MyPublicIPUInt_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690158);
      EOSPlatformSystem.NativeMethodInfoPtr_GetSystem_Public_Static_EOSPlatformSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690159);
      EOSPlatformSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690160);
      EOSPlatformSystem.NativeMethodInfoPtr_OnAuthExpirationNotification_Private_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690161);
      EOSPlatformSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690162);
      EOSPlatformSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690163);
      EOSPlatformSystem.NativeMethodInfoPtr_TickLoginReattemptLogic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690164);
      EOSPlatformSystem.NativeMethodInfoPtr_GetExponentialBackoffReattemptDelay_Private_Single_UInt32_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690165);
      EOSPlatformSystem.NativeMethodInfoPtr_LogInWithSteam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690166);
      EOSPlatformSystem.NativeMethodInfoPtr_TryGetInitResult_Public_Boolean_byref_PlatformInitState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690167);
      EOSPlatformSystem.NativeMethodInfoPtr_CreateSessionDataFromMatchmakingServerData_Private_Void_byref_MatchmakingServerData_String_Boolean_byref_SessionData_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690168);
      EOSPlatformSystem.NativeMethodInfoPtr_IPFromString_Private_Boolean_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690169);
      EOSPlatformSystem.NativeMethodInfoPtr_PortFromString_Private_Boolean_String_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690170);
      EOSPlatformSystem.NativeMethodInfoPtr_IPPortFromString_Private_Boolean_String_byref_UInt32_byref_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690171);
      EOSPlatformSystem.NativeMethodInfoPtr_TryConvertSessionToListEntryData_Public_Boolean_Session_byref_ServerListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690172);
      EOSPlatformSystem.NativeMethodInfoPtr_CreateSession_Public_Session_MatchmakingServerData_IPAddress_UInt16_UInt16_Boolean_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690173);
      EOSPlatformSystem.NativeMethodInfoPtr_CreateSession_Public_Session_MatchmakingServerData_IPAddress_UInt16_UInt16_UInt64_Boolean_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690174);
      EOSPlatformSystem.NativeMethodInfoPtr_CreateSessionInternal_Private_Session_MatchmakingServerData_String_Boolean_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690175);
      EOSPlatformSystem.NativeMethodInfoPtr_ModifySession_Public_Void_byref_Session_MatchmakingServerData_Boolean_UInt32_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690176);
      EOSPlatformSystem.NativeMethodInfoPtr_GetServerSettingsSerialized_Private_String_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690177);
      EOSPlatformSystem.NativeMethodInfoPtr_SearchSessionsDebug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690178);
      EOSPlatformSystem.NativeMethodInfoPtr_GetServers_Public_SessionSearch_Il2CppReferenceArray_1_SearchCriteron_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690179);
      EOSPlatformSystem.NativeMethodInfoPtr_GetAllServers_Public_SessionSearchPaginated_Il2CppReferenceArray_1_SearchCriteron_EOSSessionSearchPaginatedResultsUpdatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690180);
      EOSPlatformSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690181);
      EOSPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_Il2CppStructArray_1_Byte_PlatformError_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690182);
      EOSPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_Boolean_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690183);
      EOSPlatformSystem.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690184);
      EOSPlatformSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, 100690185);
    }

    public EOSPlatformSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _ProductName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__ProductName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__ProductName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _ProductVersion
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__ProductVersion)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__ProductVersion), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe SteamPlatformSystem _SteamPlatformSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__SteamPlatformSystem));
        return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__SteamPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlatformInterface _PlatformInterface
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__PlatformInterface));
        return pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__PlatformInterface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<byte> _ServerSettingsSerializationNetBufferData
    {
      get
      {
        return *(NativeList<byte>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__ServerSettingsSerializationNetBufferData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__ServerSettingsSerializationNetBufferData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PlatformInitState _InitState
    {
      get
      {
        return *(PlatformInitState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__InitState));
      }
      [param: In] set
      {
        *(PlatformInitState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__InitState)) = value;
      }
    }

    public unsafe bool _InitDone
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__InitDone));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__InitDone)) = value;
      }
    }

    public unsafe List<Session> activeSessions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr_activeSessions));
        return pointer == System.IntPtr.Zero ? (List<Session>) null : new List<Session>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr_activeSessions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe string LogHeader
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_LogHeader, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_LogHeader, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ProductUserId _LoggedInUserID_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__LoggedInUserID_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__LoggedInUserID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _NeedsLogin
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__NeedsLogin));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__NeedsLogin)) = value;
      }
    }

    public unsafe bool _IsLoggingIn_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__IsLoggingIn_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__IsLoggingIn_k__BackingField)) = value;
      }
    }

    public unsafe uint _FailedLoginAttempts
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__FailedLoginAttempts));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__FailedLoginAttempts)) = value;
      }
    }

    public unsafe Il2CppSystem.DateTime _NextLoginAttemptTime
    {
      get
      {
        return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__NextLoginAttemptTime));
      }
      [param: In] set
      {
        *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__NextLoginAttemptTime)) = value;
      }
    }

    public unsafe bool _CanAccessAPI_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__CanAccessAPI_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__CanAccessAPI_k__BackingField)) = value;
      }
    }

    public unsafe IPAddress _MyPublicIP
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__MyPublicIP));
        return pointer == System.IntPtr.Zero ? (IPAddress) null : new IPAddress(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr__MyPublicIP), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<ulong> authExpirationCallbackHandle
    {
      get
      {
        return *(Nullable_Unboxed<ulong>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr_authExpirationCallbackHandle));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.NativeFieldInfoPtr_authExpirationCallbackHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe string ServerNameKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_ServerNameKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_ServerNameKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string IsAvailableKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_IsAvailableKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_IsAvailableKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ServerNameLowerInvariantKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_ServerNameLowerInvariantKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_ServerNameLowerInvariantKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ServerNameSortingValueKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_ServerNameSortingValueKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_ServerNameSortingValueKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PlayerCountKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_PlayerCountKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_PlayerCountKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string OpenPlayerSlotsKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_OpenPlayerSlotsKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_OpenPlayerSlotsKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string HasPasswordKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_HasPasswordKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_HasPasswordKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string IsDedicatedKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_IsDedicatedKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_IsDedicatedKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string TagsKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_TagsKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_TagsKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string HasScheduledWipesKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_HasScheduledWipesKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_HasScheduledWipesKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string UsesStandardSettingsKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_UsesStandardSettingsKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_UsesStandardSettingsKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DaysRunningKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_DaysRunningKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_DaysRunningKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DaysUntilResetKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_DaysUntilResetKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_DaysUntilResetKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string SessionGuidKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_SessionGuidKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_SessionGuidKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string VersionKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_VersionKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_VersionKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string Branchkey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_Branchkey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_Branchkey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DescriptionKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_DescriptionKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_DescriptionKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string BloodBoundEnabledKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_BloodBoundEnabledKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_BloodBoundEnabledKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string CastleHeartDamageModeKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_CastleHeartDamageModeKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_CastleHeartDamageModeKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameSettingsHashKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_GameSettingsHashKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_GameSettingsHashKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string SettingsKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_SettingsKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_SettingsKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string ClanSizeKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_ClanSizeKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_ClanSizeKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string IsHardcoreKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_IsHardcoreKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_IsHardcoreKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string GameModeKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_GameModeKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_GameModeKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string SessionCreationTimeKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_SessionCreationTimeKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_SessionCreationTimeKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string AppIdKey
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(EOSPlatformSystem.NativeFieldInfoPtr_AppIdKey, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EOSPlatformSystem.NativeFieldInfoPtr_AppIdKey, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public enum AddressType
    {
      SteamUser,
      IPv4AndPort,
    }

    [ObfuscatedName("ProjectM.Auth.EOSPlatformSystem/<>c__DisplayClass40_0")]
    public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyedSessions;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnDestroy_b__0_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass40_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass40_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _OnDestroy_b__0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__OnDestroy_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass40_0()
      {
        Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, "<>c__DisplayClass40_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass40_0>.NativeClassPtr);
        EOSPlatformSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_destroyedSessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass40_0>.NativeClassPtr, nameof (destroyedSessions));
        EOSPlatformSystem.__c__DisplayClass40_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass40_0>.NativeClassPtr, "<>9__0");
        EOSPlatformSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass40_0>.NativeClassPtr, 100690186);
        EOSPlatformSystem.__c__DisplayClass40_0.NativeMethodInfoPtr__OnDestroy_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass40_0>.NativeClassPtr, 100690187);
      }

      public __c__DisplayClass40_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int destroyedSessions
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_destroyedSessions));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass40_0.NativeFieldInfoPtr_destroyedSessions)) = value;
        }
      }

      public unsafe EOSOperationCompleteHandler __9__0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass40_0.NativeFieldInfoPtr___9__0));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass40_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Auth.EOSPlatformSystem/<>c__DisplayClass79_0")]
    public sealed class __c__DisplayClass79_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_createdSession;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CreateSessionInternal_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass79_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass79_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139274, XrefRangeEnd = 1139277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CreateSessionInternal_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.__c__DisplayClass79_0.NativeMethodInfoPtr__CreateSessionInternal_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass79_0()
      {
        Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, "<>c__DisplayClass79_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass79_0>.NativeClassPtr);
        EOSPlatformSystem.__c__DisplayClass79_0.NativeFieldInfoPtr_createdSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass79_0>.NativeClassPtr, nameof (createdSession));
        EOSPlatformSystem.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
        EOSPlatformSystem.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass79_0>.NativeClassPtr, 100690188);
        EOSPlatformSystem.__c__DisplayClass79_0.NativeMethodInfoPtr__CreateSessionInternal_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass79_0>.NativeClassPtr, 100690189);
      }

      public __c__DisplayClass79_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session createdSession
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass79_0.NativeFieldInfoPtr_createdSession));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass79_0.NativeFieldInfoPtr_createdSession), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSPlatformSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (EOSPlatformSystem) null : new EOSPlatformSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Auth.EOSPlatformSystem/<>c__DisplayClass82_0")]
    public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_searchHandle;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SearchSessionsDebug_b__0_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass82_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass82_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139277, XrefRangeEnd = 1139302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SearchSessionsDebug_b__0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EOSPlatformSystem.__c__DisplayClass82_0.NativeMethodInfoPtr__SearchSessionsDebug_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass82_0()
      {
        Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EOSPlatformSystem>.NativeClassPtr, "<>c__DisplayClass82_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass82_0>.NativeClassPtr);
        EOSPlatformSystem.__c__DisplayClass82_0.NativeFieldInfoPtr_searchHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass82_0>.NativeClassPtr, nameof (searchHandle));
        EOSPlatformSystem.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass82_0>.NativeClassPtr, 100690190);
        EOSPlatformSystem.__c__DisplayClass82_0.NativeMethodInfoPtr__SearchSessionsDebug_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSPlatformSystem.__c__DisplayClass82_0>.NativeClassPtr, 100690191);
      }

      public __c__DisplayClass82_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SessionSearch searchHandle
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass82_0.NativeFieldInfoPtr_searchHandle));
          return pointer == System.IntPtr.Zero ? (SessionSearch) null : new SessionSearch(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EOSPlatformSystem.__c__DisplayClass82_0.NativeFieldInfoPtr_searchHandle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
