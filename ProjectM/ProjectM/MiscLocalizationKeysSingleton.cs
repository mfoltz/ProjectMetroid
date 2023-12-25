// Decompiled with JetBrains decompiler
// Type: ProjectM.MiscLocalizationKeysSingleton
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
  public struct MiscLocalizationKeysSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AdminUsedConsoleCommandMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceJoinClan_AdminJoinedYourClanMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceJoinClan_SenderAlreadyInClanError;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceJoinClan_TargetNotInAClanError;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceJoinClan_NoPlayerFoundError;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnUnit_UnitNotFoundError;
    [FieldOffset(0)]
    public LocalizationKey AdminUsedConsoleCommandMessage;
    [FieldOffset(16)]
    public LocalizationKey ForceJoinClan_AdminJoinedYourClanMessage;
    [FieldOffset(32)]
    public LocalizationKey ForceJoinClan_SenderAlreadyInClanError;
    [FieldOffset(48)]
    public LocalizationKey ForceJoinClan_TargetNotInAClanError;
    [FieldOffset(64)]
    public LocalizationKey ForceJoinClan_NoPlayerFoundError;
    [FieldOffset(80)]
    public LocalizationKey SpawnUnit_UnitNotFoundError;

    static MiscLocalizationKeysSingleton()
    {
      Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MiscLocalizationKeysSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr);
      MiscLocalizationKeysSingleton.NativeFieldInfoPtr_AdminUsedConsoleCommandMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr, nameof (AdminUsedConsoleCommandMessage));
      MiscLocalizationKeysSingleton.NativeFieldInfoPtr_ForceJoinClan_AdminJoinedYourClanMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr, nameof (ForceJoinClan_AdminJoinedYourClanMessage));
      MiscLocalizationKeysSingleton.NativeFieldInfoPtr_ForceJoinClan_SenderAlreadyInClanError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr, nameof (ForceJoinClan_SenderAlreadyInClanError));
      MiscLocalizationKeysSingleton.NativeFieldInfoPtr_ForceJoinClan_TargetNotInAClanError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr, nameof (ForceJoinClan_TargetNotInAClanError));
      MiscLocalizationKeysSingleton.NativeFieldInfoPtr_ForceJoinClan_NoPlayerFoundError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr, nameof (ForceJoinClan_NoPlayerFoundError));
      MiscLocalizationKeysSingleton.NativeFieldInfoPtr_SpawnUnit_UnitNotFoundError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr, nameof (SpawnUnit_UnitNotFoundError));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiscLocalizationKeysSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
