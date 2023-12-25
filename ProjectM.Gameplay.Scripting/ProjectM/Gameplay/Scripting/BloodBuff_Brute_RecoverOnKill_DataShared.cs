// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Brute_RecoverOnKill_DataShared
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
  public struct BloodBuff_Brute_RecoverOnKill_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHealingReceived;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealingReceived;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecoverHealthOnKill;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnHealingReceivedListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_AffectRecovery;
    [FieldOffset(0)]
    public float MinHealingReceived;
    [FieldOffset(4)]
    public float MaxHealingReceived;
    [FieldOffset(8)]
    public float RecoverHealthOnKill;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;
    [FieldOffset(16)]
    public ListenerId OnHealingReceivedListener;
    [FieldOffset(24)]
    public bool AffectRecovery;

    static BloodBuff_Brute_RecoverOnKill_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Brute_RecoverOnKill_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr);
      BloodBuff_Brute_RecoverOnKill_DataShared.NativeFieldInfoPtr_MinHealingReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr, nameof (MinHealingReceived));
      BloodBuff_Brute_RecoverOnKill_DataShared.NativeFieldInfoPtr_MaxHealingReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr, nameof (MaxHealingReceived));
      BloodBuff_Brute_RecoverOnKill_DataShared.NativeFieldInfoPtr_RecoverHealthOnKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr, nameof (RecoverHealthOnKill));
      BloodBuff_Brute_RecoverOnKill_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuff_Brute_RecoverOnKill_DataShared.NativeFieldInfoPtr_OnHealingReceivedListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr, nameof (OnHealingReceivedListener));
      BloodBuff_Brute_RecoverOnKill_DataShared.NativeFieldInfoPtr_AffectRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr, nameof (AffectRecovery));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Brute_RecoverOnKill_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
