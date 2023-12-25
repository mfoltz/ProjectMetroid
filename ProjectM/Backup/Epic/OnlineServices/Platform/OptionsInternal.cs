// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.OptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.IntegratedPlatform;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OptionsInternal
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
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_Unboxed_1_RTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Options_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Options_0;
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
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972067, XrefRangeEnd = 972071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String SandboxId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972071, XrefRangeEnd = 972075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ClientCredentials ClientCredentials
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972075, XrefRangeEnd = 972081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsServer
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972081, XrefRangeEnd = 972085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String EncryptionKey
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972085, XrefRangeEnd = 972089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OverrideCountryCode
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972089, XrefRangeEnd = 972093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OverrideLocaleCode
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972093, XrefRangeEnd = 972097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DeploymentId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972097, XrefRangeEnd = 972101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CacheDirectory
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972101, XrefRangeEnd = 972105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Epic.OnlineServices.Platform.RTCOptions> RTCOptions
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972105, XrefRangeEnd = 972111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_Unboxed_1_RTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972111, XrefRangeEnd = 972115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 972163, RefRangeEnd = 972164, XrefRangeStart = 972115, XrefRangeEnd = 972163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Options other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Options_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972164, XrefRangeEnd = 972242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<Options> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Options_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972242, XrefRangeEnd = 972258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OptionsInternal()
    {
      Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (OptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr);
      OptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      OptionsInternal.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_Reserved));
      OptionsInternal.NativeFieldInfoPtr_m_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_ProductId));
      OptionsInternal.NativeFieldInfoPtr_m_SandboxId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_SandboxId));
      OptionsInternal.NativeFieldInfoPtr_m_ClientCredentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_ClientCredentials));
      OptionsInternal.NativeFieldInfoPtr_m_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_IsServer));
      OptionsInternal.NativeFieldInfoPtr_m_EncryptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_EncryptionKey));
      OptionsInternal.NativeFieldInfoPtr_m_OverrideCountryCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_OverrideCountryCode));
      OptionsInternal.NativeFieldInfoPtr_m_OverrideLocaleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_OverrideLocaleCode));
      OptionsInternal.NativeFieldInfoPtr_m_DeploymentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_DeploymentId));
      OptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_Flags));
      OptionsInternal.NativeFieldInfoPtr_m_CacheDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_CacheDirectory));
      OptionsInternal.NativeFieldInfoPtr_m_TickBudgetInMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_TickBudgetInMilliseconds));
      OptionsInternal.NativeFieldInfoPtr_m_RTCOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_RTCOptions));
      OptionsInternal.NativeFieldInfoPtr_m_IntegratedPlatformOptionsContainerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_IntegratedPlatformOptionsContainerHandle));
      OptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674735);
      OptionsInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674736);
      OptionsInternal.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674737);
      OptionsInternal.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674738);
      OptionsInternal.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674739);
      OptionsInternal.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674740);
      OptionsInternal.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674741);
      OptionsInternal.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674742);
      OptionsInternal.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674743);
      OptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674744);
      OptionsInternal.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674745);
      OptionsInternal.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674746);
      OptionsInternal.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_Unboxed_1_RTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674747);
      OptionsInternal.NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674748);
      OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674749);
      OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674750);
      OptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100674751);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
