// Decompiled with JetBrains decompiler
// Type: ProjectM.StressTest
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class StressTest : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StressTestClientManager;
    private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1051622, RefRangeEnd = 1051624, XrefRangeStart = 1051615, XrefRangeEnd = 1051622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Shutdown()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StressTest.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StressTest()
    {
      Il2CppClassPointerStore<StressTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StressTest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StressTest>.NativeClassPtr);
      StressTest.NativeFieldInfoPtr_StressTestClientManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StressTest>.NativeClassPtr, nameof (StressTestClientManager));
      StressTest.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StressTest>.NativeClassPtr, 100682650);
    }

    public StressTest(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe IStressTestClientManager StressTestClientManager
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StressTest.NativeFieldInfoPtr_StressTestClientManager, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IStressTestClientManager) null : new IStressTestClientManager(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StressTest.NativeFieldInfoPtr_StressTestClientManager, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
