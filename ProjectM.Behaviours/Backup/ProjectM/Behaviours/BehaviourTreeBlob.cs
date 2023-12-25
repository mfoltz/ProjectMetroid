// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeBlob
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Nodes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeDebugData;
    [FieldOffset(0)]
    public BlobArray<BehaviourTreeNode> Nodes;
    [FieldOffset(8)]
    public BlobArray<BehaviourTreeNode_DebugData> NodeDebugData;

    static BehaviourTreeBlob()
    {
      Il2CppClassPointerStore<BehaviourTreeBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeBlob>.NativeClassPtr);
      BehaviourTreeBlob.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlob>.NativeClassPtr, nameof (Nodes));
      BehaviourTreeBlob.NativeFieldInfoPtr_NodeDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlob>.NativeClassPtr, nameof (NodeDebugData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
