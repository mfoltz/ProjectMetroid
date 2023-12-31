// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.EnableRoomRoofDebuggingSingleton
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Roofs
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EnableRoomRoofDebuggingSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Mode;
    [FieldOffset(0)]
    public RoofDebugMode Mode;

    static EnableRoomRoofDebuggingSingleton()
    {
      Il2CppClassPointerStore<EnableRoomRoofDebuggingSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Roofs", nameof (EnableRoomRoofDebuggingSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableRoomRoofDebuggingSingleton>.NativeClassPtr);
      EnableRoomRoofDebuggingSingleton.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableRoomRoofDebuggingSingleton>.NativeClassPtr, nameof (Mode));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EnableRoomRoofDebuggingSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
