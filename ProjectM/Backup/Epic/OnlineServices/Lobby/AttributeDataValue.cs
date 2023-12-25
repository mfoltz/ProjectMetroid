// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.AttributeDataValue
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
  public sealed class AttributeDataValue : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AsInt64;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AsDouble;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AsBool;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AsUtf8;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ValueType;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_Unboxed_1_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_Unboxed_1_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_Unboxed_1_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_Unboxed_1_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_Unboxed_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_Unboxed_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AsUtf8_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ValueType_Public_get_AttributeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ValueType_Private_set_Void_AttributeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_AttributeDataValueInternal_0;

    public unsafe Nullable_Unboxed<long> AsInt64
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953865, XrefRangeEnd = 953871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_Unboxed_1_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<long>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953871, XrefRangeEnd = 953877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_Unboxed_1_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<double> AsDouble
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953877, XrefRangeEnd = 953883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_Unboxed_1_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<double>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953883, XrefRangeEnd = 953889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_Unboxed_1_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<bool> AsBool
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 953895, RefRangeEnd = 953896, XrefRangeStart = 953889, XrefRangeEnd = 953895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_Unboxed_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<bool>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 953902, RefRangeEnd = 953904, XrefRangeStart = 953896, XrefRangeEnd = 953902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_Unboxed_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String AsUtf8
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 953910, RefRangeEnd = 953911, XrefRangeStart = 953904, XrefRangeEnd = 953910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_AsUtf8_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 953917, RefRangeEnd = 953920, XrefRangeStart = 953911, XrefRangeEnd = 953917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AttributeType ValueType
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 32697, RefRangeEnd = 32698, XrefRangeStart = 32697, XrefRangeEnd = 32698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_ValueType_Public_get_AttributeType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AttributeType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 42947, RefRangeEnd = 42948, XrefRangeStart = 42947, XrefRangeEnd = 42948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_ValueType_Private_set_Void_AttributeType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953920, XrefRangeEnd = 953929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator AttributeDataValue(long value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new AttributeDataValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953929, XrefRangeEnd = 953938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator AttributeDataValue(double value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new AttributeDataValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953938, XrefRangeEnd = 953942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator AttributeDataValue(bool value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new AttributeDataValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953942, XrefRangeEnd = 953943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator AttributeDataValue(Epic.OnlineServices.Utf8String value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new AttributeDataValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953943, XrefRangeEnd = 953945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator AttributeDataValue(string value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new AttributeDataValue(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 953973, RefRangeEnd = 953974, XrefRangeStart = 953945, XrefRangeEnd = 953973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref AttributeDataValueInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_Set_Internal_Void_byref_AttributeDataValueInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AttributeDataValue()
    {
      Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (AttributeDataValue));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr);
      AttributeDataValue.NativeFieldInfoPtr_m_AsInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_AsInt64));
      AttributeDataValue.NativeFieldInfoPtr_m_AsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_AsDouble));
      AttributeDataValue.NativeFieldInfoPtr_m_AsBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_AsBool));
      AttributeDataValue.NativeFieldInfoPtr_m_AsUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_AsUtf8));
      AttributeDataValue.NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_ValueType));
      AttributeDataValue.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669642);
      AttributeDataValue.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669643);
      AttributeDataValue.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_Unboxed_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669644);
      AttributeDataValue.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_Unboxed_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669645);
      AttributeDataValue.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669646);
      AttributeDataValue.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669647);
      AttributeDataValue.NativeMethodInfoPtr_get_AsUtf8_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669648);
      AttributeDataValue.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669649);
      AttributeDataValue.NativeMethodInfoPtr_get_ValueType_Public_get_AttributeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669650);
      AttributeDataValue.NativeMethodInfoPtr_set_ValueType_Private_set_Void_AttributeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669651);
      AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669652);
      AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669653);
      AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669654);
      AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669655);
      AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669656);
      AttributeDataValue.NativeMethodInfoPtr_Set_Internal_Void_byref_AttributeDataValueInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100669657);
    }

    public AttributeDataValue(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AttributeDataValue()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, data));
    }

    public unsafe Nullable_Unboxed<long> m_AsInt64
    {
      get
      {
        return *(Nullable_Unboxed<long>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsInt64));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsInt64), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<long>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<double> m_AsDouble
    {
      get
      {
        return *(Nullable_Unboxed<double>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsDouble));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsDouble), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<double>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<bool> m_AsBool
    {
      get
      {
        return *(Nullable_Unboxed<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsBool));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsBool), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String m_AsUtf8
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsUtf8));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsUtf8), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AttributeType m_ValueType
    {
      get
      {
        return *(AttributeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_ValueType));
      }
      [param: In] set
      {
        *(AttributeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_ValueType)) = value;
      }
    }
  }
}
