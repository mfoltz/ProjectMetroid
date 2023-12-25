// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_AllResistance_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_AllResistance_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId_Silver;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId_Garlic;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId_Fire;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId_Holy;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId_Sun;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinBonus;
    [FieldOffset(4)]
    public float MaxBonus;
    [FieldOffset(8)]
    public ModificationId ModificationId_Silver;
    [FieldOffset(12)]
    public ModificationId ModificationId_Garlic;
    [FieldOffset(16)]
    public ModificationId ModificationId_Fire;
    [FieldOffset(20)]
    public ModificationId ModificationId_Holy;
    [FieldOffset(24)]
    public ModificationId ModificationId_Sun;
    [FieldOffset(28)]
    public float RequiredBloodPercentage;

    static BloodBuff_AllResistance_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_AllResistance_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr);
      BloodBuff_AllResistance_DataShared.NativeFieldInfoPtr_MinBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, nameof (MinBonus));
      BloodBuff_AllResistance_DataShared.NativeFieldInfoPtr_MaxBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, nameof (MaxBonus));
      BloodBuff_AllResistance_DataShared.NativeFieldInfoPtr_ModificationId_Silver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, nameof (ModificationId_Silver));
      BloodBuff_AllResistance_DataShared.NativeFieldInfoPtr_ModificationId_Garlic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, nameof (ModificationId_Garlic));
      BloodBuff_AllResistance_DataShared.NativeFieldInfoPtr_ModificationId_Fire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, nameof (ModificationId_Fire));
      BloodBuff_AllResistance_DataShared.NativeFieldInfoPtr_ModificationId_Holy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, nameof (ModificationId_Holy));
      BloodBuff_AllResistance_DataShared.NativeFieldInfoPtr_ModificationId_Sun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, nameof (ModificationId_Sun));
      BloodBuff_AllResistance_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_AllResistance_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
