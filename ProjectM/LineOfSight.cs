// Decompiled with JetBrains decompiler
// Type: LineOfSight
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

#nullable disable
[Serializable]
public sealed class LineOfSight : CustomPostProcessVolumeComponent
{
  private static readonly IntPtr NativeFieldInfoPtr_m_Material;
  private static readonly IntPtr NativeFieldInfoPtr_InputTextureProperty;
  private static readonly IntPtr NativeFieldInfoPtr_BlackLineOfSightTextureProperty;
  private static readonly IntPtr NativeFieldInfoPtr__CachedScreenSize;
  private static readonly IntPtr NativeFieldInfoPtr__FrameCount;
  private static readonly IntPtr NativeFieldInfoPtr_kShaderName;
  private static readonly IntPtr NativeFieldInfoPtr_cShaderName;
  private static readonly IntPtr NativeFieldInfoPtr__BlackLineOfSightCS;
  private static readonly IntPtr NativeFieldInfoPtr__BlackLineOfSightTexture;
  private static readonly IntPtr NativeFieldInfoPtr__BlackLineOfSightHistoryTexture;
  private static readonly IntPtr NativeFieldInfoPtr__RenderBlackLineOfSightKernel;
  private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0;
  private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922050, XrefRangeEnd = 922054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsActive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineOfSight.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineOfSight.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CustomPostProcessInjectionPoint*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922054, XrefRangeEnd = 922119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Setup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LineOfSight.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922119, XrefRangeEnd = 922178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(LineOfSight.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922178, XrefRangeEnd = 922184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Cleanup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LineOfSight.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922184, XrefRangeEnd = 922185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LineOfSight()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LineOfSight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LineOfSight()
  {
    Il2CppClassPointerStore<LineOfSight>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (LineOfSight));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr);
    LineOfSight.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (m_Material));
    LineOfSight.NativeFieldInfoPtr_InputTextureProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (InputTextureProperty));
    LineOfSight.NativeFieldInfoPtr_BlackLineOfSightTextureProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (BlackLineOfSightTextureProperty));
    LineOfSight.NativeFieldInfoPtr__CachedScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (_CachedScreenSize));
    LineOfSight.NativeFieldInfoPtr__FrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (_FrameCount));
    LineOfSight.NativeFieldInfoPtr_kShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (kShaderName));
    LineOfSight.NativeFieldInfoPtr_cShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (cShaderName));
    LineOfSight.NativeFieldInfoPtr__BlackLineOfSightCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (_BlackLineOfSightCS));
    LineOfSight.NativeFieldInfoPtr__BlackLineOfSightTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (_BlackLineOfSightTexture));
    LineOfSight.NativeFieldInfoPtr__BlackLineOfSightHistoryTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (_BlackLineOfSightHistoryTexture));
    LineOfSight.NativeFieldInfoPtr__RenderBlackLineOfSightKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, nameof (_RenderBlackLineOfSightKernel));
    LineOfSight.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, 100663743);
    LineOfSight.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, 100663744);
    LineOfSight.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, 100663745);
    LineOfSight.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, 100663746);
    LineOfSight.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, 100663747);
    LineOfSight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSight>.NativeClassPtr, 100663748);
  }

  public LineOfSight(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Material m_Material
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr_m_Material));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int InputTextureProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr_InputTextureProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr_InputTextureProperty)) = value;
    }
  }

  public unsafe int BlackLineOfSightTextureProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr_BlackLineOfSightTextureProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr_BlackLineOfSightTextureProperty)) = value;
    }
  }

  public unsafe int2 _CachedScreenSize
  {
    get
    {
      return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__CachedScreenSize));
    }
    [param: In] set
    {
      *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__CachedScreenSize)) = value;
    }
  }

  public unsafe int _FrameCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__FrameCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__FrameCount)) = value;
    }
  }

  public static unsafe string kShaderName
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(LineOfSight.NativeFieldInfoPtr_kShaderName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LineOfSight.NativeFieldInfoPtr_kShaderName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string cShaderName
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(LineOfSight.NativeFieldInfoPtr_cShaderName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LineOfSight.NativeFieldInfoPtr_cShaderName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ComputeShader _BlackLineOfSightCS
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__BlackLineOfSightCS));
      return pointer == IntPtr.Zero ? (ComputeShader) null : new ComputeShader(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__BlackLineOfSightCS), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderTexture _BlackLineOfSightTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__BlackLineOfSightTexture));
      return pointer == IntPtr.Zero ? (RenderTexture) null : new RenderTexture(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__BlackLineOfSightTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderTexture _BlackLineOfSightHistoryTexture
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__BlackLineOfSightHistoryTexture));
      return pointer == IntPtr.Zero ? (RenderTexture) null : new RenderTexture(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__BlackLineOfSightHistoryTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _RenderBlackLineOfSightKernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__RenderBlackLineOfSightKernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineOfSight.NativeFieldInfoPtr__RenderBlackLineOfSightKernel)) = value;
    }
  }
}
