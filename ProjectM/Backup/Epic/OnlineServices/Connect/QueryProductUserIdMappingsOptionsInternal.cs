// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.QueryProductUserIdMappingsOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect
{
  [StructLayout(LayoutKind.Explicit)]
  public struct QueryProductUserIdMappingsOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserIdCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountIdType_DEPRECATED_Public_set_Void_ExternalAccountType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryProductUserIdMappingsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryProductUserIdMappingsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public ExternalAccountType m_AccountIdType_DEPRECATED;
    [FieldOffset(24)]
    public System.IntPtr m_ProductUserIds;
    [FieldOffset(32)]
    public uint m_ProductUserIdCount;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966345, XrefRangeEnd = 966349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ExternalAccountType AccountIdType_DEPRECATED
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_AccountIdType_DEPRECATED_Public_set_Void_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<ProductUserId> ProductUserIds
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 966355, RefRangeEnd = 966357, XrefRangeStart = 966349, XrefRangeEnd = 966355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_ProductUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 966362, RefRangeEnd = 966363, XrefRangeStart = 966357, XrefRangeEnd = 966362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref QueryProductUserIdMappingsOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryProductUserIdMappingsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966363, XrefRangeEnd = 966376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<QueryProductUserIdMappingsOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryProductUserIdMappingsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966376, XrefRangeEnd = 966381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QueryProductUserIdMappingsOptionsInternal()
    {
      Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (QueryProductUserIdMappingsOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr);
      QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_AccountIdType_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_AccountIdType_DEPRECATED));
      QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_ProductUserIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_ProductUserIds));
      QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_ProductUserIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_ProductUserIdCount));
      QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100673104);
      QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_AccountIdType_DEPRECATED_Public_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100673105);
      QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_ProductUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100673106);
      QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryProductUserIdMappingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100673107);
      QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryProductUserIdMappingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100673108);
      QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100673109);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
