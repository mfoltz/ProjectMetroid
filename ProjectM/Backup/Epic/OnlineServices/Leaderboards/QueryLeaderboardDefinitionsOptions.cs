// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.QueryLeaderboardDefinitionsOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards
{
  public sealed class QueryLeaderboardDefinitionsOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__StartTime_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__EndTime_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> StartTime
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 242918, RefRangeEnd = 242920, XrefRangeStart = 242918, XrefRangeEnd = 242920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Il2CppSystem.DateTimeOffset>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(5), CachedScanResults(RefRangeStart = 743279, RefRangeEnd = 743284, XrefRangeStart = 743279, XrefRangeEnd = 743284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> EndTime
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Il2CppSystem.DateTimeOffset>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static QueryLeaderboardDefinitionsOptions()
    {
      Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (QueryLeaderboardDefinitionsOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr);
      QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__StartTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, "<StartTime>k__BackingField");
      QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__EndTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, "<EndTime>k__BackingField");
      QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
      QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, 100671059);
      QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, 100671060);
      QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, 100671061);
      QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, 100671062);
      QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, 100671063);
      QueryLeaderboardDefinitionsOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, 100671064);
    }

    public QueryLeaderboardDefinitionsOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public QueryLeaderboardDefinitionsOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryLeaderboardDefinitionsOptions>.NativeClassPtr, data));
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> _StartTime_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Il2CppSystem.DateTimeOffset>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__StartTime_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__StartTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<Il2CppSystem.DateTimeOffset> _EndTime_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Il2CppSystem.DateTimeOffset>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__EndTime_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__EndTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ProductUserId _LocalUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QueryLeaderboardDefinitionsOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
