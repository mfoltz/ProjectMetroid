// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodPositionsRequestData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodPositionsRequestData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequestCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextRequestTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequestInterval;
    [FieldOffset(0)]
    public int RequestCount;
    [FieldOffset(4)]
    public float NextRequestTime;
    [FieldOffset(8)]
    public float RequestInterval;

    static VBloodPositionsRequestData()
    {
      Il2CppClassPointerStore<VBloodPositionsRequestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodPositionsRequestData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodPositionsRequestData>.NativeClassPtr);
      VBloodPositionsRequestData.NativeFieldInfoPtr_RequestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPositionsRequestData>.NativeClassPtr, nameof (RequestCount));
      VBloodPositionsRequestData.NativeFieldInfoPtr_NextRequestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPositionsRequestData>.NativeClassPtr, nameof (NextRequestTime));
      VBloodPositionsRequestData.NativeFieldInfoPtr_RequestInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPositionsRequestData>.NativeClassPtr, nameof (RequestInterval));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodPositionsRequestData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
