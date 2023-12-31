// Decompiled with JetBrains decompiler
// Type: CameraMath
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared.Mathematics;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
public static class CameraMath : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Ray_byref_float4x4_byref_float4x4_float3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_byref_float4x4_byref_float4x4_float2_float3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToViewPortPoint_Public_Static_float3_float2_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float2_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_float3_float2_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float2_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateViewMatrix_Public_Static_float4x4_float3_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProjectionSpaceToUnityViewPort_Private_Static_float2_float2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityViewPortSpaceToProjection_Private_Static_float2_float2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizePoint_Private_Static_float3_float4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnNormalizePoint_Private_Static_float3_float4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransformPoint_Private_Static_float4_byref_float4x4_float4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LookRotationExtended_Public_Static_quaternion_float3_float3_float3_float3_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716936, RefRangeEnd = 716938, XrefRangeStart = 716931, XrefRangeEnd = 716936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Ray ViewportPointToRay(
    [In] ref float4x4 viewMatrix,
    [In] ref float4x4 projectionMatrix,
    float3 position,
    float nearClipPlane,
    float farClipPlane)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nearClipPlane;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &farClipPlane;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Ray_byref_float4x4_byref_float4x4_float3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Ray*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 716944, RefRangeEnd = 716948, XrefRangeStart = 716938, XrefRangeEnd = 716944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Ray ScreenPointToRay(
    [In] ref float4x4 viewMatrix,
    [In] ref float4x4 projectionMatrix,
    float2 resolution,
    float3 position,
    float nearClipPlane,
    float farClipPlane)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &nearClipPlane;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &farClipPlane;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_byref_float4x4_byref_float4x4_float2_float3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Ray*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716948, RefRangeEnd = 716950, XrefRangeStart = 716948, XrefRangeEnd = 716948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 ScreenToViewPortPoint(float2 resolution, float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &resolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_ScreenToViewPortPoint_Public_Static_float3_float2_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716951, RefRangeEnd = 716953, XrefRangeStart = 716950, XrefRangeEnd = 716951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 ScreenToWorldPoint(
    [In] ref float4x4 viewMatrix,
    [In] ref float4x4 projectionMatrix,
    float2 resolution,
    float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float2_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716953, RefRangeEnd = 716955, XrefRangeStart = 716953, XrefRangeEnd = 716953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 ViewportToScreenPoint(float2 screenResolution, float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &screenResolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_float3_float2_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716957, RefRangeEnd = 716959, XrefRangeStart = 716955, XrefRangeEnd = 716957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 WorldToScreenPoint(
    [In] ref float4x4 viewMatrix,
    [In] ref float4x4 projectionMatrix,
    float2 resolution,
    float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float2_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 716963, RefRangeEnd = 716970, XrefRangeStart = 716959, XrefRangeEnd = 716963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 ViewportToWorldPoint(
    [In] ref float4x4 viewMatrix,
    [In] ref float4x4 projectionMatrix,
    float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716972, RefRangeEnd = 716974, XrefRangeStart = 716970, XrefRangeEnd = 716972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 WorldToViewportPoint(
    [In] ref float4x4 viewMatrix,
    [In] ref float4x4 projectionMatrix,
    float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716979, RefRangeEnd = 716981, XrefRangeStart = 716974, XrefRangeEnd = 716979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float4x4 CreateViewMatrix(float3 cameraPosition, quaternion cameraRotation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &cameraPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cameraRotation;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_CreateViewMatrix_Public_Static_float4x4_float3_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float4x4*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float2 ProjectionSpaceToUnityViewPort(float2 projSpace)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &projSpace;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_ProjectionSpaceToUnityViewPort_Private_Static_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float2 UnityViewPortSpaceToProjection(float2 viewPortSpace)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &viewPortSpace;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_UnityViewPortSpaceToProjection_Private_Static_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float3 NormalizePoint(float4 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &point;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_NormalizePoint_Private_Static_float3_float4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float3 UnNormalizePoint(float4 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &point;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_UnNormalizePoint_Private_Static_float3_float4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 716981, RefRangeEnd = 716988, XrefRangeStart = 716981, XrefRangeEnd = 716981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float4 TransformPoint([In] ref float4x4 transformationMatrix, float4 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref transformationMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &point;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_TransformPoint_Private_Static_float4_byref_float4x4_float4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float4*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716988, XrefRangeEnd = 716993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe quaternion LookRotationExtended(
    float3 alignWithVector,
    float3 alignWithNormal,
    float3 customForward,
    float3 customUp)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &alignWithVector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &alignWithNormal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &customForward;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &customUp;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMath.NativeMethodInfoPtr_LookRotationExtended_Public_Static_quaternion_float3_float3_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(quaternion*) IL2CPP.il2cpp_object_unbox(num);
  }

  static CameraMath()
  {
    Il2CppClassPointerStore<CameraMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (CameraMath));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMath>.NativeClassPtr);
    CameraMath.NativeMethodInfoPtr_ViewportPointToRay_Public_Static_Ray_byref_float4x4_byref_float4x4_float3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663463);
    CameraMath.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_byref_float4x4_byref_float4x4_float2_float3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663464);
    CameraMath.NativeMethodInfoPtr_ScreenToViewPortPoint_Public_Static_float3_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663465);
    CameraMath.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663466);
    CameraMath.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Static_float3_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663467);
    CameraMath.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663468);
    CameraMath.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663469);
    CameraMath.NativeMethodInfoPtr_WorldToViewportPoint_Public_Static_float3_byref_float4x4_byref_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663470);
    CameraMath.NativeMethodInfoPtr_CreateViewMatrix_Public_Static_float4x4_float3_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663471);
    CameraMath.NativeMethodInfoPtr_ProjectionSpaceToUnityViewPort_Private_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663472);
    CameraMath.NativeMethodInfoPtr_UnityViewPortSpaceToProjection_Private_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663473);
    CameraMath.NativeMethodInfoPtr_NormalizePoint_Private_Static_float3_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663474);
    CameraMath.NativeMethodInfoPtr_UnNormalizePoint_Private_Static_float3_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663475);
    CameraMath.NativeMethodInfoPtr_TransformPoint_Private_Static_float4_byref_float4x4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663476);
    CameraMath.NativeMethodInfoPtr_LookRotationExtended_Public_Static_quaternion_float3_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMath>.NativeClassPtr, 100663477);
  }

  public CameraMath(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
