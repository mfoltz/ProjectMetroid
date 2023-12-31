// Decompiled with JetBrains decompiler
// Type: ProjectM.Buff_StacksIncreaseEvent
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
  public struct Buff_StacksIncreaseEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldStacks;
    [FieldOffset(0)]
    public Entity Buff;
    [FieldOffset(8)]
    public byte NewStacks;
    [FieldOffset(9)]
    public byte OldStacks;

    static Buff_StacksIncreaseEvent()
    {
      Il2CppClassPointerStore<Buff_StacksIncreaseEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Buff_StacksIncreaseEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff_StacksIncreaseEvent>.NativeClassPtr);
      Buff_StacksIncreaseEvent.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_StacksIncreaseEvent>.NativeClassPtr, nameof (Buff));
      Buff_StacksIncreaseEvent.NativeFieldInfoPtr_NewStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_StacksIncreaseEvent>.NativeClassPtr, nameof (NewStacks));
      Buff_StacksIncreaseEvent.NativeFieldInfoPtr_OldStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buff_StacksIncreaseEvent>.NativeClassPtr, nameof (OldStacks));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff_StacksIncreaseEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
