// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.CreateLobbyOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  public sealed class CreateLobbyOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxLobbyMembers_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PermissionLevel_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PresenceEnabled_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllowInvites_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__BucketId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisableHostMigration_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnableRTCRoom_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalRTCOptions_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LobbyId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__EnableJoinById_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__RejoinAfterKickRequiresInvite_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxLobbyMembers_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BucketId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_BucketId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisableHostMigration_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableRTCRoom_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_Nullable_Unboxed_1_LocalRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableJoinById_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableJoinById_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RejoinAfterKickRequiresInvite_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RejoinAfterKickRequiresInvite_Public_set_Void_Boolean_0;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint MaxLobbyMembers
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_MaxLobbyMembers_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LobbyPermissionLevel PermissionLevel
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LobbyPermissionLevel*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 204792, RefRangeEnd = 204801, XrefRangeStart = 204792, XrefRangeEnd = 204801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool PresenceEnabled
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool AllowInvites
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String BucketId
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_BucketId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_BucketId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool DisableHostMigration
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_DisableHostMigration_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool EnableRTCRoom
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_EnableRTCRoom_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions> LocalRTCOptions
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_Nullable_Unboxed_1_LocalRTCOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LobbyId
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_LobbyId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool EnableJoinById
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_EnableJoinById_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_EnableJoinById_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool RejoinAfterKickRequiresInvite
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_get_RejoinAfterKickRequiresInvite_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateLobbyOptions.NativeMethodInfoPtr_set_RejoinAfterKickRequiresInvite_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static CreateLobbyOptions()
    {
      Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (CreateLobbyOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr);
      CreateLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__MaxLobbyMembers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<MaxLobbyMembers>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__PermissionLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<PermissionLevel>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<PresenceEnabled>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__AllowInvites_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<AllowInvites>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__BucketId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<BucketId>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__DisableHostMigration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<DisableHostMigration>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__EnableRTCRoom_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<EnableRTCRoom>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<LocalRTCOptions>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__LobbyId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<LobbyId>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__EnableJoinById_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<EnableJoinById>k__BackingField");
      CreateLobbyOptions.NativeFieldInfoPtr__RejoinAfterKickRequiresInvite_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, "<RejoinAfterKickRequiresInvite>k__BackingField");
      CreateLobbyOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669710);
      CreateLobbyOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669711);
      CreateLobbyOptions.NativeMethodInfoPtr_get_MaxLobbyMembers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669712);
      CreateLobbyOptions.NativeMethodInfoPtr_set_MaxLobbyMembers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669713);
      CreateLobbyOptions.NativeMethodInfoPtr_get_PermissionLevel_Public_get_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669714);
      CreateLobbyOptions.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_LobbyPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669715);
      CreateLobbyOptions.NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669716);
      CreateLobbyOptions.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669717);
      CreateLobbyOptions.NativeMethodInfoPtr_get_AllowInvites_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669718);
      CreateLobbyOptions.NativeMethodInfoPtr_set_AllowInvites_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669719);
      CreateLobbyOptions.NativeMethodInfoPtr_get_BucketId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669720);
      CreateLobbyOptions.NativeMethodInfoPtr_set_BucketId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669721);
      CreateLobbyOptions.NativeMethodInfoPtr_get_DisableHostMigration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669722);
      CreateLobbyOptions.NativeMethodInfoPtr_set_DisableHostMigration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669723);
      CreateLobbyOptions.NativeMethodInfoPtr_get_EnableRTCRoom_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669724);
      CreateLobbyOptions.NativeMethodInfoPtr_set_EnableRTCRoom_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669725);
      CreateLobbyOptions.NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_Nullable_Unboxed_1_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669726);
      CreateLobbyOptions.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669727);
      CreateLobbyOptions.NativeMethodInfoPtr_get_LobbyId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669728);
      CreateLobbyOptions.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669729);
      CreateLobbyOptions.NativeMethodInfoPtr_get_EnableJoinById_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669730);
      CreateLobbyOptions.NativeMethodInfoPtr_set_EnableJoinById_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669731);
      CreateLobbyOptions.NativeMethodInfoPtr_get_RejoinAfterKickRequiresInvite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669732);
      CreateLobbyOptions.NativeMethodInfoPtr_set_RejoinAfterKickRequiresInvite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, 100669733);
    }

    public CreateLobbyOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CreateLobbyOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateLobbyOptions>.NativeClassPtr, data));
    }

    public unsafe ProductUserId _LocalUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe uint _MaxLobbyMembers_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__MaxLobbyMembers_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__MaxLobbyMembers_k__BackingField)) = value;
      }
    }

    public unsafe LobbyPermissionLevel _PermissionLevel_k__BackingField
    {
      get
      {
        return *(LobbyPermissionLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__PermissionLevel_k__BackingField));
      }
      [param: In] set
      {
        *(LobbyPermissionLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__PermissionLevel_k__BackingField)) = value;
      }
    }

    public unsafe bool _PresenceEnabled_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField)) = value;
      }
    }

    public unsafe bool _AllowInvites_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__AllowInvites_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__AllowInvites_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _BucketId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__BucketId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__BucketId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _DisableHostMigration_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__DisableHostMigration_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__DisableHostMigration_k__BackingField)) = value;
      }
    }

    public unsafe bool _EnableRTCRoom_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__EnableRTCRoom_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__EnableRTCRoom_k__BackingField)) = value;
      }
    }

    public unsafe Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions> _LocalRTCOptions_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _LobbyId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LobbyId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__LobbyId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _EnableJoinById_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__EnableJoinById_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__EnableJoinById_k__BackingField)) = value;
      }
    }

    public unsafe bool _RejoinAfterKickRequiresInvite_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__RejoinAfterKickRequiresInvite_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateLobbyOptions.NativeFieldInfoPtr__RejoinAfterKickRequiresInvite_k__BackingField)) = value;
      }
    }
  }
}
