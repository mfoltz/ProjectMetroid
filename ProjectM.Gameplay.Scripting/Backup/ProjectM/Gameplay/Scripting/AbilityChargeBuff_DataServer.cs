// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.AbilityChargeBuff_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityChargeBuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponChargeAbilityPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeWhenInterrupted;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetOnAnyAbilityUseForSlot;
    [FieldOffset(0)]
    public PrefabGUID AbilityGroup;
    [FieldOffset(4)]
    public int AbilitySlot;
    [FieldOffset(8)]
    public ModificationId AbilityModificationId;
    [FieldOffset(12)]
    public int WeaponChargeAbilityPriority;
    [FieldOffset(16)]
    public bool ConsumeWhenInterrupted;
    [FieldOffset(17)]
    public bool ResetOnAnyAbilityUseForSlot;

    static AbilityChargeBuff_DataServer()
    {
      Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (AbilityChargeBuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr);
      AbilityChargeBuff_DataServer.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr, nameof (AbilityGroup));
      AbilityChargeBuff_DataServer.NativeFieldInfoPtr_AbilitySlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr, nameof (AbilitySlot));
      AbilityChargeBuff_DataServer.NativeFieldInfoPtr_AbilityModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr, nameof (AbilityModificationId));
      AbilityChargeBuff_DataServer.NativeFieldInfoPtr_WeaponChargeAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr, nameof (WeaponChargeAbilityPriority));
      AbilityChargeBuff_DataServer.NativeFieldInfoPtr_ConsumeWhenInterrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr, nameof (ConsumeWhenInterrupted));
      AbilityChargeBuff_DataServer.NativeFieldInfoPtr_ResetOnAnyAbilityUseForSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr, nameof (ResetOnAnyAbilityUseForSlot));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityChargeBuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
