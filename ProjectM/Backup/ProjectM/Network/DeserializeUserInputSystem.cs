// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.DeserializeUserInputSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public class DeserializeUserInputSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__IncomingUserInputsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PacketBookkeeperSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151948, XrefRangeEnd = 1152008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeserializeUserInputSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152008, XrefRangeEnd = 1152066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeserializeUserInputSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeserializeUserInputSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeserializeUserInputSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeserializeUserInputSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeserializeUserInputSystem()
    {
      Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (DeserializeUserInputSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr);
      DeserializeUserInputSystem.NativeFieldInfoPtr__IncomingUserInputsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, nameof (_IncomingUserInputsQuery));
      DeserializeUserInputSystem.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, nameof (_DestroyBarrier));
      DeserializeUserInputSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      DeserializeUserInputSystem.NativeFieldInfoPtr__PacketBookkeeperSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, nameof (_PacketBookkeeperSystem));
      DeserializeUserInputSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, 100691526);
      DeserializeUserInputSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, 100691527);
      DeserializeUserInputSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, 100691528);
      DeserializeUserInputSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, 100691529);
    }

    public DeserializeUserInputSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _IncomingUserInputsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeUserInputSystem.NativeFieldInfoPtr__IncomingUserInputsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeUserInputSystem.NativeFieldInfoPtr__IncomingUserInputsQuery)) = value;
      }
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeUserInputSystem.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializeUserInputSystem.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeUserInputSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializeUserInputSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PacketBookkeeperSystem _PacketBookkeeperSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeUserInputSystem.NativeFieldInfoPtr__PacketBookkeeperSystem));
        return pointer == System.IntPtr.Zero ? (PacketBookkeeperSystem) null : new PacketBookkeeperSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializeUserInputSystem.NativeFieldInfoPtr__PacketBookkeeperSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DeserializeUserInputJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedUserType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DisconnectedTimerType;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkStateBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_IncomingNetBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UserDestroyedEntityBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_PacketBookkeeperData;
      private static readonly System.IntPtr NativeFieldInfoPtr_IncomingClientMessageType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerNetworkStateType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ControllerType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDestroyedEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetFrameChanged;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetUpToDateUserBitMask;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAbilityBarServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetInteractor;
      private static readonly System.IntPtr NativeFieldInfoPtr_DestroyCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIdMap;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeInput_Private_Void_Int32_byref_ConnectedUser_byref_DisconnectedTimer_byref_ServerNetworkState_byref_Controller_NativeArray_1_Byte_Int32_DynamicBuffer_1_UserEntityNetworkState_DynamicBuffer_1_InputCommandBufferElement_DynamicBuffer_1_UserDestroyedEntityBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandlePacketForUser_Private_Void_Int32_byref_ConnectedUser_DynamicBuffer_1_UserEntityNetworkState_DynamicBuffer_1_UserDestroyedEntityBuffer_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<ConnectedUser> ConnectedUserType;
      [FieldOffset(32)]
      public ComponentTypeHandle<DisconnectedTimer> DisconnectedTimerType;
      [FieldOffset(64)]
      public BufferTypeHandle<UserEntityNetworkState> NetworkStateBufferType;
      [FieldOffset(104)]
      public BufferTypeHandle<InputCommandBufferElement> InputCommandBufferType;
      [FieldOffset(144)]
      public BufferTypeHandle<IncomingNetBuffer> IncomingNetBufferType;
      [FieldOffset(184)]
      public BufferTypeHandle<UserDestroyedEntityBuffer> UserDestroyedEntityBufferType;
      [FieldOffset(224)]
      public PacketBookkeeperData PacketBookkeeperData;
      [FieldOffset(280)]
      public BufferTypeHandle<IncomingClientMessage> IncomingClientMessageType;
      [FieldOffset(320)]
      public ComponentTypeHandle<ServerNetworkState> ServerNetworkStateType;
      [FieldOffset(352)]
      public ComponentTypeHandle<Controller> ControllerType;
      [FieldOffset(384)]
      public ComponentDataFromEntity<DestroyedEntity> GetDestroyedEntity;
      [FieldOffset(416)]
      public ComponentDataFromEntity<FrameChanged> GetFrameChanged;
      [FieldOffset(448)]
      public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
      [FieldOffset(480)]
      public ComponentDataFromEntity<UpToDateUserBitMask> GetUpToDateUserBitMask;
      [FieldOffset(512)]
      public ComponentDataFromEntity<AbilityBar_Server> GetAbilityBarServer;
      [FieldOffset(544)]
      public ComponentDataFromEntity<Interactor> GetInteractor;
      [FieldOffset(576)]
      public EntityCommandBuffer.ParallelWriter DestroyCommandBuffer;
      [FieldOffset(592)]
      public NativeHashMap<NetworkId, Entity> NetworkIdMap;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151677, XrefRangeEnd = 1151758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeUserInputSystem.DeserializeUserInputJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1151836, RefRangeEnd = 1151837, XrefRangeStart = 1151758, XrefRangeEnd = 1151836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void DeserializeInput(
        int chunkIndex,
        [In] ref ConnectedUser connectedUser,
        ref DisconnectedTimer disconnectedTimer,
        ref ServerNetworkState serverNetworkState,
        [In] ref Controller controller,
        NativeArray<byte> byteBuffer,
        int packetSizeBits,
        DynamicBuffer<UserEntityNetworkState> networkStates,
        DynamicBuffer<InputCommandBufferElement> inputCommandBuffer,
        DynamicBuffer<UserDestroyedEntityBuffer> userDestroyedEntities)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[10];
        numPtr[0] = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedUser;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref disconnectedTimer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverNetworkState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &byteBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &packetSizeBits;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &networkStates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &inputCommandBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &userDestroyedEntities;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeUserInputSystem.DeserializeUserInputJob.NativeMethodInfoPtr_DeserializeInput_Private_Void_Int32_byref_ConnectedUser_byref_DisconnectedTimer_byref_ServerNetworkState_byref_Controller_NativeArray_1_Byte_Int32_DynamicBuffer_1_UserEntityNetworkState_DynamicBuffer_1_InputCommandBufferElement_DynamicBuffer_1_UserDestroyedEntityBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1151947, RefRangeEnd = 1151948, XrefRangeStart = 1151837, XrefRangeEnd = 1151947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandlePacketForUser(
        int chunkIndex,
        [In] ref ConnectedUser connectedUser,
        DynamicBuffer<UserEntityNetworkState> networkStates,
        DynamicBuffer<UserDestroyedEntityBuffer> userDestroyedEntities,
        int packetServerFrame)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedUser;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &networkStates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &userDestroyedEntities;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &packetServerFrame;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeUserInputSystem.DeserializeUserInputJob.NativeMethodInfoPtr_HandlePacketForUser_Private_Void_Int32_byref_ConnectedUser_DynamicBuffer_1_UserEntityNetworkState_DynamicBuffer_1_UserDestroyedEntityBuffer_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DeserializeUserInputJob()
      {
        Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeUserInputSystem>.NativeClassPtr, nameof (DeserializeUserInputJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr);
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_ConnectedUserType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (ConnectedUserType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_DisconnectedTimerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (DisconnectedTimerType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_NetworkStateBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (NetworkStateBufferType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_InputCommandBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (InputCommandBufferType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_IncomingNetBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (IncomingNetBufferType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_UserDestroyedEntityBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (UserDestroyedEntityBufferType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_PacketBookkeeperData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (PacketBookkeeperData));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_IncomingClientMessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (IncomingClientMessageType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_ServerNetworkStateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (ServerNetworkStateType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_ControllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (ControllerType));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_GetDestroyedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (GetDestroyedEntity));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_GetFrameChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (GetFrameChanged));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (GetPrefabGUID));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_GetUpToDateUserBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (GetUpToDateUserBitMask));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_GetAbilityBarServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (GetAbilityBarServer));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_GetInteractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (GetInteractor));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_DestroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (DestroyCommandBuffer));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeFieldInfoPtr_NetworkIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, nameof (NetworkIdMap));
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, 100691530);
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeMethodInfoPtr_DeserializeInput_Private_Void_Int32_byref_ConnectedUser_byref_DisconnectedTimer_byref_ServerNetworkState_byref_Controller_NativeArray_1_Byte_Int32_DynamicBuffer_1_UserEntityNetworkState_DynamicBuffer_1_InputCommandBufferElement_DynamicBuffer_1_UserDestroyedEntityBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, 100691531);
        DeserializeUserInputSystem.DeserializeUserInputJob.NativeMethodInfoPtr_HandlePacketForUser_Private_Void_Int32_byref_ConnectedUser_DynamicBuffer_1_UserEntityNetworkState_DynamicBuffer_1_UserDestroyedEntityBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, 100691532);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeUserInputSystem.DeserializeUserInputJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
