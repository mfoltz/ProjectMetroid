// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMove_Client
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiMove_Client
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SimulatedServerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SimulatedPathFinishTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SimulatedPathFinished;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerStuck;
    private static readonly System.IntPtr NativeFieldInfoPtr_HardSeekServerPosition;
    [FieldOffset(0)]
    public float2 SimulatedServerPosition;
    [FieldOffset(8)]
    public double SimulatedPathFinishTime;
    [FieldOffset(16)]
    public ModificationId SpeedModId;
    [FieldOffset(20)]
    public bool SimulatedPathFinished;
    [FieldOffset(21)]
    public bool ServerStuck;
    [FieldOffset(22)]
    public bool HardSeekServerPosition;

    static AiMove_Client()
    {
      Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiMove_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr);
      AiMove_Client.NativeFieldInfoPtr_SimulatedServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr, nameof (SimulatedServerPosition));
      AiMove_Client.NativeFieldInfoPtr_SimulatedPathFinishTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr, nameof (SimulatedPathFinishTime));
      AiMove_Client.NativeFieldInfoPtr_SpeedModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr, nameof (SpeedModId));
      AiMove_Client.NativeFieldInfoPtr_SimulatedPathFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr, nameof (SimulatedPathFinished));
      AiMove_Client.NativeFieldInfoPtr_ServerStuck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr, nameof (ServerStuck));
      AiMove_Client.NativeFieldInfoPtr_HardSeekServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr, nameof (HardSeekServerPosition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiMove_Client>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
