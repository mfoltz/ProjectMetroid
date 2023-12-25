// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.P2PInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  public sealed class P2PInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptconnectionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyincomingpacketqueuefullApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerconnectionclosedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerconnectionestablishedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerconnectioninterruptedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifypeerconnectionrequestApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClearpacketqueueApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseconnectionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseconnectionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetnattypeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetnextreceivedpacketsizeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetpacketqueueinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetportrangeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetrelaycontrolApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxConnections;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPacketSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxQueueSizeUnlimited;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuerynattypeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReceivepacketApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendpacketApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetpacketqueuesizeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetportrangeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetrelaycontrolApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SocketidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SocketidSocketnameSize;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AcceptConnection_Public_Result_byref_AcceptConnectionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyIncomingPacketQueueFull_Public_UInt64_byref_AddNotifyIncomingPacketQueueFullOptions_Object_OnIncomingPacketQueueFullCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerConnectionClosed_Public_UInt64_byref_AddNotifyPeerConnectionClosedOptions_Object_OnRemoteConnectionClosedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerConnectionEstablished_Public_UInt64_byref_AddNotifyPeerConnectionEstablishedOptions_Object_OnPeerConnectionEstablishedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerConnectionInterrupted_Public_UInt64_byref_AddNotifyPeerConnectionInterruptedOptions_Object_OnPeerConnectionInterruptedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyPeerConnectionRequest_Public_UInt64_byref_AddNotifyPeerConnectionRequestOptions_Object_OnIncomingConnectionRequestCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearPacketQueue_Public_Result_byref_ClearPacketQueueOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CloseConnection_Public_Result_byref_CloseConnectionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CloseConnections_Public_Result_byref_CloseConnectionsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNATType_Public_Result_byref_GetNATTypeOptions_byref_NATType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNextReceivedPacketSize_Public_Result_byref_GetNextReceivedPacketSizeOptions_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPacketQueueInfo_Public_Result_byref_GetPacketQueueInfoOptions_byref_PacketQueueInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPortRange_Public_Result_byref_GetPortRangeOptions_byref_UInt16_byref_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRelayControl_Public_Result_byref_GetRelayControlOptions_byref_RelayControl_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryNATType_Public_Void_byref_QueryNATTypeOptions_Object_OnQueryNATTypeCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePacket_Public_Result_byref_ReceivePacketOptions_byref_ProductUserId_byref_SocketId_byref_Byte_ArraySegment_1_Byte_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyIncomingPacketQueueFull_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerConnectionClosed_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerConnectionEstablished_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerConnectionInterrupted_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyPeerConnectionRequest_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendPacket_Public_Result_byref_SendPacketOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPacketQueueSize_Public_Result_byref_SetPacketQueueSizeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPortRange_Public_Result_byref_SetPortRangeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetRelayControl_Public_Result_byref_SetRelayControlOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnIncomingConnectionRequestCallbackInternalImplementation_Internal_Static_Void_byref_OnIncomingConnectionRequestInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnIncomingPacketQueueFullCallbackInternalImplementation_Internal_Static_Void_byref_OnIncomingPacketQueueFullInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPeerConnectionEstablishedCallbackInternalImplementation_Internal_Static_Void_byref_OnPeerConnectionEstablishedInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPeerConnectionInterruptedCallbackInternalImplementation_Internal_Static_Void_byref_OnPeerConnectionInterruptedInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryNATTypeCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryNATTypeCompleteInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoteConnectionClosedCallbackInternalImplementation_Internal_Static_Void_byref_OnRemoteConnectionClosedInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe P2PInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951884, XrefRangeEnd = 951892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result AcceptConnection(ref AcceptConnectionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AcceptConnection_Public_Result_byref_AcceptConnectionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951892, XrefRangeEnd = 951912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyIncomingPacketQueueFull(
      ref AddNotifyIncomingPacketQueueFullOptions options,
      Il2CppSystem.Object clientData,
      OnIncomingPacketQueueFullCallback incomingPacketQueueFullHandler)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) incomingPacketQueueFullHandler);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyIncomingPacketQueueFull_Public_UInt64_byref_AddNotifyIncomingPacketQueueFullOptions_Object_OnIncomingPacketQueueFullCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951912, XrefRangeEnd = 951933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyPeerConnectionClosed(
      ref AddNotifyPeerConnectionClosedOptions options,
      Il2CppSystem.Object clientData,
      OnRemoteConnectionClosedCallback connectionClosedHandler)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionClosedHandler);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionClosed_Public_UInt64_byref_AddNotifyPeerConnectionClosedOptions_Object_OnRemoteConnectionClosedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951933, XrefRangeEnd = 951953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyPeerConnectionEstablished(
      ref AddNotifyPeerConnectionEstablishedOptions options,
      Il2CppSystem.Object clientData,
      OnPeerConnectionEstablishedCallback connectionEstablishedHandler)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionEstablishedHandler);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionEstablished_Public_UInt64_byref_AddNotifyPeerConnectionEstablishedOptions_Object_OnPeerConnectionEstablishedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951953, XrefRangeEnd = 951973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyPeerConnectionInterrupted(
      ref AddNotifyPeerConnectionInterruptedOptions options,
      Il2CppSystem.Object clientData,
      OnPeerConnectionInterruptedCallback connectionInterruptedHandler)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionInterruptedHandler);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionInterrupted_Public_UInt64_byref_AddNotifyPeerConnectionInterruptedOptions_Object_OnPeerConnectionInterruptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951973, XrefRangeEnd = 951993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyPeerConnectionRequest(
      ref AddNotifyPeerConnectionRequestOptions options,
      Il2CppSystem.Object clientData,
      OnIncomingConnectionRequestCallback connectionRequestHandler)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) connectionRequestHandler);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionRequest_Public_UInt64_byref_AddNotifyPeerConnectionRequestOptions_Object_OnIncomingConnectionRequestCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951993, XrefRangeEnd = 952001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result ClearPacketQueue(ref ClearPacketQueueOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_ClearPacketQueue_Public_Result_byref_ClearPacketQueueOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952001, XrefRangeEnd = 952009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CloseConnection(ref CloseConnectionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_CloseConnection_Public_Result_byref_CloseConnectionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952009, XrefRangeEnd = 952017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CloseConnections(ref CloseConnectionsOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_CloseConnections_Public_Result_byref_CloseConnectionsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952017, XrefRangeEnd = 952028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetNATType(ref GetNATTypeOptions options, out NATType outNATType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outNATType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetNATType_Public_Result_byref_GetNATTypeOptions_byref_NATType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952028, XrefRangeEnd = 952039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetNextReceivedPacketSize(
      ref GetNextReceivedPacketSizeOptions options,
      out uint outPacketSizeBytes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outPacketSizeBytes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetNextReceivedPacketSize_Public_Result_byref_GetNextReceivedPacketSizeOptions_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952039, XrefRangeEnd = 952053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetPacketQueueInfo(
      ref GetPacketQueueInfoOptions options,
      out PacketQueueInfo outPacketQueueInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outPacketQueueInfo;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetPacketQueueInfo_Public_Result_byref_GetPacketQueueInfoOptions_byref_PacketQueueInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952053, XrefRangeEnd = 952066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetPortRange(
      ref GetPortRangeOptions options,
      out ushort outPort,
      out ushort outNumAdditionalPortsToTry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outPort;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref outNumAdditionalPortsToTry;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetPortRange_Public_Result_byref_GetPortRangeOptions_byref_UInt16_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952066, XrefRangeEnd = 952077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetRelayControl(
      ref GetRelayControlOptions options,
      out RelayControl outRelayControl)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outRelayControl;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_GetRelayControl_Public_Result_byref_GetRelayControlOptions_byref_RelayControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952077, XrefRangeEnd = 952096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryNATType(
      ref QueryNATTypeOptions options,
      Il2CppSystem.Object clientData,
      OnQueryNATTypeCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_QueryNATType_Public_Void_byref_QueryNATTypeOptions_Object_OnQueryNATTypeCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952096, XrefRangeEnd = 952119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result ReceivePacket(
      ref ReceivePacketOptions options,
      out ProductUserId outPeerId,
      out SocketId outSocketId,
      out byte outChannel,
      Il2CppSystem.ArraySegment<byte> outData,
      out uint outBytesWritten)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref outChannel;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) outData));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref outBytesWritten;
      System.IntPtr exc;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_ReceivePacket_Public_Result_byref_ReceivePacketOptions_byref_ProductUserId_byref_SocketId_byref_Byte_ArraySegment_1_Byte_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ProductUserId local1 = ref outPeerId;
      System.IntPtr pointer1 = zero1;
      ProductUserId productUserId = pointer1 == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer1);
      local1 = productUserId;
      ref SocketId local2 = ref outSocketId;
      System.IntPtr pointer2 = zero2;
      SocketId socketId = pointer2 == System.IntPtr.Zero ? (SocketId) null : new SocketId(pointer2);
      local2 = socketId;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952119, XrefRangeEnd = 952124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyIncomingPacketQueueFull(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyIncomingPacketQueueFull_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952124, XrefRangeEnd = 952129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyPeerConnectionClosed(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionClosed_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952129, XrefRangeEnd = 952134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyPeerConnectionEstablished(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionEstablished_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952134, XrefRangeEnd = 952139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyPeerConnectionInterrupted(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionInterrupted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952139, XrefRangeEnd = 952144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyPeerConnectionRequest(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionRequest_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952144, XrefRangeEnd = 952152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SendPacket(ref SendPacketOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_SendPacket_Public_Result_byref_SendPacketOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952152, XrefRangeEnd = 952160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetPacketQueueSize(ref SetPacketQueueSizeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_SetPacketQueueSize_Public_Result_byref_SetPacketQueueSizeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952160, XrefRangeEnd = 952168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetPortRange(ref SetPortRangeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_SetPortRange_Public_Result_byref_SetPortRangeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952168, XrefRangeEnd = 952176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetRelayControl(ref SetRelayControlOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_SetRelayControl_Public_Result_byref_SetRelayControlOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952176, XrefRangeEnd = 952183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnIncomingConnectionRequestCallbackInternalImplementation(
      ref OnIncomingConnectionRequestInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnIncomingConnectionRequestCallbackInternalImplementation_Internal_Static_Void_byref_OnIncomingConnectionRequestInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952183, XrefRangeEnd = 952190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnIncomingPacketQueueFullCallbackInternalImplementation(
      ref OnIncomingPacketQueueFullInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnIncomingPacketQueueFullCallbackInternalImplementation_Internal_Static_Void_byref_OnIncomingPacketQueueFullInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952190, XrefRangeEnd = 952197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnPeerConnectionEstablishedCallbackInternalImplementation(
      ref OnPeerConnectionEstablishedInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnPeerConnectionEstablishedCallbackInternalImplementation_Internal_Static_Void_byref_OnPeerConnectionEstablishedInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952197, XrefRangeEnd = 952204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnPeerConnectionInterruptedCallbackInternalImplementation(
      ref OnPeerConnectionInterruptedInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnPeerConnectionInterruptedCallbackInternalImplementation_Internal_Static_Void_byref_OnPeerConnectionInterruptedInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952204, XrefRangeEnd = 952211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryNATTypeCompleteCallbackInternalImplementation(
      ref OnQueryNATTypeCompleteInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnQueryNATTypeCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryNATTypeCompleteInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952211, XrefRangeEnd = 952218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnRemoteConnectionClosedCallbackInternalImplementation(
      ref OnRemoteConnectionClosedInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(P2PInterface.NativeMethodInfoPtr_OnRemoteConnectionClosedCallbackInternalImplementation_Internal_Static_Void_byref_OnRemoteConnectionClosedInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static P2PInterface()
    {
      Il2CppClassPointerStore<P2PInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (P2PInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr);
      P2PInterface.NativeFieldInfoPtr_AcceptconnectionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AcceptconnectionApiLatest));
      P2PInterface.NativeFieldInfoPtr_AddnotifyincomingpacketqueuefullApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifyincomingpacketqueuefullApiLatest));
      P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionclosedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifypeerconnectionclosedApiLatest));
      P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionestablishedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifypeerconnectionestablishedApiLatest));
      P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectioninterruptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifypeerconnectioninterruptedApiLatest));
      P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionrequestApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (AddnotifypeerconnectionrequestApiLatest));
      P2PInterface.NativeFieldInfoPtr_ClearpacketqueueApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (ClearpacketqueueApiLatest));
      P2PInterface.NativeFieldInfoPtr_CloseconnectionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (CloseconnectionApiLatest));
      P2PInterface.NativeFieldInfoPtr_CloseconnectionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (CloseconnectionsApiLatest));
      P2PInterface.NativeFieldInfoPtr_GetnattypeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetnattypeApiLatest));
      P2PInterface.NativeFieldInfoPtr_GetnextreceivedpacketsizeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetnextreceivedpacketsizeApiLatest));
      P2PInterface.NativeFieldInfoPtr_GetpacketqueueinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetpacketqueueinfoApiLatest));
      P2PInterface.NativeFieldInfoPtr_GetportrangeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetportrangeApiLatest));
      P2PInterface.NativeFieldInfoPtr_GetrelaycontrolApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (GetrelaycontrolApiLatest));
      P2PInterface.NativeFieldInfoPtr_MaxConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (MaxConnections));
      P2PInterface.NativeFieldInfoPtr_MaxPacketSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (MaxPacketSize));
      P2PInterface.NativeFieldInfoPtr_MaxQueueSizeUnlimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (MaxQueueSizeUnlimited));
      P2PInterface.NativeFieldInfoPtr_QuerynattypeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (QuerynattypeApiLatest));
      P2PInterface.NativeFieldInfoPtr_ReceivepacketApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (ReceivepacketApiLatest));
      P2PInterface.NativeFieldInfoPtr_SendpacketApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SendpacketApiLatest));
      P2PInterface.NativeFieldInfoPtr_SetpacketqueuesizeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SetpacketqueuesizeApiLatest));
      P2PInterface.NativeFieldInfoPtr_SetportrangeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SetportrangeApiLatest));
      P2PInterface.NativeFieldInfoPtr_SetrelaycontrolApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SetrelaycontrolApiLatest));
      P2PInterface.NativeFieldInfoPtr_SocketidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SocketidApiLatest));
      P2PInterface.NativeFieldInfoPtr_SocketidSocketnameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, nameof (SocketidSocketnameSize));
      P2PInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669132);
      P2PInterface.NativeMethodInfoPtr_AcceptConnection_Public_Result_byref_AcceptConnectionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669134);
      P2PInterface.NativeMethodInfoPtr_AddNotifyIncomingPacketQueueFull_Public_UInt64_byref_AddNotifyIncomingPacketQueueFullOptions_Object_OnIncomingPacketQueueFullCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669135);
      P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionClosed_Public_UInt64_byref_AddNotifyPeerConnectionClosedOptions_Object_OnRemoteConnectionClosedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669136);
      P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionEstablished_Public_UInt64_byref_AddNotifyPeerConnectionEstablishedOptions_Object_OnPeerConnectionEstablishedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669137);
      P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionInterrupted_Public_UInt64_byref_AddNotifyPeerConnectionInterruptedOptions_Object_OnPeerConnectionInterruptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669138);
      P2PInterface.NativeMethodInfoPtr_AddNotifyPeerConnectionRequest_Public_UInt64_byref_AddNotifyPeerConnectionRequestOptions_Object_OnIncomingConnectionRequestCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669139);
      P2PInterface.NativeMethodInfoPtr_ClearPacketQueue_Public_Result_byref_ClearPacketQueueOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669140);
      P2PInterface.NativeMethodInfoPtr_CloseConnection_Public_Result_byref_CloseConnectionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669141);
      P2PInterface.NativeMethodInfoPtr_CloseConnections_Public_Result_byref_CloseConnectionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669142);
      P2PInterface.NativeMethodInfoPtr_GetNATType_Public_Result_byref_GetNATTypeOptions_byref_NATType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669143);
      P2PInterface.NativeMethodInfoPtr_GetNextReceivedPacketSize_Public_Result_byref_GetNextReceivedPacketSizeOptions_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669144);
      P2PInterface.NativeMethodInfoPtr_GetPacketQueueInfo_Public_Result_byref_GetPacketQueueInfoOptions_byref_PacketQueueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669145);
      P2PInterface.NativeMethodInfoPtr_GetPortRange_Public_Result_byref_GetPortRangeOptions_byref_UInt16_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669146);
      P2PInterface.NativeMethodInfoPtr_GetRelayControl_Public_Result_byref_GetRelayControlOptions_byref_RelayControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669147);
      P2PInterface.NativeMethodInfoPtr_QueryNATType_Public_Void_byref_QueryNATTypeOptions_Object_OnQueryNATTypeCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669148);
      P2PInterface.NativeMethodInfoPtr_ReceivePacket_Public_Result_byref_ReceivePacketOptions_byref_ProductUserId_byref_SocketId_byref_Byte_ArraySegment_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669149);
      P2PInterface.NativeMethodInfoPtr_RemoveNotifyIncomingPacketQueueFull_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669150);
      P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionClosed_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669151);
      P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionEstablished_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669152);
      P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionInterrupted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669153);
      P2PInterface.NativeMethodInfoPtr_RemoveNotifyPeerConnectionRequest_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669154);
      P2PInterface.NativeMethodInfoPtr_SendPacket_Public_Result_byref_SendPacketOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669155);
      P2PInterface.NativeMethodInfoPtr_SetPacketQueueSize_Public_Result_byref_SetPacketQueueSizeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669156);
      P2PInterface.NativeMethodInfoPtr_SetPortRange_Public_Result_byref_SetPortRangeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669157);
      P2PInterface.NativeMethodInfoPtr_SetRelayControl_Public_Result_byref_SetRelayControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669158);
      P2PInterface.NativeMethodInfoPtr_OnIncomingConnectionRequestCallbackInternalImplementation_Internal_Static_Void_byref_OnIncomingConnectionRequestInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669159);
      P2PInterface.NativeMethodInfoPtr_OnIncomingPacketQueueFullCallbackInternalImplementation_Internal_Static_Void_byref_OnIncomingPacketQueueFullInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669160);
      P2PInterface.NativeMethodInfoPtr_OnPeerConnectionEstablishedCallbackInternalImplementation_Internal_Static_Void_byref_OnPeerConnectionEstablishedInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669161);
      P2PInterface.NativeMethodInfoPtr_OnPeerConnectionInterruptedCallbackInternalImplementation_Internal_Static_Void_byref_OnPeerConnectionInterruptedInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669162);
      P2PInterface.NativeMethodInfoPtr_OnQueryNATTypeCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryNATTypeCompleteInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669163);
      P2PInterface.NativeMethodInfoPtr_OnRemoteConnectionClosedCallbackInternalImplementation_Internal_Static_Void_byref_OnRemoteConnectionClosedInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<P2PInterface>.NativeClassPtr, 100669164);
    }

    public P2PInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AcceptconnectionApiLatest
    {
      get
      {
        int acceptconnectionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AcceptconnectionApiLatest, (void*) &acceptconnectionApiLatest);
        return acceptconnectionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AcceptconnectionApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyincomingpacketqueuefullApiLatest
    {
      get
      {
        int addnotifyincomingpacketqueuefullApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifyincomingpacketqueuefullApiLatest, (void*) &addnotifyincomingpacketqueuefullApiLatest);
        return addnotifyincomingpacketqueuefullApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifyincomingpacketqueuefullApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifypeerconnectionclosedApiLatest
    {
      get
      {
        int addnotifypeerconnectionclosedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionclosedApiLatest, (void*) &addnotifypeerconnectionclosedApiLatest);
        return addnotifypeerconnectionclosedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionclosedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifypeerconnectionestablishedApiLatest
    {
      get
      {
        int addnotifypeerconnectionestablishedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionestablishedApiLatest, (void*) &addnotifypeerconnectionestablishedApiLatest);
        return addnotifypeerconnectionestablishedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionestablishedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifypeerconnectioninterruptedApiLatest
    {
      get
      {
        int addnotifypeerconnectioninterruptedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectioninterruptedApiLatest, (void*) &addnotifypeerconnectioninterruptedApiLatest);
        return addnotifypeerconnectioninterruptedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectioninterruptedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifypeerconnectionrequestApiLatest
    {
      get
      {
        int addnotifypeerconnectionrequestApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionrequestApiLatest, (void*) &addnotifypeerconnectionrequestApiLatest);
        return addnotifypeerconnectionrequestApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_AddnotifypeerconnectionrequestApiLatest, (void*) &value);
      }
    }

    public static unsafe int ClearpacketqueueApiLatest
    {
      get
      {
        int clearpacketqueueApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_ClearpacketqueueApiLatest, (void*) &clearpacketqueueApiLatest);
        return clearpacketqueueApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_ClearpacketqueueApiLatest, (void*) &value);
      }
    }

    public static unsafe int CloseconnectionApiLatest
    {
      get
      {
        int closeconnectionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_CloseconnectionApiLatest, (void*) &closeconnectionApiLatest);
        return closeconnectionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_CloseconnectionApiLatest, (void*) &value);
      }
    }

    public static unsafe int CloseconnectionsApiLatest
    {
      get
      {
        int closeconnectionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_CloseconnectionsApiLatest, (void*) &closeconnectionsApiLatest);
        return closeconnectionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_CloseconnectionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetnattypeApiLatest
    {
      get
      {
        int getnattypeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetnattypeApiLatest, (void*) &getnattypeApiLatest);
        return getnattypeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetnattypeApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetnextreceivedpacketsizeApiLatest
    {
      get
      {
        int getnextreceivedpacketsizeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetnextreceivedpacketsizeApiLatest, (void*) &getnextreceivedpacketsizeApiLatest);
        return getnextreceivedpacketsizeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetnextreceivedpacketsizeApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetpacketqueueinfoApiLatest
    {
      get
      {
        int getpacketqueueinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetpacketqueueinfoApiLatest, (void*) &getpacketqueueinfoApiLatest);
        return getpacketqueueinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetpacketqueueinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetportrangeApiLatest
    {
      get
      {
        int getportrangeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetportrangeApiLatest, (void*) &getportrangeApiLatest);
        return getportrangeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetportrangeApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetrelaycontrolApiLatest
    {
      get
      {
        int getrelaycontrolApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_GetrelaycontrolApiLatest, (void*) &getrelaycontrolApiLatest);
        return getrelaycontrolApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_GetrelaycontrolApiLatest, (void*) &value);
      }
    }

    public static unsafe int MaxConnections
    {
      get
      {
        int maxConnections;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_MaxConnections, (void*) &maxConnections);
        return maxConnections;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_MaxConnections, (void*) &value);
      }
    }

    public static unsafe int MaxPacketSize
    {
      get
      {
        int maxPacketSize;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_MaxPacketSize, (void*) &maxPacketSize);
        return maxPacketSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_MaxPacketSize, (void*) &value);
      }
    }

    public static unsafe int MaxQueueSizeUnlimited
    {
      get
      {
        int queueSizeUnlimited;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_MaxQueueSizeUnlimited, (void*) &queueSizeUnlimited);
        return queueSizeUnlimited;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_MaxQueueSizeUnlimited, (void*) &value);
      }
    }

    public static unsafe int QuerynattypeApiLatest
    {
      get
      {
        int querynattypeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_QuerynattypeApiLatest, (void*) &querynattypeApiLatest);
        return querynattypeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_QuerynattypeApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReceivepacketApiLatest
    {
      get
      {
        int receivepacketApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_ReceivepacketApiLatest, (void*) &receivepacketApiLatest);
        return receivepacketApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_ReceivepacketApiLatest, (void*) &value);
      }
    }

    public static unsafe int SendpacketApiLatest
    {
      get
      {
        int sendpacketApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SendpacketApiLatest, (void*) &sendpacketApiLatest);
        return sendpacketApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SendpacketApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetpacketqueuesizeApiLatest
    {
      get
      {
        int setpacketqueuesizeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SetpacketqueuesizeApiLatest, (void*) &setpacketqueuesizeApiLatest);
        return setpacketqueuesizeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SetpacketqueuesizeApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetportrangeApiLatest
    {
      get
      {
        int setportrangeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SetportrangeApiLatest, (void*) &setportrangeApiLatest);
        return setportrangeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SetportrangeApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetrelaycontrolApiLatest
    {
      get
      {
        int setrelaycontrolApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SetrelaycontrolApiLatest, (void*) &setrelaycontrolApiLatest);
        return setrelaycontrolApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SetrelaycontrolApiLatest, (void*) &value);
      }
    }

    public static unsafe int SocketidApiLatest
    {
      get
      {
        int socketidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SocketidApiLatest, (void*) &socketidApiLatest);
        return socketidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SocketidApiLatest, (void*) &value);
      }
    }

    public static unsafe int SocketidSocketnameSize
    {
      get
      {
        int socketidSocketnameSize;
        IL2CPP.il2cpp_field_static_get_value(P2PInterface.NativeFieldInfoPtr_SocketidSocketnameSize, (void*) &socketidSocketnameSize);
        return socketidSocketnameSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(P2PInterface.NativeFieldInfoPtr_SocketidSocketnameSize, (void*) &value);
      }
    }
  }
}
