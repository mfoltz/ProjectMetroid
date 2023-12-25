// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.GetNextReceivedPacketSizeOptionsInternal
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
  public struct GetNextReceivedPacketSizeOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RequestedChannel;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_Unboxed_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetNextReceivedPacketSizeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_GetNextReceivedPacketSizeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_RequestedChannel;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951239, XrefRangeEnd = 951243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<byte> RequestedChannel
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 951249, RefRangeEnd = 951251, XrefRangeStart = 951243, XrefRangeEnd = 951249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_Unboxed_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 951256, RefRangeEnd = 951257, XrefRangeStart = 951251, XrefRangeEnd = 951256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref GetNextReceivedPacketSizeOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetNextReceivedPacketSizeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951257, XrefRangeEnd = 951268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<GetNextReceivedPacketSizeOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_GetNextReceivedPacketSizeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951268, XrefRangeEnd = 951273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetNextReceivedPacketSizeOptionsInternal()
    {
      Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (GetNextReceivedPacketSizeOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr);
      GetNextReceivedPacketSizeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      GetNextReceivedPacketSizeOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      GetNextReceivedPacketSizeOptionsInternal.NativeFieldInfoPtr_m_RequestedChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, nameof (m_RequestedChannel));
      GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668916);
      GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_Unboxed_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668917);
      GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetNextReceivedPacketSizeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668918);
      GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_GetNextReceivedPacketSizeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668919);
      GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668920);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
