// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_IgniteDebuff_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_IgniteDebuff_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalTicks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Damage_TotalProcentualHealth_Vampire;
    private static readonly System.IntPtr NativeFieldInfoPtr_Damage_TotalProcentualHealth_Pve;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticPveBonusDamage;
    [FieldOffset(0)]
    public float TotalTicks;
    [FieldOffset(4)]
    public float Damage_TotalProcentualHealth_Vampire;
    [FieldOffset(8)]
    public float Damage_TotalProcentualHealth_Pve;
    [FieldOffset(12)]
    public float TicksCounter;
    [FieldOffset(16)]
    public float StaticPveBonusDamage;

    static Script_IgniteDebuff_DataServer()
    {
      Il2CppClassPointerStore<Script_IgniteDebuff_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_IgniteDebuff_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_IgniteDebuff_DataServer>.NativeClassPtr);
      Script_IgniteDebuff_DataServer.NativeFieldInfoPtr_TotalTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IgniteDebuff_DataServer>.NativeClassPtr, nameof (TotalTicks));
      Script_IgniteDebuff_DataServer.NativeFieldInfoPtr_Damage_TotalProcentualHealth_Vampire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IgniteDebuff_DataServer>.NativeClassPtr, nameof (Damage_TotalProcentualHealth_Vampire));
      Script_IgniteDebuff_DataServer.NativeFieldInfoPtr_Damage_TotalProcentualHealth_Pve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IgniteDebuff_DataServer>.NativeClassPtr, nameof (Damage_TotalProcentualHealth_Pve));
      Script_IgniteDebuff_DataServer.NativeFieldInfoPtr_TicksCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IgniteDebuff_DataServer>.NativeClassPtr, nameof (TicksCounter));
      Script_IgniteDebuff_DataServer.NativeFieldInfoPtr_StaticPveBonusDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_IgniteDebuff_DataServer>.NativeClassPtr, nameof (StaticPveBonusDamage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_IgniteDebuff_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
