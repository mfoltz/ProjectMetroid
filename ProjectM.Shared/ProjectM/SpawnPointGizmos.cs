// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnPointGizmos
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class SpawnPointGizmos : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawSpawnPoint_Public_Static_Void_Transform_Vector3_Quaternion_Color_Mesh_Single_Boolean_Nullable_Unboxed_1_Quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawLimitedSpawnPoint_Public_Static_Void_Transform_Vector3_Quaternion_Color_Boolean_Nullable_Unboxed_1_Quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawSplineNode_Public_Static_Void_Vector3_Color_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawPathNode_Public_Static_Void_Transform_Color_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawPathNode_Public_Static_Void_Matrix4x4_Color_Boolean_Single_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765168, RefRangeEnd = 765169, XrefRangeStart = 765124, XrefRangeEnd = 765168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawSpawnPoint(
      Transform transform,
      Vector3 localPosition,
      Quaternion localRotation,
      Color color,
      Mesh optionalMesh,
      float potionalMeshScale,
      bool wireFrame = false,
      Nullable_Unboxed<Quaternion> overridenRotation = default (Nullable_Unboxed<Quaternion>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) optionalMesh);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &potionalMeshScale;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &wireFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &overridenRotation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPointGizmos.NativeMethodInfoPtr_DrawSpawnPoint_Public_Static_Void_Transform_Vector3_Quaternion_Color_Mesh_Single_Boolean_Nullable_Unboxed_1_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765169, XrefRangeEnd = 765189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawLimitedSpawnPoint(
      Transform transform,
      Vector3 localPosition,
      Quaternion localRotation,
      Color color,
      bool wireFrame = false,
      Nullable_Unboxed<Quaternion> overridenRotation = default (Nullable_Unboxed<Quaternion>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &wireFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &overridenRotation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPointGizmos.NativeMethodInfoPtr_DrawLimitedSpawnPoint_Public_Static_Void_Transform_Vector3_Quaternion_Color_Boolean_Nullable_Unboxed_1_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765189, XrefRangeEnd = 765193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawSplineNode(Vector3 position, Color color, float radius = 0.35f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPointGizmos.NativeMethodInfoPtr_DrawSplineNode_Public_Static_Void_Vector3_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765193, XrefRangeEnd = 765212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawPathNode(
      Transform transform,
      Color color,
      bool wireFrame = false,
      float sizeMultiplier = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wireFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sizeMultiplier;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPointGizmos.NativeMethodInfoPtr_DrawPathNode_Public_Static_Void_Transform_Color_Boolean_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765212, XrefRangeEnd = 765226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DrawPathNode(
      Matrix4x4 matrix,
      Color color,
      bool wireFrame = false,
      float sizeMultiplier = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &matrix;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wireFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sizeMultiplier;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnPointGizmos.NativeMethodInfoPtr_DrawPathNode_Public_Static_Void_Matrix4x4_Color_Boolean_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnPointGizmos()
    {
      Il2CppClassPointerStore<SpawnPointGizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnPointGizmos));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnPointGizmos>.NativeClassPtr);
      SpawnPointGizmos.NativeMethodInfoPtr_DrawSpawnPoint_Public_Static_Void_Transform_Vector3_Quaternion_Color_Mesh_Single_Boolean_Nullable_Unboxed_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPointGizmos>.NativeClassPtr, 100667586);
      SpawnPointGizmos.NativeMethodInfoPtr_DrawLimitedSpawnPoint_Public_Static_Void_Transform_Vector3_Quaternion_Color_Boolean_Nullable_Unboxed_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPointGizmos>.NativeClassPtr, 100667587);
      SpawnPointGizmos.NativeMethodInfoPtr_DrawSplineNode_Public_Static_Void_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPointGizmos>.NativeClassPtr, 100667588);
      SpawnPointGizmos.NativeMethodInfoPtr_DrawPathNode_Public_Static_Void_Transform_Color_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPointGizmos>.NativeClassPtr, 100667589);
      SpawnPointGizmos.NativeMethodInfoPtr_DrawPathNode_Public_Static_Void_Matrix4x4_Color_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPointGizmos>.NativeClassPtr, 100667590);
    }

    public SpawnPointGizmos(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
