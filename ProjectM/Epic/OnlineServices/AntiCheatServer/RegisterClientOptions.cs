// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.RegisterClientOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.AntiCheatCommon;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer
{
  public sealed class RegisterClientOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientType_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientPlatform_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AccountId_DEPRECATED_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IpAddress_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserId_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientType_Public_get_AntiCheatCommonClientType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientPlatform_Public_get_AntiCheatCommonClientPlatform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_DEPRECATED_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_DEPRECATED_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IpAddress_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IpAddress_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0;

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientType ClientType
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_get_ClientType_Public_get_AntiCheatCommonClientType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonClientType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientPlatform ClientPlatform
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_get_ClientPlatform_Public_get_AntiCheatCommonClientPlatform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonClientPlatform*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 204792, RefRangeEnd = 204801, XrefRangeStart = 204792, XrefRangeEnd = 204801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String AccountId_DEPRECATED
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_get_AccountId_DEPRECATED_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_set_AccountId_DEPRECATED_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String IpAddress
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_get_IpAddress_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId UserId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(RegisterClientOptions.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static RegisterClientOptions()
    {
      Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatServer", nameof (RegisterClientOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr);
      RegisterClientOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, "<ClientHandle>k__BackingField");
      RegisterClientOptions.NativeFieldInfoPtr__ClientType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, "<ClientType>k__BackingField");
      RegisterClientOptions.NativeFieldInfoPtr__ClientPlatform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, "<ClientPlatform>k__BackingField");
      RegisterClientOptions.NativeFieldInfoPtr__AccountId_DEPRECATED_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, "<AccountId_DEPRECATED>k__BackingField");
      RegisterClientOptions.NativeFieldInfoPtr__IpAddress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, "<IpAddress>k__BackingField");
      RegisterClientOptions.NativeFieldInfoPtr__UserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, "<UserId>k__BackingField");
      RegisterClientOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673877);
      RegisterClientOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673878);
      RegisterClientOptions.NativeMethodInfoPtr_get_ClientType_Public_get_AntiCheatCommonClientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673879);
      RegisterClientOptions.NativeMethodInfoPtr_set_ClientType_Public_set_Void_AntiCheatCommonClientType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673880);
      RegisterClientOptions.NativeMethodInfoPtr_get_ClientPlatform_Public_get_AntiCheatCommonClientPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673881);
      RegisterClientOptions.NativeMethodInfoPtr_set_ClientPlatform_Public_set_Void_AntiCheatCommonClientPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673882);
      RegisterClientOptions.NativeMethodInfoPtr_get_AccountId_DEPRECATED_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673883);
      RegisterClientOptions.NativeMethodInfoPtr_set_AccountId_DEPRECATED_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673884);
      RegisterClientOptions.NativeMethodInfoPtr_get_IpAddress_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673885);
      RegisterClientOptions.NativeMethodInfoPtr_set_IpAddress_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673886);
      RegisterClientOptions.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673887);
      RegisterClientOptions.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, 100673888);
    }

    public RegisterClientOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public RegisterClientOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterClientOptions>.NativeClassPtr, data));
    }

    public unsafe System.IntPtr _ClientHandle_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField)) = value;
      }
    }

    public unsafe AntiCheatCommonClientType _ClientType_k__BackingField
    {
      get
      {
        return *(AntiCheatCommonClientType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__ClientType_k__BackingField));
      }
      [param: In] set
      {
        *(AntiCheatCommonClientType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__ClientType_k__BackingField)) = value;
      }
    }

    public unsafe AntiCheatCommonClientPlatform _ClientPlatform_k__BackingField
    {
      get
      {
        return *(AntiCheatCommonClientPlatform*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__ClientPlatform_k__BackingField));
      }
      [param: In] set
      {
        *(AntiCheatCommonClientPlatform*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__ClientPlatform_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _AccountId_DEPRECATED_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__AccountId_DEPRECATED_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__AccountId_DEPRECATED_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _IpAddress_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__IpAddress_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__IpAddress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProductUserId _UserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__UserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterClientOptions.NativeFieldInfoPtr__UserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
