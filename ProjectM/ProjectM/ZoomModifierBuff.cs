﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.ZoomModifierBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ZoomModifierBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinZoomBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZoomBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPitchBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPitchBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    [FieldOffset(0)]
    public float MinZoomBonus;
    [FieldOffset(4)]
    public float MaxZoomBonus;
    [FieldOffset(8)]
    public float MinPitchBonus;
    [FieldOffset(12)]
    public float MaxPitchBonus;
    [FieldOffset(16)]
    public int Importance;

    static ZoomModifierBuff()
    {
      Il2CppClassPointerStore<ZoomModifierBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ZoomModifierBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZoomModifierBuff>.NativeClassPtr);
      ZoomModifierBuff.NativeFieldInfoPtr_MinZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierBuff>.NativeClassPtr, nameof (MinZoomBonus));
      ZoomModifierBuff.NativeFieldInfoPtr_MaxZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierBuff>.NativeClassPtr, nameof (MaxZoomBonus));
      ZoomModifierBuff.NativeFieldInfoPtr_MinPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierBuff>.NativeClassPtr, nameof (MinPitchBonus));
      ZoomModifierBuff.NativeFieldInfoPtr_MaxPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierBuff>.NativeClassPtr, nameof (MaxPitchBonus));
      ZoomModifierBuff.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierBuff>.NativeClassPtr, nameof (Importance));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ZoomModifierBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
