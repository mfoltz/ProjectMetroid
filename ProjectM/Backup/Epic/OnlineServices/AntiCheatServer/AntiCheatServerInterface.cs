// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.AntiCheatServerInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.AntiCheatCommon;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer
{
  public sealed class AntiCheatServerInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyclientactionrequiredApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyclientauthstatuschangedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifymessagetoclientApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeginsessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeginsessionMaxRegistertimeout;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeginsessionMinRegistertimeout;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndsessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProtectmessageApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReceivemessagefromclientApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterclientApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetclientnetworkstateApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnprotectmessageApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnregisterclientApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyClientActionRequired_Public_UInt64_byref_AddNotifyClientActionRequiredOptions_Object_OnClientActionRequiredCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyClientAuthStatusChanged_Public_UInt64_byref_AddNotifyClientAuthStatusChangedOptions_Object_OnClientAuthStatusChangedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyMessageToClient_Public_UInt64_byref_AddNotifyMessageToClientOptions_Object_OnMessageToClientCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginSession_Public_Result_byref_BeginSessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndSession_Public_Result_byref_EndSessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_byref_GetProtectMessageOutputLengthOptions_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogEvent_Public_Result_byref_LogEventOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogGameRoundEnd_Public_Result_byref_LogGameRoundEndOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogGameRoundStart_Public_Result_byref_LogGameRoundStartOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerDespawn_Public_Result_byref_LogPlayerDespawnOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerRevive_Public_Result_byref_LogPlayerReviveOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerSpawn_Public_Result_byref_LogPlayerSpawnOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerTakeDamage_Public_Result_byref_LogPlayerTakeDamageOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerTick_Public_Result_byref_LogPlayerTickOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerUseAbility_Public_Result_byref_LogPlayerUseAbilityOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogPlayerUseWeapon_Public_Result_byref_LogPlayerUseWeaponOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProtectMessage_Public_Result_byref_ProtectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessageFromClient_Public_Result_byref_ReceiveMessageFromClientOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterClient_Public_Result_byref_RegisterClientOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterEvent_Public_Result_byref_RegisterEventOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyClientActionRequired_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyClientAuthStatusChanged_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyMessageToClient_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetClientDetails_Public_Result_byref_SetClientDetailsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetClientNetworkState_Public_Result_byref_SetClientNetworkStateOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetGameSessionId_Public_Result_byref_SetGameSessionIdOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnprotectMessage_Public_Result_byref_UnprotectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterClient_Public_Result_byref_UnregisterClientOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnClientActionRequiredCallbackInternalImplementation_Internal_Static_Void_byref_OnClientActionRequiredCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnClientAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientAuthStatusChangedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMessageToClientCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToClientCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AntiCheatServerInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968892, XrefRangeEnd = 968912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyClientActionRequired(
      ref AddNotifyClientActionRequiredOptions options,
      Il2CppSystem.Object clientData,
      OnClientActionRequiredCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyClientActionRequired_Public_UInt64_byref_AddNotifyClientActionRequiredOptions_Object_OnClientActionRequiredCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968912, XrefRangeEnd = 968932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyClientAuthStatusChanged(
      ref AddNotifyClientAuthStatusChangedOptions options,
      Il2CppSystem.Object clientData,
      OnClientAuthStatusChangedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyClientAuthStatusChanged_Public_UInt64_byref_AddNotifyClientAuthStatusChangedOptions_Object_OnClientAuthStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968932, XrefRangeEnd = 968952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyMessageToClient(
      ref AddNotifyMessageToClientOptions options,
      Il2CppSystem.Object clientData,
      OnMessageToClientCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyMessageToClient_Public_UInt64_byref_AddNotifyMessageToClientOptions_Object_OnMessageToClientCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968952, XrefRangeEnd = 968960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result BeginSession(ref BeginSessionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_BeginSession_Public_Result_byref_BeginSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968960, XrefRangeEnd = 968968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result EndSession(ref EndSessionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_EndSession_Public_Result_byref_EndSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968968, XrefRangeEnd = 968979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetProtectMessageOutputLength(
      ref GetProtectMessageOutputLengthOptions options,
      out uint outBufferSizeBytes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outBufferSizeBytes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_byref_GetProtectMessageOutputLengthOptions_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968979, XrefRangeEnd = 968987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogEvent(ref LogEventOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogEvent_Public_Result_byref_LogEventOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968987, XrefRangeEnd = 968995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogGameRoundEnd(ref LogGameRoundEndOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogGameRoundEnd_Public_Result_byref_LogGameRoundEndOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968995, XrefRangeEnd = 969003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogGameRoundStart(ref LogGameRoundStartOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogGameRoundStart_Public_Result_byref_LogGameRoundStartOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969003, XrefRangeEnd = 969011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogPlayerDespawn(ref LogPlayerDespawnOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerDespawn_Public_Result_byref_LogPlayerDespawnOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969011, XrefRangeEnd = 969019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogPlayerRevive(ref LogPlayerReviveOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerRevive_Public_Result_byref_LogPlayerReviveOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969019, XrefRangeEnd = 969027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogPlayerSpawn(ref LogPlayerSpawnOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerSpawn_Public_Result_byref_LogPlayerSpawnOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969027, XrefRangeEnd = 969035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogPlayerTakeDamage(ref LogPlayerTakeDamageOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerTakeDamage_Public_Result_byref_LogPlayerTakeDamageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969035, XrefRangeEnd = 969043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogPlayerTick(ref LogPlayerTickOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerTick_Public_Result_byref_LogPlayerTickOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969043, XrefRangeEnd = 969051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogPlayerUseAbility(ref LogPlayerUseAbilityOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerUseAbility_Public_Result_byref_LogPlayerUseAbilityOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969051, XrefRangeEnd = 969059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result LogPlayerUseWeapon(ref LogPlayerUseWeaponOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerUseWeapon_Public_Result_byref_LogPlayerUseWeaponOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969059, XrefRangeEnd = 969069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result ProtectMessage(
      ref ProtectMessageOptions options,
      Il2CppSystem.ArraySegment<byte> outBuffer,
      out uint outBytesWritten)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) outBuffer));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref outBytesWritten;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_ProtectMessage_Public_Result_byref_ProtectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969069, XrefRangeEnd = 969077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result ReceiveMessageFromClient(ref ReceiveMessageFromClientOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_ReceiveMessageFromClient_Public_Result_byref_ReceiveMessageFromClientOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969077, XrefRangeEnd = 969085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RegisterClient(ref RegisterClientOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RegisterClient_Public_Result_byref_RegisterClientOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969085, XrefRangeEnd = 969093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RegisterEvent(ref RegisterEventOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RegisterEvent_Public_Result_byref_RegisterEventOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969093, XrefRangeEnd = 969098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyClientActionRequired(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyClientActionRequired_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969098, XrefRangeEnd = 969103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyClientAuthStatusChanged(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyClientAuthStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969103, XrefRangeEnd = 969108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyMessageToClient(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyMessageToClient_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969108, XrefRangeEnd = 969116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetClientDetails(ref SetClientDetailsOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_SetClientDetails_Public_Result_byref_SetClientDetailsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969116, XrefRangeEnd = 969124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetClientNetworkState(ref SetClientNetworkStateOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_SetClientNetworkState_Public_Result_byref_SetClientNetworkStateOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969124, XrefRangeEnd = 969132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetGameSessionId(ref SetGameSessionIdOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_SetGameSessionId_Public_Result_byref_SetGameSessionIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969132, XrefRangeEnd = 969142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result UnprotectMessage(
      ref UnprotectMessageOptions options,
      Il2CppSystem.ArraySegment<byte> outBuffer,
      out uint outBytesWritten)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) outBuffer));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref outBytesWritten;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_UnprotectMessage_Public_Result_byref_UnprotectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969142, XrefRangeEnd = 969150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result UnregisterClient(ref UnregisterClientOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_UnregisterClient_Public_Result_byref_UnregisterClientOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969150, XrefRangeEnd = 969157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnClientActionRequiredCallbackInternalImplementation(
      ref OnClientActionRequiredCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_OnClientActionRequiredCallbackInternalImplementation_Internal_Static_Void_byref_OnClientActionRequiredCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969157, XrefRangeEnd = 969164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnClientAuthStatusChangedCallbackInternalImplementation(
      ref OnClientAuthStatusChangedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_OnClientAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientAuthStatusChangedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969164, XrefRangeEnd = 969171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnMessageToClientCallbackInternalImplementation(
      ref OnMessageToClientCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatServerInterface.NativeMethodInfoPtr_OnMessageToClientCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToClientCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AntiCheatServerInterface()
    {
      Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatServer", nameof (AntiCheatServerInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr);
      AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientactionrequiredApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (AddnotifyclientactionrequiredApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientauthstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (AddnotifyclientauthstatuschangedApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifymessagetoclientApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (AddnotifymessagetoclientApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (BeginsessionApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMaxRegistertimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (BeginsessionMaxRegistertimeout));
      AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMinRegistertimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (BeginsessionMinRegistertimeout));
      AntiCheatServerInterface.NativeFieldInfoPtr_EndsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (EndsessionApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (GetprotectmessageoutputlengthApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_ProtectmessageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (ProtectmessageApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_ReceivemessagefromclientApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (ReceivemessagefromclientApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_RegisterclientApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (RegisterclientApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_SetclientnetworkstateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (SetclientnetworkstateApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (UnprotectmessageApiLatest));
      AntiCheatServerInterface.NativeFieldInfoPtr_UnregisterclientApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, nameof (UnregisterclientApiLatest));
      AntiCheatServerInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673775);
      AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyClientActionRequired_Public_UInt64_byref_AddNotifyClientActionRequiredOptions_Object_OnClientActionRequiredCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673777);
      AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyClientAuthStatusChanged_Public_UInt64_byref_AddNotifyClientAuthStatusChangedOptions_Object_OnClientAuthStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673778);
      AntiCheatServerInterface.NativeMethodInfoPtr_AddNotifyMessageToClient_Public_UInt64_byref_AddNotifyMessageToClientOptions_Object_OnMessageToClientCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673779);
      AntiCheatServerInterface.NativeMethodInfoPtr_BeginSession_Public_Result_byref_BeginSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673780);
      AntiCheatServerInterface.NativeMethodInfoPtr_EndSession_Public_Result_byref_EndSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673781);
      AntiCheatServerInterface.NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_byref_GetProtectMessageOutputLengthOptions_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673782);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogEvent_Public_Result_byref_LogEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673783);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogGameRoundEnd_Public_Result_byref_LogGameRoundEndOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673784);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogGameRoundStart_Public_Result_byref_LogGameRoundStartOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673785);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerDespawn_Public_Result_byref_LogPlayerDespawnOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673786);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerRevive_Public_Result_byref_LogPlayerReviveOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673787);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerSpawn_Public_Result_byref_LogPlayerSpawnOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673788);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerTakeDamage_Public_Result_byref_LogPlayerTakeDamageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673789);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerTick_Public_Result_byref_LogPlayerTickOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673790);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerUseAbility_Public_Result_byref_LogPlayerUseAbilityOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673791);
      AntiCheatServerInterface.NativeMethodInfoPtr_LogPlayerUseWeapon_Public_Result_byref_LogPlayerUseWeaponOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673792);
      AntiCheatServerInterface.NativeMethodInfoPtr_ProtectMessage_Public_Result_byref_ProtectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673793);
      AntiCheatServerInterface.NativeMethodInfoPtr_ReceiveMessageFromClient_Public_Result_byref_ReceiveMessageFromClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673794);
      AntiCheatServerInterface.NativeMethodInfoPtr_RegisterClient_Public_Result_byref_RegisterClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673795);
      AntiCheatServerInterface.NativeMethodInfoPtr_RegisterEvent_Public_Result_byref_RegisterEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673796);
      AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyClientActionRequired_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673797);
      AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyClientAuthStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673798);
      AntiCheatServerInterface.NativeMethodInfoPtr_RemoveNotifyMessageToClient_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673799);
      AntiCheatServerInterface.NativeMethodInfoPtr_SetClientDetails_Public_Result_byref_SetClientDetailsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673800);
      AntiCheatServerInterface.NativeMethodInfoPtr_SetClientNetworkState_Public_Result_byref_SetClientNetworkStateOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673801);
      AntiCheatServerInterface.NativeMethodInfoPtr_SetGameSessionId_Public_Result_byref_SetGameSessionIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673802);
      AntiCheatServerInterface.NativeMethodInfoPtr_UnprotectMessage_Public_Result_byref_UnprotectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673803);
      AntiCheatServerInterface.NativeMethodInfoPtr_UnregisterClient_Public_Result_byref_UnregisterClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673804);
      AntiCheatServerInterface.NativeMethodInfoPtr_OnClientActionRequiredCallbackInternalImplementation_Internal_Static_Void_byref_OnClientActionRequiredCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673805);
      AntiCheatServerInterface.NativeMethodInfoPtr_OnClientAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientAuthStatusChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673806);
      AntiCheatServerInterface.NativeMethodInfoPtr_OnMessageToClientCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToClientCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatServerInterface>.NativeClassPtr, 100673807);
    }

    public AntiCheatServerInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifyclientactionrequiredApiLatest
    {
      get
      {
        int addnotifyclientactionrequiredApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientactionrequiredApiLatest, (void*) &addnotifyclientactionrequiredApiLatest);
        return addnotifyclientactionrequiredApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientactionrequiredApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyclientauthstatuschangedApiLatest
    {
      get
      {
        int addnotifyclientauthstatuschangedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientauthstatuschangedApiLatest, (void*) &addnotifyclientauthstatuschangedApiLatest);
        return addnotifyclientauthstatuschangedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifyclientauthstatuschangedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifymessagetoclientApiLatest
    {
      get
      {
        int addnotifymessagetoclientApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifymessagetoclientApiLatest, (void*) &addnotifymessagetoclientApiLatest);
        return addnotifymessagetoclientApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_AddnotifymessagetoclientApiLatest, (void*) &value);
      }
    }

    public static unsafe int BeginsessionApiLatest
    {
      get
      {
        int beginsessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionApiLatest, (void*) &beginsessionApiLatest);
        return beginsessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int BeginsessionMaxRegistertimeout
    {
      get
      {
        int maxRegistertimeout;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMaxRegistertimeout, (void*) &maxRegistertimeout);
        return maxRegistertimeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMaxRegistertimeout, (void*) &value);
      }
    }

    public static unsafe int BeginsessionMinRegistertimeout
    {
      get
      {
        int minRegistertimeout;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMinRegistertimeout, (void*) &minRegistertimeout);
        return minRegistertimeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_BeginsessionMinRegistertimeout, (void*) &value);
      }
    }

    public static unsafe int EndsessionApiLatest
    {
      get
      {
        int endsessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &endsessionApiLatest);
        return endsessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetprotectmessageoutputlengthApiLatest
    {
      get
      {
        int getprotectmessageoutputlengthApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest, (void*) &getprotectmessageoutputlengthApiLatest);
        return getprotectmessageoutputlengthApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest, (void*) &value);
      }
    }

    public static unsafe int ProtectmessageApiLatest
    {
      get
      {
        int protectmessageApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_ProtectmessageApiLatest, (void*) &protectmessageApiLatest);
        return protectmessageApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_ProtectmessageApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReceivemessagefromclientApiLatest
    {
      get
      {
        int receivemessagefromclientApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_ReceivemessagefromclientApiLatest, (void*) &receivemessagefromclientApiLatest);
        return receivemessagefromclientApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_ReceivemessagefromclientApiLatest, (void*) &value);
      }
    }

    public static unsafe int RegisterclientApiLatest
    {
      get
      {
        int registerclientApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_RegisterclientApiLatest, (void*) &registerclientApiLatest);
        return registerclientApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_RegisterclientApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetclientnetworkstateApiLatest
    {
      get
      {
        int setclientnetworkstateApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_SetclientnetworkstateApiLatest, (void*) &setclientnetworkstateApiLatest);
        return setclientnetworkstateApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_SetclientnetworkstateApiLatest, (void*) &value);
      }
    }

    public static unsafe int UnprotectmessageApiLatest
    {
      get
      {
        int unprotectmessageApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest, (void*) &unprotectmessageApiLatest);
        return unprotectmessageApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest, (void*) &value);
      }
    }

    public static unsafe int UnregisterclientApiLatest
    {
      get
      {
        int unregisterclientApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatServerInterface.NativeFieldInfoPtr_UnregisterclientApiLatest, (void*) &unregisterclientApiLatest);
        return unregisterclientApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatServerInterface.NativeFieldInfoPtr_UnregisterclientApiLatest, (void*) &value);
      }
    }
  }
}
