// Decompiled with JetBrains decompiler
// Type: SpecularBoost
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

#nullable disable
[Serializable]
public sealed class SpecularBoost : CustomPostProcessVolumeComponent
{
  private static readonly IntPtr NativeFieldInfoPtr_blendMode;
  private static readonly IntPtr NativeFieldInfoPtr_tint;
  private static readonly IntPtr NativeFieldInfoPtr_contrast;
  private static readonly IntPtr NativeFieldInfoPtr_wallMaskStrength;
  private static readonly IntPtr NativeFieldInfoPtr_intensity;
  private static readonly IntPtr NativeFieldInfoPtr_power;
  private static readonly IntPtr NativeFieldInfoPtr_cutoff;
  private static readonly IntPtr NativeFieldInfoPtr_range;
  private static readonly IntPtr NativeFieldInfoPtr_m_Material;
  private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0;
  private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922185, XrefRangeEnd = 922189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsActive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpecularBoost.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  public override unsafe CustomPostProcessInjectionPoint injectionPoint
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpecularBoost.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CustomPostProcessInjectionPoint*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922189, XrefRangeEnd = 922203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Setup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecularBoost.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922203, XrefRangeEnd = 922301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Render(
    CommandBuffer cmd,
    HDCamera camera,
    RTHandle source,
    RTHandle destination)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destination);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecularBoost.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922301, XrefRangeEnd = 922305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Cleanup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecularBoost.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922305, XrefRangeEnd = 922343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpecularBoost()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecularBoost.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpecularBoost()
  {
    Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SpecularBoost));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr);
    SpecularBoost.NativeFieldInfoPtr_blendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (blendMode));
    SpecularBoost.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (tint));
    SpecularBoost.NativeFieldInfoPtr_contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (contrast));
    SpecularBoost.NativeFieldInfoPtr_wallMaskStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (wallMaskStrength));
    SpecularBoost.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (intensity));
    SpecularBoost.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (power));
    SpecularBoost.NativeFieldInfoPtr_cutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (cutoff));
    SpecularBoost.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (range));
    SpecularBoost.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, nameof (m_Material));
    SpecularBoost.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, 100663749);
    SpecularBoost.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, 100663750);
    SpecularBoost.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, 100663751);
    SpecularBoost.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, 100663752);
    SpecularBoost.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, 100663753);
    SpecularBoost.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecularBoost>.NativeClassPtr, 100663754);
  }

  public SpecularBoost(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe SpecularBlendModeParameter blendMode
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_blendMode));
      return pointer == IntPtr.Zero ? (SpecularBlendModeParameter) null : new SpecularBlendModeParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_blendMode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter tint
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_tint));
      return pointer == IntPtr.Zero ? (ColorParameter) null : new ColorParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_tint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter contrast
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_contrast));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_contrast), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter wallMaskStrength
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_wallMaskStrength));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_wallMaskStrength), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter intensity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_intensity));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter power
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_power));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_power), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatRangeParameter cutoff
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_cutoff));
      return pointer == IntPtr.Zero ? (FloatRangeParameter) null : new FloatRangeParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_cutoff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter range
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_range));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_range), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material m_Material
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_m_Material));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecularBoost.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
