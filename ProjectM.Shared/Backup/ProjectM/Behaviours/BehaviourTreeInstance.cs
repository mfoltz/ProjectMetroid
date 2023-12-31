// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeInstance
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
  public struct BehaviourTreeInstance
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TreeEntity;
    [FieldOffset(0)]
    public Entity TreeEntity;

    static BehaviourTreeInstance()
    {
      Il2CppClassPointerStore<BehaviourTreeInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Behaviours", nameof (BehaviourTreeInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeInstance>.NativeClassPtr);
      BehaviourTreeInstance.NativeFieldInfoPtr_TreeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeInstance>.NativeClassPtr, nameof (TreeEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeInstance>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
