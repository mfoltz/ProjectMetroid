// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.SessionSearchPaginated
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.Platform;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.EOS
{
  public class SessionSearchPaginated : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_sessionsPerPage;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewResultsCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformInterface;
    private static readonly System.IntPtr NativeFieldInfoPtr__SearchHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__BaseSearchCriteria;
    private static readonly System.IntPtr NativeFieldInfoPtr__PriorityCriteria;
    private static readonly System.IntPtr NativeFieldInfoPtr__CriteriaForNextSearch;
    private static readonly System.IntPtr NativeFieldInfoPtr_sessionUniqueCheck;
    private static readonly System.IntPtr NativeFieldInfoPtr__Status_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__FoundSessions_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLowToHigh_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_EOSSessionSearchPaginatedResultsUpdatedHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_SessionSearchStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_SessionSearchStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FoundSessions_Public_get_List_1_Session_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_FoundSessions_Private_set_Void_List_1_Session_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsReadyToGetNextPage_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNextPage_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnNewSearchResultsAvailable_Private_Void_Boolean_0;

    public unsafe bool IsLowToHigh
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1123835, RefRangeEnd = 1123837, XrefRangeStart = 1123830, XrefRangeEnd = 1123835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_get_IsLowToHigh_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1123869, RefRangeEnd = 1123870, XrefRangeStart = 1123837, XrefRangeEnd = 1123869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionSearchPaginated(
      PlatformInterface platformInterface,
      Il2CppReferenceArray<SearchCriteron> searchCriteria,
      EOSSessionSearchPaginatedResultsUpdatedHandler resultsUpdatedCallback)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) searchCriteria);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultsUpdatedCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_EOSSessionSearchPaginatedResultsUpdatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe SessionSearchStatus Status
    {
      [CallerCount(15), CachedScanResults(RefRangeStart = 93740, RefRangeEnd = 93755, XrefRangeStart = 93740, XrefRangeEnd = 93755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_get_Status_Public_get_SessionSearchStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SessionSearchStatus*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_set_Status_Private_set_Void_SessionSearchStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe List<Session> FoundSessions
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 72810, RefRangeEnd = 72822, XrefRangeStart = 72810, XrefRangeEnd = 72822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_get_FoundSessions_Public_get_List_1_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<Session>) null : new List<Session>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_set_FoundSessions_Private_set_Void_List_1_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1123870, RefRangeEnd = 1123871, XrefRangeStart = 1123870, XrefRangeEnd = 1123870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsReadyToGetNextPage()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_IsReadyToGetNextPage_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1123891, RefRangeEnd = 1123892, XrefRangeStart = 1123871, XrefRangeEnd = 1123891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetNextPage()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_GetNextPage_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1123916, RefRangeEnd = 1123921, XrefRangeStart = 1123892, XrefRangeEnd = 1123916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Abort()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123921, XrefRangeEnd = 1124023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnNewSearchResultsAvailable(bool success)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &success;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchPaginated.NativeMethodInfoPtr_OnNewSearchResultsAvailable_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SessionSearchPaginated()
    {
      Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (SessionSearchPaginated));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr);
      SessionSearchPaginated.NativeFieldInfoPtr_LogHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (LogHeader));
      SessionSearchPaginated.NativeFieldInfoPtr_sessionsPerPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (sessionsPerPage));
      SessionSearchPaginated.NativeFieldInfoPtr__NewResultsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (_NewResultsCallback));
      SessionSearchPaginated.NativeFieldInfoPtr__PlatformInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (_PlatformInterface));
      SessionSearchPaginated.NativeFieldInfoPtr__SearchHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (_SearchHandle));
      SessionSearchPaginated.NativeFieldInfoPtr__BaseSearchCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (_BaseSearchCriteria));
      SessionSearchPaginated.NativeFieldInfoPtr__PriorityCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (_PriorityCriteria));
      SessionSearchPaginated.NativeFieldInfoPtr__CriteriaForNextSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (_CriteriaForNextSearch));
      SessionSearchPaginated.NativeFieldInfoPtr_sessionUniqueCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, nameof (sessionUniqueCheck));
      SessionSearchPaginated.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, "<Status>k__BackingField");
      SessionSearchPaginated.NativeFieldInfoPtr__FoundSessions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, "<FoundSessions>k__BackingField");
      SessionSearchPaginated.NativeMethodInfoPtr_get_IsLowToHigh_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689174);
      SessionSearchPaginated.NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_EOSSessionSearchPaginatedResultsUpdatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689175);
      SessionSearchPaginated.NativeMethodInfoPtr_get_Status_Public_get_SessionSearchStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689176);
      SessionSearchPaginated.NativeMethodInfoPtr_set_Status_Private_set_Void_SessionSearchStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689177);
      SessionSearchPaginated.NativeMethodInfoPtr_get_FoundSessions_Public_get_List_1_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689178);
      SessionSearchPaginated.NativeMethodInfoPtr_set_FoundSessions_Private_set_Void_List_1_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689179);
      SessionSearchPaginated.NativeMethodInfoPtr_IsReadyToGetNextPage_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689180);
      SessionSearchPaginated.NativeMethodInfoPtr_GetNextPage_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689181);
      SessionSearchPaginated.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689182);
      SessionSearchPaginated.NativeMethodInfoPtr_OnNewSearchResultsAvailable_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchPaginated>.NativeClassPtr, 100689183);
    }

    public SessionSearchPaginated(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string LogHeader
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SessionSearchPaginated.NativeFieldInfoPtr_LogHeader, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearchPaginated.NativeFieldInfoPtr_LogHeader, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe uint sessionsPerPage
    {
      get
      {
        uint sessionsPerPage;
        IL2CPP.il2cpp_field_static_get_value(SessionSearchPaginated.NativeFieldInfoPtr_sessionsPerPage, (void*) &sessionsPerPage);
        return sessionsPerPage;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearchPaginated.NativeFieldInfoPtr_sessionsPerPage, (void*) &value);
      }
    }

    public unsafe EOSSessionSearchPaginatedResultsUpdatedHandler _NewResultsCallback
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__NewResultsCallback));
        return pointer == System.IntPtr.Zero ? (EOSSessionSearchPaginatedResultsUpdatedHandler) null : new EOSSessionSearchPaginatedResultsUpdatedHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__NewResultsCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlatformInterface _PlatformInterface
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__PlatformInterface));
        return pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__PlatformInterface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SessionSearch _SearchHandle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__SearchHandle));
        return pointer == System.IntPtr.Zero ? (SessionSearch) null : new SessionSearch(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__SearchHandle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<SearchCriteron> _BaseSearchCriteria
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__BaseSearchCriteria));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SearchCriteron>) null : new Il2CppReferenceArray<SearchCriteron>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__BaseSearchCriteria), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public SearchCriteron _PriorityCriteria
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__PriorityCriteria);
        return new SearchCriteron(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__PriorityCriteria), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Il2CppReferenceArray<SearchCriteron> _CriteriaForNextSearch
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__CriteriaForNextSearch));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SearchCriteron>) null : new Il2CppReferenceArray<SearchCriteron>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__CriteriaForNextSearch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<string> sessionUniqueCheck
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr_sessionUniqueCheck));
        return pointer == System.IntPtr.Zero ? (HashSet<string>) null : new HashSet<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr_sessionUniqueCheck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SessionSearchStatus _Status_k__BackingField
    {
      get
      {
        return *(SessionSearchStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__Status_k__BackingField));
      }
      [param: In] set
      {
        *(SessionSearchStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__Status_k__BackingField)) = value;
      }
    }

    public unsafe List<Session> _FoundSessions_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__FoundSessions_k__BackingField));
        return pointer == System.IntPtr.Zero ? (List<Session>) null : new List<Session>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearchPaginated.NativeFieldInfoPtr__FoundSessions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
