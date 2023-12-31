// Decompiled with JetBrains decompiler
// Type: ProjectM.RendererTagAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class RendererTagAsset : RendererTagMask
  {
    private static readonly IntPtr NativeFieldInfoPtr_Value;
    private static readonly IntPtr NativeMethodInfoPtr_GetMask_Public_Virtual_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(264)]
    [CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetMask()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RendererTagAsset.NativeMethodInfoPtr_GetMask_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RendererTagAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererTagAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RendererTagAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RendererTagAsset()
    {
      Il2CppClassPointerStore<RendererTagAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RendererTagAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererTagAsset>.NativeClassPtr);
      RendererTagAsset.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererTagAsset>.NativeClassPtr, nameof (Value));
      RendererTagAsset.NativeMethodInfoPtr_GetMask_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererTagAsset>.NativeClassPtr, 100665972);
      RendererTagAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererTagAsset>.NativeClassPtr, 100665973);
    }

    public RendererTagAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Value
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererTagAsset.NativeFieldInfoPtr_Value));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RendererTagAsset.NativeFieldInfoPtr_Value)) = value;
      }
    }
  }
}
