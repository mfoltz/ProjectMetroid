// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerTime
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerTime
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnmodifiedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeOnServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModifiedTimeOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameCount;
    [FieldOffset(0)]
    public double Time;
    [FieldOffset(8)]
    public double UnmodifiedTime;
    [FieldOffset(16)]
    public double TimeOnServer;
    [FieldOffset(24)]
    public double ModifiedTimeOffset;
    [FieldOffset(32)]
    public int FrameCount;

    static ServerTime()
    {
      Il2CppClassPointerStore<ServerTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerTime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerTime>.NativeClassPtr);
      ServerTime.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerTime>.NativeClassPtr, nameof (Time));
      ServerTime.NativeFieldInfoPtr_UnmodifiedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerTime>.NativeClassPtr, nameof (UnmodifiedTime));
      ServerTime.NativeFieldInfoPtr_TimeOnServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerTime>.NativeClassPtr, nameof (TimeOnServer));
      ServerTime.NativeFieldInfoPtr_ModifiedTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerTime>.NativeClassPtr, nameof (ModifiedTimeOffset));
      ServerTime.NativeFieldInfoPtr_FrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerTime>.NativeClassPtr, nameof (FrameCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerTime>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
