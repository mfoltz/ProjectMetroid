// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.PacketQueueInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PacketQueueInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IncomingPacketQueueCurrentSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IncomingPacketQueueCurrentPacketCount_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutgoingPacketQueueCurrentSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutgoingPacketQueueCurrentPacketCount_k__BackingField;
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
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_PacketQueueInfoInternal_0;
    [FieldOffset(0)]
    public ulong _IncomingPacketQueueMaxSizeBytes_k__BackingField;
    [FieldOffset(8)]
    public ulong _IncomingPacketQueueCurrentSizeBytes_k__BackingField;
    [FieldOffset(16)]
    public ulong _IncomingPacketQueueCurrentPacketCount_k__BackingField;
    [FieldOffset(24)]
    public ulong _OutgoingPacketQueueMaxSizeBytes_k__BackingField;
    [FieldOffset(32)]
    public ulong _OutgoingPacketQueueCurrentSizeBytes_k__BackingField;
    [FieldOffset(40)]
    public ulong _OutgoingPacketQueueCurrentPacketCount_k__BackingField;

    public unsafe ulong IncomingPacketQueueMaxSizeBytes
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong IncomingPacketQueueCurrentSizeBytes
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong IncomingPacketQueueCurrentPacketCount
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OutgoingPacketQueueMaxSizeBytes
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OutgoingPacketQueueCurrentSizeBytes
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OutgoingPacketQueueCurrentPacketCount
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public unsafe void Set(ref PacketQueueInfoInternal other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_PacketQueueInfoInternal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PacketQueueInfo()
    {
      Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (PacketQueueInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr);
      PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<IncomingPacketQueueMaxSizeBytes>k__BackingField");
      PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueCurrentSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<IncomingPacketQueueCurrentSizeBytes>k__BackingField");
      PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueCurrentPacketCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<IncomingPacketQueueCurrentPacketCount>k__BackingField");
      PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<OutgoingPacketQueueMaxSizeBytes>k__BackingField");
      PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueCurrentSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<OutgoingPacketQueueCurrentSizeBytes>k__BackingField");
      PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueCurrentPacketCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<OutgoingPacketQueueCurrentPacketCount>k__BackingField");
      PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669165);
      PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669166);
      PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669167);
      PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669168);
      PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669169);
      PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669170);
      PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669171);
      PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669172);
      PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669173);
      PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669174);
      PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669175);
      PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669176);
      PacketQueueInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_PacketQueueInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100669177);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
