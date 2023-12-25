// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogOffer
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
  public sealed class CatalogOffer : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerIndex_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CatalogNamespace_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Id_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TitleText_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DescriptionText_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LongDescriptionText_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TechnicalDetailsText_DEPRECATED_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrencyCode_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PriceResult_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalPrice_DEPRECATED_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPrice_DEPRECATED_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscountPercentage_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ExpirationTimestamp_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PurchasedCount_DEPRECATED_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PurchaseLimit_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AvailableForPurchase_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalPrice64_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPrice64_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DecimalPoint_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReleaseDateTimestamp_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__EffectiveDateTimestamp_k__BackingField;
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
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_CatalogOfferInternal_0;

    public unsafe int ServerIndex
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CatalogNamespace
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Id
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String TitleText
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_TitleText_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_TitleText_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DescriptionText
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_DescriptionText_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LongDescriptionText
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String TechnicalDetailsText_DEPRECATED
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CurrencyCode
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 22398, RefRangeEnd = 22405, XrefRangeStart = 22398, XrefRangeEnd = 22405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_CurrencyCode_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23675, RefRangeEnd = 23677, XrefRangeStart = 23675, XrefRangeEnd = 23677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Result PriceResult
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Result*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint OriginalPrice_DEPRECATED
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint CurrentPrice_DEPRECATED
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 45778, RefRangeEnd = 45781, XrefRangeStart = 45778, XrefRangeEnd = 45781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe byte DiscountPercentage
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long ExpirationTimestamp
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22805, RefRangeEnd = 22806, XrefRangeStart = 22805, XrefRangeEnd = 22806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint PurchasedCount_DEPRECATED
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 43842, RefRangeEnd = 43846, XrefRangeStart = 43842, XrefRangeEnd = 43846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_PurchasedCount_DEPRECATED_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 86269, RefRangeEnd = 86272, XrefRangeStart = 86269, XrefRangeEnd = 86272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_PurchasedCount_DEPRECATED_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int PurchaseLimit
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 86251, RefRangeEnd = 86253, XrefRangeStart = 86251, XrefRangeEnd = 86253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool AvailableForPurchase
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OriginalPrice64
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong CurrentPrice64
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22439, RefRangeEnd = 22440, XrefRangeStart = 22439, XrefRangeEnd = 22440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint DecimalPoint
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long ReleaseDateTimestamp
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_ReleaseDateTimestamp_Public_get_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_ReleaseDateTimestamp_Public_set_Void_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long EffectiveDateTimestamp
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_get_EffectiveDateTimestamp_Public_get_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_set_EffectiveDateTimestamp_Public_set_Void_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 961430, RefRangeEnd = 961431, XrefRangeStart = 961391, XrefRangeEnd = 961430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref CatalogOfferInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CatalogOffer.NativeMethodInfoPtr_Set_Internal_Void_byref_CatalogOfferInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CatalogOffer()
    {
      Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (CatalogOffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr);
      CatalogOffer.NativeFieldInfoPtr__ServerIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<ServerIndex>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__CatalogNamespace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<CatalogNamespace>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<Id>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__TitleText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<TitleText>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__DescriptionText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<DescriptionText>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__LongDescriptionText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<LongDescriptionText>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__TechnicalDetailsText_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<TechnicalDetailsText_DEPRECATED>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__CurrencyCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<CurrencyCode>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__PriceResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<PriceResult>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__OriginalPrice_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<OriginalPrice_DEPRECATED>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__CurrentPrice_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<CurrentPrice_DEPRECATED>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__DiscountPercentage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<DiscountPercentage>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__ExpirationTimestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<ExpirationTimestamp>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__PurchasedCount_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<PurchasedCount_DEPRECATED>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__PurchaseLimit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<PurchaseLimit>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__AvailableForPurchase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<AvailableForPurchase>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__OriginalPrice64_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<OriginalPrice64>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__CurrentPrice64_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<CurrentPrice64>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__DecimalPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<DecimalPoint>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__ReleaseDateTimestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<ReleaseDateTimestamp>k__BackingField");
      CatalogOffer.NativeFieldInfoPtr__EffectiveDateTimestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, "<EffectiveDateTimestamp>k__BackingField");
      CatalogOffer.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671716);
      CatalogOffer.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671717);
      CatalogOffer.NativeMethodInfoPtr_get_CatalogNamespace_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671718);
      CatalogOffer.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671719);
      CatalogOffer.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671720);
      CatalogOffer.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671721);
      CatalogOffer.NativeMethodInfoPtr_get_TitleText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671722);
      CatalogOffer.NativeMethodInfoPtr_set_TitleText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671723);
      CatalogOffer.NativeMethodInfoPtr_get_DescriptionText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671724);
      CatalogOffer.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671725);
      CatalogOffer.NativeMethodInfoPtr_get_LongDescriptionText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671726);
      CatalogOffer.NativeMethodInfoPtr_set_LongDescriptionText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671727);
      CatalogOffer.NativeMethodInfoPtr_get_TechnicalDetailsText_DEPRECATED_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671728);
      CatalogOffer.NativeMethodInfoPtr_set_TechnicalDetailsText_DEPRECATED_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671729);
      CatalogOffer.NativeMethodInfoPtr_get_CurrencyCode_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671730);
      CatalogOffer.NativeMethodInfoPtr_set_CurrencyCode_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671731);
      CatalogOffer.NativeMethodInfoPtr_get_PriceResult_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671732);
      CatalogOffer.NativeMethodInfoPtr_set_PriceResult_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671733);
      CatalogOffer.NativeMethodInfoPtr_get_OriginalPrice_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671734);
      CatalogOffer.NativeMethodInfoPtr_set_OriginalPrice_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671735);
      CatalogOffer.NativeMethodInfoPtr_get_CurrentPrice_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671736);
      CatalogOffer.NativeMethodInfoPtr_set_CurrentPrice_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671737);
      CatalogOffer.NativeMethodInfoPtr_get_DiscountPercentage_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671738);
      CatalogOffer.NativeMethodInfoPtr_set_DiscountPercentage_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671739);
      CatalogOffer.NativeMethodInfoPtr_get_ExpirationTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671740);
      CatalogOffer.NativeMethodInfoPtr_set_ExpirationTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671741);
      CatalogOffer.NativeMethodInfoPtr_get_PurchasedCount_DEPRECATED_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671742);
      CatalogOffer.NativeMethodInfoPtr_set_PurchasedCount_DEPRECATED_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671743);
      CatalogOffer.NativeMethodInfoPtr_get_PurchaseLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671744);
      CatalogOffer.NativeMethodInfoPtr_set_PurchaseLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671745);
      CatalogOffer.NativeMethodInfoPtr_get_AvailableForPurchase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671746);
      CatalogOffer.NativeMethodInfoPtr_set_AvailableForPurchase_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671747);
      CatalogOffer.NativeMethodInfoPtr_get_OriginalPrice64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671748);
      CatalogOffer.NativeMethodInfoPtr_set_OriginalPrice64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671749);
      CatalogOffer.NativeMethodInfoPtr_get_CurrentPrice64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671750);
      CatalogOffer.NativeMethodInfoPtr_set_CurrentPrice64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671751);
      CatalogOffer.NativeMethodInfoPtr_get_DecimalPoint_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671752);
      CatalogOffer.NativeMethodInfoPtr_set_DecimalPoint_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671753);
      CatalogOffer.NativeMethodInfoPtr_get_ReleaseDateTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671754);
      CatalogOffer.NativeMethodInfoPtr_set_ReleaseDateTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671755);
      CatalogOffer.NativeMethodInfoPtr_get_EffectiveDateTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671756);
      CatalogOffer.NativeMethodInfoPtr_set_EffectiveDateTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671757);
      CatalogOffer.NativeMethodInfoPtr_Set_Internal_Void_byref_CatalogOfferInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, 100671758);
    }

    public CatalogOffer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CatalogOffer()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CatalogOffer>.NativeClassPtr, data));
    }

    public unsafe int _ServerIndex_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ServerIndex_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ServerIndex_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _CatalogNamespace_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CatalogNamespace_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CatalogNamespace_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _Id_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__Id_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _TitleText_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__TitleText_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__TitleText_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _DescriptionText_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DescriptionText_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DescriptionText_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _LongDescriptionText_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__LongDescriptionText_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__LongDescriptionText_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _TechnicalDetailsText_DEPRECATED_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__TechnicalDetailsText_DEPRECATED_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__TechnicalDetailsText_DEPRECATED_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _CurrencyCode_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrencyCode_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrencyCode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Result _PriceResult_k__BackingField
    {
      get
      {
        return *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PriceResult_k__BackingField));
      }
      [param: In] set
      {
        *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PriceResult_k__BackingField)) = value;
      }
    }

    public unsafe uint _OriginalPrice_DEPRECATED_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__OriginalPrice_DEPRECATED_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__OriginalPrice_DEPRECATED_k__BackingField)) = value;
      }
    }

    public unsafe uint _CurrentPrice_DEPRECATED_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrentPrice_DEPRECATED_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrentPrice_DEPRECATED_k__BackingField)) = value;
      }
    }

    public unsafe byte _DiscountPercentage_k__BackingField
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DiscountPercentage_k__BackingField));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DiscountPercentage_k__BackingField)) = value;
      }
    }

    public unsafe long _ExpirationTimestamp_k__BackingField
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ExpirationTimestamp_k__BackingField));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ExpirationTimestamp_k__BackingField)) = value;
      }
    }

    public unsafe uint _PurchasedCount_DEPRECATED_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PurchasedCount_DEPRECATED_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PurchasedCount_DEPRECATED_k__BackingField)) = value;
      }
    }

    public unsafe int _PurchaseLimit_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PurchaseLimit_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__PurchaseLimit_k__BackingField)) = value;
      }
    }

    public unsafe bool _AvailableForPurchase_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__AvailableForPurchase_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__AvailableForPurchase_k__BackingField)) = value;
      }
    }

    public unsafe ulong _OriginalPrice64_k__BackingField
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__OriginalPrice64_k__BackingField));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__OriginalPrice64_k__BackingField)) = value;
      }
    }

    public unsafe ulong _CurrentPrice64_k__BackingField
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrentPrice64_k__BackingField));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__CurrentPrice64_k__BackingField)) = value;
      }
    }

    public unsafe uint _DecimalPoint_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DecimalPoint_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__DecimalPoint_k__BackingField)) = value;
      }
    }

    public unsafe long _ReleaseDateTimestamp_k__BackingField
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ReleaseDateTimestamp_k__BackingField));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__ReleaseDateTimestamp_k__BackingField)) = value;
      }
    }

    public unsafe long _EffectiveDateTimestamp_k__BackingField
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__EffectiveDateTimestamp_k__BackingField));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CatalogOffer.NativeFieldInfoPtr__EffectiveDateTimestamp_k__BackingField)) = value;
      }
    }
  }
}
