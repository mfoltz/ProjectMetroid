// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.TokenInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct TokenInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_App;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccessToken;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpiresIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpiresAt;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AuthType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshToken;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshExpiresIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshExpiresAt;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_App_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_App_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccessToken_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpiresIn_Public_get_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpiresAt_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpiresAt_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AuthType_Public_get_AuthTokenType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AuthType_Public_set_Void_AuthTokenType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RefreshToken_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RefreshExpiresIn_Public_get_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RefreshExpiresIn_Public_set_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RefreshExpiresAt_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RefreshExpiresAt_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Token_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Token_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Token_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_App;
    [FieldOffset(16)]
    public System.IntPtr m_ClientId;
    [FieldOffset(24)]
    public System.IntPtr m_AccountId;
    [FieldOffset(32)]
    public System.IntPtr m_AccessToken;
    [FieldOffset(40)]
    public double m_ExpiresIn;
    [FieldOffset(48)]
    public System.IntPtr m_ExpiresAt;
    [FieldOffset(56)]
    public AuthTokenType m_AuthType;
    [FieldOffset(64)]
    public System.IntPtr m_RefreshToken;
    [FieldOffset(72)]
    public double m_RefreshExpiresIn;
    [FieldOffset(80)]
    public System.IntPtr m_RefreshExpiresAt;

    public unsafe Epic.OnlineServices.Utf8String App
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968234, XrefRangeEnd = 968238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_App_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968238, XrefRangeEnd = 968242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_App_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ClientId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968242, XrefRangeEnd = 968246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_ClientId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968246, XrefRangeEnd = 968250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_ClientId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EpicAccountId AccountId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 968256, RefRangeEnd = 968257, XrefRangeStart = 968250, XrefRangeEnd = 968256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968257, XrefRangeEnd = 968261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String AccessToken
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968261, XrefRangeEnd = 968265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_AccessToken_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968265, XrefRangeEnd = 968269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_AccessToken_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe double ExpiresIn
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(double*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ExpiresAt
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968269, XrefRangeEnd = 968273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_ExpiresAt_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968273, XrefRangeEnd = 968277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_ExpiresAt_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AuthTokenType AuthType
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_AuthType_Public_get_AuthTokenType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AuthTokenType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_AuthType_Public_set_Void_AuthTokenType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String RefreshToken
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968277, XrefRangeEnd = 968281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_RefreshToken_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968281, XrefRangeEnd = 968285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe double RefreshExpiresIn
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_RefreshExpiresIn_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(double*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_RefreshExpiresIn_Public_set_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String RefreshExpiresAt
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968285, XrefRangeEnd = 968289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_RefreshExpiresAt_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968289, XrefRangeEnd = 968293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_RefreshExpiresAt_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968293, XrefRangeEnd = 968321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Token other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Token_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968321, XrefRangeEnd = 968371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<Token> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Token_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968371, XrefRangeEnd = 968381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968381, XrefRangeEnd = 968382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out Token output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Token_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Token local = ref output;
      System.IntPtr pointer = zero;
      Token token = pointer == System.IntPtr.Zero ? (Token) null : new Token(pointer);
      local = token;
    }

    static TokenInternal()
    {
      Il2CppClassPointerStore<TokenInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (TokenInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr);
      TokenInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_ApiVersion));
      TokenInternal.NativeFieldInfoPtr_m_App = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_App));
      TokenInternal.NativeFieldInfoPtr_m_ClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_ClientId));
      TokenInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_AccountId));
      TokenInternal.NativeFieldInfoPtr_m_AccessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_AccessToken));
      TokenInternal.NativeFieldInfoPtr_m_ExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_ExpiresIn));
      TokenInternal.NativeFieldInfoPtr_m_ExpiresAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_ExpiresAt));
      TokenInternal.NativeFieldInfoPtr_m_AuthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_AuthType));
      TokenInternal.NativeFieldInfoPtr_m_RefreshToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_RefreshToken));
      TokenInternal.NativeFieldInfoPtr_m_RefreshExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_RefreshExpiresIn));
      TokenInternal.NativeFieldInfoPtr_m_RefreshExpiresAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_RefreshExpiresAt));
      TokenInternal.NativeMethodInfoPtr_get_App_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673613);
      TokenInternal.NativeMethodInfoPtr_set_App_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673614);
      TokenInternal.NativeMethodInfoPtr_get_ClientId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673615);
      TokenInternal.NativeMethodInfoPtr_set_ClientId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673616);
      TokenInternal.NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673617);
      TokenInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673618);
      TokenInternal.NativeMethodInfoPtr_get_AccessToken_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673619);
      TokenInternal.NativeMethodInfoPtr_set_AccessToken_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673620);
      TokenInternal.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673621);
      TokenInternal.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673622);
      TokenInternal.NativeMethodInfoPtr_get_ExpiresAt_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673623);
      TokenInternal.NativeMethodInfoPtr_set_ExpiresAt_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673624);
      TokenInternal.NativeMethodInfoPtr_get_AuthType_Public_get_AuthTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673625);
      TokenInternal.NativeMethodInfoPtr_set_AuthType_Public_set_Void_AuthTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673626);
      TokenInternal.NativeMethodInfoPtr_get_RefreshToken_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673627);
      TokenInternal.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673628);
      TokenInternal.NativeMethodInfoPtr_get_RefreshExpiresIn_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673629);
      TokenInternal.NativeMethodInfoPtr_set_RefreshExpiresIn_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673630);
      TokenInternal.NativeMethodInfoPtr_get_RefreshExpiresAt_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673631);
      TokenInternal.NativeMethodInfoPtr_set_RefreshExpiresAt_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673632);
      TokenInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673633);
      TokenInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673634);
      TokenInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673635);
      TokenInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100673636);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
