// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.ConnectInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect
{
  public sealed class ConnectInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyauthexpirationApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyidtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccountidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccounttypeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyproductuserexternalaccountbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyproductuserinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatedeviceidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatedeviceidDevicemodelMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateuserApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CredentialsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletedeviceidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExternalAccountIdMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExternalaccountinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetexternalaccountmappingApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetexternalaccountmappingsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetproductuserexternalaccountcountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetproductuseridmappingApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinkaccountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoginApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnauthexpirationcallbackApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryexternalaccountmappingsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryexternalaccountmappingsMaxAccountIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryproductuseridmappingsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeUndefined;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransferdeviceidaccountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlinkaccountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserlogininfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserlogininfoDisplaynameMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_VerifyidtokenApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAuthExpiration_Public_UInt64_byref_AddNotifyAuthExpirationOptions_Object_OnAuthExpirationCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_byref_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyIdToken_Public_Result_byref_CopyIdTokenOptions_byref_Nullable_1_IdToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountId_Public_Result_byref_CopyProductUserExternalAccountByAccountIdOptions_byref_Nullable_1_ExternalAccountInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountType_Public_Result_byref_CopyProductUserExternalAccountByAccountTypeOptions_byref_Nullable_1_ExternalAccountInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyProductUserExternalAccountByIndex_Public_Result_byref_CopyProductUserExternalAccountByIndexOptions_byref_Nullable_1_ExternalAccountInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyProductUserInfo_Public_Result_byref_CopyProductUserInfoOptions_byref_Nullable_1_ExternalAccountInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDeviceId_Public_Void_byref_CreateDeviceIdOptions_Object_OnCreateDeviceIdCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateUser_Public_Void_byref_CreateUserOptions_Object_OnCreateUserCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDeviceId_Public_Void_byref_DeleteDeviceIdOptions_Object_OnDeleteDeviceIdCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExternalAccountMapping_Public_ProductUserId_byref_GetExternalAccountMappingsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLoggedInUserByIndex_Public_ProductUserId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLoggedInUsersCount_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProductUserExternalAccountCount_Public_UInt32_byref_GetProductUserExternalAccountCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProductUserIdMapping_Public_Result_byref_GetProductUserIdMappingOptions_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LinkAccount_Public_Void_byref_LinkAccountOptions_Object_OnLinkAccountCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Login_Public_Void_byref_LoginOptions_Object_OnLoginCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryExternalAccountMappings_Public_Void_byref_QueryExternalAccountMappingsOptions_Object_OnQueryExternalAccountMappingsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryProductUserIdMappings_Public_Void_byref_QueryProductUserIdMappingsOptions_Object_OnQueryProductUserIdMappingsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAuthExpiration_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TransferDeviceIdAccount_Public_Void_byref_TransferDeviceIdAccountOptions_Object_OnTransferDeviceIdAccountCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlinkAccount_Public_Void_byref_UnlinkAccountOptions_Object_OnUnlinkAccountCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIdToken_Public_Void_byref_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAuthExpirationCallbackInternalImplementation_Internal_Static_Void_byref_AuthExpirationCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateDeviceIdCallbackInternalImplementation_Internal_Static_Void_byref_CreateDeviceIdCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_byref_CreateUserCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteDeviceIdCallbackInternalImplementation_Internal_Static_Void_byref_DeleteDeviceIdCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_LinkAccountCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_byref_LoginCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_LoginStatusChangedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryExternalAccountMappingsCallbackInternalImplementation_Internal_Static_Void_byref_QueryExternalAccountMappingsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryProductUserIdMappingsCallbackInternalImplementation_Internal_Static_Void_byref_QueryProductUserIdMappingsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnTransferDeviceIdAccountCallbackInternalImplementation_Internal_Static_Void_byref_TransferDeviceIdAccountCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUnlinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_UnlinkAccountCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_VerifyIdTokenCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConnectInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 964779, RefRangeEnd = 964780, XrefRangeStart = 964759, XrefRangeEnd = 964779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyAuthExpiration(
      ref AddNotifyAuthExpirationOptions options,
      Il2CppSystem.Object clientData,
      OnAuthExpirationCallback notification)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_AddNotifyAuthExpiration_Public_UInt64_byref_AddNotifyAuthExpirationOptions_Object_OnAuthExpirationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964780, XrefRangeEnd = 964800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyLoginStatusChanged(
      ref AddNotifyLoginStatusChangedOptions options,
      Il2CppSystem.Object clientData,
      OnLoginStatusChangedCallback notification)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_byref_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964800, XrefRangeEnd = 964817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyIdToken(
      ref CopyIdTokenOptions options,
      out Il2CppSystem.Nullable<IdToken> outIdToken)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyIdToken_Public_Result_byref_CopyIdTokenOptions_byref_Nullable_1_IdToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<IdToken> local = ref outIdToken;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<IdToken>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964817, XrefRangeEnd = 964831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyProductUserExternalAccountByAccountId(
      ref CopyProductUserExternalAccountByAccountIdOptions options,
      out Il2CppSystem.Nullable<ExternalAccountInfo> outExternalAccountInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountId_Public_Result_byref_CopyProductUserExternalAccountByAccountIdOptions_byref_Nullable_1_ExternalAccountInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ExternalAccountInfo> local = ref outExternalAccountInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ExternalAccountInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964831, XrefRangeEnd = 964848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyProductUserExternalAccountByAccountType(
      ref CopyProductUserExternalAccountByAccountTypeOptions options,
      out Il2CppSystem.Nullable<ExternalAccountInfo> outExternalAccountInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountType_Public_Result_byref_CopyProductUserExternalAccountByAccountTypeOptions_byref_Nullable_1_ExternalAccountInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ExternalAccountInfo> local = ref outExternalAccountInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ExternalAccountInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964848, XrefRangeEnd = 964865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyProductUserExternalAccountByIndex(
      ref CopyProductUserExternalAccountByIndexOptions options,
      out Il2CppSystem.Nullable<ExternalAccountInfo> outExternalAccountInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByIndex_Public_Result_byref_CopyProductUserExternalAccountByIndexOptions_byref_Nullable_1_ExternalAccountInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ExternalAccountInfo> local = ref outExternalAccountInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ExternalAccountInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964865, XrefRangeEnd = 964882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyProductUserInfo(
      ref CopyProductUserInfoOptions options,
      out Il2CppSystem.Nullable<ExternalAccountInfo> outExternalAccountInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CopyProductUserInfo_Public_Result_byref_CopyProductUserInfoOptions_byref_Nullable_1_ExternalAccountInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ExternalAccountInfo> local = ref outExternalAccountInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ExternalAccountInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964882, XrefRangeEnd = 964901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDeviceId(
      ref CreateDeviceIdOptions options,
      Il2CppSystem.Object clientData,
      OnCreateDeviceIdCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CreateDeviceId_Public_Void_byref_CreateDeviceIdOptions_Object_OnCreateDeviceIdCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964901, XrefRangeEnd = 964920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateUser(
      ref CreateUserOptions options,
      Il2CppSystem.Object clientData,
      OnCreateUserCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_CreateUser_Public_Void_byref_CreateUserOptions_Object_OnCreateUserCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964920, XrefRangeEnd = 964939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeleteDeviceId(
      ref DeleteDeviceIdOptions options,
      Il2CppSystem.Object clientData,
      OnDeleteDeviceIdCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_DeleteDeviceId_Public_Void_byref_DeleteDeviceIdOptions_Object_OnDeleteDeviceIdCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 964950, RefRangeEnd = 964951, XrefRangeStart = 964939, XrefRangeEnd = 964950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProductUserId GetExternalAccountMapping(
      ref GetExternalAccountMappingsOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetExternalAccountMapping_Public_ProductUserId_byref_GetExternalAccountMappingsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 964958, RefRangeEnd = 964964, XrefRangeStart = 964951, XrefRangeEnd = 964958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProductUserId GetLoggedInUserByIndex(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetLoggedInUserByIndex_Public_ProductUserId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964964, XrefRangeEnd = 964965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetLoggedInUsersCount()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetLoggedInUsersCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964965, XrefRangeEnd = 964971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LoginStatus GetLoginStatus(ProductUserId localUserId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LoginStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964971, XrefRangeEnd = 964979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetProductUserExternalAccountCount(
      ref GetProductUserExternalAccountCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetProductUserExternalAccountCount_Public_UInt32_byref_GetProductUserExternalAccountCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964979, XrefRangeEnd = 964990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetProductUserIdMapping(
      ref GetProductUserIdMappingOptions options,
      out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_GetProductUserIdMapping_Public_Result_byref_GetProductUserIdMappingOptions_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964990, XrefRangeEnd = 965009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LinkAccount(
      ref LinkAccountOptions options,
      Il2CppSystem.Object clientData,
      OnLinkAccountCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_LinkAccount_Public_Void_byref_LinkAccountOptions_Object_OnLinkAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 965028, RefRangeEnd = 965029, XrefRangeStart = 965009, XrefRangeEnd = 965028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Login(
      ref LoginOptions options,
      Il2CppSystem.Object clientData,
      OnLoginCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_Login_Public_Void_byref_LoginOptions_Object_OnLoginCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 965048, RefRangeEnd = 965049, XrefRangeStart = 965029, XrefRangeEnd = 965048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryExternalAccountMappings(
      ref QueryExternalAccountMappingsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryExternalAccountMappingsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_QueryExternalAccountMappings_Public_Void_byref_QueryExternalAccountMappingsOptions_Object_OnQueryExternalAccountMappingsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965049, XrefRangeEnd = 965068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryProductUserIdMappings(
      ref QueryProductUserIdMappingsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryProductUserIdMappingsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_QueryProductUserIdMappings_Public_Void_byref_QueryProductUserIdMappingsOptions_Object_OnQueryProductUserIdMappingsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 965073, RefRangeEnd = 965075, XrefRangeStart = 965068, XrefRangeEnd = 965073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyAuthExpiration(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_RemoveNotifyAuthExpiration_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965075, XrefRangeEnd = 965080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyLoginStatusChanged(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965080, XrefRangeEnd = 965099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TransferDeviceIdAccount(
      ref TransferDeviceIdAccountOptions options,
      Il2CppSystem.Object clientData,
      OnTransferDeviceIdAccountCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_TransferDeviceIdAccount_Public_Void_byref_TransferDeviceIdAccountOptions_Object_OnTransferDeviceIdAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965099, XrefRangeEnd = 965118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlinkAccount(
      ref UnlinkAccountOptions options,
      Il2CppSystem.Object clientData,
      OnUnlinkAccountCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_UnlinkAccount_Public_Void_byref_UnlinkAccountOptions_Object_OnUnlinkAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965118, XrefRangeEnd = 965137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void VerifyIdToken(
      ref VerifyIdTokenOptions options,
      Il2CppSystem.Object clientData,
      OnVerifyIdTokenCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_VerifyIdToken_Public_Void_byref_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965137, XrefRangeEnd = 965144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAuthExpirationCallbackInternalImplementation(
      ref AuthExpirationCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnAuthExpirationCallbackInternalImplementation_Internal_Static_Void_byref_AuthExpirationCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965144, XrefRangeEnd = 965151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnCreateDeviceIdCallbackInternalImplementation(
      ref CreateDeviceIdCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnCreateDeviceIdCallbackInternalImplementation_Internal_Static_Void_byref_CreateDeviceIdCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965151, XrefRangeEnd = 965158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnCreateUserCallbackInternalImplementation(
      ref CreateUserCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_byref_CreateUserCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965158, XrefRangeEnd = 965165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDeleteDeviceIdCallbackInternalImplementation(
      ref DeleteDeviceIdCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnDeleteDeviceIdCallbackInternalImplementation_Internal_Static_Void_byref_DeleteDeviceIdCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965165, XrefRangeEnd = 965172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLinkAccountCallbackInternalImplementation(
      ref LinkAccountCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_LinkAccountCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965172, XrefRangeEnd = 965179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLoginCallbackInternalImplementation(
      ref LoginCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_byref_LoginCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965179, XrefRangeEnd = 965186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLoginStatusChangedCallbackInternalImplementation(
      ref LoginStatusChangedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_LoginStatusChangedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965186, XrefRangeEnd = 965193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryExternalAccountMappingsCallbackInternalImplementation(
      ref QueryExternalAccountMappingsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnQueryExternalAccountMappingsCallbackInternalImplementation_Internal_Static_Void_byref_QueryExternalAccountMappingsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965193, XrefRangeEnd = 965200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryProductUserIdMappingsCallbackInternalImplementation(
      ref QueryProductUserIdMappingsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnQueryProductUserIdMappingsCallbackInternalImplementation_Internal_Static_Void_byref_QueryProductUserIdMappingsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965200, XrefRangeEnd = 965207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnTransferDeviceIdAccountCallbackInternalImplementation(
      ref TransferDeviceIdAccountCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnTransferDeviceIdAccountCallbackInternalImplementation_Internal_Static_Void_byref_TransferDeviceIdAccountCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965207, XrefRangeEnd = 965214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUnlinkAccountCallbackInternalImplementation(
      ref UnlinkAccountCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnUnlinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_UnlinkAccountCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965214, XrefRangeEnd = 965221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnVerifyIdTokenCallbackInternalImplementation(
      ref VerifyIdTokenCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectInterface.NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_VerifyIdTokenCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConnectInterface()
    {
      Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (ConnectInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr);
      ConnectInterface.NativeFieldInfoPtr_AddnotifyauthexpirationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (AddnotifyauthexpirationApiLatest));
      ConnectInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (AddnotifyloginstatuschangedApiLatest));
      ConnectInterface.NativeFieldInfoPtr_CopyidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyidtokenApiLatest));
      ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccountidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyproductuserexternalaccountbyaccountidApiLatest));
      ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccounttypeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyproductuserexternalaccountbyaccounttypeApiLatest));
      ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyproductuserexternalaccountbyindexApiLatest));
      ConnectInterface.NativeFieldInfoPtr_CopyproductuserinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CopyproductuserinfoApiLatest));
      ConnectInterface.NativeFieldInfoPtr_CreatedeviceidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CreatedeviceidApiLatest));
      ConnectInterface.NativeFieldInfoPtr_CreatedeviceidDevicemodelMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CreatedeviceidDevicemodelMaxLength));
      ConnectInterface.NativeFieldInfoPtr_CreateuserApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CreateuserApiLatest));
      ConnectInterface.NativeFieldInfoPtr_CredentialsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (CredentialsApiLatest));
      ConnectInterface.NativeFieldInfoPtr_DeletedeviceidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (DeletedeviceidApiLatest));
      ConnectInterface.NativeFieldInfoPtr_ExternalAccountIdMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (ExternalAccountIdMaxLength));
      ConnectInterface.NativeFieldInfoPtr_ExternalaccountinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (ExternalaccountinfoApiLatest));
      ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (GetexternalaccountmappingApiLatest));
      ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (GetexternalaccountmappingsApiLatest));
      ConnectInterface.NativeFieldInfoPtr_GetproductuserexternalaccountcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (GetproductuserexternalaccountcountApiLatest));
      ConnectInterface.NativeFieldInfoPtr_GetproductuseridmappingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (GetproductuseridmappingApiLatest));
      ConnectInterface.NativeFieldInfoPtr_IdtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (IdtokenApiLatest));
      ConnectInterface.NativeFieldInfoPtr_LinkaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (LinkaccountApiLatest));
      ConnectInterface.NativeFieldInfoPtr_LoginApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (LoginApiLatest));
      ConnectInterface.NativeFieldInfoPtr_OnauthexpirationcallbackApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (OnauthexpirationcallbackApiLatest));
      ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (QueryexternalaccountmappingsApiLatest));
      ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsMaxAccountIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (QueryexternalaccountmappingsMaxAccountIds));
      ConnectInterface.NativeFieldInfoPtr_QueryproductuseridmappingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (QueryproductuseridmappingsApiLatest));
      ConnectInterface.NativeFieldInfoPtr_TimeUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (TimeUndefined));
      ConnectInterface.NativeFieldInfoPtr_TransferdeviceidaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (TransferdeviceidaccountApiLatest));
      ConnectInterface.NativeFieldInfoPtr_UnlinkaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (UnlinkaccountApiLatest));
      ConnectInterface.NativeFieldInfoPtr_UserlogininfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (UserlogininfoApiLatest));
      ConnectInterface.NativeFieldInfoPtr_UserlogininfoDisplaynameMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (UserlogininfoDisplaynameMaxLength));
      ConnectInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, nameof (VerifyidtokenApiLatest));
      ConnectInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672646);
      ConnectInterface.NativeMethodInfoPtr_AddNotifyAuthExpiration_Public_UInt64_byref_AddNotifyAuthExpirationOptions_Object_OnAuthExpirationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672648);
      ConnectInterface.NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_byref_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672649);
      ConnectInterface.NativeMethodInfoPtr_CopyIdToken_Public_Result_byref_CopyIdTokenOptions_byref_Nullable_1_IdToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672650);
      ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountId_Public_Result_byref_CopyProductUserExternalAccountByAccountIdOptions_byref_Nullable_1_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672651);
      ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByAccountType_Public_Result_byref_CopyProductUserExternalAccountByAccountTypeOptions_byref_Nullable_1_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672652);
      ConnectInterface.NativeMethodInfoPtr_CopyProductUserExternalAccountByIndex_Public_Result_byref_CopyProductUserExternalAccountByIndexOptions_byref_Nullable_1_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672653);
      ConnectInterface.NativeMethodInfoPtr_CopyProductUserInfo_Public_Result_byref_CopyProductUserInfoOptions_byref_Nullable_1_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672654);
      ConnectInterface.NativeMethodInfoPtr_CreateDeviceId_Public_Void_byref_CreateDeviceIdOptions_Object_OnCreateDeviceIdCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672655);
      ConnectInterface.NativeMethodInfoPtr_CreateUser_Public_Void_byref_CreateUserOptions_Object_OnCreateUserCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672656);
      ConnectInterface.NativeMethodInfoPtr_DeleteDeviceId_Public_Void_byref_DeleteDeviceIdOptions_Object_OnDeleteDeviceIdCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672657);
      ConnectInterface.NativeMethodInfoPtr_GetExternalAccountMapping_Public_ProductUserId_byref_GetExternalAccountMappingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672658);
      ConnectInterface.NativeMethodInfoPtr_GetLoggedInUserByIndex_Public_ProductUserId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672659);
      ConnectInterface.NativeMethodInfoPtr_GetLoggedInUsersCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672660);
      ConnectInterface.NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672661);
      ConnectInterface.NativeMethodInfoPtr_GetProductUserExternalAccountCount_Public_UInt32_byref_GetProductUserExternalAccountCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672662);
      ConnectInterface.NativeMethodInfoPtr_GetProductUserIdMapping_Public_Result_byref_GetProductUserIdMappingOptions_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672663);
      ConnectInterface.NativeMethodInfoPtr_LinkAccount_Public_Void_byref_LinkAccountOptions_Object_OnLinkAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672664);
      ConnectInterface.NativeMethodInfoPtr_Login_Public_Void_byref_LoginOptions_Object_OnLoginCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672665);
      ConnectInterface.NativeMethodInfoPtr_QueryExternalAccountMappings_Public_Void_byref_QueryExternalAccountMappingsOptions_Object_OnQueryExternalAccountMappingsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672666);
      ConnectInterface.NativeMethodInfoPtr_QueryProductUserIdMappings_Public_Void_byref_QueryProductUserIdMappingsOptions_Object_OnQueryProductUserIdMappingsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672667);
      ConnectInterface.NativeMethodInfoPtr_RemoveNotifyAuthExpiration_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672668);
      ConnectInterface.NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672669);
      ConnectInterface.NativeMethodInfoPtr_TransferDeviceIdAccount_Public_Void_byref_TransferDeviceIdAccountOptions_Object_OnTransferDeviceIdAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672670);
      ConnectInterface.NativeMethodInfoPtr_UnlinkAccount_Public_Void_byref_UnlinkAccountOptions_Object_OnUnlinkAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672671);
      ConnectInterface.NativeMethodInfoPtr_VerifyIdToken_Public_Void_byref_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672672);
      ConnectInterface.NativeMethodInfoPtr_OnAuthExpirationCallbackInternalImplementation_Internal_Static_Void_byref_AuthExpirationCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672673);
      ConnectInterface.NativeMethodInfoPtr_OnCreateDeviceIdCallbackInternalImplementation_Internal_Static_Void_byref_CreateDeviceIdCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672674);
      ConnectInterface.NativeMethodInfoPtr_OnCreateUserCallbackInternalImplementation_Internal_Static_Void_byref_CreateUserCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672675);
      ConnectInterface.NativeMethodInfoPtr_OnDeleteDeviceIdCallbackInternalImplementation_Internal_Static_Void_byref_DeleteDeviceIdCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672676);
      ConnectInterface.NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_LinkAccountCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672677);
      ConnectInterface.NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_byref_LoginCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672678);
      ConnectInterface.NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_LoginStatusChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672679);
      ConnectInterface.NativeMethodInfoPtr_OnQueryExternalAccountMappingsCallbackInternalImplementation_Internal_Static_Void_byref_QueryExternalAccountMappingsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672680);
      ConnectInterface.NativeMethodInfoPtr_OnQueryProductUserIdMappingsCallbackInternalImplementation_Internal_Static_Void_byref_QueryProductUserIdMappingsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672681);
      ConnectInterface.NativeMethodInfoPtr_OnTransferDeviceIdAccountCallbackInternalImplementation_Internal_Static_Void_byref_TransferDeviceIdAccountCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672682);
      ConnectInterface.NativeMethodInfoPtr_OnUnlinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_UnlinkAccountCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672683);
      ConnectInterface.NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_VerifyIdTokenCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectInterface>.NativeClassPtr, 100672684);
    }

    public ConnectInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifyauthexpirationApiLatest
    {
      get
      {
        int addnotifyauthexpirationApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_AddnotifyauthexpirationApiLatest, (void*) &addnotifyauthexpirationApiLatest);
        return addnotifyauthexpirationApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_AddnotifyauthexpirationApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyloginstatuschangedApiLatest
    {
      get
      {
        int addnotifyloginstatuschangedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest, (void*) &addnotifyloginstatuschangedApiLatest);
        return addnotifyloginstatuschangedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyidtokenApiLatest
    {
      get
      {
        int copyidtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyidtokenApiLatest, (void*) &copyidtokenApiLatest);
        return copyidtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyidtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyproductuserexternalaccountbyaccountidApiLatest
    {
      get
      {
        int copyproductuserexternalaccountbyaccountidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccountidApiLatest, (void*) &copyproductuserexternalaccountbyaccountidApiLatest);
        return copyproductuserexternalaccountbyaccountidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccountidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyproductuserexternalaccountbyaccounttypeApiLatest
    {
      get
      {
        int copyproductuserexternalaccountbyaccounttypeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccounttypeApiLatest, (void*) &copyproductuserexternalaccountbyaccounttypeApiLatest);
        return copyproductuserexternalaccountbyaccounttypeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyaccounttypeApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyproductuserexternalaccountbyindexApiLatest
    {
      get
      {
        int copyproductuserexternalaccountbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyindexApiLatest, (void*) &copyproductuserexternalaccountbyindexApiLatest);
        return copyproductuserexternalaccountbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserexternalaccountbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyproductuserinfoApiLatest
    {
      get
      {
        int copyproductuserinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserinfoApiLatest, (void*) &copyproductuserinfoApiLatest);
        return copyproductuserinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CopyproductuserinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int CreatedeviceidApiLatest
    {
      get
      {
        int createdeviceidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CreatedeviceidApiLatest, (void*) &createdeviceidApiLatest);
        return createdeviceidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CreatedeviceidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CreatedeviceidDevicemodelMaxLength
    {
      get
      {
        int devicemodelMaxLength;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CreatedeviceidDevicemodelMaxLength, (void*) &devicemodelMaxLength);
        return devicemodelMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CreatedeviceidDevicemodelMaxLength, (void*) &value);
      }
    }

    public static unsafe int CreateuserApiLatest
    {
      get
      {
        int createuserApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CreateuserApiLatest, (void*) &createuserApiLatest);
        return createuserApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CreateuserApiLatest, (void*) &value);
      }
    }

    public static unsafe int CredentialsApiLatest
    {
      get
      {
        int credentialsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_CredentialsApiLatest, (void*) &credentialsApiLatest);
        return credentialsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_CredentialsApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletedeviceidApiLatest
    {
      get
      {
        int deletedeviceidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_DeletedeviceidApiLatest, (void*) &deletedeviceidApiLatest);
        return deletedeviceidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_DeletedeviceidApiLatest, (void*) &value);
      }
    }

    public static unsafe int ExternalAccountIdMaxLength
    {
      get
      {
        int accountIdMaxLength;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_ExternalAccountIdMaxLength, (void*) &accountIdMaxLength);
        return accountIdMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_ExternalAccountIdMaxLength, (void*) &value);
      }
    }

    public static unsafe int ExternalaccountinfoApiLatest
    {
      get
      {
        int externalaccountinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_ExternalaccountinfoApiLatest, (void*) &externalaccountinfoApiLatest);
        return externalaccountinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_ExternalaccountinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetexternalaccountmappingApiLatest
    {
      get
      {
        int getexternalaccountmappingApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingApiLatest, (void*) &getexternalaccountmappingApiLatest);
        return getexternalaccountmappingApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetexternalaccountmappingsApiLatest
    {
      get
      {
        int getexternalaccountmappingsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingsApiLatest, (void*) &getexternalaccountmappingsApiLatest);
        return getexternalaccountmappingsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_GetexternalaccountmappingsApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetproductuserexternalaccountcountApiLatest
    {
      get
      {
        int getproductuserexternalaccountcountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_GetproductuserexternalaccountcountApiLatest, (void*) &getproductuserexternalaccountcountApiLatest);
        return getproductuserexternalaccountcountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_GetproductuserexternalaccountcountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetproductuseridmappingApiLatest
    {
      get
      {
        int getproductuseridmappingApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_GetproductuseridmappingApiLatest, (void*) &getproductuseridmappingApiLatest);
        return getproductuseridmappingApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_GetproductuseridmappingApiLatest, (void*) &value);
      }
    }

    public static unsafe int IdtokenApiLatest
    {
      get
      {
        int idtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_IdtokenApiLatest, (void*) &idtokenApiLatest);
        return idtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_IdtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int LinkaccountApiLatest
    {
      get
      {
        int linkaccountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_LinkaccountApiLatest, (void*) &linkaccountApiLatest);
        return linkaccountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_LinkaccountApiLatest, (void*) &value);
      }
    }

    public static unsafe int LoginApiLatest
    {
      get
      {
        int loginApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_LoginApiLatest, (void*) &loginApiLatest);
        return loginApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_LoginApiLatest, (void*) &value);
      }
    }

    public static unsafe int OnauthexpirationcallbackApiLatest
    {
      get
      {
        int onauthexpirationcallbackApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_OnauthexpirationcallbackApiLatest, (void*) &onauthexpirationcallbackApiLatest);
        return onauthexpirationcallbackApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_OnauthexpirationcallbackApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryexternalaccountmappingsApiLatest
    {
      get
      {
        int queryexternalaccountmappingsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsApiLatest, (void*) &queryexternalaccountmappingsApiLatest);
        return queryexternalaccountmappingsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryexternalaccountmappingsMaxAccountIds
    {
      get
      {
        int queryexternalaccountmappingsMaxAccountIds;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsMaxAccountIds, (void*) &queryexternalaccountmappingsMaxAccountIds);
        return queryexternalaccountmappingsMaxAccountIds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_QueryexternalaccountmappingsMaxAccountIds, (void*) &value);
      }
    }

    public static unsafe int QueryproductuseridmappingsApiLatest
    {
      get
      {
        int queryproductuseridmappingsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_QueryproductuseridmappingsApiLatest, (void*) &queryproductuseridmappingsApiLatest);
        return queryproductuseridmappingsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_QueryproductuseridmappingsApiLatest, (void*) &value);
      }
    }

    public static unsafe int TimeUndefined
    {
      get
      {
        int timeUndefined;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &timeUndefined);
        return timeUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &value);
      }
    }

    public static unsafe int TransferdeviceidaccountApiLatest
    {
      get
      {
        int transferdeviceidaccountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_TransferdeviceidaccountApiLatest, (void*) &transferdeviceidaccountApiLatest);
        return transferdeviceidaccountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_TransferdeviceidaccountApiLatest, (void*) &value);
      }
    }

    public static unsafe int UnlinkaccountApiLatest
    {
      get
      {
        int unlinkaccountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_UnlinkaccountApiLatest, (void*) &unlinkaccountApiLatest);
        return unlinkaccountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_UnlinkaccountApiLatest, (void*) &value);
      }
    }

    public static unsafe int UserlogininfoApiLatest
    {
      get
      {
        int userlogininfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_UserlogininfoApiLatest, (void*) &userlogininfoApiLatest);
        return userlogininfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_UserlogininfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int UserlogininfoDisplaynameMaxLength
    {
      get
      {
        int displaynameMaxLength;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_UserlogininfoDisplaynameMaxLength, (void*) &displaynameMaxLength);
        return displaynameMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_UserlogininfoDisplaynameMaxLength, (void*) &value);
      }
    }

    public static unsafe int VerifyidtokenApiLatest
    {
      get
      {
        int verifyidtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ConnectInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest, (void*) &verifyidtokenApiLatest);
        return verifyidtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConnectInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest, (void*) &value);
      }
    }
  }
}
