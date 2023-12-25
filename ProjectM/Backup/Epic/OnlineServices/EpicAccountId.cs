// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.EpicAccountId
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
  public sealed class EpicAccountId : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EpicaccountidMaxLength;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromString_Public_Static_EpicAccountId_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_EpicAccountId_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Result_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_String_IFormatProvider_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Utf8String_EpicAccountId_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EpicAccountId()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936322, XrefRangeEnd = 936332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EpicAccountId FromString(Utf8String accountIdString)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) accountIdString);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_FromString_Public_Static_EpicAccountId_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe explicit operator EpicAccountId(Utf8String value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_op_Explicit_Public_Static_EpicAccountId_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936332, XrefRangeEnd = 936337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValid()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936337, XrefRangeEnd = 936344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result ToString(out Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_ToString_Public_Result_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Utf8String utf8String = pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936344, XrefRangeEnd = 936352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936352, XrefRangeEnd = 936360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe explicit operator Utf8String(EpicAccountId value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_op_Explicit_Public_Static_Utf8String_EpicAccountId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
    }

    static EpicAccountId()
    {
      Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (EpicAccountId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr);
      EpicAccountId.NativeFieldInfoPtr_EpicaccountidMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, nameof (EpicaccountidMaxLength));
      EpicAccountId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664825);
      EpicAccountId.NativeMethodInfoPtr_FromString_Public_Static_EpicAccountId_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664827);
      EpicAccountId.NativeMethodInfoPtr_op_Explicit_Public_Static_EpicAccountId_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664828);
      EpicAccountId.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664829);
      EpicAccountId.NativeMethodInfoPtr_ToString_Public_Result_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664830);
      EpicAccountId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664831);
      EpicAccountId.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664832);
      EpicAccountId.NativeMethodInfoPtr_op_Explicit_Public_Static_Utf8String_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664833);
    }

    public EpicAccountId(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int EpicaccountidMaxLength
    {
      get
      {
        int epicaccountidMaxLength;
        IL2CPP.il2cpp_field_static_get_value(EpicAccountId.NativeFieldInfoPtr_EpicaccountidMaxLength, (void*) &epicaccountidMaxLength);
        return epicaccountidMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EpicAccountId.NativeFieldInfoPtr_EpicaccountidMaxLength, (void*) &value);
      }
    }
  }
}
