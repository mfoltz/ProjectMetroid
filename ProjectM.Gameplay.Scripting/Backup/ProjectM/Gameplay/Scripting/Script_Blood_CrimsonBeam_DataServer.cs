// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Blood_CrimsonBeam_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TickRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelfHealParameters;
    [FieldOffset(0)]
    public float TickRate;
    [FieldOffset(4)]
    public DealDamageParameters DamageParameters;
    [FieldOffset(116)]
    public HealUtility.DealHealingParameters HealParameters;
    [FieldOffset(132)]
    public GameplayEventId TickEventId;
    [FieldOffset(140)]
    public HealUtility.DealHealingParameters SelfHealParameters;

    static Script_Blood_CrimsonBeam_DataServer()
    {
      Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Blood_CrimsonBeam_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataServer>.NativeClassPtr);
      Script_Blood_CrimsonBeam_DataServer.NativeFieldInfoPtr_TickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataServer>.NativeClassPtr, nameof (TickRate));
      Script_Blood_CrimsonBeam_DataServer.NativeFieldInfoPtr_DamageParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataServer>.NativeClassPtr, nameof (DamageParameters));
      Script_Blood_CrimsonBeam_DataServer.NativeFieldInfoPtr_HealParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataServer>.NativeClassPtr, nameof (HealParameters));
      Script_Blood_CrimsonBeam_DataServer.NativeFieldInfoPtr_TickEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataServer>.NativeClassPtr, nameof (TickEventId));
      Script_Blood_CrimsonBeam_DataServer.NativeFieldInfoPtr_SelfHealParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataServer>.NativeClassPtr, nameof (SelfHealParameters));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
