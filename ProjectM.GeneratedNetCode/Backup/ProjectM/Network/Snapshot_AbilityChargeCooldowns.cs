// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_AbilityChargeCooldowns
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_AbilityChargeCooldowns
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCooldown;
    [FieldOffset(0)]
    public int AbilitySlotIndex;
    [FieldOffset(4)]
    public float Cooldown;
    [FieldOffset(8)]
    public float CurrentCooldown;

    static Snapshot_AbilityChargeCooldowns()
    {
      Il2CppClassPointerStore<Snapshot_AbilityChargeCooldowns>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_AbilityChargeCooldowns));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_AbilityChargeCooldowns>.NativeClassPtr);
      Snapshot_AbilityChargeCooldowns.NativeFieldInfoPtr_AbilitySlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_AbilityChargeCooldowns>.NativeClassPtr, nameof (AbilitySlotIndex));
      Snapshot_AbilityChargeCooldowns.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_AbilityChargeCooldowns>.NativeClassPtr, nameof (Cooldown));
      Snapshot_AbilityChargeCooldowns.NativeFieldInfoPtr_CurrentCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_AbilityChargeCooldowns>.NativeClassPtr, nameof (CurrentCooldown));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_AbilityChargeCooldowns>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
