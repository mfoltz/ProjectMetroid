// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UserInfo.UserInfoDataInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct UserInfoDataInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Country;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PreferredLanguage;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Nickname;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayNameSanitized;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Country_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Country_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PreferredLanguage_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PreferredLanguage_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Nickname_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Nickname_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayNameSanitized_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayNameSanitized_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserInfoData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserInfoData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserInfoData_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_UserId;
    [FieldOffset(16)]
    public System.IntPtr m_Country;
    [FieldOffset(24)]
    public System.IntPtr m_DisplayName;
    [FieldOffset(32)]
    public System.IntPtr m_PreferredLanguage;
    [FieldOffset(40)]
    public System.IntPtr m_Nickname;
    [FieldOffset(48)]
    public System.IntPtr m_DisplayNameSanitized;

    public unsafe EpicAccountId UserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 937175, RefRangeEnd = 937176, XrefRangeStart = 937169, XrefRangeEnd = 937175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937176, XrefRangeEnd = 937180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Country
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937180, XrefRangeEnd = 937184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_get_Country_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937184, XrefRangeEnd = 937188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_set_Country_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DisplayName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937188, XrefRangeEnd = 937192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937192, XrefRangeEnd = 937196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String PreferredLanguage
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937196, XrefRangeEnd = 937200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_get_PreferredLanguage_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937200, XrefRangeEnd = 937204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_set_PreferredLanguage_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Nickname
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937204, XrefRangeEnd = 937208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_get_Nickname_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937208, XrefRangeEnd = 937212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_set_Nickname_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DisplayNameSanitized
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937212, XrefRangeEnd = 937216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_get_DisplayNameSanitized_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937216, XrefRangeEnd = 937220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_set_DisplayNameSanitized_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937220, XrefRangeEnd = 937244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UserInfoData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserInfoData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937244, XrefRangeEnd = 937282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UserInfoData> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserInfoData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937282, XrefRangeEnd = 937291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937291, XrefRangeEnd = 937292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out UserInfoData output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserInfoDataInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserInfoData_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref UserInfoData local = ref output;
      System.IntPtr pointer = zero;
      UserInfoData userInfoData = pointer == System.IntPtr.Zero ? (UserInfoData) null : new UserInfoData(pointer);
      local = userInfoData;
    }

    static UserInfoDataInternal()
    {
      Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UserInfo", nameof (UserInfoDataInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr);
      UserInfoDataInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UserInfoDataInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, nameof (m_UserId));
      UserInfoDataInternal.NativeFieldInfoPtr_m_Country = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, nameof (m_Country));
      UserInfoDataInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, nameof (m_DisplayName));
      UserInfoDataInternal.NativeFieldInfoPtr_m_PreferredLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, nameof (m_PreferredLanguage));
      UserInfoDataInternal.NativeFieldInfoPtr_m_Nickname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, nameof (m_Nickname));
      UserInfoDataInternal.NativeFieldInfoPtr_m_DisplayNameSanitized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, nameof (m_DisplayNameSanitized));
      UserInfoDataInternal.NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665101);
      UserInfoDataInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665102);
      UserInfoDataInternal.NativeMethodInfoPtr_get_Country_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665103);
      UserInfoDataInternal.NativeMethodInfoPtr_set_Country_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665104);
      UserInfoDataInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665105);
      UserInfoDataInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665106);
      UserInfoDataInternal.NativeMethodInfoPtr_get_PreferredLanguage_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665107);
      UserInfoDataInternal.NativeMethodInfoPtr_set_PreferredLanguage_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665108);
      UserInfoDataInternal.NativeMethodInfoPtr_get_Nickname_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665109);
      UserInfoDataInternal.NativeMethodInfoPtr_set_Nickname_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665110);
      UserInfoDataInternal.NativeMethodInfoPtr_get_DisplayNameSanitized_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665111);
      UserInfoDataInternal.NativeMethodInfoPtr_set_DisplayNameSanitized_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665112);
      UserInfoDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserInfoData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665113);
      UserInfoDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserInfoData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665114);
      UserInfoDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665115);
      UserInfoDataInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserInfoData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, 100665116);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserInfoDataInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
