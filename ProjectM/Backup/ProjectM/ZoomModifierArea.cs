// Decompiled with JetBrains decompiler
// Type: ProjectM.ZoomModifierArea
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ZoomModifierArea
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LerpDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeepZoomBonusDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinZoomBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZoomBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPitchBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPitchBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveOnLocalCharacter;
    [FieldOffset(0)]
    public double LerpDuration;
    [FieldOffset(8)]
    public float Weight;
    [FieldOffset(12)]
    public float Radius;
    [FieldOffset(16)]
    public float KeepZoomBonusDistance;
    [FieldOffset(20)]
    public float MinZoomBonus;
    [FieldOffset(24)]
    public float MaxZoomBonus;
    [FieldOffset(28)]
    public float MinPitchBonus;
    [FieldOffset(32)]
    public float MaxPitchBonus;
    [FieldOffset(36)]
    public int Importance;
    [FieldOffset(40)]
    public bool ActiveOnLocalCharacter;

    static ZoomModifierArea()
    {
      Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ZoomModifierArea));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr);
      ZoomModifierArea.NativeFieldInfoPtr_LerpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (LerpDuration));
      ZoomModifierArea.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (Weight));
      ZoomModifierArea.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (Radius));
      ZoomModifierArea.NativeFieldInfoPtr_KeepZoomBonusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (KeepZoomBonusDistance));
      ZoomModifierArea.NativeFieldInfoPtr_MinZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (MinZoomBonus));
      ZoomModifierArea.NativeFieldInfoPtr_MaxZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (MaxZoomBonus));
      ZoomModifierArea.NativeFieldInfoPtr_MinPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (MinPitchBonus));
      ZoomModifierArea.NativeFieldInfoPtr_MaxPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (MaxPitchBonus));
      ZoomModifierArea.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (Importance));
      ZoomModifierArea.NativeFieldInfoPtr_ActiveOnLocalCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, nameof (ActiveOnLocalCharacter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ZoomModifierArea>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
