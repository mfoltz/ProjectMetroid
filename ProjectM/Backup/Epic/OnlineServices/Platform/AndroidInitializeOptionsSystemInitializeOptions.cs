// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.AndroidInitializeOptionsSystemInitializeOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  public sealed class AndroidInitializeOptionsSystemInitializeOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Reserved_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OptionalInternalDirectory_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OptionalExternalDirectory_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OptionalInternalDirectory_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OptionalInternalDirectory_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OptionalExternalDirectory_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OptionalExternalDirectory_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_AndroidInitializeOptionsSystemInitializeOptionsInternal_0;

    public unsafe System.IntPtr Reserved
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OptionalInternalDirectory
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_get_OptionalInternalDirectory_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_set_OptionalInternalDirectory_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OptionalExternalDirectory
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_get_OptionalExternalDirectory_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_set_OptionalExternalDirectory_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971526, RefRangeEnd = 971527, XrefRangeStart = 971516, XrefRangeEnd = 971526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(
      ref AndroidInitializeOptionsSystemInitializeOptionsInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_AndroidInitializeOptionsSystemInitializeOptionsInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AndroidInitializeOptionsSystemInitializeOptions()
    {
      Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (AndroidInitializeOptionsSystemInitializeOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr);
      AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__Reserved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, "<Reserved>k__BackingField");
      AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__OptionalInternalDirectory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, "<OptionalInternalDirectory>k__BackingField");
      AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__OptionalExternalDirectory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, "<OptionalExternalDirectory>k__BackingField");
      AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, 100674557);
      AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, 100674558);
      AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_get_OptionalInternalDirectory_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, 100674559);
      AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_set_OptionalInternalDirectory_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, 100674560);
      AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_get_OptionalExternalDirectory_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, 100674561);
      AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_set_OptionalExternalDirectory_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, 100674562);
      AndroidInitializeOptionsSystemInitializeOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_AndroidInitializeOptionsSystemInitializeOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, 100674563);
    }

    public AndroidInitializeOptionsSystemInitializeOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AndroidInitializeOptionsSystemInitializeOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptions>.NativeClassPtr, data));
    }

    public unsafe System.IntPtr _Reserved_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__Reserved_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__Reserved_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _OptionalInternalDirectory_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__OptionalInternalDirectory_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__OptionalInternalDirectory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _OptionalExternalDirectory_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__OptionalExternalDirectory_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AndroidInitializeOptionsSystemInitializeOptions.NativeFieldInfoPtr__OptionalExternalDirectory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
