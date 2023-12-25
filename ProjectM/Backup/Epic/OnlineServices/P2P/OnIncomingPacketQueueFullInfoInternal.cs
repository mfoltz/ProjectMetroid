// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.OnIncomingPacketQueueFullInfoInternal
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
  public struct OnIncomingPacketQueueFullInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PacketQueueMaxSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PacketQueueCurrentSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OverflowPacketLocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OverflowPacketChannel;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OverflowPacketSizeBytes;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketChannel_Public_set_Void_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnIncomingPacketQueueFullInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnIncomingPacketQueueFullInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnIncomingPacketQueueFullInfo_0;
    [FieldOffset(0)]
    public System.IntPtr m_ClientData;
    [FieldOffset(8)]
    public ulong m_PacketQueueMaxSizeBytes;
    [FieldOffset(16)]
    public ulong m_PacketQueueCurrentSizeBytes;
    [FieldOffset(24)]
    public System.IntPtr m_OverflowPacketLocalUserId;
    [FieldOffset(32)]
    public byte m_OverflowPacketChannel;
    [FieldOffset(36)]
    public uint m_OverflowPacketSizeBytes;

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951414, XrefRangeEnd = 951418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951418, XrefRangeEnd = 951422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ulong PacketQueueMaxSizeBytes
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong PacketQueueCurrentSizeBytes
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId OverflowPacketLocalUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 951428, RefRangeEnd = 951429, XrefRangeStart = 951422, XrefRangeEnd = 951428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951429, XrefRangeEnd = 951433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe byte OverflowPacketChannel
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_OverflowPacketChannel_Public_set_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint OverflowPacketSizeBytes
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951433, XrefRangeEnd = 951441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref OnIncomingPacketQueueFullInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnIncomingPacketQueueFullInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951441, XrefRangeEnd = 951463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<OnIncomingPacketQueueFullInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnIncomingPacketQueueFullInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951463, XrefRangeEnd = 951468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951468, XrefRangeEnd = 951469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out OnIncomingPacketQueueFullInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnIncomingPacketQueueFullInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref OnIncomingPacketQueueFullInfo local = ref output;
      System.IntPtr pointer = zero;
      OnIncomingPacketQueueFullInfo packetQueueFullInfo = pointer == System.IntPtr.Zero ? (OnIncomingPacketQueueFullInfo) null : new OnIncomingPacketQueueFullInfo(pointer);
      local = packetQueueFullInfo;
    }

    static OnIncomingPacketQueueFullInfoInternal()
    {
      Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (OnIncomingPacketQueueFullInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr);
      OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_PacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_PacketQueueMaxSizeBytes));
      OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_PacketQueueCurrentSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_PacketQueueCurrentSizeBytes));
      OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_OverflowPacketLocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_OverflowPacketLocalUserId));
      OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_OverflowPacketChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_OverflowPacketChannel));
      OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_OverflowPacketSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_OverflowPacketSizeBytes));
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668983);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668984);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668985);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668986);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668987);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668988);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668989);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668990);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668991);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668992);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_OverflowPacketChannel_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668993);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668994);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668995);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnIncomingPacketQueueFullInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668996);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnIncomingPacketQueueFullInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668997);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668998);
      OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnIncomingPacketQueueFullInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668999);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
