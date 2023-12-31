// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeStateChangedEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeStateChangedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousState;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewState;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public GenericEnemyState PreviousState;
    [FieldOffset(12)]
    public GenericEnemyState NewState;

    static BehaviourTreeStateChangedEvent()
    {
      Il2CppClassPointerStore<BehaviourTreeStateChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Behaviours", nameof (BehaviourTreeStateChangedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateChangedEvent>.NativeClassPtr);
      BehaviourTreeStateChangedEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateChangedEvent>.NativeClassPtr, nameof (Entity));
      BehaviourTreeStateChangedEvent.NativeFieldInfoPtr_PreviousState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateChangedEvent>.NativeClassPtr, nameof (PreviousState));
      BehaviourTreeStateChangedEvent.NativeFieldInfoPtr_NewState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateChangedEvent>.NativeClassPtr, nameof (NewState));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateChangedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
