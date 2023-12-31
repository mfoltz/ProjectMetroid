// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeStateMetadata
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeStateMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousState;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastChangeTime;
    [FieldOffset(0)]
    public GenericEnemyState PreviousState;
    [FieldOffset(8)]
    public double LastChangeTime;

    static BehaviourTreeStateMetadata()
    {
      Il2CppClassPointerStore<BehaviourTreeStateMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Behaviours", nameof (BehaviourTreeStateMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateMetadata>.NativeClassPtr);
      BehaviourTreeStateMetadata.NativeFieldInfoPtr_PreviousState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateMetadata>.NativeClassPtr, nameof (PreviousState));
      BehaviourTreeStateMetadata.NativeFieldInfoPtr_LastChangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateMetadata>.NativeClassPtr, nameof (LastChangeTime));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
