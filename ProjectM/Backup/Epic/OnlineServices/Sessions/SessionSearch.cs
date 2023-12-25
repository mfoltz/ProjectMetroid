// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionSearch
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  public sealed class SessionSearch : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchCopysearchresultbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchFindApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchGetsearchresultcountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchRemoveparameterApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchSetmaxsearchresultsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchSetparameterApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchSetsessionidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionsearchSettargetuseridApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_byref_SessionSearchCopySearchResultByIndexOptions_byref_SessionDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Void_byref_SessionSearchFindOptions_Object_SessionSearchOnFindCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_byref_SessionSearchGetSearchResultCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveParameter_Public_Result_byref_SessionSearchRemoveParameterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxResults_Public_Result_byref_SessionSearchSetMaxResultsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetParameter_Public_Result_byref_SessionSearchSetParameterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSessionId_Public_Result_byref_SessionSearchSetSessionIdOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetUserId_Public_Result_byref_SessionSearchSetTargetUserIdOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_byref_SessionSearchFindCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionSearch()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942246, RefRangeEnd = 942247, XrefRangeStart = 942235, XrefRangeEnd = 942246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopySearchResultByIndex(
      ref SessionSearchCopySearchResultByIndexOptions options,
      out SessionDetails outSessionHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_byref_SessionSearchCopySearchResultByIndexOptions_byref_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionDetails local = ref outSessionHandle;
      System.IntPtr pointer = zero;
      SessionDetails sessionDetails = pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
      local = sessionDetails;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942247, XrefRangeEnd = 942270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Find(
      ref SessionSearchFindOptions options,
      Il2CppSystem.Object clientData,
      SessionSearchOnFindCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_Find_Public_Void_byref_SessionSearchFindOptions_Object_SessionSearchOnFindCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942277, RefRangeEnd = 942278, XrefRangeStart = 942270, XrefRangeEnd = 942277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetSearchResultCount(
      ref SessionSearchGetSearchResultCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_byref_SessionSearchGetSearchResultCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942279, RefRangeEnd = 942280, XrefRangeStart = 942278, XrefRangeEnd = 942279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942280, XrefRangeEnd = 942291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RemoveParameter(ref SessionSearchRemoveParameterOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_RemoveParameter_Public_Result_byref_SessionSearchRemoveParameterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942291, XrefRangeEnd = 942298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetMaxResults(ref SessionSearchSetMaxResultsOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetMaxResults_Public_Result_byref_SessionSearchSetMaxResultsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942298, XrefRangeEnd = 942306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetParameter(ref SessionSearchSetParameterOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetParameter_Public_Result_byref_SessionSearchSetParameterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942306, XrefRangeEnd = 942317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetSessionId(ref SessionSearchSetSessionIdOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetSessionId_Public_Result_byref_SessionSearchSetSessionIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942317, XrefRangeEnd = 942328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetTargetUserId(ref SessionSearchSetTargetUserIdOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetTargetUserId_Public_Result_byref_SessionSearchSetTargetUserIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942328, XrefRangeEnd = 942335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnFindCallbackInternalImplementation(
      ref SessionSearchFindCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_byref_SessionSearchFindCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SessionSearch()
    {
      Il2CppClassPointerStore<SessionSearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionSearch));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr);
      SessionSearch.NativeFieldInfoPtr_SessionsearchCopysearchresultbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchCopysearchresultbyindexApiLatest));
      SessionSearch.NativeFieldInfoPtr_SessionsearchFindApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchFindApiLatest));
      SessionSearch.NativeFieldInfoPtr_SessionsearchGetsearchresultcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchGetsearchresultcountApiLatest));
      SessionSearch.NativeFieldInfoPtr_SessionsearchRemoveparameterApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchRemoveparameterApiLatest));
      SessionSearch.NativeFieldInfoPtr_SessionsearchSetmaxsearchresultsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchSetmaxsearchresultsApiLatest));
      SessionSearch.NativeFieldInfoPtr_SessionsearchSetparameterApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchSetparameterApiLatest));
      SessionSearch.NativeFieldInfoPtr_SessionsearchSetsessionidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchSetsessionidApiLatest));
      SessionSearch.NativeFieldInfoPtr_SessionsearchSettargetuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (SessionsearchSettargetuseridApiLatest));
      SessionSearch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666525);
      SessionSearch.NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_byref_SessionSearchCopySearchResultByIndexOptions_byref_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666527);
      SessionSearch.NativeMethodInfoPtr_Find_Public_Void_byref_SessionSearchFindOptions_Object_SessionSearchOnFindCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666528);
      SessionSearch.NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_byref_SessionSearchGetSearchResultCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666529);
      SessionSearch.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666530);
      SessionSearch.NativeMethodInfoPtr_RemoveParameter_Public_Result_byref_SessionSearchRemoveParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666531);
      SessionSearch.NativeMethodInfoPtr_SetMaxResults_Public_Result_byref_SessionSearchSetMaxResultsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666532);
      SessionSearch.NativeMethodInfoPtr_SetParameter_Public_Result_byref_SessionSearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666533);
      SessionSearch.NativeMethodInfoPtr_SetSessionId_Public_Result_byref_SessionSearchSetSessionIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666534);
      SessionSearch.NativeMethodInfoPtr_SetTargetUserId_Public_Result_byref_SessionSearchSetTargetUserIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666535);
      SessionSearch.NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_byref_SessionSearchFindCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100666536);
    }

    public SessionSearch(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int SessionsearchCopysearchresultbyindexApiLatest
    {
      get
      {
        int copysearchresultbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchCopysearchresultbyindexApiLatest, (void*) &copysearchresultbyindexApiLatest);
        return copysearchresultbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchCopysearchresultbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionsearchFindApiLatest
    {
      get
      {
        int sessionsearchFindApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchFindApiLatest, (void*) &sessionsearchFindApiLatest);
        return sessionsearchFindApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchFindApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionsearchGetsearchresultcountApiLatest
    {
      get
      {
        int getsearchresultcountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchGetsearchresultcountApiLatest, (void*) &getsearchresultcountApiLatest);
        return getsearchresultcountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchGetsearchresultcountApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionsearchRemoveparameterApiLatest
    {
      get
      {
        int removeparameterApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchRemoveparameterApiLatest, (void*) &removeparameterApiLatest);
        return removeparameterApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchRemoveparameterApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionsearchSetmaxsearchresultsApiLatest
    {
      get
      {
        int setmaxsearchresultsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetmaxsearchresultsApiLatest, (void*) &setmaxsearchresultsApiLatest);
        return setmaxsearchresultsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetmaxsearchresultsApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionsearchSetparameterApiLatest
    {
      get
      {
        int setparameterApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetparameterApiLatest, (void*) &setparameterApiLatest);
        return setparameterApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetparameterApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionsearchSetsessionidApiLatest
    {
      get
      {
        int setsessionidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetsessionidApiLatest, (void*) &setsessionidApiLatest);
        return setsessionidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSetsessionidApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionsearchSettargetuseridApiLatest
    {
      get
      {
        int settargetuseridApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSettargetuseridApiLatest, (void*) &settargetuseridApiLatest);
        return settargetuseridApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_SessionsearchSettargetuseridApiLatest, (void*) &value);
      }
    }
  }
}
