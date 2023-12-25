// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.AttributeDataValueInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct AttributeDataValueInternal
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
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0;
    [FieldOffset(0)]
    public long m_AsInt64;
    [FieldOffset(0)]
    public double m_AsDouble;
    [FieldOffset(0)]
    public int m_AsBool;
    [FieldOffset(0)]
    public System.IntPtr m_AsUtf8;
    [FieldOffset(8)]
    public AttributeType m_ValueType;

    public unsafe Nullable_Unboxed<long> AsInt64
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953974, XrefRangeEnd = 953980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_Unboxed_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<long>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 953989, RefRangeEnd = 953991, XrefRangeStart = 953980, XrefRangeEnd = 953989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_Unboxed_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<double> AsDouble
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953991, XrefRangeEnd = 953997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_Unboxed_1_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<double>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 954006, RefRangeEnd = 954008, XrefRangeStart = 953997, XrefRangeEnd = 954006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_Unboxed_1_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<bool> AsBool
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 954014, RefRangeEnd = 954015, XrefRangeStart = 954008, XrefRangeEnd = 954014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_Unboxed_1_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<bool>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 954024, RefRangeEnd = 954026, XrefRangeStart = 954015, XrefRangeEnd = 954024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_Unboxed_1_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String AsUtf8
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 954032, RefRangeEnd = 954033, XrefRangeStart = 954026, XrefRangeEnd = 954032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsUtf8_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 954042, RefRangeEnd = 954044, XrefRangeStart = 954033, XrefRangeEnd = 954042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 954062, RefRangeEnd = 954063, XrefRangeStart = 954044, XrefRangeEnd = 954062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AttributeDataValue other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954063, XrefRangeEnd = 954101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<AttributeDataValue> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954101, XrefRangeEnd = 954107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 954108, RefRangeEnd = 954109, XrefRangeStart = 954107, XrefRangeEnd = 954108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out AttributeDataValue output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AttributeDataValue local = ref output;
      System.IntPtr pointer = zero;
      AttributeDataValue attributeDataValue = pointer == System.IntPtr.Zero ? (AttributeDataValue) null : new AttributeDataValue(pointer);
      local = attributeDataValue;
    }

    static AttributeDataValueInternal()
    {
      Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (AttributeDataValueInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr);
      AttributeDataValueInternal.NativeFieldInfoPtr_m_AsInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsInt64));
      AttributeDataValueInternal.NativeFieldInfoPtr_m_AsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsDouble));
      AttributeDataValueInternal.NativeFieldInfoPtr_m_AsBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsBool));
      AttributeDataValueInternal.NativeFieldInfoPtr_m_AsUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsUtf8));
      AttributeDataValueInternal.NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_ValueType));
      AttributeDataValueInternal.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669658);
      AttributeDataValueInternal.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669659);
      AttributeDataValueInternal.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_Unboxed_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669660);
      AttributeDataValueInternal.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_Unboxed_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669661);
      AttributeDataValueInternal.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669662);
      AttributeDataValueInternal.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669663);
      AttributeDataValueInternal.NativeMethodInfoPtr_get_AsUtf8_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669664);
      AttributeDataValueInternal.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669665);
      AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669666);
      AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669667);
      AttributeDataValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669668);
      AttributeDataValueInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100669669);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
