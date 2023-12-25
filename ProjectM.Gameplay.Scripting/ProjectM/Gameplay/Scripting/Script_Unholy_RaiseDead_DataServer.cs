﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Unholy_RaiseDead_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Unholy_RaiseDead_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthPerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalPowerPerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitType;
    [FieldOffset(0)]
    public float HealthPerSpellPower;
    [FieldOffset(4)]
    public float PhysicalPowerPerSpellPower;
    [FieldOffset(8)]
    public PrefabGUID UnitType;

    static Script_Unholy_RaiseDead_DataServer()
    {
      Il2CppClassPointerStore<Script_Unholy_RaiseDead_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Unholy_RaiseDead_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Unholy_RaiseDead_DataServer>.NativeClassPtr);
      Script_Unholy_RaiseDead_DataServer.NativeFieldInfoPtr_HealthPerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_RaiseDead_DataServer>.NativeClassPtr, nameof (HealthPerSpellPower));
      Script_Unholy_RaiseDead_DataServer.NativeFieldInfoPtr_PhysicalPowerPerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_RaiseDead_DataServer>.NativeClassPtr, nameof (PhysicalPowerPerSpellPower));
      Script_Unholy_RaiseDead_DataServer.NativeFieldInfoPtr_UnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_RaiseDead_DataServer>.NativeClassPtr, nameof (UnitType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Unholy_RaiseDead_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
