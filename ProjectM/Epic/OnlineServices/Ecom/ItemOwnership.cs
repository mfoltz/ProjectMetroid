// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.ItemOwnership
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
  public sealed class ItemOwnership : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Id_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OwnershipStatus_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_ItemOwnershipInternal_0;

    public unsafe Epic.OnlineServices.Utf8String Id
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemOwnership.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(ItemOwnership.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe OwnershipStatus OwnershipStatus
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemOwnership.NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(OwnershipStatus*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemOwnership.NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 963083, RefRangeEnd = 963084, XrefRangeStart = 963078, XrefRangeEnd = 963083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref ItemOwnershipInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemOwnership.NativeMethodInfoPtr_Set_Internal_Void_byref_ItemOwnershipInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ItemOwnership()
    {
      Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (ItemOwnership));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr);
      ItemOwnership.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, "<Id>k__BackingField");
      ItemOwnership.NativeFieldInfoPtr__OwnershipStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, "<OwnershipStatus>k__BackingField");
      ItemOwnership.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, 100672134);
      ItemOwnership.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, 100672135);
      ItemOwnership.NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, 100672136);
      ItemOwnership.NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, 100672137);
      ItemOwnership.NativeMethodInfoPtr_Set_Internal_Void_byref_ItemOwnershipInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, 100672138);
    }

    public ItemOwnership(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ItemOwnership()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemOwnership>.NativeClassPtr, data));
    }

    public unsafe Epic.OnlineServices.Utf8String _Id_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemOwnership.NativeFieldInfoPtr__Id_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemOwnership.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe OwnershipStatus _OwnershipStatus_k__BackingField
    {
      get
      {
        return *(OwnershipStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemOwnership.NativeFieldInfoPtr__OwnershipStatus_k__BackingField));
      }
      [param: In] set
      {
        *(OwnershipStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemOwnership.NativeFieldInfoPtr__OwnershipStatus_k__BackingField)) = value;
      }
    }
  }
}
