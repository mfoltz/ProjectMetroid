// Decompiled with JetBrains decompiler
// Type: ProjectM.CubeRenderer.DebugCubeSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

#nullable disable
namespace ProjectM.CubeRenderer
{
  public class DebugCubeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CubeRenderLayer;
    private static readonly System.IntPtr NativeFieldInfoPtr__CubeMatrices;
    private static readonly System.IntPtr NativeFieldInfoPtr__CubeColors;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequestedCubeMatrices;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequestedCubeColors;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugLocalToWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugWorldToLocal;
    private static readonly System.IntPtr NativeFieldInfoPtr__MatricesBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__ColorsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__IndirectArgsBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__IndirectArgs;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialPropertyBlock;
    private static readonly System.IntPtr NativeFieldInfoPtr__CubeMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr__GreaterZOpacity;
    private static readonly System.IntPtr NativeFieldInfoPtr__InfiniteBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr__CubeDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__CubeRendererCustomPassVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasDrawnRequested;
    private static readonly System.IntPtr NativeMethodInfoPtr_get__RendererEnabled_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetGreaterZOpacity_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalToWorld_Public_Void_byref_float4x4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawCubes_Public_Void_byref_CubeRendererData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResizeBufferAndSetData_Private_Static_Void_byref_ComputeBuffer_byref_NativeArray_1_T_byref_Int32_byref_Int32_ComputeBufferType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe bool _RendererEnabled
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugCubeSystem.NativeMethodInfoPtr_get__RendererEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124202, XrefRangeEnd = 1124225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugCubeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124225, XrefRangeEnd = 1124253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugCubeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124253, XrefRangeEnd = 1124307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugCubeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetGreaterZOpacity(float opacity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &opacity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCubeSystem.NativeMethodInfoPtr_SetGreaterZOpacity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124307, XrefRangeEnd = 1124308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetLocalToWorld([In] ref float4x4 localToWorld)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref localToWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCubeSystem.NativeMethodInfoPtr_SetLocalToWorld_Public_Void_byref_float4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1124320, RefRangeEnd = 1124327, XrefRangeStart = 1124308, XrefRangeEnd = 1124320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawCubes([In] ref CubeRendererData cubeRendererData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref cubeRendererData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCubeSystem.NativeMethodInfoPtr_DrawCubes_Public_Void_byref_CubeRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124334, RefRangeEnd = 1124335, XrefRangeStart = 1124327, XrefRangeEnd = 1124334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ResizeBufferAndSetData<T>(
      ref ComputeBuffer buffer,
      ref NativeArray<T> data,
      [In] ref int stride,
      [In] ref int length,
      ComputeBufferType bufferType = ComputeBufferType.Default)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref stride;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref length;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCubeSystem.MethodInfoStoreGeneric_ResizeBufferAndSetData_Private_Static_Void_byref_ComputeBuffer_byref_NativeArray_1_T_byref_Int32_byref_Int32_ComputeBufferType_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ComputeBuffer local = ref buffer;
      System.IntPtr pointer = ptr;
      ComputeBuffer computeBuffer = pointer == System.IntPtr.Zero ? (ComputeBuffer) null : new ComputeBuffer(pointer);
      local = computeBuffer;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124398, RefRangeEnd = 1124399, XrefRangeStart = 1124335, XrefRangeEnd = 1124398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCubeSystem.NativeMethodInfoPtr_UpdateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124399, XrefRangeEnd = 1124405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugCubeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCubeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugCubeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugCubeSystem()
    {
      Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CubeRenderer", nameof (DebugCubeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr);
      DebugCubeSystem.NativeFieldInfoPtr__CubeRenderLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_CubeRenderLayer));
      DebugCubeSystem.NativeFieldInfoPtr__CubeMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_CubeMatrices));
      DebugCubeSystem.NativeFieldInfoPtr__CubeColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_CubeColors));
      DebugCubeSystem.NativeFieldInfoPtr__RequestedCubeMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_RequestedCubeMatrices));
      DebugCubeSystem.NativeFieldInfoPtr__RequestedCubeColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_RequestedCubeColors));
      DebugCubeSystem.NativeFieldInfoPtr__DebugLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_DebugLocalToWorld));
      DebugCubeSystem.NativeFieldInfoPtr__DebugWorldToLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_DebugWorldToLocal));
      DebugCubeSystem.NativeFieldInfoPtr__MatricesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_MatricesBuffer));
      DebugCubeSystem.NativeFieldInfoPtr__ColorsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_ColorsBuffer));
      DebugCubeSystem.NativeFieldInfoPtr__IndirectArgsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_IndirectArgsBuffer));
      DebugCubeSystem.NativeFieldInfoPtr__IndirectArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_IndirectArgs));
      DebugCubeSystem.NativeFieldInfoPtr__MaterialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_MaterialPropertyBlock));
      DebugCubeSystem.NativeFieldInfoPtr__CubeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_CubeMaterial));
      DebugCubeSystem.NativeFieldInfoPtr__GreaterZOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_GreaterZOpacity));
      DebugCubeSystem.NativeFieldInfoPtr__InfiniteBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_InfiniteBounds));
      DebugCubeSystem.NativeFieldInfoPtr__CubeDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_CubeDebugSettings));
      DebugCubeSystem.NativeFieldInfoPtr__CubeRendererCustomPassVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_CubeRendererCustomPassVolume));
      DebugCubeSystem.NativeFieldInfoPtr__HasDrawnRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, nameof (_HasDrawnRequested));
      DebugCubeSystem.NativeMethodInfoPtr_get__RendererEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689199);
      DebugCubeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689200);
      DebugCubeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689201);
      DebugCubeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689202);
      DebugCubeSystem.NativeMethodInfoPtr_SetGreaterZOpacity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689203);
      DebugCubeSystem.NativeMethodInfoPtr_SetLocalToWorld_Public_Void_byref_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689204);
      DebugCubeSystem.NativeMethodInfoPtr_DrawCubes_Public_Void_byref_CubeRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689205);
      DebugCubeSystem.NativeMethodInfoPtr_ResizeBufferAndSetData_Private_Static_Void_byref_ComputeBuffer_byref_NativeArray_1_T_byref_Int32_byref_Int32_ComputeBufferType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689206);
      DebugCubeSystem.NativeMethodInfoPtr_UpdateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689207);
      DebugCubeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689208);
      DebugCubeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr, 100689209);
    }

    public DebugCubeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int _CubeRenderLayer
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeRenderLayer));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeRenderLayer)) = value;
      }
    }

    public unsafe NativeArray<float4x4> _CubeMatrices
    {
      get
      {
        return *(NativeArray<float4x4>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeMatrices));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeMatrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<float4> _CubeColors
    {
      get
      {
        return *(NativeArray<float4>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeColors));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeColors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<float4x4> _RequestedCubeMatrices
    {
      get
      {
        return *(NativeList<float4x4>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__RequestedCubeMatrices));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__RequestedCubeMatrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<float4x4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<float4> _RequestedCubeColors
    {
      get
      {
        return *(NativeList<float4>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__RequestedCubeColors));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__RequestedCubeColors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<float4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float4x4 _DebugLocalToWorld
    {
      get
      {
        return *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__DebugLocalToWorld));
      }
      [param: In] set
      {
        *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__DebugLocalToWorld)) = value;
      }
    }

    public unsafe float4x4 _DebugWorldToLocal
    {
      get
      {
        return *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__DebugWorldToLocal));
      }
      [param: In] set
      {
        *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__DebugWorldToLocal)) = value;
      }
    }

    public unsafe ComputeBuffer _MatricesBuffer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__MatricesBuffer));
        return pointer == System.IntPtr.Zero ? (ComputeBuffer) null : new ComputeBuffer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__MatricesBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ComputeBuffer _ColorsBuffer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__ColorsBuffer));
        return pointer == System.IntPtr.Zero ? (ComputeBuffer) null : new ComputeBuffer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__ColorsBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ComputeBuffer _IndirectArgsBuffer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__IndirectArgsBuffer));
        return pointer == System.IntPtr.Zero ? (ComputeBuffer) null : new ComputeBuffer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__IndirectArgsBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<uint> _IndirectArgs
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__IndirectArgs));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<uint>) null : new Il2CppStructArray<uint>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__IndirectArgs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPropertyBlock _MaterialPropertyBlock
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__MaterialPropertyBlock));
        return pointer == System.IntPtr.Zero ? (MaterialPropertyBlock) null : new MaterialPropertyBlock(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__MaterialPropertyBlock), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material _CubeMaterial
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeMaterial));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _GreaterZOpacity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__GreaterZOpacity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__GreaterZOpacity)) = value;
      }
    }

    public unsafe Bounds _InfiniteBounds
    {
      get
      {
        return *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__InfiniteBounds));
      }
      [param: In] set
      {
        *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__InfiniteBounds)) = value;
      }
    }

    public unsafe CubeDebugSettings _CubeDebugSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeDebugSettings));
        return pointer == System.IntPtr.Zero ? (CubeDebugSettings) null : new CubeDebugSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeDebugSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomPassVolume _CubeRendererCustomPassVolume
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeRendererCustomPassVolume));
        return pointer == System.IntPtr.Zero ? (CustomPassVolume) null : new CustomPassVolume(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__CubeRendererCustomPassVolume), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _HasDrawnRequested
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__HasDrawnRequested));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCubeSystem.NativeFieldInfoPtr__HasDrawnRequested)) = value;
      }
    }

    private sealed class MethodInfoStoreGeneric_ResizeBufferAndSetData_Private_Static_Void_byref_ComputeBuffer_byref_NativeArray_1_T_byref_Int32_byref_Int32_ComputeBufferType_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(DebugCubeSystem.NativeMethodInfoPtr_ResizeBufferAndSetData_Private_Static_Void_byref_ComputeBuffer_byref_NativeArray_1_T_byref_Int32_byref_Int32_ComputeBufferType_0, Il2CppClassPointerStore<DebugCubeSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
