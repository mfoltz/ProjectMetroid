// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ModifierButtons
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifierButtons
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Shift;
    private static readonly System.IntPtr NativeFieldInfoPtr_Control;
    private static readonly System.IntPtr NativeFieldInfoPtr_Alt;
    [FieldOffset(0)]
    public bool Shift;
    [FieldOffset(1)]
    public bool Control;
    [FieldOffset(2)]
    public bool Alt;

    static ModifierButtons()
    {
      Il2CppClassPointerStore<ModifierButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ModifierButtons));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierButtons>.NativeClassPtr);
      ModifierButtons.NativeFieldInfoPtr_Shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierButtons>.NativeClassPtr, nameof (Shift));
      ModifierButtons.NativeFieldInfoPtr_Control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierButtons>.NativeClassPtr, nameof (Control));
      ModifierButtons.NativeFieldInfoPtr_Alt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierButtons>.NativeClassPtr, nameof (Alt));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifierButtons>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
