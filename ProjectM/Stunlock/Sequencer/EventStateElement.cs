// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.EventStateElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EventStateElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventStruct;
    [FieldOffset(0)]
    public EventStruct EventStruct;

    static EventStateElement()
    {
      Il2CppClassPointerStore<EventStateElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (EventStateElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventStateElement>.NativeClassPtr);
      EventStateElement.NativeFieldInfoPtr_EventStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStateElement>.NativeClassPtr, nameof (EventStruct));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventStateElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
