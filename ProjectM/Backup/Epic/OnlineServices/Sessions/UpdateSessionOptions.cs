// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.UpdateSessionOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  public sealed class UpdateSessionOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SessionModificationHandle_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionModificationHandle_Public_get_SessionModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionModificationHandle_Public_set_Void_SessionModification_0;

    public unsafe SessionModification SessionModificationHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSessionOptions.NativeMethodInfoPtr_get_SessionModificationHandle_Public_get_SessionModification_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SessionModification) null : new SessionModification(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSessionOptions.NativeMethodInfoPtr_set_SessionModificationHandle_Public_set_Void_SessionModification_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static UpdateSessionOptions()
    {
      Il2CppClassPointerStore<UpdateSessionOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (UpdateSessionOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSessionOptions>.NativeClassPtr);
      UpdateSessionOptions.NativeFieldInfoPtr__SessionModificationHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSessionOptions>.NativeClassPtr, "<SessionModificationHandle>k__BackingField");
      UpdateSessionOptions.NativeMethodInfoPtr_get_SessionModificationHandle_Public_get_SessionModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSessionOptions>.NativeClassPtr, 100666732);
      UpdateSessionOptions.NativeMethodInfoPtr_set_SessionModificationHandle_Public_set_Void_SessionModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSessionOptions>.NativeClassPtr, 100666733);
    }

    public UpdateSessionOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public UpdateSessionOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UpdateSessionOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSessionOptions>.NativeClassPtr, data));
    }

    public unsafe SessionModification _SessionModificationHandle_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSessionOptions.NativeFieldInfoPtr__SessionModificationHandle_k__BackingField));
        return pointer == System.IntPtr.Zero ? (SessionModification) null : new SessionModification(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateSessionOptions.NativeFieldInfoPtr__SessionModificationHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
