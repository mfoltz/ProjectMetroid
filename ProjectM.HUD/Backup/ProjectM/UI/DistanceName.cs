// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DistanceName
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
  public struct DistanceName
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public int MaxDistance;
    [FieldOffset(4)]
    public LocalizationKey Name;

    static DistanceName()
    {
      Il2CppClassPointerStore<DistanceName>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DistanceName));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistanceName>.NativeClassPtr);
      DistanceName.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistanceName>.NativeClassPtr, nameof (MaxDistance));
      DistanceName.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistanceName>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DistanceName>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
