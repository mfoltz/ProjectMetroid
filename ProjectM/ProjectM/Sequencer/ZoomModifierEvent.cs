// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ZoomModifierEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ZoomModifierEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeightParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinZoomBonusParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZoomBonusParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinBonusPitchParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxBonusPitchParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomCameraTargetParameter;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public int Importance;
    [FieldOffset(8)]
    public BlackboardParameterRuntime WeightParameter;
    [FieldOffset(12)]
    public BlackboardParameterRuntime MinZoomBonusParameter;
    [FieldOffset(16)]
    public BlackboardParameterRuntime MaxZoomBonusParameter;
    [FieldOffset(20)]
    public BlackboardParameterRuntime MinBonusPitchParameter;
    [FieldOffset(24)]
    public BlackboardParameterRuntime MaxBonusPitchParameter;
    [FieldOffset(28)]
    public BlackboardParameterRuntime CustomCameraTargetParameter;

    static ZoomModifierEvent()
    {
      Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ZoomModifierEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr);
      ZoomModifierEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, nameof (NodeIndex));
      ZoomModifierEvent.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, nameof (Importance));
      ZoomModifierEvent.NativeFieldInfoPtr_WeightParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, nameof (WeightParameter));
      ZoomModifierEvent.NativeFieldInfoPtr_MinZoomBonusParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, nameof (MinZoomBonusParameter));
      ZoomModifierEvent.NativeFieldInfoPtr_MaxZoomBonusParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, nameof (MaxZoomBonusParameter));
      ZoomModifierEvent.NativeFieldInfoPtr_MinBonusPitchParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, nameof (MinBonusPitchParameter));
      ZoomModifierEvent.NativeFieldInfoPtr_MaxBonusPitchParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, nameof (MaxBonusPitchParameter));
      ZoomModifierEvent.NativeFieldInfoPtr_CustomCameraTargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, nameof (CustomCameraTargetParameter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ZoomModifierEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
