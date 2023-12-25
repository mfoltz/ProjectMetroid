// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerResetScheduleNoticeSettingsSingleton
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
  public struct ServerResetScheduleNoticeSettingsSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ResetEnabledNotice_Singular;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ResetEnabledNotice_Plural;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ResetDisabledNotice;
    [FieldOffset(0)]
    public LocalizationKey LKey_ResetEnabledNotice_Singular;
    [FieldOffset(16)]
    public LocalizationKey LKey_ResetEnabledNotice_Plural;
    [FieldOffset(32)]
    public LocalizationKey LKey_ResetDisabledNotice;

    static ServerResetScheduleNoticeSettingsSingleton()
    {
      Il2CppClassPointerStore<ServerResetScheduleNoticeSettingsSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerResetScheduleNoticeSettingsSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerResetScheduleNoticeSettingsSingleton>.NativeClassPtr);
      ServerResetScheduleNoticeSettingsSingleton.NativeFieldInfoPtr_LKey_ResetEnabledNotice_Singular = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleNoticeSettingsSingleton>.NativeClassPtr, nameof (LKey_ResetEnabledNotice_Singular));
      ServerResetScheduleNoticeSettingsSingleton.NativeFieldInfoPtr_LKey_ResetEnabledNotice_Plural = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleNoticeSettingsSingleton>.NativeClassPtr, nameof (LKey_ResetEnabledNotice_Plural));
      ServerResetScheduleNoticeSettingsSingleton.NativeFieldInfoPtr_LKey_ResetDisabledNotice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleNoticeSettingsSingleton>.NativeClassPtr, nameof (LKey_ResetDisabledNotice));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerResetScheduleNoticeSettingsSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
