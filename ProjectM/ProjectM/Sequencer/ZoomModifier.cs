// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ZoomModifier
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ZoomModifier
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CameraTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinZoomBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZoomBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPitchBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPitchBonus;
    [FieldOffset(0)]
    public Entity CameraTarget;
    [FieldOffset(8)]
    public int Importance;
    [FieldOffset(12)]
    public float Weight;
    [FieldOffset(16)]
    public float MinZoomBonus;
    [FieldOffset(20)]
    public float MaxZoomBonus;
    [FieldOffset(24)]
    public float MinPitchBonus;
    [FieldOffset(28)]
    public float MaxPitchBonus;

    static ZoomModifier()
    {
      Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ZoomModifier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr);
      ZoomModifier.NativeFieldInfoPtr_CameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr, nameof (CameraTarget));
      ZoomModifier.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr, nameof (Importance));
      ZoomModifier.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr, nameof (Weight));
      ZoomModifier.NativeFieldInfoPtr_MinZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr, nameof (MinZoomBonus));
      ZoomModifier.NativeFieldInfoPtr_MaxZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr, nameof (MaxZoomBonus));
      ZoomModifier.NativeFieldInfoPtr_MinPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr, nameof (MinPitchBonus));
      ZoomModifier.NativeFieldInfoPtr_MaxPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr, nameof (MaxPitchBonus));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ZoomModifier>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
