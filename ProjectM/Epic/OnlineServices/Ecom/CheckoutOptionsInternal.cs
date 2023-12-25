// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CheckoutOptionsInternal
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
  public struct CheckoutOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideCatalogNamespace;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EntryCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Entries;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideCatalogNamespace_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Entries_Public_set_Void_Il2CppReferenceArray_1_CheckoutEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CheckoutOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CheckoutOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_OverrideCatalogNamespace;
    [FieldOffset(24)]
    public uint m_EntryCount;
    [FieldOffset(32)]
    public System.IntPtr m_Entries;

    public unsafe EpicAccountId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961805, XrefRangeEnd = 961809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OverrideCatalogNamespace
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961809, XrefRangeEnd = 961813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_set_OverrideCatalogNamespace_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<CheckoutEntry> Entries
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 961819, RefRangeEnd = 961821, XrefRangeStart = 961813, XrefRangeEnd = 961819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_set_Entries_Public_set_Void_Il2CppReferenceArray_1_CheckoutEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 961830, RefRangeEnd = 961831, XrefRangeStart = 961821, XrefRangeEnd = 961830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref CheckoutOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CheckoutOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961831, XrefRangeEnd = 961848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<CheckoutOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CheckoutOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961848, XrefRangeEnd = 961854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CheckoutOptionsInternal()
    {
      Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (CheckoutOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr);
      CheckoutOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CheckoutOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      CheckoutOptionsInternal.NativeFieldInfoPtr_m_OverrideCatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_OverrideCatalogNamespace));
      CheckoutOptionsInternal.NativeFieldInfoPtr_m_EntryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_EntryCount));
      CheckoutOptionsInternal.NativeFieldInfoPtr_m_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_Entries));
      CheckoutOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100671860);
      CheckoutOptionsInternal.NativeMethodInfoPtr_set_OverrideCatalogNamespace_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100671861);
      CheckoutOptionsInternal.NativeMethodInfoPtr_set_Entries_Public_set_Void_Il2CppReferenceArray_1_CheckoutEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100671862);
      CheckoutOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CheckoutOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100671863);
      CheckoutOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CheckoutOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100671864);
      CheckoutOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100671865);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
