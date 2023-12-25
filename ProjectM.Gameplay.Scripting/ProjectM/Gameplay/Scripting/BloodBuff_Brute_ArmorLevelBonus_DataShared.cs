// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Brute_ArmorLevelBonus_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Brute_ArmorLevelBonus_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GearLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseGearLevelModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseAttackSpeedModificationId;
    [FieldOffset(0)]
    public float GearLevel;
    [FieldOffset(4)]
    public float MinValue;
    [FieldOffset(8)]
    public float MaxValue;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;
    [FieldOffset(16)]
    public ModificationId IncreaseGearLevelModificationId;
    [FieldOffset(20)]
    public ModificationId IncreaseAttackSpeedModificationId;

    static BloodBuff_Brute_ArmorLevelBonus_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Brute_ArmorLevelBonus_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr);
      BloodBuff_Brute_ArmorLevelBonus_DataShared.NativeFieldInfoPtr_GearLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr, nameof (GearLevel));
      BloodBuff_Brute_ArmorLevelBonus_DataShared.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr, nameof (MinValue));
      BloodBuff_Brute_ArmorLevelBonus_DataShared.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr, nameof (MaxValue));
      BloodBuff_Brute_ArmorLevelBonus_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuff_Brute_ArmorLevelBonus_DataShared.NativeFieldInfoPtr_IncreaseGearLevelModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr, nameof (IncreaseGearLevelModificationId));
      BloodBuff_Brute_ArmorLevelBonus_DataShared.NativeFieldInfoPtr_IncreaseAttackSpeedModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr, nameof (IncreaseAttackSpeedModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Brute_ArmorLevelBonus_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
