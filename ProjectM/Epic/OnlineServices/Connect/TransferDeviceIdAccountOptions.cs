// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.TransferDeviceIdAccountOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect
{
  public sealed class TransferDeviceIdAccountOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrimaryLocalUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalDeviceUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProductUserIdToPreserve_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrimaryLocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalDeviceUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductUserIdToPreserve_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0;

    public unsafe ProductUserId PrimaryLocalUserId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptions.NativeMethodInfoPtr_get_PrimaryLocalUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptions.NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalDeviceUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptions.NativeMethodInfoPtr_get_LocalDeviceUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptions.NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId ProductUserIdToPreserve
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptions.NativeMethodInfoPtr_get_ProductUserIdToPreserve_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptions.NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static TransferDeviceIdAccountOptions()
    {
      Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (TransferDeviceIdAccountOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr);
      TransferDeviceIdAccountOptions.NativeFieldInfoPtr__PrimaryLocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, "<PrimaryLocalUserId>k__BackingField");
      TransferDeviceIdAccountOptions.NativeFieldInfoPtr__LocalDeviceUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, "<LocalDeviceUserId>k__BackingField");
      TransferDeviceIdAccountOptions.NativeFieldInfoPtr__ProductUserIdToPreserve_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, "<ProductUserIdToPreserve>k__BackingField");
      TransferDeviceIdAccountOptions.NativeMethodInfoPtr_get_PrimaryLocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, 100673129);
      TransferDeviceIdAccountOptions.NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, 100673130);
      TransferDeviceIdAccountOptions.NativeMethodInfoPtr_get_LocalDeviceUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, 100673131);
      TransferDeviceIdAccountOptions.NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, 100673132);
      TransferDeviceIdAccountOptions.NativeMethodInfoPtr_get_ProductUserIdToPreserve_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, 100673133);
      TransferDeviceIdAccountOptions.NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, 100673134);
    }

    public TransferDeviceIdAccountOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TransferDeviceIdAccountOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransferDeviceIdAccountOptions>.NativeClassPtr, data));
    }

    public unsafe ProductUserId _PrimaryLocalUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransferDeviceIdAccountOptions.NativeFieldInfoPtr__PrimaryLocalUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransferDeviceIdAccountOptions.NativeFieldInfoPtr__PrimaryLocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProductUserId _LocalDeviceUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransferDeviceIdAccountOptions.NativeFieldInfoPtr__LocalDeviceUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransferDeviceIdAccountOptions.NativeFieldInfoPtr__LocalDeviceUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProductUserId _ProductUserIdToPreserve_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransferDeviceIdAccountOptions.NativeFieldInfoPtr__ProductUserIdToPreserve_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransferDeviceIdAccountOptions.NativeFieldInfoPtr__ProductUserIdToPreserve_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
