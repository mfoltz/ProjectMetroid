// Decompiled with JetBrains decompiler
// Type: ProjectM.Auth.ServerListExtendedData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Auth
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerListExtendedData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DaysRunning;
    [FieldOffset(0)]
    public int DaysRunning;

    static ServerListExtendedData()
    {
      Il2CppClassPointerStore<ServerListExtendedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Auth", nameof (ServerListExtendedData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListExtendedData>.NativeClassPtr);
      ServerListExtendedData.NativeFieldInfoPtr_DaysRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListExtendedData>.NativeClassPtr, nameof (DaysRunning));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListExtendedData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
