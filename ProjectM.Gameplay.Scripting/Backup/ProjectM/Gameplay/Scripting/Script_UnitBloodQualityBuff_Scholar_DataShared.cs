// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_UnitBloodQualityBuff_Scholar_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_UnitBloodQualityBuff_Scholar_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve_DamageIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve_HealthIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve_MovementIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageIncreaseMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthIncreaseMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedIncreaseMax;
    [FieldOffset(0)]
    public ModificationId HealthModificationId;
    [FieldOffset(4)]
    public ModificationId DamageModificationId;
    [FieldOffset(8)]
    public ModificationId SpeedModificationId;
    [FieldOffset(12)]
    public CurveReference Curve_DamageIncrease;
    [FieldOffset(20)]
    public CurveReference Curve_HealthIncrease;
    [FieldOffset(28)]
    public CurveReference Curve_MovementIncrease;
    [FieldOffset(36)]
    public float DamageIncreaseMax;
    [FieldOffset(40)]
    public float HealthIncreaseMax;
    [FieldOffset(44)]
    public float SpeedIncreaseMax;

    static Script_UnitBloodQualityBuff_Scholar_DataShared()
    {
      Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_UnitBloodQualityBuff_Scholar_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr);
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_HealthModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (HealthModificationId));
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_DamageModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (DamageModificationId));
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_SpeedModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (SpeedModificationId));
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_Curve_DamageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (Curve_DamageIncrease));
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_Curve_HealthIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (Curve_HealthIncrease));
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_Curve_MovementIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (Curve_MovementIncrease));
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_DamageIncreaseMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (DamageIncreaseMax));
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_HealthIncreaseMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (HealthIncreaseMax));
      Script_UnitBloodQualityBuff_Scholar_DataShared.NativeFieldInfoPtr_SpeedIncreaseMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, nameof (SpeedIncreaseMax));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_UnitBloodQualityBuff_Scholar_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
