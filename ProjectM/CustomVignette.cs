// Decompiled with JetBrains decompiler
// Type: CustomVignette
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
public sealed class CustomVignette : CustomPostProcessVolumeComponent
{
  private static readonly IntPtr NativeFieldInfoPtr_Intensity;
  private static readonly IntPtr NativeFieldInfoPtr_ColorTint;
  private static readonly IntPtr NativeFieldInfoPtr_UvPolarCoordinates;
  private static readonly IntPtr NativeFieldInfoPtr_OverlayTexture;
  private static readonly IntPtr NativeFieldInfoPtr_OverlayTilingScrolling;
  private static readonly IntPtr NativeFieldInfoPtr_SecOverlayTex;
  private static readonly IntPtr NativeFieldInfoPtr_SecOverlayTilingScrolling;
  private static readonly IntPtr NativeFieldInfoPtr_MaskTexture;
  private static readonly IntPtr NativeFieldInfoPtr_DistortionTexture;
  private static readonly IntPtr NativeFieldInfoPtr_DistortionTilingScrolling;
  private static readonly IntPtr NativeFieldInfoPtr_Distortion;
  private static readonly IntPtr NativeFieldInfoPtr_m_Material;
  private static readonly IntPtr NativeFieldInfoPtr_kShaderName;
  private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Override_Public_Virtual_Void_VolumeComponent_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0;
  private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921382, XrefRangeEnd = 921386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsActive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomVignette.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  public override unsafe CustomPostProcessInjectionPoint injectionPoint
  {
    [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomVignette.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CustomPostProcessInjectionPoint*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921386, XrefRangeEnd = 921406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Setup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomVignette.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921406, XrefRangeEnd = 921409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Override(VolumeComponent state, float interpFactor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &interpFactor;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomVignette.NativeMethodInfoPtr_Override_Public_Virtual_Void_VolumeComponent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921409, XrefRangeEnd = 921470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(CustomVignette.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921470, XrefRangeEnd = 921474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Cleanup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomVignette.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921474, XrefRangeEnd = 921529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomVignette()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomVignette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CustomVignette()
  {
    Il2CppClassPointerStore<CustomVignette>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (CustomVignette));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr);
    CustomVignette.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (Intensity));
    CustomVignette.NativeFieldInfoPtr_ColorTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (ColorTint));
    CustomVignette.NativeFieldInfoPtr_UvPolarCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (UvPolarCoordinates));
    CustomVignette.NativeFieldInfoPtr_OverlayTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (OverlayTexture));
    CustomVignette.NativeFieldInfoPtr_OverlayTilingScrolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (OverlayTilingScrolling));
    CustomVignette.NativeFieldInfoPtr_SecOverlayTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (SecOverlayTex));
    CustomVignette.NativeFieldInfoPtr_SecOverlayTilingScrolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (SecOverlayTilingScrolling));
    CustomVignette.NativeFieldInfoPtr_MaskTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (MaskTexture));
    CustomVignette.NativeFieldInfoPtr_DistortionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (DistortionTexture));
    CustomVignette.NativeFieldInfoPtr_DistortionTilingScrolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (DistortionTilingScrolling));
    CustomVignette.NativeFieldInfoPtr_Distortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (Distortion));
    CustomVignette.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (m_Material));
    CustomVignette.NativeFieldInfoPtr_kShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, nameof (kShaderName));
    CustomVignette.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, 100663678);
    CustomVignette.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, 100663679);
    CustomVignette.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, 100663680);
    CustomVignette.NativeMethodInfoPtr_Override_Public_Virtual_Void_VolumeComponent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, 100663681);
    CustomVignette.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, 100663682);
    CustomVignette.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, 100663683);
    CustomVignette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomVignette>.NativeClassPtr, 100663684);
  }

  public CustomVignette(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe FloatParameter Intensity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_Intensity));
      return pointer == IntPtr.Zero ? (FloatParameter) null : new FloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_Intensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter ColorTint
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_ColorTint));
      return pointer == IntPtr.Zero ? (ColorParameter) null : new ColorParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_ColorTint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoolParameter UvPolarCoordinates
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_UvPolarCoordinates));
      return pointer == IntPtr.Zero ? (BoolParameter) null : new BoolParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_UvPolarCoordinates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextureParameter OverlayTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_OverlayTexture));
      return pointer == IntPtr.Zero ? (TextureParameter) null : new TextureParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_OverlayTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4Parameter OverlayTilingScrolling
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_OverlayTilingScrolling));
      return pointer == IntPtr.Zero ? (Vector4Parameter) null : new Vector4Parameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_OverlayTilingScrolling), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextureParameter SecOverlayTex
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_SecOverlayTex));
      return pointer == IntPtr.Zero ? (TextureParameter) null : new TextureParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_SecOverlayTex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4Parameter SecOverlayTilingScrolling
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_SecOverlayTilingScrolling));
      return pointer == IntPtr.Zero ? (Vector4Parameter) null : new Vector4Parameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_SecOverlayTilingScrolling), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextureParameter MaskTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_MaskTexture));
      return pointer == IntPtr.Zero ? (TextureParameter) null : new TextureParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_MaskTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextureParameter DistortionTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_DistortionTexture));
      return pointer == IntPtr.Zero ? (TextureParameter) null : new TextureParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_DistortionTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4Parameter DistortionTilingScrolling
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_DistortionTilingScrolling));
      return pointer == IntPtr.Zero ? (Vector4Parameter) null : new Vector4Parameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_DistortionTilingScrolling), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter Distortion
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_Distortion));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_Distortion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material m_Material
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_m_Material));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomVignette.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string kShaderName
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(CustomVignette.NativeFieldInfoPtr_kShaderName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomVignette.NativeFieldInfoPtr_kShaderName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
