// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.PolygonRegionBlob
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PolygonRegionBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BoundsMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoundsMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_Vertices;
    private static readonly System.IntPtr NativeFieldInfoPtr_Triangles;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalArea;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInsideRegion_Public_Boolean_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInsideTriangle_Private_Static_Boolean_float2_float2_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomPosition_Public_float2_byref_Random_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomPositionInTriangle_Private_float2_int3_byref_Random_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_float2_float2_float2_PDM_0;
    [FieldOffset(0)]
    public float2 BoundsMin;
    [FieldOffset(8)]
    public float2 BoundsMax;
    [FieldOffset(16)]
    public BlobArray<float2> Vertices;
    [FieldOffset(24)]
    public BlobArray<PolygonRegionTriangle> Triangles;
    [FieldOffset(32)]
    public BlobString Name;
    [FieldOffset(40)]
    public float TotalArea;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 766776, RefRangeEnd = 766780, XrefRangeStart = 766763, XrefRangeEnd = 766776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInsideRegion(float2 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonRegionBlob.NativeMethodInfoPtr_IsInsideRegion_Public_Boolean_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766780, XrefRangeEnd = 766782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInsideTriangle(float2 position, float2 t0, float2 t1, float2 t2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &t2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonRegionBlob.NativeMethodInfoPtr_IsInsideTriangle_Private_Static_Boolean_float2_float2_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766786, RefRangeEnd = 766787, XrefRangeStart = 766782, XrefRangeEnd = 766786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float2 GetRandomPosition(ref Unity.Mathematics.Random random)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref random;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonRegionBlob.NativeMethodInfoPtr_GetRandomPosition_Public_float2_byref_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766787, XrefRangeEnd = 766794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float2 GetRandomPositionInTriangle(int3 triangle, ref Unity.Mathematics.Random random)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &triangle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonRegionBlob.NativeMethodInfoPtr_GetRandomPositionInTriangle_Private_float2_int3_byref_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float Method_Internal_Static_Single_float2_float2_float2_PDM_0(
      float2 a,
      float2 b,
      float2 o)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &o;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PolygonRegionBlob.NativeMethodInfoPtr_Method_Internal_Static_Single_float2_float2_float2_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PolygonRegionBlob()
    {
      Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (PolygonRegionBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr);
      PolygonRegionBlob.NativeFieldInfoPtr_BoundsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, nameof (BoundsMin));
      PolygonRegionBlob.NativeFieldInfoPtr_BoundsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, nameof (BoundsMax));
      PolygonRegionBlob.NativeFieldInfoPtr_Vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, nameof (Vertices));
      PolygonRegionBlob.NativeFieldInfoPtr_Triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, nameof (Triangles));
      PolygonRegionBlob.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, nameof (Name));
      PolygonRegionBlob.NativeFieldInfoPtr_TotalArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, nameof (TotalArea));
      PolygonRegionBlob.NativeMethodInfoPtr_IsInsideRegion_Public_Boolean_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, 100667794);
      PolygonRegionBlob.NativeMethodInfoPtr_IsInsideTriangle_Private_Static_Boolean_float2_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, 100667795);
      PolygonRegionBlob.NativeMethodInfoPtr_GetRandomPosition_Public_float2_byref_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, 100667796);
      PolygonRegionBlob.NativeMethodInfoPtr_GetRandomPositionInTriangle_Private_float2_int3_byref_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, 100667797);
      PolygonRegionBlob.NativeMethodInfoPtr_Method_Internal_Static_Single_float2_float2_float2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, 100667798);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PolygonRegionBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
