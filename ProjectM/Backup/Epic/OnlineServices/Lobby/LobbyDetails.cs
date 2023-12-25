// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyDetails
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  public sealed class LobbyDetails : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsCopyattributebyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsCopyattributebykeyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsCopyinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsCopymemberattributebyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsCopymemberattributebykeyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsGetattributecountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsGetlobbyownerApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsGetmemberattributecountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsGetmemberbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsGetmembercountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbydetailsInfoApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAttributeByIndex_Public_Result_byref_LobbyDetailsCopyAttributeByIndexOptions_byref_Nullable_1_Attribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAttributeByKey_Public_Result_byref_LobbyDetailsCopyAttributeByKeyOptions_byref_Nullable_1_Attribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyInfo_Public_Result_byref_LobbyDetailsCopyInfoOptions_byref_Nullable_1_LobbyDetailsInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyMemberAttributeByIndex_Public_Result_byref_LobbyDetailsCopyMemberAttributeByIndexOptions_byref_Nullable_1_Attribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyMemberAttributeByKey_Public_Result_byref_LobbyDetailsCopyMemberAttributeByKeyOptions_byref_Nullable_1_Attribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAttributeCount_Public_UInt32_byref_LobbyDetailsGetAttributeCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLobbyOwner_Public_ProductUserId_byref_LobbyDetailsGetLobbyOwnerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMemberAttributeCount_Public_UInt32_byref_LobbyDetailsGetMemberAttributeCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMemberByIndex_Public_ProductUserId_byref_LobbyDetailsGetMemberByIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMemberCount_Public_UInt32_byref_LobbyDetailsGetMemberCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LobbyDetails()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955281, XrefRangeEnd = 955294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyAttributeByIndex(
      ref LobbyDetailsCopyAttributeByIndexOptions options,
      out Il2CppSystem.Nullable<Attribute> outAttribute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyAttributeByIndex_Public_Result_byref_LobbyDetailsCopyAttributeByIndexOptions_byref_Nullable_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Attribute> local = ref outAttribute;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Attribute>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955294, XrefRangeEnd = 955311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyAttributeByKey(
      ref LobbyDetailsCopyAttributeByKeyOptions options,
      out Il2CppSystem.Nullable<Attribute> outAttribute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyAttributeByKey_Public_Result_byref_LobbyDetailsCopyAttributeByKeyOptions_byref_Nullable_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Attribute> local = ref outAttribute;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Attribute>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955311, XrefRangeEnd = 955324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyInfo(
      ref LobbyDetailsCopyInfoOptions options,
      out Il2CppSystem.Nullable<LobbyDetailsInfo> outLobbyDetailsInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyInfo_Public_Result_byref_LobbyDetailsCopyInfoOptions_byref_Nullable_1_LobbyDetailsInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<LobbyDetailsInfo> local = ref outLobbyDetailsInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<LobbyDetailsInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955324, XrefRangeEnd = 955341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyMemberAttributeByIndex(
      ref LobbyDetailsCopyMemberAttributeByIndexOptions options,
      out Il2CppSystem.Nullable<Attribute> outAttribute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyMemberAttributeByIndex_Public_Result_byref_LobbyDetailsCopyMemberAttributeByIndexOptions_byref_Nullable_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Attribute> local = ref outAttribute;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Attribute>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955341, XrefRangeEnd = 955355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyMemberAttributeByKey(
      ref LobbyDetailsCopyMemberAttributeByKeyOptions options,
      out Il2CppSystem.Nullable<Attribute> outAttribute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyMemberAttributeByKey_Public_Result_byref_LobbyDetailsCopyMemberAttributeByKeyOptions_byref_Nullable_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Attribute> local = ref outAttribute;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Attribute>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955355, XrefRangeEnd = 955362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetAttributeCount(ref LobbyDetailsGetAttributeCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetAttributeCount_Public_UInt32_byref_LobbyDetailsGetAttributeCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955362, XrefRangeEnd = 955372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProductUserId GetLobbyOwner(ref LobbyDetailsGetLobbyOwnerOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetLobbyOwner_Public_ProductUserId_byref_LobbyDetailsGetLobbyOwnerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955372, XrefRangeEnd = 955383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetMemberAttributeCount(
      ref LobbyDetailsGetMemberAttributeCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetMemberAttributeCount_Public_UInt32_byref_LobbyDetailsGetMemberAttributeCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955383, XrefRangeEnd = 955393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProductUserId GetMemberByIndex(ref LobbyDetailsGetMemberByIndexOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetMemberByIndex_Public_ProductUserId_byref_LobbyDetailsGetMemberByIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955393, XrefRangeEnd = 955400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetMemberCount(ref LobbyDetailsGetMemberCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetMemberCount_Public_UInt32_byref_LobbyDetailsGetMemberCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955400, XrefRangeEnd = 955401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LobbyDetails()
    {
      Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LobbyDetails));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr);
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopyattributebyindexApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebykeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopyattributebykeyApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopyinfoApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopymemberattributebyindexApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebykeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopymemberattributebykeyApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetattributecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetattributecountApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetlobbyownerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetlobbyownerApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberattributecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetmemberattributecountApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetmemberbyindexApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmembercountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetmembercountApiLatest));
      LobbyDetails.NativeFieldInfoPtr_LobbydetailsInfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsInfoApiLatest));
      LobbyDetails.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670000);
      LobbyDetails.NativeMethodInfoPtr_CopyAttributeByIndex_Public_Result_byref_LobbyDetailsCopyAttributeByIndexOptions_byref_Nullable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670002);
      LobbyDetails.NativeMethodInfoPtr_CopyAttributeByKey_Public_Result_byref_LobbyDetailsCopyAttributeByKeyOptions_byref_Nullable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670003);
      LobbyDetails.NativeMethodInfoPtr_CopyInfo_Public_Result_byref_LobbyDetailsCopyInfoOptions_byref_Nullable_1_LobbyDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670004);
      LobbyDetails.NativeMethodInfoPtr_CopyMemberAttributeByIndex_Public_Result_byref_LobbyDetailsCopyMemberAttributeByIndexOptions_byref_Nullable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670005);
      LobbyDetails.NativeMethodInfoPtr_CopyMemberAttributeByKey_Public_Result_byref_LobbyDetailsCopyMemberAttributeByKeyOptions_byref_Nullable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670006);
      LobbyDetails.NativeMethodInfoPtr_GetAttributeCount_Public_UInt32_byref_LobbyDetailsGetAttributeCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670007);
      LobbyDetails.NativeMethodInfoPtr_GetLobbyOwner_Public_ProductUserId_byref_LobbyDetailsGetLobbyOwnerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670008);
      LobbyDetails.NativeMethodInfoPtr_GetMemberAttributeCount_Public_UInt32_byref_LobbyDetailsGetMemberAttributeCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670009);
      LobbyDetails.NativeMethodInfoPtr_GetMemberByIndex_Public_ProductUserId_byref_LobbyDetailsGetMemberByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670010);
      LobbyDetails.NativeMethodInfoPtr_GetMemberCount_Public_UInt32_byref_LobbyDetailsGetMemberCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670011);
      LobbyDetails.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100670012);
    }

    public LobbyDetails(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int LobbydetailsCopyattributebyindexApiLatest
    {
      get
      {
        int copyattributebyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebyindexApiLatest, (void*) &copyattributebyindexApiLatest);
        return copyattributebyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsCopyattributebykeyApiLatest
    {
      get
      {
        int copyattributebykeyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebykeyApiLatest, (void*) &copyattributebykeyApiLatest);
        return copyattributebykeyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebykeyApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsCopyinfoApiLatest
    {
      get
      {
        int copyinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyinfoApiLatest, (void*) &copyinfoApiLatest);
        return copyinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsCopymemberattributebyindexApiLatest
    {
      get
      {
        int copymemberattributebyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebyindexApiLatest, (void*) &copymemberattributebyindexApiLatest);
        return copymemberattributebyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsCopymemberattributebykeyApiLatest
    {
      get
      {
        int copymemberattributebykeyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebykeyApiLatest, (void*) &copymemberattributebykeyApiLatest);
        return copymemberattributebykeyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebykeyApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsGetattributecountApiLatest
    {
      get
      {
        int getattributecountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetattributecountApiLatest, (void*) &getattributecountApiLatest);
        return getattributecountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetattributecountApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsGetlobbyownerApiLatest
    {
      get
      {
        int getlobbyownerApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetlobbyownerApiLatest, (void*) &getlobbyownerApiLatest);
        return getlobbyownerApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetlobbyownerApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsGetmemberattributecountApiLatest
    {
      get
      {
        int getmemberattributecountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberattributecountApiLatest, (void*) &getmemberattributecountApiLatest);
        return getmemberattributecountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberattributecountApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsGetmemberbyindexApiLatest
    {
      get
      {
        int getmemberbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberbyindexApiLatest, (void*) &getmemberbyindexApiLatest);
        return getmemberbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsGetmembercountApiLatest
    {
      get
      {
        int getmembercountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmembercountApiLatest, (void*) &getmembercountApiLatest);
        return getmembercountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmembercountApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbydetailsInfoApiLatest
    {
      get
      {
        int lobbydetailsInfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsInfoApiLatest, (void*) &lobbydetailsInfoApiLatest);
        return lobbydetailsInfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsInfoApiLatest, (void*) &value);
      }
    }
  }
}
