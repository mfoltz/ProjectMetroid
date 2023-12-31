// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeStateBuffsBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeStateBuffsBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    [FieldOffset(0)]
    public PrefabGUID BuffGuid;
    [FieldOffset(4)]
    public GenericEnemyState State;

    static BehaviourTreeStateBuffsBuffer()
    {
      Il2CppClassPointerStore<BehaviourTreeStateBuffsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Behaviours", nameof (BehaviourTreeStateBuffsBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsBuffer>.NativeClassPtr);
      BehaviourTreeStateBuffsBuffer.NativeFieldInfoPtr_BuffGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsBuffer>.NativeClassPtr, nameof (BuffGuid));
      BehaviourTreeStateBuffsBuffer.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsBuffer>.NativeClassPtr, nameof (State));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
