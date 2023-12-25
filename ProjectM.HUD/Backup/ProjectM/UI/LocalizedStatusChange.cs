// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizedStatusChange
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct LocalizedStatusChange
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Reason;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKey;
    [FieldOffset(0)]
    public ConnectionStatusChangeReason Reason;
    [FieldOffset(4)]
    public LocalizationKey LocalizationKey;

    static LocalizedStatusChange()
    {
      Il2CppClassPointerStore<LocalizedStatusChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (LocalizedStatusChange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStatusChange>.NativeClassPtr);
      LocalizedStatusChange.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStatusChange>.NativeClassPtr, nameof (Reason));
      LocalizedStatusChange.NativeFieldInfoPtr_LocalizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStatusChange>.NativeClassPtr, nameof (LocalizationKey));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedStatusChange>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
