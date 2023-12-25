// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsOptions
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
  public sealed class WindowsOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Reserved_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProductId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SandboxId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientCredentials_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsServer_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__EncryptionKey_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OverrideCountryCode_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OverrideLocaleCode_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DeploymentId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Flags_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CacheDirectory_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TickBudgetInMilliseconds_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__RTCOptions_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IntegratedPlatformOptionsContainerHandle_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SandboxId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SandboxId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientCredentials_Public_get_ClientCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EncryptionKey_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideCountryCode_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideLocaleCode_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeploymentId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_PlatformFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CacheDirectory_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TickBudgetInMilliseconds_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RTCOptions_Public_get_Nullable_1_WindowsRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_1_WindowsRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IntegratedPlatformOptionsContainerHandle_Public_get_IntegratedPlatformOptionsContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0;

    public unsafe System.IntPtr Reserved
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_ProductId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String SandboxId
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_SandboxId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ClientCredentials ClientCredentials
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_ClientCredentials_Public_get_ClientCredentials_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new ClientCredentials(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsServer
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 56397, RefRangeEnd = 56398, XrefRangeStart = 56397, XrefRangeEnd = 56398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String EncryptionKey
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_EncryptionKey_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OverrideCountryCode
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 22398, RefRangeEnd = 22405, XrefRangeStart = 22398, XrefRangeEnd = 22405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_OverrideCountryCode_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23675, RefRangeEnd = 23677, XrefRangeStart = 23675, XrefRangeEnd = 23677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OverrideLocaleCode
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22405, RefRangeEnd = 22406, XrefRangeStart = 22405, XrefRangeEnd = 22406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_OverrideLocaleCode_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23672, RefRangeEnd = 23674, XrefRangeStart = 23672, XrefRangeEnd = 23674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DeploymentId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_DeploymentId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PlatformFlags Flags
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22805, RefRangeEnd = 22806, XrefRangeStart = 22805, XrefRangeEnd = 22806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_Flags_Public_get_PlatformFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlatformFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CacheDirectory
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_CacheDirectory_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint TickBudgetInMilliseconds
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_TickBudgetInMilliseconds_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(174), CachedScanResults(RefRangeStart = 95032, RefRangeEnd = 95206, XrefRangeStart = 95032, XrefRangeEnd = 95206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<WindowsRTCOptions> RTCOptions
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_RTCOptions_Public_get_Nullable_1_WindowsRTCOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<WindowsRTCOptions>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972279, XrefRangeEnd = 972280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_1_WindowsRTCOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_get_IntegratedPlatformOptionsContainerHandle_Public_get_IntegratedPlatformOptionsContainer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IntegratedPlatformOptionsContainer) null : new IntegratedPlatformOptionsContainer(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsOptions.NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static WindowsOptions()
    {
      Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (WindowsOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr);
      WindowsOptions.NativeFieldInfoPtr__Reserved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<Reserved>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__ProductId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<ProductId>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__SandboxId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<SandboxId>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__ClientCredentials_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<ClientCredentials>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__IsServer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<IsServer>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__EncryptionKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<EncryptionKey>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__OverrideCountryCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<OverrideCountryCode>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__OverrideLocaleCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<OverrideLocaleCode>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__DeploymentId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<DeploymentId>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__Flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<Flags>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__CacheDirectory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<CacheDirectory>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__TickBudgetInMilliseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<TickBudgetInMilliseconds>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__RTCOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<RTCOptions>k__BackingField");
      WindowsOptions.NativeFieldInfoPtr__IntegratedPlatformOptionsContainerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, "<IntegratedPlatformOptionsContainerHandle>k__BackingField");
      WindowsOptions.NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674769);
      WindowsOptions.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674770);
      WindowsOptions.NativeMethodInfoPtr_get_ProductId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674771);
      WindowsOptions.NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674772);
      WindowsOptions.NativeMethodInfoPtr_get_SandboxId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674773);
      WindowsOptions.NativeMethodInfoPtr_set_SandboxId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674774);
      WindowsOptions.NativeMethodInfoPtr_get_ClientCredentials_Public_get_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674775);
      WindowsOptions.NativeMethodInfoPtr_set_ClientCredentials_Public_set_Void_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674776);
      WindowsOptions.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674777);
      WindowsOptions.NativeMethodInfoPtr_set_IsServer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674778);
      WindowsOptions.NativeMethodInfoPtr_get_EncryptionKey_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674779);
      WindowsOptions.NativeMethodInfoPtr_set_EncryptionKey_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674780);
      WindowsOptions.NativeMethodInfoPtr_get_OverrideCountryCode_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674781);
      WindowsOptions.NativeMethodInfoPtr_set_OverrideCountryCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674782);
      WindowsOptions.NativeMethodInfoPtr_get_OverrideLocaleCode_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674783);
      WindowsOptions.NativeMethodInfoPtr_set_OverrideLocaleCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674784);
      WindowsOptions.NativeMethodInfoPtr_get_DeploymentId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674785);
      WindowsOptions.NativeMethodInfoPtr_set_DeploymentId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674786);
      WindowsOptions.NativeMethodInfoPtr_get_Flags_Public_get_PlatformFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674787);
      WindowsOptions.NativeMethodInfoPtr_set_Flags_Public_set_Void_PlatformFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674788);
      WindowsOptions.NativeMethodInfoPtr_get_CacheDirectory_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674789);
      WindowsOptions.NativeMethodInfoPtr_set_CacheDirectory_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674790);
      WindowsOptions.NativeMethodInfoPtr_get_TickBudgetInMilliseconds_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674791);
      WindowsOptions.NativeMethodInfoPtr_set_TickBudgetInMilliseconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674792);
      WindowsOptions.NativeMethodInfoPtr_get_RTCOptions_Public_get_Nullable_1_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674793);
      WindowsOptions.NativeMethodInfoPtr_set_RTCOptions_Public_set_Void_Nullable_1_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674794);
      WindowsOptions.NativeMethodInfoPtr_get_IntegratedPlatformOptionsContainerHandle_Public_get_IntegratedPlatformOptionsContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674795);
      WindowsOptions.NativeMethodInfoPtr_set_IntegratedPlatformOptionsContainerHandle_Public_set_Void_IntegratedPlatformOptionsContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, 100674796);
    }

    public WindowsOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public WindowsOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowsOptions>.NativeClassPtr, data));
    }

    public unsafe System.IntPtr _Reserved_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__Reserved_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__Reserved_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _ProductId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__ProductId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__ProductId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _SandboxId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__SandboxId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__SandboxId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ClientCredentials _ClientCredentials_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__ClientCredentials_k__BackingField);
        return new ClientCredentials(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientCredentials>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__ClientCredentials_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientCredentials>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _IsServer_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__IsServer_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__IsServer_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _EncryptionKey_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__EncryptionKey_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__EncryptionKey_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _OverrideCountryCode_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__OverrideCountryCode_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__OverrideCountryCode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _OverrideLocaleCode_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__OverrideLocaleCode_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__OverrideLocaleCode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _DeploymentId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__DeploymentId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__DeploymentId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlatformFlags _Flags_k__BackingField
    {
      get
      {
        return *(PlatformFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__Flags_k__BackingField));
      }
      [param: In] set
      {
        *(PlatformFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__Flags_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _CacheDirectory_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__CacheDirectory_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__CacheDirectory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe uint _TickBudgetInMilliseconds_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__TickBudgetInMilliseconds_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__TickBudgetInMilliseconds_k__BackingField)) = value;
      }
    }

    public Il2CppSystem.Nullable<WindowsRTCOptions> _RTCOptions_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__RTCOptions_k__BackingField);
        return new Il2CppSystem.Nullable<WindowsRTCOptions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<WindowsRTCOptions>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__RTCOptions_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<WindowsRTCOptions>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe IntegratedPlatformOptionsContainer _IntegratedPlatformOptionsContainerHandle_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__IntegratedPlatformOptionsContainerHandle_k__BackingField));
        return pointer == System.IntPtr.Zero ? (IntegratedPlatformOptionsContainer) null : new IntegratedPlatformOptionsContainer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsOptions.NativeFieldInfoPtr__IntegratedPlatformOptionsContainerHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
