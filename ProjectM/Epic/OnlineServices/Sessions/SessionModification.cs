// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionModification
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  public sealed class SessionModification : Handle
  {
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationAddattributeApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationMaxSessionAttributeLength;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationMaxSessionAttributes;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationMaxSessionidoverrideLength;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationMinSessionidoverrideLength;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationRemoveattributeApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetbucketidApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSethostaddressApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetinvitesallowedApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetjoininprogressallowedApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetmaxplayersApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetpermissionlevelApiLatest;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Result_byref_SessionModificationAddAttributeOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Result_byref_SessionModificationRemoveAttributeOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetBucketId_Public_Result_byref_SessionModificationSetBucketIdOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetHostAddress_Public_Result_byref_SessionModificationSetHostAddressOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_byref_SessionModificationSetInvitesAllowedOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetJoinInProgressAllowed_Public_Result_byref_SessionModificationSetJoinInProgressAllowedOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetMaxPlayers_Public_Result_byref_SessionModificationSetMaxPlayersOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetPermissionLevel_Public_Result_byref_SessionModificationSetPermissionLevelOptions_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionModification()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionModification>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 942026, RefRangeEnd = 942029, XrefRangeStart = 942018, XrefRangeEnd = 942026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result AddAttribute(ref SessionModificationAddAttributeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_AddAttribute_Public_Result_byref_SessionModificationAddAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 942030, RefRangeEnd = 942032, XrefRangeStart = 942029, XrefRangeEnd = 942030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942043, RefRangeEnd = 942044, XrefRangeStart = 942032, XrefRangeEnd = 942043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RemoveAttribute(
      ref SessionModificationRemoveAttributeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_RemoveAttribute_Public_Result_byref_SessionModificationRemoveAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942044, XrefRangeEnd = 942055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetBucketId(ref SessionModificationSetBucketIdOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetBucketId_Public_Result_byref_SessionModificationSetBucketIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942066, RefRangeEnd = 942067, XrefRangeStart = 942055, XrefRangeEnd = 942066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetHostAddress(
      ref SessionModificationSetHostAddressOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetHostAddress_Public_Result_byref_SessionModificationSetHostAddressOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942078, RefRangeEnd = 942079, XrefRangeStart = 942067, XrefRangeEnd = 942078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetInvitesAllowed(
      ref SessionModificationSetInvitesAllowedOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref options;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_byref_SessionModificationSetInvitesAllowedOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942090, RefRangeEnd = 942091, XrefRangeStart = 942079, XrefRangeEnd = 942090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetJoinInProgressAllowed(
      ref SessionModificationSetJoinInProgressAllowedOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref options;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetJoinInProgressAllowed_Public_Result_byref_SessionModificationSetJoinInProgressAllowedOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942091, XrefRangeEnd = 942098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetMaxPlayers(
      ref SessionModificationSetMaxPlayersOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref options;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetMaxPlayers_Public_Result_byref_SessionModificationSetMaxPlayersOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942105, RefRangeEnd = 942106, XrefRangeStart = 942098, XrefRangeEnd = 942105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetPermissionLevel(
      ref SessionModificationSetPermissionLevelOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref options;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetPermissionLevel_Public_Result_byref_SessionModificationSetPermissionLevelOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SessionModification()
    {
      Il2CppClassPointerStore<SessionModification>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionModification));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionModification>.NativeClassPtr);
      SessionModification.NativeFieldInfoPtr_SessionmodificationAddattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationAddattributeApiLatest));
      SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationMaxSessionAttributeLength));
      SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationMaxSessionAttributes));
      SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionidoverrideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationMaxSessionidoverrideLength));
      SessionModification.NativeFieldInfoPtr_SessionmodificationMinSessionidoverrideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationMinSessionidoverrideLength));
      SessionModification.NativeFieldInfoPtr_SessionmodificationRemoveattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationRemoveattributeApiLatest));
      SessionModification.NativeFieldInfoPtr_SessionmodificationSetbucketidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetbucketidApiLatest));
      SessionModification.NativeFieldInfoPtr_SessionmodificationSethostaddressApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSethostaddressApiLatest));
      SessionModification.NativeFieldInfoPtr_SessionmodificationSetinvitesallowedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetinvitesallowedApiLatest));
      SessionModification.NativeFieldInfoPtr_SessionmodificationSetjoininprogressallowedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetjoininprogressallowedApiLatest));
      SessionModification.NativeFieldInfoPtr_SessionmodificationSetmaxplayersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetmaxplayersApiLatest));
      SessionModification.NativeFieldInfoPtr_SessionmodificationSetpermissionlevelApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetpermissionlevelApiLatest));
      SessionModification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666463);
      SessionModification.NativeMethodInfoPtr_AddAttribute_Public_Result_byref_SessionModificationAddAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666465);
      SessionModification.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666466);
      SessionModification.NativeMethodInfoPtr_RemoveAttribute_Public_Result_byref_SessionModificationRemoveAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666467);
      SessionModification.NativeMethodInfoPtr_SetBucketId_Public_Result_byref_SessionModificationSetBucketIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666468);
      SessionModification.NativeMethodInfoPtr_SetHostAddress_Public_Result_byref_SessionModificationSetHostAddressOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666469);
      SessionModification.NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_byref_SessionModificationSetInvitesAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666470);
      SessionModification.NativeMethodInfoPtr_SetJoinInProgressAllowed_Public_Result_byref_SessionModificationSetJoinInProgressAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666471);
      SessionModification.NativeMethodInfoPtr_SetMaxPlayers_Public_Result_byref_SessionModificationSetMaxPlayersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666472);
      SessionModification.NativeMethodInfoPtr_SetPermissionLevel_Public_Result_byref_SessionModificationSetPermissionLevelOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100666473);
    }

    public SessionModification(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int SessionmodificationAddattributeApiLatest
    {
      get
      {
        int addattributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationAddattributeApiLatest, (void*) &addattributeApiLatest);
        return addattributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationAddattributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationMaxSessionAttributeLength
    {
      get
      {
        int sessionAttributeLength;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributeLength, (void*) &sessionAttributeLength);
        return sessionAttributeLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributeLength, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationMaxSessionAttributes
    {
      get
      {
        int sessionAttributes;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributes, (void*) &sessionAttributes);
        return sessionAttributes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributes, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationMaxSessionidoverrideLength
    {
      get
      {
        int sessionidoverrideLength;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionidoverrideLength, (void*) &sessionidoverrideLength);
        return sessionidoverrideLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionidoverrideLength, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationMinSessionidoverrideLength
    {
      get
      {
        int sessionidoverrideLength;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMinSessionidoverrideLength, (void*) &sessionidoverrideLength);
        return sessionidoverrideLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMinSessionidoverrideLength, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationRemoveattributeApiLatest
    {
      get
      {
        int removeattributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationRemoveattributeApiLatest, (void*) &removeattributeApiLatest);
        return removeattributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationRemoveattributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationSetbucketidApiLatest
    {
      get
      {
        int setbucketidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetbucketidApiLatest, (void*) &setbucketidApiLatest);
        return setbucketidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetbucketidApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationSethostaddressApiLatest
    {
      get
      {
        int sethostaddressApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSethostaddressApiLatest, (void*) &sethostaddressApiLatest);
        return sethostaddressApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSethostaddressApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationSetinvitesallowedApiLatest
    {
      get
      {
        int setinvitesallowedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetinvitesallowedApiLatest, (void*) &setinvitesallowedApiLatest);
        return setinvitesallowedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetinvitesallowedApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationSetjoininprogressallowedApiLatest
    {
      get
      {
        int setjoininprogressallowedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetjoininprogressallowedApiLatest, (void*) &setjoininprogressallowedApiLatest);
        return setjoininprogressallowedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetjoininprogressallowedApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationSetmaxplayersApiLatest
    {
      get
      {
        int setmaxplayersApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetmaxplayersApiLatest, (void*) &setmaxplayersApiLatest);
        return setmaxplayersApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetmaxplayersApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessionmodificationSetpermissionlevelApiLatest
    {
      get
      {
        int setpermissionlevelApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetpermissionlevelApiLatest, (void*) &setpermissionlevelApiLatest);
        return setpermissionlevelApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetpermissionlevelApiLatest, (void*) &value);
      }
    }
  }
}
