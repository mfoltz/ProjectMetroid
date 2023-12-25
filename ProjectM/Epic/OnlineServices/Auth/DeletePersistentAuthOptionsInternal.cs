// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.DeletePersistentAuthOptionsInternal
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
  public struct DeletePersistentAuthOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshToken;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DeletePersistentAuthOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DeletePersistentAuthOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_RefreshToken;

    public unsafe Epic.OnlineServices.Utf8String RefreshToken
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967356, XrefRangeEnd = 967360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 967364, RefRangeEnd = 967365, XrefRangeStart = 967360, XrefRangeEnd = 967364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref DeletePersistentAuthOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DeletePersistentAuthOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967365, XrefRangeEnd = 967373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<DeletePersistentAuthOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DeletePersistentAuthOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 967373, XrefRangeEnd = 967377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeletePersistentAuthOptionsInternal()
    {
      Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (DeletePersistentAuthOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr);
      DeletePersistentAuthOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      DeletePersistentAuthOptionsInternal.NativeFieldInfoPtr_m_RefreshToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, nameof (m_RefreshToken));
      DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, 100673327);
      DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DeletePersistentAuthOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, 100673328);
      DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DeletePersistentAuthOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, 100673329);
      DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, 100673330);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
