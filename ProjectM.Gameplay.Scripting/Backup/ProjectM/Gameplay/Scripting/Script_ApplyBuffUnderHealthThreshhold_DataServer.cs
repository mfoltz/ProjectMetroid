// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderHealthThreshhold_DataServer
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
  public struct Script_ApplyBuffUnderHealthThreshhold_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewBuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThresholdMet;
    private static readonly System.IntPtr NativeFieldInfoPtr_DontTriggerOnDots;
    private static readonly System.IntPtr NativeFieldInfoPtr_DontTriggerInFlight;
    [FieldOffset(0)]
    public float HealthFactor;
    [FieldOffset(4)]
    public PrefabGUID NewBuffEntity;
    [FieldOffset(8)]
    public SequenceGUID TriggerSequence;
    [FieldOffset(12)]
    public ListenerId OnDamageTakenListener;
    [FieldOffset(20)]
    public bool ThresholdMet;
    [FieldOffset(21)]
    public bool DontTriggerOnDots;
    [FieldOffset(22)]
    public bool DontTriggerInFlight;

    static Script_ApplyBuffUnderHealthThreshhold_DataServer()
    {
      Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ApplyBuffUnderHealthThreshhold_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr);
      Script_ApplyBuffUnderHealthThreshhold_DataServer.NativeFieldInfoPtr_HealthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr, nameof (HealthFactor));
      Script_ApplyBuffUnderHealthThreshhold_DataServer.NativeFieldInfoPtr_NewBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr, nameof (NewBuffEntity));
      Script_ApplyBuffUnderHealthThreshhold_DataServer.NativeFieldInfoPtr_TriggerSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr, nameof (TriggerSequence));
      Script_ApplyBuffUnderHealthThreshhold_DataServer.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr, nameof (OnDamageTakenListener));
      Script_ApplyBuffUnderHealthThreshhold_DataServer.NativeFieldInfoPtr_ThresholdMet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr, nameof (ThresholdMet));
      Script_ApplyBuffUnderHealthThreshhold_DataServer.NativeFieldInfoPtr_DontTriggerOnDots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr, nameof (DontTriggerOnDots));
      Script_ApplyBuffUnderHealthThreshhold_DataServer.NativeFieldInfoPtr_DontTriggerInFlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr, nameof (DontTriggerInFlight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ApplyBuffUnderHealthThreshhold_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
