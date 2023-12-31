// Decompiled with JetBrains decompiler
// Type: ProjectM.FloatExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class FloatExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EPSILON;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApproxEquals_Public_Static_Boolean_Single_Single_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 764793, RefRangeEnd = 764804, XrefRangeStart = 764793, XrefRangeEnd = 764793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ApproxEquals(this float a, float b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatExtensions.NativeMethodInfoPtr_ApproxEquals_Public_Static_Boolean_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FloatExtensions()
    {
      Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FloatExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr);
      FloatExtensions.NativeFieldInfoPtr_EPSILON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, nameof (EPSILON));
      FloatExtensions.NativeMethodInfoPtr_ApproxEquals_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100667544);
    }

    public FloatExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float EPSILON
    {
      get
      {
        float epsilon;
        IL2CPP.il2cpp_field_static_get_value(FloatExtensions.NativeFieldInfoPtr_EPSILON, (void*) &epsilon);
        return epsilon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FloatExtensions.NativeFieldInfoPtr_EPSILON, (void*) &value);
      }
    }
  }
}
