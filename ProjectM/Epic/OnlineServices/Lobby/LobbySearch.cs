// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbySearch
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  public sealed class LobbySearch : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchCopysearchresultbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchFindApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchGetsearchresultcountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchRemoveparameterApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchSetlobbyidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchSetmaxresultsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchSetparameterApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LobbysearchSettargetuseridApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_byref_LobbySearchCopySearchResultByIndexOptions_byref_LobbyDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Void_byref_LobbySearchFindOptions_Object_LobbySearchOnFindCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_byref_LobbySearchGetSearchResultCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveParameter_Public_Result_byref_LobbySearchRemoveParameterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLobbyId_Public_Result_byref_LobbySearchSetLobbyIdOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxResults_Public_Result_byref_LobbySearchSetMaxResultsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetParameter_Public_Result_byref_LobbySearchSetParameterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetUserId_Public_Result_byref_LobbySearchSetTargetUserIdOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_byref_LobbySearchFindCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LobbySearch()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957139, XrefRangeEnd = 957150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopySearchResultByIndex(
      ref LobbySearchCopySearchResultByIndexOptions options,
      out LobbyDetails outLobbyDetailsHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_byref_LobbySearchCopySearchResultByIndexOptions_byref_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LobbyDetails local = ref outLobbyDetailsHandle;
      System.IntPtr pointer = zero;
      LobbyDetails lobbyDetails = pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
      local = lobbyDetails;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957150, XrefRangeEnd = 957169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Find(
      ref LobbySearchFindOptions options,
      Il2CppSystem.Object clientData,
      LobbySearchOnFindCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_Find_Public_Void_byref_LobbySearchFindOptions_Object_LobbySearchOnFindCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957169, XrefRangeEnd = 957177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetSearchResultCount(ref LobbySearchGetSearchResultCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_byref_LobbySearchGetSearchResultCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957177, XrefRangeEnd = 957178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957178, XrefRangeEnd = 957186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RemoveParameter(ref LobbySearchRemoveParameterOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_RemoveParameter_Public_Result_byref_LobbySearchRemoveParameterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957186, XrefRangeEnd = 957194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetLobbyId(ref LobbySearchSetLobbyIdOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_SetLobbyId_Public_Result_byref_LobbySearchSetLobbyIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957194, XrefRangeEnd = 957202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetMaxResults(ref LobbySearchSetMaxResultsOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_SetMaxResults_Public_Result_byref_LobbySearchSetMaxResultsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957202, XrefRangeEnd = 957210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetParameter(ref LobbySearchSetParameterOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_SetParameter_Public_Result_byref_LobbySearchSetParameterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957210, XrefRangeEnd = 957218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetTargetUserId(ref LobbySearchSetTargetUserIdOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_SetTargetUserId_Public_Result_byref_LobbySearchSetTargetUserIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957218, XrefRangeEnd = 957225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnFindCallbackInternalImplementation(
      ref LobbySearchFindCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbySearch.NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_byref_LobbySearchFindCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LobbySearch()
    {
      Il2CppClassPointerStore<LobbySearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LobbySearch));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr);
      LobbySearch.NativeFieldInfoPtr_LobbysearchCopysearchresultbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchCopysearchresultbyindexApiLatest));
      LobbySearch.NativeFieldInfoPtr_LobbysearchFindApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchFindApiLatest));
      LobbySearch.NativeFieldInfoPtr_LobbysearchGetsearchresultcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchGetsearchresultcountApiLatest));
      LobbySearch.NativeFieldInfoPtr_LobbysearchRemoveparameterApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchRemoveparameterApiLatest));
      LobbySearch.NativeFieldInfoPtr_LobbysearchSetlobbyidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchSetlobbyidApiLatest));
      LobbySearch.NativeFieldInfoPtr_LobbysearchSetmaxresultsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchSetmaxresultsApiLatest));
      LobbySearch.NativeFieldInfoPtr_LobbysearchSetparameterApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchSetparameterApiLatest));
      LobbySearch.NativeFieldInfoPtr_LobbysearchSettargetuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, nameof (LobbysearchSettargetuseridApiLatest));
      LobbySearch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670363);
      LobbySearch.NativeMethodInfoPtr_CopySearchResultByIndex_Public_Result_byref_LobbySearchCopySearchResultByIndexOptions_byref_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670365);
      LobbySearch.NativeMethodInfoPtr_Find_Public_Void_byref_LobbySearchFindOptions_Object_LobbySearchOnFindCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670366);
      LobbySearch.NativeMethodInfoPtr_GetSearchResultCount_Public_UInt32_byref_LobbySearchGetSearchResultCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670367);
      LobbySearch.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670368);
      LobbySearch.NativeMethodInfoPtr_RemoveParameter_Public_Result_byref_LobbySearchRemoveParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670369);
      LobbySearch.NativeMethodInfoPtr_SetLobbyId_Public_Result_byref_LobbySearchSetLobbyIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670370);
      LobbySearch.NativeMethodInfoPtr_SetMaxResults_Public_Result_byref_LobbySearchSetMaxResultsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670371);
      LobbySearch.NativeMethodInfoPtr_SetParameter_Public_Result_byref_LobbySearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670372);
      LobbySearch.NativeMethodInfoPtr_SetTargetUserId_Public_Result_byref_LobbySearchSetTargetUserIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670373);
      LobbySearch.NativeMethodInfoPtr_OnFindCallbackInternalImplementation_Internal_Static_Void_byref_LobbySearchFindCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearch>.NativeClassPtr, 100670374);
    }

    public LobbySearch(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int LobbysearchCopysearchresultbyindexApiLatest
    {
      get
      {
        int copysearchresultbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchCopysearchresultbyindexApiLatest, (void*) &copysearchresultbyindexApiLatest);
        return copysearchresultbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchCopysearchresultbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbysearchFindApiLatest
    {
      get
      {
        int lobbysearchFindApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchFindApiLatest, (void*) &lobbysearchFindApiLatest);
        return lobbysearchFindApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchFindApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbysearchGetsearchresultcountApiLatest
    {
      get
      {
        int getsearchresultcountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchGetsearchresultcountApiLatest, (void*) &getsearchresultcountApiLatest);
        return getsearchresultcountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchGetsearchresultcountApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbysearchRemoveparameterApiLatest
    {
      get
      {
        int removeparameterApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchRemoveparameterApiLatest, (void*) &removeparameterApiLatest);
        return removeparameterApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchRemoveparameterApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbysearchSetlobbyidApiLatest
    {
      get
      {
        int setlobbyidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetlobbyidApiLatest, (void*) &setlobbyidApiLatest);
        return setlobbyidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetlobbyidApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbysearchSetmaxresultsApiLatest
    {
      get
      {
        int setmaxresultsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetmaxresultsApiLatest, (void*) &setmaxresultsApiLatest);
        return setmaxresultsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetmaxresultsApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbysearchSetparameterApiLatest
    {
      get
      {
        int setparameterApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetparameterApiLatest, (void*) &setparameterApiLatest);
        return setparameterApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSetparameterApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbysearchSettargetuseridApiLatest
    {
      get
      {
        int settargetuseridApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSettargetuseridApiLatest, (void*) &settargetuseridApiLatest);
        return settargetuseridApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbySearch.NativeFieldInfoPtr_LobbysearchSettargetuseridApiLatest, (void*) &value);
      }
    }
  }
}
