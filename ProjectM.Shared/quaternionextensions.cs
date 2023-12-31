// Decompiled with JetBrains decompiler
// Type: quaternionextensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
public static class quaternionextensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_radToDeg;
  private static readonly System.IntPtr NativeFieldInfoPtr_degToRad;
  private static readonly System.IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;
  private static readonly System.IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_quaternion_quaternion_quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_quaternion_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetForward_Public_Static_float3_byref_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBackward_Public_Static_float3_byref_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRight_Public_Static_float3_byref_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeft_Public_Static_float3_byref_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUp_Public_Static_float3_byref_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDown_Public_Static_float3_byref_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInvalid_Public_Static_Boolean_byref_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEulerAngles_Public_Static_float3_byref_quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeAngles_Private_Static_float3_float3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeAngle_Private_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_float2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_float2_float2_0;

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 717172, RefRangeEnd = 717177, XrefRangeStart = 717164, XrefRangeEnd = 717172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe quaternion RotateTowards(
    quaternion from,
    quaternion to,
    float maxDegreesDelta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxDegreesDelta;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_RotateTowards_Public_Static_quaternion_quaternion_quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(quaternion*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 717182, RefRangeEnd = 717186, XrefRangeStart = 717177, XrefRangeEnd = 717182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Angle(quaternion a, quaternion b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_Angle_Public_Static_Single_quaternion_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 717190, RefRangeEnd = 717192, XrefRangeStart = 717186, XrefRangeEnd = 717190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetForward([In] ref quaternion quaternion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref quaternion;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_GetForward_Public_Static_float3_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 717196, RefRangeEnd = 717197, XrefRangeStart = 717192, XrefRangeEnd = 717196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetBackward([In] ref quaternion quaternion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref quaternion;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_GetBackward_Public_Static_float3_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 717201, RefRangeEnd = 717202, XrefRangeStart = 717197, XrefRangeEnd = 717201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetRight([In] ref quaternion quaternion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref quaternion;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_GetRight_Public_Static_float3_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717202, XrefRangeEnd = 717206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetLeft([In] ref quaternion quaternion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref quaternion;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_GetLeft_Public_Static_float3_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717206, XrefRangeEnd = 717210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetUp([In] ref quaternion quaternion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref quaternion;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_GetUp_Public_Static_float3_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717210, XrefRangeEnd = 717214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetDown([In] ref quaternion quaternion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref quaternion;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_GetDown_Public_Static_float3_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 717221, RefRangeEnd = 717229, XrefRangeStart = 717214, XrefRangeEnd = 717221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsInvalid([In] ref quaternion quaternion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref quaternion;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_IsInvalid_Public_Static_Boolean_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 717241, RefRangeEnd = 717247, XrefRangeStart = 717229, XrefRangeEnd = 717241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 GetEulerAngles([In] ref quaternion rotation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref rotation;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_GetEulerAngles_Public_Static_float3_byref_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float3 NormalizeAngles(float3 angles)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &angles;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_NormalizeAngles_Private_Static_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float NormalizeAngle(float angle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &angle;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_NormalizeAngle_Private_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe float SqrMagnitude(float2 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &vector;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717247, XrefRangeEnd = 717254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Angle(float2 from, float2 to)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &from;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(quaternionextensions.NativeMethodInfoPtr_Angle_Public_Static_Single_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  static quaternionextensions()
  {
    Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (quaternionextensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr);
    quaternionextensions.NativeFieldInfoPtr_radToDeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, nameof (radToDeg));
    quaternionextensions.NativeFieldInfoPtr_degToRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, nameof (degToRad));
    quaternionextensions.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, nameof (kEpsilonNormalSqrt));
    quaternionextensions.NativeMethodInfoPtr_RotateTowards_Public_Static_quaternion_quaternion_quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663504);
    quaternionextensions.NativeMethodInfoPtr_Angle_Public_Static_Single_quaternion_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663505);
    quaternionextensions.NativeMethodInfoPtr_GetForward_Public_Static_float3_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663506);
    quaternionextensions.NativeMethodInfoPtr_GetBackward_Public_Static_float3_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663507);
    quaternionextensions.NativeMethodInfoPtr_GetRight_Public_Static_float3_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663508);
    quaternionextensions.NativeMethodInfoPtr_GetLeft_Public_Static_float3_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663509);
    quaternionextensions.NativeMethodInfoPtr_GetUp_Public_Static_float3_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663510);
    quaternionextensions.NativeMethodInfoPtr_GetDown_Public_Static_float3_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663511);
    quaternionextensions.NativeMethodInfoPtr_IsInvalid_Public_Static_Boolean_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663512);
    quaternionextensions.NativeMethodInfoPtr_GetEulerAngles_Public_Static_float3_byref_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663513);
    quaternionextensions.NativeMethodInfoPtr_NormalizeAngles_Private_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663514);
    quaternionextensions.NativeMethodInfoPtr_NormalizeAngle_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663515);
    quaternionextensions.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663516);
    quaternionextensions.NativeMethodInfoPtr_Angle_Public_Static_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<quaternionextensions>.NativeClassPtr, 100663517);
  }

  public quaternionextensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float radToDeg
  {
    get
    {
      float radToDeg;
      IL2CPP.il2cpp_field_static_get_value(quaternionextensions.NativeFieldInfoPtr_radToDeg, (void*) &radToDeg);
      return radToDeg;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(quaternionextensions.NativeFieldInfoPtr_radToDeg, (void*) &value);
    }
  }

  public static unsafe float degToRad
  {
    get
    {
      float degToRad;
      IL2CPP.il2cpp_field_static_get_value(quaternionextensions.NativeFieldInfoPtr_degToRad, (void*) &degToRad);
      return degToRad;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(quaternionextensions.NativeFieldInfoPtr_degToRad, (void*) &value);
    }
  }

  public static unsafe float kEpsilonNormalSqrt
  {
    get
    {
      float epsilonNormalSqrt;
      IL2CPP.il2cpp_field_static_get_value(quaternionextensions.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*) &epsilonNormalSqrt);
      return epsilonNormalSqrt;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(quaternionextensions.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*) &value);
    }
  }
}
