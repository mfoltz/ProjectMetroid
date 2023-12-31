// Decompiled with JetBrains decompiler
// Type: ProjectM.ScreenShakeSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ScreenShakeSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ShakeLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShakeCurveX;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShakeCurveY;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShakeCurveZ;
    [FieldOffset(0)]
    public CurveData ShakeLifetime;
    [FieldOffset(1020)]
    public CurveData ShakeCurveX;
    [FieldOffset(2040)]
    public CurveData ShakeCurveY;
    [FieldOffset(3060)]
    public CurveData ShakeCurveZ;

    static ScreenShakeSettings()
    {
      Il2CppClassPointerStore<ScreenShakeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ScreenShakeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenShakeSettings>.NativeClassPtr);
      ScreenShakeSettings.NativeFieldInfoPtr_ShakeLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeSettings>.NativeClassPtr, nameof (ShakeLifetime));
      ScreenShakeSettings.NativeFieldInfoPtr_ShakeCurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeSettings>.NativeClassPtr, nameof (ShakeCurveX));
      ScreenShakeSettings.NativeFieldInfoPtr_ShakeCurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeSettings>.NativeClassPtr, nameof (ShakeCurveY));
      ScreenShakeSettings.NativeFieldInfoPtr_ShakeCurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeSettings>.NativeClassPtr, nameof (ShakeCurveZ));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenShakeSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
