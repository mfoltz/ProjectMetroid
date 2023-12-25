// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.PinGrantInfoInternal
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
  public struct PinGrantInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_VerificationURI;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpiresIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_VerificationURIComplete;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserCode_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserCode_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VerificationURI_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PinGrantInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PinGrantInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PinGrantInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_UserCode;
    [FieldOffset(16)]
    public System.IntPtr m_VerificationURI;
    [FieldOffset(24)]
    public int m_ExpiresIn;
    [FieldOffset(32)]
    public System.IntPtr m_VerificationURIComplete;

    public unsafe Epic.OnlineServices.Utf8String UserCode
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968016, XrefRangeEnd = 968020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_get_UserCode_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968020, XrefRangeEnd = 968024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_set_UserCode_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String VerificationURI
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968024, XrefRangeEnd = 968028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_get_VerificationURI_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968028, XrefRangeEnd = 968032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int ExpiresIn
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String VerificationURIComplete
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968032, XrefRangeEnd = 968036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968036, XrefRangeEnd = 968040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968040, XrefRangeEnd = 968052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref PinGrantInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PinGrantInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968052, XrefRangeEnd = 968074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<PinGrantInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PinGrantInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968074, XrefRangeEnd = 968080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968080, XrefRangeEnd = 968081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out PinGrantInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PinGrantInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PinGrantInfo local = ref output;
      System.IntPtr pointer = zero;
      PinGrantInfo pinGrantInfo = pointer == System.IntPtr.Zero ? (PinGrantInfo) null : new PinGrantInfo(pointer);
      local = pinGrantInfo;
    }

    static PinGrantInfoInternal()
    {
      Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (PinGrantInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr);
      PinGrantInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PinGrantInfoInternal.NativeFieldInfoPtr_m_UserCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_UserCode));
      PinGrantInfoInternal.NativeFieldInfoPtr_m_VerificationURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_VerificationURI));
      PinGrantInfoInternal.NativeFieldInfoPtr_m_ExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_ExpiresIn));
      PinGrantInfoInternal.NativeFieldInfoPtr_m_VerificationURIComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_VerificationURIComplete));
      PinGrantInfoInternal.NativeMethodInfoPtr_get_UserCode_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673548);
      PinGrantInfoInternal.NativeMethodInfoPtr_set_UserCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673549);
      PinGrantInfoInternal.NativeMethodInfoPtr_get_VerificationURI_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673550);
      PinGrantInfoInternal.NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673551);
      PinGrantInfoInternal.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673552);
      PinGrantInfoInternal.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673553);
      PinGrantInfoInternal.NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673554);
      PinGrantInfoInternal.NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673555);
      PinGrantInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PinGrantInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673556);
      PinGrantInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PinGrantInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673557);
      PinGrantInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673558);
      PinGrantInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PinGrantInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100673559);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
