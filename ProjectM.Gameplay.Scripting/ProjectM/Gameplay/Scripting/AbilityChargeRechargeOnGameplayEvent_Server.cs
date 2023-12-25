// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.AbilityChargeRechargeOnGameplayEvent_Server
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityChargeRechargeOnGameplayEvent_Server
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    [FieldOffset(0)]
    public float Value;
    [FieldOffset(4)]
    public int AbilitySlot;
    [FieldOffset(8)]
    public RechargeType Type;

    static AbilityChargeRechargeOnGameplayEvent_Server()
    {
      Il2CppClassPointerStore<AbilityChargeRechargeOnGameplayEvent_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (AbilityChargeRechargeOnGameplayEvent_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityChargeRechargeOnGameplayEvent_Server>.NativeClassPtr);
      AbilityChargeRechargeOnGameplayEvent_Server.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeRechargeOnGameplayEvent_Server>.NativeClassPtr, nameof (Value));
      AbilityChargeRechargeOnGameplayEvent_Server.NativeFieldInfoPtr_AbilitySlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeRechargeOnGameplayEvent_Server>.NativeClassPtr, nameof (AbilitySlot));
      AbilityChargeRechargeOnGameplayEvent_Server.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeRechargeOnGameplayEvent_Server>.NativeClassPtr, nameof (Type));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityChargeRechargeOnGameplayEvent_Server>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
