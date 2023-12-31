// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomizedSpawnChainChild
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RandomizedSpawnChainChild
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent;
    [FieldOffset(0)]
    public Entity Parent;

    static RandomizedSpawnChainChild()
    {
      Il2CppClassPointerStore<RandomizedSpawnChainChild>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RandomizedSpawnChainChild));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainChild>.NativeClassPtr);
      RandomizedSpawnChainChild.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainChild>.NativeClassPtr, nameof (Parent));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainChild>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
