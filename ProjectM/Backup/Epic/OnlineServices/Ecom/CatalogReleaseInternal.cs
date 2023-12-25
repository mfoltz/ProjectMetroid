// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogReleaseInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CatalogReleaseInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CompatibleAppIdCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CompatibleAppIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CompatiblePlatformCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CompatiblePlatforms;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReleaseNote;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReleaseNote_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogRelease_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogRelease_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogRelease_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public uint m_CompatibleAppIdCount;
    [FieldOffset(8)]
    public System.IntPtr m_CompatibleAppIds;
    [FieldOffset(16)]
    public uint m_CompatiblePlatformCount;
    [FieldOffset(24)]
    public System.IntPtr m_CompatiblePlatforms;
    [FieldOffset(32)]
    public System.IntPtr m_ReleaseNote;

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> CompatibleAppIds
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 961630, RefRangeEnd = 961631, XrefRangeStart = 961624, XrefRangeEnd = 961630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Utf8String>) null : new Il2CppReferenceArray<Epic.OnlineServices.Utf8String>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 961637, RefRangeEnd = 961639, XrefRangeStart = 961631, XrefRangeEnd = 961637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> CompatiblePlatforms
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 961645, RefRangeEnd = 961646, XrefRangeStart = 961639, XrefRangeEnd = 961645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Utf8String>) null : new Il2CppReferenceArray<Epic.OnlineServices.Utf8String>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 961652, RefRangeEnd = 961654, XrefRangeStart = 961646, XrefRangeEnd = 961652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ReleaseNote
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961654, XrefRangeEnd = 961658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_get_ReleaseNote_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961658, XrefRangeEnd = 961662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961662, XrefRangeEnd = 961668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref CatalogRelease other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogRelease_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961668, XrefRangeEnd = 961682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<CatalogRelease> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogRelease_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961682, XrefRangeEnd = 961688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961688, XrefRangeEnd = 961689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out CatalogRelease output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogRelease_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref CatalogRelease local = ref output;
      System.IntPtr pointer = zero;
      CatalogRelease catalogRelease = pointer == System.IntPtr.Zero ? (CatalogRelease) null : new CatalogRelease(pointer);
      local = catalogRelease;
    }

    static CatalogReleaseInternal()
    {
      Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (CatalogReleaseInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr);
      CatalogReleaseInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CatalogReleaseInternal.NativeFieldInfoPtr_m_CompatibleAppIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_CompatibleAppIdCount));
      CatalogReleaseInternal.NativeFieldInfoPtr_m_CompatibleAppIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_CompatibleAppIds));
      CatalogReleaseInternal.NativeFieldInfoPtr_m_CompatiblePlatformCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_CompatiblePlatformCount));
      CatalogReleaseInternal.NativeFieldInfoPtr_m_CompatiblePlatforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_CompatiblePlatforms));
      CatalogReleaseInternal.NativeFieldInfoPtr_m_ReleaseNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_ReleaseNote));
      CatalogReleaseInternal.NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671812);
      CatalogReleaseInternal.NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671813);
      CatalogReleaseInternal.NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671814);
      CatalogReleaseInternal.NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671815);
      CatalogReleaseInternal.NativeMethodInfoPtr_get_ReleaseNote_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671816);
      CatalogReleaseInternal.NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671817);
      CatalogReleaseInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogRelease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671818);
      CatalogReleaseInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogRelease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671819);
      CatalogReleaseInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671820);
      CatalogReleaseInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogRelease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100671821);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
