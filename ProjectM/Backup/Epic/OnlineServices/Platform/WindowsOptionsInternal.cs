// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.IntegratedPlatform;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WindowsOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Reserved;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SandboxId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientCredentials;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EncryptionKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideCountryCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideLocaleCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DeploymentId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CacheDirectory;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TickBudgetInMilliseconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RTCOptions;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IntegratedPlatformOptionsContainerHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SandboxId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_1_WindowsRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Reserved;
    [FieldOffset(16)]
    public System.IntPtr m_ProductId;
    [FieldOffset(24)]
    public System.IntPtr m_SandboxId;
    [FieldOffset(32)]
    public ClientCredentialsInternal m_ClientCredentials;
    [FieldOffset(48)]
    public int m_IsServer;
    [FieldOffset(56)]
    public System.IntPtr m_EncryptionKey;
    [FieldOffset(64)]
    public System.IntPtr m_OverrideCountryCode;
    [FieldOffset(72)]
    public System.IntPtr m_OverrideLocaleCode;
    [FieldOffset(80)]
    public System.IntPtr m_DeploymentId;
    [FieldOffset(88)]
    public PlatformFlags m_Flags;
    [FieldOffset(96)]
    public System.IntPtr m_CacheDirectory;
    [FieldOffset(104)]
    public uint m_TickBudgetInMilliseconds;
    [FieldOffset(112)]
    public System.IntPtr m_RTCOptions;
    [FieldOffset(120)]
    public System.IntPtr m_IntegratedPlatformOptionsContainerHandle;

    public unsafe System.IntPtr Reserved
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972280, XrefRangeEnd = 972284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String SandboxId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972284, XrefRangeEnd = 972288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ClientCredentials ClientCredentials
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972288, XrefRangeEnd = 972294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsServer
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972294, XrefRangeEnd = 972298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String EncryptionKey
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972298, XrefRangeEnd = 972302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OverrideCountryCode
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972302, XrefRangeEnd = 972306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OverrideLocaleCode
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972306, XrefRangeEnd = 972310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DeploymentId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972310, XrefRangeEnd = 972314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PlatformFlags Flags
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CacheDirectory
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972314, XrefRangeEnd = 972318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint TickBudgetInMilliseconds
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 70661, RefRangeEnd = 70670, XrefRangeStart = 70661, XrefRangeEnd = 70670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<WindowsRTCOptions> RTCOptions
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972318, XrefRangeEnd = 972324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_1_WindowsRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972324, XrefRangeEnd = 972328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 972376, RefRangeEnd = 972377, XrefRangeStart = 972328, XrefRangeEnd = 972376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref WindowsOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972377, XrefRangeEnd = 972455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<WindowsOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972455, XrefRangeEnd = 972471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WindowsOptionsInternal()
    {
      Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (WindowsOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr);
      WindowsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_Reserved));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_ProductId));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_SandboxId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_SandboxId));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_ClientCredentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_ClientCredentials));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_IsServer));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_EncryptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_EncryptionKey));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_OverrideCountryCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_OverrideCountryCode));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_OverrideLocaleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_OverrideLocaleCode));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_DeploymentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_DeploymentId));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_Flags));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_CacheDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_CacheDirectory));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_TickBudgetInMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_TickBudgetInMilliseconds));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_RTCOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_RTCOptions));
      WindowsOptionsInternal.NativeFieldInfoPtr_m_IntegratedPlatformOptionsContainerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, nameof (m_IntegratedPlatformOptionsContainerHandle));
      WindowsOptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674797);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674798);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674799);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674800);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674801);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674802);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674803);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674804);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674805);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674806);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674807);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674808);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_1_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674809);
      WindowsOptionsInternal.NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674810);
      WindowsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674811);
      WindowsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674812);
      WindowsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, 100674813);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
