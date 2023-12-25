// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BasicAnnouncement
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BasicAnnouncement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubHeaderKey;
    [FieldOffset(0)]
    public LocalizationKey HeaderKey;
    [FieldOffset(16)]
    public LocalizationKey SubHeaderKey;

    static BasicAnnouncement()
    {
      Il2CppClassPointerStore<BasicAnnouncement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BasicAnnouncement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicAnnouncement>.NativeClassPtr);
      BasicAnnouncement.NativeFieldInfoPtr_HeaderKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAnnouncement>.NativeClassPtr, nameof (HeaderKey));
      BasicAnnouncement.NativeFieldInfoPtr_SubHeaderKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicAnnouncement>.NativeClassPtr, nameof (SubHeaderKey));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BasicAnnouncement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
