// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.IOSLoginOptionsInternal
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
  public struct IOSLoginOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Credentials;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ScopeFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_IOSCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSLoginOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IOSLoginOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Credentials;
    [FieldOffset(16)]
    public AuthScopeFlags m_ScopeFlags;

    public unsafe Il2CppSystem.Nullable<IOSCredentials> Credentials
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968860, XrefRangeEnd = 968866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSLoginOptionsInternal.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_IOSCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(IOSLoginOptionsInternal.NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 968872, RefRangeEnd = 968873, XrefRangeStart = 968866, XrefRangeEnd = 968872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref IOSLoginOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSLoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSLoginOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968873, XrefRangeEnd = 968885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<IOSLoginOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSLoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IOSLoginOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968885, XrefRangeEnd = 968889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSLoginOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IOSLoginOptionsInternal()
    {
      Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (IOSLoginOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr);
      IOSLoginOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      IOSLoginOptionsInternal.NativeFieldInfoPtr_m_Credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, nameof (m_Credentials));
      IOSLoginOptionsInternal.NativeFieldInfoPtr_m_ScopeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, nameof (m_ScopeFlags));
      IOSLoginOptionsInternal.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Nullable_1_IOSCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, 100673761);
      IOSLoginOptionsInternal.NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, 100673762);
      IOSLoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSLoginOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, 100673763);
      IOSLoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IOSLoginOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, 100673764);
      IOSLoginOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, 100673765);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IOSLoginOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
