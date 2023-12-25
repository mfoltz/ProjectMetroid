// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantMissionSetting
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantMissionSetting
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RaidStability;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuccessRateBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_InjuryChance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LootFactor;
    [FieldOffset(0)]
    public RaidStability RaidStability;
    [FieldOffset(4)]
    public float SuccessRateBonus;
    [FieldOffset(8)]
    public float MissionLength;
    [FieldOffset(12)]
    public float InjuryChance;
    [FieldOffset(16)]
    public float LootFactor;

    static ServantMissionSetting()
    {
      Il2CppClassPointerStore<ServantMissionSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantMissionSetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSetting>.NativeClassPtr);
      ServantMissionSetting.NativeFieldInfoPtr_RaidStability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSetting>.NativeClassPtr, nameof (RaidStability));
      ServantMissionSetting.NativeFieldInfoPtr_SuccessRateBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSetting>.NativeClassPtr, nameof (SuccessRateBonus));
      ServantMissionSetting.NativeFieldInfoPtr_MissionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSetting>.NativeClassPtr, nameof (MissionLength));
      ServantMissionSetting.NativeFieldInfoPtr_InjuryChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSetting>.NativeClassPtr, nameof (InjuryChance));
      ServantMissionSetting.NativeFieldInfoPtr_LootFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSetting>.NativeClassPtr, nameof (LootFactor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSetting>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
