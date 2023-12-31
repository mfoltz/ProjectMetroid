// Decompiled with JetBrains decompiler
// Type: ProjectM.LoadToTargetWorld
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
  public struct LoadToTargetWorld
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrimPersistentData;
    [FieldOffset(0)]
    public WorldType WorldType;
    [FieldOffset(4)]
    public bool TrimPersistentData;

    static LoadToTargetWorld()
    {
      Il2CppClassPointerStore<LoadToTargetWorld>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LoadToTargetWorld));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadToTargetWorld>.NativeClassPtr);
      LoadToTargetWorld.NativeFieldInfoPtr_WorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadToTargetWorld>.NativeClassPtr, nameof (WorldType));
      LoadToTargetWorld.NativeFieldInfoPtr_TrimPersistentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadToTargetWorld>.NativeClassPtr, nameof (TrimPersistentData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadToTargetWorld>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
