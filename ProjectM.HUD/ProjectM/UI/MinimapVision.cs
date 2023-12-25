// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MinimapVision
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MinimapVision
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    [FieldOffset(0)]
    public Vector2 Position;
    [FieldOffset(8)]
    public float Radius;

    static MinimapVision()
    {
      Il2CppClassPointerStore<MinimapVision>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MinimapVision));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimapVision>.NativeClassPtr);
      MinimapVision.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapVision>.NativeClassPtr, nameof (Position));
      MinimapVision.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimapVision>.NativeClassPtr, nameof (Radius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinimapVision>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
