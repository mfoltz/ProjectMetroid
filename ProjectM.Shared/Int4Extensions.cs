// Decompiled with JetBrains decompiler
// Type: Int4Extensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
public static class Int4Extensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ToColor32_Public_Static_Color32_int4_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717254, XrefRangeEnd = 717255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color32 ToColor32(this int4 vector)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &vector;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Int4Extensions.NativeMethodInfoPtr_ToColor32_Public_Static_Color32_int4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color32*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Int4Extensions()
  {
    Il2CppClassPointerStore<Int4Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (Int4Extensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int4Extensions>.NativeClassPtr);
    Int4Extensions.NativeMethodInfoPtr_ToColor32_Public_Static_Color32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int4Extensions>.NativeClassPtr, 100663523);
  }

  public Int4Extensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
