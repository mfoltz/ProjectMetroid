// Decompiled with JetBrains decompiler
// Type: ProjectM.PerformanceLoggingConstants
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class PerformanceLoggingConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SNAPSHOT_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_PERSIST_FREQUENCY_SECONDS;

    static PerformanceLoggingConstants()
    {
      Il2CppClassPointerStore<PerformanceLoggingConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PerformanceLoggingConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceLoggingConstants>.NativeClassPtr);
      PerformanceLoggingConstants.NativeFieldInfoPtr_SNAPSHOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggingConstants>.NativeClassPtr, nameof (SNAPSHOT_COUNT));
      PerformanceLoggingConstants.NativeFieldInfoPtr_PERSIST_FREQUENCY_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggingConstants>.NativeClassPtr, nameof (PERSIST_FREQUENCY_SECONDS));
    }

    public PerformanceLoggingConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int SNAPSHOT_COUNT
    {
      get
      {
        int snapshotCount;
        IL2CPP.il2cpp_field_static_get_value(PerformanceLoggingConstants.NativeFieldInfoPtr_SNAPSHOT_COUNT, (void*) &snapshotCount);
        return snapshotCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PerformanceLoggingConstants.NativeFieldInfoPtr_SNAPSHOT_COUNT, (void*) &value);
      }
    }

    public static unsafe int PERSIST_FREQUENCY_SECONDS
    {
      get
      {
        int frequencySeconds;
        IL2CPP.il2cpp_field_static_get_value(PerformanceLoggingConstants.NativeFieldInfoPtr_PERSIST_FREQUENCY_SECONDS, (void*) &frequencySeconds);
        return frequencySeconds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PerformanceLoggingConstants.NativeFieldInfoPtr_PERSIST_FREQUENCY_SECONDS, (void*) &value);
      }
    }
  }
}
