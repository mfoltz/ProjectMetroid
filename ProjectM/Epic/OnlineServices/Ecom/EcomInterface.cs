// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.EcomInterface
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
  public sealed class EcomInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CatalogitemApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CatalogitemEntitlementendtimestampUndefined;
    private static readonly System.IntPtr NativeFieldInfoPtr_CatalogofferApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CatalogofferEffectivedatetimestampUndefined;
    private static readonly System.IntPtr NativeFieldInfoPtr_CatalogofferExpirationtimestampUndefined;
    private static readonly System.IntPtr NativeFieldInfoPtr_CatalogofferReleasedatetimestampUndefined;
    private static readonly System.IntPtr NativeFieldInfoPtr_CatalogreleaseApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckoutApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckoutMaxEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckoutentryApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyentitlementbyidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyentitlementbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyentitlementbynameandindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyitembyidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyitemimageinfobyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyitemreleasebyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopylastredeemedentitlementbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyofferbyidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyofferbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyofferimageinfobyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyofferitembyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopytransactionbyidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopytransactionbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntitlementApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntitlementEndtimestampUndefined;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntitlementidMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetentitlementsbynamecountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetentitlementscountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetitemimageinfocountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetitemreleasecountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetlastredeemedentitlementscountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetoffercountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetofferimageinfocountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetofferitemcountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GettransactioncountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemownershipApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeyimageinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryentitlementsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryentitlementsMaxEntitlementIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryentitlementtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryentitlementtokenMaxEntitlementIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryoffersApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryownershipApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryownershipMaxCatalogIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryownershiptokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryownershiptokenMaxCatalogitemIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_RedeementitlementsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RedeementitlementsMaxIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransactionidMaximumLength;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Checkout_Public_Void_byref_CheckoutOptions_Object_OnCheckoutCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyEntitlementById_Public_Result_byref_CopyEntitlementByIdOptions_byref_Nullable_1_Entitlement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_byref_CopyEntitlementByIndexOptions_byref_Nullable_1_Entitlement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyEntitlementByNameAndIndex_Public_Result_byref_CopyEntitlementByNameAndIndexOptions_byref_Nullable_1_Entitlement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyItemById_Public_Result_byref_CopyItemByIdOptions_byref_Nullable_1_CatalogItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyItemImageInfoByIndex_Public_Result_byref_CopyItemImageInfoByIndexOptions_byref_Nullable_1_KeyImageInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyItemReleaseByIndex_Public_Result_byref_CopyItemReleaseByIndexOptions_byref_Nullable_1_CatalogRelease_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLastRedeemedEntitlementByIndex_Public_Result_byref_CopyLastRedeemedEntitlementByIndexOptions_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyOfferById_Public_Result_byref_CopyOfferByIdOptions_byref_Nullable_1_CatalogOffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyOfferByIndex_Public_Result_byref_CopyOfferByIndexOptions_byref_Nullable_1_CatalogOffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyOfferImageInfoByIndex_Public_Result_byref_CopyOfferImageInfoByIndexOptions_byref_Nullable_1_KeyImageInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyOfferItemByIndex_Public_Result_byref_CopyOfferItemByIndexOptions_byref_Nullable_1_CatalogItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyTransactionById_Public_Result_byref_CopyTransactionByIdOptions_byref_Transaction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyTransactionByIndex_Public_Result_byref_CopyTransactionByIndexOptions_byref_Transaction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitlementsByNameCount_Public_UInt32_byref_GetEntitlementsByNameCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_byref_GetEntitlementsCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemImageInfoCount_Public_UInt32_byref_GetItemImageInfoCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemReleaseCount_Public_UInt32_byref_GetItemReleaseCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLastRedeemedEntitlementsCount_Public_UInt32_byref_GetLastRedeemedEntitlementsCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOfferCount_Public_UInt32_byref_GetOfferCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOfferImageInfoCount_Public_UInt32_byref_GetOfferImageInfoCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOfferItemCount_Public_UInt32_byref_GetOfferItemCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTransactionCount_Public_UInt32_byref_GetTransactionCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryEntitlementToken_Public_Void_byref_QueryEntitlementTokenOptions_Object_OnQueryEntitlementTokenCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryEntitlements_Public_Void_byref_QueryEntitlementsOptions_Object_OnQueryEntitlementsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryOffers_Public_Void_byref_QueryOffersOptions_Object_OnQueryOffersCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryOwnership_Public_Void_byref_QueryOwnershipOptions_Object_OnQueryOwnershipCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryOwnershipToken_Public_Void_byref_QueryOwnershipTokenOptions_Object_OnQueryOwnershipTokenCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RedeemEntitlements_Public_Void_byref_RedeemEntitlementsOptions_Object_OnRedeemEntitlementsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCheckoutCallbackInternalImplementation_Internal_Static_Void_byref_CheckoutCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryEntitlementTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryEntitlementTokenCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryEntitlementsCallbackInternalImplementation_Internal_Static_Void_byref_QueryEntitlementsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryOffersCallbackInternalImplementation_Internal_Static_Void_byref_QueryOffersCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryOwnershipCallbackInternalImplementation_Internal_Static_Void_byref_QueryOwnershipCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryOwnershipTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryOwnershipTokenCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRedeemEntitlementsCallbackInternalImplementation_Internal_Static_Void_byref_RedeemEntitlementsCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EcomInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962280, XrefRangeEnd = 962299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Checkout(
      ref CheckoutOptions options,
      Il2CppSystem.Object clientData,
      OnCheckoutCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_Checkout_Public_Void_byref_CheckoutOptions_Object_OnCheckoutCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962299, XrefRangeEnd = 962313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyEntitlementById(
      ref CopyEntitlementByIdOptions options,
      out Il2CppSystem.Nullable<Entitlement> outEntitlement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyEntitlementById_Public_Result_byref_CopyEntitlementByIdOptions_byref_Nullable_1_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Entitlement> local = ref outEntitlement;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Entitlement>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962313, XrefRangeEnd = 962327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyEntitlementByIndex(
      ref CopyEntitlementByIndexOptions options,
      out Il2CppSystem.Nullable<Entitlement> outEntitlement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_byref_CopyEntitlementByIndexOptions_byref_Nullable_1_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Entitlement> local = ref outEntitlement;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Entitlement>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962327, XrefRangeEnd = 962341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyEntitlementByNameAndIndex(
      ref CopyEntitlementByNameAndIndexOptions options,
      out Il2CppSystem.Nullable<Entitlement> outEntitlement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyEntitlementByNameAndIndex_Public_Result_byref_CopyEntitlementByNameAndIndexOptions_byref_Nullable_1_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Entitlement> local = ref outEntitlement;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Entitlement>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962341, XrefRangeEnd = 962355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyItemById(
      ref CopyItemByIdOptions options,
      out Il2CppSystem.Nullable<CatalogItem> outItem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyItemById_Public_Result_byref_CopyItemByIdOptions_byref_Nullable_1_CatalogItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<CatalogItem> local = ref outItem;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<CatalogItem>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962355, XrefRangeEnd = 962369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyItemImageInfoByIndex(
      ref CopyItemImageInfoByIndexOptions options,
      out Il2CppSystem.Nullable<KeyImageInfo> outImageInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyItemImageInfoByIndex_Public_Result_byref_CopyItemImageInfoByIndexOptions_byref_Nullable_1_KeyImageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<KeyImageInfo> local = ref outImageInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<KeyImageInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962369, XrefRangeEnd = 962383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyItemReleaseByIndex(
      ref CopyItemReleaseByIndexOptions options,
      out Il2CppSystem.Nullable<CatalogRelease> outRelease)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyItemReleaseByIndex_Public_Result_byref_CopyItemReleaseByIndexOptions_byref_Nullable_1_CatalogRelease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<CatalogRelease> local = ref outRelease;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<CatalogRelease>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962383, XrefRangeEnd = 962394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLastRedeemedEntitlementByIndex(
      ref CopyLastRedeemedEntitlementByIndexOptions options,
      out Epic.OnlineServices.Utf8String outRedeemedEntitlementId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyLastRedeemedEntitlementByIndex_Public_Result_byref_CopyLastRedeemedEntitlementByIndexOptions_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outRedeemedEntitlementId;
      System.IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962394, XrefRangeEnd = 962408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyOfferById(
      ref CopyOfferByIdOptions options,
      out Il2CppSystem.Nullable<CatalogOffer> outOffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyOfferById_Public_Result_byref_CopyOfferByIdOptions_byref_Nullable_1_CatalogOffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<CatalogOffer> local = ref outOffer;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<CatalogOffer>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962408, XrefRangeEnd = 962422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyOfferByIndex(
      ref CopyOfferByIndexOptions options,
      out Il2CppSystem.Nullable<CatalogOffer> outOffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyOfferByIndex_Public_Result_byref_CopyOfferByIndexOptions_byref_Nullable_1_CatalogOffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<CatalogOffer> local = ref outOffer;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<CatalogOffer>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962422, XrefRangeEnd = 962436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyOfferImageInfoByIndex(
      ref CopyOfferImageInfoByIndexOptions options,
      out Il2CppSystem.Nullable<KeyImageInfo> outImageInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyOfferImageInfoByIndex_Public_Result_byref_CopyOfferImageInfoByIndexOptions_byref_Nullable_1_KeyImageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<KeyImageInfo> local = ref outImageInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<KeyImageInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962436, XrefRangeEnd = 962450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyOfferItemByIndex(
      ref CopyOfferItemByIndexOptions options,
      out Il2CppSystem.Nullable<CatalogItem> outItem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyOfferItemByIndex_Public_Result_byref_CopyOfferItemByIndexOptions_byref_Nullable_1_CatalogItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<CatalogItem> local = ref outItem;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<CatalogItem>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962450, XrefRangeEnd = 962462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyTransactionById(
      ref CopyTransactionByIdOptions options,
      out Transaction outTransaction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyTransactionById_Public_Result_byref_CopyTransactionByIdOptions_byref_Transaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Transaction local = ref outTransaction;
      System.IntPtr pointer = zero;
      Transaction transaction = pointer == System.IntPtr.Zero ? (Transaction) null : new Transaction(pointer);
      local = transaction;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962462, XrefRangeEnd = 962474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyTransactionByIndex(
      ref CopyTransactionByIndexOptions options,
      out Transaction outTransaction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_CopyTransactionByIndex_Public_Result_byref_CopyTransactionByIndexOptions_byref_Transaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Transaction local = ref outTransaction;
      System.IntPtr pointer = zero;
      Transaction transaction = pointer == System.IntPtr.Zero ? (Transaction) null : new Transaction(pointer);
      local = transaction;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962474, XrefRangeEnd = 962482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetEntitlementsByNameCount(ref GetEntitlementsByNameCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetEntitlementsByNameCount_Public_UInt32_byref_GetEntitlementsByNameCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962482, XrefRangeEnd = 962490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetEntitlementsCount(ref GetEntitlementsCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_byref_GetEntitlementsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962490, XrefRangeEnd = 962498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetItemImageInfoCount(ref GetItemImageInfoCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetItemImageInfoCount_Public_UInt32_byref_GetItemImageInfoCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962498, XrefRangeEnd = 962506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetItemReleaseCount(ref GetItemReleaseCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetItemReleaseCount_Public_UInt32_byref_GetItemReleaseCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962506, XrefRangeEnd = 962514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetLastRedeemedEntitlementsCount(
      ref GetLastRedeemedEntitlementsCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetLastRedeemedEntitlementsCount_Public_UInt32_byref_GetLastRedeemedEntitlementsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962514, XrefRangeEnd = 962522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetOfferCount(ref GetOfferCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetOfferCount_Public_UInt32_byref_GetOfferCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962522, XrefRangeEnd = 962530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetOfferImageInfoCount(ref GetOfferImageInfoCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetOfferImageInfoCount_Public_UInt32_byref_GetOfferImageInfoCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962530, XrefRangeEnd = 962538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetOfferItemCount(ref GetOfferItemCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetOfferItemCount_Public_UInt32_byref_GetOfferItemCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962538, XrefRangeEnd = 962546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetTransactionCount(ref GetTransactionCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_GetTransactionCount_Public_UInt32_byref_GetTransactionCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962546, XrefRangeEnd = 962565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryEntitlementToken(
      ref QueryEntitlementTokenOptions options,
      Il2CppSystem.Object clientData,
      OnQueryEntitlementTokenCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryEntitlementToken_Public_Void_byref_QueryEntitlementTokenOptions_Object_OnQueryEntitlementTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962565, XrefRangeEnd = 962584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryEntitlements(
      ref QueryEntitlementsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryEntitlementsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryEntitlements_Public_Void_byref_QueryEntitlementsOptions_Object_OnQueryEntitlementsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962584, XrefRangeEnd = 962603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryOffers(
      ref QueryOffersOptions options,
      Il2CppSystem.Object clientData,
      OnQueryOffersCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryOffers_Public_Void_byref_QueryOffersOptions_Object_OnQueryOffersCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962603, XrefRangeEnd = 962622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryOwnership(
      ref QueryOwnershipOptions options,
      Il2CppSystem.Object clientData,
      OnQueryOwnershipCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryOwnership_Public_Void_byref_QueryOwnershipOptions_Object_OnQueryOwnershipCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962622, XrefRangeEnd = 962641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryOwnershipToken(
      ref QueryOwnershipTokenOptions options,
      Il2CppSystem.Object clientData,
      OnQueryOwnershipTokenCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_QueryOwnershipToken_Public_Void_byref_QueryOwnershipTokenOptions_Object_OnQueryOwnershipTokenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962641, XrefRangeEnd = 962660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RedeemEntitlements(
      ref RedeemEntitlementsOptions options,
      Il2CppSystem.Object clientData,
      OnRedeemEntitlementsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_RedeemEntitlements_Public_Void_byref_RedeemEntitlementsOptions_Object_OnRedeemEntitlementsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962660, XrefRangeEnd = 962667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnCheckoutCallbackInternalImplementation(
      ref CheckoutCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnCheckoutCallbackInternalImplementation_Internal_Static_Void_byref_CheckoutCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962667, XrefRangeEnd = 962674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryEntitlementTokenCallbackInternalImplementation(
      ref QueryEntitlementTokenCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryEntitlementTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryEntitlementTokenCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962674, XrefRangeEnd = 962681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryEntitlementsCallbackInternalImplementation(
      ref QueryEntitlementsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryEntitlementsCallbackInternalImplementation_Internal_Static_Void_byref_QueryEntitlementsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962681, XrefRangeEnd = 962688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryOffersCallbackInternalImplementation(
      ref QueryOffersCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryOffersCallbackInternalImplementation_Internal_Static_Void_byref_QueryOffersCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962688, XrefRangeEnd = 962695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryOwnershipCallbackInternalImplementation(
      ref QueryOwnershipCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryOwnershipCallbackInternalImplementation_Internal_Static_Void_byref_QueryOwnershipCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962695, XrefRangeEnd = 962702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryOwnershipTokenCallbackInternalImplementation(
      ref QueryOwnershipTokenCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnQueryOwnershipTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryOwnershipTokenCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962702, XrefRangeEnd = 962709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnRedeemEntitlementsCallbackInternalImplementation(
      ref RedeemEntitlementsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EcomInterface.NativeMethodInfoPtr_OnRedeemEntitlementsCallbackInternalImplementation_Internal_Static_Void_byref_RedeemEntitlementsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EcomInterface()
    {
      Il2CppClassPointerStore<EcomInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (EcomInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr);
      EcomInterface.NativeFieldInfoPtr_CatalogitemApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogitemApiLatest));
      EcomInterface.NativeFieldInfoPtr_CatalogitemEntitlementendtimestampUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogitemEntitlementendtimestampUndefined));
      EcomInterface.NativeFieldInfoPtr_CatalogofferApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogofferApiLatest));
      EcomInterface.NativeFieldInfoPtr_CatalogofferEffectivedatetimestampUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogofferEffectivedatetimestampUndefined));
      EcomInterface.NativeFieldInfoPtr_CatalogofferExpirationtimestampUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogofferExpirationtimestampUndefined));
      EcomInterface.NativeFieldInfoPtr_CatalogofferReleasedatetimestampUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogofferReleasedatetimestampUndefined));
      EcomInterface.NativeFieldInfoPtr_CatalogreleaseApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CatalogreleaseApiLatest));
      EcomInterface.NativeFieldInfoPtr_CheckoutApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CheckoutApiLatest));
      EcomInterface.NativeFieldInfoPtr_CheckoutMaxEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CheckoutMaxEntries));
      EcomInterface.NativeFieldInfoPtr_CheckoutentryApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CheckoutentryApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyentitlementbyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyentitlementbyidApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyentitlementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyentitlementbyindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyentitlementbynameandindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyentitlementbynameandindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyitembyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyitembyidApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyitemimageinfobyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyitemimageinfobyindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyitemreleasebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyitemreleasebyindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopylastredeemedentitlementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopylastredeemedentitlementbyindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyofferbyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyofferbyidApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyofferbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyofferbyindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyofferimageinfobyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyofferimageinfobyindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopyofferitembyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopyofferitembyindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopytransactionbyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopytransactionbyidApiLatest));
      EcomInterface.NativeFieldInfoPtr_CopytransactionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (CopytransactionbyindexApiLatest));
      EcomInterface.NativeFieldInfoPtr_EntitlementApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (EntitlementApiLatest));
      EcomInterface.NativeFieldInfoPtr_EntitlementEndtimestampUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (EntitlementEndtimestampUndefined));
      EcomInterface.NativeFieldInfoPtr_EntitlementidMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (EntitlementidMaxLength));
      EcomInterface.NativeFieldInfoPtr_GetentitlementsbynamecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetentitlementsbynamecountApiLatest));
      EcomInterface.NativeFieldInfoPtr_GetentitlementscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetentitlementscountApiLatest));
      EcomInterface.NativeFieldInfoPtr_GetitemimageinfocountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetitemimageinfocountApiLatest));
      EcomInterface.NativeFieldInfoPtr_GetitemreleasecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetitemreleasecountApiLatest));
      EcomInterface.NativeFieldInfoPtr_GetlastredeemedentitlementscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetlastredeemedentitlementscountApiLatest));
      EcomInterface.NativeFieldInfoPtr_GetoffercountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetoffercountApiLatest));
      EcomInterface.NativeFieldInfoPtr_GetofferimageinfocountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetofferimageinfocountApiLatest));
      EcomInterface.NativeFieldInfoPtr_GetofferitemcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GetofferitemcountApiLatest));
      EcomInterface.NativeFieldInfoPtr_GettransactioncountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (GettransactioncountApiLatest));
      EcomInterface.NativeFieldInfoPtr_ItemownershipApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (ItemownershipApiLatest));
      EcomInterface.NativeFieldInfoPtr_KeyimageinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (KeyimageinfoApiLatest));
      EcomInterface.NativeFieldInfoPtr_QueryentitlementsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryentitlementsApiLatest));
      EcomInterface.NativeFieldInfoPtr_QueryentitlementsMaxEntitlementIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryentitlementsMaxEntitlementIds));
      EcomInterface.NativeFieldInfoPtr_QueryentitlementtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryentitlementtokenApiLatest));
      EcomInterface.NativeFieldInfoPtr_QueryentitlementtokenMaxEntitlementIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryentitlementtokenMaxEntitlementIds));
      EcomInterface.NativeFieldInfoPtr_QueryoffersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryoffersApiLatest));
      EcomInterface.NativeFieldInfoPtr_QueryownershipApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryownershipApiLatest));
      EcomInterface.NativeFieldInfoPtr_QueryownershipMaxCatalogIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryownershipMaxCatalogIds));
      EcomInterface.NativeFieldInfoPtr_QueryownershiptokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryownershiptokenApiLatest));
      EcomInterface.NativeFieldInfoPtr_QueryownershiptokenMaxCatalogitemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (QueryownershiptokenMaxCatalogitemIds));
      EcomInterface.NativeFieldInfoPtr_RedeementitlementsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (RedeementitlementsApiLatest));
      EcomInterface.NativeFieldInfoPtr_RedeementitlementsMaxIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (RedeementitlementsMaxIds));
      EcomInterface.NativeFieldInfoPtr_TransactionidMaximumLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, nameof (TransactionidMaximumLength));
      EcomInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100671998);
      EcomInterface.NativeMethodInfoPtr_Checkout_Public_Void_byref_CheckoutOptions_Object_OnCheckoutCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672000);
      EcomInterface.NativeMethodInfoPtr_CopyEntitlementById_Public_Result_byref_CopyEntitlementByIdOptions_byref_Nullable_1_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672001);
      EcomInterface.NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_byref_CopyEntitlementByIndexOptions_byref_Nullable_1_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672002);
      EcomInterface.NativeMethodInfoPtr_CopyEntitlementByNameAndIndex_Public_Result_byref_CopyEntitlementByNameAndIndexOptions_byref_Nullable_1_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672003);
      EcomInterface.NativeMethodInfoPtr_CopyItemById_Public_Result_byref_CopyItemByIdOptions_byref_Nullable_1_CatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672004);
      EcomInterface.NativeMethodInfoPtr_CopyItemImageInfoByIndex_Public_Result_byref_CopyItemImageInfoByIndexOptions_byref_Nullable_1_KeyImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672005);
      EcomInterface.NativeMethodInfoPtr_CopyItemReleaseByIndex_Public_Result_byref_CopyItemReleaseByIndexOptions_byref_Nullable_1_CatalogRelease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672006);
      EcomInterface.NativeMethodInfoPtr_CopyLastRedeemedEntitlementByIndex_Public_Result_byref_CopyLastRedeemedEntitlementByIndexOptions_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672007);
      EcomInterface.NativeMethodInfoPtr_CopyOfferById_Public_Result_byref_CopyOfferByIdOptions_byref_Nullable_1_CatalogOffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672008);
      EcomInterface.NativeMethodInfoPtr_CopyOfferByIndex_Public_Result_byref_CopyOfferByIndexOptions_byref_Nullable_1_CatalogOffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672009);
      EcomInterface.NativeMethodInfoPtr_CopyOfferImageInfoByIndex_Public_Result_byref_CopyOfferImageInfoByIndexOptions_byref_Nullable_1_KeyImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672010);
      EcomInterface.NativeMethodInfoPtr_CopyOfferItemByIndex_Public_Result_byref_CopyOfferItemByIndexOptions_byref_Nullable_1_CatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672011);
      EcomInterface.NativeMethodInfoPtr_CopyTransactionById_Public_Result_byref_CopyTransactionByIdOptions_byref_Transaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672012);
      EcomInterface.NativeMethodInfoPtr_CopyTransactionByIndex_Public_Result_byref_CopyTransactionByIndexOptions_byref_Transaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672013);
      EcomInterface.NativeMethodInfoPtr_GetEntitlementsByNameCount_Public_UInt32_byref_GetEntitlementsByNameCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672014);
      EcomInterface.NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_byref_GetEntitlementsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672015);
      EcomInterface.NativeMethodInfoPtr_GetItemImageInfoCount_Public_UInt32_byref_GetItemImageInfoCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672016);
      EcomInterface.NativeMethodInfoPtr_GetItemReleaseCount_Public_UInt32_byref_GetItemReleaseCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672017);
      EcomInterface.NativeMethodInfoPtr_GetLastRedeemedEntitlementsCount_Public_UInt32_byref_GetLastRedeemedEntitlementsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672018);
      EcomInterface.NativeMethodInfoPtr_GetOfferCount_Public_UInt32_byref_GetOfferCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672019);
      EcomInterface.NativeMethodInfoPtr_GetOfferImageInfoCount_Public_UInt32_byref_GetOfferImageInfoCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672020);
      EcomInterface.NativeMethodInfoPtr_GetOfferItemCount_Public_UInt32_byref_GetOfferItemCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672021);
      EcomInterface.NativeMethodInfoPtr_GetTransactionCount_Public_UInt32_byref_GetTransactionCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672022);
      EcomInterface.NativeMethodInfoPtr_QueryEntitlementToken_Public_Void_byref_QueryEntitlementTokenOptions_Object_OnQueryEntitlementTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672023);
      EcomInterface.NativeMethodInfoPtr_QueryEntitlements_Public_Void_byref_QueryEntitlementsOptions_Object_OnQueryEntitlementsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672024);
      EcomInterface.NativeMethodInfoPtr_QueryOffers_Public_Void_byref_QueryOffersOptions_Object_OnQueryOffersCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672025);
      EcomInterface.NativeMethodInfoPtr_QueryOwnership_Public_Void_byref_QueryOwnershipOptions_Object_OnQueryOwnershipCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672026);
      EcomInterface.NativeMethodInfoPtr_QueryOwnershipToken_Public_Void_byref_QueryOwnershipTokenOptions_Object_OnQueryOwnershipTokenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672027);
      EcomInterface.NativeMethodInfoPtr_RedeemEntitlements_Public_Void_byref_RedeemEntitlementsOptions_Object_OnRedeemEntitlementsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672028);
      EcomInterface.NativeMethodInfoPtr_OnCheckoutCallbackInternalImplementation_Internal_Static_Void_byref_CheckoutCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672029);
      EcomInterface.NativeMethodInfoPtr_OnQueryEntitlementTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryEntitlementTokenCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672030);
      EcomInterface.NativeMethodInfoPtr_OnQueryEntitlementsCallbackInternalImplementation_Internal_Static_Void_byref_QueryEntitlementsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672031);
      EcomInterface.NativeMethodInfoPtr_OnQueryOffersCallbackInternalImplementation_Internal_Static_Void_byref_QueryOffersCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672032);
      EcomInterface.NativeMethodInfoPtr_OnQueryOwnershipCallbackInternalImplementation_Internal_Static_Void_byref_QueryOwnershipCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672033);
      EcomInterface.NativeMethodInfoPtr_OnQueryOwnershipTokenCallbackInternalImplementation_Internal_Static_Void_byref_QueryOwnershipTokenCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672034);
      EcomInterface.NativeMethodInfoPtr_OnRedeemEntitlementsCallbackInternalImplementation_Internal_Static_Void_byref_RedeemEntitlementsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcomInterface>.NativeClassPtr, 100672035);
    }

    public EcomInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CatalogitemApiLatest
    {
      get
      {
        int catalogitemApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogitemApiLatest, (void*) &catalogitemApiLatest);
        return catalogitemApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogitemApiLatest, (void*) &value);
      }
    }

    public static unsafe int CatalogitemEntitlementendtimestampUndefined
    {
      get
      {
        int entitlementendtimestampUndefined;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogitemEntitlementendtimestampUndefined, (void*) &entitlementendtimestampUndefined);
        return entitlementendtimestampUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogitemEntitlementendtimestampUndefined, (void*) &value);
      }
    }

    public static unsafe int CatalogofferApiLatest
    {
      get
      {
        int catalogofferApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogofferApiLatest, (void*) &catalogofferApiLatest);
        return catalogofferApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogofferApiLatest, (void*) &value);
      }
    }

    public static unsafe int CatalogofferEffectivedatetimestampUndefined
    {
      get
      {
        int effectivedatetimestampUndefined;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogofferEffectivedatetimestampUndefined, (void*) &effectivedatetimestampUndefined);
        return effectivedatetimestampUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogofferEffectivedatetimestampUndefined, (void*) &value);
      }
    }

    public static unsafe int CatalogofferExpirationtimestampUndefined
    {
      get
      {
        int expirationtimestampUndefined;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogofferExpirationtimestampUndefined, (void*) &expirationtimestampUndefined);
        return expirationtimestampUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogofferExpirationtimestampUndefined, (void*) &value);
      }
    }

    public static unsafe int CatalogofferReleasedatetimestampUndefined
    {
      get
      {
        int releasedatetimestampUndefined;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogofferReleasedatetimestampUndefined, (void*) &releasedatetimestampUndefined);
        return releasedatetimestampUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogofferReleasedatetimestampUndefined, (void*) &value);
      }
    }

    public static unsafe int CatalogreleaseApiLatest
    {
      get
      {
        int catalogreleaseApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CatalogreleaseApiLatest, (void*) &catalogreleaseApiLatest);
        return catalogreleaseApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CatalogreleaseApiLatest, (void*) &value);
      }
    }

    public static unsafe int CheckoutApiLatest
    {
      get
      {
        int checkoutApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CheckoutApiLatest, (void*) &checkoutApiLatest);
        return checkoutApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CheckoutApiLatest, (void*) &value);
      }
    }

    public static unsafe int CheckoutMaxEntries
    {
      get
      {
        int checkoutMaxEntries;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CheckoutMaxEntries, (void*) &checkoutMaxEntries);
        return checkoutMaxEntries;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CheckoutMaxEntries, (void*) &value);
      }
    }

    public static unsafe int CheckoutentryApiLatest
    {
      get
      {
        int checkoutentryApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CheckoutentryApiLatest, (void*) &checkoutentryApiLatest);
        return checkoutentryApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CheckoutentryApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyentitlementbyidApiLatest
    {
      get
      {
        int copyentitlementbyidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbyidApiLatest, (void*) &copyentitlementbyidApiLatest);
        return copyentitlementbyidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbyidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyentitlementbyindexApiLatest
    {
      get
      {
        int copyentitlementbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbyindexApiLatest, (void*) &copyentitlementbyindexApiLatest);
        return copyentitlementbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyentitlementbynameandindexApiLatest
    {
      get
      {
        int copyentitlementbynameandindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbynameandindexApiLatest, (void*) &copyentitlementbynameandindexApiLatest);
        return copyentitlementbynameandindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyentitlementbynameandindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyitembyidApiLatest
    {
      get
      {
        int copyitembyidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyitembyidApiLatest, (void*) &copyitembyidApiLatest);
        return copyitembyidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyitembyidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyitemimageinfobyindexApiLatest
    {
      get
      {
        int copyitemimageinfobyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyitemimageinfobyindexApiLatest, (void*) &copyitemimageinfobyindexApiLatest);
        return copyitemimageinfobyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyitemimageinfobyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyitemreleasebyindexApiLatest
    {
      get
      {
        int copyitemreleasebyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyitemreleasebyindexApiLatest, (void*) &copyitemreleasebyindexApiLatest);
        return copyitemreleasebyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyitemreleasebyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopylastredeemedentitlementbyindexApiLatest
    {
      get
      {
        int copylastredeemedentitlementbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopylastredeemedentitlementbyindexApiLatest, (void*) &copylastredeemedentitlementbyindexApiLatest);
        return copylastredeemedentitlementbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopylastredeemedentitlementbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyofferbyidApiLatest
    {
      get
      {
        int copyofferbyidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyofferbyidApiLatest, (void*) &copyofferbyidApiLatest);
        return copyofferbyidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyofferbyidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyofferbyindexApiLatest
    {
      get
      {
        int copyofferbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyofferbyindexApiLatest, (void*) &copyofferbyindexApiLatest);
        return copyofferbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyofferbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyofferimageinfobyindexApiLatest
    {
      get
      {
        int copyofferimageinfobyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyofferimageinfobyindexApiLatest, (void*) &copyofferimageinfobyindexApiLatest);
        return copyofferimageinfobyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyofferimageinfobyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyofferitembyindexApiLatest
    {
      get
      {
        int copyofferitembyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopyofferitembyindexApiLatest, (void*) &copyofferitembyindexApiLatest);
        return copyofferitembyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopyofferitembyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopytransactionbyidApiLatest
    {
      get
      {
        int copytransactionbyidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopytransactionbyidApiLatest, (void*) &copytransactionbyidApiLatest);
        return copytransactionbyidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopytransactionbyidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopytransactionbyindexApiLatest
    {
      get
      {
        int copytransactionbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_CopytransactionbyindexApiLatest, (void*) &copytransactionbyindexApiLatest);
        return copytransactionbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_CopytransactionbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int EntitlementApiLatest
    {
      get
      {
        int entitlementApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_EntitlementApiLatest, (void*) &entitlementApiLatest);
        return entitlementApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_EntitlementApiLatest, (void*) &value);
      }
    }

    public static unsafe int EntitlementEndtimestampUndefined
    {
      get
      {
        int endtimestampUndefined;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_EntitlementEndtimestampUndefined, (void*) &endtimestampUndefined);
        return endtimestampUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_EntitlementEndtimestampUndefined, (void*) &value);
      }
    }

    public static unsafe int EntitlementidMaxLength
    {
      get
      {
        int entitlementidMaxLength;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_EntitlementidMaxLength, (void*) &entitlementidMaxLength);
        return entitlementidMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_EntitlementidMaxLength, (void*) &value);
      }
    }

    public static unsafe int GetentitlementsbynamecountApiLatest
    {
      get
      {
        int getentitlementsbynamecountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetentitlementsbynamecountApiLatest, (void*) &getentitlementsbynamecountApiLatest);
        return getentitlementsbynamecountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetentitlementsbynamecountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetentitlementscountApiLatest
    {
      get
      {
        int getentitlementscountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetentitlementscountApiLatest, (void*) &getentitlementscountApiLatest);
        return getentitlementscountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetentitlementscountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetitemimageinfocountApiLatest
    {
      get
      {
        int getitemimageinfocountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetitemimageinfocountApiLatest, (void*) &getitemimageinfocountApiLatest);
        return getitemimageinfocountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetitemimageinfocountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetitemreleasecountApiLatest
    {
      get
      {
        int getitemreleasecountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetitemreleasecountApiLatest, (void*) &getitemreleasecountApiLatest);
        return getitemreleasecountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetitemreleasecountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetlastredeemedentitlementscountApiLatest
    {
      get
      {
        int getlastredeemedentitlementscountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetlastredeemedentitlementscountApiLatest, (void*) &getlastredeemedentitlementscountApiLatest);
        return getlastredeemedentitlementscountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetlastredeemedentitlementscountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetoffercountApiLatest
    {
      get
      {
        int getoffercountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetoffercountApiLatest, (void*) &getoffercountApiLatest);
        return getoffercountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetoffercountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetofferimageinfocountApiLatest
    {
      get
      {
        int getofferimageinfocountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetofferimageinfocountApiLatest, (void*) &getofferimageinfocountApiLatest);
        return getofferimageinfocountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetofferimageinfocountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetofferitemcountApiLatest
    {
      get
      {
        int getofferitemcountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GetofferitemcountApiLatest, (void*) &getofferitemcountApiLatest);
        return getofferitemcountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GetofferitemcountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GettransactioncountApiLatest
    {
      get
      {
        int gettransactioncountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_GettransactioncountApiLatest, (void*) &gettransactioncountApiLatest);
        return gettransactioncountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_GettransactioncountApiLatest, (void*) &value);
      }
    }

    public static unsafe int ItemownershipApiLatest
    {
      get
      {
        int itemownershipApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_ItemownershipApiLatest, (void*) &itemownershipApiLatest);
        return itemownershipApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_ItemownershipApiLatest, (void*) &value);
      }
    }

    public static unsafe int KeyimageinfoApiLatest
    {
      get
      {
        int keyimageinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_KeyimageinfoApiLatest, (void*) &keyimageinfoApiLatest);
        return keyimageinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_KeyimageinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryentitlementsApiLatest
    {
      get
      {
        int queryentitlementsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementsApiLatest, (void*) &queryentitlementsApiLatest);
        return queryentitlementsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementsApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryentitlementsMaxEntitlementIds
    {
      get
      {
        int maxEntitlementIds;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementsMaxEntitlementIds, (void*) &maxEntitlementIds);
        return maxEntitlementIds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementsMaxEntitlementIds, (void*) &value);
      }
    }

    public static unsafe int QueryentitlementtokenApiLatest
    {
      get
      {
        int queryentitlementtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementtokenApiLatest, (void*) &queryentitlementtokenApiLatest);
        return queryentitlementtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryentitlementtokenMaxEntitlementIds
    {
      get
      {
        int maxEntitlementIds;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementtokenMaxEntitlementIds, (void*) &maxEntitlementIds);
        return maxEntitlementIds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryentitlementtokenMaxEntitlementIds, (void*) &value);
      }
    }

    public static unsafe int QueryoffersApiLatest
    {
      get
      {
        int queryoffersApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryoffersApiLatest, (void*) &queryoffersApiLatest);
        return queryoffersApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryoffersApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryownershipApiLatest
    {
      get
      {
        int queryownershipApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryownershipApiLatest, (void*) &queryownershipApiLatest);
        return queryownershipApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryownershipApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryownershipMaxCatalogIds
    {
      get
      {
        int queryownershipMaxCatalogIds;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryownershipMaxCatalogIds, (void*) &queryownershipMaxCatalogIds);
        return queryownershipMaxCatalogIds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryownershipMaxCatalogIds, (void*) &value);
      }
    }

    public static unsafe int QueryownershiptokenApiLatest
    {
      get
      {
        int queryownershiptokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryownershiptokenApiLatest, (void*) &queryownershiptokenApiLatest);
        return queryownershiptokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryownershiptokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryownershiptokenMaxCatalogitemIds
    {
      get
      {
        int maxCatalogitemIds;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_QueryownershiptokenMaxCatalogitemIds, (void*) &maxCatalogitemIds);
        return maxCatalogitemIds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_QueryownershiptokenMaxCatalogitemIds, (void*) &value);
      }
    }

    public static unsafe int RedeementitlementsApiLatest
    {
      get
      {
        int redeementitlementsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_RedeementitlementsApiLatest, (void*) &redeementitlementsApiLatest);
        return redeementitlementsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_RedeementitlementsApiLatest, (void*) &value);
      }
    }

    public static unsafe int RedeementitlementsMaxIds
    {
      get
      {
        int redeementitlementsMaxIds;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_RedeementitlementsMaxIds, (void*) &redeementitlementsMaxIds);
        return redeementitlementsMaxIds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_RedeementitlementsMaxIds, (void*) &value);
      }
    }

    public static unsafe int TransactionidMaximumLength
    {
      get
      {
        int transactionidMaximumLength;
        IL2CPP.il2cpp_field_static_get_value(EcomInterface.NativeFieldInfoPtr_TransactionidMaximumLength, (void*) &transactionidMaximumLength);
        return transactionidMaximumLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EcomInterface.NativeFieldInfoPtr_TransactionidMaximumLength, (void*) &value);
      }
    }
  }
}
