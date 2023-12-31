// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyAfterDurationCounter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyAfterDurationCounter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Timer;
    [FieldOffset(0)]
    public float Duration;
    [FieldOffset(4)]
    public float Timer;

    static DestroyAfterDurationCounter()
    {
      Il2CppClassPointerStore<DestroyAfterDurationCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroyAfterDurationCounter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyAfterDurationCounter>.NativeClassPtr);
      DestroyAfterDurationCounter.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDurationCounter>.NativeClassPtr, nameof (Duration));
      DestroyAfterDurationCounter.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDurationCounter>.NativeClassPtr, nameof (Timer));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyAfterDurationCounter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
