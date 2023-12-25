// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SendPacketOptions
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
  public sealed class SendPacketOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemoteUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SocketId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Channel_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Data_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllowDelayedDelivery_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Reliability_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisableAutoAcceptConnection_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketId_Public_get_Nullable_1_SocketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Channel_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowDelayedDelivery_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Reliability_Public_get_PacketReliability_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisableAutoAcceptConnection_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisableAutoAcceptConnection_Public_set_Void_Boolean_0;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId RemoteUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId> SocketId
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 137664, RefRangeEnd = 137668, XrefRangeStart = 137664, XrefRangeEnd = 137668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_SocketId_Public_get_Nullable_1_SocketId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe byte Channel
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_Channel_Public_get_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.ArraySegment<byte> Data
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_Data_Public_get_ArraySegment_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.ArraySegment<byte>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952269, XrefRangeEnd = 952270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool AllowDelayedDelivery
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_AllowDelayedDelivery_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PacketReliability Reliability
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_Reliability_Public_get_PacketReliability_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PacketReliability*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(7), CachedScanResults(RefRangeStart = 70456, RefRangeEnd = 70463, XrefRangeStart = 70456, XrefRangeEnd = 70463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool DisableAutoAcceptConnection
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_DisableAutoAcceptConnection_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_DisableAutoAcceptConnection_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static SendPacketOptions()
    {
      Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (SendPacketOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr);
      SendPacketOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
      SendPacketOptions.NativeFieldInfoPtr__RemoteUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<RemoteUserId>k__BackingField");
      SendPacketOptions.NativeFieldInfoPtr__SocketId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<SocketId>k__BackingField");
      SendPacketOptions.NativeFieldInfoPtr__Channel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<Channel>k__BackingField");
      SendPacketOptions.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<Data>k__BackingField");
      SendPacketOptions.NativeFieldInfoPtr__AllowDelayedDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<AllowDelayedDelivery>k__BackingField");
      SendPacketOptions.NativeFieldInfoPtr__Reliability_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<Reliability>k__BackingField");
      SendPacketOptions.NativeFieldInfoPtr__DisableAutoAcceptConnection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<DisableAutoAcceptConnection>k__BackingField");
      SendPacketOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669209);
      SendPacketOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669210);
      SendPacketOptions.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669211);
      SendPacketOptions.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669212);
      SendPacketOptions.NativeMethodInfoPtr_get_SocketId_Public_get_Nullable_1_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669213);
      SendPacketOptions.NativeMethodInfoPtr_set_SocketId_Public_set_Void_Nullable_1_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669214);
      SendPacketOptions.NativeMethodInfoPtr_get_Channel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669215);
      SendPacketOptions.NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669216);
      SendPacketOptions.NativeMethodInfoPtr_get_Data_Public_get_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669217);
      SendPacketOptions.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669218);
      SendPacketOptions.NativeMethodInfoPtr_get_AllowDelayedDelivery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669219);
      SendPacketOptions.NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669220);
      SendPacketOptions.NativeMethodInfoPtr_get_Reliability_Public_get_PacketReliability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669221);
      SendPacketOptions.NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669222);
      SendPacketOptions.NativeMethodInfoPtr_get_DisableAutoAcceptConnection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669223);
      SendPacketOptions.NativeMethodInfoPtr_set_DisableAutoAcceptConnection_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100669224);
    }

    public SendPacketOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SendPacketOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, data));
    }

    public unsafe ProductUserId _LocalUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProductUserId _RemoteUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__RemoteUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__RemoteUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId> _SocketId_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__SocketId_k__BackingField);
        return new Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__SocketId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Epic.OnlineServices.P2P.SocketId>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe byte _Channel_k__BackingField
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Channel_k__BackingField));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Channel_k__BackingField)) = value;
      }
    }

    public Il2CppSystem.ArraySegment<byte> _Data_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Data_k__BackingField);
        return new Il2CppSystem.ArraySegment<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ArraySegment<byte>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ArraySegment<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _AllowDelayedDelivery_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__AllowDelayedDelivery_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__AllowDelayedDelivery_k__BackingField)) = value;
      }
    }

    public unsafe PacketReliability _Reliability_k__BackingField
    {
      get
      {
        return *(PacketReliability*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Reliability_k__BackingField));
      }
      [param: In] set
      {
        *(PacketReliability*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Reliability_k__BackingField)) = value;
      }
    }

    public unsafe bool _DisableAutoAcceptConnection_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__DisableAutoAcceptConnection_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__DisableAutoAcceptConnection_k__BackingField)) = value;
      }
    }
  }
}
