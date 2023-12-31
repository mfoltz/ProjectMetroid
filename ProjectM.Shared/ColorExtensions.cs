// Decompiled with JetBrains decompiler
// Type: ColorExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
public static class ColorExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ToFloat4_Public_Static_float4_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToInt4_Public_Static_int4_Color32_0;

  [CallerCount(98)]
  [CachedScanResults(RefRangeStart = 260427, RefRangeEnd = 260525, XrefRangeStart = 260427, XrefRangeEnd = 260525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float4 ToFloat4(this Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &color;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorExtensions.NativeMethodInfoPtr_ToFloat4_Public_Static_float4_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float4*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe int4 ToInt4(this Color32 color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &color;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorExtensions.NativeMethodInfoPtr_ToInt4_Public_Static_int4_Color32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int4*) IL2CPP.il2cpp_object_unbox(num);
  }

  static ColorExtensions()
  {
    Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (ColorExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr);
    ColorExtensions.NativeMethodInfoPtr_ToFloat4_Public_Static_float4_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100663520);
    ColorExtensions.NativeMethodInfoPtr_ToInt4_Public_Static_int4_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorExtensions>.NativeClassPtr, 100663521);
  }

  public ColorExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
