// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyModification
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  public sealed class LobbyModification : Handle
  {
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationAddattributeApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationAddmemberattributeApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationMaxAttributeLength;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationMaxAttributes;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationRemoveattributeApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationRemovememberattributeApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationSetbucketidApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationSetinvitesallowedApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationSetmaxmembersApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationSetpermissionlevelApiLatest;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Result_byref_LobbyModificationAddAttributeOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddMemberAttribute_Public_Result_byref_LobbyModificationAddMemberAttributeOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Result_byref_LobbyModificationRemoveAttributeOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveMemberAttribute_Public_Result_byref_LobbyModificationRemoveMemberAttributeOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetBucketId_Public_Result_byref_LobbyModificationSetBucketIdOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_byref_LobbyModificationSetInvitesAllowedOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetMaxMembers_Public_Result_byref_LobbyModificationSetMaxMembersOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetPermissionLevel_Public_Result_byref_LobbyModificationSetPermissionLevelOptions_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LobbyModification()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956922, XrefRangeEnd = 956930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result AddAttribute(ref LobbyModificationAddAttributeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_AddAttribute_Public_Result_byref_LobbyModificationAddAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956930, XrefRangeEnd = 956938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result AddMemberAttribute(
      ref LobbyModificationAddMemberAttributeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_AddMemberAttribute_Public_Result_byref_LobbyModificationAddMemberAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956938, XrefRangeEnd = 956939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956939, XrefRangeEnd = 956950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RemoveAttribute(
      ref LobbyModificationRemoveAttributeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_RemoveAttribute_Public_Result_byref_LobbyModificationRemoveAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956950, XrefRangeEnd = 956961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RemoveMemberAttribute(
      ref LobbyModificationRemoveMemberAttributeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_RemoveMemberAttribute_Public_Result_byref_LobbyModificationRemoveMemberAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956961, XrefRangeEnd = 956972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetBucketId(ref LobbyModificationSetBucketIdOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_SetBucketId_Public_Result_byref_LobbyModificationSetBucketIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956972, XrefRangeEnd = 956983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetInvitesAllowed(
      ref LobbyModificationSetInvitesAllowedOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref options;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_byref_LobbyModificationSetInvitesAllowedOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956983, XrefRangeEnd = 956990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetMaxMembers(ref LobbyModificationSetMaxMembersOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref options;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_SetMaxMembers_Public_Result_byref_LobbyModificationSetMaxMembersOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956990, XrefRangeEnd = 956997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetPermissionLevel(
      ref LobbyModificationSetPermissionLevelOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref options;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_SetPermissionLevel_Public_Result_byref_LobbyModificationSetPermissionLevelOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    static LobbyModification()
    {
      Il2CppClassPointerStore<LobbyModification>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LobbyModification));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr);
      LobbyModification.NativeFieldInfoPtr_LobbymodificationAddattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationAddattributeApiLatest));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationAddmemberattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationAddmemberattributeApiLatest));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationMaxAttributeLength));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationMaxAttributes));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationRemoveattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationRemoveattributeApiLatest));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationRemovememberattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationRemovememberattributeApiLatest));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationSetbucketidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationSetbucketidApiLatest));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationSetinvitesallowedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationSetinvitesallowedApiLatest));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationSetmaxmembersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationSetmaxmembersApiLatest));
      LobbyModification.NativeFieldInfoPtr_LobbymodificationSetpermissionlevelApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationSetpermissionlevelApiLatest));
      LobbyModification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670298);
      LobbyModification.NativeMethodInfoPtr_AddAttribute_Public_Result_byref_LobbyModificationAddAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670300);
      LobbyModification.NativeMethodInfoPtr_AddMemberAttribute_Public_Result_byref_LobbyModificationAddMemberAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670301);
      LobbyModification.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670302);
      LobbyModification.NativeMethodInfoPtr_RemoveAttribute_Public_Result_byref_LobbyModificationRemoveAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670303);
      LobbyModification.NativeMethodInfoPtr_RemoveMemberAttribute_Public_Result_byref_LobbyModificationRemoveMemberAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670304);
      LobbyModification.NativeMethodInfoPtr_SetBucketId_Public_Result_byref_LobbyModificationSetBucketIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670305);
      LobbyModification.NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_byref_LobbyModificationSetInvitesAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670306);
      LobbyModification.NativeMethodInfoPtr_SetMaxMembers_Public_Result_byref_LobbyModificationSetMaxMembersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670307);
      LobbyModification.NativeMethodInfoPtr_SetPermissionLevel_Public_Result_byref_LobbyModificationSetPermissionLevelOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100670308);
    }

    public LobbyModification(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int LobbymodificationAddattributeApiLatest
    {
      get
      {
        int addattributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationAddattributeApiLatest, (void*) &addattributeApiLatest);
        return addattributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationAddattributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationAddmemberattributeApiLatest
    {
      get
      {
        int addmemberattributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationAddmemberattributeApiLatest, (void*) &addmemberattributeApiLatest);
        return addmemberattributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationAddmemberattributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationMaxAttributeLength
    {
      get
      {
        int maxAttributeLength;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributeLength, (void*) &maxAttributeLength);
        return maxAttributeLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributeLength, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationMaxAttributes
    {
      get
      {
        int lobbymodificationMaxAttributes;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributes, (void*) &lobbymodificationMaxAttributes);
        return lobbymodificationMaxAttributes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributes, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationRemoveattributeApiLatest
    {
      get
      {
        int removeattributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationRemoveattributeApiLatest, (void*) &removeattributeApiLatest);
        return removeattributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationRemoveattributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationRemovememberattributeApiLatest
    {
      get
      {
        int removememberattributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationRemovememberattributeApiLatest, (void*) &removememberattributeApiLatest);
        return removememberattributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationRemovememberattributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationSetbucketidApiLatest
    {
      get
      {
        int setbucketidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetbucketidApiLatest, (void*) &setbucketidApiLatest);
        return setbucketidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetbucketidApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationSetinvitesallowedApiLatest
    {
      get
      {
        int setinvitesallowedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetinvitesallowedApiLatest, (void*) &setinvitesallowedApiLatest);
        return setinvitesallowedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetinvitesallowedApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationSetmaxmembersApiLatest
    {
      get
      {
        int setmaxmembersApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetmaxmembersApiLatest, (void*) &setmaxmembersApiLatest);
        return setmaxmembersApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetmaxmembersApiLatest, (void*) &value);
      }
    }

    public static unsafe int LobbymodificationSetpermissionlevelApiLatest
    {
      get
      {
        int setpermissionlevelApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetpermissionlevelApiLatest, (void*) &setpermissionlevelApiLatest);
        return setpermissionlevelApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetpermissionlevelApiLatest, (void*) &value);
      }
    }
  }
}
