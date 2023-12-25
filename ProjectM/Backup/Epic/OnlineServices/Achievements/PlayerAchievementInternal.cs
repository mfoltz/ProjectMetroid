// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.PlayerAchievementInternal
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
namespace Epic.OnlineServices.Achievements
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlayerAchievementInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatInfoCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IconURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FlavorText;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Progress_Public_get_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Progress_Public_set_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StatInfo_Public_get_Il2CppReferenceArray_1_PlayerStatInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_PlayerStatInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IconURL_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IconURL_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FlavorText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_FlavorText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerAchievement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerAchievement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerAchievement_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_AchievementId;
    [FieldOffset(16)]
    public double m_Progress;
    [FieldOffset(24)]
    public long m_UnlockTime;
    [FieldOffset(32)]
    public int m_StatInfoCount;
    [FieldOffset(40)]
    public System.IntPtr m_StatInfo;
    [FieldOffset(48)]
    public System.IntPtr m_DisplayName;
    [FieldOffset(56)]
    public System.IntPtr m_Description;
    [FieldOffset(64)]
    public System.IntPtr m_IconURL;
    [FieldOffset(72)]
    public System.IntPtr m_FlavorText;

    public unsafe Epic.OnlineServices.Utf8String AchievementId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973975, XrefRangeEnd = 973979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973979, XrefRangeEnd = 973983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe double Progress
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_Progress_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(double*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_Progress_Public_set_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> UnlockTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973983, XrefRangeEnd = 973987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Il2CppSystem.DateTimeOffset>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973987, XrefRangeEnd = 973991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<PlayerStatInfo> StatInfo
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 973997, RefRangeEnd = 973998, XrefRangeStart = 973991, XrefRangeEnd = 973997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_StatInfo_Public_get_Il2CppReferenceArray_1_PlayerStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<PlayerStatInfo>) null : new Il2CppReferenceArray<PlayerStatInfo>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 974004, RefRangeEnd = 974006, XrefRangeStart = 973998, XrefRangeEnd = 974004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_PlayerStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DisplayName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974006, XrefRangeEnd = 974010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974010, XrefRangeEnd = 974014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Description
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974014, XrefRangeEnd = 974018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_Description_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974018, XrefRangeEnd = 974022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_Description_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String IconURL
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974022, XrefRangeEnd = 974026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_IconURL_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974026, XrefRangeEnd = 974030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_IconURL_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String FlavorText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974030, XrefRangeEnd = 974034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_FlavorText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974034, XrefRangeEnd = 974038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974038, XrefRangeEnd = 974063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref PlayerAchievement other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerAchievement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974063, XrefRangeEnd = 974106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<PlayerAchievement> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerAchievement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974106, XrefRangeEnd = 974115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974115, XrefRangeEnd = 974116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out PlayerAchievement output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerAchievement_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayerAchievement local = ref output;
      System.IntPtr pointer = zero;
      PlayerAchievement playerAchievement = pointer == System.IntPtr.Zero ? (PlayerAchievement) null : new PlayerAchievement(pointer);
      local = playerAchievement;
    }

    static PlayerAchievementInternal()
    {
      Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (PlayerAchievementInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr);
      PlayerAchievementInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_AchievementId));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_Progress));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_UnlockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_UnlockTime));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_StatInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_StatInfoCount));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_StatInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_StatInfo));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_DisplayName));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_Description));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_IconURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_IconURL));
      PlayerAchievementInternal.NativeFieldInfoPtr_m_FlavorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_FlavorText));
      PlayerAchievementInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675193);
      PlayerAchievementInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675194);
      PlayerAchievementInternal.NativeMethodInfoPtr_get_Progress_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675195);
      PlayerAchievementInternal.NativeMethodInfoPtr_set_Progress_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675196);
      PlayerAchievementInternal.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675197);
      PlayerAchievementInternal.NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675198);
      PlayerAchievementInternal.NativeMethodInfoPtr_get_StatInfo_Public_get_Il2CppReferenceArray_1_PlayerStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675199);
      PlayerAchievementInternal.NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_PlayerStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675200);
      PlayerAchievementInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675201);
      PlayerAchievementInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675202);
      PlayerAchievementInternal.NativeMethodInfoPtr_get_Description_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675203);
      PlayerAchievementInternal.NativeMethodInfoPtr_set_Description_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675204);
      PlayerAchievementInternal.NativeMethodInfoPtr_get_IconURL_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675205);
      PlayerAchievementInternal.NativeMethodInfoPtr_set_IconURL_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675206);
      PlayerAchievementInternal.NativeMethodInfoPtr_get_FlavorText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675207);
      PlayerAchievementInternal.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675208);
      PlayerAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PlayerAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675209);
      PlayerAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PlayerAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675210);
      PlayerAchievementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675211);
      PlayerAchievementInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PlayerAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100675212);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
