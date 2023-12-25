// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.GraphDebugRegisterElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GraphDebugRegisterElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GraphName;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardRegisterIndex;
    [FieldOffset(0)]
    public FixedString64 GraphName;
    [FieldOffset(64)]
    public FixedString64 RegisterName;
    [FieldOffset(128)]
    public BlackboardRegisterType Type;
    [FieldOffset(132)]
    public int BlackboardRegisterIndex;

    static GraphDebugRegisterElement()
    {
      Il2CppClassPointerStore<GraphDebugRegisterElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (GraphDebugRegisterElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphDebugRegisterElement>.NativeClassPtr);
      GraphDebugRegisterElement.NativeFieldInfoPtr_GraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphDebugRegisterElement>.NativeClassPtr, nameof (GraphName));
      GraphDebugRegisterElement.NativeFieldInfoPtr_RegisterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphDebugRegisterElement>.NativeClassPtr, nameof (RegisterName));
      GraphDebugRegisterElement.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphDebugRegisterElement>.NativeClassPtr, nameof (Type));
      GraphDebugRegisterElement.NativeFieldInfoPtr_BlackboardRegisterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphDebugRegisterElement>.NativeClassPtr, nameof (BlackboardRegisterIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphDebugRegisterElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
