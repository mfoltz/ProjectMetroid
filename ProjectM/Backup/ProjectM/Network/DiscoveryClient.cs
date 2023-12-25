// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.DiscoveryClient
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using Lidgren.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class DiscoveryClient : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetClient;
    private static readonly System.IntPtr NativeFieldInfoPtr__SendTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_VERSION;
    private static readonly System.IntPtr NativeFieldInfoPtr_FoundServers;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearFoundServers_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendDiscoverMessages_Public_Void_Nullable_Unboxed_1_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendDiscoveryMessages_Public_Void_List_1_ServerInfo_Boolean_Boolean_Nullable_Unboxed_1_UInt64_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetServer_Public_Boolean_String_Int32_byref_ServerDiscoveryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetServer_Public_Boolean_IPAddress_Int32_byref_ServerDiscoveryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetServer_Public_Boolean_IPEndPoint_byref_ServerDiscoveryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1147889, RefRangeEnd = 1147893, XrefRangeStart = 1147864, XrefRangeEnd = 1147889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DiscoveryClient()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1147897, RefRangeEnd = 1147898, XrefRangeStart = 1147893, XrefRangeEnd = 1147897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearFoundServers()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr_ClearFoundServers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147898, XrefRangeEnd = 1147914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendDiscoverMessages(Nullable_Unboxed<ulong> platformId = default (Nullable_Unboxed<ulong>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &platformId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr_SendDiscoverMessages_Public_Void_Nullable_Unboxed_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1147957, RefRangeEnd = 1147960, XrefRangeStart = 1147914, XrefRangeEnd = 1147957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendDiscoveryMessages(
      List<ServerInfo> serverList,
      bool discoverLocalPeers = false,
      bool clearFoundServers = false,
      Nullable_Unboxed<ulong> platformId = default (Nullable_Unboxed<ulong>),
      bool clearRequestedServers = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverList);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &discoverLocalPeers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &clearFoundServers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &platformId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &clearRequestedServers;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr_SendDiscoveryMessages_Public_Void_List_1_ServerInfo_Boolean_Boolean_Nullable_Unboxed_1_UInt64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147960, XrefRangeEnd = 1147965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetServer(string ip, int port, out ServerDiscoveryData serverData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(ip);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr_TryGetServer_Public_Boolean_String_Int32_byref_ServerDiscoveryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerDiscoveryData local = ref serverData;
      System.IntPtr pointer = zero;
      ServerDiscoveryData serverDiscoveryData = pointer == System.IntPtr.Zero ? (ServerDiscoveryData) null : new ServerDiscoveryData(pointer);
      local = serverDiscoveryData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147965, XrefRangeEnd = 1147973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetServer(
      IPAddress ipAdress,
      int port,
      out ServerDiscoveryData serverData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ipAdress);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr_TryGetServer_Public_Boolean_IPAddress_Int32_byref_ServerDiscoveryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerDiscoveryData local = ref serverData;
      System.IntPtr pointer = zero;
      ServerDiscoveryData serverDiscoveryData = pointer == System.IntPtr.Zero ? (ServerDiscoveryData) null : new ServerDiscoveryData(pointer);
      local = serverDiscoveryData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1147977, RefRangeEnd = 1147981, XrefRangeStart = 1147973, XrefRangeEnd = 1147977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetServer(IPEndPoint ipEndPoint, out ServerDiscoveryData serverData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ipEndPoint);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr_TryGetServer_Public_Boolean_IPEndPoint_byref_ServerDiscoveryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerDiscoveryData local = ref serverData;
      System.IntPtr pointer = zero;
      ServerDiscoveryData serverDiscoveryData = pointer == System.IntPtr.Zero ? (ServerDiscoveryData) null : new ServerDiscoveryData(pointer);
      local = serverDiscoveryData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1148023, RefRangeEnd = 1148027, XrefRangeStart = 1147981, XrefRangeEnd = 1148023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148027, XrefRangeEnd = 1148031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Shutdown()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DiscoveryClient.NativeMethodInfoPtr_Shutdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DiscoveryClient()
    {
      Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (DiscoveryClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr);
      DiscoveryClient.NativeFieldInfoPtr__NetClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, nameof (_NetClient));
      DiscoveryClient.NativeFieldInfoPtr__SendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, nameof (_SendTime));
      DiscoveryClient.NativeFieldInfoPtr_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, nameof (VERSION));
      DiscoveryClient.NativeFieldInfoPtr_FoundServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, nameof (FoundServers));
      DiscoveryClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691190);
      DiscoveryClient.NativeMethodInfoPtr_ClearFoundServers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691191);
      DiscoveryClient.NativeMethodInfoPtr_SendDiscoverMessages_Public_Void_Nullable_Unboxed_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691192);
      DiscoveryClient.NativeMethodInfoPtr_SendDiscoveryMessages_Public_Void_List_1_ServerInfo_Boolean_Boolean_Nullable_Unboxed_1_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691193);
      DiscoveryClient.NativeMethodInfoPtr_TryGetServer_Public_Boolean_String_Int32_byref_ServerDiscoveryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691194);
      DiscoveryClient.NativeMethodInfoPtr_TryGetServer_Public_Boolean_IPAddress_Int32_byref_ServerDiscoveryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691195);
      DiscoveryClient.NativeMethodInfoPtr_TryGetServer_Public_Boolean_IPEndPoint_byref_ServerDiscoveryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691196);
      DiscoveryClient.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691197);
      DiscoveryClient.NativeMethodInfoPtr_Shutdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryClient>.NativeClassPtr, 100691198);
    }

    public DiscoveryClient(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetClient _NetClient
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscoveryClient.NativeFieldInfoPtr__NetClient));
        return pointer == System.IntPtr.Zero ? (NetClient) null : new NetClient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DiscoveryClient.NativeFieldInfoPtr__NetClient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double _SendTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscoveryClient.NativeFieldInfoPtr__SendTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscoveryClient.NativeFieldInfoPtr__SendTime)) = value;
      }
    }

    public static unsafe byte VERSION
    {
      get
      {
        byte version;
        IL2CPP.il2cpp_field_static_get_value(DiscoveryClient.NativeFieldInfoPtr_VERSION, (void*) &version);
        return version;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DiscoveryClient.NativeFieldInfoPtr_VERSION, (void*) &value);
      }
    }

    public unsafe Dictionary<IPEndPoint, ServerDiscoveryData> FoundServers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DiscoveryClient.NativeFieldInfoPtr_FoundServers));
        return pointer == System.IntPtr.Zero ? (Dictionary<IPEndPoint, ServerDiscoveryData>) null : new Dictionary<IPEndPoint, ServerDiscoveryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DiscoveryClient.NativeFieldInfoPtr_FoundServers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
