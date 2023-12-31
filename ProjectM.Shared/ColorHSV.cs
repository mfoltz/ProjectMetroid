// Decompiled with JetBrains decompiler
// Type: ColorHSV
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
[StructLayout(LayoutKind.Explicit)]
public struct ColorHSV
{
  private static readonly System.IntPtr NativeFieldInfoPtr_H;
  private static readonly System.IntPtr NativeFieldInfoPtr_S;
  private static readonly System.IntPtr NativeFieldInfoPtr_V;
  private static readonly System.IntPtr NativeFieldInfoPtr_A;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromRGB_Public_Static_ColorHSV_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToRGB_Public_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt_Public_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_ColorHSV_ColorHSV_ColorHSV_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LerpHue_Public_Static_Single_Single_0;
  [FieldOffset(0)]
  public float H;
  [FieldOffset(4)]
  public float S;
  [FieldOffset(8)]
  public float V;
  [FieldOffset(12)]
  public float A;

  [CallerCount(599)]
  [CachedScanResults(RefRangeStart = 203641, RefRangeEnd = 204240, XrefRangeStart = 203641, XrefRangeEnd = 204240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ColorHSV(float h, float s, float v, float a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &h;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &s;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &v;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ColorHSV.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 717086, RefRangeEnd = 717096, XrefRangeStart = 717079, XrefRangeEnd = 717086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ColorHSV FromRGB(Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &color;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorHSV.NativeMethodInfoPtr_FromRGB_Public_Static_ColorHSV_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(ColorHSV*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 717096, RefRangeEnd = 717103, XrefRangeStart = 717096, XrefRangeEnd = 717096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Color ToRGB()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorHSV.NativeMethodInfoPtr_ToRGB_Public_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717103, XrefRangeEnd = 717104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint ToUInt()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorHSV.NativeMethodInfoPtr_ToUInt_Public_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 717106, RefRangeEnd = 717110, XrefRangeStart = 717104, XrefRangeEnd = 717106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ColorHSV Lerp(ColorHSV a, ColorHSV b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorHSV.NativeMethodInfoPtr_Lerp_Public_Static_ColorHSV_ColorHSV_ColorHSV_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(ColorHSV*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717110, XrefRangeEnd = 717111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float LerpHue(float indexFraction)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &indexFraction;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorHSV.NativeMethodInfoPtr_LerpHue_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  static ColorHSV()
  {
    Il2CppClassPointerStore<ColorHSV>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (ColorHSV));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr);
    ColorHSV.NativeFieldInfoPtr_H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, nameof (H));
    ColorHSV.NativeFieldInfoPtr_S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, nameof (S));
    ColorHSV.NativeFieldInfoPtr_V = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, nameof (V));
    ColorHSV.NativeFieldInfoPtr_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, nameof (A));
    ColorHSV.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100663491);
    ColorHSV.NativeMethodInfoPtr_FromRGB_Public_Static_ColorHSV_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100663492);
    ColorHSV.NativeMethodInfoPtr_ToRGB_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100663493);
    ColorHSV.NativeMethodInfoPtr_ToUInt_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100663494);
    ColorHSV.NativeMethodInfoPtr_Lerp_Public_Static_ColorHSV_ColorHSV_ColorHSV_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100663495);
    ColorHSV.NativeMethodInfoPtr_LerpHue_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100663496);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
