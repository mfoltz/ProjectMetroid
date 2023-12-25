// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.UserScoresQueryStatInfo
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
  public sealed class UserScoresQueryStatInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__StatName_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Aggregation_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_UserScoresQueryStatInfoInternal_0;

    public unsafe Epic.OnlineServices.Utf8String StatName
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LeaderboardAggregation Aggregation
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LeaderboardAggregation*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 959247, RefRangeEnd = 959248, XrefRangeStart = 959242, XrefRangeEnd = 959247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref UserScoresQueryStatInfoInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_UserScoresQueryStatInfoInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UserScoresQueryStatInfo()
    {
      Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (UserScoresQueryStatInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr);
      UserScoresQueryStatInfo.NativeFieldInfoPtr__StatName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, "<StatName>k__BackingField");
      UserScoresQueryStatInfo.NativeFieldInfoPtr__Aggregation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, "<Aggregation>k__BackingField");
      UserScoresQueryStatInfo.NativeMethodInfoPtr_get_StatName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100671098);
      UserScoresQueryStatInfo.NativeMethodInfoPtr_set_StatName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100671099);
      UserScoresQueryStatInfo.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100671100);
      UserScoresQueryStatInfo.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100671101);
      UserScoresQueryStatInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_UserScoresQueryStatInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100671102);
    }

    public UserScoresQueryStatInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public UserScoresQueryStatInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, data));
    }

    public unsafe Epic.OnlineServices.Utf8String _StatName_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserScoresQueryStatInfo.NativeFieldInfoPtr__StatName_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserScoresQueryStatInfo.NativeFieldInfoPtr__StatName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LeaderboardAggregation _Aggregation_k__BackingField
    {
      get
      {
        return *(LeaderboardAggregation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserScoresQueryStatInfo.NativeFieldInfoPtr__Aggregation_k__BackingField));
      }
      [param: In] set
      {
        *(LeaderboardAggregation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserScoresQueryStatInfo.NativeFieldInfoPtr__Aggregation_k__BackingField)) = value;
      }
    }
  }
}
