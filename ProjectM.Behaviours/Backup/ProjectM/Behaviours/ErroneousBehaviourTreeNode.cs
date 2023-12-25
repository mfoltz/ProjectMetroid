// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.ErroneousBehaviourTreeNode
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ErroneousBehaviourTreeNode
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Message;
    private static readonly System.IntPtr NativeFieldInfoPtr_Subject;
    private static readonly System.IntPtr NativeFieldInfoPtr_BehaviourTree;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildNodeIndex;
    [FieldOffset(0)]
    public FixedString128 Message;
    [FieldOffset(128)]
    public Entity Subject;
    [FieldOffset(136)]
    public Entity BehaviourTree;
    [FieldOffset(144)]
    public GenericEnemyState State;
    [FieldOffset(148)]
    public ushort NodeIndex;
    [FieldOffset(150)]
    public ushort ChildNodeIndex;

    static ErroneousBehaviourTreeNode()
    {
      Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (ErroneousBehaviourTreeNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr);
      ErroneousBehaviourTreeNode.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr, nameof (Message));
      ErroneousBehaviourTreeNode.NativeFieldInfoPtr_Subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr, nameof (Subject));
      ErroneousBehaviourTreeNode.NativeFieldInfoPtr_BehaviourTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr, nameof (BehaviourTree));
      ErroneousBehaviourTreeNode.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr, nameof (State));
      ErroneousBehaviourTreeNode.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr, nameof (NodeIndex));
      ErroneousBehaviourTreeNode.NativeFieldInfoPtr_ChildNodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr, nameof (ChildNodeIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErroneousBehaviourTreeNode>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
