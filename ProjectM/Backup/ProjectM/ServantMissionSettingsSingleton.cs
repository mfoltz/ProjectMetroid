// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantMissionSettingsSingleton
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantMissionSettingsSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionLootVariance;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticPartyBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissionBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissionStarted;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissionSuccess;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_MissionFailed;
    [FieldOffset(0)]
    public float MissionLootVariance;
    [FieldOffset(4)]
    public int StaticPartyBonus;
    [FieldOffset(8)]
    public PrefabGUID MissionBuff;
    [FieldOffset(12)]
    public LocalizationKey LKey_MissionStarted;
    [FieldOffset(28)]
    public LocalizationKey LKey_MissionSuccess;
    [FieldOffset(44)]
    public LocalizationKey LKey_MissionFailed;

    static ServantMissionSettingsSingleton()
    {
      Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantMissionSettingsSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr);
      ServantMissionSettingsSingleton.NativeFieldInfoPtr_MissionLootVariance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr, nameof (MissionLootVariance));
      ServantMissionSettingsSingleton.NativeFieldInfoPtr_StaticPartyBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr, nameof (StaticPartyBonus));
      ServantMissionSettingsSingleton.NativeFieldInfoPtr_MissionBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr, nameof (MissionBuff));
      ServantMissionSettingsSingleton.NativeFieldInfoPtr_LKey_MissionStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr, nameof (LKey_MissionStarted));
      ServantMissionSettingsSingleton.NativeFieldInfoPtr_LKey_MissionSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr, nameof (LKey_MissionSuccess));
      ServantMissionSettingsSingleton.NativeFieldInfoPtr_LKey_MissionFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr, nameof (LKey_MissionFailed));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSettingsSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
