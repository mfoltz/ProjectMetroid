// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Stats.QueryStatsOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Stats
{
  [StructLayout(LayoutKind.Explicit)]
  public struct QueryStatsOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatNamesCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StatNames_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryStatsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryStatsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public long m_StartTime;
    [FieldOffset(24)]
    public long m_EndTime;
    [FieldOffset(32)]
    public System.IntPtr m_StatNames;
    [FieldOffset(40)]
    public uint m_StatNamesCount;
    [FieldOffset(48)]
    public System.IntPtr m_TargetUserId;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939696, XrefRangeEnd = 939700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> StartTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939700, XrefRangeEnd = 939704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> EndTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939704, XrefRangeEnd = 939708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> StatNames
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 939714, RefRangeEnd = 939716, XrefRangeStart = 939708, XrefRangeEnd = 939714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_StatNames_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId TargetUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939716, XrefRangeEnd = 939720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 939737, RefRangeEnd = 939738, XrefRangeStart = 939720, XrefRangeEnd = 939737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref QueryStatsOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryStatsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939738, XrefRangeEnd = 939767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<QueryStatsOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryStatsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939767, XrefRangeEnd = 939773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryStatsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QueryStatsOptionsInternal()
    {
      Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Stats", nameof (QueryStatsOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr);
      QueryStatsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      QueryStatsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      QueryStatsOptionsInternal.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_StartTime));
      QueryStatsOptionsInternal.NativeFieldInfoPtr_m_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_EndTime));
      QueryStatsOptionsInternal.NativeFieldInfoPtr_m_StatNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_StatNames));
      QueryStatsOptionsInternal.NativeFieldInfoPtr_m_StatNamesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_StatNamesCount));
      QueryStatsOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
      QueryStatsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665811);
      QueryStatsOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665812);
      QueryStatsOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665813);
      QueryStatsOptionsInternal.NativeMethodInfoPtr_set_StatNames_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665814);
      QueryStatsOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665815);
      QueryStatsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryStatsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665816);
      QueryStatsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryStatsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665817);
      QueryStatsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, 100665818);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryStatsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
