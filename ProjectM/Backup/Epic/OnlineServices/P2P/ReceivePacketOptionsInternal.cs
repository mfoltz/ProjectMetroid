// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.ReceivePacketOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReceivePacketOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxDataSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RequestedChannel;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxDataSizeBytes_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_Unboxed_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceivePacketOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceivePacketOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public uint m_MaxDataSizeBytes;
    [FieldOffset(24)]
    public System.IntPtr m_RequestedChannel;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952233, XrefRangeEnd = 952237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint MaxDataSizeBytes
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_MaxDataSizeBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<byte> RequestedChannel
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 952243, RefRangeEnd = 952245, XrefRangeStart = 952237, XrefRangeEnd = 952243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_Unboxed_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 952250, RefRangeEnd = 952251, XrefRangeStart = 952245, XrefRangeEnd = 952250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ReceivePacketOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceivePacketOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952251, XrefRangeEnd = 952264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<ReceivePacketOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceivePacketOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952264, XrefRangeEnd = 952269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReceivePacketOptionsInternal()
    {
      Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (ReceivePacketOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr);
      ReceivePacketOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      ReceivePacketOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      ReceivePacketOptionsInternal.NativeFieldInfoPtr_m_MaxDataSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, nameof (m_MaxDataSizeBytes));
      ReceivePacketOptionsInternal.NativeFieldInfoPtr_m_RequestedChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, nameof (m_RequestedChannel));
      ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100669203);
      ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_MaxDataSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100669204);
      ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_Unboxed_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100669205);
      ReceivePacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceivePacketOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100669206);
      ReceivePacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceivePacketOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100669207);
      ReceivePacketOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100669208);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
