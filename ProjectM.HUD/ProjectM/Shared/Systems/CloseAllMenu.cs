// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Systems.CloseAllMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared.Systems
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CloseAllMenu
  {
    static CloseAllMenu()
    {
      Il2CppClassPointerStore<CloseAllMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.Shared.Systems", nameof (CloseAllMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloseAllMenu>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CloseAllMenu>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
