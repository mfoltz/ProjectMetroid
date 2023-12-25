// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogRelease
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
  public sealed class CatalogRelease : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CompatibleAppIds_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CompatiblePlatforms_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReleaseNote_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReleaseNote_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_CatalogReleaseInternal_0;

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> CompatibleAppIds
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogRelease.NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppReferenceArray_1_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Utf8String>) null : new Il2CppReferenceArray<Epic.OnlineServices.Utf8String>(nativeObject);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogRelease.NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> CompatiblePlatforms
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogRelease.NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppReferenceArray_1_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Utf8String>) null : new Il2CppReferenceArray<Epic.OnlineServices.Utf8String>(nativeObject);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogRelease.NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ReleaseNote
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogRelease.NativeMethodInfoPtr_get_ReleaseNote_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogRelease.NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 961623, RefRangeEnd = 961624, XrefRangeStart = 961614, XrefRangeEnd = 961623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref CatalogReleaseInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogRelease.NativeMethodInfoPtr_Set_Internal_Void_byref_CatalogReleaseInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CatalogRelease()
    {
      Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (CatalogRelease));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr);
      CatalogRelease.NativeFieldInfoPtr__CompatibleAppIds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, "<CompatibleAppIds>k__BackingField");
      CatalogRelease.NativeFieldInfoPtr__CompatiblePlatforms_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, "<CompatiblePlatforms>k__BackingField");
      CatalogRelease.NativeFieldInfoPtr__ReleaseNote_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, "<ReleaseNote>k__BackingField");
      CatalogRelease.NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, 100671805);
      CatalogRelease.NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, 100671806);
      CatalogRelease.NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, 100671807);
      CatalogRelease.NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, 100671808);
      CatalogRelease.NativeMethodInfoPtr_get_ReleaseNote_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, 100671809);
      CatalogRelease.NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, 100671810);
      CatalogRelease.NativeMethodInfoPtr_Set_Internal_Void_byref_CatalogReleaseInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, 100671811);
    }

    public CatalogRelease(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CatalogRelease()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CatalogRelease>.NativeClassPtr, data));
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> _CompatibleAppIds_k__BackingField
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogRelease.NativeFieldInfoPtr__CompatibleAppIds_k__BackingField));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Utf8String>) null : new Il2CppReferenceArray<Epic.OnlineServices.Utf8String>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogRelease.NativeFieldInfoPtr__CompatibleAppIds_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> _CompatiblePlatforms_k__BackingField
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogRelease.NativeFieldInfoPtr__CompatiblePlatforms_k__BackingField));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Utf8String>) null : new Il2CppReferenceArray<Epic.OnlineServices.Utf8String>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogRelease.NativeFieldInfoPtr__CompatiblePlatforms_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _ReleaseNote_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogRelease.NativeFieldInfoPtr__ReleaseNote_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogRelease.NativeFieldInfoPtr__ReleaseNote_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
