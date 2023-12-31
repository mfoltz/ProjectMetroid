// Decompiled with JetBrains decompiler
// Type: ColorUtilityStunlock
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public static class ColorUtilityStunlock : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_KellysMaxContrastSet;
  private static readonly System.IntPtr NativeFieldInfoPtr_BoyntonOptimized;
  private static readonly System.IntPtr NativeMethodInfoPtr_UIntToColor_Public_Static_Color_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ColorFromARGB_Public_Static_Color_Byte_Byte_Byte_Byte_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715159, XrefRangeEnd = 715163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color UIntToColor(uint color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &color;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorUtilityStunlock.NativeMethodInfoPtr_UIntToColor_Public_Static_Color_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715163, XrefRangeEnd = 715164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color ColorFromARGB(byte a, byte r, byte g, byte b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &r;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &g;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorUtilityStunlock.NativeMethodInfoPtr_ColorFromARGB_Public_Static_Color_Byte_Byte_Byte_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  static ColorUtilityStunlock()
  {
    Il2CppClassPointerStore<ColorUtilityStunlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (ColorUtilityStunlock));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtilityStunlock>.NativeClassPtr);
    ColorUtilityStunlock.NativeFieldInfoPtr_KellysMaxContrastSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilityStunlock>.NativeClassPtr, nameof (KellysMaxContrastSet));
    ColorUtilityStunlock.NativeFieldInfoPtr_BoyntonOptimized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUtilityStunlock>.NativeClassPtr, nameof (BoyntonOptimized));
    ColorUtilityStunlock.NativeMethodInfoPtr_UIntToColor_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilityStunlock>.NativeClassPtr, 100663360);
    ColorUtilityStunlock.NativeMethodInfoPtr_ColorFromARGB_Public_Static_Color_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilityStunlock>.NativeClassPtr, 100663361);
  }

  public ColorUtilityStunlock(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppStructArray<Color> KellysMaxContrastSet
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ColorUtilityStunlock.NativeFieldInfoPtr_KellysMaxContrastSet, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : new Il2CppStructArray<Color>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ColorUtilityStunlock.NativeFieldInfoPtr_KellysMaxContrastSet, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<Color> BoyntonOptimized
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ColorUtilityStunlock.NativeFieldInfoPtr_BoyntonOptimized, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Color>) null : new Il2CppStructArray<Color>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ColorUtilityStunlock.NativeFieldInfoPtr_BoyntonOptimized, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
