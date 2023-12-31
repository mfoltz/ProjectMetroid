// Decompiled with JetBrains decompiler
// Type: DebugExtension
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using Unity.Mathematics;
using Unity.Physics;
using UnityEngine;

#nullable disable
public static class DebugExtension : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugPoint_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugPoint_Public_Static_Void_Vector3_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugBounds_Public_Static_Void_Bounds_Color_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugBounds_Public_Static_Void_Bounds_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Transform_Vector3_Color_Vector3_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Transform_Vector3_Vector3_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Matrix4x4_Vector3_Color_Vector3_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Matrix4x4_Vector3_Vector3_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugStar_Public_Static_Void_Vector3_Color_Single_Single_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCapsule2D_Public_Static_Void_Vector3_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugWireSphere_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugWireSphere_Public_Static_Void_Vector3_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCylinder_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCylinder_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCone2d_Public_Static_Void_float3_float3_Single_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugArrow_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugLineArrow_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugArrow_Public_Static_Void_Vector3_Vector3_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCapsule_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawThickLine_Public_Static_Void_Vector3_Vector3_Single_Color_Single_Boolean_ThickLineStyle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateThickLine_Public_Static_Void_Vector3_Vector3_Single_ThickLineStyle_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugCapsule_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugSquare_Public_Static_Void_float3_Color_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugAABB_Public_Static_Void_float3_float3_Color_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugTile_Public_Static_Void_int2_Single_Color_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugBoundsMinMax_Public_Static_Void_BoundsMinMax_Single_Color_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugWireCube_Public_Static_Void_Vector3_Quaternion_Vector3_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DebugWireAabb_Public_Static_Void_Aabb_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawPoint_Public_Static_Void_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawPoint_Public_Static_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawBoundsMinMax_Public_Static_Void_BoundsMinMax_Single_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Transform_Vector3_Color_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Transform_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Matrix4x4_Vector3_Color_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Matrix4x4_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCylinder_Public_Static_Void_Vector3_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCylinder_Public_Static_Void_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawArrow_Public_Static_Void_Vector3_Vector3_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawArrow_Public_Static_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCapsule_Public_Static_Void_Vector3_Vector3_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawCapsule_Public_Static_Void_Vector3_Vector3_Single_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715164, XrefRangeEnd = 715179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugPoint(
    Vector3 position,
    Color color,
    float scale = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugPoint_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugPoint(
    Vector3 position,
    float scale = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugPoint_Public_Static_Void_Vector3_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715179, XrefRangeEnd = 715198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugBounds(
    Bounds bounds,
    Color color,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &bounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugBounds_Public_Static_Void_Bounds_Color_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugBounds(Bounds bounds, float duration = 0.0f, bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &bounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugBounds_Public_Static_Void_Bounds_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715198, XrefRangeEnd = 715221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugLocalCube(
    Transform transform,
    Vector3 size,
    Color color,
    Vector3 center = default (Vector3),
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Transform_Vector3_Color_Vector3_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugLocalCube(
    Transform transform,
    Vector3 size,
    Vector3 center = default (Vector3),
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Transform_Vector3_Vector3_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715221, XrefRangeEnd = 715247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugLocalCube(
    Matrix4x4 space,
    Vector3 size,
    Color color,
    Vector3 center = default (Vector3),
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &space;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Matrix4x4_Vector3_Color_Vector3_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugLocalCube(
    Matrix4x4 space,
    Vector3 size,
    Vector3 center = default (Vector3),
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &space;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Matrix4x4_Vector3_Vector3_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715247, XrefRangeEnd = 715274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCircle(
    Vector3 position,
    Vector3 up,
    Color color,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715274, XrefRangeEnd = 715283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugStar(
    Vector3 position,
    Color color,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true,
    int numOfLines = 6)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &numOfLines;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugStar_Public_Static_Void_Vector3_Color_Single_Single_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715283, XrefRangeEnd = 715292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCapsule2D(Vector3 start, Vector3 end, Color color, float radius)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCapsule2D_Public_Static_Void_Vector3_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCircle(
    Vector3 position,
    Color color,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCircle(
    Vector3 position,
    Vector3 up,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCircle(
    Vector3 position,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715292, XrefRangeEnd = 715302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugWireSphere(
    Vector3 position,
    Color color,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugWireSphere_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugWireSphere(
    Vector3 position,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugWireSphere_Public_Static_Void_Vector3_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715302, XrefRangeEnd = 715317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCylinder(
    Vector3 start,
    Vector3 end,
    Color color,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCylinder_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCylinder(
    Vector3 start,
    Vector3 end,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCylinder_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715317, XrefRangeEnd = 715340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCone(
    Vector3 position,
    Vector3 direction,
    Color color,
    float angle = 45f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715340, XrefRangeEnd = 715400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCone2d(
    float3 position,
    float3 direction,
    float radius,
    Color color,
    float angle,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCone2d_Public_Static_Void_float3_float3_Single_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCone(
    Vector3 position,
    Vector3 direction,
    float angle = 45f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCone(
    Vector3 position,
    Color color,
    float angle = 45f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCone(
    Vector3 position,
    float angle = 45f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715400, XrefRangeEnd = 715404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugArrow(
    Vector3 position,
    Vector3 direction,
    Color color,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugArrow_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715404, XrefRangeEnd = 715410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugLineArrow(
    Vector3 from,
    Vector3 to,
    Color color,
    float duration = 0.0f,
    bool depthTest = true,
    float size = 1f,
    int cones = 1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &cones;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugLineArrow_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugArrow(
    Vector3 position,
    Vector3 direction,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugArrow_Public_Static_Void_Vector3_Vector3_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715410, XrefRangeEnd = 715451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCapsule(
    Vector3 start,
    Vector3 end,
    Color color,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCapsule_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 715457, RefRangeEnd = 715459, XrefRangeStart = 715451, XrefRangeEnd = 715457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawThickLine(
    Vector3 start,
    Vector3 end,
    float width,
    Color color,
    float duration,
    bool depthTest,
    DebugExtension.ThickLineStyle style = DebugExtension.ThickLineStyle.Line)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &style;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawThickLine_Public_Static_Void_Vector3_Vector3_Single_Color_Single_Boolean_ThickLineStyle_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 715464, RefRangeEnd = 715465, XrefRangeStart = 715459, XrefRangeEnd = 715464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CalculateThickLine(
    Vector3 start,
    Vector3 end,
    float width,
    DebugExtension.ThickLineStyle style,
    out Vector3 line1Point1,
    out Vector3 line1Point2,
    out Vector3 line2Point1,
    out Vector3 line2Point2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &style;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref line1Point1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref line1Point2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref line2Point1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref line2Point2;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_CalculateThickLine_Public_Static_Void_Vector3_Vector3_Single_ThickLineStyle_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugCapsule(
    Vector3 start,
    Vector3 end,
    float radius = 1f,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugCapsule_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715465, XrefRangeEnd = 715480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugSquare(
    float3 worldPos,
    Color color,
    float radius,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &worldPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugSquare_Public_Static_Void_float3_Color_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715480, XrefRangeEnd = 715519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugAABB(
    float3 minWorldPos,
    float3 maxWorldPos,
    Color color,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &minWorldPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxWorldPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugAABB_Public_Static_Void_float3_float3_Color_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715519, XrefRangeEnd = 715539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugTile(
    int2 worldTile,
    float y,
    Color color,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &worldTile;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugTile_Public_Static_Void_int2_Single_Color_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715539, XrefRangeEnd = 715560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugBoundsMinMax(
    BoundsMinMax bounds,
    float y,
    Color color,
    float duration = 0.0f,
    bool depthTest = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &bounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthTest;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugBoundsMinMax_Public_Static_Void_BoundsMinMax_Single_Color_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715560, XrefRangeEnd = 715584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugWireCube(Vector3 pos, Quaternion rot, Vector3 scale, Color c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugWireCube_Public_Static_Void_Vector3_Quaternion_Vector3_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715584, XrefRangeEnd = 715599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DebugWireAabb(Aabb aabb, Color c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aabb;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DebugWireAabb_Public_Static_Void_Aabb_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715599, XrefRangeEnd = 715611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawPoint(Vector3 position, Color color, float scale = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawPoint_Public_Static_Void_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawPoint(Vector3 position, float scale = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawPoint_Public_Static_Void_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715611, XrefRangeEnd = 715630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawBounds(Bounds bounds, Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &bounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawBounds(Bounds bounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &bounds;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715630, XrefRangeEnd = 715651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawBoundsMinMax(BoundsMinMax bounds, float y, Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &bounds;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawBoundsMinMax_Public_Static_Void_BoundsMinMax_Single_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715651, XrefRangeEnd = 715674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLocalCube(
    Transform transform,
    Vector3 size,
    Color color,
    Vector3 center = default (Vector3))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Transform_Vector3_Color_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLocalCube(Transform transform, Vector3 size, Vector3 center = default (Vector3))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Transform_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715674, XrefRangeEnd = 715697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLocalCube(
    Matrix4x4 space,
    Vector3 size,
    Color color,
    Vector3 center = default (Vector3))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &space;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Matrix4x4_Vector3_Color_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawLocalCube(Matrix4x4 space, Vector3 size, Vector3 center = default (Vector3))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &space;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &center;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Matrix4x4_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715697, XrefRangeEnd = 715728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCircle(Vector3 position, Vector3 up, Color color, float radius = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCircle(Vector3 position, Color color, float radius = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCircle(Vector3 position, Vector3 up, float radius = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &up;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCircle(Vector3 position, float radius = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715728, XrefRangeEnd = 715743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCylinder(Vector3 start, Vector3 end, Color color, float radius = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCylinder_Public_Static_Void_Vector3_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCylinder(Vector3 start, Vector3 end, float radius = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCylinder_Public_Static_Void_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715743, XrefRangeEnd = 715766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCone(
    Vector3 position,
    Vector3 direction,
    Color color,
    float angle = 45f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCone(Vector3 position, Vector3 direction, float angle = 45f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCone(Vector3 position, Color color, float angle = 45f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCone(Vector3 position, float angle = 45f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &angle;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715766, XrefRangeEnd = 715770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawArrow(Vector3 position, Vector3 direction, Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawArrow_Public_Static_Void_Vector3_Vector3_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawArrow(Vector3 position, Vector3 direction)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawArrow_Public_Static_Void_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715770, XrefRangeEnd = 715809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCapsule(Vector3 start, Vector3 end, Color color, float radius = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCapsule_Public_Static_Void_Vector3_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawCapsule(Vector3 start, Vector3 end, float radius = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugExtension.NativeMethodInfoPtr_DrawCapsule_Public_Static_Void_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DebugExtension()
  {
    Il2CppClassPointerStore<DebugExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (DebugExtension));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr);
    DebugExtension.NativeMethodInfoPtr_DebugPoint_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663363);
    DebugExtension.NativeMethodInfoPtr_DebugPoint_Public_Static_Void_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663364);
    DebugExtension.NativeMethodInfoPtr_DebugBounds_Public_Static_Void_Bounds_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663365);
    DebugExtension.NativeMethodInfoPtr_DebugBounds_Public_Static_Void_Bounds_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663366);
    DebugExtension.NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Transform_Vector3_Color_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663367);
    DebugExtension.NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Transform_Vector3_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663368);
    DebugExtension.NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Matrix4x4_Vector3_Color_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663369);
    DebugExtension.NativeMethodInfoPtr_DebugLocalCube_Public_Static_Void_Matrix4x4_Vector3_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663370);
    DebugExtension.NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663371);
    DebugExtension.NativeMethodInfoPtr_DebugStar_Public_Static_Void_Vector3_Color_Single_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663372);
    DebugExtension.NativeMethodInfoPtr_DebugCapsule2D_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663373);
    DebugExtension.NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663374);
    DebugExtension.NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663375);
    DebugExtension.NativeMethodInfoPtr_DebugCircle_Public_Static_Void_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663376);
    DebugExtension.NativeMethodInfoPtr_DebugWireSphere_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663377);
    DebugExtension.NativeMethodInfoPtr_DebugWireSphere_Public_Static_Void_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663378);
    DebugExtension.NativeMethodInfoPtr_DebugCylinder_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663379);
    DebugExtension.NativeMethodInfoPtr_DebugCylinder_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663380);
    DebugExtension.NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663381);
    DebugExtension.NativeMethodInfoPtr_DebugCone2d_Public_Static_Void_float3_float3_Single_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663382);
    DebugExtension.NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663383);
    DebugExtension.NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663384);
    DebugExtension.NativeMethodInfoPtr_DebugCone_Public_Static_Void_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663385);
    DebugExtension.NativeMethodInfoPtr_DebugArrow_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663386);
    DebugExtension.NativeMethodInfoPtr_DebugLineArrow_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663387);
    DebugExtension.NativeMethodInfoPtr_DebugArrow_Public_Static_Void_Vector3_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663388);
    DebugExtension.NativeMethodInfoPtr_DebugCapsule_Public_Static_Void_Vector3_Vector3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663389);
    DebugExtension.NativeMethodInfoPtr_DrawThickLine_Public_Static_Void_Vector3_Vector3_Single_Color_Single_Boolean_ThickLineStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663390);
    DebugExtension.NativeMethodInfoPtr_CalculateThickLine_Public_Static_Void_Vector3_Vector3_Single_ThickLineStyle_byref_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663391);
    DebugExtension.NativeMethodInfoPtr_DebugCapsule_Public_Static_Void_Vector3_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663392);
    DebugExtension.NativeMethodInfoPtr_DebugSquare_Public_Static_Void_float3_Color_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663393);
    DebugExtension.NativeMethodInfoPtr_DebugAABB_Public_Static_Void_float3_float3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663394);
    DebugExtension.NativeMethodInfoPtr_DebugTile_Public_Static_Void_int2_Single_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663395);
    DebugExtension.NativeMethodInfoPtr_DebugBoundsMinMax_Public_Static_Void_BoundsMinMax_Single_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663396);
    DebugExtension.NativeMethodInfoPtr_DebugWireCube_Public_Static_Void_Vector3_Quaternion_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663397);
    DebugExtension.NativeMethodInfoPtr_DebugWireAabb_Public_Static_Void_Aabb_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663398);
    DebugExtension.NativeMethodInfoPtr_DrawPoint_Public_Static_Void_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663399);
    DebugExtension.NativeMethodInfoPtr_DrawPoint_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663400);
    DebugExtension.NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663401);
    DebugExtension.NativeMethodInfoPtr_DrawBounds_Public_Static_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663402);
    DebugExtension.NativeMethodInfoPtr_DrawBoundsMinMax_Public_Static_Void_BoundsMinMax_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663403);
    DebugExtension.NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Transform_Vector3_Color_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663404);
    DebugExtension.NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Transform_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663405);
    DebugExtension.NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Matrix4x4_Vector3_Color_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663406);
    DebugExtension.NativeMethodInfoPtr_DrawLocalCube_Public_Static_Void_Matrix4x4_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663407);
    DebugExtension.NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663408);
    DebugExtension.NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663409);
    DebugExtension.NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663410);
    DebugExtension.NativeMethodInfoPtr_DrawCircle_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663411);
    DebugExtension.NativeMethodInfoPtr_DrawCylinder_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663412);
    DebugExtension.NativeMethodInfoPtr_DrawCylinder_Public_Static_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663413);
    DebugExtension.NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663414);
    DebugExtension.NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663415);
    DebugExtension.NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663416);
    DebugExtension.NativeMethodInfoPtr_DrawCone_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663417);
    DebugExtension.NativeMethodInfoPtr_DrawArrow_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663418);
    DebugExtension.NativeMethodInfoPtr_DrawArrow_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663419);
    DebugExtension.NativeMethodInfoPtr_DrawCapsule_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663420);
    DebugExtension.NativeMethodInfoPtr_DrawCapsule_Public_Static_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugExtension>.NativeClassPtr, 100663421);
  }

  public DebugExtension(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public enum ThickLineStyle
  {
    Line,
    Cross,
  }
}
