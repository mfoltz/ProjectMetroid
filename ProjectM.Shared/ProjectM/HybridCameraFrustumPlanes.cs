// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridCameraFrustumPlanes
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridCameraFrustumPlanes
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Plane;
    private static readonly System.IntPtr NativeMethodInfoPtr_DistanceToPlane_Private_Static_Single_float4_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSphereInsideFrustum_Public_Static_Boolean_NativeArray_1_float4_float3_Single_0;
    [FieldOffset(0)]
    public float4 Plane;

    [CallerCount(0)]
    public static unsafe float DistanceToPlane(float4 vPlane, float3 vPoint)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &vPlane;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vPoint;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraFrustumPlanes.NativeMethodInfoPtr_DistanceToPlane_Private_Static_Single_float4_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 722660, RefRangeEnd = 722661, XrefRangeStart = 722655, XrefRangeEnd = 722660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsSphereInsideFrustum(
      NativeArray<float4> vPlanes,
      float3 vCenter,
      float fRadius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &vPlanes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fRadius;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraFrustumPlanes.NativeMethodInfoPtr_IsSphereInsideFrustum_Public_Static_Boolean_NativeArray_1_float4_float3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HybridCameraFrustumPlanes()
    {
      Il2CppClassPointerStore<HybridCameraFrustumPlanes>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HybridCameraFrustumPlanes));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridCameraFrustumPlanes>.NativeClassPtr);
      HybridCameraFrustumPlanes.NativeFieldInfoPtr_Plane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCameraFrustumPlanes>.NativeClassPtr, nameof (Plane));
      HybridCameraFrustumPlanes.NativeMethodInfoPtr_DistanceToPlane_Private_Static_Single_float4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraFrustumPlanes>.NativeClassPtr, 100663817);
      HybridCameraFrustumPlanes.NativeMethodInfoPtr_IsSphereInsideFrustum_Public_Static_Boolean_NativeArray_1_float4_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraFrustumPlanes>.NativeClassPtr, 100663818);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridCameraFrustumPlanes>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
