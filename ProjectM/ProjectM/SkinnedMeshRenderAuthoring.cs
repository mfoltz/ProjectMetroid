// Decompiled with JetBrains decompiler
// Type: ProjectM.SkinnedMeshRenderAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SkinnedMeshRenderAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SkinnedMeshRenderers;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SkinnedMeshRenderAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedMeshRenderAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SkinnedMeshRenderAuthoring()
    {
      Il2CppClassPointerStore<SkinnedMeshRenderAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SkinnedMeshRenderAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedMeshRenderAuthoring>.NativeClassPtr);
      SkinnedMeshRenderAuthoring.NativeFieldInfoPtr_SkinnedMeshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedMeshRenderAuthoring>.NativeClassPtr, nameof (SkinnedMeshRenderers));
      SkinnedMeshRenderAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderAuthoring>.NativeClassPtr, 100684171);
    }

    public SkinnedMeshRenderAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> SkinnedMeshRenderers
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SkinnedMeshRenderAuthoring.NativeFieldInfoPtr_SkinnedMeshRenderers));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SkinnedMeshRenderer>) null : new Il2CppReferenceArray<SkinnedMeshRenderer>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SkinnedMeshRenderAuthoring.NativeFieldInfoPtr_SkinnedMeshRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
