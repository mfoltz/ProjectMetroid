// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogItemInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CatalogItemInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogNamespace;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TitleText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DescriptionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LongDescriptionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TechnicalDetailsText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DeveloperText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementEndTimestamp;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CatalogNamespace_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitlementName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TitleText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TitleText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DescriptionText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LongDescriptionText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TechnicalDetailsText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TechnicalDetailsText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeveloperText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DeveloperText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemType_Public_get_EcomItemType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemType_Public_set_Void_EcomItemType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitlementEndTimestamp_Public_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementEndTimestamp_Public_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogItem_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_CatalogNamespace;
    [FieldOffset(16)]
    public System.IntPtr m_Id;
    [FieldOffset(24)]
    public System.IntPtr m_EntitlementName;
    [FieldOffset(32)]
    public System.IntPtr m_TitleText;
    [FieldOffset(40)]
    public System.IntPtr m_DescriptionText;
    [FieldOffset(48)]
    public System.IntPtr m_LongDescriptionText;
    [FieldOffset(56)]
    public System.IntPtr m_TechnicalDetailsText;
    [FieldOffset(64)]
    public System.IntPtr m_DeveloperText;
    [FieldOffset(72)]
    public EcomItemType m_ItemType;
    [FieldOffset(80)]
    public long m_EntitlementEndTimestamp;

    public unsafe Epic.OnlineServices.Utf8String CatalogNamespace
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961229, XrefRangeEnd = 961233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961233, XrefRangeEnd = 961237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Id
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961237, XrefRangeEnd = 961241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961241, XrefRangeEnd = 961245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String EntitlementName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961245, XrefRangeEnd = 961249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_EntitlementName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961249, XrefRangeEnd = 961253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String TitleText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961253, XrefRangeEnd = 961257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_TitleText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961257, XrefRangeEnd = 961261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_TitleText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DescriptionText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961261, XrefRangeEnd = 961265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_DescriptionText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961265, XrefRangeEnd = 961269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LongDescriptionText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961269, XrefRangeEnd = 961273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961273, XrefRangeEnd = 961277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String TechnicalDetailsText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961277, XrefRangeEnd = 961281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_TechnicalDetailsText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961281, XrefRangeEnd = 961285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_TechnicalDetailsText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DeveloperText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961285, XrefRangeEnd = 961289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_DeveloperText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961289, XrefRangeEnd = 961293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_DeveloperText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EcomItemType ItemType
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 45778, RefRangeEnd = 45781, XrefRangeStart = 45778, XrefRangeEnd = 45781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_ItemType_Public_get_EcomItemType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EcomItemType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_ItemType_Public_set_Void_EcomItemType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long EntitlementEndTimestamp
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22805, RefRangeEnd = 22806, XrefRangeStart = 22805, XrefRangeEnd = 22806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_get_EntitlementEndTimestamp_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_set_EntitlementEndTimestamp_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961293, XrefRangeEnd = 961325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref CatalogItem other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogItem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961325, XrefRangeEnd = 961379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<CatalogItem> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogItem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961379, XrefRangeEnd = 961390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961390, XrefRangeEnd = 961391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out CatalogItem output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogItemInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogItem_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref CatalogItem local = ref output;
      System.IntPtr pointer = zero;
      CatalogItem catalogItem = pointer == System.IntPtr.Zero ? (CatalogItem) null : new CatalogItem(pointer);
      local = catalogItem;
    }

    static CatalogItemInternal()
    {
      Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (CatalogItemInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr);
      CatalogItemInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CatalogItemInternal.NativeFieldInfoPtr_m_CatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_CatalogNamespace));
      CatalogItemInternal.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_Id));
      CatalogItemInternal.NativeFieldInfoPtr_m_EntitlementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_EntitlementName));
      CatalogItemInternal.NativeFieldInfoPtr_m_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_TitleText));
      CatalogItemInternal.NativeFieldInfoPtr_m_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_DescriptionText));
      CatalogItemInternal.NativeFieldInfoPtr_m_LongDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_LongDescriptionText));
      CatalogItemInternal.NativeFieldInfoPtr_m_TechnicalDetailsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_TechnicalDetailsText));
      CatalogItemInternal.NativeFieldInfoPtr_m_DeveloperText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_DeveloperText));
      CatalogItemInternal.NativeFieldInfoPtr_m_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_ItemType));
      CatalogItemInternal.NativeFieldInfoPtr_m_EntitlementEndTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, nameof (m_EntitlementEndTimestamp));
      CatalogItemInternal.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671692);
      CatalogItemInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671693);
      CatalogItemInternal.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671694);
      CatalogItemInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671695);
      CatalogItemInternal.NativeMethodInfoPtr_get_EntitlementName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671696);
      CatalogItemInternal.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671697);
      CatalogItemInternal.NativeMethodInfoPtr_get_TitleText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671698);
      CatalogItemInternal.NativeMethodInfoPtr_set_TitleText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671699);
      CatalogItemInternal.NativeMethodInfoPtr_get_DescriptionText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671700);
      CatalogItemInternal.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671701);
      CatalogItemInternal.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671702);
      CatalogItemInternal.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671703);
      CatalogItemInternal.NativeMethodInfoPtr_get_TechnicalDetailsText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671704);
      CatalogItemInternal.NativeMethodInfoPtr_set_TechnicalDetailsText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671705);
      CatalogItemInternal.NativeMethodInfoPtr_get_DeveloperText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671706);
      CatalogItemInternal.NativeMethodInfoPtr_set_DeveloperText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671707);
      CatalogItemInternal.NativeMethodInfoPtr_get_ItemType_Public_get_EcomItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671708);
      CatalogItemInternal.NativeMethodInfoPtr_set_ItemType_Public_set_Void_EcomItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671709);
      CatalogItemInternal.NativeMethodInfoPtr_get_EntitlementEndTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671710);
      CatalogItemInternal.NativeMethodInfoPtr_set_EntitlementEndTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671711);
      CatalogItemInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671712);
      CatalogItemInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671713);
      CatalogItemInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671714);
      CatalogItemInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, 100671715);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CatalogItemInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
