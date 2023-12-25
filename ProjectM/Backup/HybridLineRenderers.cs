// Decompiled with JetBrains decompiler
// Type: HybridLineRenderers
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
public class HybridLineRenderers : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_LineRenderers;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HybridLineRenderers()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridLineRenderers>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridLineRenderers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HybridLineRenderers()
  {
    Il2CppClassPointerStore<HybridLineRenderers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (HybridLineRenderers));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridLineRenderers>.NativeClassPtr);
    HybridLineRenderers.NativeFieldInfoPtr_LineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLineRenderers>.NativeClassPtr, nameof (LineRenderers));
    HybridLineRenderers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLineRenderers>.NativeClassPtr, 100663580);
  }

  public HybridLineRenderers(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<HybridLineRendererComponent> LineRenderers
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRenderers.NativeFieldInfoPtr_LineRenderers));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<HybridLineRendererComponent>) null : new Il2CppReferenceArray<HybridLineRendererComponent>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridLineRenderers.NativeFieldInfoPtr_LineRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
