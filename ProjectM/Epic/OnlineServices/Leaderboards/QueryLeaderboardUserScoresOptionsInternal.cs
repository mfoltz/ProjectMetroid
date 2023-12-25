// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.QueryLeaderboardUserScoresOptionsInternal
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
namespace Epic.OnlineServices.Leaderboards
{
  [StructLayout(LayoutKind.Explicit)]
  public struct QueryLeaderboardUserScoresOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserIdsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatInfoCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_UserScoresQueryStatInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryLeaderboardUserScoresOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryLeaderboardUserScoresOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_UserIds;
    [FieldOffset(16)]
    public uint m_UserIdsCount;
    [FieldOffset(24)]
    public System.IntPtr m_StatInfo;
    [FieldOffset(32)]
    public uint m_StatInfoCount;
    [FieldOffset(40)]
    public long m_StartTime;
    [FieldOffset(48)]
    public long m_EndTime;
    [FieldOffset(56)]
    public System.IntPtr m_LocalUserId;

    public unsafe Il2CppReferenceArray<ProductUserId> UserIds
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 959173, RefRangeEnd = 959175, XrefRangeStart = 959167, XrefRangeEnd = 959173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_UserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<UserScoresQueryStatInfo> StatInfo
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 959181, RefRangeEnd = 959183, XrefRangeStart = 959175, XrefRangeEnd = 959181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_UserScoresQueryStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> StartTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959183, XrefRangeEnd = 959187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> EndTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959187, XrefRangeEnd = 959191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959191, XrefRangeEnd = 959195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 959209, RefRangeEnd = 959210, XrefRangeStart = 959195, XrefRangeEnd = 959209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref QueryLeaderboardUserScoresOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryLeaderboardUserScoresOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959210, XrefRangeEnd = 959236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<QueryLeaderboardUserScoresOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryLeaderboardUserScoresOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959236, XrefRangeEnd = 959242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QueryLeaderboardUserScoresOptionsInternal()
    {
      Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (QueryLeaderboardUserScoresOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr);
      QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_UserIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_UserIds));
      QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_UserIdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_UserIdsCount));
      QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_StatInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_StatInfo));
      QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_StatInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_StatInfoCount));
      QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_StartTime));
      QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_EndTime));
      QueryLeaderboardUserScoresOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_UserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100671090);
      QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_UserScoresQueryStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100671091);
      QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100671092);
      QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100671093);
      QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100671094);
      QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryLeaderboardUserScoresOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100671095);
      QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryLeaderboardUserScoresOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100671096);
      QueryLeaderboardUserScoresOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, 100671097);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryLeaderboardUserScoresOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
