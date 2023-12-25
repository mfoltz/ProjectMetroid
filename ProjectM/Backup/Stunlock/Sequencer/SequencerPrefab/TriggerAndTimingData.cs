// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequencerPrefab.TriggerAndTimingData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer.SequencerPrefab
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TriggerAndTimingData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Delay;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfiniteDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseDelayData;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseDurationData;
    [FieldOffset(0)]
    public float Delay;
    [FieldOffset(4)]
    public float Duration;
    [FieldOffset(8)]
    public bool InfiniteDuration;
    [FieldOffset(9)]
    public bool UseDelayData;
    [FieldOffset(10)]
    public bool UseDurationData;

    static TriggerAndTimingData()
    {
      Il2CppClassPointerStore<TriggerAndTimingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer.SequencerPrefab", nameof (TriggerAndTimingData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerAndTimingData>.NativeClassPtr);
      TriggerAndTimingData.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerAndTimingData>.NativeClassPtr, nameof (Delay));
      TriggerAndTimingData.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerAndTimingData>.NativeClassPtr, nameof (Duration));
      TriggerAndTimingData.NativeFieldInfoPtr_InfiniteDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerAndTimingData>.NativeClassPtr, nameof (InfiniteDuration));
      TriggerAndTimingData.NativeFieldInfoPtr_UseDelayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerAndTimingData>.NativeClassPtr, nameof (UseDelayData));
      TriggerAndTimingData.NativeFieldInfoPtr_UseDurationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerAndTimingData>.NativeClassPtr, nameof (UseDurationData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerAndTimingData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
