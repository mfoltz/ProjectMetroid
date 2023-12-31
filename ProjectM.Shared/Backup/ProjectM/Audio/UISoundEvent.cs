// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.UISoundEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UISoundEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventGuid;
    [FieldOffset(0)]
    public FmodEventGuid EventGuid;

    static UISoundEvent()
    {
      Il2CppClassPointerStore<UISoundEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Audio", nameof (UISoundEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISoundEvent>.NativeClassPtr);
      UISoundEvent.NativeFieldInfoPtr_EventGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISoundEvent>.NativeClassPtr, nameof (EventGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UISoundEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
