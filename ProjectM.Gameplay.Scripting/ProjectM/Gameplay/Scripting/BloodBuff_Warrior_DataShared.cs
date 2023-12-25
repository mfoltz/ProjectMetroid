﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Warrior_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Warrior_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPowerMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalModificationId;
    [FieldOffset(0)]
    public float BloodQualityThreshold;
    [FieldOffset(4)]
    public float PhysicalPowerMax;
    [FieldOffset(8)]
    public ModificationId PhysicalModificationId;

    static BloodBuff_Warrior_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Warrior_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Warrior_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Warrior_DataShared>.NativeClassPtr);
      BloodBuff_Warrior_DataShared.NativeFieldInfoPtr_BloodQualityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_DataShared>.NativeClassPtr, nameof (BloodQualityThreshold));
      BloodBuff_Warrior_DataShared.NativeFieldInfoPtr_PhysicalPowerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_DataShared>.NativeClassPtr, nameof (PhysicalPowerMax));
      BloodBuff_Warrior_DataShared.NativeFieldInfoPtr_PhysicalModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Warrior_DataShared>.NativeClassPtr, nameof (PhysicalModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Warrior_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
