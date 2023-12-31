// Decompiled with JetBrains decompiler
// Type: ProjectM.AnalogInputExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class AnalogInputExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToIndex_Public_Static_Int32_AnalogInput_0;

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 740893, RefRangeEnd = 740900, XrefRangeStart = 740893, XrefRangeEnd = 740893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int ToIndex(this AnalogInput analogInput)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &analogInput;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnalogInputExtensions.NativeMethodInfoPtr_ToIndex_Public_Static_Int32_AnalogInput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AnalogInputExtensions()
    {
      Il2CppClassPointerStore<AnalogInputExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AnalogInputExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalogInputExtensions>.NativeClassPtr);
      AnalogInputExtensions.NativeMethodInfoPtr_ToIndex_Public_Static_Int32_AnalogInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogInputExtensions>.NativeClassPtr, 100665407);
    }

    public AnalogInputExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
