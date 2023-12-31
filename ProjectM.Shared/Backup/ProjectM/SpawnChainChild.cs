// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainChild
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
  public struct SpawnChainChild
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChain;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChainElementIndex;
    [FieldOffset(0)]
    public Entity SpawnChain;
    [FieldOffset(8)]
    public int SpawnChainElementIndex;

    static SpawnChainChild()
    {
      Il2CppClassPointerStore<SpawnChainChild>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainChild));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainChild>.NativeClassPtr);
      SpawnChainChild.NativeFieldInfoPtr_SpawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainChild>.NativeClassPtr, nameof (SpawnChain));
      SpawnChainChild.NativeFieldInfoPtr_SpawnChainElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainChild>.NativeClassPtr, nameof (SpawnChainElementIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainChild>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
