// Decompiled with JetBrains decompiler
// Type: MathExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;

#nullable disable
public static class MathExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRight_Public_Static_float3_float4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUp_Public_Static_float3_float4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetForward_Public_Static_float3_float4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Public_Static_float3_float4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRotation_Public_Static_quaternion_float4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScale_Public_Static_float3_float4x4_0;

  [CallerCount(68)]
  [CachedScanResults(RefRangeStart = 537890, RefRangeEnd = 537958, XrefRangeStart = 537890, XrefRangeEnd = 537958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetRight(this float4x4 matrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &matrix;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_GetRight_Public_Static_float3_float4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float3 GetUp(this float4x4 matrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &matrix;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_GetUp_Public_Static_float3_float4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float3 GetForward(this float4x4 matrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &matrix;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_GetForward_Public_Static_float3_float4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 717111, RefRangeEnd = 717133, XrefRangeStart = 717111, XrefRangeEnd = 717111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetPosition(this float4x4 matrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &matrix;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_GetPosition_Public_Static_float3_float4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 717140, RefRangeEnd = 717154, XrefRangeStart = 717133, XrefRangeEnd = 717140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe quaternion GetRotation(this float4x4 matrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &matrix;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_GetRotation_Public_Static_quaternion_float4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(quaternion*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 717157, RefRangeEnd = 717164, XrefRangeStart = 717154, XrefRangeEnd = 717157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetScale(this float4x4 matrix)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &matrix;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MathExtensions.NativeMethodInfoPtr_GetScale_Public_Static_float3_float4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  static MathExtensions()
  {
    Il2CppClassPointerStore<MathExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (MathExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr);
    MathExtensions.NativeMethodInfoPtr_GetRight_Public_Static_float3_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100663497);
    MathExtensions.NativeMethodInfoPtr_GetUp_Public_Static_float3_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100663498);
    MathExtensions.NativeMethodInfoPtr_GetForward_Public_Static_float3_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100663499);
    MathExtensions.NativeMethodInfoPtr_GetPosition_Public_Static_float3_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100663500);
    MathExtensions.NativeMethodInfoPtr_GetRotation_Public_Static_quaternion_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100663501);
    MathExtensions.NativeMethodInfoPtr_GetScale_Public_Static_float3_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathExtensions>.NativeClassPtr, 100663502);
  }

  public MathExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
