// Decompiled with JetBrains decompiler
// Type: ProjectM.ScreenShake
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ScreenShake
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ShakeSpace;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForwardForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_SideForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_XDir;
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    [FieldOffset(0)]
    public ScreenShakeSpaceEnum ShakeSpace;
    [FieldOffset(4)]
    public float ForwardForce;
    [FieldOffset(8)]
    public float SideForce;
    [FieldOffset(12)]
    public Vector3 Direction;
    [FieldOffset(24)]
    public float XDir;
    [FieldOffset(28)]
    public ScreenShakeSettings Settings;

    static ScreenShake()
    {
      Il2CppClassPointerStore<ScreenShake>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ScreenShake));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenShake>.NativeClassPtr);
      ScreenShake.NativeFieldInfoPtr_ShakeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShake>.NativeClassPtr, nameof (ShakeSpace));
      ScreenShake.NativeFieldInfoPtr_ForwardForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShake>.NativeClassPtr, nameof (ForwardForce));
      ScreenShake.NativeFieldInfoPtr_SideForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShake>.NativeClassPtr, nameof (SideForce));
      ScreenShake.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShake>.NativeClassPtr, nameof (Direction));
      ScreenShake.NativeFieldInfoPtr_XDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShake>.NativeClassPtr, nameof (XDir));
      ScreenShake.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShake>.NativeClassPtr, nameof (Settings));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenShake>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
