// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Worker_Gallop_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Worker_Gallop_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinIncreasedGalopSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxIncreasedGalopSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreasedGalopSpeedModificationId;
    [FieldOffset(0)]
    public float MinIncreasedGalopSpeed;
    [FieldOffset(4)]
    public float MaxIncreasedGalopSpeed;
    [FieldOffset(8)]
    public float RequiredBloodPercentage;
    [FieldOffset(12)]
    public ModificationId IncreasedGalopSpeedModificationId;

    static BloodBuff_Worker_Gallop_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Worker_Gallop_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Worker_Gallop_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Worker_Gallop_DataShared>.NativeClassPtr);
      BloodBuff_Worker_Gallop_DataShared.NativeFieldInfoPtr_MinIncreasedGalopSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Gallop_DataShared>.NativeClassPtr, nameof (MinIncreasedGalopSpeed));
      BloodBuff_Worker_Gallop_DataShared.NativeFieldInfoPtr_MaxIncreasedGalopSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Gallop_DataShared>.NativeClassPtr, nameof (MaxIncreasedGalopSpeed));
      BloodBuff_Worker_Gallop_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Gallop_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuff_Worker_Gallop_DataShared.NativeFieldInfoPtr_IncreasedGalopSpeedModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Gallop_DataShared>.NativeClassPtr, nameof (IncreasedGalopSpeedModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Worker_Gallop_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
