// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_PhysCritChanceBonus_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_PhysCritChanceBonus_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinPhysicalCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPhysicalCriticalStrikeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalCriticalStrikeChanceModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinPhysicalCriticalStrikeChance;
    [FieldOffset(4)]
    public float MaxPhysicalCriticalStrikeChance;
    [FieldOffset(8)]
    public ModificationId PhysicalCriticalStrikeChanceModificationId;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;

    static BloodBuff_PhysCritChanceBonus_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_PhysCritChanceBonus_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_PhysCritChanceBonus_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_PhysCritChanceBonus_DataShared>.NativeClassPtr);
      BloodBuff_PhysCritChanceBonus_DataShared.NativeFieldInfoPtr_MinPhysicalCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PhysCritChanceBonus_DataShared>.NativeClassPtr, nameof (MinPhysicalCriticalStrikeChance));
      BloodBuff_PhysCritChanceBonus_DataShared.NativeFieldInfoPtr_MaxPhysicalCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PhysCritChanceBonus_DataShared>.NativeClassPtr, nameof (MaxPhysicalCriticalStrikeChance));
      BloodBuff_PhysCritChanceBonus_DataShared.NativeFieldInfoPtr_PhysicalCriticalStrikeChanceModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PhysCritChanceBonus_DataShared>.NativeClassPtr, nameof (PhysicalCriticalStrikeChanceModificationId));
      BloodBuff_PhysCritChanceBonus_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PhysCritChanceBonus_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_PhysCritChanceBonus_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
