// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.AbilityChargeCooldowns
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityChargeCooldowns
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ExpectedAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeWhenInterrupted;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetOnAbilityAnySlotUse;
    [FieldOffset(0)]
    public PrefabGUID ExpectedAbility;
    [FieldOffset(4)]
    public int AbilitySlotIndex;
    [FieldOffset(8)]
    public float Cooldown;
    [FieldOffset(12)]
    public float CurrentCooldown;
    [FieldOffset(16)]
    public bool ConsumeWhenInterrupted;
    [FieldOffset(17)]
    public bool ResetOnAbilityAnySlotUse;

    static AbilityChargeCooldowns()
    {
      Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (AbilityChargeCooldowns));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr);
      AbilityChargeCooldowns.NativeFieldInfoPtr_ExpectedAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr, nameof (ExpectedAbility));
      AbilityChargeCooldowns.NativeFieldInfoPtr_AbilitySlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr, nameof (AbilitySlotIndex));
      AbilityChargeCooldowns.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr, nameof (Cooldown));
      AbilityChargeCooldowns.NativeFieldInfoPtr_CurrentCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr, nameof (CurrentCooldown));
      AbilityChargeCooldowns.NativeFieldInfoPtr_ConsumeWhenInterrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr, nameof (ConsumeWhenInterrupted));
      AbilityChargeCooldowns.NativeFieldInfoPtr_ResetOnAbilityAnySlotUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr, nameof (ResetOnAbilityAnySlotUse));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityChargeCooldowns>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
