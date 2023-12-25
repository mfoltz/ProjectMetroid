// Decompiled with JetBrains decompiler
// Type: ProjectM.CounterTriggerEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CounterTriggerEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Receiver;
    private static readonly System.IntPtr NativeFieldInfoPtr_CounterBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sender;
    [FieldOffset(0)]
    public Entity Receiver;
    [FieldOffset(8)]
    public Entity CounterBuff;
    [FieldOffset(16)]
    public Entity SpellTarget;
    [FieldOffset(24)]
    public Entity Sender;

    static CounterTriggerEvent()
    {
      Il2CppClassPointerStore<CounterTriggerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CounterTriggerEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterTriggerEvent>.NativeClassPtr);
      CounterTriggerEvent.NativeFieldInfoPtr_Receiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterTriggerEvent>.NativeClassPtr, nameof (Receiver));
      CounterTriggerEvent.NativeFieldInfoPtr_CounterBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterTriggerEvent>.NativeClassPtr, nameof (CounterBuff));
      CounterTriggerEvent.NativeFieldInfoPtr_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterTriggerEvent>.NativeClassPtr, nameof (SpellTarget));
      CounterTriggerEvent.NativeFieldInfoPtr_Sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterTriggerEvent>.NativeClassPtr, nameof (Sender));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CounterTriggerEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
