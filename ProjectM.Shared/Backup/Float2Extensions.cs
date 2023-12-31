// Decompiled with JetBrains decompiler
// Type: Float2Extensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;

#nullable disable
public static class Float2Extensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Float3FromXz_Public_Static_float3_float2_Single_0;

  [CallerCount(81)]
  [CachedScanResults(RefRangeStart = 716848, RefRangeEnd = 716929, XrefRangeStart = 716848, XrefRangeEnd = 716848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float3 Float3FromXz(this float2 value, float y = 0.0f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Float2Extensions.NativeMethodInfoPtr_Float3FromXz_Public_Static_float3_float2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float3*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Float2Extensions()
  {
    Il2CppClassPointerStore<Float2Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (Float2Extensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Float2Extensions>.NativeClassPtr);
    Float2Extensions.NativeMethodInfoPtr_Float3FromXz_Public_Static_float3_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float2Extensions>.NativeClassPtr, 100663461);
  }

  public Float2Extensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
