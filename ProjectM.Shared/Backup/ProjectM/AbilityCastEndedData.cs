// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityCastEndedData
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
  public struct AbilityCastEndedData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_SlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasInterrupted;
    [FieldOffset(0)]
    public Entity Character;
    [FieldOffset(8)]
    public Entity AbilityGroup;
    [FieldOffset(16)]
    public Entity Ability;
    [FieldOffset(24)]
    public int SlotIndex;
    [FieldOffset(28)]
    public bool WasInterrupted;

    static AbilityCastEndedData()
    {
      Il2CppClassPointerStore<AbilityCastEndedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityCastEndedData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCastEndedData>.NativeClassPtr);
      AbilityCastEndedData.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastEndedData>.NativeClassPtr, nameof (Character));
      AbilityCastEndedData.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastEndedData>.NativeClassPtr, nameof (AbilityGroup));
      AbilityCastEndedData.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastEndedData>.NativeClassPtr, nameof (Ability));
      AbilityCastEndedData.NativeFieldInfoPtr_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastEndedData>.NativeClassPtr, nameof (SlotIndex));
      AbilityCastEndedData.NativeFieldInfoPtr_WasInterrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastEndedData>.NativeClassPtr, nameof (WasInterrupted));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCastEndedData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
