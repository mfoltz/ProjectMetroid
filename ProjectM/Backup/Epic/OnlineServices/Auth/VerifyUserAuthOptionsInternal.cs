// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.VerifyUserAuthOptionsInternal
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
  public struct VerifyUserAuthOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AuthToken;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Nullable_1_Token_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_VerifyUserAuthOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_VerifyUserAuthOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_AuthToken;

    public unsafe Il2CppSystem.Nullable<Token> AuthToken
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968722, XrefRangeEnd = 968728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Nullable_1_Token_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 968734, RefRangeEnd = 968735, XrefRangeStart = 968728, XrefRangeEnd = 968734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref VerifyUserAuthOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_VerifyUserAuthOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968735, XrefRangeEnd = 968745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<VerifyUserAuthOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_VerifyUserAuthOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968745, XrefRangeEnd = 968749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VerifyUserAuthOptionsInternal()
    {
      Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (VerifyUserAuthOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr);
      VerifyUserAuthOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      VerifyUserAuthOptionsInternal.NativeFieldInfoPtr_m_AuthToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, nameof (m_AuthToken));
      VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Nullable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, 100673719);
      VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_VerifyUserAuthOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, 100673720);
      VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_VerifyUserAuthOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, 100673721);
      VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, 100673722);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
