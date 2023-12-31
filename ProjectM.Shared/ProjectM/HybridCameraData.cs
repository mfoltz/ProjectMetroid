// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridCameraData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridCameraData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Viewport;
    private static readonly System.IntPtr NativeFieldInfoPtr_ViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FieldOfView_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Resolution_Public_get_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NearClipPlane_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FarClipPlane_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AspectRatio_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProjectionMatrix_Public_get_float4x4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToViewPortPoint_Public_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsOnScreen_Public_Boolean_float3_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Public_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_float3_float3_0;
    [FieldOffset(0)]
    public Viewport Viewport;
    [FieldOffset(92)]
    public float4x4 ViewMatrix;
    [FieldOffset(156)]
    public float3 Position;
    [FieldOffset(168)]
    public Quaternion Rotation;

    public unsafe float FieldOfView
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_get_FieldOfView_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float2 Resolution
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 260361, RefRangeEnd = 260366, XrefRangeStart = 260361, XrefRangeEnd = 260366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_get_Resolution_Public_get_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float2*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float NearClipPlane
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 233475, RefRangeEnd = 233478, XrefRangeStart = 233475, XrefRangeEnd = 233478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_get_NearClipPlane_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float FarClipPlane
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 445329, RefRangeEnd = 445331, XrefRangeStart = 445329, XrefRangeEnd = 445331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_get_FarClipPlane_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float AspectRatio
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_get_AspectRatio_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float4x4 ProjectionMatrix
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 722661, RefRangeEnd = 722669, XrefRangeStart = 722661, XrefRangeEnd = 722661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_get_ProjectionMatrix_Public_get_float4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float4x4*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722669, XrefRangeEnd = 722670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM.Shared.Mathematics.Ray ViewportPointToRay(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProjectM.Shared.Mathematics.Ray*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 722671, RefRangeEnd = 722675, XrefRangeStart = 722670, XrefRangeEnd = 722671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM.Shared.Mathematics.Ray ScreenPointToRay(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProjectM.Shared.Mathematics.Ray*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 722676, RefRangeEnd = 722677, XrefRangeStart = 722675, XrefRangeEnd = 722676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 ScreenToWorldPoint(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_ScreenToWorldPoint_Public_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722677, XrefRangeEnd = 722678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 ScreenToViewPortPoint(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_ScreenToViewPortPoint_Public_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 722678, RefRangeEnd = 722679, XrefRangeStart = 722678, XrefRangeEnd = 722678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsOnScreen(float3 screenPosition, float offset = 0.0f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &screenPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_IsOnScreen_Public_Boolean_float3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722679, XrefRangeEnd = 722680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 ViewportToScreenPoint(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_ViewportToScreenPoint_Public_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 722681, RefRangeEnd = 722685, XrefRangeStart = 722680, XrefRangeEnd = 722681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 WorldToScreenPoint(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_WorldToScreenPoint_Public_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 722686, RefRangeEnd = 722687, XrefRangeStart = 722685, XrefRangeEnd = 722686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 ViewportToWorldPoint(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_ViewportToWorldPoint_Public_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722687, XrefRangeEnd = 722688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 WorldToViewportPoint(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridCameraData.NativeMethodInfoPtr_WorldToViewportPoint_Public_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HybridCameraData()
    {
      Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HybridCameraData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr);
      HybridCameraData.NativeFieldInfoPtr_Viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, nameof (Viewport));
      HybridCameraData.NativeFieldInfoPtr_ViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, nameof (ViewMatrix));
      HybridCameraData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, nameof (Position));
      HybridCameraData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, nameof (Rotation));
      HybridCameraData.NativeMethodInfoPtr_get_FieldOfView_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663819);
      HybridCameraData.NativeMethodInfoPtr_get_Resolution_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663820);
      HybridCameraData.NativeMethodInfoPtr_get_NearClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663821);
      HybridCameraData.NativeMethodInfoPtr_get_FarClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663822);
      HybridCameraData.NativeMethodInfoPtr_get_AspectRatio_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663823);
      HybridCameraData.NativeMethodInfoPtr_get_ProjectionMatrix_Public_get_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663824);
      HybridCameraData.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663825);
      HybridCameraData.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663826);
      HybridCameraData.NativeMethodInfoPtr_ScreenToWorldPoint_Public_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663827);
      HybridCameraData.NativeMethodInfoPtr_ScreenToViewPortPoint_Public_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663828);
      HybridCameraData.NativeMethodInfoPtr_IsOnScreen_Public_Boolean_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663829);
      HybridCameraData.NativeMethodInfoPtr_ViewportToScreenPoint_Public_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663830);
      HybridCameraData.NativeMethodInfoPtr_WorldToScreenPoint_Public_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663831);
      HybridCameraData.NativeMethodInfoPtr_ViewportToWorldPoint_Public_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663832);
      HybridCameraData.NativeMethodInfoPtr_WorldToViewportPoint_Public_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, 100663833);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridCameraData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
