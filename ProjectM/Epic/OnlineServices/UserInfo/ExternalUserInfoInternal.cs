// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UserInfo.ExternalUserInfoInternal
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
  public struct ExternalUserInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayNameSanitized;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountType_Public_get_ExternalAccountType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountType_Public_set_Void_ExternalAccountType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayNameSanitized_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayNameSanitized_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ExternalUserInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ExternalUserInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ExternalUserInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public ExternalAccountType m_AccountType;
    [FieldOffset(8)]
    public System.IntPtr m_AccountId;
    [FieldOffset(16)]
    public System.IntPtr m_DisplayName;
    [FieldOffset(24)]
    public System.IntPtr m_DisplayNameSanitized;

    public unsafe ExternalAccountType AccountType
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_get_AccountType_Public_get_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ExternalAccountType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_set_AccountType_Public_set_Void_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String AccountId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936604, XrefRangeEnd = 936608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_get_AccountId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936608, XrefRangeEnd = 936612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DisplayName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936612, XrefRangeEnd = 936616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936616, XrefRangeEnd = 936620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DisplayNameSanitized
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936620, XrefRangeEnd = 936624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_get_DisplayNameSanitized_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936624, XrefRangeEnd = 936628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_set_DisplayNameSanitized_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936628, XrefRangeEnd = 936640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ExternalUserInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ExternalUserInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936640, XrefRangeEnd = 936662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<ExternalUserInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ExternalUserInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936662, XrefRangeEnd = 936668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936668, XrefRangeEnd = 936669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out ExternalUserInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalUserInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ExternalUserInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ExternalUserInfo local = ref output;
      System.IntPtr pointer = zero;
      ExternalUserInfo externalUserInfo = pointer == System.IntPtr.Zero ? (ExternalUserInfo) null : new ExternalUserInfo(pointer);
      local = externalUserInfo;
    }

    static ExternalUserInfoInternal()
    {
      Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UserInfo", nameof (ExternalUserInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr);
      ExternalUserInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      ExternalUserInfoInternal.NativeFieldInfoPtr_m_AccountType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, nameof (m_AccountType));
      ExternalUserInfoInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, nameof (m_AccountId));
      ExternalUserInfoInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, nameof (m_DisplayName));
      ExternalUserInfoInternal.NativeFieldInfoPtr_m_DisplayNameSanitized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, nameof (m_DisplayNameSanitized));
      ExternalUserInfoInternal.NativeMethodInfoPtr_get_AccountType_Public_get_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664932);
      ExternalUserInfoInternal.NativeMethodInfoPtr_set_AccountType_Public_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664933);
      ExternalUserInfoInternal.NativeMethodInfoPtr_get_AccountId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664934);
      ExternalUserInfoInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664935);
      ExternalUserInfoInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664936);
      ExternalUserInfoInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664937);
      ExternalUserInfoInternal.NativeMethodInfoPtr_get_DisplayNameSanitized_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664938);
      ExternalUserInfoInternal.NativeMethodInfoPtr_set_DisplayNameSanitized_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664939);
      ExternalUserInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664940);
      ExternalUserInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664941);
      ExternalUserInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664942);
      ExternalUserInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ExternalUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, 100664943);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExternalUserInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
