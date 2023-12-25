// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogOfferInternal
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
  public struct CatalogOfferInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ServerIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogNamespace;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TitleText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DescriptionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LongDescriptionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TechnicalDetailsText_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrencyCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PriceResult;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalPrice_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentPrice_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DiscountPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpirationTimestamp;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PurchasedCount_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PurchaseLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AvailableForPurchase;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalPrice64;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentPrice64;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DecimalPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReleaseDateTimestamp;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveDateTimestamp;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CatalogNamespace_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TitleText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TitleText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DescriptionText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LongDescriptionText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrencyCode_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PurchasedCount_DEPRECATED_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PurchasedCount_DEPRECATED_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReleaseDateTimestamp_Public_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReleaseDateTimestamp_Public_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EffectiveDateTimestamp_Public_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EffectiveDateTimestamp_Public_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogOffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogOffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogOffer_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public int m_ServerIndex;
    [FieldOffset(8)]
    public System.IntPtr m_CatalogNamespace;
    [FieldOffset(16)]
    public System.IntPtr m_Id;
    [FieldOffset(24)]
    public System.IntPtr m_TitleText;
    [FieldOffset(32)]
    public System.IntPtr m_DescriptionText;
    [FieldOffset(40)]
    public System.IntPtr m_LongDescriptionText;
    [FieldOffset(48)]
    public System.IntPtr m_TechnicalDetailsText_DEPRECATED;
    [FieldOffset(56)]
    public System.IntPtr m_CurrencyCode;
    [FieldOffset(64)]
    public Result m_PriceResult;
    [FieldOffset(68)]
    public uint m_OriginalPrice_DEPRECATED;
    [FieldOffset(72)]
    public uint m_CurrentPrice_DEPRECATED;
    [FieldOffset(76)]
    public byte m_DiscountPercentage;
    [FieldOffset(80)]
    public long m_ExpirationTimestamp;
    [FieldOffset(88)]
    public uint m_PurchasedCount_DEPRECATED;
    [FieldOffset(92)]
    public int m_PurchaseLimit;
    [FieldOffset(96)]
    public int m_AvailableForPurchase;
    [FieldOffset(104)]
    public ulong m_OriginalPrice64;
    [FieldOffset(112)]
    public ulong m_CurrentPrice64;
    [FieldOffset(120)]
    public uint m_DecimalPoint;
    [FieldOffset(128)]
    public long m_ReleaseDateTimestamp;
    [FieldOffset(136)]
    public long m_EffectiveDateTimestamp;

    public unsafe int ServerIndex
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CatalogNamespace
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961431, XrefRangeEnd = 961435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961435, XrefRangeEnd = 961439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Id
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961439, XrefRangeEnd = 961443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961443, XrefRangeEnd = 961447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String TitleText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961447, XrefRangeEnd = 961451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_TitleText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961451, XrefRangeEnd = 961455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_TitleText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DescriptionText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961455, XrefRangeEnd = 961459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_DescriptionText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961459, XrefRangeEnd = 961463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LongDescriptionText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961463, XrefRangeEnd = 961467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961467, XrefRangeEnd = 961471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String TechnicalDetailsText_DEPRECATED
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961471, XrefRangeEnd = 961475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961475, XrefRangeEnd = 961479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CurrencyCode
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961479, XrefRangeEnd = 961483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_CurrencyCode_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961483, XrefRangeEnd = 961487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Result PriceResult
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Result*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint OriginalPrice_DEPRECATED
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint CurrentPrice_DEPRECATED
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 45778, RefRangeEnd = 45781, XrefRangeStart = 45778, XrefRangeEnd = 45781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe byte DiscountPercentage
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long ExpirationTimestamp
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22805, RefRangeEnd = 22806, XrefRangeStart = 22805, XrefRangeEnd = 22806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint PurchasedCount_DEPRECATED
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 43842, RefRangeEnd = 43846, XrefRangeStart = 43842, XrefRangeEnd = 43846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_PurchasedCount_DEPRECATED_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 86269, RefRangeEnd = 86272, XrefRangeStart = 86269, XrefRangeEnd = 86272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_PurchasedCount_DEPRECATED_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int PurchaseLimit
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 86251, RefRangeEnd = 86253, XrefRangeStart = 86251, XrefRangeEnd = 86253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool AvailableForPurchase
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961487, XrefRangeEnd = 961491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961491, XrefRangeEnd = 961495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OriginalPrice64
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong CurrentPrice64
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22439, RefRangeEnd = 22440, XrefRangeStart = 22439, XrefRangeEnd = 22440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint DecimalPoint
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long ReleaseDateTimestamp
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_ReleaseDateTimestamp_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_ReleaseDateTimestamp_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long EffectiveDateTimestamp
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_get_EffectiveDateTimestamp_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_set_EffectiveDateTimestamp_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961495, XrefRangeEnd = 961527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref CatalogOffer other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogOffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961527, XrefRangeEnd = 961603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<CatalogOffer> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogOffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961603, XrefRangeEnd = 961613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961613, XrefRangeEnd = 961614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out CatalogOffer output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogOfferInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogOffer_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref CatalogOffer local = ref output;
      System.IntPtr pointer = zero;
      CatalogOffer catalogOffer = pointer == System.IntPtr.Zero ? (CatalogOffer) null : new CatalogOffer(pointer);
      local = catalogOffer;
    }

    static CatalogOfferInternal()
    {
      Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (CatalogOfferInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr);
      CatalogOfferInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CatalogOfferInternal.NativeFieldInfoPtr_m_ServerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_ServerIndex));
      CatalogOfferInternal.NativeFieldInfoPtr_m_CatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_CatalogNamespace));
      CatalogOfferInternal.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_Id));
      CatalogOfferInternal.NativeFieldInfoPtr_m_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_TitleText));
      CatalogOfferInternal.NativeFieldInfoPtr_m_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_DescriptionText));
      CatalogOfferInternal.NativeFieldInfoPtr_m_LongDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_LongDescriptionText));
      CatalogOfferInternal.NativeFieldInfoPtr_m_TechnicalDetailsText_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_TechnicalDetailsText_DEPRECATED));
      CatalogOfferInternal.NativeFieldInfoPtr_m_CurrencyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_CurrencyCode));
      CatalogOfferInternal.NativeFieldInfoPtr_m_PriceResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_PriceResult));
      CatalogOfferInternal.NativeFieldInfoPtr_m_OriginalPrice_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_OriginalPrice_DEPRECATED));
      CatalogOfferInternal.NativeFieldInfoPtr_m_CurrentPrice_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_CurrentPrice_DEPRECATED));
      CatalogOfferInternal.NativeFieldInfoPtr_m_DiscountPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_DiscountPercentage));
      CatalogOfferInternal.NativeFieldInfoPtr_m_ExpirationTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_ExpirationTimestamp));
      CatalogOfferInternal.NativeFieldInfoPtr_m_PurchasedCount_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_PurchasedCount_DEPRECATED));
      CatalogOfferInternal.NativeFieldInfoPtr_m_PurchaseLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_PurchaseLimit));
      CatalogOfferInternal.NativeFieldInfoPtr_m_AvailableForPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_AvailableForPurchase));
      CatalogOfferInternal.NativeFieldInfoPtr_m_OriginalPrice64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_OriginalPrice64));
      CatalogOfferInternal.NativeFieldInfoPtr_m_CurrentPrice64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_CurrentPrice64));
      CatalogOfferInternal.NativeFieldInfoPtr_m_DecimalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_DecimalPoint));
      CatalogOfferInternal.NativeFieldInfoPtr_m_ReleaseDateTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_ReleaseDateTimestamp));
      CatalogOfferInternal.NativeFieldInfoPtr_m_EffectiveDateTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, nameof (m_EffectiveDateTimestamp));
      CatalogOfferInternal.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671759);
      CatalogOfferInternal.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671760);
      CatalogOfferInternal.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671761);
      CatalogOfferInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671762);
      CatalogOfferInternal.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671763);
      CatalogOfferInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671764);
      CatalogOfferInternal.NativeMethodInfoPtr_get_TitleText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671765);
      CatalogOfferInternal.NativeMethodInfoPtr_set_TitleText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671766);
      CatalogOfferInternal.NativeMethodInfoPtr_get_DescriptionText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671767);
      CatalogOfferInternal.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671768);
      CatalogOfferInternal.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671769);
      CatalogOfferInternal.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671770);
      CatalogOfferInternal.NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671771);
      CatalogOfferInternal.NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671772);
      CatalogOfferInternal.NativeMethodInfoPtr_get_CurrencyCode_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671773);
      CatalogOfferInternal.NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671774);
      CatalogOfferInternal.NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671775);
      CatalogOfferInternal.NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671776);
      CatalogOfferInternal.NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671777);
      CatalogOfferInternal.NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671778);
      CatalogOfferInternal.NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671779);
      CatalogOfferInternal.NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671780);
      CatalogOfferInternal.NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671781);
      CatalogOfferInternal.NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671782);
      CatalogOfferInternal.NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671783);
      CatalogOfferInternal.NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671784);
      CatalogOfferInternal.NativeMethodInfoPtr_get_PurchasedCount_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671785);
      CatalogOfferInternal.NativeMethodInfoPtr_set_PurchasedCount_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671786);
      CatalogOfferInternal.NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671787);
      CatalogOfferInternal.NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671788);
      CatalogOfferInternal.NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671789);
      CatalogOfferInternal.NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671790);
      CatalogOfferInternal.NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671791);
      CatalogOfferInternal.NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671792);
      CatalogOfferInternal.NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671793);
      CatalogOfferInternal.NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671794);
      CatalogOfferInternal.NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671795);
      CatalogOfferInternal.NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671796);
      CatalogOfferInternal.NativeMethodInfoPtr_get_ReleaseDateTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671797);
      CatalogOfferInternal.NativeMethodInfoPtr_set_ReleaseDateTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671798);
      CatalogOfferInternal.NativeMethodInfoPtr_get_EffectiveDateTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671799);
      CatalogOfferInternal.NativeMethodInfoPtr_set_EffectiveDateTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671800);
      CatalogOfferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CatalogOffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671801);
      CatalogOfferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CatalogOffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671802);
      CatalogOfferInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671803);
      CatalogOfferInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_CatalogOffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, 100671804);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CatalogOfferInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
