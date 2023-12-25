// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_PrimaryProc_FreeCast_DataShared
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
  public struct BloodBuff_PrimaryProc_FreeCast_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeCastBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageDealtListener;
    [FieldOffset(0)]
    public float MinBonus;
    [FieldOffset(4)]
    public float MaxBonus;
    [FieldOffset(8)]
    public PrefabGUID FreeCastBuff;
    [FieldOffset(12)]
    public float RequiredBloodPercentage;
    [FieldOffset(16)]
    public ListenerId OnDamageDealtListener;

    static BloodBuff_PrimaryProc_FreeCast_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_PrimaryProc_FreeCast_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_PrimaryProc_FreeCast_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_PrimaryProc_FreeCast_DataShared>.NativeClassPtr);
      BloodBuff_PrimaryProc_FreeCast_DataShared.NativeFieldInfoPtr_MinBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PrimaryProc_FreeCast_DataShared>.NativeClassPtr, nameof (MinBonus));
      BloodBuff_PrimaryProc_FreeCast_DataShared.NativeFieldInfoPtr_MaxBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PrimaryProc_FreeCast_DataShared>.NativeClassPtr, nameof (MaxBonus));
      BloodBuff_PrimaryProc_FreeCast_DataShared.NativeFieldInfoPtr_FreeCastBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PrimaryProc_FreeCast_DataShared>.NativeClassPtr, nameof (FreeCastBuff));
      BloodBuff_PrimaryProc_FreeCast_DataShared.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PrimaryProc_FreeCast_DataShared>.NativeClassPtr, nameof (RequiredBloodPercentage));
      BloodBuff_PrimaryProc_FreeCast_DataShared.NativeFieldInfoPtr_OnDamageDealtListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_PrimaryProc_FreeCast_DataShared>.NativeClassPtr, nameof (OnDamageDealtListener));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_PrimaryProc_FreeCast_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
