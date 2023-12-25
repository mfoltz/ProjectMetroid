// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.OnPeerConnectionEstablishedInfoInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct OnPeerConnectionEstablishedInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RemoteUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SocketId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ConnectionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NetworkType;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketId_Public_get_Nullable_1_SocketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ConnectionType_Public_get_ConnectionEstablishedType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ConnectionType_Public_set_Void_ConnectionEstablishedType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NetworkType_Public_get_NetworkConnectionType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NetworkType_Public_set_Void_NetworkConnectionType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnPeerConnectionEstablishedInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnPeerConnectionEstablishedInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnPeerConnectionEstablishedInfo_0;
    [FieldOffset(0)]
    public System.IntPtr m_ClientData;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_RemoteUserId;
    [FieldOffset(24)]
    public System.IntPtr m_SocketId;
    [FieldOffset(32)]
    public ConnectionEstablishedType m_ConnectionType;
    [FieldOffset(36)]
    public NetworkConnectionType m_NetworkType;

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951494, XrefRangeEnd = 951498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951498, XrefRangeEnd = 951502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 951508, RefRangeEnd = 951509, XrefRangeStart = 951502, XrefRangeEnd = 951508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951509, XrefRangeEnd = 951513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId RemoteUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 951519, RefRangeEnd = 951520, XrefRangeStart = 951513, XrefRangeEnd = 951519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951520, XrefRangeEnd = 951524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId> SocketId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951524, XrefRangeEnd = 951530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_SocketId_Public_get_Nullable_1_SocketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951530, XrefRangeEnd = 951536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ConnectionEstablishedType ConnectionType
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_ConnectionType_Public_get_ConnectionEstablishedType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ConnectionEstablishedType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_ConnectionType_Public_set_Void_ConnectionEstablishedType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe NetworkConnectionType NetworkType
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_NetworkType_Public_get_NetworkConnectionType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NetworkConnectionType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_NetworkType_Public_set_Void_NetworkConnectionType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951536, XrefRangeEnd = 951554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref OnPeerConnectionEstablishedInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnPeerConnectionEstablishedInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951554, XrefRangeEnd = 951586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<OnPeerConnectionEstablishedInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnPeerConnectionEstablishedInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951586, XrefRangeEnd = 951593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951593, XrefRangeEnd = 951594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out OnPeerConnectionEstablishedInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnPeerConnectionEstablishedInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref OnPeerConnectionEstablishedInfo local = ref output;
      System.IntPtr pointer = zero;
      OnPeerConnectionEstablishedInfo connectionEstablishedInfo = pointer == System.IntPtr.Zero ? (OnPeerConnectionEstablishedInfo) null : new OnPeerConnectionEstablishedInfo(pointer);
      local = connectionEstablishedInfo;
    }

    static OnPeerConnectionEstablishedInfoInternal()
    {
      Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (OnPeerConnectionEstablishedInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr);
      OnPeerConnectionEstablishedInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      OnPeerConnectionEstablishedInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
      OnPeerConnectionEstablishedInfoInternal.NativeFieldInfoPtr_m_RemoteUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, nameof (m_RemoteUserId));
      OnPeerConnectionEstablishedInfoInternal.NativeFieldInfoPtr_m_SocketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, nameof (m_SocketId));
      OnPeerConnectionEstablishedInfoInternal.NativeFieldInfoPtr_m_ConnectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, nameof (m_ConnectionType));
      OnPeerConnectionEstablishedInfoInternal.NativeFieldInfoPtr_m_NetworkType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, nameof (m_NetworkType));
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669022);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669023);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669024);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669025);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669026);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669027);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669028);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_SocketId_Public_get_Nullable_1_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669029);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669030);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_ConnectionType_Public_get_ConnectionEstablishedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669031);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_ConnectionType_Public_set_Void_ConnectionEstablishedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669032);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_get_NetworkType_Public_get_NetworkConnectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669033);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_set_NetworkType_Public_set_Void_NetworkConnectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669034);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnPeerConnectionEstablishedInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669035);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnPeerConnectionEstablishedInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669036);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669037);
      OnPeerConnectionEstablishedInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnPeerConnectionEstablishedInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, 100669038);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnPeerConnectionEstablishedInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
