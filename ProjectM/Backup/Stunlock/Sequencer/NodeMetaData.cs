// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.NodeMetaData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NodeMetaData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    [FieldOffset(0)]
    public NodeTypeEnum NodeType;
    [FieldOffset(4)]
    public int Index;

    static NodeMetaData()
    {
      Il2CppClassPointerStore<NodeMetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (NodeMetaData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeMetaData>.NativeClassPtr);
      NodeMetaData.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeMetaData>.NativeClassPtr, nameof (NodeType));
      NodeMetaData.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeMetaData>.NativeClassPtr, nameof (Index));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NodeMetaData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
