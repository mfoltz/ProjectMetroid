// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.LeaderboardUserScoreInternal
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
  public struct LeaderboardUserScoreInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Score;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Score_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Score_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LeaderboardUserScore_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LeaderboardUserScore_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LeaderboardUserScore_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_UserId;
    [FieldOffset(16)]
    public int m_Score;

    public unsafe ProductUserId UserId
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 958738, RefRangeEnd = 958740, XrefRangeStart = 958732, XrefRangeEnd = 958738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardUserScoreInternal.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958740, XrefRangeEnd = 958744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LeaderboardUserScoreInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int Score
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardUserScoreInternal.NativeMethodInfoPtr_get_Score_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LeaderboardUserScoreInternal.NativeMethodInfoPtr_set_Score_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958744, XrefRangeEnd = 958748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LeaderboardUserScore other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardUserScoreInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LeaderboardUserScore_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958748, XrefRangeEnd = 958758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LeaderboardUserScore> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardUserScoreInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LeaderboardUserScore_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958758, XrefRangeEnd = 958762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardUserScoreInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958762, XrefRangeEnd = 958764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out LeaderboardUserScore output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardUserScoreInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LeaderboardUserScore_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LeaderboardUserScore local = ref output;
      System.IntPtr pointer = zero;
      LeaderboardUserScore leaderboardUserScore = pointer == System.IntPtr.Zero ? (LeaderboardUserScore) null : new LeaderboardUserScore(pointer);
      local = leaderboardUserScore;
    }

    static LeaderboardUserScoreInternal()
    {
      Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (LeaderboardUserScoreInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr);
      LeaderboardUserScoreInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LeaderboardUserScoreInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, nameof (m_UserId));
      LeaderboardUserScoreInternal.NativeFieldInfoPtr_m_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, nameof (m_Score));
      LeaderboardUserScoreInternal.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, 100670965);
      LeaderboardUserScoreInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, 100670966);
      LeaderboardUserScoreInternal.NativeMethodInfoPtr_get_Score_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, 100670967);
      LeaderboardUserScoreInternal.NativeMethodInfoPtr_set_Score_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, 100670968);
      LeaderboardUserScoreInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LeaderboardUserScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, 100670969);
      LeaderboardUserScoreInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LeaderboardUserScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, 100670970);
      LeaderboardUserScoreInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, 100670971);
      LeaderboardUserScoreInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LeaderboardUserScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, 100670972);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardUserScoreInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
