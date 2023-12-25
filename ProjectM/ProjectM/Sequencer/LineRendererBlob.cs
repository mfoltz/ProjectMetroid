// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.LineRendererBlob
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
  public struct LineRendererBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineRendererIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionIndex;
    [FieldOffset(0)]
    public BlackboardParameterRuntime PositionParameter;
    [FieldOffset(4)]
    public int LineRendererIndex;
    [FieldOffset(8)]
    public int PositionIndex;

    static LineRendererBlob()
    {
      Il2CppClassPointerStore<LineRendererBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (LineRendererBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineRendererBlob>.NativeClassPtr);
      LineRendererBlob.NativeFieldInfoPtr_PositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineRendererBlob>.NativeClassPtr, nameof (PositionParameter));
      LineRendererBlob.NativeFieldInfoPtr_LineRendererIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineRendererBlob>.NativeClassPtr, nameof (LineRendererIndex));
      LineRendererBlob.NativeFieldInfoPtr_PositionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineRendererBlob>.NativeClassPtr, nameof (PositionIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineRendererBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
