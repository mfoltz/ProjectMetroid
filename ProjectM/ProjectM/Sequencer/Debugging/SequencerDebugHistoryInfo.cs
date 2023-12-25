// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Debugging.SequencerDebugHistoryInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SequencerDebugHistoryInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StateByteSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardByteSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameCount;
    [FieldOffset(0)]
    public int StateByteSize;
    [FieldOffset(4)]
    public int BlackboardByteSize;
    [FieldOffset(8)]
    public int FrameCount;

    static SequencerDebugHistoryInfo()
    {
      Il2CppClassPointerStore<SequencerDebugHistoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer.Debugging", nameof (SequencerDebugHistoryInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequencerDebugHistoryInfo>.NativeClassPtr);
      SequencerDebugHistoryInfo.NativeFieldInfoPtr_StateByteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerDebugHistoryInfo>.NativeClassPtr, nameof (StateByteSize));
      SequencerDebugHistoryInfo.NativeFieldInfoPtr_BlackboardByteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerDebugHistoryInfo>.NativeClassPtr, nameof (BlackboardByteSize));
      SequencerDebugHistoryInfo.NativeFieldInfoPtr_FrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequencerDebugHistoryInfo>.NativeClassPtr, nameof (FrameCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequencerDebugHistoryInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
