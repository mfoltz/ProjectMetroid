// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.AttributeDataValueInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
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
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940336, XrefRangeEnd = 940342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_Unboxed_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<long>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 940351, RefRangeEnd = 940353, XrefRangeStart = 940342, XrefRangeEnd = 940351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940353, XrefRangeEnd = 940359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_Unboxed_1_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<double>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 940368, RefRangeEnd = 940370, XrefRangeStart = 940359, XrefRangeEnd = 940368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
      [CallerCount(1), CachedScanResults(RefRangeStart = 940376, RefRangeEnd = 940377, XrefRangeStart = 940370, XrefRangeEnd = 940376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_Unboxed_1_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<bool>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 940386, RefRangeEnd = 940388, XrefRangeStart = 940377, XrefRangeEnd = 940386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
      [CallerCount(1), CachedScanResults(RefRangeStart = 940394, RefRangeEnd = 940395, XrefRangeStart = 940388, XrefRangeEnd = 940394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsUtf8_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 940404, RefRangeEnd = 940406, XrefRangeStart = 940395, XrefRangeEnd = 940404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 940424, RefRangeEnd = 940425, XrefRangeStart = 940406, XrefRangeEnd = 940424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AttributeDataValue other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940425, XrefRangeEnd = 940463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<AttributeDataValue> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940463, XrefRangeEnd = 940469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940469, XrefRangeEnd = 940470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (AttributeDataValueInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr);
      AttributeDataValueInternal.NativeFieldInfoPtr_m_AsInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsInt64));
      AttributeDataValueInternal.NativeFieldInfoPtr_m_AsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsDouble));
      AttributeDataValueInternal.NativeFieldInfoPtr_m_AsBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsBool));
      AttributeDataValueInternal.NativeFieldInfoPtr_m_AsUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsUtf8));
      AttributeDataValueInternal.NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_ValueType));
      AttributeDataValueInternal.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665926);
      AttributeDataValueInternal.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665927);
      AttributeDataValueInternal.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_Unboxed_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665928);
      AttributeDataValueInternal.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_Unboxed_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665929);
      AttributeDataValueInternal.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665930);
      AttributeDataValueInternal.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665931);
      AttributeDataValueInternal.NativeMethodInfoPtr_get_AsUtf8_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665932);
      AttributeDataValueInternal.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665933);
      AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665934);
      AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665935);
      AttributeDataValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665936);
      AttributeDataValueInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665937);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
