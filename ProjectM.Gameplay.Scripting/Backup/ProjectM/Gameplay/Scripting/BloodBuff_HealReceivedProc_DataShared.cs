﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_HealReceivedProc_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_HealReceivedProc_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChancePerRelativeHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProcBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnHealingListener;
    [FieldOffset(0)]
    public float ChancePerRelativeHealth;
    [FieldOffset(4)]
    public PrefabGUID ProcBuff;
    [FieldOffset(8)]
    public float RequiredBloodPercentage;
    [FieldOffset(12)]
    public ListenerId OnHealingListener;

    static BloodBuff_HealReceivedProc_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_HealReceivedProc_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_HealReceivedProc_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_HealReceivedProc_DataShared>.NativeClassPtr);
      BloodBuff_HealReceivedProc_DataShared.NativeFieldInfoPtr_ChancePerRelativeHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_HealReceivedProc_DataShared>.NativeClassPtr, nameof (ChancePerRelativeHealth));
      BloodBuff_HealReceivedProc_DataShared.NativeFieldInfoPtr_ProcBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_HealReceivedProc_DataShared>.NativeClassPtr, nameof (ProcBuff));
      BloodBuff_HealReceivedProc_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_HealReceivedProc_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuff_HealReceivedProc_DataShared.NativeFieldInfoPtr_OnHealingListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_HealReceivedProc_DataShared>.NativeClassPtr, nameof (OnHealingListener));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_HealReceivedProc_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
