// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OpenMenuEvent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OpenMenuEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Menu;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitDataEntity;
    [FieldOffset(0)]
    public HUDMenuType Menu;
    [FieldOffset(4)]
    public Entity InitDataEntity;

    static OpenMenuEvent()
    {
      Il2CppClassPointerStore<OpenMenuEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (OpenMenuEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenMenuEvent>.NativeClassPtr);
      OpenMenuEvent.NativeFieldInfoPtr_Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenMenuEvent>.NativeClassPtr, nameof (Menu));
      OpenMenuEvent.NativeFieldInfoPtr_InitDataEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenMenuEvent>.NativeClassPtr, nameof (InitDataEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OpenMenuEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
