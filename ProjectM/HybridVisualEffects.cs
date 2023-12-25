// Decompiled with JetBrains decompiler
// Type: HybridVisualEffects
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
using UnityEngine.VFX;

#nullable disable
public class HybridVisualEffects : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_VisualEffects;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HybridVisualEffects()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridVisualEffects>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridVisualEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HybridVisualEffects()
  {
    Il2CppClassPointerStore<HybridVisualEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (HybridVisualEffects));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridVisualEffects>.NativeClassPtr);
    HybridVisualEffects.NativeFieldInfoPtr_VisualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridVisualEffects>.NativeClassPtr, nameof (VisualEffects));
    HybridVisualEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridVisualEffects>.NativeClassPtr, 100663593);
  }

  public HybridVisualEffects(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<VisualEffect> VisualEffects
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridVisualEffects.NativeFieldInfoPtr_VisualEffects));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<VisualEffect>) null : new Il2CppReferenceArray<VisualEffect>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridVisualEffects.NativeFieldInfoPtr_VisualEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
