// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CheckoutEntry
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom
{
  public sealed class CheckoutEntry : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__OfferId_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OfferId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OfferId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_CheckoutEntryInternal_0;

    public unsafe Epic.OnlineServices.Utf8String OfferId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CheckoutEntry.NativeMethodInfoPtr_get_OfferId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CheckoutEntry.NativeMethodInfoPtr_set_OfferId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 961778, RefRangeEnd = 961779, XrefRangeStart = 961773, XrefRangeEnd = 961778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref CheckoutEntryInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CheckoutEntry.NativeMethodInfoPtr_Set_Internal_Void_byref_CheckoutEntryInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CheckoutEntry()
    {
      Il2CppClassPointerStore<CheckoutEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (CheckoutEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckoutEntry>.NativeClassPtr);
      CheckoutEntry.NativeFieldInfoPtr__OfferId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutEntry>.NativeClassPtr, "<OfferId>k__BackingField");
      CheckoutEntry.NativeMethodInfoPtr_get_OfferId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutEntry>.NativeClassPtr, 100671845);
      CheckoutEntry.NativeMethodInfoPtr_set_OfferId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutEntry>.NativeClassPtr, 100671846);
      CheckoutEntry.NativeMethodInfoPtr_Set_Internal_Void_byref_CheckoutEntryInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutEntry>.NativeClassPtr, 100671847);
    }

    public CheckoutEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CheckoutEntry()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CheckoutEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckoutEntry>.NativeClassPtr, data));
    }

    public unsafe Epic.OnlineServices.Utf8String _OfferId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheckoutEntry.NativeFieldInfoPtr__OfferId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CheckoutEntry.NativeFieldInfoPtr__OfferId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
