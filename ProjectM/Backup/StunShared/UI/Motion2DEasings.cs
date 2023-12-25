// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DEasings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  public static class Motion2DEasings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToAnimationCurve_Public_Static_AnimationCurve_Curve_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Single_Single_Curve_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_Double_Double_Curve_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_linear_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuad_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuad_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuad_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInCubic_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCubic_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCubic_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuart_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuart_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuart_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuint_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuint_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuint_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInSine_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutSine_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutSine_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInExpo_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutExpo_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutExpo_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInCirc_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCirc_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCirc_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInElastic_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutElastic_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutElastic_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInBack_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBack_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBack_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInBounce_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBounce_Public_Static_Double_Double_Double_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBounce_Public_Static_Double_Double_Double_Double_Double_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922427, XrefRangeEnd = 922439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AnimationCurve ToAnimationCurve(this Motion2DEasings.Curve curve)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &curve;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_ToAnimationCurve_Public_Static_AnimationCurve_Curve_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922439, XrefRangeEnd = 922440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float Evaluate(float value, Motion2DEasings.Curve curve)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &curve;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Single_Curve_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 922543, RefRangeEnd = 922546, XrefRangeStart = 922440, XrefRangeEnd = 922543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double Evaluate(double value, Motion2DEasings.Curve curve)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &curve;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_Evaluate_Public_Static_Double_Double_Curve_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double linear(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_linear_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInQuad(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInQuad_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeOutQuad(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutQuad_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInOutQuad(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutQuad_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInCubic(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInCubic_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeOutCubic(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutCubic_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 922546, RefRangeEnd = 922548, XrefRangeStart = 922546, XrefRangeEnd = 922546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInOutCubic(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutCubic_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInQuart(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInQuart_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeOutQuart(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutQuart_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInOutQuart(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutQuart_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInQuint(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInQuint_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeOutQuint(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutQuint_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInOutQuint(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutQuint_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922548, XrefRangeEnd = 922552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInSine(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInSine_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922552, XrefRangeEnd = 922556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeOutSine(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutSine_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922556, XrefRangeEnd = 922560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInOutSine(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutSine_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922560, XrefRangeEnd = 922565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInExpo(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInExpo_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922565, XrefRangeEnd = 922570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeOutExpo(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutExpo_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922570, XrefRangeEnd = 922578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInOutExpo(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutExpo_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922578, XrefRangeEnd = 922583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInCirc(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInCirc_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922583, XrefRangeEnd = 922588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeOutCirc(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutCirc_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922588, XrefRangeEnd = 922597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInOutCirc(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutCirc_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922597, XrefRangeEnd = 922610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInElastic(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInElastic_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922610, XrefRangeEnd = 922622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeOutElastic(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutElastic_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 922638, RefRangeEnd = 922639, XrefRangeStart = 922622, XrefRangeEnd = 922638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInOutElastic(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutElastic_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInBack(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInBack_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeOutBack(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutBack_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe double easeInOutBack(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutBack_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922639, XrefRangeEnd = 922640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInBounce(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInBounce_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 922640, RefRangeEnd = 922643, XrefRangeStart = 922640, XrefRangeEnd = 922640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeOutBounce(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeOutBounce_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922643, XrefRangeEnd = 922646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double easeInOutBounce(double t, double b = 0.0, double c = 1.0, double d = 1.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &c;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DEasings.NativeMethodInfoPtr_easeInOutBounce_Public_Static_Double_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Motion2DEasings()
    {
      Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DEasings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr);
      Motion2DEasings.NativeMethodInfoPtr_ToAnimationCurve_Public_Static_AnimationCurve_Curve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663783);
      Motion2DEasings.NativeMethodInfoPtr_Evaluate_Public_Static_Single_Single_Curve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663784);
      Motion2DEasings.NativeMethodInfoPtr_Evaluate_Public_Static_Double_Double_Curve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663785);
      Motion2DEasings.NativeMethodInfoPtr_linear_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663786);
      Motion2DEasings.NativeMethodInfoPtr_easeInQuad_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663787);
      Motion2DEasings.NativeMethodInfoPtr_easeOutQuad_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663788);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutQuad_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663789);
      Motion2DEasings.NativeMethodInfoPtr_easeInCubic_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663790);
      Motion2DEasings.NativeMethodInfoPtr_easeOutCubic_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663791);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutCubic_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663792);
      Motion2DEasings.NativeMethodInfoPtr_easeInQuart_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663793);
      Motion2DEasings.NativeMethodInfoPtr_easeOutQuart_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663794);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutQuart_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663795);
      Motion2DEasings.NativeMethodInfoPtr_easeInQuint_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663796);
      Motion2DEasings.NativeMethodInfoPtr_easeOutQuint_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663797);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutQuint_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663798);
      Motion2DEasings.NativeMethodInfoPtr_easeInSine_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663799);
      Motion2DEasings.NativeMethodInfoPtr_easeOutSine_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663800);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutSine_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663801);
      Motion2DEasings.NativeMethodInfoPtr_easeInExpo_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663802);
      Motion2DEasings.NativeMethodInfoPtr_easeOutExpo_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663803);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutExpo_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663804);
      Motion2DEasings.NativeMethodInfoPtr_easeInCirc_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663805);
      Motion2DEasings.NativeMethodInfoPtr_easeOutCirc_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663806);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutCirc_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663807);
      Motion2DEasings.NativeMethodInfoPtr_easeInElastic_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663808);
      Motion2DEasings.NativeMethodInfoPtr_easeOutElastic_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663809);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutElastic_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663810);
      Motion2DEasings.NativeMethodInfoPtr_easeInBack_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663811);
      Motion2DEasings.NativeMethodInfoPtr_easeOutBack_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663812);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutBack_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663813);
      Motion2DEasings.NativeMethodInfoPtr_easeInBounce_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663814);
      Motion2DEasings.NativeMethodInfoPtr_easeOutBounce_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663815);
      Motion2DEasings.NativeMethodInfoPtr_easeInOutBounce_Public_Static_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DEasings>.NativeClassPtr, 100663816);
    }

    public Motion2DEasings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [Serializable]
    public enum Curve
    {
      None,
      Linear,
      EaseInQuad,
      EaseOutQuad,
      EaseInOutQuad,
      EaseInCubic,
      EaseOutCubic,
      EaseInOutCubic,
      EaseInQuart,
      EaseOutQuart,
      EaseInOutQuart,
      EaseInQuint,
      EaseOutQuint,
      EaseInOutQuint,
      EaseInSine,
      EaseOutSine,
      EaseInOutSine,
      EaseInExpo,
      EaseOutExpo,
      EaseInOutExpo,
      EaseInCirc,
      EaseOutCirc,
      EaseInOutCirc,
      EaseInElastic,
      EaseOutElastic,
      EaseInOutElastic,
      EaseInBack,
      EaseOutBack,
      EaseInOutBack,
    }
  }
}
