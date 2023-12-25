// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.ClientCredentialsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClientCredentialsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientSecret;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientSecret_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ClientCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ClientCredentials_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ClientCredentials_0;
    [FieldOffset(0)]
    public System.IntPtr m_ClientId;
    [FieldOffset(8)]
    public System.IntPtr m_ClientSecret;

    public unsafe Epic.OnlineServices.Utf8String ClientId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971911, XrefRangeEnd = 971915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_get_ClientId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971915, XrefRangeEnd = 971919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_set_ClientId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ClientSecret
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971919, XrefRangeEnd = 971923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_get_ClientSecret_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971923, XrefRangeEnd = 971927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971927, XrefRangeEnd = 971935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ClientCredentials other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ClientCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971935, XrefRangeEnd = 971949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<ClientCredentials> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ClientCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971949, XrefRangeEnd = 971954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971954, XrefRangeEnd = 971955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out ClientCredentials output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ClientCredentials_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ClientCredentials local = ref output;
      System.IntPtr pointer = zero;
      ClientCredentials clientCredentials = pointer == System.IntPtr.Zero ? (ClientCredentials) null : new ClientCredentials(pointer);
      local = clientCredentials;
    }

    static ClientCredentialsInternal()
    {
      Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (ClientCredentialsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr);
      ClientCredentialsInternal.NativeFieldInfoPtr_m_ClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, nameof (m_ClientId));
      ClientCredentialsInternal.NativeFieldInfoPtr_m_ClientSecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, nameof (m_ClientSecret));
      ClientCredentialsInternal.NativeMethodInfoPtr_get_ClientId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100674630);
      ClientCredentialsInternal.NativeMethodInfoPtr_set_ClientId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100674631);
      ClientCredentialsInternal.NativeMethodInfoPtr_get_ClientSecret_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100674632);
      ClientCredentialsInternal.NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100674633);
      ClientCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100674634);
      ClientCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100674635);
      ClientCredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100674636);
      ClientCredentialsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100674637);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
