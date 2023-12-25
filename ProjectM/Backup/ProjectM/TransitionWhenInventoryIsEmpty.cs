// Decompiled with JetBrains decompiler
// Type: ProjectM.TransitionWhenInventoryIsEmpty
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TransitionWhenInventoryIsEmpty
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TransitionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasEmpty;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasSpawned;
    [FieldOffset(0)]
    public SpawnChainData.TransitionId TransitionId;
    [FieldOffset(32)]
    public bool WasEmpty;
    [FieldOffset(33)]
    public bool HasSpawned;

    static TransitionWhenInventoryIsEmpty()
    {
      Il2CppClassPointerStore<TransitionWhenInventoryIsEmpty>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TransitionWhenInventoryIsEmpty));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionWhenInventoryIsEmpty>.NativeClassPtr);
      TransitionWhenInventoryIsEmpty.NativeFieldInfoPtr_TransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryIsEmpty>.NativeClassPtr, nameof (TransitionId));
      TransitionWhenInventoryIsEmpty.NativeFieldInfoPtr_WasEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryIsEmpty>.NativeClassPtr, nameof (WasEmpty));
      TransitionWhenInventoryIsEmpty.NativeFieldInfoPtr_HasSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionWhenInventoryIsEmpty>.NativeClassPtr, nameof (HasSpawned));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransitionWhenInventoryIsEmpty>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
