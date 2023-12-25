// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ScreenShakeEvent
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
  public struct ScreenShakeEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScreenShakeSpace;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScreenShakeSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_SideForceParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectionParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRangeParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRangeParameter;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public ScreenShakeSpaceEnum ScreenShakeSpace;
    [FieldOffset(8)]
    public ScreenShakeSettings ScreenShakeSettings;
    [FieldOffset(4088)]
    public BlackboardParameterRuntime ForceParameter;
    [FieldOffset(4092)]
    public BlackboardParameterRuntime SideForceParameter;
    [FieldOffset(4096)]
    public BlackboardParameterRuntime DirectionParameter;
    [FieldOffset(4100)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(4104)]
    public BlackboardParameterRuntime PositionParameter;
    [FieldOffset(4108)]
    public BlackboardParameterRuntime MinRangeParameter;
    [FieldOffset(4112)]
    public BlackboardParameterRuntime MaxRangeParameter;

    static ScreenShakeEvent()
    {
      Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ScreenShakeEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr);
      ScreenShakeEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (NodeIndex));
      ScreenShakeEvent.NativeFieldInfoPtr_ScreenShakeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (ScreenShakeSpace));
      ScreenShakeEvent.NativeFieldInfoPtr_ScreenShakeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (ScreenShakeSettings));
      ScreenShakeEvent.NativeFieldInfoPtr_ForceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (ForceParameter));
      ScreenShakeEvent.NativeFieldInfoPtr_SideForceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (SideForceParameter));
      ScreenShakeEvent.NativeFieldInfoPtr_DirectionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (DirectionParameter));
      ScreenShakeEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (TargetParameter));
      ScreenShakeEvent.NativeFieldInfoPtr_PositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (PositionParameter));
      ScreenShakeEvent.NativeFieldInfoPtr_MinRangeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (MinRangeParameter));
      ScreenShakeEvent.NativeFieldInfoPtr_MaxRangeParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, nameof (MaxRangeParameter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenShakeEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
