// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DCurve
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  public class Motion2DCurve : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Curve;
    private static readonly IntPtr NativeMethodInfoPtr_DefaultLinear_Public_Static_Motion2DCurve_0;
    private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Void_Motion2DCurve_Curve_byref_Motion2DValues_byref_Motion2DValues_byref_Motion2DValues_Single_Motion2DMask_0;
    private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Motion2DValues_byref_Motion2DValues_byref_Motion2DValues_Single_Motion2DMask_0;
    private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922372, XrefRangeEnd = 922380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Motion2DCurve DefaultLinear()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DCurve.NativeMethodInfoPtr_DefaultLinear_Public_Static_Motion2DCurve_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Motion2DCurve) null : new Motion2DCurve(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 885485, RefRangeEnd = 885487, XrefRangeStart = 885485, XrefRangeEnd = 885487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Evaluate(float t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &t;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 922384, RefRangeEnd = 922388, XrefRangeStart = 922380, XrefRangeEnd = 922384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Evaluate(
      Motion2DCurve curve,
      Motion2DEasings.Curve easingCurve,
      ref Motion2DValues current,
      ref Motion2DValues start,
      ref Motion2DValues end,
      float t,
      Motion2DMask mask)
    {
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &easingCurve;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref current;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref start;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) ref end;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &t;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &mask;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DCurve.NativeMethodInfoPtr_Evaluate_Public_Static_Void_Motion2DCurve_Curve_byref_Motion2DValues_byref_Motion2DValues_byref_Motion2DValues_Single_Motion2DMask_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922388, XrefRangeEnd = 922398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Motion2DValues Lerp(
      ref Motion2DValues start,
      ref Motion2DValues end,
      float t,
      Motion2DMask mask)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) ref start;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref end;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &t;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &mask;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DCurve.NativeMethodInfoPtr_Lerp_Public_Static_Motion2DValues_byref_Motion2DValues_byref_Motion2DValues_Single_Motion2DMask_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Motion2DValues*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float Lerp(float from, float to, float t)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &from;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &to;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &t;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DCurve.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DCurve()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Motion2DCurve()
    {
      Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DCurve));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr);
      Motion2DCurve.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr, nameof (Curve));
      Motion2DCurve.NativeMethodInfoPtr_DefaultLinear_Public_Static_Motion2DCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr, 100663773);
      Motion2DCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr, 100663774);
      Motion2DCurve.NativeMethodInfoPtr_Evaluate_Public_Static_Void_Motion2DCurve_Curve_byref_Motion2DValues_byref_Motion2DValues_byref_Motion2DValues_Single_Motion2DMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr, 100663775);
      Motion2DCurve.NativeMethodInfoPtr_Lerp_Public_Static_Motion2DValues_byref_Motion2DValues_byref_Motion2DValues_Single_Motion2DMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr, 100663776);
      Motion2DCurve.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr, 100663777);
      Motion2DCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DCurve>.NativeClassPtr, 100663778);
    }

    public Motion2DCurve(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AnimationCurve Curve
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DCurve.NativeFieldInfoPtr_Curve));
        return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DCurve.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
