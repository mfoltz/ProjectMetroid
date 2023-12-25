// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UserInfo.UserInfoInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UserInfo
{
  public sealed class UserInfoInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyexternaluserinfobyaccountidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyexternaluserinfobyaccounttypeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyexternaluserinfobyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyuserinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExternaluserinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetexternaluserinfocountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDisplaynameCharacters;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDisplaynameUtf8Length;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryuserinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryuserinfobydisplaynameApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryuserinfobyexternalaccountApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyExternalUserInfoByAccountId_Public_Result_byref_CopyExternalUserInfoByAccountIdOptions_byref_Nullable_1_ExternalUserInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyExternalUserInfoByAccountType_Public_Result_byref_CopyExternalUserInfoByAccountTypeOptions_byref_Nullable_1_ExternalUserInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyExternalUserInfoByIndex_Public_Result_byref_CopyExternalUserInfoByIndexOptions_byref_Nullable_1_ExternalUserInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyUserInfo_Public_Result_byref_CopyUserInfoOptions_byref_Nullable_1_UserInfoData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExternalUserInfoCount_Public_UInt32_byref_GetExternalUserInfoCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryUserInfo_Public_Void_byref_QueryUserInfoOptions_Object_OnQueryUserInfoCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryUserInfoByDisplayName_Public_Void_byref_QueryUserInfoByDisplayNameOptions_Object_OnQueryUserInfoByDisplayNameCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryUserInfoByExternalAccount_Public_Void_byref_QueryUserInfoByExternalAccountOptions_Object_OnQueryUserInfoByExternalAccountCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryUserInfoByDisplayNameCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoByDisplayNameCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryUserInfoByExternalAccountCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoByExternalAccountCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryUserInfoCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserInfoInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937292, XrefRangeEnd = 937306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyExternalUserInfoByAccountId(
      ref CopyExternalUserInfoByAccountIdOptions options,
      out Il2CppSystem.Nullable<ExternalUserInfo> outExternalUserInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByAccountId_Public_Result_byref_CopyExternalUserInfoByAccountIdOptions_byref_Nullable_1_ExternalUserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ExternalUserInfo> local = ref outExternalUserInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ExternalUserInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937306, XrefRangeEnd = 937320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyExternalUserInfoByAccountType(
      ref CopyExternalUserInfoByAccountTypeOptions options,
      out Il2CppSystem.Nullable<ExternalUserInfo> outExternalUserInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByAccountType_Public_Result_byref_CopyExternalUserInfoByAccountTypeOptions_byref_Nullable_1_ExternalUserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ExternalUserInfo> local = ref outExternalUserInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ExternalUserInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937320, XrefRangeEnd = 937334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyExternalUserInfoByIndex(
      ref CopyExternalUserInfoByIndexOptions options,
      out Il2CppSystem.Nullable<ExternalUserInfo> outExternalUserInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByIndex_Public_Result_byref_CopyExternalUserInfoByIndexOptions_byref_Nullable_1_ExternalUserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ExternalUserInfo> local = ref outExternalUserInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ExternalUserInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937334, XrefRangeEnd = 937348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyUserInfo(
      ref CopyUserInfoOptions options,
      out Il2CppSystem.Nullable<UserInfoData> outUserInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_CopyUserInfo_Public_Result_byref_CopyUserInfoOptions_byref_Nullable_1_UserInfoData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<UserInfoData> local = ref outUserInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<UserInfoData>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937348, XrefRangeEnd = 937356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetExternalUserInfoCount(ref GetExternalUserInfoCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_GetExternalUserInfoCount_Public_UInt32_byref_GetExternalUserInfoCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937356, XrefRangeEnd = 937375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryUserInfo(
      ref QueryUserInfoOptions options,
      Il2CppSystem.Object clientData,
      OnQueryUserInfoCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_QueryUserInfo_Public_Void_byref_QueryUserInfoOptions_Object_OnQueryUserInfoCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937375, XrefRangeEnd = 937394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryUserInfoByDisplayName(
      ref QueryUserInfoByDisplayNameOptions options,
      Il2CppSystem.Object clientData,
      OnQueryUserInfoByDisplayNameCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_QueryUserInfoByDisplayName_Public_Void_byref_QueryUserInfoByDisplayNameOptions_Object_OnQueryUserInfoByDisplayNameCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937394, XrefRangeEnd = 937413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryUserInfoByExternalAccount(
      ref QueryUserInfoByExternalAccountOptions options,
      Il2CppSystem.Object clientData,
      OnQueryUserInfoByExternalAccountCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_QueryUserInfoByExternalAccount_Public_Void_byref_QueryUserInfoByExternalAccountOptions_Object_OnQueryUserInfoByExternalAccountCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937413, XrefRangeEnd = 937420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryUserInfoByDisplayNameCallbackInternalImplementation(
      ref QueryUserInfoByDisplayNameCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoByDisplayNameCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoByDisplayNameCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937420, XrefRangeEnd = 937427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryUserInfoByExternalAccountCallbackInternalImplementation(
      ref QueryUserInfoByExternalAccountCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoByExternalAccountCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoByExternalAccountCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937427, XrefRangeEnd = 937434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryUserInfoCallbackInternalImplementation(
      ref QueryUserInfoCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UserInfoInterface()
    {
      Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UserInfo", nameof (UserInfoInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr);
      UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccountidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (CopyexternaluserinfobyaccountidApiLatest));
      UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccounttypeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (CopyexternaluserinfobyaccounttypeApiLatest));
      UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (CopyexternaluserinfobyindexApiLatest));
      UserInfoInterface.NativeFieldInfoPtr_CopyuserinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (CopyuserinfoApiLatest));
      UserInfoInterface.NativeFieldInfoPtr_ExternaluserinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (ExternaluserinfoApiLatest));
      UserInfoInterface.NativeFieldInfoPtr_GetexternaluserinfocountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (GetexternaluserinfocountApiLatest));
      UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (MaxDisplaynameCharacters));
      UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameUtf8Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (MaxDisplaynameUtf8Length));
      UserInfoInterface.NativeFieldInfoPtr_QueryuserinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (QueryuserinfoApiLatest));
      UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobydisplaynameApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (QueryuserinfobydisplaynameApiLatest));
      UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobyexternalaccountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, nameof (QueryuserinfobyexternalaccountApiLatest));
      UserInfoInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665117);
      UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByAccountId_Public_Result_byref_CopyExternalUserInfoByAccountIdOptions_byref_Nullable_1_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665119);
      UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByAccountType_Public_Result_byref_CopyExternalUserInfoByAccountTypeOptions_byref_Nullable_1_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665120);
      UserInfoInterface.NativeMethodInfoPtr_CopyExternalUserInfoByIndex_Public_Result_byref_CopyExternalUserInfoByIndexOptions_byref_Nullable_1_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665121);
      UserInfoInterface.NativeMethodInfoPtr_CopyUserInfo_Public_Result_byref_CopyUserInfoOptions_byref_Nullable_1_UserInfoData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665122);
      UserInfoInterface.NativeMethodInfoPtr_GetExternalUserInfoCount_Public_UInt32_byref_GetExternalUserInfoCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665123);
      UserInfoInterface.NativeMethodInfoPtr_QueryUserInfo_Public_Void_byref_QueryUserInfoOptions_Object_OnQueryUserInfoCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665124);
      UserInfoInterface.NativeMethodInfoPtr_QueryUserInfoByDisplayName_Public_Void_byref_QueryUserInfoByDisplayNameOptions_Object_OnQueryUserInfoByDisplayNameCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665125);
      UserInfoInterface.NativeMethodInfoPtr_QueryUserInfoByExternalAccount_Public_Void_byref_QueryUserInfoByExternalAccountOptions_Object_OnQueryUserInfoByExternalAccountCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665126);
      UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoByDisplayNameCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoByDisplayNameCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665127);
      UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoByExternalAccountCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoByExternalAccountCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665128);
      UserInfoInterface.NativeMethodInfoPtr_OnQueryUserInfoCallbackInternalImplementation_Internal_Static_Void_byref_QueryUserInfoCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100665129);
    }

    public UserInfoInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CopyexternaluserinfobyaccountidApiLatest
    {
      get
      {
        int copyexternaluserinfobyaccountidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccountidApiLatest, (void*) &copyexternaluserinfobyaccountidApiLatest);
        return copyexternaluserinfobyaccountidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccountidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyexternaluserinfobyaccounttypeApiLatest
    {
      get
      {
        int copyexternaluserinfobyaccounttypeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccounttypeApiLatest, (void*) &copyexternaluserinfobyaccounttypeApiLatest);
        return copyexternaluserinfobyaccounttypeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyaccounttypeApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyexternaluserinfobyindexApiLatest
    {
      get
      {
        int copyexternaluserinfobyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyindexApiLatest, (void*) &copyexternaluserinfobyindexApiLatest);
        return copyexternaluserinfobyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_CopyexternaluserinfobyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyuserinfoApiLatest
    {
      get
      {
        int copyuserinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_CopyuserinfoApiLatest, (void*) &copyuserinfoApiLatest);
        return copyuserinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_CopyuserinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int ExternaluserinfoApiLatest
    {
      get
      {
        int externaluserinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_ExternaluserinfoApiLatest, (void*) &externaluserinfoApiLatest);
        return externaluserinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_ExternaluserinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetexternaluserinfocountApiLatest
    {
      get
      {
        int getexternaluserinfocountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_GetexternaluserinfocountApiLatest, (void*) &getexternaluserinfocountApiLatest);
        return getexternaluserinfocountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_GetexternaluserinfocountApiLatest, (void*) &value);
      }
    }

    public static unsafe int MaxDisplaynameCharacters
    {
      get
      {
        int displaynameCharacters;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameCharacters, (void*) &displaynameCharacters);
        return displaynameCharacters;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameCharacters, (void*) &value);
      }
    }

    public static unsafe int MaxDisplaynameUtf8Length
    {
      get
      {
        int displaynameUtf8Length;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameUtf8Length, (void*) &displaynameUtf8Length);
        return displaynameUtf8Length;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_MaxDisplaynameUtf8Length, (void*) &value);
      }
    }

    public static unsafe int QueryuserinfoApiLatest
    {
      get
      {
        int queryuserinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfoApiLatest, (void*) &queryuserinfoApiLatest);
        return queryuserinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryuserinfobydisplaynameApiLatest
    {
      get
      {
        int queryuserinfobydisplaynameApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobydisplaynameApiLatest, (void*) &queryuserinfobydisplaynameApiLatest);
        return queryuserinfobydisplaynameApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobydisplaynameApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryuserinfobyexternalaccountApiLatest
    {
      get
      {
        int queryuserinfobyexternalaccountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobyexternalaccountApiLatest, (void*) &queryuserinfobyexternalaccountApiLatest);
        return queryuserinfobyexternalaccountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_QueryuserinfobyexternalaccountApiLatest, (void*) &value);
      }
    }
  }
}
