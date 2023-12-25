// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.IOSCredentialsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IOSCredentialsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Token;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SystemAuthCredentialsOptions;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalType;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Token_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IOSCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_IOSCredentials_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Id;
    [FieldOffset(16)]
    public System.IntPtr m_Token;
    [FieldOffset(24)]
    public LoginCredentialType m_Type;
    [FieldOffset(32)]
    public System.IntPtr m_SystemAuthCredentialsOptions;
    [FieldOffset(40)]
    public ExternalCredentialType m_ExternalType;

    public unsafe Epic.OnlineServices.Utf8String Id
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968766, XrefRangeEnd = 968770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968770, XrefRangeEnd = 968774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Token
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968774, XrefRangeEnd = 968778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_get_Token_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968778, XrefRangeEnd = 968782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_set_Token_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LoginCredentialType Type
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LoginCredentialType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<IOSCredentialsSystemAuthCredentialsOptions> SystemAuthCredentialsOptions
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968782, XrefRangeEnd = 968788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<IOSCredentialsSystemAuthCredentialsOptions>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968788, XrefRangeEnd = 968794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ExternalCredentialType ExternalType
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 35564, RefRangeEnd = 35585, XrefRangeStart = 35564, XrefRangeEnd = 35585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ExternalCredentialType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968794, XrefRangeEnd = 968808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref IOSCredentials other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968808, XrefRangeEnd = 968834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<IOSCredentials> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IOSCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968834, XrefRangeEnd = 968840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968840, XrefRangeEnd = 968841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out IOSCredentials output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_IOSCredentials_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref IOSCredentials local = ref output;
      System.IntPtr pointer = zero;
      IOSCredentials iosCredentials = pointer == System.IntPtr.Zero ? (IOSCredentials) null : new IOSCredentials(pointer);
      local = iosCredentials;
    }

    static IOSCredentialsInternal()
    {
      Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (IOSCredentialsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr);
      IOSCredentialsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      IOSCredentialsInternal.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, nameof (m_Id));
      IOSCredentialsInternal.NativeFieldInfoPtr_m_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, nameof (m_Token));
      IOSCredentialsInternal.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, nameof (m_Type));
      IOSCredentialsInternal.NativeFieldInfoPtr_m_SystemAuthCredentialsOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, nameof (m_SystemAuthCredentialsOptions));
      IOSCredentialsInternal.NativeFieldInfoPtr_m_ExternalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, nameof (m_ExternalType));
      IOSCredentialsInternal.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673734);
      IOSCredentialsInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673735);
      IOSCredentialsInternal.NativeMethodInfoPtr_get_Token_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673736);
      IOSCredentialsInternal.NativeMethodInfoPtr_set_Token_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673737);
      IOSCredentialsInternal.NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673738);
      IOSCredentialsInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673739);
      IOSCredentialsInternal.NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673740);
      IOSCredentialsInternal.NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673741);
      IOSCredentialsInternal.NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673742);
      IOSCredentialsInternal.NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673743);
      IOSCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673744);
      IOSCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IOSCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673745);
      IOSCredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673746);
      IOSCredentialsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_IOSCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, 100673747);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IOSCredentialsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
