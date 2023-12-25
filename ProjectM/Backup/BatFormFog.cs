// Decompiled with JetBrains decompiler
// Type: BatFormFog
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
public sealed class BatFormFog : CustomPostProcessVolumeComponent
{
  private static readonly IntPtr NativeFieldInfoPtr_intensity;
  private static readonly IntPtr NativeFieldInfoPtr_fogColor;
  private static readonly IntPtr NativeFieldInfoPtr_fogColorDark;
  private static readonly IntPtr NativeFieldInfoPtr_fogRadius;
  private static readonly IntPtr NativeFieldInfoPtr_fogFadeDistanceDistance;
  private static readonly IntPtr NativeFieldInfoPtr_noiseTexture;
  private static readonly IntPtr NativeFieldInfoPtr_cloudTexture;
  private static readonly IntPtr NativeFieldInfoPtr_tiling;
  private static readonly IntPtr NativeFieldInfoPtr_flowSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_m_Material;
  private static readonly IntPtr NativeFieldInfoPtr_fogComponent;
  private static readonly IntPtr NativeFieldInfoPtr_kShaderName;
  private static readonly IntPtr NativeFieldInfoPtr_IntensityProperty;
  private static readonly IntPtr NativeFieldInfoPtr_FlowSpeedProperty;
  private static readonly IntPtr NativeFieldInfoPtr_CloudTextureProperty;
  private static readonly IntPtr NativeFieldInfoPtr_InputTextureProperty;
  private static readonly IntPtr NativeFieldInfoPtr_FogRadiusProperty;
  private static readonly IntPtr NativeFieldInfoPtr_FogDistanceFadeProperty;
  private static readonly IntPtr NativeFieldInfoPtr_BatFogColorProperty;
  private static readonly IntPtr NativeFieldInfoPtr_BatFogColorDarkProperty;
  private static readonly IntPtr NativeFieldInfoPtr_LocalPlayerPosProperty;
  private static readonly IntPtr NativeFieldInfoPtr_TilingProperty;
  private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0;
  private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921817, XrefRangeEnd = 921821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsActive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(BatFormFog.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BatFormFog.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CustomPostProcessInjectionPoint*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921821, XrefRangeEnd = 921871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Setup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BatFormFog.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921871, XrefRangeEnd = 921913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(BatFormFog.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921913, XrefRangeEnd = 921917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Cleanup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BatFormFog.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921917, XrefRangeEnd = 921962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BatFormFog()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BatFormFog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BatFormFog()
  {
    Il2CppClassPointerStore<BatFormFog>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (BatFormFog));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr);
    BatFormFog.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (intensity));
    BatFormFog.NativeFieldInfoPtr_fogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (fogColor));
    BatFormFog.NativeFieldInfoPtr_fogColorDark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (fogColorDark));
    BatFormFog.NativeFieldInfoPtr_fogRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (fogRadius));
    BatFormFog.NativeFieldInfoPtr_fogFadeDistanceDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (fogFadeDistanceDistance));
    BatFormFog.NativeFieldInfoPtr_noiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (noiseTexture));
    BatFormFog.NativeFieldInfoPtr_cloudTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (cloudTexture));
    BatFormFog.NativeFieldInfoPtr_tiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (tiling));
    BatFormFog.NativeFieldInfoPtr_flowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (flowSpeed));
    BatFormFog.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (m_Material));
    BatFormFog.NativeFieldInfoPtr_fogComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (fogComponent));
    BatFormFog.NativeFieldInfoPtr_kShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (kShaderName));
    BatFormFog.NativeFieldInfoPtr_IntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (IntensityProperty));
    BatFormFog.NativeFieldInfoPtr_FlowSpeedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (FlowSpeedProperty));
    BatFormFog.NativeFieldInfoPtr_CloudTextureProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (CloudTextureProperty));
    BatFormFog.NativeFieldInfoPtr_InputTextureProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (InputTextureProperty));
    BatFormFog.NativeFieldInfoPtr_FogRadiusProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (FogRadiusProperty));
    BatFormFog.NativeFieldInfoPtr_FogDistanceFadeProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (FogDistanceFadeProperty));
    BatFormFog.NativeFieldInfoPtr_BatFogColorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (BatFogColorProperty));
    BatFormFog.NativeFieldInfoPtr_BatFogColorDarkProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (BatFogColorDarkProperty));
    BatFormFog.NativeFieldInfoPtr_LocalPlayerPosProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (LocalPlayerPosProperty));
    BatFormFog.NativeFieldInfoPtr_TilingProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, nameof (TilingProperty));
    BatFormFog.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, 100663730);
    BatFormFog.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, 100663731);
    BatFormFog.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, 100663732);
    BatFormFog.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, 100663733);
    BatFormFog.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, 100663734);
    BatFormFog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatFormFog>.NativeClassPtr, 100663735);
  }

  public BatFormFog(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ClampedFloatParameter intensity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_intensity));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter fogColor
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogColor));
      return pointer == IntPtr.Zero ? (ColorParameter) null : new ColorParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter fogColorDark
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogColorDark));
      return pointer == IntPtr.Zero ? (ColorParameter) null : new ColorParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogColorDark), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter fogRadius
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogRadius));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogRadius), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter fogFadeDistanceDistance
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogFadeDistanceDistance));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogFadeDistanceDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture3DParameter noiseTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_noiseTexture));
      return pointer == IntPtr.Zero ? (Texture3DParameter) null : new Texture3DParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_noiseTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextureParameter cloudTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_cloudTexture));
      return pointer == IntPtr.Zero ? (TextureParameter) null : new TextureParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_cloudTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Parameter tiling
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_tiling));
      return pointer == IntPtr.Zero ? (Vector2Parameter) null : new Vector2Parameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_tiling), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatParameter flowSpeed
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_flowSpeed));
      return pointer == IntPtr.Zero ? (FloatParameter) null : new FloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_flowSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material m_Material
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_m_Material));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StunlockFogVolumeComponent fogComponent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogComponent));
      return pointer == IntPtr.Zero ? (StunlockFogVolumeComponent) null : new StunlockFogVolumeComponent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_fogComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string kShaderName
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(BatFormFog.NativeFieldInfoPtr_kShaderName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BatFormFog.NativeFieldInfoPtr_kShaderName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int IntensityProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_IntensityProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_IntensityProperty)) = value;
    }
  }

  public unsafe int FlowSpeedProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_FlowSpeedProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_FlowSpeedProperty)) = value;
    }
  }

  public unsafe int CloudTextureProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_CloudTextureProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_CloudTextureProperty)) = value;
    }
  }

  public unsafe int InputTextureProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_InputTextureProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_InputTextureProperty)) = value;
    }
  }

  public unsafe int FogRadiusProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_FogRadiusProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_FogRadiusProperty)) = value;
    }
  }

  public unsafe int FogDistanceFadeProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_FogDistanceFadeProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_FogDistanceFadeProperty)) = value;
    }
  }

  public unsafe int BatFogColorProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_BatFogColorProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_BatFogColorProperty)) = value;
    }
  }

  public unsafe int BatFogColorDarkProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_BatFogColorDarkProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_BatFogColorDarkProperty)) = value;
    }
  }

  public unsafe int LocalPlayerPosProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_LocalPlayerPosProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_LocalPlayerPosProperty)) = value;
    }
  }

  public unsafe int TilingProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_TilingProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatFormFog.NativeFieldInfoPtr_TilingProperty)) = value;
    }
  }
}
