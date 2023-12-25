// Decompiled with JetBrains decompiler
// Type: DarkForeground
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
public sealed class DarkForeground : CustomPostProcessVolumeComponent
{
  private static readonly IntPtr NativeFieldInfoPtr_intensity;
  private static readonly IntPtr NativeFieldInfoPtr_interpolatedDepth;
  private static readonly IntPtr NativeFieldInfoPtr_foregroundColor;
  private static readonly IntPtr NativeFieldInfoPtr_distance;
  private static readonly IntPtr NativeFieldInfoPtr_blendMode;
  private static readonly IntPtr NativeFieldInfoPtr_m_Material;
  private static readonly IntPtr NativeFieldInfoPtr_kShaderName;
  private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0;
  private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921966, XrefRangeEnd = 921974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsActive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(DarkForeground.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(DarkForeground.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CustomPostProcessInjectionPoint*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921974, XrefRangeEnd = 921994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Setup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DarkForeground.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921994, XrefRangeEnd = 922021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(DarkForeground.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922021, XrefRangeEnd = 922025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Cleanup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DarkForeground.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922025, XrefRangeEnd = 922050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DarkForeground()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DarkForeground.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DarkForeground()
  {
    Il2CppClassPointerStore<DarkForeground>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (DarkForeground));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr);
    DarkForeground.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, nameof (intensity));
    DarkForeground.NativeFieldInfoPtr_interpolatedDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, nameof (interpolatedDepth));
    DarkForeground.NativeFieldInfoPtr_foregroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, nameof (foregroundColor));
    DarkForeground.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, nameof (distance));
    DarkForeground.NativeFieldInfoPtr_blendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, nameof (blendMode));
    DarkForeground.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, nameof (m_Material));
    DarkForeground.NativeFieldInfoPtr_kShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, nameof (kShaderName));
    DarkForeground.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, 100663736);
    DarkForeground.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, 100663737);
    DarkForeground.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, 100663738);
    DarkForeground.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, 100663739);
    DarkForeground.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, 100663740);
    DarkForeground.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, 100663741);
  }

  public DarkForeground(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ClampedFloatParameter intensity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_intensity));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter interpolatedDepth
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_interpolatedDepth));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_interpolatedDepth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter foregroundColor
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_foregroundColor));
      return pointer == IntPtr.Zero ? (ColorParameter) null : new ColorParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_foregroundColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter distance
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_distance));
      return pointer == IntPtr.Zero ? (ClampedFloatParameter) null : new ClampedFloatParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_distance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DarkForeground.BlendModeParameter blendMode
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_blendMode));
      return pointer == IntPtr.Zero ? (DarkForeground.BlendModeParameter) null : new DarkForeground.BlendModeParameter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_blendMode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material m_Material
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_m_Material));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DarkForeground.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string kShaderName
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(DarkForeground.NativeFieldInfoPtr_kShaderName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DarkForeground.NativeFieldInfoPtr_kShaderName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public enum BlendMode
  {
    None,
    Multiply,
    Overlay,
  }

  [Serializable]
  public sealed class BlendModeParameter : VolumeParameter<DarkForeground.BlendMode>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlendMode_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 921965, RefRangeEnd = 921966, XrefRangeStart = 921962, XrefRangeEnd = 921965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlendModeParameter(DarkForeground.BlendMode value, bool overrideState = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkForeground.BlendModeParameter>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &value;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &overrideState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DarkForeground.BlendModeParameter.NativeMethodInfoPtr__ctor_Public_Void_BlendMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlendModeParameter()
    {
      Il2CppClassPointerStore<DarkForeground.BlendModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DarkForeground>.NativeClassPtr, nameof (BlendModeParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkForeground.BlendModeParameter>.NativeClassPtr);
      DarkForeground.BlendModeParameter.NativeMethodInfoPtr__ctor_Public_Void_BlendMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkForeground.BlendModeParameter>.NativeClassPtr, 100663742);
    }

    public BlendModeParameter(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
