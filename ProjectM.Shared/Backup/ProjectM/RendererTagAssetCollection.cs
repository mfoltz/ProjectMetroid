// Decompiled with JetBrains decompiler
// Type: ProjectM.RendererTagAssetCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class RendererTagAssetCollection : RendererTagMask
  {
    private static readonly IntPtr NativeFieldInfoPtr_RendererTags;
    private static readonly IntPtr NativeMethodInfoPtr_GetMask_Public_Virtual_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749155, XrefRangeEnd = 749168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetMask()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RendererTagAssetCollection.NativeMethodInfoPtr_GetMask_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RendererTagAssetCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererTagAssetCollection>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RendererTagAssetCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RendererTagAssetCollection()
    {
      Il2CppClassPointerStore<RendererTagAssetCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RendererTagAssetCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererTagAssetCollection>.NativeClassPtr);
      RendererTagAssetCollection.NativeFieldInfoPtr_RendererTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererTagAssetCollection>.NativeClassPtr, nameof (RendererTags));
      RendererTagAssetCollection.NativeMethodInfoPtr_GetMask_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererTagAssetCollection>.NativeClassPtr, 100665974);
      RendererTagAssetCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererTagAssetCollection>.NativeClassPtr, 100665975);
    }

    public RendererTagAssetCollection(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<RendererTagAsset> RendererTags
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererTagAssetCollection.NativeFieldInfoPtr_RendererTags));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<RendererTagAsset>) null : new Il2CppReferenceArray<RendererTagAsset>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RendererTagAssetCollection.NativeFieldInfoPtr_RendererTags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
