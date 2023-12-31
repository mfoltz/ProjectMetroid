// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionSourceExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Shared
{
  public static class ConditionSourceExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDataFields_Public_Static_ConditionDataFields_ConditionSource_0;

    [CallerCount(90)]
    [CachedScanResults(RefRangeStart = 800516, RefRangeEnd = 800606, XrefRangeStart = 800516, XrefRangeEnd = 800516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ConditionDataFields GetDataFields(this ConditionSource source)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &source;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionSourceExtensions.NativeMethodInfoPtr_GetDataFields_Public_Static_ConditionDataFields_ConditionSource_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ConditionDataFields*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ConditionSourceExtensions()
    {
      Il2CppClassPointerStore<ConditionSourceExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionSourceExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionSourceExtensions>.NativeClassPtr);
      ConditionSourceExtensions.NativeMethodInfoPtr_GetDataFields_Public_Static_ConditionDataFields_ConditionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionSourceExtensions>.NativeClassPtr, 100670606);
    }

    public ConditionSourceExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
