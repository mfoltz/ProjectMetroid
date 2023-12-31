// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.InputCommandData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InputCommandData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalExecutedCommandDelta;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastClientFrameReceivedByServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastHandledClientCommandFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastHandledClientOriginalCommandFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_Controller;
    [FieldOffset(0)]
    public double TotalExecutedCommandDelta;
    [FieldOffset(8)]
    public int LastClientFrameReceivedByServer;
    [FieldOffset(12)]
    public int LastHandledClientCommandFrame;
    [FieldOffset(16)]
    public int LastHandledClientOriginalCommandFrame;
    [FieldOffset(20)]
    public Entity Controller;

    static InputCommandData()
    {
      Il2CppClassPointerStore<InputCommandData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (InputCommandData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputCommandData>.NativeClassPtr);
      InputCommandData.NativeFieldInfoPtr_TotalExecutedCommandDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandData>.NativeClassPtr, nameof (TotalExecutedCommandDelta));
      InputCommandData.NativeFieldInfoPtr_LastClientFrameReceivedByServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandData>.NativeClassPtr, nameof (LastClientFrameReceivedByServer));
      InputCommandData.NativeFieldInfoPtr_LastHandledClientCommandFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandData>.NativeClassPtr, nameof (LastHandledClientCommandFrame));
      InputCommandData.NativeFieldInfoPtr_LastHandledClientOriginalCommandFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandData>.NativeClassPtr, nameof (LastHandledClientOriginalCommandFrame));
      InputCommandData.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandData>.NativeClassPtr, nameof (Controller));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputCommandData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
