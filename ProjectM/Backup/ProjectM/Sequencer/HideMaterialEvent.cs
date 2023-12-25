// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.HideMaterialEvent
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
  public struct HideMaterialEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(8)]
    public int RendererMask;
    [FieldOffset(12)]
    public int Importance;

    static HideMaterialEvent()
    {
      Il2CppClassPointerStore<HideMaterialEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (HideMaterialEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideMaterialEvent>.NativeClassPtr);
      HideMaterialEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialEvent>.NativeClassPtr, nameof (NodeIndex));
      HideMaterialEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialEvent>.NativeClassPtr, nameof (TargetParameter));
      HideMaterialEvent.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialEvent>.NativeClassPtr, nameof (RendererMask));
      HideMaterialEvent.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideMaterialEvent>.NativeClassPtr, nameof (Importance));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideMaterialEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
