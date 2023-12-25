// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ApplyBuffUnderThreeHealthThreshholds_DataServer
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
  public struct Script_ApplyBuffUnderThreeHealthThreshholds_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor1;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor2;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthFactor3;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewBuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThresholdMet1;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThresholdMet2;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThresholdMet3;
    [FieldOffset(0)]
    public float HealthFactor1;
    [FieldOffset(4)]
    public float HealthFactor2;
    [FieldOffset(8)]
    public float HealthFactor3;
    [FieldOffset(12)]
    public PrefabGUID NewBuffEntity;
    [FieldOffset(16)]
    public ListenerId OnDamageTakenListener;
    [FieldOffset(24)]
    public bool ThresholdMet1;
    [FieldOffset(25)]
    public bool ThresholdMet2;
    [FieldOffset(26)]
    public bool ThresholdMet3;

    static Script_ApplyBuffUnderThreeHealthThreshholds_DataServer()
    {
      Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ApplyBuffUnderThreeHealthThreshholds_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr);
      Script_ApplyBuffUnderThreeHealthThreshholds_DataServer.NativeFieldInfoPtr_HealthFactor1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, nameof (HealthFactor1));
      Script_ApplyBuffUnderThreeHealthThreshholds_DataServer.NativeFieldInfoPtr_HealthFactor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, nameof (HealthFactor2));
      Script_ApplyBuffUnderThreeHealthThreshholds_DataServer.NativeFieldInfoPtr_HealthFactor3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, nameof (HealthFactor3));
      Script_ApplyBuffUnderThreeHealthThreshholds_DataServer.NativeFieldInfoPtr_NewBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, nameof (NewBuffEntity));
      Script_ApplyBuffUnderThreeHealthThreshholds_DataServer.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, nameof (OnDamageTakenListener));
      Script_ApplyBuffUnderThreeHealthThreshholds_DataServer.NativeFieldInfoPtr_ThresholdMet1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, nameof (ThresholdMet1));
      Script_ApplyBuffUnderThreeHealthThreshholds_DataServer.NativeFieldInfoPtr_ThresholdMet2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, nameof (ThresholdMet2));
      Script_ApplyBuffUnderThreeHealthThreshholds_DataServer.NativeFieldInfoPtr_ThresholdMet3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, nameof (ThresholdMet3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ApplyBuffUnderThreeHealthThreshholds_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
