// Decompiled with JetBrains decompiler
// Type: Viewport
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
[StructLayout(LayoutKind.Explicit)]
public struct Viewport
{
  private static readonly System.IntPtr NativeFieldInfoPtr_IsValidViewport;
  private static readonly System.IntPtr NativeFieldInfoPtr_FieldOfView;
  private static readonly System.IntPtr NativeFieldInfoPtr_Resolution;
  private static readonly System.IntPtr NativeFieldInfoPtr_NearClipPlane;
  private static readonly System.IntPtr NativeFieldInfoPtr_FarClipPlane;
  private static readonly System.IntPtr NativeFieldInfoPtr_AspectRatio;
  private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionMatrix;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculatePerspectiveViewport_Public_Static_Viewport_float2_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Vector2_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssertValidViewport_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_float4x4_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_float4x4_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToViewPortPoint_Public_Vector3_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_float4x4_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_float4x4_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_float4x4_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_float4x4_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsSameAs_Public_Boolean_Viewport_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsOnScreen_Public_Boolean_float3_Single_0;
  [FieldOffset(0)]
  public readonly bool IsValidViewport;
  [FieldOffset(4)]
  public readonly float FieldOfView;
  [FieldOffset(8)]
  public readonly float2 Resolution;
  [FieldOffset(16)]
  public readonly float NearClipPlane;
  [FieldOffset(20)]
  public readonly float FarClipPlane;
  [FieldOffset(24)]
  public readonly float AspectRatio;
  [FieldOffset(28)]
  public readonly float4x4 ProjectionMatrix;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 716995, RefRangeEnd = 716996, XrefRangeStart = 716993, XrefRangeEnd = 716995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Viewport CalculatePerspectiveViewport(
    float2 resolution,
    float fieldOfView,
    float nearClipPlane,
    float farClipPlane)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &resolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fieldOfView;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nearClipPlane;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &farClipPlane;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_CalculatePerspectiveViewport_Public_Static_Viewport_float2_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Viewport*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 717007, RefRangeEnd = 717008, XrefRangeStart = 716996, XrefRangeEnd = 717007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Viewport(
    Vector2 resolution,
    float fieldOfView,
    float nearClipPlane,
    float farClipPlane)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &resolution;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fieldOfView;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nearClipPlane;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &farClipPlane;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr__ctor_Private_Void_Vector2_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717008, XrefRangeEnd = 717014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssertValidViewport()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_AssertValidViewport_Private_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717014, XrefRangeEnd = 717022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProjectM.Shared.Mathematics.Ray ViewportPointToRay(
    float4x4 viewMatrix,
    Vector3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_float4x4_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(ProjectM.Shared.Mathematics.Ray*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717022, XrefRangeEnd = 717029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProjectM.Shared.Mathematics.Ray ScreenPointToRay(
    float4x4 viewMatrix,
    float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_float4x4_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(ProjectM.Shared.Mathematics.Ray*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717029, XrefRangeEnd = 717037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ScreenToViewPortPoint(float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_ScreenToViewPortPoint_Public_Vector3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717037, XrefRangeEnd = 717045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ScreenToWorldPoint(float4x4 viewMatrix, float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_float4x4_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717045, XrefRangeEnd = 717053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ViewportToScreenPoint(float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717053, XrefRangeEnd = 717061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 WorldToScreenPoint(float4x4 viewMatrix, float3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_float4x4_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717061, XrefRangeEnd = 717070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ViewportToWorldPoint(float4x4 viewMatrix, Vector3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_float4x4_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717070, XrefRangeEnd = 717079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 WorldToViewportPoint(float4x4 viewMatrix, Vector3 position)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &viewMatrix;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_float4x4_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool IsSameAs(Viewport viewport)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &viewport;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_IsSameAs_Public_Boolean_Viewport_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe bool IsOnScreen(float3 screenPosition, float offset = 0.0f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &screenPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Viewport.NativeMethodInfoPtr_IsOnScreen_Public_Boolean_float3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Viewport()
  {
    Il2CppClassPointerStore<Viewport>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (Viewport));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Viewport>.NativeClassPtr);
    Viewport.NativeFieldInfoPtr_IsValidViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Viewport>.NativeClassPtr, nameof (IsValidViewport));
    Viewport.NativeFieldInfoPtr_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Viewport>.NativeClassPtr, nameof (FieldOfView));
    Viewport.NativeFieldInfoPtr_Resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Viewport>.NativeClassPtr, nameof (Resolution));
    Viewport.NativeFieldInfoPtr_NearClipPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Viewport>.NativeClassPtr, nameof (NearClipPlane));
    Viewport.NativeFieldInfoPtr_FarClipPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Viewport>.NativeClassPtr, nameof (FarClipPlane));
    Viewport.NativeFieldInfoPtr_AspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Viewport>.NativeClassPtr, nameof (AspectRatio));
    Viewport.NativeFieldInfoPtr_ProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Viewport>.NativeClassPtr, nameof (ProjectionMatrix));
    Viewport.NativeMethodInfoPtr_CalculatePerspectiveViewport_Public_Static_Viewport_float2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663478);
    Viewport.NativeMethodInfoPtr__ctor_Private_Void_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663479);
    Viewport.NativeMethodInfoPtr_AssertValidViewport_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663480);
    Viewport.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_float4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663481);
    Viewport.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663482);
    Viewport.NativeMethodInfoPtr_ScreenToViewPortPoint_Public_Vector3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663483);
    Viewport.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663484);
    Viewport.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663485);
    Viewport.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663486);
    Viewport.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_float4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663487);
    Viewport.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_float4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663488);
    Viewport.NativeMethodInfoPtr_IsSameAs_Public_Boolean_Viewport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663489);
    Viewport.NativeMethodInfoPtr_IsOnScreen_Public_Boolean_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Viewport>.NativeClassPtr, 100663490);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Viewport>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
