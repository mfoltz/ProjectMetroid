// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.UnlockedAchievementInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnlockedAchievementInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnlockedAchievement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnlockedAchievement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UnlockedAchievement_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_AchievementId;
    [FieldOffset(16)]
    public long m_UnlockTime;

    public unsafe Epic.OnlineServices.Utf8String AchievementId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974313, XrefRangeEnd = 974317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnlockedAchievementInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974317, XrefRangeEnd = 974321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnlockedAchievementInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> UnlockTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974321, XrefRangeEnd = 974325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnlockedAchievementInternal.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Il2CppSystem.DateTimeOffset>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974325, XrefRangeEnd = 974329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnlockedAchievementInternal.NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974329, XrefRangeEnd = 974337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UnlockedAchievement other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockedAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnlockedAchievement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974337, XrefRangeEnd = 974351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UnlockedAchievement> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockedAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnlockedAchievement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974351, XrefRangeEnd = 974355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockedAchievementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974355, XrefRangeEnd = 974356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out UnlockedAchievement output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockedAchievementInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UnlockedAchievement_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref UnlockedAchievement local = ref output;
      System.IntPtr pointer = zero;
      UnlockedAchievement unlockedAchievement = pointer == System.IntPtr.Zero ? (UnlockedAchievement) null : new UnlockedAchievement(pointer);
      local = unlockedAchievement;
    }

    static UnlockedAchievementInternal()
    {
      Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (UnlockedAchievementInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr);
      UnlockedAchievementInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UnlockedAchievementInternal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, nameof (m_AchievementId));
      UnlockedAchievementInternal.NativeFieldInfoPtr_m_UnlockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, nameof (m_UnlockTime));
      UnlockedAchievementInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, 100675278);
      UnlockedAchievementInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, 100675279);
      UnlockedAchievementInternal.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, 100675280);
      UnlockedAchievementInternal.NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, 100675281);
      UnlockedAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnlockedAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, 100675282);
      UnlockedAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnlockedAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, 100675283);
      UnlockedAchievementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, 100675284);
      UnlockedAchievementInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_UnlockedAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, 100675285);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnlockedAchievementInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
