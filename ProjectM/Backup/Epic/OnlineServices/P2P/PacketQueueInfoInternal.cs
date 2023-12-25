// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.PacketQueueInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PacketQueueInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IncomingPacketQueueMaxSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IncomingPacketQueueCurrentSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IncomingPacketQueueCurrentPacketCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OutgoingPacketQueueMaxSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OutgoingPacketQueueCurrentSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OutgoingPacketQueueCurrentPacketCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PacketQueueInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PacketQueueInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PacketQueueInfo_0;
    [FieldOffset(0)]
    public ulong m_IncomingPacketQueueMaxSizeBytes;
    [FieldOffset(8)]
    public ulong m_IncomingPacketQueueCurrentSizeBytes;
    [FieldOffset(16)]
    public ulong m_IncomingPacketQueueCurrentPacketCount;
    [FieldOffset(24)]
    public ulong m_OutgoingPacketQueueMaxSizeBytes;
    [FieldOffset(32)]
    public ulong m_OutgoingPacketQueueCurrentSizeBytes;
    [FieldOffset(40)]
    public ulong m_OutgoingPacketQueueCurrentPacketCount;

    public unsafe ulong IncomingPacketQueueMaxSizeBytes
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong IncomingPacketQueueCurrentSizeBytes
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong IncomingPacketQueueCurrentPacketCount
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OutgoingPacketQueueMaxSizeBytes
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OutgoingPacketQueueCurrentSizeBytes
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OutgoingPacketQueueCurrentPacketCount
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Set(ref PacketQueueInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PacketQueueInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952218, XrefRangeEnd = 952232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<PacketQueueInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PacketQueueInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Get(out PacketQueueInfo output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PacketQueueInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PacketQueueInfoInternal()
    {
      Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (PacketQueueInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr);
      PacketQueueInfoInternal.NativeFieldInfoPtr_m_IncomingPacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_IncomingPacketQueueMaxSizeBytes));
      PacketQueueInfoInternal.NativeFieldInfoPtr_m_IncomingPacketQueueCurrentSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_IncomingPacketQueueCurrentSizeBytes));
      PacketQueueInfoInternal.NativeFieldInfoPtr_m_IncomingPacketQueueCurrentPacketCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_IncomingPacketQueueCurrentPacketCount));
      PacketQueueInfoInternal.NativeFieldInfoPtr_m_OutgoingPacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_OutgoingPacketQueueMaxSizeBytes));
      PacketQueueInfoInternal.NativeFieldInfoPtr_m_OutgoingPacketQueueCurrentSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_OutgoingPacketQueueCurrentSizeBytes));
      PacketQueueInfoInternal.NativeFieldInfoPtr_m_OutgoingPacketQueueCurrentPacketCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_OutgoingPacketQueueCurrentPacketCount));
      PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669178);
      PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669179);
      PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669180);
      PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669181);
      PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669182);
      PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669183);
      PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669184);
      PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669185);
      PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669186);
      PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669187);
      PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669188);
      PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669189);
      PacketQueueInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PacketQueueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669190);
      PacketQueueInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PacketQueueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669191);
      PacketQueueInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669192);
      PacketQueueInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PacketQueueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100669193);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
