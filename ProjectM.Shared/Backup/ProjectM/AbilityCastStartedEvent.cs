// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityCastStartedEvent
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
  public struct AbilityCastStartedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    [FieldOffset(0)]
    public double Time;
    [FieldOffset(8)]
    public Entity Character;
    [FieldOffset(16)]
    public Entity Ability;
    [FieldOffset(24)]
    public Entity AbilityGroup;

    static AbilityCastStartedEvent()
    {
      Il2CppClassPointerStore<AbilityCastStartedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityCastStartedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCastStartedEvent>.NativeClassPtr);
      AbilityCastStartedEvent.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStartedEvent>.NativeClassPtr, nameof (Time));
      AbilityCastStartedEvent.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStartedEvent>.NativeClassPtr, nameof (Character));
      AbilityCastStartedEvent.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStartedEvent>.NativeClassPtr, nameof (Ability));
      AbilityCastStartedEvent.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStartedEvent>.NativeClassPtr, nameof (AbilityGroup));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCastStartedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
