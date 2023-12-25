// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ProductUserId
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices
{
  public sealed class ProductUserId : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ProductuseridMaxLength;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromString_Public_Static_ProductUserId_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ProductUserId_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Result_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_String_IFormatProvider_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Utf8String_ProductUserId_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProductUserId()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936377, XrefRangeEnd = 936387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ProductUserId FromString(Utf8String productUserIdString)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) productUserIdString);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_FromString_Public_Static_ProductUserId_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe explicit operator ProductUserId(Utf8String value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_op_Explicit_Public_Static_ProductUserId_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 936392, RefRangeEnd = 936393, XrefRangeStart = 936387, XrefRangeEnd = 936392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValid()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 936400, RefRangeEnd = 936401, XrefRangeStart = 936393, XrefRangeEnd = 936400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result ToString(out Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_ToString_Public_Result_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Utf8String utf8String = pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936401, XrefRangeEnd = 936409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936409, XrefRangeEnd = 936417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe explicit operator Utf8String(ProductUserId value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_op_Explicit_Public_Static_Utf8String_ProductUserId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
    }

    static ProductUserId()
    {
      Il2CppClassPointerStore<ProductUserId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (ProductUserId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr);
      ProductUserId.NativeFieldInfoPtr_ProductuseridMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, nameof (ProductuseridMaxLength));
      ProductUserId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664865);
      ProductUserId.NativeMethodInfoPtr_FromString_Public_Static_ProductUserId_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664867);
      ProductUserId.NativeMethodInfoPtr_op_Explicit_Public_Static_ProductUserId_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664868);
      ProductUserId.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664869);
      ProductUserId.NativeMethodInfoPtr_ToString_Public_Result_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664870);
      ProductUserId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664871);
      ProductUserId.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664872);
      ProductUserId.NativeMethodInfoPtr_op_Explicit_Public_Static_Utf8String_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664873);
    }

    public ProductUserId(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int ProductuseridMaxLength
    {
      get
      {
        int productuseridMaxLength;
        IL2CPP.il2cpp_field_static_get_value(ProductUserId.NativeFieldInfoPtr_ProductuseridMaxLength, (void*) &productuseridMaxLength);
        return productuseridMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProductUserId.NativeFieldInfoPtr_ProductuseridMaxLength, (void*) &value);
      }
    }
  }
}
