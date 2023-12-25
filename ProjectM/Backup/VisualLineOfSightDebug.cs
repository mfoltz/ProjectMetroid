// Decompiled with JetBrains decompiler
// Type: VisualLineOfSightDebug
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
public sealed class VisualLineOfSightDebug : CustomPostProcessVolumeComponent
{
  private static readonly IntPtr NativeFieldInfoPtr_m_Material;
  private static readonly IntPtr NativeFieldInfoPtr_InputTextureProperty;
  private static readonly IntPtr NativeFieldInfoPtr_kShaderName;
  private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0;
  private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912022, XrefRangeEnd = 912026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsActive()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(VisualLineOfSightDebug.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VisualLineOfSightDebug.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CustomPostProcessInjectionPoint*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912026, XrefRangeEnd = 912049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Setup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VisualLineOfSightDebug.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912049, XrefRangeEnd = 912059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(VisualLineOfSightDebug.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912059, XrefRangeEnd = 912063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Cleanup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VisualLineOfSightDebug.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VisualLineOfSightDebug()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VisualLineOfSightDebug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VisualLineOfSightDebug()
  {
    Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (VisualLineOfSightDebug));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr);
    VisualLineOfSightDebug.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, nameof (m_Material));
    VisualLineOfSightDebug.NativeFieldInfoPtr_InputTextureProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, nameof (InputTextureProperty));
    VisualLineOfSightDebug.NativeFieldInfoPtr_kShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, nameof (kShaderName));
    VisualLineOfSightDebug.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, 100663321);
    VisualLineOfSightDebug.NativeMethodInfoPtr_get_injectionPoint_Public_Virtual_get_CustomPostProcessInjectionPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, 100663322);
    VisualLineOfSightDebug.NativeMethodInfoPtr_Setup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, 100663323);
    VisualLineOfSightDebug.NativeMethodInfoPtr_Render_Public_Virtual_Void_CommandBuffer_HDCamera_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, 100663324);
    VisualLineOfSightDebug.NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, 100663325);
    VisualLineOfSightDebug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualLineOfSightDebug>.NativeClassPtr, 100663326);
  }

  public VisualLineOfSightDebug(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Material m_Material
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualLineOfSightDebug.NativeFieldInfoPtr_m_Material));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VisualLineOfSightDebug.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int InputTextureProperty
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualLineOfSightDebug.NativeFieldInfoPtr_InputTextureProperty));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisualLineOfSightDebug.NativeFieldInfoPtr_InputTextureProperty)) = value;
    }
  }

  public static unsafe string kShaderName
  {
    get
    {
      IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(VisualLineOfSightDebug.NativeFieldInfoPtr_kShaderName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VisualLineOfSightDebug.NativeFieldInfoPtr_kShaderName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
