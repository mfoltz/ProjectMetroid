// Decompiled with JetBrains decompiler
// Type: ProjectM.PerformanceMonitoringUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class PerformanceMonitoringUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClientFrameTimeMs_Public_Static_Single_World_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1054623, RefRangeEnd = 1054625, XrefRangeStart = 1054614, XrefRangeEnd = 1054623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetClientFrameTimeMs(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PerformanceMonitoringUtility.NativeMethodInfoPtr_GetClientFrameTimeMs_Public_Static_Single_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PerformanceMonitoringUtility()
    {
      Il2CppClassPointerStore<PerformanceMonitoringUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PerformanceMonitoringUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceMonitoringUtility>.NativeClassPtr);
      PerformanceMonitoringUtility.NativeMethodInfoPtr_GetClientFrameTimeMs_Public_Static_Single_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMonitoringUtility>.NativeClassPtr, 100682981);
    }

    public PerformanceMonitoringUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
