// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.UserScoresQueryStatInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserScoresQueryStatInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Aggregation;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserScoresQueryStatInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserScoresQueryStatInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserScoresQueryStatInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_StatName;
    [FieldOffset(16)]
    public LeaderboardAggregation m_Aggregation;

    public unsafe Epic.OnlineServices.Utf8String StatName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959248, XrefRangeEnd = 959252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959252, XrefRangeEnd = 959256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LeaderboardAggregation Aggregation
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LeaderboardAggregation*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959256, XrefRangeEnd = 959260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UserScoresQueryStatInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserScoresQueryStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959260, XrefRangeEnd = 959270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UserScoresQueryStatInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserScoresQueryStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959270, XrefRangeEnd = 959274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959274, XrefRangeEnd = 959275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out UserScoresQueryStatInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserScoresQueryStatInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref UserScoresQueryStatInfo local = ref output;
      System.IntPtr pointer = zero;
      UserScoresQueryStatInfo scoresQueryStatInfo = pointer == System.IntPtr.Zero ? (UserScoresQueryStatInfo) null : new UserScoresQueryStatInfo(pointer);
      local = scoresQueryStatInfo;
    }

    static UserScoresQueryStatInfoInternal()
    {
      Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (UserScoresQueryStatInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr);
      UserScoresQueryStatInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UserScoresQueryStatInfoInternal.NativeFieldInfoPtr_m_StatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, nameof (m_StatName));
      UserScoresQueryStatInfoInternal.NativeFieldInfoPtr_m_Aggregation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, nameof (m_Aggregation));
      UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100671103);
      UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100671104);
      UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100671105);
      UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100671106);
      UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UserScoresQueryStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100671107);
      UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UserScoresQueryStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100671108);
      UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100671109);
      UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UserScoresQueryStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100671110);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
