// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Vortex
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Vortex
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryRadius;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrimaryVortexActive_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SecondaryVortexActive_Public_get_Boolean_0;
    [FieldOffset(0)]
    public Vector2 PrimaryPosition;
    [FieldOffset(8)]
    public Vector2 SecondaryPosition;
    [FieldOffset(16)]
    public float PrimaryRadius;
    [FieldOffset(20)]
    public float SecondaryRadius;

    public unsafe bool PrimaryVortexActive
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Vortex.NativeMethodInfoPtr_get_PrimaryVortexActive_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool SecondaryVortexActive
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Vortex.NativeMethodInfoPtr_get_SecondaryVortexActive_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static Vortex()
    {
      Il2CppClassPointerStore<Vortex>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (Vortex));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vortex>.NativeClassPtr);
      Vortex.NativeFieldInfoPtr_PrimaryPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vortex>.NativeClassPtr, nameof (PrimaryPosition));
      Vortex.NativeFieldInfoPtr_SecondaryPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vortex>.NativeClassPtr, nameof (SecondaryPosition));
      Vortex.NativeFieldInfoPtr_PrimaryRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vortex>.NativeClassPtr, nameof (PrimaryRadius));
      Vortex.NativeFieldInfoPtr_SecondaryRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vortex>.NativeClassPtr, nameof (SecondaryRadius));
      Vortex.NativeMethodInfoPtr_get_PrimaryVortexActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vortex>.NativeClassPtr, 100668189);
      Vortex.NativeMethodInfoPtr_get_SecondaryVortexActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vortex>.NativeClassPtr, 100668190);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vortex>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
