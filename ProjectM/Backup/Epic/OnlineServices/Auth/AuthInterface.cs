// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.AuthInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth
{
  public sealed class AuthInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AccountfeaturerestrictedinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyidtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyuserauthtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CredentialsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletepersistentauthApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinkaccountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoginApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogoutApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_PingrantinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryidtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_TokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_VerifyidtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_VerifyuserauthApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_IosCredentialssystemauthcredentialsoptionsApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_byref_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyIdToken_Public_Result_byref_CopyIdTokenOptions_byref_Nullable_1_IdToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyUserAuthToken_Public_Result_byref_CopyUserAuthTokenOptions_EpicAccountId_byref_Nullable_1_Token_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeletePersistentAuth_Public_Void_byref_DeletePersistentAuthOptions_Object_OnDeletePersistentAuthCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLoggedInAccountByIndex_Public_EpicAccountId_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLoggedInAccountsCount_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedAccountByIndex_Public_EpicAccountId_EpicAccountId_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedAccountsCount_Public_UInt32_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedAccountId_Public_Result_EpicAccountId_byref_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LinkAccount_Public_Void_byref_LinkAccountOptions_Object_OnLinkAccountCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Login_Public_Void_byref_LoginOptions_Object_OnLoginCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Logout_Public_Void_byref_LogoutOptions_Object_OnLogoutCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryIdToken_Public_Void_byref_QueryIdTokenOptions_Object_OnQueryIdTokenCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyIdToken_Public_Void_byref_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyUserAuth_Public_Void_byref_VerifyUserAuthOptions_Object_OnVerifyUserAuthCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDeletePersistentAuthCallbackInternalImplementation_Internal_Static_Void_byref_DeletePersistentAuthCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_LinkAccountCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_byref_LoginCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_LoginStatusChangedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLogoutCallbackInternalImplementation_Internal_Static_Void_byref_LogoutCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryIdTokenCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_VerifyIdTokenCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVerifyUserAuthCallbackInternalImplementation_Internal_Static_Void_byref_VerifyUserAuthCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Login_Public_Void_byref_IOSLoginOptions_Object_OnLoginCallback_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AuthInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966917, XrefRangeEnd = 966938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_byref_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966938, XrefRangeEnd = 966954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_CopyIdToken_Public_Result_byref_CopyIdTokenOptions_byref_Nullable_1_IdToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<IdToken> local = ref outIdToken;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<IdToken>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966954, XrefRangeEnd = 966971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyUserAuthToken(
      ref CopyUserAuthTokenOptions options,
      EpicAccountId localUserId,
      out Il2CppSystem.Nullable<Token> outUserAuthToken)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_CopyUserAuthToken_Public_Result_byref_CopyUserAuthTokenOptions_EpicAccountId_byref_Nullable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Token> local = ref outUserAuthToken;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Token>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966971, XrefRangeEnd = 966991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeletePersistentAuth(
      ref DeletePersistentAuthOptions options,
      Il2CppSystem.Object clientData,
      OnDeletePersistentAuthCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_DeletePersistentAuth_Public_Void_byref_DeletePersistentAuthOptions_Object_OnDeletePersistentAuthCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966991, XrefRangeEnd = 966999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EpicAccountId GetLoggedInAccountByIndex(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetLoggedInAccountByIndex_Public_EpicAccountId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966999, XrefRangeEnd = 967001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetLoggedInAccountsCount()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetLoggedInAccountsCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967001, XrefRangeEnd = 967008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LoginStatus GetLoginStatus(EpicAccountId localUserId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LoginStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967008, XrefRangeEnd = 967018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EpicAccountId GetMergedAccountByIndex(EpicAccountId localUserId, uint index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetMergedAccountByIndex_Public_EpicAccountId_EpicAccountId_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967018, XrefRangeEnd = 967025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetMergedAccountsCount(EpicAccountId localUserId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetMergedAccountsCount_Public_UInt32_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967025, XrefRangeEnd = 967035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetSelectedAccountId(
      EpicAccountId localUserId,
      out EpicAccountId outSelectedAccountId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localUserId);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_GetSelectedAccountId_Public_Result_EpicAccountId_byref_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref EpicAccountId local = ref outSelectedAccountId;
      System.IntPtr pointer = zero;
      EpicAccountId epicAccountId = pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      local = epicAccountId;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967035, XrefRangeEnd = 967055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_LinkAccount_Public_Void_byref_LinkAccountOptions_Object_OnLinkAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967055, XrefRangeEnd = 967075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_Login_Public_Void_byref_LoginOptions_Object_OnLoginCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967075, XrefRangeEnd = 967095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Logout(
      ref LogoutOptions options,
      Il2CppSystem.Object clientData,
      OnLogoutCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_Logout_Public_Void_byref_LogoutOptions_Object_OnLogoutCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967095, XrefRangeEnd = 967115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryIdToken(
      ref QueryIdTokenOptions options,
      Il2CppSystem.Object clientData,
      OnQueryIdTokenCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_QueryIdToken_Public_Void_byref_QueryIdTokenOptions_Object_OnQueryIdTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967115, XrefRangeEnd = 967121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyLoginStatusChanged(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967121, XrefRangeEnd = 967141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_VerifyIdToken_Public_Void_byref_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967141, XrefRangeEnd = 967161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void VerifyUserAuth(
      ref VerifyUserAuthOptions options,
      Il2CppSystem.Object clientData,
      OnVerifyUserAuthCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_VerifyUserAuth_Public_Void_byref_VerifyUserAuthOptions_Object_OnVerifyUserAuthCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967161, XrefRangeEnd = 967168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDeletePersistentAuthCallbackInternalImplementation(
      ref DeletePersistentAuthCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnDeletePersistentAuthCallbackInternalImplementation_Internal_Static_Void_byref_DeletePersistentAuthCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967168, XrefRangeEnd = 967175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLinkAccountCallbackInternalImplementation(
      ref LinkAccountCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_LinkAccountCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967175, XrefRangeEnd = 967182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLoginCallbackInternalImplementation(
      ref LoginCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_byref_LoginCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967182, XrefRangeEnd = 967189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLoginStatusChangedCallbackInternalImplementation(
      ref LoginStatusChangedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_LoginStatusChangedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967189, XrefRangeEnd = 967196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnLogoutCallbackInternalImplementation(
      ref LogoutCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnLogoutCallbackInternalImplementation_Internal_Static_Void_byref_LogoutCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967196, XrefRangeEnd = 967203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryIdTokenCallbackInternalImplementation(
      ref QueryIdTokenCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnQueryIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryIdTokenCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967203, XrefRangeEnd = 967210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnVerifyIdTokenCallbackInternalImplementation(
      ref VerifyIdTokenCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_VerifyIdTokenCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967210, XrefRangeEnd = 967217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnVerifyUserAuthCallbackInternalImplementation(
      ref VerifyUserAuthCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_OnVerifyUserAuthCallbackInternalImplementation_Internal_Static_Void_byref_VerifyUserAuthCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967217, XrefRangeEnd = 967236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Login(
      ref IOSLoginOptions options,
      Il2CppSystem.Object clientData,
      OnLoginCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AuthInterface.NativeMethodInfoPtr_Login_Public_Void_byref_IOSLoginOptions_Object_OnLoginCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AuthInterface()
    {
      Il2CppClassPointerStore<AuthInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (AuthInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr);
      AuthInterface.NativeFieldInfoPtr_AccountfeaturerestrictedinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (AccountfeaturerestrictedinfoApiLatest));
      AuthInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (AddnotifyloginstatuschangedApiLatest));
      AuthInterface.NativeFieldInfoPtr_CopyidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (CopyidtokenApiLatest));
      AuthInterface.NativeFieldInfoPtr_CopyuserauthtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (CopyuserauthtokenApiLatest));
      AuthInterface.NativeFieldInfoPtr_CredentialsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (CredentialsApiLatest));
      AuthInterface.NativeFieldInfoPtr_DeletepersistentauthApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (DeletepersistentauthApiLatest));
      AuthInterface.NativeFieldInfoPtr_IdtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (IdtokenApiLatest));
      AuthInterface.NativeFieldInfoPtr_LinkaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (LinkaccountApiLatest));
      AuthInterface.NativeFieldInfoPtr_LoginApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (LoginApiLatest));
      AuthInterface.NativeFieldInfoPtr_LogoutApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (LogoutApiLatest));
      AuthInterface.NativeFieldInfoPtr_PingrantinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (PingrantinfoApiLatest));
      AuthInterface.NativeFieldInfoPtr_QueryidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (QueryidtokenApiLatest));
      AuthInterface.NativeFieldInfoPtr_TokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (TokenApiLatest));
      AuthInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (VerifyidtokenApiLatest));
      AuthInterface.NativeFieldInfoPtr_VerifyuserauthApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (VerifyuserauthApiLatest));
      AuthInterface.NativeFieldInfoPtr_IosCredentialssystemauthcredentialsoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, nameof (IosCredentialssystemauthcredentialsoptionsApiLatest));
      AuthInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673248);
      AuthInterface.NativeMethodInfoPtr_AddNotifyLoginStatusChanged_Public_UInt64_byref_AddNotifyLoginStatusChangedOptions_Object_OnLoginStatusChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673250);
      AuthInterface.NativeMethodInfoPtr_CopyIdToken_Public_Result_byref_CopyIdTokenOptions_byref_Nullable_1_IdToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673251);
      AuthInterface.NativeMethodInfoPtr_CopyUserAuthToken_Public_Result_byref_CopyUserAuthTokenOptions_EpicAccountId_byref_Nullable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673252);
      AuthInterface.NativeMethodInfoPtr_DeletePersistentAuth_Public_Void_byref_DeletePersistentAuthOptions_Object_OnDeletePersistentAuthCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673253);
      AuthInterface.NativeMethodInfoPtr_GetLoggedInAccountByIndex_Public_EpicAccountId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673254);
      AuthInterface.NativeMethodInfoPtr_GetLoggedInAccountsCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673255);
      AuthInterface.NativeMethodInfoPtr_GetLoginStatus_Public_LoginStatus_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673256);
      AuthInterface.NativeMethodInfoPtr_GetMergedAccountByIndex_Public_EpicAccountId_EpicAccountId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673257);
      AuthInterface.NativeMethodInfoPtr_GetMergedAccountsCount_Public_UInt32_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673258);
      AuthInterface.NativeMethodInfoPtr_GetSelectedAccountId_Public_Result_EpicAccountId_byref_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673259);
      AuthInterface.NativeMethodInfoPtr_LinkAccount_Public_Void_byref_LinkAccountOptions_Object_OnLinkAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673260);
      AuthInterface.NativeMethodInfoPtr_Login_Public_Void_byref_LoginOptions_Object_OnLoginCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673261);
      AuthInterface.NativeMethodInfoPtr_Logout_Public_Void_byref_LogoutOptions_Object_OnLogoutCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673262);
      AuthInterface.NativeMethodInfoPtr_QueryIdToken_Public_Void_byref_QueryIdTokenOptions_Object_OnQueryIdTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673263);
      AuthInterface.NativeMethodInfoPtr_RemoveNotifyLoginStatusChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673264);
      AuthInterface.NativeMethodInfoPtr_VerifyIdToken_Public_Void_byref_VerifyIdTokenOptions_Object_OnVerifyIdTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673265);
      AuthInterface.NativeMethodInfoPtr_VerifyUserAuth_Public_Void_byref_VerifyUserAuthOptions_Object_OnVerifyUserAuthCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673266);
      AuthInterface.NativeMethodInfoPtr_OnDeletePersistentAuthCallbackInternalImplementation_Internal_Static_Void_byref_DeletePersistentAuthCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673267);
      AuthInterface.NativeMethodInfoPtr_OnLinkAccountCallbackInternalImplementation_Internal_Static_Void_byref_LinkAccountCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673268);
      AuthInterface.NativeMethodInfoPtr_OnLoginCallbackInternalImplementation_Internal_Static_Void_byref_LoginCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673269);
      AuthInterface.NativeMethodInfoPtr_OnLoginStatusChangedCallbackInternalImplementation_Internal_Static_Void_byref_LoginStatusChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673270);
      AuthInterface.NativeMethodInfoPtr_OnLogoutCallbackInternalImplementation_Internal_Static_Void_byref_LogoutCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673271);
      AuthInterface.NativeMethodInfoPtr_OnQueryIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryIdTokenCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673272);
      AuthInterface.NativeMethodInfoPtr_OnVerifyIdTokenCallbackInternalImplementation_Internal_Static_Void_byref_VerifyIdTokenCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673273);
      AuthInterface.NativeMethodInfoPtr_OnVerifyUserAuthCallbackInternalImplementation_Internal_Static_Void_byref_VerifyUserAuthCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673274);
      AuthInterface.NativeMethodInfoPtr_Login_Public_Void_byref_IOSLoginOptions_Object_OnLoginCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthInterface>.NativeClassPtr, 100673275);
    }

    public AuthInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AccountfeaturerestrictedinfoApiLatest
    {
      get
      {
        int accountfeaturerestrictedinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_AccountfeaturerestrictedinfoApiLatest, (void*) &accountfeaturerestrictedinfoApiLatest);
        return accountfeaturerestrictedinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_AccountfeaturerestrictedinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyloginstatuschangedApiLatest
    {
      get
      {
        int addnotifyloginstatuschangedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest, (void*) &addnotifyloginstatuschangedApiLatest);
        return addnotifyloginstatuschangedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_AddnotifyloginstatuschangedApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyidtokenApiLatest
    {
      get
      {
        int copyidtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_CopyidtokenApiLatest, (void*) &copyidtokenApiLatest);
        return copyidtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_CopyidtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyuserauthtokenApiLatest
    {
      get
      {
        int copyuserauthtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_CopyuserauthtokenApiLatest, (void*) &copyuserauthtokenApiLatest);
        return copyuserauthtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_CopyuserauthtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int CredentialsApiLatest
    {
      get
      {
        int credentialsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_CredentialsApiLatest, (void*) &credentialsApiLatest);
        return credentialsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_CredentialsApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletepersistentauthApiLatest
    {
      get
      {
        int deletepersistentauthApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_DeletepersistentauthApiLatest, (void*) &deletepersistentauthApiLatest);
        return deletepersistentauthApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_DeletepersistentauthApiLatest, (void*) &value);
      }
    }

    public static unsafe int IdtokenApiLatest
    {
      get
      {
        int idtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_IdtokenApiLatest, (void*) &idtokenApiLatest);
        return idtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_IdtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int LinkaccountApiLatest
    {
      get
      {
        int linkaccountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_LinkaccountApiLatest, (void*) &linkaccountApiLatest);
        return linkaccountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_LinkaccountApiLatest, (void*) &value);
      }
    }

    public static unsafe int LoginApiLatest
    {
      get
      {
        int loginApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_LoginApiLatest, (void*) &loginApiLatest);
        return loginApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_LoginApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogoutApiLatest
    {
      get
      {
        int logoutApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_LogoutApiLatest, (void*) &logoutApiLatest);
        return logoutApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_LogoutApiLatest, (void*) &value);
      }
    }

    public static unsafe int PingrantinfoApiLatest
    {
      get
      {
        int pingrantinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_PingrantinfoApiLatest, (void*) &pingrantinfoApiLatest);
        return pingrantinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_PingrantinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryidtokenApiLatest
    {
      get
      {
        int queryidtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_QueryidtokenApiLatest, (void*) &queryidtokenApiLatest);
        return queryidtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_QueryidtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int TokenApiLatest
    {
      get
      {
        int tokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_TokenApiLatest, (void*) &tokenApiLatest);
        return tokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_TokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int VerifyidtokenApiLatest
    {
      get
      {
        int verifyidtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest, (void*) &verifyidtokenApiLatest);
        return verifyidtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_VerifyidtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int VerifyuserauthApiLatest
    {
      get
      {
        int verifyuserauthApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_VerifyuserauthApiLatest, (void*) &verifyuserauthApiLatest);
        return verifyuserauthApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_VerifyuserauthApiLatest, (void*) &value);
      }
    }

    public static unsafe int IosCredentialssystemauthcredentialsoptionsApiLatest
    {
      get
      {
        int credentialssystemauthcredentialsoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AuthInterface.NativeFieldInfoPtr_IosCredentialssystemauthcredentialsoptionsApiLatest, (void*) &credentialssystemauthcredentialsoptionsApiLatest);
        return credentialssystemauthcredentialsoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AuthInterface.NativeFieldInfoPtr_IosCredentialssystemauthcredentialsoptionsApiLatest, (void*) &value);
      }
    }
  }
}
