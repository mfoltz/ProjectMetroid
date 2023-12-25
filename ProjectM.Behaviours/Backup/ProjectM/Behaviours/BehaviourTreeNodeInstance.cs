// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeNodeInstance
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeNodeInstance
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShouldTick;
    [FieldOffset(0)]
    public ushort NodeIndex;
    [FieldOffset(2)]
    public bool ShouldTick;

    static BehaviourTreeNodeInstance()
    {
      Il2CppClassPointerStore<BehaviourTreeNodeInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeNodeInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeNodeInstance>.NativeClassPtr);
      BehaviourTreeNodeInstance.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNodeInstance>.NativeClassPtr, nameof (NodeIndex));
      BehaviourTreeNodeInstance.NativeFieldInfoPtr_ShouldTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeNodeInstance>.NativeClassPtr, nameof (ShouldTick));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeNodeInstance>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
