// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.AntiCheatClientInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.AntiCheatCommon;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient
{
  public sealed class AntiCheatClientInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddexternalintegritycatalogApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyclientintegrityviolatedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifymessagetopeerApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifymessagetoserverApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeeractionrequiredApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerauthstatuschangedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeginsessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndsessionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_PeerSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_PollstatusApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProtectmessageApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReceivemessagefrompeerApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReceivemessagefromserverApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterpeerApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterpeerMaxAuthenticationtimeout;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterpeerMinAuthenticationtimeout;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnprotectmessageApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnregisterpeerApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddExternalIntegrityCatalog_Public_Result_byref_AddExternalIntegrityCatalogOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyClientIntegrityViolated_Public_UInt64_byref_AddNotifyClientIntegrityViolatedOptions_Object_OnClientIntegrityViolatedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyMessageToPeer_Public_UInt64_byref_AddNotifyMessageToPeerOptions_Object_OnMessageToPeerCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyMessageToServer_Public_UInt64_byref_AddNotifyMessageToServerOptions_Object_OnMessageToServerCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerActionRequired_Public_UInt64_byref_AddNotifyPeerActionRequiredOptions_Object_OnPeerActionRequiredCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerAuthStatusChanged_Public_UInt64_byref_AddNotifyPeerAuthStatusChangedOptions_Object_OnPeerAuthStatusChangedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginSession_Public_Result_byref_BeginSessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndSession_Public_Result_byref_EndSessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_byref_GetProtectMessageOutputLengthOptions_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PollStatus_Public_Result_byref_PollStatusOptions_byref_AntiCheatClientViolationType_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProtectMessage_Public_Result_byref_ProtectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessageFromPeer_Public_Result_byref_ReceiveMessageFromPeerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessageFromServer_Public_Result_byref_ReceiveMessageFromServerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPeer_Public_Result_byref_RegisterPeerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyClientIntegrityViolated_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyMessageToPeer_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyMessageToServer_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerActionRequired_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerAuthStatusChanged_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnprotectMessage_Public_Result_byref_UnprotectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterPeer_Public_Result_byref_UnregisterPeerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnClientIntegrityViolatedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientIntegrityViolatedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMessageToPeerCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToClientCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMessageToServerCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToServerCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPeerActionRequiredCallbackInternalImplementation_Internal_Static_Void_byref_OnClientActionRequiredCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPeerAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientAuthStatusChangedCallbackInfoInternal_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970818, XrefRangeEnd = 970820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AntiCheatClientInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970820, XrefRangeEnd = 970828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result AddExternalIntegrityCatalog(ref AddExternalIntegrityCatalogOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddExternalIntegrityCatalog_Public_Result_byref_AddExternalIntegrityCatalogOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970828, XrefRangeEnd = 970848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyClientIntegrityViolated(
      ref AddNotifyClientIntegrityViolatedOptions options,
      Il2CppSystem.Object clientData,
      OnClientIntegrityViolatedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyClientIntegrityViolated_Public_UInt64_byref_AddNotifyClientIntegrityViolatedOptions_Object_OnClientIntegrityViolatedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970848, XrefRangeEnd = 970868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyMessageToPeer(
      ref AddNotifyMessageToPeerOptions options,
      Il2CppSystem.Object clientData,
      OnMessageToPeerCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyMessageToPeer_Public_UInt64_byref_AddNotifyMessageToPeerOptions_Object_OnMessageToPeerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970868, XrefRangeEnd = 970888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyMessageToServer(
      ref AddNotifyMessageToServerOptions options,
      Il2CppSystem.Object clientData,
      OnMessageToServerCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyMessageToServer_Public_UInt64_byref_AddNotifyMessageToServerOptions_Object_OnMessageToServerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970888, XrefRangeEnd = 970908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyPeerActionRequired(
      ref AddNotifyPeerActionRequiredOptions options,
      Il2CppSystem.Object clientData,
      OnPeerActionRequiredCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyPeerActionRequired_Public_UInt64_byref_AddNotifyPeerActionRequiredOptions_Object_OnPeerActionRequiredCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970908, XrefRangeEnd = 970928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyPeerAuthStatusChanged(
      ref AddNotifyPeerAuthStatusChangedOptions options,
      Il2CppSystem.Object clientData,
      OnPeerAuthStatusChangedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyPeerAuthStatusChanged_Public_UInt64_byref_AddNotifyPeerAuthStatusChangedOptions_Object_OnPeerAuthStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970928, XrefRangeEnd = 970936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result BeginSession(ref BeginSessionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_BeginSession_Public_Result_byref_BeginSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970936, XrefRangeEnd = 970944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result EndSession(ref EndSessionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_EndSession_Public_Result_byref_EndSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970944, XrefRangeEnd = 970955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetProtectMessageOutputLength(
      ref GetProtectMessageOutputLengthOptions options,
      out uint outBufferSizeBytes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outBufferSizeBytes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_byref_GetProtectMessageOutputLengthOptions_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970955, XrefRangeEnd = 970969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result PollStatus(
      ref PollStatusOptions options,
      out AntiCheatClientViolationType outViolationType,
      out Epic.OnlineServices.Utf8String outMessage)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outViolationType;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_PollStatus_Public_Result_byref_PollStatusOptions_byref_AntiCheatClientViolationType_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outMessage;
      System.IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970969, XrefRangeEnd = 970979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_ProtectMessage_Public_Result_byref_ProtectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970979, XrefRangeEnd = 970987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result ReceiveMessageFromPeer(ref ReceiveMessageFromPeerOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_ReceiveMessageFromPeer_Public_Result_byref_ReceiveMessageFromPeerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970987, XrefRangeEnd = 970995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result ReceiveMessageFromServer(ref ReceiveMessageFromServerOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_ReceiveMessageFromServer_Public_Result_byref_ReceiveMessageFromServerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970995, XrefRangeEnd = 971003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RegisterPeer(ref RegisterPeerOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RegisterPeer_Public_Result_byref_RegisterPeerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971003, XrefRangeEnd = 971008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyClientIntegrityViolated(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyClientIntegrityViolated_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971008, XrefRangeEnd = 971013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyMessageToPeer(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyMessageToPeer_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971013, XrefRangeEnd = 971018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyMessageToServer(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyMessageToServer_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971018, XrefRangeEnd = 971023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyPeerActionRequired(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyPeerActionRequired_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971023, XrefRangeEnd = 971028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyPeerAuthStatusChanged(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyPeerAuthStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971028, XrefRangeEnd = 971038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_UnprotectMessage_Public_Result_byref_UnprotectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971038, XrefRangeEnd = 971046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result UnregisterPeer(ref UnregisterPeerOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_UnregisterPeer_Public_Result_byref_UnregisterPeerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971046, XrefRangeEnd = 971053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnClientIntegrityViolatedCallbackInternalImplementation(
      ref OnClientIntegrityViolatedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnClientIntegrityViolatedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientIntegrityViolatedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971053, XrefRangeEnd = 971060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnMessageToPeerCallbackInternalImplementation(
      ref OnMessageToClientCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnMessageToPeerCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToClientCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971060, XrefRangeEnd = 971067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnMessageToServerCallbackInternalImplementation(
      ref OnMessageToServerCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnMessageToServerCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToServerCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971067, XrefRangeEnd = 971074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnPeerActionRequiredCallbackInternalImplementation(
      ref OnClientActionRequiredCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnPeerActionRequiredCallbackInternalImplementation_Internal_Static_Void_byref_OnClientActionRequiredCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971074, XrefRangeEnd = 971081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnPeerAuthStatusChangedCallbackInternalImplementation(
      ref OnClientAuthStatusChangedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatClientInterface.NativeMethodInfoPtr_OnPeerAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientAuthStatusChangedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AntiCheatClientInterface()
    {
      Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatClient", nameof (AntiCheatClientInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr);
      AntiCheatClientInterface.NativeFieldInfoPtr_AddexternalintegritycatalogApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddexternalintegritycatalogApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifyclientintegrityviolatedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifyclientintegrityviolatedApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetopeerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifymessagetopeerApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetoserverApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifymessagetoserverApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeeractionrequiredApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifypeeractionrequiredApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeerauthstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (AddnotifypeerauthstatuschangedApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_BeginsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (BeginsessionApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_EndsessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (EndsessionApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (GetprotectmessageoutputlengthApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_PeerSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (PeerSelf));
      AntiCheatClientInterface.NativeFieldInfoPtr_PollstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (PollstatusApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_ProtectmessageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (ProtectmessageApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefrompeerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (ReceivemessagefrompeerApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefromserverApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (ReceivemessagefromserverApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (RegisterpeerApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerMaxAuthenticationtimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (RegisterpeerMaxAuthenticationtimeout));
      AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerMinAuthenticationtimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (RegisterpeerMinAuthenticationtimeout));
      AntiCheatClientInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (UnprotectmessageApiLatest));
      AntiCheatClientInterface.NativeFieldInfoPtr_UnregisterpeerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, nameof (UnregisterpeerApiLatest));
      AntiCheatClientInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674341);
      AntiCheatClientInterface.NativeMethodInfoPtr_AddExternalIntegrityCatalog_Public_Result_byref_AddExternalIntegrityCatalogOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674343);
      AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyClientIntegrityViolated_Public_UInt64_byref_AddNotifyClientIntegrityViolatedOptions_Object_OnClientIntegrityViolatedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674344);
      AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyMessageToPeer_Public_UInt64_byref_AddNotifyMessageToPeerOptions_Object_OnMessageToPeerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674345);
      AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyMessageToServer_Public_UInt64_byref_AddNotifyMessageToServerOptions_Object_OnMessageToServerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674346);
      AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyPeerActionRequired_Public_UInt64_byref_AddNotifyPeerActionRequiredOptions_Object_OnPeerActionRequiredCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674347);
      AntiCheatClientInterface.NativeMethodInfoPtr_AddNotifyPeerAuthStatusChanged_Public_UInt64_byref_AddNotifyPeerAuthStatusChangedOptions_Object_OnPeerAuthStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674348);
      AntiCheatClientInterface.NativeMethodInfoPtr_BeginSession_Public_Result_byref_BeginSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674349);
      AntiCheatClientInterface.NativeMethodInfoPtr_EndSession_Public_Result_byref_EndSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674350);
      AntiCheatClientInterface.NativeMethodInfoPtr_GetProtectMessageOutputLength_Public_Result_byref_GetProtectMessageOutputLengthOptions_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674351);
      AntiCheatClientInterface.NativeMethodInfoPtr_PollStatus_Public_Result_byref_PollStatusOptions_byref_AntiCheatClientViolationType_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674352);
      AntiCheatClientInterface.NativeMethodInfoPtr_ProtectMessage_Public_Result_byref_ProtectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674353);
      AntiCheatClientInterface.NativeMethodInfoPtr_ReceiveMessageFromPeer_Public_Result_byref_ReceiveMessageFromPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674354);
      AntiCheatClientInterface.NativeMethodInfoPtr_ReceiveMessageFromServer_Public_Result_byref_ReceiveMessageFromServerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674355);
      AntiCheatClientInterface.NativeMethodInfoPtr_RegisterPeer_Public_Result_byref_RegisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674356);
      AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyClientIntegrityViolated_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674357);
      AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyMessageToPeer_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674358);
      AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyMessageToServer_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674359);
      AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyPeerActionRequired_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674360);
      AntiCheatClientInterface.NativeMethodInfoPtr_RemoveNotifyPeerAuthStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674361);
      AntiCheatClientInterface.NativeMethodInfoPtr_UnprotectMessage_Public_Result_byref_UnprotectMessageOptions_ArraySegment_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674362);
      AntiCheatClientInterface.NativeMethodInfoPtr_UnregisterPeer_Public_Result_byref_UnregisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674363);
      AntiCheatClientInterface.NativeMethodInfoPtr_OnClientIntegrityViolatedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientIntegrityViolatedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674364);
      AntiCheatClientInterface.NativeMethodInfoPtr_OnMessageToPeerCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToClientCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674365);
      AntiCheatClientInterface.NativeMethodInfoPtr_OnMessageToServerCallbackInternalImplementation_Internal_Static_Void_byref_OnMessageToServerCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674366);
      AntiCheatClientInterface.NativeMethodInfoPtr_OnPeerActionRequiredCallbackInternalImplementation_Internal_Static_Void_byref_OnClientActionRequiredCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674367);
      AntiCheatClientInterface.NativeMethodInfoPtr_OnPeerAuthStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_OnClientAuthStatusChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatClientInterface>.NativeClassPtr, 100674368);
    }

    public AntiCheatClientInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddexternalintegritycatalogApiLatest
    {
      get
      {
        int addexternalintegritycatalogApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddexternalintegritycatalogApiLatest, (void*) &addexternalintegritycatalogApiLatest);
        return addexternalintegritycatalogApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddexternalintegritycatalogApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyclientintegrityviolatedApiLatest
    {
      get
      {
        int addnotifyclientintegrityviolatedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifyclientintegrityviolatedApiLatest, (void*) &addnotifyclientintegrityviolatedApiLatest);
        return addnotifyclientintegrityviolatedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifyclientintegrityviolatedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifymessagetopeerApiLatest
    {
      get
      {
        int addnotifymessagetopeerApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetopeerApiLatest, (void*) &addnotifymessagetopeerApiLatest);
        return addnotifymessagetopeerApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetopeerApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifymessagetoserverApiLatest
    {
      get
      {
        int addnotifymessagetoserverApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetoserverApiLatest, (void*) &addnotifymessagetoserverApiLatest);
        return addnotifymessagetoserverApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifymessagetoserverApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifypeeractionrequiredApiLatest
    {
      get
      {
        int addnotifypeeractionrequiredApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeeractionrequiredApiLatest, (void*) &addnotifypeeractionrequiredApiLatest);
        return addnotifypeeractionrequiredApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeeractionrequiredApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifypeerauthstatuschangedApiLatest
    {
      get
      {
        int addnotifypeerauthstatuschangedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeerauthstatuschangedApiLatest, (void*) &addnotifypeerauthstatuschangedApiLatest);
        return addnotifypeerauthstatuschangedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_AddnotifypeerauthstatuschangedApiLatest, (void*) &value);
      }
    }

    public static unsafe int BeginsessionApiLatest
    {
      get
      {
        int beginsessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_BeginsessionApiLatest, (void*) &beginsessionApiLatest);
        return beginsessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_BeginsessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int EndsessionApiLatest
    {
      get
      {
        int endsessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &endsessionApiLatest);
        return endsessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_EndsessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetprotectmessageoutputlengthApiLatest
    {
      get
      {
        int getprotectmessageoutputlengthApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest, (void*) &getprotectmessageoutputlengthApiLatest);
        return getprotectmessageoutputlengthApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_GetprotectmessageoutputlengthApiLatest, (void*) &value);
      }
    }

    public unsafe System.IntPtr PeerSelf
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AntiCheatClientInterface.NativeFieldInfoPtr_PeerSelf));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AntiCheatClientInterface.NativeFieldInfoPtr_PeerSelf)) = value;
      }
    }

    public static unsafe int PollstatusApiLatest
    {
      get
      {
        int pollstatusApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_PollstatusApiLatest, (void*) &pollstatusApiLatest);
        return pollstatusApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_PollstatusApiLatest, (void*) &value);
      }
    }

    public static unsafe int ProtectmessageApiLatest
    {
      get
      {
        int protectmessageApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_ProtectmessageApiLatest, (void*) &protectmessageApiLatest);
        return protectmessageApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_ProtectmessageApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReceivemessagefrompeerApiLatest
    {
      get
      {
        int receivemessagefrompeerApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefrompeerApiLatest, (void*) &receivemessagefrompeerApiLatest);
        return receivemessagefrompeerApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefrompeerApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReceivemessagefromserverApiLatest
    {
      get
      {
        int receivemessagefromserverApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefromserverApiLatest, (void*) &receivemessagefromserverApiLatest);
        return receivemessagefromserverApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_ReceivemessagefromserverApiLatest, (void*) &value);
      }
    }

    public static unsafe int RegisterpeerApiLatest
    {
      get
      {
        int registerpeerApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerApiLatest, (void*) &registerpeerApiLatest);
        return registerpeerApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerApiLatest, (void*) &value);
      }
    }

    public static unsafe int RegisterpeerMaxAuthenticationtimeout
    {
      get
      {
        int authenticationtimeout;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerMaxAuthenticationtimeout, (void*) &authenticationtimeout);
        return authenticationtimeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerMaxAuthenticationtimeout, (void*) &value);
      }
    }

    public static unsafe int RegisterpeerMinAuthenticationtimeout
    {
      get
      {
        int authenticationtimeout;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerMinAuthenticationtimeout, (void*) &authenticationtimeout);
        return authenticationtimeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_RegisterpeerMinAuthenticationtimeout, (void*) &value);
      }
    }

    public static unsafe int UnprotectmessageApiLatest
    {
      get
      {
        int unprotectmessageApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest, (void*) &unprotectmessageApiLatest);
        return unprotectmessageApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_UnprotectmessageApiLatest, (void*) &value);
      }
    }

    public static unsafe int UnregisterpeerApiLatest
    {
      get
      {
        int unregisterpeerApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatClientInterface.NativeFieldInfoPtr_UnregisterpeerApiLatest, (void*) &unregisterpeerApiLatest);
        return unregisterpeerApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatClientInterface.NativeFieldInfoPtr_UnregisterpeerApiLatest, (void*) &value);
      }
    }
  }
}
