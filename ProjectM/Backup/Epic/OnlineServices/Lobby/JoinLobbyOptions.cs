// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.JoinLobbyOptions
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
  public sealed class JoinLobbyOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LobbyDetailsHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PresenceEnabled_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalRTCOptions_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyDetailsHandle_Public_get_LobbyDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_Nullable_Unboxed_1_LocalRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0;

    public unsafe LobbyDetails LobbyDetailsHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_get_LobbyDetailsHandle_Public_get_LobbyDetails_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions> LocalRTCOptions
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 878128, RefRangeEnd = 878134, XrefRangeStart = 878128, XrefRangeEnd = 878134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_Nullable_Unboxed_1_LocalRTCOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static JoinLobbyOptions()
    {
      Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (JoinLobbyOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr);
      JoinLobbyOptions.NativeFieldInfoPtr__LobbyDetailsHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, "<LobbyDetailsHandle>k__BackingField");
      JoinLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
      JoinLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, "<PresenceEnabled>k__BackingField");
      JoinLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, "<LocalRTCOptions>k__BackingField");
      JoinLobbyOptions.NativeMethodInfoPtr_get_LobbyDetailsHandle_Public_get_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669926);
      JoinLobbyOptions.NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669927);
      JoinLobbyOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669928);
      JoinLobbyOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669929);
      JoinLobbyOptions.NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669930);
      JoinLobbyOptions.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669931);
      JoinLobbyOptions.NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_Nullable_Unboxed_1_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669932);
      JoinLobbyOptions.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669933);
    }

    public JoinLobbyOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public JoinLobbyOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, data));
    }

    public unsafe LobbyDetails _LobbyDetailsHandle_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LobbyDetailsHandle_k__BackingField));
        return pointer == System.IntPtr.Zero ? (LobbyDetails) null : new LobbyDetails(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LobbyDetailsHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProductUserId _LocalUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _PresenceEnabled_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField)) = value;
      }
    }

    public unsafe Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions> _LocalRTCOptions_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
