// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.RegisterPeerOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.AntiCheatCommon;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RegisterPeerOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PeerHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientPlatform;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AuthenticationTimeout;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IpAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PeerProductUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AuthenticationTimeout_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_DEPRECATED_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IpAddress_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PeerProductUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterPeerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterPeerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PeerHandle;
    [FieldOffset(16)]
    public AntiCheatCommonClientType m_ClientType;
    [FieldOffset(20)]
    public AntiCheatCommonClientPlatform m_ClientPlatform;
    [FieldOffset(24)]
    public uint m_AuthenticationTimeout;
    [FieldOffset(32)]
    public System.IntPtr m_AccountId_DEPRECATED;
    [FieldOffset(40)]
    public System.IntPtr m_IpAddress;
    [FieldOffset(48)]
    public System.IntPtr m_PeerProductUserId;

    public unsafe System.IntPtr PeerHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientType ClientType
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientPlatform ClientPlatform
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 23499, RefRangeEnd = 23501, XrefRangeStart = 23499, XrefRangeEnd = 23501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint AuthenticationTimeout
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_AuthenticationTimeout_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String AccountId_DEPRECATED
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971334, XrefRangeEnd = 971338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_AccountId_DEPRECATED_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String IpAddress
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971338, XrefRangeEnd = 971342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId PeerProductUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971342, XrefRangeEnd = 971346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_PeerProductUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971358, RefRangeEnd = 971359, XrefRangeStart = 971346, XrefRangeEnd = 971358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref RegisterPeerOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterPeerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971359, XrefRangeEnd = 971387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<RegisterPeerOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterPeerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971387, XrefRangeEnd = 971394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterPeerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RegisterPeerOptionsInternal()
    {
      Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatClient", nameof (RegisterPeerOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr);
      RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_PeerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_PeerHandle));
      RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_ClientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_ClientType));
      RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_ClientPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_ClientPlatform));
      RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_AuthenticationTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_AuthenticationTimeout));
      RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_AccountId_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_AccountId_DEPRECATED));
      RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_IpAddress));
      RegisterPeerOptionsInternal.NativeFieldInfoPtr_m_PeerProductUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, nameof (m_PeerProductUserId));
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674505);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674506);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674507);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_AuthenticationTimeout_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674508);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_AccountId_DEPRECATED_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674509);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674510);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_set_PeerProductUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674511);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674512);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674513);
      RegisterPeerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, 100674514);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterPeerOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
