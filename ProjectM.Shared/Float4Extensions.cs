// Decompiled with JetBrains decompiler
// Type: Float4Extensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
public static class Float4Extensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ToColor_Public_Static_Color_float4_0;

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 260526, RefRangeEnd = 260536, XrefRangeStart = 260526, XrefRangeEnd = 260536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color ToColor(this float4 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &vector;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Float4Extensions.NativeMethodInfoPtr_ToColor_Public_Static_Color_float4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Float4Extensions()
  {
    Il2CppClassPointerStore<Float4Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (Float4Extensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Float4Extensions>.NativeClassPtr);
    Float4Extensions.NativeMethodInfoPtr_ToColor_Public_Static_Color_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float4Extensions>.NativeClassPtr, 100663522);
  }

  public Float4Extensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
