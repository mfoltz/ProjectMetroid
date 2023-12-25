// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.LoginOptionsInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct LoginOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Credentials;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserLoginInfo;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_Nullable_1_UserLoginInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LoginOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LoginOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Credentials;
    [FieldOffset(16)]
    public System.IntPtr m_UserLoginInfo;

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.Connect.Credentials> Credentials
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965986, XrefRangeEnd = 965992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.Connect.UserLoginInfo> UserLoginInfo
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965992, XrefRangeEnd = 965998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_Nullable_1_UserLoginInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 966010, RefRangeEnd = 966011, XrefRangeStart = 965998, XrefRangeEnd = 966010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LoginOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LoginOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966011, XrefRangeEnd = 966029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LoginOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LoginOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966029, XrefRangeEnd = 966034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LoginOptionsInternal()
    {
      Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (LoginOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr);
      LoginOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LoginOptionsInternal.NativeFieldInfoPtr_m_Credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_Credentials));
      LoginOptionsInternal.NativeFieldInfoPtr_m_UserLoginInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_UserLoginInfo));
      LoginOptionsInternal.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672924);
      LoginOptionsInternal.NativeMethodInfoPtr_set_UserLoginInfo_Public_set_Void_Nullable_1_UserLoginInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672925);
      LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LoginOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672926);
      LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LoginOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672927);
      LoginOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672928);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
