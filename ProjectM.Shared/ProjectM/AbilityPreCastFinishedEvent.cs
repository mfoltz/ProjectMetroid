// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityPreCastFinishedEvent
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
  public struct AbilityPreCastFinishedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    [FieldOffset(0)]
    public Entity Character;
    [FieldOffset(8)]
    public Entity Ability;
    [FieldOffset(16)]
    public Entity AbilityGroup;

    static AbilityPreCastFinishedEvent()
    {
      Il2CppClassPointerStore<AbilityPreCastFinishedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityPreCastFinishedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityPreCastFinishedEvent>.NativeClassPtr);
      AbilityPreCastFinishedEvent.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPreCastFinishedEvent>.NativeClassPtr, nameof (Character));
      AbilityPreCastFinishedEvent.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPreCastFinishedEvent>.NativeClassPtr, nameof (Ability));
      AbilityPreCastFinishedEvent.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPreCastFinishedEvent>.NativeClassPtr, nameof (AbilityGroup));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityPreCastFinishedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
