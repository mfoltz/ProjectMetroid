// Decompiled with JetBrains decompiler
// Type: NetworkEvents_Serialize
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM;
using ProjectM.Network;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
public static class NetworkEvents_Serialize : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SerializeNetworkEvent_Public_Static_Void_EntityManager_NetworkEventType_byref_NetBufferOut_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SerializeEvent_Private_Static_Void_EntityManager_NetworkEventType_byref_NetBufferOut_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeNetworkEvent_Public_Static_Void_EntityManager_EntityCommandBuffer_byref_NetBufferIn_byref_DeserializeNetworkEventParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeEvent_Private_Static_Void_EntityManager_EntityCommandBuffer_byref_NetBufferIn_byref_DeserializeNetworkEventParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateEvent_Private_Static_Boolean_EntityCommandBuffer_NetworkEventType_T_Boolean_Boolean_Boolean_byref_DeserializeNetworkEventParams_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_EntityManager_byref___c__DisplayClass4_0_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 918676, RefRangeEnd = 918678, XrefRangeStart = 918675, XrefRangeEnd = 918676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SerializeNetworkEvent(
    EntityManager entityManager,
    NetworkEventType networkEventType,
    ref NetBufferOut netBuffer,
    Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &networkEventType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NetworkEvents_Serialize.NativeMethodInfoPtr_SerializeNetworkEvent_Public_Static_Void_EntityManager_NetworkEventType_byref_NetBufferOut_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 919158, RefRangeEnd = 919159, XrefRangeStart = 918678, XrefRangeEnd = 919158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SerializeEvent(
    EntityManager entityManager,
    NetworkEventType networkEventType,
    ref NetBufferOut netBuffer,
    Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &networkEventType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NetworkEvents_Serialize.NativeMethodInfoPtr_SerializeEvent_Private_Static_Void_EntityManager_NetworkEventType_byref_NetBufferOut_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 919160, RefRangeEnd = 919162, XrefRangeStart = 919159, XrefRangeEnd = 919160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeserializeNetworkEvent(
    EntityManager entityManager,
    EntityCommandBuffer commandBuffer,
    ref NetBufferIn netBuffer,
    ref NetworkEvents_Serialize.DeserializeNetworkEventParams eventParams)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventParams;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NetworkEvents_Serialize.NativeMethodInfoPtr_DeserializeNetworkEvent_Public_Static_Void_EntityManager_EntityCommandBuffer_byref_NetBufferIn_byref_DeserializeNetworkEventParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921247, RefRangeEnd = 921248, XrefRangeStart = 919162, XrefRangeEnd = 921247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeserializeEvent(
    EntityManager entityManager,
    EntityCommandBuffer commandBuffer,
    ref NetBufferIn netBuffer,
    ref NetworkEvents_Serialize.DeserializeNetworkEventParams eventParams)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventParams;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NetworkEvents_Serialize.NativeMethodInfoPtr_DeserializeEvent_Private_Static_Void_EntityManager_EntityCommandBuffer_byref_NetBufferIn_byref_DeserializeNetworkEventParams_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921257, RefRangeEnd = 921258, XrefRangeStart = 921248, XrefRangeEnd = 921257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryCreateEvent<T>(
    EntityCommandBuffer commandBuffer,
    NetworkEventType networkEventType,
    T eventData,
    bool hasSufficientAdminLevel,
    bool isServerToClientEvent,
    bool isClientToServerEvent,
    ref NetworkEvents_Serialize.DeserializeNetworkEventParams eventParams,
    bool addHandleClientDebugEvent = false,
    bool addHandleClientAdminEvent = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) &commandBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &networkEventType;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) eventData;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref eventData;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hasSufficientAdminLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isServerToClientEvent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &isClientToServerEvent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &addHandleClientDebugEvent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &addHandleClientAdminEvent;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NetworkEvents_Serialize.MethodInfoStoreGeneric_TryCreateEvent_Private_Static_Boolean_EntityCommandBuffer_NetworkEventType_T_Boolean_Boolean_Boolean_byref_DeserializeNetworkEventParams_Boolean_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921296, RefRangeEnd = 921297, XrefRangeStart = 921258, XrefRangeEnd = 921296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Internal_Static_Void_EntityManager_byref___c__DisplayClass4_0_0(
    EntityManager entityManager,
    ref NetworkEvents_Serialize.__c__DisplayClass4_0 _param1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref _param1;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NetworkEvents_Serialize.NativeMethodInfoPtr_Method_Internal_Static_Void_EntityManager_byref___c__DisplayClass4_0_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NetworkEvents_Serialize()
  {
    Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (NetworkEvents_Serialize));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr);
    NetworkEvents_Serialize.NativeMethodInfoPtr_SerializeNetworkEvent_Public_Static_Void_EntityManager_NetworkEventType_byref_NetBufferOut_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr, 100663664);
    NetworkEvents_Serialize.NativeMethodInfoPtr_SerializeEvent_Private_Static_Void_EntityManager_NetworkEventType_byref_NetBufferOut_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr, 100663665);
    NetworkEvents_Serialize.NativeMethodInfoPtr_DeserializeNetworkEvent_Public_Static_Void_EntityManager_EntityCommandBuffer_byref_NetBufferIn_byref_DeserializeNetworkEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr, 100663666);
    NetworkEvents_Serialize.NativeMethodInfoPtr_DeserializeEvent_Private_Static_Void_EntityManager_EntityCommandBuffer_byref_NetBufferIn_byref_DeserializeNetworkEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr, 100663667);
    NetworkEvents_Serialize.NativeMethodInfoPtr_TryCreateEvent_Private_Static_Boolean_EntityCommandBuffer_NetworkEventType_T_Boolean_Boolean_Boolean_byref_DeserializeNetworkEventParams_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr, 100663668);
    NetworkEvents_Serialize.NativeMethodInfoPtr_Method_Internal_Static_Void_EntityManager_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr, 100663669);
  }

  public NetworkEvents_Serialize(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DeserializeNetworkEventParams
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FromCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdminUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowAdminEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdminOnlyDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_EveryoneIsAdmin;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowServerToClientEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowClientToServerEvents;
    [FieldOffset(0)]
    public FromCharacter FromCharacter;
    [FieldOffset(16)]
    public int FromUserIndex;
    [FieldOffset(20)]
    public AdminUser AdminUser;
    [FieldOffset(28)]
    public bool AllowDebugEvents;
    [FieldOffset(29)]
    public bool AllowAdminEvents;
    [FieldOffset(30)]
    public bool AdminOnlyDebugEvents;
    [FieldOffset(31)]
    public bool EveryoneIsAdmin;
    [FieldOffset(32)]
    public bool AllowServerToClientEvents;
    [FieldOffset(33)]
    public bool AllowClientToServerEvents;

    static DeserializeNetworkEventParams()
    {
      Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr, nameof (DeserializeNetworkEventParams));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr);
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_FromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (FromCharacter));
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_FromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (FromUserIndex));
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_AdminUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (AdminUser));
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_AllowDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (AllowDebugEvents));
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_AllowAdminEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (AllowAdminEvents));
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_AdminOnlyDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (AdminOnlyDebugEvents));
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_EveryoneIsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (EveryoneIsAdmin));
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_AllowServerToClientEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (AllowServerToClientEvents));
      NetworkEvents_Serialize.DeserializeNetworkEventParams.NativeFieldInfoPtr_AllowClientToServerEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, nameof (AllowClientToServerEvents));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkEvents_Serialize.DeserializeNetworkEventParams>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("NetworkEvents_Serialize/<>c__DisplayClass4_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass4_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
    [FieldOffset(0)]
    public EntityCommandBuffer commandBuffer;

    static __c__DisplayClass4_0()
    {
      Il2CppClassPointerStore<NetworkEvents_Serialize.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr, "<>c__DisplayClass4_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkEvents_Serialize.__c__DisplayClass4_0>.NativeClassPtr);
      NetworkEvents_Serialize.__c__DisplayClass4_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvents_Serialize.__c__DisplayClass4_0>.NativeClassPtr, nameof (commandBuffer));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkEvents_Serialize.__c__DisplayClass4_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  private sealed class MethodInfoStoreGeneric_TryCreateEvent_Private_Static_Boolean_EntityCommandBuffer_NetworkEventType_T_Boolean_Boolean_Boolean_byref_DeserializeNetworkEventParams_Boolean_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NetworkEvents_Serialize.NativeMethodInfoPtr_TryCreateEvent_Private_Static_Boolean_EntityCommandBuffer_NetworkEventType_T_Boolean_Boolean_Boolean_byref_DeserializeNetworkEventParams_Boolean_Boolean_0, Il2CppClassPointerStore<NetworkEvents_Serialize>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
