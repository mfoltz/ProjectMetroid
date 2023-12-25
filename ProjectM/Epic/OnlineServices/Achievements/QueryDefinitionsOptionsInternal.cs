// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.QueryDefinitionsOptionsInternal
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
  public struct QueryDefinitionsOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EpicUserId_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HiddenAchievementIds_DEPRECATED;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HiddenAchievementsCount_DEPRECATED;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EpicUserId_DEPRECATED_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HiddenAchievementIds_DEPRECATED_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryDefinitionsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryDefinitionsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_EpicUserId_DEPRECATED;
    [FieldOffset(24)]
    public System.IntPtr m_HiddenAchievementIds_DEPRECATED;
    [FieldOffset(32)]
    public uint m_HiddenAchievementsCount_DEPRECATED;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974151, XrefRangeEnd = 974155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EpicAccountId EpicUserId_DEPRECATED
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974155, XrefRangeEnd = 974159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_EpicUserId_DEPRECATED_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> HiddenAchievementIds_DEPRECATED
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 974165, RefRangeEnd = 974167, XrefRangeStart = 974159, XrefRangeEnd = 974165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_HiddenAchievementIds_DEPRECATED_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 974176, RefRangeEnd = 974177, XrefRangeStart = 974167, XrefRangeEnd = 974176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref QueryDefinitionsOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryDefinitionsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974177, XrefRangeEnd = 974194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<QueryDefinitionsOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryDefinitionsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974194, XrefRangeEnd = 974200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QueryDefinitionsOptionsInternal()
    {
      Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (QueryDefinitionsOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr);
      QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_EpicUserId_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_EpicUserId_DEPRECATED));
      QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_HiddenAchievementIds_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_HiddenAchievementIds_DEPRECATED));
      QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_HiddenAchievementsCount_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_HiddenAchievementsCount_DEPRECATED));
      QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100675236);
      QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_EpicUserId_DEPRECATED_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100675237);
      QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_HiddenAchievementIds_DEPRECATED_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100675238);
      QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_QueryDefinitionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100675239);
      QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_QueryDefinitionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100675240);
      QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100675241);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
