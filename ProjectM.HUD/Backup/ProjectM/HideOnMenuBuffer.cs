// Decompiled with JetBrains decompiler
// Type: ProjectM.HideOnMenuBuffer
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using ProjectM.UI;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HideOnMenuBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Menu;
    [FieldOffset(0)]
    public HUDMenuType Menu;

    static HideOnMenuBuffer()
    {
      Il2CppClassPointerStore<HideOnMenuBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (HideOnMenuBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideOnMenuBuffer>.NativeClassPtr);
      HideOnMenuBuffer.NativeFieldInfoPtr_Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideOnMenuBuffer>.NativeClassPtr, nameof (Menu));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideOnMenuBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
