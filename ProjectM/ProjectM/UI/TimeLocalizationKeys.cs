// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TimeLocalizationKeys
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TimeLocalizationKeys
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpaceSeperatedValues2;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpaceSeperatedValues3;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpaceSeperatedValues4;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommaSeperatedValues2;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommaSeperatedValues3;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommaSeperatedValues4;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayShortKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_HourShortKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinuteShortKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondShortKey;
    [FieldOffset(0)]
    public LocalizationKey SpaceSeperatedValues2;
    [FieldOffset(16)]
    public LocalizationKey SpaceSeperatedValues3;
    [FieldOffset(32)]
    public LocalizationKey SpaceSeperatedValues4;
    [FieldOffset(48)]
    public LocalizationKey CommaSeperatedValues2;
    [FieldOffset(64)]
    public LocalizationKey CommaSeperatedValues3;
    [FieldOffset(80)]
    public LocalizationKey CommaSeperatedValues4;
    [FieldOffset(96)]
    public LocalizationKey DayShortKey;
    [FieldOffset(112)]
    public LocalizationKey HourShortKey;
    [FieldOffset(128)]
    public LocalizationKey MinuteShortKey;
    [FieldOffset(144)]
    public LocalizationKey SecondShortKey;

    static TimeLocalizationKeys()
    {
      Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (TimeLocalizationKeys));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr);
      TimeLocalizationKeys.NativeFieldInfoPtr_SpaceSeperatedValues2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (SpaceSeperatedValues2));
      TimeLocalizationKeys.NativeFieldInfoPtr_SpaceSeperatedValues3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (SpaceSeperatedValues3));
      TimeLocalizationKeys.NativeFieldInfoPtr_SpaceSeperatedValues4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (SpaceSeperatedValues4));
      TimeLocalizationKeys.NativeFieldInfoPtr_CommaSeperatedValues2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (CommaSeperatedValues2));
      TimeLocalizationKeys.NativeFieldInfoPtr_CommaSeperatedValues3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (CommaSeperatedValues3));
      TimeLocalizationKeys.NativeFieldInfoPtr_CommaSeperatedValues4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (CommaSeperatedValues4));
      TimeLocalizationKeys.NativeFieldInfoPtr_DayShortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (DayShortKey));
      TimeLocalizationKeys.NativeFieldInfoPtr_HourShortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (HourShortKey));
      TimeLocalizationKeys.NativeFieldInfoPtr_MinuteShortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (MinuteShortKey));
      TimeLocalizationKeys.NativeFieldInfoPtr_SecondShortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, nameof (SecondShortKey));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeLocalizationKeys>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
