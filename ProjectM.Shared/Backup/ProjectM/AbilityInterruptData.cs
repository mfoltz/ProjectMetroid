// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityInterruptData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityInterruptData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownOnInterrupt;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptTypes;
    [FieldOffset(0)]
    public float CooldownOnInterrupt;
    [FieldOffset(4)]
    public InterruptTypes InterruptTypes;

    static AbilityInterruptData()
    {
      Il2CppClassPointerStore<AbilityInterruptData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityInterruptData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityInterruptData>.NativeClassPtr);
      AbilityInterruptData.NativeFieldInfoPtr_CooldownOnInterrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityInterruptData>.NativeClassPtr, nameof (CooldownOnInterrupt));
      AbilityInterruptData.NativeFieldInfoPtr_InterruptTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityInterruptData>.NativeClassPtr, nameof (InterruptTypes));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityInterruptData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
