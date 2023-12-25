// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowInSpellbookBar
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShowInSpellbookBar
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisplayLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideLifetimeText;
    [FieldOffset(0)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(4)]
    public bool DisplayLifetime;
    [FieldOffset(5)]
    public bool HideLifetimeText;

    static ShowInSpellbookBar()
    {
      Il2CppClassPointerStore<ShowInSpellbookBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (ShowInSpellbookBar));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowInSpellbookBar>.NativeClassPtr);
      ShowInSpellbookBar.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookBar>.NativeClassPtr, nameof (PrefabGUID));
      ShowInSpellbookBar.NativeFieldInfoPtr_DisplayLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookBar>.NativeClassPtr, nameof (DisplayLifetime));
      ShowInSpellbookBar.NativeFieldInfoPtr_HideLifetimeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowInSpellbookBar>.NativeClassPtr, nameof (HideLifetimeText));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowInSpellbookBar>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
