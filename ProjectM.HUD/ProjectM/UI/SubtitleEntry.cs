// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SubtitleEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct SubtitleEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    [FieldOffset(0)]
    public float StartTime;
    [FieldOffset(4)]
    public float EndTime;
    [FieldOffset(8)]
    public LocalizationKey Text;

    static SubtitleEntry()
    {
      Il2CppClassPointerStore<SubtitleEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SubtitleEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubtitleEntry>.NativeClassPtr);
      SubtitleEntry.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitleEntry>.NativeClassPtr, nameof (StartTime));
      SubtitleEntry.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitleEntry>.NativeClassPtr, nameof (EndTime));
      SubtitleEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitleEntry>.NativeClassPtr, nameof (Text));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubtitleEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
