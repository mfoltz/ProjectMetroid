// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeBlackboardDebugElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeBlackboardDebugElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterType;
    [FieldOffset(0)]
    public FixedString64 Guid;
    [FieldOffset(64)]
    public FixedString64 Name;
    [FieldOffset(128)]
    public int Index;
    [FieldOffset(132)]
    public BlackboardRegisterType RegisterType;

    static BehaviourTreeBlackboardDebugElement()
    {
      Il2CppClassPointerStore<BehaviourTreeBlackboardDebugElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Behaviours", nameof (BehaviourTreeBlackboardDebugElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeBlackboardDebugElement>.NativeClassPtr);
      BehaviourTreeBlackboardDebugElement.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlackboardDebugElement>.NativeClassPtr, nameof (Guid));
      BehaviourTreeBlackboardDebugElement.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlackboardDebugElement>.NativeClassPtr, nameof (Name));
      BehaviourTreeBlackboardDebugElement.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlackboardDebugElement>.NativeClassPtr, nameof (Index));
      BehaviourTreeBlackboardDebugElement.NativeFieldInfoPtr_RegisterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeBlackboardDebugElement>.NativeClassPtr, nameof (RegisterType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeBlackboardDebugElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
