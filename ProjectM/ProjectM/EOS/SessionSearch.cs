// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.SessionSearch
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.Sessions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.EOS
{
  public class SessionSearch : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr__CompleteCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformInterface;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxResults;
    private static readonly System.IntPtr NativeFieldInfoPtr__Status_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__FoundSessions_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_SearchSessionsAsync_Private_Static_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_UInt32_EOSSessionSearchIsAbortedCheck_EOSSessionSearchCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_UInt32_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_SessionSearchStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_SessionSearchStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FoundSessions_Public_get_Il2CppReferenceArray_1_Session_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_FoundSessions_Private_set_Void_Il2CppReferenceArray_1_Session_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAborted_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetResult_Private_Void_SessionSearchStatus_Il2CppReferenceArray_1_Session_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__7_0_Private_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1123721, RefRangeEnd = 1123722, XrefRangeStart = 1123636, XrefRangeEnd = 1123721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SearchSessionsAsync(
      PlatformInterface platformInterface,
      Il2CppReferenceArray<SearchCriteron> searchCriteria,
      uint maxSearchResults,
      SessionSearch.EOSSessionSearchIsAbortedCheck isAbortedCheckCallback,
      SessionSearch.EOSSessionSearchCompleteHandler sessionSearchCompleteCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) searchCriteria);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSearchResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) isAbortedCheckCallback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sessionSearchCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SearchSessionsAsync_Private_Static_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_UInt32_EOSSessionSearchIsAbortedCheck_EOSSessionSearchCompleteHandler_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1123738, RefRangeEnd = 1123741, XrefRangeStart = 1123722, XrefRangeEnd = 1123738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionSearch(
      PlatformInterface platformInterface,
      Il2CppReferenceArray<SearchCriteron> searchCriteria,
      uint maxSearchResults,
      EOSOperationCompleteHandler completeCallback)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) searchCriteria);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSearchResults;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completeCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_UInt32_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe SessionSearchStatus Status
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_get_Status_Public_get_SessionSearchStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SessionSearchStatus*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_set_Status_Private_set_Void_SessionSearchStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Session> FoundSessions
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_get_FoundSessions_Public_get_Il2CppReferenceArray_1_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Session>) null : new Il2CppReferenceArray<Session>(nativeObject);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_set_FoundSessions_Private_set_Void_Il2CppReferenceArray_1_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool Succeeded
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123741, XrefRangeEnd = 1123747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsAborted
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 65067, RefRangeEnd = 65076, XrefRangeStart = 65067, XrefRangeEnd = 65076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_get_IsAborted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123747, XrefRangeEnd = 1123757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Abort()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123757, XrefRangeEnd = 1123774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetResult(SessionSearchStatus status, Il2CppReferenceArray<Session> result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &status;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr_SetResult_Private_Void_SessionSearchStatus_Il2CppReferenceArray_1_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 65067, RefRangeEnd = 65076, XrefRangeStart = 65067, XrefRangeEnd = 65076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool __ctor_b__7_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.NativeMethodInfoPtr___ctor_b__7_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SessionSearch()
    {
      Il2CppClassPointerStore<SessionSearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (SessionSearch));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr);
      SessionSearch.NativeFieldInfoPtr_LogHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (LogHeader));
      SessionSearch.NativeFieldInfoPtr__CompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (_CompleteCallback));
      SessionSearch.NativeFieldInfoPtr__PlatformInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (_PlatformInterface));
      SessionSearch.NativeFieldInfoPtr_MaxResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (MaxResults));
      SessionSearch.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, "<Status>k__BackingField");
      SessionSearch.NativeFieldInfoPtr__FoundSessions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, "<FoundSessions>k__BackingField");
      SessionSearch.NativeMethodInfoPtr_SearchSessionsAsync_Private_Static_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_UInt32_EOSSessionSearchIsAbortedCheck_EOSSessionSearchCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689146);
      SessionSearch.NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_Il2CppReferenceArray_1_SearchCriteron_UInt32_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689147);
      SessionSearch.NativeMethodInfoPtr_get_Status_Public_get_SessionSearchStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689148);
      SessionSearch.NativeMethodInfoPtr_set_Status_Private_set_Void_SessionSearchStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689149);
      SessionSearch.NativeMethodInfoPtr_get_FoundSessions_Public_get_Il2CppReferenceArray_1_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689150);
      SessionSearch.NativeMethodInfoPtr_set_FoundSessions_Private_set_Void_Il2CppReferenceArray_1_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689151);
      SessionSearch.NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689152);
      SessionSearch.NativeMethodInfoPtr_get_IsAborted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689153);
      SessionSearch.NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689154);
      SessionSearch.NativeMethodInfoPtr_SetResult_Private_Void_SessionSearchStatus_Il2CppReferenceArray_1_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689155);
      SessionSearch.NativeMethodInfoPtr___ctor_b__7_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, 100689156);
    }

    public SessionSearch(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string LogHeader
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_LogHeader, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_LogHeader, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe EOSOperationCompleteHandler _CompleteCallback
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.NativeFieldInfoPtr__CompleteCallback));
        return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.NativeFieldInfoPtr__CompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlatformInterface _PlatformInterface
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.NativeFieldInfoPtr__PlatformInterface));
        return pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.NativeFieldInfoPtr__PlatformInterface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe uint MaxResults
    {
      get
      {
        uint maxResults;
        IL2CPP.il2cpp_field_static_get_value(SessionSearch.NativeFieldInfoPtr_MaxResults, (void*) &maxResults);
        return maxResults;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionSearch.NativeFieldInfoPtr_MaxResults, (void*) &value);
      }
    }

    public unsafe SessionSearchStatus _Status_k__BackingField
    {
      get
      {
        return *(SessionSearchStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.NativeFieldInfoPtr__Status_k__BackingField));
      }
      [param: In] set
      {
        *(SessionSearchStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.NativeFieldInfoPtr__Status_k__BackingField)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<Session> _FoundSessions_k__BackingField
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.NativeFieldInfoPtr__FoundSessions_k__BackingField));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Session>) null : new Il2CppReferenceArray<Session>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.NativeFieldInfoPtr__FoundSessions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class EOSSessionSearchIsAbortedCheck : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EOSSessionSearchIsAbortedCheck(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchIsAbortedCheck>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearch.EOSSessionSearchIsAbortedCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 248566, RefRangeEnd = 248569, XrefRangeStart = 248566, XrefRangeEnd = 248569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Invoke()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.EOSSessionSearchIsAbortedCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.EOSSessionSearchIsAbortedCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.EOSSessionSearchIsAbortedCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static EOSSessionSearchIsAbortedCheck()
      {
        Il2CppClassPointerStore<SessionSearch.EOSSessionSearchIsAbortedCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (EOSSessionSearchIsAbortedCheck));
        SessionSearch.EOSSessionSearchIsAbortedCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchIsAbortedCheck>.NativeClassPtr, 100689157);
        SessionSearch.EOSSessionSearchIsAbortedCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchIsAbortedCheck>.NativeClassPtr, 100689158);
        SessionSearch.EOSSessionSearchIsAbortedCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchIsAbortedCheck>.NativeClassPtr, 100689159);
        SessionSearch.EOSSessionSearchIsAbortedCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchIsAbortedCheck>.NativeClassPtr, 100689160);
      }

      public EOSSessionSearchIsAbortedCheck(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator SessionSearch.EOSSessionSearchIsAbortedCheck([In] System.Func<bool> obj0)
      {
        return DelegateSupport.ConvertDelegate<SessionSearch.EOSSessionSearchIsAbortedCheck>((System.Delegate) obj0);
      }

      public static SessionSearch.EOSSessionSearchIsAbortedCheck operator +(
        [In] SessionSearch.EOSSessionSearchIsAbortedCheck obj0,
        [In] SessionSearch.EOSSessionSearchIsAbortedCheck obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<SessionSearch.EOSSessionSearchIsAbortedCheck>();
      }

      public static SessionSearch.EOSSessionSearchIsAbortedCheck operator -(
        [In] SessionSearch.EOSSessionSearchIsAbortedCheck obj0,
        [In] SessionSearch.EOSSessionSearchIsAbortedCheck obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (SessionSearch.EOSSessionSearchIsAbortedCheck) @delegate : @delegate.Cast<SessionSearch.EOSSessionSearchIsAbortedCheck>();
      }
    }

    public sealed class EOSSessionSearchCompleteHandler : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SessionSearchStatus_Il2CppReferenceArray_1_Session_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SessionSearchStatus_Il2CppReferenceArray_1_Session_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe EOSSessionSearchCompleteHandler(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchCompleteHandler>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearch.EOSSessionSearchCompleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 885694, RefRangeEnd = 885701, XrefRangeStart = 885694, XrefRangeEnd = 885701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        SessionSearchStatus status,
        Il2CppReferenceArray<Session> result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &status;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearch.EOSSessionSearchCompleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SessionSearchStatus_Il2CppReferenceArray_1_Session_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123591, XrefRangeEnd = 1123595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        SessionSearchStatus status,
        Il2CppReferenceArray<Session> result,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &status;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionSearch.EOSSessionSearchCompleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SessionSearchStatus_Il2CppReferenceArray_1_Session_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearch.EOSSessionSearchCompleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static EOSSessionSearchCompleteHandler()
      {
        Il2CppClassPointerStore<SessionSearch.EOSSessionSearchCompleteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, nameof (EOSSessionSearchCompleteHandler));
        SessionSearch.EOSSessionSearchCompleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchCompleteHandler>.NativeClassPtr, 100689161);
        SessionSearch.EOSSessionSearchCompleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SessionSearchStatus_Il2CppReferenceArray_1_Session_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchCompleteHandler>.NativeClassPtr, 100689162);
        SessionSearch.EOSSessionSearchCompleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SessionSearchStatus_Il2CppReferenceArray_1_Session_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchCompleteHandler>.NativeClassPtr, 100689163);
        SessionSearch.EOSSessionSearchCompleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.EOSSessionSearchCompleteHandler>.NativeClassPtr, 100689164);
      }

      public EOSSessionSearchCompleteHandler(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator SessionSearch.EOSSessionSearchCompleteHandler(
        [In] System.Action<SessionSearchStatus, Il2CppReferenceArray<Session>> obj0)
      {
        return DelegateSupport.ConvertDelegate<SessionSearch.EOSSessionSearchCompleteHandler>((System.Delegate) obj0);
      }

      public static SessionSearch.EOSSessionSearchCompleteHandler operator +(
        [In] SessionSearch.EOSSessionSearchCompleteHandler obj0,
        [In] SessionSearch.EOSSessionSearchCompleteHandler obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<SessionSearch.EOSSessionSearchCompleteHandler>();
      }

      public static SessionSearch.EOSSessionSearchCompleteHandler operator -(
        [In] SessionSearch.EOSSessionSearchCompleteHandler obj0,
        [In] SessionSearch.EOSSessionSearchCompleteHandler obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (SessionSearch.EOSSessionSearchCompleteHandler) @delegate : @delegate.Cast<SessionSearch.EOSSessionSearchCompleteHandler>();
      }
    }

    [ObfuscatedName("ProjectM.EOS.SessionSearch/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionSearch;
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionSearchCompleteCallback;
      private static readonly System.IntPtr NativeFieldInfoPtr_isAbortedCheckCallback;
      private static readonly System.IntPtr NativeFieldInfoPtr_result;
      private static readonly System.IntPtr NativeFieldInfoPtr_platformInterface;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_SessionSearchFindCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearch.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123595, XrefRangeEnd = 1123636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_SessionSearchFindCallbackInfo_PDM_0(
        ref SessionSearchFindCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearch.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_Void_byref_SessionSearchFindCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionSearch>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr);
        SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_sessionSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr, nameof (sessionSearch));
        SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_sessionSearchCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr, nameof (sessionSearchCompleteCallback));
        SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_isAbortedCheckCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr, nameof (isAbortedCheckCallback));
        SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr, nameof (result));
        SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_platformInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr, nameof (platformInterface));
        SessionSearch.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr, 100689165);
        SessionSearch.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_Void_byref_SessionSearchFindCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearch.__c__DisplayClass2_0>.NativeClassPtr, 100689166);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Epic.OnlineServices.Sessions.SessionSearch sessionSearch
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_sessionSearch));
          return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Sessions.SessionSearch) null : new Epic.OnlineServices.Sessions.SessionSearch(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_sessionSearch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SessionSearch.EOSSessionSearchCompleteHandler sessionSearchCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_sessionSearchCompleteCallback));
          return pointer == System.IntPtr.Zero ? (SessionSearch.EOSSessionSearchCompleteHandler) null : new SessionSearch.EOSSessionSearchCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_sessionSearchCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SessionSearch.EOSSessionSearchIsAbortedCheck isAbortedCheckCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_isAbortedCheckCallback));
          return pointer == System.IntPtr.Zero ? (SessionSearch.EOSSessionSearchIsAbortedCheck) null : new SessionSearch.EOSSessionSearchIsAbortedCheck(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_isAbortedCheckCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Result result
      {
        get
        {
          return *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_result));
        }
        [param: In] set
        {
          *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_result)) = value;
        }
      }

      public unsafe PlatformInterface platformInterface
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_platformInterface));
          return pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionSearch.__c__DisplayClass2_0.NativeFieldInfoPtr_platformInterface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
