// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.Transaction
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
  public sealed class Transaction : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TransactionCopyentitlementbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransactionGetentitlementscountApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_byref_TransactionCopyEntitlementByIndexOptions_byref_Nullable_1_Entitlement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_byref_TransactionGetEntitlementsCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTransactionId_Public_Result_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Transaction()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transaction>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963909, XrefRangeEnd = 963922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyEntitlementByIndex(
      ref TransactionCopyEntitlementByIndexOptions options,
      out Il2CppSystem.Nullable<Entitlement> outEntitlement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_byref_TransactionCopyEntitlementByIndexOptions_byref_Nullable_1_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Entitlement> local = ref outEntitlement;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Entitlement>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963922, XrefRangeEnd = 963929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetEntitlementsCount(ref TransactionGetEntitlementsCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_byref_TransactionGetEntitlementsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963929, XrefRangeEnd = 963936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetTransactionId(out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_GetTransactionId_Public_Result_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963936, XrefRangeEnd = 963937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Transaction()
    {
      Il2CppClassPointerStore<Transaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (Transaction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transaction>.NativeClassPtr);
      Transaction.NativeFieldInfoPtr_TransactionCopyentitlementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, nameof (TransactionCopyentitlementbyindexApiLatest));
      Transaction.NativeFieldInfoPtr_TransactionGetentitlementscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, nameof (TransactionGetentitlementscountApiLatest));
      Transaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100672417);
      Transaction.NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_byref_TransactionCopyEntitlementByIndexOptions_byref_Nullable_1_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100672419);
      Transaction.NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_byref_TransactionGetEntitlementsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100672420);
      Transaction.NativeMethodInfoPtr_GetTransactionId_Public_Result_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100672421);
      Transaction.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100672422);
    }

    public Transaction(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int TransactionCopyentitlementbyindexApiLatest
    {
      get
      {
        int copyentitlementbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(Transaction.NativeFieldInfoPtr_TransactionCopyentitlementbyindexApiLatest, (void*) &copyentitlementbyindexApiLatest);
        return copyentitlementbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Transaction.NativeFieldInfoPtr_TransactionCopyentitlementbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int TransactionGetentitlementscountApiLatest
    {
      get
      {
        int getentitlementscountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(Transaction.NativeFieldInfoPtr_TransactionGetentitlementscountApiLatest, (void*) &getentitlementscountApiLatest);
        return getentitlementscountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Transaction.NativeFieldInfoPtr_TransactionGetentitlementscountApiLatest, (void*) &value);
      }
    }
  }
}
