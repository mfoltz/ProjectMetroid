// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Worker_Pulverize_DataShared
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
  public struct BloodBuff_Worker_Pulverize_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PulverizeBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_PulverizeChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PulverizeDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageDealtListener;
    [FieldOffset(0)]
    public PrefabGUID PulverizeBuff;
    [FieldOffset(4)]
    public float RequiredBloodPercentage;
    [FieldOffset(8)]
    public float PulverizeChance;
    [FieldOffset(12)]
    public DealDamageParameters PulverizeDamage;
    [FieldOffset(124)]
    public SequenceGUID SequenceGuid;
    [FieldOffset(128)]
    public SequenceState SequenceState;
    [FieldOffset(136)]
    public ListenerId OnDamageDealtListener;

    static BloodBuff_Worker_Pulverize_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Worker_Pulverize_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr);
      BloodBuff_Worker_Pulverize_DataShared.NativeFieldInfoPtr_PulverizeBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr, nameof (PulverizeBuff));
      BloodBuff_Worker_Pulverize_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuff_Worker_Pulverize_DataShared.NativeFieldInfoPtr_PulverizeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr, nameof (PulverizeChance));
      BloodBuff_Worker_Pulverize_DataShared.NativeFieldInfoPtr_PulverizeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr, nameof (PulverizeDamage));
      BloodBuff_Worker_Pulverize_DataShared.NativeFieldInfoPtr_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr, nameof (SequenceGuid));
      BloodBuff_Worker_Pulverize_DataShared.NativeFieldInfoPtr_SequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr, nameof (SequenceState));
      BloodBuff_Worker_Pulverize_DataShared.NativeFieldInfoPtr_OnDamageDealtListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr, nameof (OnDamageDealtListener));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Worker_Pulverize_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
