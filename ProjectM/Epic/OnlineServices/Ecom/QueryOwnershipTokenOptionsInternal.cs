// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.QueryOwnershipTokenOptionsInternal
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
  public struct QueryOwnershipTokenOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogItemIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogItemIdCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogNamespace;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryOwnershipTokenOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryOwnershipTokenOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_CatalogItemIds;
    [FieldOffset(24)]
    public uint m_CatalogItemIdCount;
    [FieldOffset(32)]
    public System.IntPtr m_CatalogNamespace;

    public unsafe EpicAccountId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963764, XrefRangeEnd = 963768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> CatalogItemIds
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 963774, RefRangeEnd = 963776, XrefRangeStart = 963768, XrefRangeEnd = 963774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CatalogNamespace
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963776, XrefRangeEnd = 963780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 963789, RefRangeEnd = 963790, XrefRangeStart = 963780, XrefRangeEnd = 963789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref QueryOwnershipTokenOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryOwnershipTokenOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963790, XrefRangeEnd = 963807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<QueryOwnershipTokenOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryOwnershipTokenOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963807, XrefRangeEnd = 963813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QueryOwnershipTokenOptionsInternal()
    {
      Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (QueryOwnershipTokenOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr);
      QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_CatalogItemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_CatalogItemIds));
      QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_CatalogItemIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_CatalogItemIdCount));
      QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_CatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_CatalogNamespace));
      QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100672379);
      QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100672380);
      QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100672381);
      QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryOwnershipTokenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100672382);
      QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryOwnershipTokenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100672383);
      QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100672384);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
