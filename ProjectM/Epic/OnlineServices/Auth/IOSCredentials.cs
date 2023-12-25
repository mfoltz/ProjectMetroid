// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.IOSCredentials
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth
{
  public sealed class IOSCredentials : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Id_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Token_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Type_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SystemAuthCredentialsOptions_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ExternalType_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Token_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_IOSCredentialsInternal_0;

    public unsafe Epic.OnlineServices.Utf8String Id
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Token
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_get_Token_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_set_Token_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LoginCredentialType Type
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LoginCredentialType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<IOSCredentialsSystemAuthCredentialsOptions> SystemAuthCredentialsOptions
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<IOSCredentialsSystemAuthCredentialsOptions>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ExternalCredentialType ExternalType
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 35564, RefRangeEnd = 35585, XrefRangeStart = 35564, XrefRangeEnd = 35585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ExternalCredentialType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 968765, RefRangeEnd = 968766, XrefRangeStart = 968749, XrefRangeEnd = 968765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref IOSCredentialsInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentials.NativeMethodInfoPtr_Set_Internal_Void_byref_IOSCredentialsInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IOSCredentials()
    {
      Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (IOSCredentials));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr);
      IOSCredentials.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, "<Id>k__BackingField");
      IOSCredentials.NativeFieldInfoPtr__Token_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, "<Token>k__BackingField");
      IOSCredentials.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, "<Type>k__BackingField");
      IOSCredentials.NativeFieldInfoPtr__SystemAuthCredentialsOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, "<SystemAuthCredentialsOptions>k__BackingField");
      IOSCredentials.NativeFieldInfoPtr__ExternalType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, "<ExternalType>k__BackingField");
      IOSCredentials.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673723);
      IOSCredentials.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673724);
      IOSCredentials.NativeMethodInfoPtr_get_Token_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673725);
      IOSCredentials.NativeMethodInfoPtr_set_Token_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673726);
      IOSCredentials.NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673727);
      IOSCredentials.NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673728);
      IOSCredentials.NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673729);
      IOSCredentials.NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673730);
      IOSCredentials.NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673731);
      IOSCredentials.NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673732);
      IOSCredentials.NativeMethodInfoPtr_Set_Internal_Void_byref_IOSCredentialsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, 100673733);
    }

    public IOSCredentials(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public IOSCredentials()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IOSCredentials>.NativeClassPtr, data));
    }

    public unsafe Epic.OnlineServices.Utf8String _Id_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__Id_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _Token_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__Token_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__Token_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LoginCredentialType _Type_k__BackingField
    {
      get
      {
        return *(LoginCredentialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__Type_k__BackingField));
      }
      [param: In] set
      {
        *(LoginCredentialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__Type_k__BackingField)) = value;
      }
    }

    public unsafe Nullable_Unboxed<IOSCredentialsSystemAuthCredentialsOptions> _SystemAuthCredentialsOptions_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<IOSCredentialsSystemAuthCredentialsOptions>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__SystemAuthCredentialsOptions_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__SystemAuthCredentialsOptions_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<IOSCredentialsSystemAuthCredentialsOptions>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ExternalCredentialType _ExternalType_k__BackingField
    {
      get
      {
        return *(ExternalCredentialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__ExternalType_k__BackingField));
      }
      [param: In] set
      {
        *(ExternalCredentialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IOSCredentials.NativeFieldInfoPtr__ExternalType_k__BackingField)) = value;
      }
    }
  }
}
