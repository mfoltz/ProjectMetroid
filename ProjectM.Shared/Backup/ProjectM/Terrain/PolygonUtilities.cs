// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.PolygonUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public static class PolygonUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConstructRegion_Public_Static_BlobAssetReference_1_PolygonRegionBlob_NativeArray_1_float2_NativeArray_1_int3_String_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInPolygon_Public_Static_Boolean_float2_NativeArray_1_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DistanceToPolygon_Public_Static_Single_float2_NativeArray_1_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInPolygon_Public_Static_Boolean_float2_Il2CppStructArray_1_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckLineIntersect_Public_Static_Boolean_float2_float2_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckLinePolygonIntersect_Public_Static_Boolean_float2_float2_byref_NativeArray_1_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateArea_Public_Static_Single_byref_NativeArray_1_float2_byref_NativeArray_1_int3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateArea_Public_Static_Single_byref_NativeArray_1_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateArea_Public_Static_Single_float2_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateWinding_Public_Static_PolygonWinding_byref_NativeSlice_1_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTriangleSignedArea_Internal_Private_Static_Single_float2_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSignedArea_Internal_Private_Static_Single_byref_NativeSlice_1_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsConvexPolygon_Public_Static_Boolean_NativeArray_1_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CrossProductLength_Private_Static_Single_float2_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_float2_float2_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766794, XrefRangeEnd = 766819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BlobAssetReference<PolygonRegionBlob> ConstructRegion(
      NativeArray<float2> vertices,
      NativeArray<int3> triangleIndices,
      string name,
      Allocator allocator = Allocator.Persistent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &vertices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &triangleIndices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_ConstructRegion_Public_Static_BlobAssetReference_1_PolygonRegionBlob_NativeArray_1_float2_NativeArray_1_int3_String_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<PolygonRegionBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 766819, RefRangeEnd = 766833, XrefRangeStart = 766819, XrefRangeEnd = 766819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInPolygon(float2 point, NativeArray<float2> polygon)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &point;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &polygon;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_IsInPolygon_Public_Static_Boolean_float2_NativeArray_1_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766837, RefRangeEnd = 766838, XrefRangeStart = 766833, XrefRangeEnd = 766837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float DistanceToPolygon(float2 point, NativeArray<float2> polygon)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &point;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &polygon;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_DistanceToPolygon_Public_Static_Single_float2_NativeArray_1_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766838, XrefRangeEnd = 766839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInPolygon(float2 point, Il2CppStructArray<Vector3> polygon)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &point;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) polygon);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_IsInPolygon_Public_Static_Boolean_float2_Il2CppStructArray_1_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 766841, RefRangeEnd = 766843, XrefRangeStart = 766839, XrefRangeEnd = 766841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckLineIntersect(
      float2 beginA,
      float2 endA,
      float2 beginB,
      float2 endB)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &beginA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &endA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &beginB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &endB;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CheckLineIntersect_Public_Static_Boolean_float2_float2_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766843, XrefRangeEnd = 766846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckLinePolygonIntersect(
      float2 begin,
      float2 end,
      [In] ref NativeArray<float2> polygon)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &begin;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref polygon;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CheckLinePolygonIntersect_Public_Static_Boolean_float2_float2_byref_NativeArray_1_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766862, RefRangeEnd = 766863, XrefRangeStart = 766846, XrefRangeEnd = 766862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float CalculateArea(
      [In] ref NativeArray<float2> vertices,
      [In] ref NativeArray<int3> triangles)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref vertices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref triangles;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CalculateArea_Public_Static_Single_byref_NativeArray_1_float2_byref_NativeArray_1_int3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766863, XrefRangeEnd = 766867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float CalculateArea([In] ref NativeArray<float2> polygon)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref polygon;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CalculateArea_Public_Static_Single_byref_NativeArray_1_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float CalculateArea(float2 a, float2 b, float2 c)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CalculateArea_Public_Static_Single_float2_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766867, XrefRangeEnd = 766868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PolygonWinding CalculateWinding([In] ref NativeSlice<float2> polygon)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref polygon;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CalculateWinding_Public_Static_PolygonWinding_byref_NativeSlice_1_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PolygonWinding*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float CalculateTriangleSignedArea_Internal(float2 a, float2 b, float2 c)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CalculateTriangleSignedArea_Internal_Private_Static_Single_float2_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 766884, RefRangeEnd = 766886, XrefRangeStart = 766868, XrefRangeEnd = 766884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float CalculateSignedArea_Internal([In] ref NativeSlice<float2> polygon)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref polygon;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CalculateSignedArea_Internal_Private_Static_Single_byref_NativeSlice_1_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsConvexPolygon(NativeArray<float2> polygon)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &polygon;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_IsConvexPolygon_Public_Static_Boolean_NativeArray_1_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float CrossProductLength(float2 a, float2 b, float2 c)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_CrossProductLength_Private_Static_Single_float2_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float Method_Internal_Static_Single_float2_float2_PDM_0(float2 a, float2 b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonUtilities.NativeMethodInfoPtr_Method_Internal_Static_Single_float2_float2_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PolygonUtilities()
    {
      Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (PolygonUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr);
      PolygonUtilities.NativeMethodInfoPtr_ConstructRegion_Public_Static_BlobAssetReference_1_PolygonRegionBlob_NativeArray_1_float2_NativeArray_1_int3_String_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667799);
      PolygonUtilities.NativeMethodInfoPtr_IsInPolygon_Public_Static_Boolean_float2_NativeArray_1_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667800);
      PolygonUtilities.NativeMethodInfoPtr_DistanceToPolygon_Public_Static_Single_float2_NativeArray_1_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667801);
      PolygonUtilities.NativeMethodInfoPtr_IsInPolygon_Public_Static_Boolean_float2_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667802);
      PolygonUtilities.NativeMethodInfoPtr_CheckLineIntersect_Public_Static_Boolean_float2_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667803);
      PolygonUtilities.NativeMethodInfoPtr_CheckLinePolygonIntersect_Public_Static_Boolean_float2_float2_byref_NativeArray_1_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667804);
      PolygonUtilities.NativeMethodInfoPtr_CalculateArea_Public_Static_Single_byref_NativeArray_1_float2_byref_NativeArray_1_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667805);
      PolygonUtilities.NativeMethodInfoPtr_CalculateArea_Public_Static_Single_byref_NativeArray_1_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667806);
      PolygonUtilities.NativeMethodInfoPtr_CalculateArea_Public_Static_Single_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667807);
      PolygonUtilities.NativeMethodInfoPtr_CalculateWinding_Public_Static_PolygonWinding_byref_NativeSlice_1_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667808);
      PolygonUtilities.NativeMethodInfoPtr_CalculateTriangleSignedArea_Internal_Private_Static_Single_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667809);
      PolygonUtilities.NativeMethodInfoPtr_CalculateSignedArea_Internal_Private_Static_Single_byref_NativeSlice_1_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667810);
      PolygonUtilities.NativeMethodInfoPtr_IsConvexPolygon_Public_Static_Boolean_NativeArray_1_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667811);
      PolygonUtilities.NativeMethodInfoPtr_CrossProductLength_Private_Static_Single_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667812);
      PolygonUtilities.NativeMethodInfoPtr_Method_Internal_Static_Single_float2_float2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonUtilities>.NativeClassPtr, 100667813);
    }

    public PolygonUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
