// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.UnlockAchievementsOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnlockAchievementsOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementsCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnlockAchievementsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnlockAchievementsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_UserId;
    [FieldOffset(16)]
    public System.IntPtr m_AchievementIds;
    [FieldOffset(24)]
    public uint m_AchievementsCount;

    public unsafe ProductUserId UserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974269, XrefRangeEnd = 974273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> AchievementIds
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 974279, RefRangeEnd = 974281, XrefRangeStart = 974273, XrefRangeEnd = 974279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_set_AchievementIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 974286, RefRangeEnd = 974287, XrefRangeStart = 974281, XrefRangeEnd = 974286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UnlockAchievementsOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnlockAchievementsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974287, XrefRangeEnd = 974298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UnlockAchievementsOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnlockAchievementsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974298, XrefRangeEnd = 974303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnlockAchievementsOptionsInternal()
    {
      Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (UnlockAchievementsOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr);
      UnlockAchievementsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UnlockAchievementsOptionsInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, nameof (m_UserId));
      UnlockAchievementsOptionsInternal.NativeFieldInfoPtr_m_AchievementIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, nameof (m_AchievementIds));
      UnlockAchievementsOptionsInternal.NativeFieldInfoPtr_m_AchievementsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, nameof (m_AchievementsCount));
      UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100675268);
      UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_set_AchievementIds_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100675269);
      UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnlockAchievementsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100675270);
      UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnlockAchievementsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100675271);
      UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100675272);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
