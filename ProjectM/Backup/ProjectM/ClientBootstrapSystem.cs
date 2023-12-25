// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientBootstrapSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Network;
using ProjectM.Terrain;
using Stunlock.Network;
using Stunlock.Network.Lidgren;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Scenes;

#nullable disable
namespace ProjectM
{
  public class ClientBootstrapSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__StatusChangedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReceivePacketQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__HailMessageAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientNetworkStateAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsGameDataInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIAssetSubSceneLoader;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetClient;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveConnectionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionString;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultNetworkData;
    private static readonly System.IntPtr NativeFieldInfoPtr__PacketPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientCreateData;
    private static readonly System.IntPtr NativeFieldInfoPtr__VFXReplacementSettings_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__QueuedConnectRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastConnectData;
    private static readonly System.IntPtr NativeFieldInfoPtr__SetupWorldState;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasBeenConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequestedDisconnect;
    private static readonly System.IntPtr NativeFieldInfoPtr__SetClientStateToRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextConnectionAttempt;
    private static readonly System.IntPtr NativeFieldInfoPtr_TIME_TO_WAIT_FOR_LOCAL_SERVER_STARTUP;
    private static readonly System.IntPtr NativeFieldInfoPtr_RETRY_DELAY;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CONNECT_RETRIES;
    private static readonly System.IntPtr NativeFieldInfoPtr_RetryAttempts;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientLoadProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientLoadProgressMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameBootstrap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientState;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisconnectChangeReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisconnectReasonExtraData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerLoadProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_VersionMismatchError;
    private static readonly System.IntPtr NativeFieldInfoPtr_HailMessageStruct;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShaderPreWarmProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShaderPreWarmMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreWarmingShadersState;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumFramesSincePreWarmStart;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VFXReplacementSettings_Public_get_VFXReplacementSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VFXReplacementSettings_Private_set_Void_VFXReplacementSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ConnectRequestIsEnqueued_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasBeenConnected_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LastConnectionData_Public_get_ClientConnectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ConnectionStatus_Public_get_ClientConnectState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Latency_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SkipClickToFade_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SimulatedLatency_Public_get_SimulationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SimulatedLatency_Public_set_Void_SimulationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkStats_Public_byref_ClientTransportStats_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadToTargetWorldConfig_Private_LoadToTargetWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateClientLoadingState_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetShouldCreateCharacter_Public_Static_Boolean_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginSetupClient_Public_Void_GameBootstrap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginSetupClientWorld_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeSetupClient_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasLoadedAllChunks_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Void_ConnectAddress_PlatformIdCollection_Il2CppStructArray_1_Byte_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateNetClient_Private_Void_ConnectAddress_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoadingDataReceived_Private_Void_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConnectRequest_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_ConnectionStatusChangeReason_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendPacketToServer_Public_Boolean_NativeArray_1_Byte_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnClientConnected_Private_Void_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnClientDisconnected_Private_Void_ConnectionStatusChangeReason_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDataReceivedClient_Private_Void_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStateSyncReceived_Private_Void_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateReceivedPacketEntity_Private_DynamicBuffer_1_Byte_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnReliableEventsReceived_Private_Void_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    public unsafe VFXReplacementSettings VFXReplacementSettings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_get_VFXReplacementSettings_Public_get_VFXReplacementSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (VFXReplacementSettings) null : new VFXReplacementSettings(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977788, XrefRangeEnd = 977789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_set_VFXReplacementSettings_Private_set_Void_VFXReplacementSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool ConnectRequestIsEnqueued
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977789, XrefRangeEnd = 977790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_get_ConnectRequestIsEnqueued_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasBeenConnected
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_get_HasBeenConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ClientConnectData LastConnectionData
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 977795, RefRangeEnd = 977796, XrefRangeStart = 977790, XrefRangeEnd = 977795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_get_LastConnectionData_Public_get_ClientConnectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new ClientConnectData(pointer);
      }
    }

    public unsafe ClientConnectState ConnectionStatus
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 977797, RefRangeEnd = 977800, XrefRangeStart = 977796, XrefRangeEnd = 977797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_get_ConnectionStatus_Public_get_ClientConnectState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ClientConnectState*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float Latency
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 977803, RefRangeEnd = 977806, XrefRangeStart = 977800, XrefRangeEnd = 977803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_get_Latency_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool SkipClickToFade
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_get_SkipClickToFade_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe SimulationData SimulatedLatency
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977806, XrefRangeEnd = 977809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_get_SimulatedLatency_Public_get_SimulationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SimulationData*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977809, XrefRangeEnd = 977812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_set_SimulatedLatency_Public_set_Void_SimulationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 977815, RefRangeEnd = 977818, XrefRangeStart = 977812, XrefRangeEnd = 977815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref ClientTransportStats GetNetworkStats()
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    public unsafe LoadToTargetWorld GetLoadToTargetWorldConfig()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_GetLoadToTargetWorldConfig_Private_LoadToTargetWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LoadToTargetWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977818, XrefRangeEnd = 977867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientBootstrapSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977867, XrefRangeEnd = 977894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientBootstrapSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 977925, RefRangeEnd = 977926, XrefRangeStart = 977894, XrefRangeEnd = 977925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateClientLoadingState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_UpdateClientLoadingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977926, XrefRangeEnd = 977947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetShouldCreateCharacter(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_GetShouldCreateCharacter_Public_Static_Boolean_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977947, XrefRangeEnd = 977967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientBootstrapSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977967, XrefRangeEnd = 977976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientBootstrapSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 977994, RefRangeEnd = 977995, XrefRangeStart = 977976, XrefRangeEnd = 977994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginSetupClient(GameBootstrap gameBootstrap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameBootstrap);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_BeginSetupClient_Public_Void_GameBootstrap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 978075, RefRangeEnd = 978076, XrefRangeStart = 977995, XrefRangeEnd = 978075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginSetupClientWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_BeginSetupClientWorld_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 978145, RefRangeEnd = 978146, XrefRangeStart = 978076, XrefRangeEnd = 978145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinalizeSetupClient()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_FinalizeSetupClient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978146, XrefRangeEnd = 978199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasLoadedAllChunks(Entity userEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &userEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_HasLoadedAllChunks_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 978242, RefRangeEnd = 978243, XrefRangeStart = 978199, XrefRangeEnd = 978242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Connect(
      ConnectAddress connectAddress,
      PlatformIdCollection platformIds,
      Il2CppStructArray<byte> sessionTicket,
      string password)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &connectAddress;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformIds);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sessionTicket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(password);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_Connect_Public_Void_ConnectAddress_PlatformIdCollection_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 978300, RefRangeEnd = 978301, XrefRangeStart = 978243, XrefRangeEnd = 978300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateNetClient(ConnectAddress connectAddress)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &connectAddress;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_CreateNetClient_Private_Void_ConnectAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978301, XrefRangeEnd = 978302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnLoadingDataReceived(ref NetBufferIn loadingData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref loadingData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_OnLoadingDataReceived_Private_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 978343, RefRangeEnd = 978345, XrefRangeStart = 978302, XrefRangeEnd = 978343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateConnectRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_UpdateConnectRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 978352, RefRangeEnd = 978356, XrefRangeStart = 978345, XrefRangeEnd = 978352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Disconnect(bool graceful, ConnectionStatusChangeReason reason = ConnectionStatusChangeReason.LeftGame)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &graceful;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &reason;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_ConnectionStatusChangeReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 978365, RefRangeEnd = 978367, XrefRangeStart = 978356, XrefRangeEnd = 978365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SendPacketToServer(NativeArray<byte> data, int lengthBits, bool reliable)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lengthBits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &reliable;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_SendPacketToServer_Public_Boolean_NativeArray_1_Byte_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978367, XrefRangeEnd = 978403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnClientConnected(ref NetBufferIn hailData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref hailData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_OnClientConnected_Private_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978403, XrefRangeEnd = 978474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnClientDisconnected(
      ConnectionStatusChangeReason connectionStatusChangeReason,
      string extraData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &connectionStatusChangeReason;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(extraData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_OnClientDisconnected_Private_Void_ConnectionStatusChangeReason_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978474, XrefRangeEnd = 978519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDataReceivedClient(ref NetBufferIn netBufferIn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBufferIn;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_OnDataReceivedClient_Private_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978519, XrefRangeEnd = 978541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnStateSyncReceived(ref NetBufferIn netBufferIn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBufferIn;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_OnStateSyncReceived_Private_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978541, XrefRangeEnd = 978554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicBuffer<byte> CreateReceivedPacketEntity(int lengthBits)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &lengthBits;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_CreateReceivedPacketEntity_Private_DynamicBuffer_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<byte>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 978581, RefRangeEnd = 978582, XrefRangeStart = 978554, XrefRangeEnd = 978581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnReliableEventsReceived(ref NetBufferIn netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr_OnReliableEventsReceived_Private_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978582, XrefRangeEnd = 978583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientBootstrapSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978583, XrefRangeEnd = 978603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientBootstrapSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978603, XrefRangeEnd = 978619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ClientBootstrapSystem()
    {
      Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ClientBootstrapSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr);
      ClientBootstrapSystem.NativeFieldInfoPtr__StatusChangedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_StatusChangedEventQuery));
      ClientBootstrapSystem.NativeFieldInfoPtr__ReceivePacketQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_ReceivePacketQuery));
      ClientBootstrapSystem.NativeFieldInfoPtr__HailMessageAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_HailMessageAccessor));
      ClientBootstrapSystem.NativeFieldInfoPtr__ClientNetworkStateAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_ClientNetworkStateAccessor));
      ClientBootstrapSystem.NativeFieldInfoPtr__IsGameDataInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_IsGameDataInitialized));
      ClientBootstrapSystem.NativeFieldInfoPtr__GameDataManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_GameDataManager));
      ClientBootstrapSystem.NativeFieldInfoPtr__SceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_SceneSystem));
      ClientBootstrapSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_TerrainManager));
      ClientBootstrapSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_UIAssetSubSceneLoader));
      ClientBootstrapSystem.NativeFieldInfoPtr__NetClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_NetClient));
      ClientBootstrapSystem.NativeFieldInfoPtr_ActiveConnectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ActiveConnectionData));
      ClientBootstrapSystem.NativeFieldInfoPtr_ConnectionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ConnectionString));
      ClientBootstrapSystem.NativeFieldInfoPtr_SessionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (SessionGuid));
      ClientBootstrapSystem.NativeFieldInfoPtr__DefaultNetworkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_DefaultNetworkData));
      ClientBootstrapSystem.NativeFieldInfoPtr__PacketPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_PacketPrefab));
      ClientBootstrapSystem.NativeFieldInfoPtr__ClientCreateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_ClientCreateData));
      ClientBootstrapSystem.NativeFieldInfoPtr__VFXReplacementSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, "<VFXReplacementSettings>k__BackingField");
      ClientBootstrapSystem.NativeFieldInfoPtr__QueuedConnectRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_QueuedConnectRequest));
      ClientBootstrapSystem.NativeFieldInfoPtr__LastConnectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_LastConnectData));
      ClientBootstrapSystem.NativeFieldInfoPtr__SetupWorldState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_SetupWorldState));
      ClientBootstrapSystem.NativeFieldInfoPtr__HasBeenConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_HasBeenConnected));
      ClientBootstrapSystem.NativeFieldInfoPtr__RequestedDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_RequestedDisconnect));
      ClientBootstrapSystem.NativeFieldInfoPtr__SetClientStateToRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_SetClientStateToRunning));
      ClientBootstrapSystem.NativeFieldInfoPtr__NextConnectionAttempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (_NextConnectionAttempt));
      ClientBootstrapSystem.NativeFieldInfoPtr_TIME_TO_WAIT_FOR_LOCAL_SERVER_STARTUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (TIME_TO_WAIT_FOR_LOCAL_SERVER_STARTUP));
      ClientBootstrapSystem.NativeFieldInfoPtr_RETRY_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (RETRY_DELAY));
      ClientBootstrapSystem.NativeFieldInfoPtr_MAX_CONNECT_RETRIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (MAX_CONNECT_RETRIES));
      ClientBootstrapSystem.NativeFieldInfoPtr_RetryAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (RetryAttempts));
      ClientBootstrapSystem.NativeFieldInfoPtr_ClientLoadProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ClientLoadProgress));
      ClientBootstrapSystem.NativeFieldInfoPtr_ClientLoadProgressMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ClientLoadProgressMax));
      ClientBootstrapSystem.NativeFieldInfoPtr_GameBootstrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (GameBootstrap));
      ClientBootstrapSystem.NativeFieldInfoPtr_ClientState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ClientState));
      ClientBootstrapSystem.NativeFieldInfoPtr_DisconnectChangeReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (DisconnectChangeReason));
      ClientBootstrapSystem.NativeFieldInfoPtr_DisconnectReasonExtraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (DisconnectReasonExtraData));
      ClientBootstrapSystem.NativeFieldInfoPtr_ServerLoadProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ServerLoadProgress));
      ClientBootstrapSystem.NativeFieldInfoPtr_VersionMismatchError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (VersionMismatchError));
      ClientBootstrapSystem.NativeFieldInfoPtr_HailMessageStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (HailMessageStruct));
      ClientBootstrapSystem.NativeFieldInfoPtr_ShaderPreWarmProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ShaderPreWarmProgress));
      ClientBootstrapSystem.NativeFieldInfoPtr_ShaderPreWarmMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ShaderPreWarmMax));
      ClientBootstrapSystem.NativeFieldInfoPtr_PreWarmingShadersState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (PreWarmingShadersState));
      ClientBootstrapSystem.NativeFieldInfoPtr_NumFramesSincePreWarmStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (NumFramesSincePreWarmStart));
      ClientBootstrapSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      ClientBootstrapSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      ClientBootstrapSystem.NativeMethodInfoPtr_get_VFXReplacementSettings_Public_get_VFXReplacementSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675557);
      ClientBootstrapSystem.NativeMethodInfoPtr_set_VFXReplacementSettings_Private_set_Void_VFXReplacementSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675558);
      ClientBootstrapSystem.NativeMethodInfoPtr_get_ConnectRequestIsEnqueued_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675559);
      ClientBootstrapSystem.NativeMethodInfoPtr_get_HasBeenConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675560);
      ClientBootstrapSystem.NativeMethodInfoPtr_get_LastConnectionData_Public_get_ClientConnectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675561);
      ClientBootstrapSystem.NativeMethodInfoPtr_get_ConnectionStatus_Public_get_ClientConnectState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675562);
      ClientBootstrapSystem.NativeMethodInfoPtr_get_Latency_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675563);
      ClientBootstrapSystem.NativeMethodInfoPtr_get_SkipClickToFade_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675564);
      ClientBootstrapSystem.NativeMethodInfoPtr_get_SimulatedLatency_Public_get_SimulationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675565);
      ClientBootstrapSystem.NativeMethodInfoPtr_set_SimulatedLatency_Public_set_Void_SimulationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675566);
      ClientBootstrapSystem.NativeMethodInfoPtr_GetNetworkStats_Public_byref_ClientTransportStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675567);
      ClientBootstrapSystem.NativeMethodInfoPtr_GetLoadToTargetWorldConfig_Private_LoadToTargetWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675568);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675569);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675570);
      ClientBootstrapSystem.NativeMethodInfoPtr_UpdateClientLoadingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675571);
      ClientBootstrapSystem.NativeMethodInfoPtr_GetShouldCreateCharacter_Public_Static_Boolean_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675572);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675573);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675574);
      ClientBootstrapSystem.NativeMethodInfoPtr_BeginSetupClient_Public_Void_GameBootstrap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675575);
      ClientBootstrapSystem.NativeMethodInfoPtr_BeginSetupClientWorld_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675576);
      ClientBootstrapSystem.NativeMethodInfoPtr_FinalizeSetupClient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675577);
      ClientBootstrapSystem.NativeMethodInfoPtr_HasLoadedAllChunks_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675578);
      ClientBootstrapSystem.NativeMethodInfoPtr_Connect_Public_Void_ConnectAddress_PlatformIdCollection_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675579);
      ClientBootstrapSystem.NativeMethodInfoPtr_CreateNetClient_Private_Void_ConnectAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675580);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnLoadingDataReceived_Private_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675581);
      ClientBootstrapSystem.NativeMethodInfoPtr_UpdateConnectRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675582);
      ClientBootstrapSystem.NativeMethodInfoPtr_Disconnect_Public_Void_Boolean_ConnectionStatusChangeReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675583);
      ClientBootstrapSystem.NativeMethodInfoPtr_SendPacketToServer_Public_Boolean_NativeArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675584);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnClientConnected_Private_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675585);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnClientDisconnected_Private_Void_ConnectionStatusChangeReason_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675586);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnDataReceivedClient_Private_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675587);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnStateSyncReceived_Private_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675588);
      ClientBootstrapSystem.NativeMethodInfoPtr_CreateReceivedPacketEntity_Private_DynamicBuffer_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675589);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnReliableEventsReceived_Private_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675590);
      ClientBootstrapSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675591);
      ClientBootstrapSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675592);
      ClientBootstrapSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, 100675593);
    }

    public ClientBootstrapSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _StatusChangedEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__StatusChangedEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__StatusChangedEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _ReceivePacketQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__ReceivePacketQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__ReceivePacketQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<HailMessage> _HailMessageAccessor
    {
      get
      {
        return *(SingletonAccessor<HailMessage>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__HailMessageAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__HailMessageAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<HailMessage>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ClientNetworkState> _ClientNetworkStateAccessor
    {
      get
      {
        return *(SingletonAccessor<ClientNetworkState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__ClientNetworkStateAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__ClientNetworkStateAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ClientNetworkState>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _IsGameDataInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__IsGameDataInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__IsGameDataInitialized)) = value;
      }
    }

    public unsafe GameDataManager _GameDataManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__GameDataManager));
        return pointer == System.IntPtr.Zero ? (GameDataManager) null : new GameDataManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__GameDataManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SceneSystem _SceneSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__SceneSystem));
        return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__SceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIAssetSubSceneLoader_ClientWorld _UIAssetSubSceneLoader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader));
        return pointer == System.IntPtr.Zero ? (UIAssetSubSceneLoader_ClientWorld) null : new UIAssetSubSceneLoader_ClientWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__UIAssetSubSceneLoader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IClientNetworkLayer _NetClient
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__NetClient));
        return pointer == System.IntPtr.Zero ? (IClientNetworkLayer) null : new IClientNetworkLayer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__NetClient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ClientBootstrapSystem.ConnectionData ActiveConnectionData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ActiveConnectionData);
        return new ClientBootstrapSystem.ConnectionData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ActiveConnectionData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string ConnectionString
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ConnectionString)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ConnectionString), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppSystem.Guid SessionGuid
    {
      get
      {
        return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_SessionGuid));
      }
      [param: In] set
      {
        *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_SessionGuid)) = value;
      }
    }

    public ClientNetworkData _DefaultNetworkData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__DefaultNetworkData);
        return new ClientNetworkData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientNetworkData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__DefaultNetworkData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientNetworkData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Entity _PacketPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__PacketPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__PacketPrefab)) = value;
      }
    }

    public unsafe ClientCreateData _ClientCreateData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__ClientCreateData));
        return pointer == System.IntPtr.Zero ? (ClientCreateData) null : new ClientCreateData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__ClientCreateData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VFXReplacementSettings _VFXReplacementSettings_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__VFXReplacementSettings_k__BackingField));
        return pointer == System.IntPtr.Zero ? (VFXReplacementSettings) null : new VFXReplacementSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__VFXReplacementSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.Nullable<ClientConnectData> _QueuedConnectRequest
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__QueuedConnectRequest);
        return new Il2CppSystem.Nullable<ClientConnectData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ClientConnectData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__QueuedConnectRequest), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ClientConnectData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public ClientConnectData _LastConnectData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__LastConnectData);
        return new ClientConnectData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientConnectData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__LastConnectData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientConnectData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SetupWorldState _SetupWorldState
    {
      get
      {
        return *(SetupWorldState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__SetupWorldState));
      }
      [param: In] set
      {
        *(SetupWorldState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__SetupWorldState)) = value;
      }
    }

    public unsafe bool _HasBeenConnected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__HasBeenConnected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__HasBeenConnected)) = value;
      }
    }

    public unsafe bool _RequestedDisconnect
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__RequestedDisconnect));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__RequestedDisconnect)) = value;
      }
    }

    public unsafe bool _SetClientStateToRunning
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__SetClientStateToRunning));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__SetClientStateToRunning)) = value;
      }
    }

    public unsafe double _NextConnectionAttempt
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__NextConnectionAttempt));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr__NextConnectionAttempt)) = value;
      }
    }

    public static unsafe double TIME_TO_WAIT_FOR_LOCAL_SERVER_STARTUP
    {
      get
      {
        double localServerStartup;
        IL2CPP.il2cpp_field_static_get_value(ClientBootstrapSystem.NativeFieldInfoPtr_TIME_TO_WAIT_FOR_LOCAL_SERVER_STARTUP, (void*) &localServerStartup);
        return localServerStartup;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientBootstrapSystem.NativeFieldInfoPtr_TIME_TO_WAIT_FOR_LOCAL_SERVER_STARTUP, (void*) &value);
      }
    }

    public static unsafe double RETRY_DELAY
    {
      get
      {
        double retryDelay;
        IL2CPP.il2cpp_field_static_get_value(ClientBootstrapSystem.NativeFieldInfoPtr_RETRY_DELAY, (void*) &retryDelay);
        return retryDelay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientBootstrapSystem.NativeFieldInfoPtr_RETRY_DELAY, (void*) &value);
      }
    }

    public static unsafe int MAX_CONNECT_RETRIES
    {
      get
      {
        int maxConnectRetries;
        IL2CPP.il2cpp_field_static_get_value(ClientBootstrapSystem.NativeFieldInfoPtr_MAX_CONNECT_RETRIES, (void*) &maxConnectRetries);
        return maxConnectRetries;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientBootstrapSystem.NativeFieldInfoPtr_MAX_CONNECT_RETRIES, (void*) &value);
      }
    }

    public unsafe int RetryAttempts
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_RetryAttempts));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_RetryAttempts)) = value;
      }
    }

    public unsafe int ClientLoadProgress
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ClientLoadProgress));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ClientLoadProgress)) = value;
      }
    }

    public unsafe int ClientLoadProgressMax
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ClientLoadProgressMax));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ClientLoadProgressMax)) = value;
      }
    }

    public unsafe GameBootstrap GameBootstrap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_GameBootstrap));
        return pointer == System.IntPtr.Zero ? (GameBootstrap) null : new GameBootstrap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_GameBootstrap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClientState ClientState
    {
      get
      {
        return *(ClientState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ClientState));
      }
      [param: In] set
      {
        *(ClientState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ClientState)) = value;
      }
    }

    public unsafe ConnectionStatusChangeReason DisconnectChangeReason
    {
      get
      {
        return *(ConnectionStatusChangeReason*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_DisconnectChangeReason));
      }
      [param: In] set
      {
        *(ConnectionStatusChangeReason*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_DisconnectChangeReason)) = value;
      }
    }

    public unsafe string DisconnectReasonExtraData
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_DisconnectReasonExtraData)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_DisconnectReasonExtraData), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ServerLoadProgress ServerLoadProgress
    {
      get
      {
        return *(ServerLoadProgress*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ServerLoadProgress));
      }
      [param: In] set
      {
        *(ServerLoadProgress*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ServerLoadProgress)) = value;
      }
    }

    public unsafe VersionMismatchError VersionMismatchError
    {
      get
      {
        return *(VersionMismatchError*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_VersionMismatchError));
      }
      [param: In] set
      {
        *(VersionMismatchError*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_VersionMismatchError)) = value;
      }
    }

    public unsafe HailMessageStruct_Server HailMessageStruct
    {
      get
      {
        return *(HailMessageStruct_Server*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_HailMessageStruct));
      }
      [param: In] set
      {
        *(HailMessageStruct_Server*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_HailMessageStruct)) = value;
      }
    }

    public unsafe int ShaderPreWarmProgress
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ShaderPreWarmProgress));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ShaderPreWarmProgress)) = value;
      }
    }

    public unsafe int ShaderPreWarmMax
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ShaderPreWarmMax));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_ShaderPreWarmMax)) = value;
      }
    }

    public unsafe ClientBootstrapSystem.ShaderPreWarmState PreWarmingShadersState
    {
      get
      {
        return *(ClientBootstrapSystem.ShaderPreWarmState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_PreWarmingShadersState));
      }
      [param: In] set
      {
        *(ClientBootstrapSystem.ShaderPreWarmState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_PreWarmingShadersState)) = value;
      }
    }

    public unsafe int NumFramesSincePreWarmStart
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_NumFramesSincePreWarmStart));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr_NumFramesSincePreWarmStart)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public sealed class ConnectionData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HasConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerName;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryConnectionString;
      private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryConnectionString;

      static ConnectionData()
      {
        Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, nameof (ConnectionData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr);
        ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_HasConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, nameof (HasConnection));
        ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_ServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, nameof (ServerName));
        ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_PrimaryConnectionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, nameof (PrimaryConnectionString));
        ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_SecondaryConnectionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, nameof (SecondaryConnectionString));
      }

      public ConnectionData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ConnectionData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, data));
      }

      public unsafe bool HasConnection
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_HasConnection));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_HasConnection)) = value;
        }
      }

      public unsafe string ServerName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_ServerName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_ServerName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string PrimaryConnectionString
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_PrimaryConnectionString)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_PrimaryConnectionString), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string SecondaryConnectionString
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_SecondaryConnectionString)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.ConnectionData.NativeFieldInfoPtr_SecondaryConnectionString), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    public enum ShaderPreWarmState
    {
      Start,
      Warmup,
      End,
    }

    [ObfuscatedName("ProjectM.ClientBootstrapSystem/<>c__DisplayClass64_0")]
    public sealed class __c__DisplayClass64_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_StatusChangedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass64_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref StatusChangedEvent statusChangedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statusChangedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_StatusChangedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass64_0()
      {
        Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass64_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr);
        ClientBootstrapSystem.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
        ClientBootstrapSystem.__c__DisplayClass64_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr, nameof (entityManager));
        ClientBootstrapSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr, 100675594);
        ClientBootstrapSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_StatusChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr, 100675595);
      }

      public __c__DisplayClass64_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass64_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass64_0>.NativeClassPtr, data));
      }

      public unsafe ClientBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientBootstrapSystem) null : new ClientBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass64_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass64_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ClientBootstrapSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatusChangedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientBootstrapSystem_byref___c__DisplayClass64_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 977761, RefRangeEnd = 977762, XrefRangeStart = 977548, XrefRangeEnd = 977761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref StatusChangedEvent statusChangedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref statusChangedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatusChangedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 975279, RefRangeEnd = 975282, XrefRangeStart = 975279, XrefRangeEnd = 975282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ClientBootstrapSystem.__c__DisplayClass64_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 975283, RefRangeEnd = 975294, XrefRangeStart = 975283, XrefRangeEnd = 975294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ClientBootstrapSystem.__c__DisplayClass64_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977762, XrefRangeEnd = 977772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 977778, RefRangeEnd = 977779, XrefRangeStart = 977772, XrefRangeEnd = 977778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 977780, RefRangeEnd = 977788, XrefRangeStart = 977779, XrefRangeEnd = 977780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ClientBootstrapSystem componentSystem,
        ref ClientBootstrapSystem.__c__DisplayClass64_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientBootstrapSystem_byref___c__DisplayClass64_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientBootstrapSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "<>4__this");
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StatusChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100675596);
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100675597);
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100675598);
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100675600);
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100675601);
        ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientBootstrapSystem_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100675602);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ClientBootstrapSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ClientBootstrapSystem) null : new ClientBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_statusChangedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientBootstrapSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StatusChangedEvent> forParameter_statusChangedEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977540, XrefRangeEnd = 977543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ClientBootstrapSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientBootstrapSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 977547, RefRangeEnd = 977548, XrefRangeStart = 977543, XrefRangeEnd = 977547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_statusChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_statusChangedEvent));
          ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ClientBootstrapSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675603);
          ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675604);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_statusChangedEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<StatusChangedEvent>.StructuralChangeRuntime runtime_statusChangedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_statusChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_statusChangedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientBootstrapSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
