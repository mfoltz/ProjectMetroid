// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.QueryEntitlementTokenOptionsInternal
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
  public struct QueryEntitlementTokenOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementNameCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementNames_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryEntitlementTokenOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryEntitlementTokenOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_EntitlementNames;
    [FieldOffset(24)]
    public uint m_EntitlementNameCount;

    public unsafe EpicAccountId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963311, XrefRangeEnd = 963315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> EntitlementNames
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 963321, RefRangeEnd = 963323, XrefRangeStart = 963315, XrefRangeEnd = 963321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_set_EntitlementNames_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 963328, RefRangeEnd = 963329, XrefRangeStart = 963323, XrefRangeEnd = 963328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref QueryEntitlementTokenOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryEntitlementTokenOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963329, XrefRangeEnd = 963340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<QueryEntitlementTokenOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryEntitlementTokenOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963340, XrefRangeEnd = 963345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QueryEntitlementTokenOptionsInternal()
    {
      Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (QueryEntitlementTokenOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr);
      QueryEntitlementTokenOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      QueryEntitlementTokenOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      QueryEntitlementTokenOptionsInternal.NativeFieldInfoPtr_m_EntitlementNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, nameof (m_EntitlementNames));
      QueryEntitlementTokenOptionsInternal.NativeFieldInfoPtr_m_EntitlementNameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, nameof (m_EntitlementNameCount));
      QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, 100672251);
      QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_set_EntitlementNames_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, 100672252);
      QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryEntitlementTokenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, 100672253);
      QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryEntitlementTokenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, 100672254);
      QueryEntitlementTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, 100672255);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryEntitlementTokenOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
