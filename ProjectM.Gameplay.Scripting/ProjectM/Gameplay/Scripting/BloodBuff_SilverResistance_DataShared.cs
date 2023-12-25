﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_SilverResistance_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_SilverResistance_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    [FieldOffset(0)]
    public float MinBonus;
    [FieldOffset(4)]
    public float MaxBonus;
    [FieldOffset(8)]
    public ModificationId ModificationId;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;

    static BloodBuff_SilverResistance_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_SilverResistance_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_SilverResistance_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_SilverResistance_DataShared>.NativeClassPtr);
      BloodBuff_SilverResistance_DataShared.NativeFieldInfoPtr_MinBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_SilverResistance_DataShared>.NativeClassPtr, nameof (MinBonus));
      BloodBuff_SilverResistance_DataShared.NativeFieldInfoPtr_MaxBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_SilverResistance_DataShared>.NativeClassPtr, nameof (MaxBonus));
      BloodBuff_SilverResistance_DataShared.NativeFieldInfoPtr_ModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_SilverResistance_DataShared>.NativeClassPtr, nameof (ModificationId));
      BloodBuff_SilverResistance_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_SilverResistance_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_SilverResistance_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
