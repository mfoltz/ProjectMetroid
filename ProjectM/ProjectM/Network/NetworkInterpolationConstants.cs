// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkInterpolationConstants
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public static class NetworkInterpolationConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TELEPORT_MAX_RANGE;
    private static readonly System.IntPtr NativeFieldInfoPtr_TELEPORT_MAX_RANGE_SQ;
    private static readonly System.IntPtr NativeFieldInfoPtr_SYNC_RATE_WHILE_SIMULATING;
    private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_SEND_FPS;
    private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_SEND_FRAME_TIME;

    static NetworkInterpolationConstants()
    {
      Il2CppClassPointerStore<NetworkInterpolationConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (NetworkInterpolationConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkInterpolationConstants>.NativeClassPtr);
      NetworkInterpolationConstants.NativeFieldInfoPtr_TELEPORT_MAX_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolationConstants>.NativeClassPtr, nameof (TELEPORT_MAX_RANGE));
      NetworkInterpolationConstants.NativeFieldInfoPtr_TELEPORT_MAX_RANGE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolationConstants>.NativeClassPtr, nameof (TELEPORT_MAX_RANGE_SQ));
      NetworkInterpolationConstants.NativeFieldInfoPtr_SYNC_RATE_WHILE_SIMULATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolationConstants>.NativeClassPtr, nameof (SYNC_RATE_WHILE_SIMULATING));
      NetworkInterpolationConstants.NativeFieldInfoPtr_SERVER_SEND_FPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolationConstants>.NativeClassPtr, nameof (SERVER_SEND_FPS));
      NetworkInterpolationConstants.NativeFieldInfoPtr_SERVER_SEND_FRAME_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolationConstants>.NativeClassPtr, nameof (SERVER_SEND_FRAME_TIME));
    }

    public NetworkInterpolationConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float TELEPORT_MAX_RANGE
    {
      get
      {
        float teleportMaxRange;
        IL2CPP.il2cpp_field_static_get_value(NetworkInterpolationConstants.NativeFieldInfoPtr_TELEPORT_MAX_RANGE, (void*) &teleportMaxRange);
        return teleportMaxRange;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkInterpolationConstants.NativeFieldInfoPtr_TELEPORT_MAX_RANGE, (void*) &value);
      }
    }

    public static unsafe float TELEPORT_MAX_RANGE_SQ
    {
      get
      {
        float teleportMaxRangeSq;
        IL2CPP.il2cpp_field_static_get_value(NetworkInterpolationConstants.NativeFieldInfoPtr_TELEPORT_MAX_RANGE_SQ, (void*) &teleportMaxRangeSq);
        return teleportMaxRangeSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkInterpolationConstants.NativeFieldInfoPtr_TELEPORT_MAX_RANGE_SQ, (void*) &value);
      }
    }

    public static unsafe float SYNC_RATE_WHILE_SIMULATING
    {
      get
      {
        float rateWhileSimulating;
        IL2CPP.il2cpp_field_static_get_value(NetworkInterpolationConstants.NativeFieldInfoPtr_SYNC_RATE_WHILE_SIMULATING, (void*) &rateWhileSimulating);
        return rateWhileSimulating;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkInterpolationConstants.NativeFieldInfoPtr_SYNC_RATE_WHILE_SIMULATING, (void*) &value);
      }
    }

    public static unsafe int SERVER_SEND_FPS
    {
      get
      {
        int serverSendFps;
        IL2CPP.il2cpp_field_static_get_value(NetworkInterpolationConstants.NativeFieldInfoPtr_SERVER_SEND_FPS, (void*) &serverSendFps);
        return serverSendFps;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkInterpolationConstants.NativeFieldInfoPtr_SERVER_SEND_FPS, (void*) &value);
      }
    }

    public static unsafe float SERVER_SEND_FRAME_TIME
    {
      get
      {
        float serverSendFrameTime;
        IL2CPP.il2cpp_field_static_get_value(NetworkInterpolationConstants.NativeFieldInfoPtr_SERVER_SEND_FRAME_TIME, (void*) &serverSendFrameTime);
        return serverSendFrameTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkInterpolationConstants.NativeFieldInfoPtr_SERVER_SEND_FRAME_TIME, (void*) &value);
      }
    }
  }
}
