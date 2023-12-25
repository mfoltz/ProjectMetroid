// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Stats.StatsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Stats
{
  public sealed class StatsInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CopystatbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopystatbynameApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetstatcountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetstatscountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_IngestdataApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_IngeststatApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxIngestStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxQueryStats;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuerystatsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeUndefined;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyStatByIndex_Public_Result_byref_CopyStatByIndexOptions_byref_Nullable_1_Stat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyStatByName_Public_Result_byref_CopyStatByNameOptions_byref_Nullable_1_Stat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStatsCount_Public_UInt32_byref_GetStatCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IngestStat_Public_Void_byref_IngestStatOptions_Object_OnIngestStatCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryStats_Public_Void_byref_QueryStatsOptions_Object_OnQueryStatsCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnIngestStatCompleteCallbackInternalImplementation_Internal_Static_Void_byref_IngestStatCompleteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryStatsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryStatsCompleteCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939844, XrefRangeEnd = 939858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyStatByIndex(
      ref CopyStatByIndexOptions options,
      out Il2CppSystem.Nullable<Stat> outStat)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_CopyStatByIndex_Public_Result_byref_CopyStatByIndexOptions_byref_Nullable_1_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Stat> local = ref outStat;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Stat>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939858, XrefRangeEnd = 939872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyStatByName(
      ref CopyStatByNameOptions options,
      out Il2CppSystem.Nullable<Stat> outStat)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_CopyStatByName_Public_Result_byref_CopyStatByNameOptions_byref_Nullable_1_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Stat> local = ref outStat;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Stat>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939872, XrefRangeEnd = 939880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetStatsCount(ref GetStatCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_GetStatsCount_Public_UInt32_byref_GetStatCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939880, XrefRangeEnd = 939899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IngestStat(
      ref IngestStatOptions options,
      Il2CppSystem.Object clientData,
      OnIngestStatCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_IngestStat_Public_Void_byref_IngestStatOptions_Object_OnIngestStatCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939899, XrefRangeEnd = 939918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryStats(
      ref QueryStatsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryStatsCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_QueryStats_Public_Void_byref_QueryStatsOptions_Object_OnQueryStatsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939918, XrefRangeEnd = 939925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnIngestStatCompleteCallbackInternalImplementation(
      ref IngestStatCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_OnIngestStatCompleteCallbackInternalImplementation_Internal_Static_Void_byref_IngestStatCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939925, XrefRangeEnd = 939932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryStatsCompleteCallbackInternalImplementation(
      ref OnQueryStatsCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsInterface.NativeMethodInfoPtr_OnQueryStatsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryStatsCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StatsInterface()
    {
      Il2CppClassPointerStore<StatsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Stats", nameof (StatsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr);
      StatsInterface.NativeFieldInfoPtr_CopystatbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (CopystatbyindexApiLatest));
      StatsInterface.NativeFieldInfoPtr_CopystatbynameApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (CopystatbynameApiLatest));
      StatsInterface.NativeFieldInfoPtr_GetstatcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (GetstatcountApiLatest));
      StatsInterface.NativeFieldInfoPtr_GetstatscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (GetstatscountApiLatest));
      StatsInterface.NativeFieldInfoPtr_IngestdataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (IngestdataApiLatest));
      StatsInterface.NativeFieldInfoPtr_IngeststatApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (IngeststatApiLatest));
      StatsInterface.NativeFieldInfoPtr_MaxIngestStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (MaxIngestStats));
      StatsInterface.NativeFieldInfoPtr_MaxQueryStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (MaxQueryStats));
      StatsInterface.NativeFieldInfoPtr_QuerystatsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (QuerystatsApiLatest));
      StatsInterface.NativeFieldInfoPtr_StatApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (StatApiLatest));
      StatsInterface.NativeFieldInfoPtr_TimeUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, nameof (TimeUndefined));
      StatsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665840);
      StatsInterface.NativeMethodInfoPtr_CopyStatByIndex_Public_Result_byref_CopyStatByIndexOptions_byref_Nullable_1_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665842);
      StatsInterface.NativeMethodInfoPtr_CopyStatByName_Public_Result_byref_CopyStatByNameOptions_byref_Nullable_1_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665843);
      StatsInterface.NativeMethodInfoPtr_GetStatsCount_Public_UInt32_byref_GetStatCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665844);
      StatsInterface.NativeMethodInfoPtr_IngestStat_Public_Void_byref_IngestStatOptions_Object_OnIngestStatCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665845);
      StatsInterface.NativeMethodInfoPtr_QueryStats_Public_Void_byref_QueryStatsOptions_Object_OnQueryStatsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665846);
      StatsInterface.NativeMethodInfoPtr_OnIngestStatCompleteCallbackInternalImplementation_Internal_Static_Void_byref_IngestStatCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665847);
      StatsInterface.NativeMethodInfoPtr_OnQueryStatsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryStatsCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsInterface>.NativeClassPtr, 100665848);
    }

    public StatsInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CopystatbyindexApiLatest
    {
      get
      {
        int copystatbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_CopystatbyindexApiLatest, (void*) &copystatbyindexApiLatest);
        return copystatbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_CopystatbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopystatbynameApiLatest
    {
      get
      {
        int copystatbynameApiLatest;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_CopystatbynameApiLatest, (void*) &copystatbynameApiLatest);
        return copystatbynameApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_CopystatbynameApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetstatcountApiLatest
    {
      get
      {
        int getstatcountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_GetstatcountApiLatest, (void*) &getstatcountApiLatest);
        return getstatcountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_GetstatcountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetstatscountApiLatest
    {
      get
      {
        int getstatscountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_GetstatscountApiLatest, (void*) &getstatscountApiLatest);
        return getstatscountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_GetstatscountApiLatest, (void*) &value);
      }
    }

    public static unsafe int IngestdataApiLatest
    {
      get
      {
        int ingestdataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_IngestdataApiLatest, (void*) &ingestdataApiLatest);
        return ingestdataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_IngestdataApiLatest, (void*) &value);
      }
    }

    public static unsafe int IngeststatApiLatest
    {
      get
      {
        int ingeststatApiLatest;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_IngeststatApiLatest, (void*) &ingeststatApiLatest);
        return ingeststatApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_IngeststatApiLatest, (void*) &value);
      }
    }

    public static unsafe int MaxIngestStats
    {
      get
      {
        int maxIngestStats;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_MaxIngestStats, (void*) &maxIngestStats);
        return maxIngestStats;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_MaxIngestStats, (void*) &value);
      }
    }

    public static unsafe int MaxQueryStats
    {
      get
      {
        int maxQueryStats;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_MaxQueryStats, (void*) &maxQueryStats);
        return maxQueryStats;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_MaxQueryStats, (void*) &value);
      }
    }

    public static unsafe int QuerystatsApiLatest
    {
      get
      {
        int querystatsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_QuerystatsApiLatest, (void*) &querystatsApiLatest);
        return querystatsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_QuerystatsApiLatest, (void*) &value);
      }
    }

    public static unsafe int StatApiLatest
    {
      get
      {
        int statApiLatest;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_StatApiLatest, (void*) &statApiLatest);
        return statApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_StatApiLatest, (void*) &value);
      }
    }

    public static unsafe int TimeUndefined
    {
      get
      {
        int timeUndefined;
        IL2CPP.il2cpp_field_static_get_value(StatsInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &timeUndefined);
        return timeUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &value);
      }
    }
  }
}
