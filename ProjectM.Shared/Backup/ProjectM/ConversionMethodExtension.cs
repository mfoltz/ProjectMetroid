// Decompiled with JetBrains decompiler
// Type: ProjectM.ConversionMethodExtension
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class ConversionMethodExtension : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsConvertOnDemand_Public_Static_Boolean_PrefabConversionMethod_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734935, RefRangeEnd = 734936, XrefRangeStart = 734935, XrefRangeEnd = 734935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsConvertOnDemand(this PrefabConversionMethod method)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &method;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConversionMethodExtension.NativeMethodInfoPtr_IsConvertOnDemand_Public_Static_Boolean_PrefabConversionMethod_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ConversionMethodExtension()
    {
      Il2CppClassPointerStore<ConversionMethodExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConversionMethodExtension));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversionMethodExtension>.NativeClassPtr);
      ConversionMethodExtension.NativeMethodInfoPtr_IsConvertOnDemand_Public_Static_Boolean_PrefabConversionMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionMethodExtension>.NativeClassPtr, 100664903);
    }

    public ConversionMethodExtension(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
