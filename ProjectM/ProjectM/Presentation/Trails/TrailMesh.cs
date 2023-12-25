// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.TrailMesh
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
namespace ProjectM.Presentation.Trails
{
  public class TrailMesh : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__Mesh;
    private static readonly IntPtr NativeFieldInfoPtr__Vertices;
    private static readonly IntPtr NativeFieldInfoPtr__Normals;
    private static readonly IntPtr NativeFieldInfoPtr__UV;
    private static readonly IntPtr NativeFieldInfoPtr__UV2;
    private static readonly IntPtr NativeFieldInfoPtr__Color;
    private static readonly IntPtr NativeFieldInfoPtr__Quads;
    private static readonly IntPtr NativeFieldInfoPtr__MaxParticleCount;
    private static readonly IntPtr NativeFieldInfoPtr__MeshType;
    private static readonly IntPtr NativeFieldInfoPtr_Native;
    private static readonly IntPtr NativeFieldInfoPtr__MadeQuads;
    private static readonly IntPtr NativeMethodInfoPtr_INTERNAL_CopyUV_Public_Static_Void_UVRect_Int32_IntPtr_0;
    private static readonly IntPtr NativeMethodInfoPtr_INTERNAL_CopyColor_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0;
    private static readonly IntPtr NativeMethodInfoPtr_INTERNAL_CopyVertex_Public_Static_Bounds_IntPtr_Int32_Int32_Int32_Int32_IntPtr_0;
    private static readonly IntPtr NativeMethodInfoPtr_INTERNAL_CopyVertexFaceCamera_Public_Static_Bounds_IntPtr_Int32_Int32_Int32_Int32_IntPtr_IntPtr_0;
    private static readonly IntPtr NativeMethodInfoPtr_INTERNAL_CopyUVFaceCamera_Public_Static_Void_UVRect_Int32_IntPtr_0;
    private static readonly IntPtr NativeMethodInfoPtr_INTERNAL_CopyUVLifetimeFaceCamera_Public_Static_Void_IntPtr_Int32_Int32_Int32_UVRect_Single_Single_IntPtr_0;
    private static readonly IntPtr NativeMethodInfoPtr_INTERNAL_CopyColorFaceCamera_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0;
    private static readonly IntPtr NativeMethodInfoPtr_INTERNAL_CopyColorFaceCamera2_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MaxParticleCount_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_MeshType_Public_get_MeshType_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_MeshType_0;
    private static readonly IntPtr NativeMethodInfoPtr_CalculateUVRect_Private_Static_UVRect_Single_Single_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_ResetIndices_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateMesh_Public_Void_Single_Single_byref_ParticleArrayData_byref_EmitterData_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateTrailFaceCameraMesh_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateTrailFaceCameraMeshNative_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateTrailMesh_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateTrailMeshNative_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114080, XrefRangeEnd = 1114082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void INTERNAL_CopyUV(UVRect uvRect, int particleCount, IntPtr uvBuffer)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &uvRect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &uvBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyUV_Public_Static_Void_UVRect_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114082, XrefRangeEnd = 1114084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void INTERNAL_CopyColor(
      IntPtr ringBuffer,
      int startIndex,
      int ringBufferSize,
      int particleCount,
      IntPtr colorBuffer)
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &ringBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &ringBufferSize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &colorBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyColor_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114084, XrefRangeEnd = 1114086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Bounds INTERNAL_CopyVertex(
      IntPtr ringBuffer,
      int startIndex,
      int ringBufferSize,
      int particleCount,
      int maxParticleCount,
      IntPtr vertexBuffer)
    {
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) &ringBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &ringBufferSize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &maxParticleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &vertexBuffer;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyVertex_Public_Static_Bounds_IntPtr_Int32_Int32_Int32_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114086, XrefRangeEnd = 1114088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Bounds INTERNAL_CopyVertexFaceCamera(
      IntPtr ringBuffer,
      int startIndex,
      int ringBufferSize,
      int particleCount,
      int maxParticleCount,
      IntPtr vertexBuffer,
      IntPtr uvBuffer)
    {
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = (IntPtr) &ringBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &ringBufferSize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &maxParticleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &vertexBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &uvBuffer;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyVertexFaceCamera_Public_Static_Bounds_IntPtr_Int32_Int32_Int32_Int32_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114088, XrefRangeEnd = 1114090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void INTERNAL_CopyUVFaceCamera(
      UVRect uvRect,
      int particleCount,
      IntPtr uvBuffer)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &uvRect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &uvBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyUVFaceCamera_Public_Static_Void_UVRect_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114090, XrefRangeEnd = 1114092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void INTERNAL_CopyUVLifetimeFaceCamera(
      IntPtr particleBuffer,
      int startIndex,
      int ringBufferSize,
      int particleCount,
      UVRect uvRect,
      float lifetime,
      float time,
      IntPtr uvBuffer)
    {
      IntPtr* numPtr = stackalloc IntPtr[8];
      numPtr[0] = (IntPtr) &particleBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &ringBufferSize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &uvRect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &lifetime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &uvBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyUVLifetimeFaceCamera_Public_Static_Void_IntPtr_Int32_Int32_Int32_UVRect_Single_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114092, XrefRangeEnd = 1114094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void INTERNAL_CopyColorFaceCamera(
      IntPtr ringBuffer,
      int startIndex,
      int ringBufferSize,
      int particleCount,
      IntPtr colorBuffer)
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &ringBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &ringBufferSize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &colorBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyColorFaceCamera_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114094, XrefRangeEnd = 1114096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void INTERNAL_CopyColorFaceCamera2(
      IntPtr particleBuffer,
      int startIndex,
      int ringBufferSize,
      int particleCount,
      IntPtr colorBuffer)
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &particleBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &ringBufferSize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &colorBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyColorFaceCamera2_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe int MaxParticleCount
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 32748, RefRangeEnd = 32752, XrefRangeStart = 32748, XrefRangeEnd = 32752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_get_MaxParticleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe MeshType MeshType
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 40943, RefRangeEnd = 40949, XrefRangeStart = 40943, XrefRangeEnd = 40949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_get_MeshType_Public_get_MeshType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MeshType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1114143, RefRangeEnd = 1114144, XrefRangeStart = 1114096, XrefRangeEnd = 1114143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(int particleCount, MeshType meshType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &particleCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &meshType;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_Initialize_Public_Void_Int32_MeshType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114144, XrefRangeEnd = 1114147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe UVRect CalculateUVRect(
      float age,
      float cyclesPerSecond,
      int tilesU,
      int tilesV)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &age;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cyclesPerSecond;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &tilesU;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &tilesV;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_CalculateUVRect_Private_Static_UVRect_Single_Single_Int32_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UVRect*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void ResetIndices()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_ResetIndices_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114147, XrefRangeEnd = 1114161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateMesh(
      float time,
      float timeStarted,
      ref ParticleArrayData particles,
      ref EmitterData emitterData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &timeStarted;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) particles);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) emitterData);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_UpdateMesh_Public_Void_Single_Single_byref_ParticleArrayData_byref_EmitterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1114233, RefRangeEnd = 1114234, XrefRangeStart = 1114161, XrefRangeEnd = 1114233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTrailFaceCameraMesh(
      float time,
      ref ParticleArrayData particles,
      UVMode uvMode,
      UVRect uvRect,
      float lifetime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) particles);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &uvMode;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &uvRect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &lifetime;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_UpdateTrailFaceCameraMesh_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114234, XrefRangeEnd = 1114285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTrailFaceCameraMeshNative(
      float time,
      ref ParticleArrayData particles,
      UVMode uvMode,
      UVRect uvRect,
      float lifetime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) particles);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &uvMode;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &uvRect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &lifetime;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_UpdateTrailFaceCameraMeshNative_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114285, XrefRangeEnd = 1114355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTrailMesh(
      float time,
      ref ParticleArrayData particles,
      UVMode uvMode,
      UVRect uvRect,
      float lifetime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) particles);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &uvMode;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &uvRect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &lifetime;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_UpdateTrailMesh_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114355, XrefRangeEnd = 1114389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTrailMeshNative(
      float time,
      ref ParticleArrayData particles,
      UVMode uvMode,
      UVRect uvRect,
      float lifetime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &time;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) particles);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &uvMode;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &uvRect;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &lifetime;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr_UpdateTrailMeshNative_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrailMesh()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TrailMesh()
    {
      Il2CppClassPointerStore<TrailMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (TrailMesh));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr);
      TrailMesh.NativeFieldInfoPtr__Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_Mesh));
      TrailMesh.NativeFieldInfoPtr__Vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_Vertices));
      TrailMesh.NativeFieldInfoPtr__Normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_Normals));
      TrailMesh.NativeFieldInfoPtr__UV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_UV));
      TrailMesh.NativeFieldInfoPtr__UV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_UV2));
      TrailMesh.NativeFieldInfoPtr__Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_Color));
      TrailMesh.NativeFieldInfoPtr__Quads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_Quads));
      TrailMesh.NativeFieldInfoPtr__MaxParticleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_MaxParticleCount));
      TrailMesh.NativeFieldInfoPtr__MeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_MeshType));
      TrailMesh.NativeFieldInfoPtr_Native = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (Native));
      TrailMesh.NativeFieldInfoPtr__MadeQuads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, nameof (_MadeQuads));
      TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyUV_Public_Static_Void_UVRect_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688183);
      TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyColor_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688184);
      TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyVertex_Public_Static_Bounds_IntPtr_Int32_Int32_Int32_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688185);
      TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyVertexFaceCamera_Public_Static_Bounds_IntPtr_Int32_Int32_Int32_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688186);
      TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyUVFaceCamera_Public_Static_Void_UVRect_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688187);
      TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyUVLifetimeFaceCamera_Public_Static_Void_IntPtr_Int32_Int32_Int32_UVRect_Single_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688188);
      TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyColorFaceCamera_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688189);
      TrailMesh.NativeMethodInfoPtr_INTERNAL_CopyColorFaceCamera2_Public_Static_Void_IntPtr_Int32_Int32_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688190);
      TrailMesh.NativeMethodInfoPtr_get_MaxParticleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688191);
      TrailMesh.NativeMethodInfoPtr_get_MeshType_Public_get_MeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688192);
      TrailMesh.NativeMethodInfoPtr_Initialize_Public_Void_Int32_MeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688193);
      TrailMesh.NativeMethodInfoPtr_CalculateUVRect_Private_Static_UVRect_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688194);
      TrailMesh.NativeMethodInfoPtr_ResetIndices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688195);
      TrailMesh.NativeMethodInfoPtr_UpdateMesh_Public_Void_Single_Single_byref_ParticleArrayData_byref_EmitterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688196);
      TrailMesh.NativeMethodInfoPtr_UpdateTrailFaceCameraMesh_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688197);
      TrailMesh.NativeMethodInfoPtr_UpdateTrailFaceCameraMeshNative_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688198);
      TrailMesh.NativeMethodInfoPtr_UpdateTrailMesh_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688199);
      TrailMesh.NativeMethodInfoPtr_UpdateTrailMeshNative_Private_Void_Single_byref_ParticleArrayData_UVMode_UVRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688200);
      TrailMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailMesh>.NativeClassPtr, 100688201);
    }

    public TrailMesh(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Mesh _Mesh
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Mesh));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Mesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Vector3> _Vertices
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Vertices));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Vertices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Vector3> _Normals
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Normals));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Normals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Vector2> _UV
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__UV));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Vector2>) null : new Il2CppStructArray<Vector2>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__UV), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Vector2> _UV2
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__UV2));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Vector2>) null : new Il2CppStructArray<Vector2>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__UV2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Color32> _Color
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Color));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Color32>) null : new Il2CppStructArray<Color32>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Color), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<int> _Quads
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Quads));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__Quads), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _MaxParticleCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__MaxParticleCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__MaxParticleCount)) = value;
      }
    }

    public unsafe MeshType _MeshType
    {
      get
      {
        return *(MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__MeshType));
      }
      [param: In] set
      {
        *(MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__MeshType)) = value;
      }
    }

    public static unsafe bool Native
    {
      get
      {
        bool native;
        IL2CPP.il2cpp_field_static_get_value(TrailMesh.NativeFieldInfoPtr_Native, (void*) &native);
        return native;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TrailMesh.NativeFieldInfoPtr_Native, (void*) &value);
      }
    }

    public unsafe bool _MadeQuads
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__MadeQuads));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailMesh.NativeFieldInfoPtr__MadeQuads)) = value;
      }
    }
  }
}
