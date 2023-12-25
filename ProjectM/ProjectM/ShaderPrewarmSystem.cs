// Decompiled with JetBrains decompiler
// Type: ProjectM.ShaderPrewarmSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM
{
  public class ShaderPrewarmSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__NewShaderQuery;
    private static readonly IntPtr NativeFieldInfoPtr__ShaderToPrewarm;
    private static readonly IntPtr NativeFieldInfoPtr__ShadersEveryFrame;
    private static readonly IntPtr NativeFieldInfoPtr__ShadersEveryFrameResetValue;
    private static readonly IntPtr NativeFieldInfoPtr__PrewarmStopwatch;
    private static readonly IntPtr NativeMethodInfoPtr_get_ShadersLeftToPrewarm_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_PrewarmShader_Public_Void_Int32_byref_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_PrewarmShader_Private_Static_Void_Shader_PassType_Il2CppStringArray_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe int ShadersLeftToPrewarm
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067635, XrefRangeEnd = 1067636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShaderPrewarmSystem.NativeMethodInfoPtr_get_ShadersLeftToPrewarm_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067636, XrefRangeEnd = 1067646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShaderPrewarmSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067646, XrefRangeEnd = 1067687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrewarmShader(int shadersEveryFrame, out int totalToPrewarm)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &shadersEveryFrame;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref totalToPrewarm;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShaderPrewarmSystem.NativeMethodInfoPtr_PrewarmShader_Public_Void_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067687, XrefRangeEnd = 1067711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShaderPrewarmSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067711, XrefRangeEnd = 1067719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PrewarmShader(
      Shader shader,
      PassType passType,
      Il2CppStringArray keywords)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shader);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &passType;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keywords);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShaderPrewarmSystem.NativeMethodInfoPtr_PrewarmShader_Private_Static_Void_Shader_PassType_Il2CppStringArray_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067719, XrefRangeEnd = 1067720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShaderPrewarmSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShaderPrewarmSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShaderPrewarmSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShaderPrewarmSystem()
    {
      Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShaderPrewarmSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr);
      ShaderPrewarmSystem.NativeFieldInfoPtr__NewShaderQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, nameof (_NewShaderQuery));
      ShaderPrewarmSystem.NativeFieldInfoPtr__ShaderToPrewarm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, nameof (_ShaderToPrewarm));
      ShaderPrewarmSystem.NativeFieldInfoPtr__ShadersEveryFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, nameof (_ShadersEveryFrame));
      ShaderPrewarmSystem.NativeFieldInfoPtr__ShadersEveryFrameResetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, nameof (_ShadersEveryFrameResetValue));
      ShaderPrewarmSystem.NativeFieldInfoPtr__PrewarmStopwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, nameof (_PrewarmStopwatch));
      ShaderPrewarmSystem.NativeMethodInfoPtr_get_ShadersLeftToPrewarm_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, 100683993);
      ShaderPrewarmSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, 100683994);
      ShaderPrewarmSystem.NativeMethodInfoPtr_PrewarmShader_Public_Void_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, 100683995);
      ShaderPrewarmSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, 100683996);
      ShaderPrewarmSystem.NativeMethodInfoPtr_PrewarmShader_Private_Static_Void_Shader_PassType_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, 100683997);
      ShaderPrewarmSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, 100683998);
      ShaderPrewarmSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPrewarmSystem>.NativeClassPtr, 100683999);
    }

    public ShaderPrewarmSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _NewShaderQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__NewShaderQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__NewShaderQuery)) = value;
      }
    }

    public unsafe Stack<ShaderVar> _ShaderToPrewarm
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__ShaderToPrewarm));
        return pointer == IntPtr.Zero ? (Stack<ShaderVar>) null : new Stack<ShaderVar>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__ShaderToPrewarm), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _ShadersEveryFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__ShadersEveryFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__ShadersEveryFrame)) = value;
      }
    }

    public unsafe int _ShadersEveryFrameResetValue
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__ShadersEveryFrameResetValue));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__ShadersEveryFrameResetValue)) = value;
      }
    }

    public unsafe Stopwatch _PrewarmStopwatch
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__PrewarmStopwatch));
        return pointer == IntPtr.Zero ? (Stopwatch) null : new Stopwatch(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShaderPrewarmSystem.NativeFieldInfoPtr__PrewarmStopwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
