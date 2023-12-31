// Decompiled with JetBrains decompiler
// Type: Int2Extensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;

#nullable disable
public static class Int2Extensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Int3FromXz_Public_Static_int3_int2_Int32_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716929, RefRangeEnd = 716931, XrefRangeStart = 716929, XrefRangeEnd = 716929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int3 Int3FromXz(this int2 value, int y = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Int2Extensions.NativeMethodInfoPtr_Int3FromXz_Public_Static_int3_int2_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int3*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Int2Extensions()
  {
    Il2CppClassPointerStore<Int2Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (Int2Extensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int2Extensions>.NativeClassPtr);
    Int2Extensions.NativeMethodInfoPtr_Int3FromXz_Public_Static_int3_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int2Extensions>.NativeClassPtr, 100663462);
  }

  public Int2Extensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
