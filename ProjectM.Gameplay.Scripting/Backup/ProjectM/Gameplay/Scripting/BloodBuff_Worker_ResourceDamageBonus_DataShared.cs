// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Worker_ResourceDamageBonus_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Worker_ResourceDamageBonus_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinIncreasedHarvestDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxIncreasedHarvestDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreasedWoodModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreasedMaterialModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreasedVegetationModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinIncreasedHarvestDamage;
    [FieldOffset(4)]
    public float MaxIncreasedHarvestDamage;
    [FieldOffset(8)]
    public ModificationId IncreasedWoodModificationId;
    [FieldOffset(12)]
    public ModificationId IncreasedMaterialModificationId;
    [FieldOffset(16)]
    public ModificationId IncreasedVegetationModificationId;
    [FieldOffset(20)]
    public float RequiredBloodPercentage;

    static BloodBuff_Worker_ResourceDamageBonus_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Worker_ResourceDamageBonus_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr);
      BloodBuff_Worker_ResourceDamageBonus_DataShared.NativeFieldInfoPtr_MinIncreasedHarvestDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr, nameof (MinIncreasedHarvestDamage));
      BloodBuff_Worker_ResourceDamageBonus_DataShared.NativeFieldInfoPtr_MaxIncreasedHarvestDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr, nameof (MaxIncreasedHarvestDamage));
      BloodBuff_Worker_ResourceDamageBonus_DataShared.NativeFieldInfoPtr_IncreasedWoodModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr, nameof (IncreasedWoodModificationId));
      BloodBuff_Worker_ResourceDamageBonus_DataShared.NativeFieldInfoPtr_IncreasedMaterialModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr, nameof (IncreasedMaterialModificationId));
      BloodBuff_Worker_ResourceDamageBonus_DataShared.NativeFieldInfoPtr_IncreasedVegetationModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr, nameof (IncreasedVegetationModificationId));
      BloodBuff_Worker_ResourceDamageBonus_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Worker_ResourceDamageBonus_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
