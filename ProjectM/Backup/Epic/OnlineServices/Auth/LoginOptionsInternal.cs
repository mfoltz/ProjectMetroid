// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.LoginOptionsInternal
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
  public struct LoginOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Credentials;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ScopeFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LoginOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LoginOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Credentials;
    [FieldOffset(16)]
    public AuthScopeFlags m_ScopeFlags;

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.Auth.Credentials> Credentials
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967767, XrefRangeEnd = 967773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AuthScopeFlags ScopeFlags
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 967779, RefRangeEnd = 967780, XrefRangeStart = 967773, XrefRangeEnd = 967779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LoginOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LoginOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967780, XrefRangeEnd = 967792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LoginOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LoginOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967792, XrefRangeEnd = 967796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LoginOptionsInternal()
    {
      Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (LoginOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr);
      LoginOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LoginOptionsInternal.NativeFieldInfoPtr_m_Credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_Credentials));
      LoginOptionsInternal.NativeFieldInfoPtr_m_ScopeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_ScopeFlags));
      LoginOptionsInternal.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100673422);
      LoginOptionsInternal.NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100673423);
      LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LoginOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100673424);
      LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LoginOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100673425);
      LoginOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100673426);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
