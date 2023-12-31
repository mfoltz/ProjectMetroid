// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.LinearVector3Curve
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM.StunDebug
{
  [Serializable]
  public class LinearVector3Curve : Curve<Vector3, Vector3>
  {
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_LinearVector3Curve_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_LinearVector3Curve_Single_Vector3_Single_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_Interpolate_Private_Static_Vector3_Vector3_Vector3_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770826, XrefRangeEnd = 770837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LinearVector3Curve Create()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LinearVector3Curve.NativeMethodInfoPtr_Create_Public_Static_LinearVector3Curve_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (LinearVector3Curve) null : new LinearVector3Curve(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770837, XrefRangeEnd = 770853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LinearVector3Curve Create(
      float startTime,
      Vector3 startValue,
      float endTime,
      Vector3 endValue)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &startTime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &startValue;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &endTime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &endValue;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LinearVector3Curve.NativeMethodInfoPtr_Create_Public_Static_LinearVector3Curve_Single_Vector3_Single_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (LinearVector3Curve) null : new LinearVector3Curve(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770853, XrefRangeEnd = 770854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector3 Interpolate(Vector3 v1, Vector3 v2, float t)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &v1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &v2;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &t;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LinearVector3Curve.NativeMethodInfoPtr_Interpolate_Private_Static_Vector3_Vector3_Vector3_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770857, RefRangeEnd = 770858, XrefRangeStart = 770854, XrefRangeEnd = 770857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinearVector3Curve()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinearVector3Curve>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinearVector3Curve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LinearVector3Curve()
    {
      Il2CppClassPointerStore<LinearVector3Curve>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (LinearVector3Curve));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearVector3Curve>.NativeClassPtr);
      LinearVector3Curve.NativeMethodInfoPtr_Create_Public_Static_LinearVector3Curve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearVector3Curve>.NativeClassPtr, 100668275);
      LinearVector3Curve.NativeMethodInfoPtr_Create_Public_Static_LinearVector3Curve_Single_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearVector3Curve>.NativeClassPtr, 100668276);
      LinearVector3Curve.NativeMethodInfoPtr_Interpolate_Private_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearVector3Curve>.NativeClassPtr, 100668277);
      LinearVector3Curve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearVector3Curve>.NativeClassPtr, 100668278);
    }

    public LinearVector3Curve(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
