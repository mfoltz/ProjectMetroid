// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.GraphEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GraphEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackType;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_GraphDurationParameterIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_GraphTimeParameterIndex;
    [FieldOffset(0)]
    public GraphPlaybackType PlaybackType;
    [FieldOffset(4)]
    public int NodeIndex;
    [FieldOffset(8)]
    public int StartIndex;
    [FieldOffset(12)]
    public int GraphDurationParameterIndex;
    [FieldOffset(16)]
    public int GraphTimeParameterIndex;

    static GraphEvent()
    {
      Il2CppClassPointerStore<GraphEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (GraphEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphEvent>.NativeClassPtr);
      GraphEvent.NativeFieldInfoPtr_PlaybackType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEvent>.NativeClassPtr, nameof (PlaybackType));
      GraphEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEvent>.NativeClassPtr, nameof (NodeIndex));
      GraphEvent.NativeFieldInfoPtr_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEvent>.NativeClassPtr, nameof (StartIndex));
      GraphEvent.NativeFieldInfoPtr_GraphDurationParameterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEvent>.NativeClassPtr, nameof (GraphDurationParameterIndex));
      GraphEvent.NativeFieldInfoPtr_GraphTimeParameterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphEvent>.NativeClassPtr, nameof (GraphTimeParameterIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
