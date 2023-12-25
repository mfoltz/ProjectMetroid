// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_TriggerCooldownOnSpawn_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_TriggerCooldownOnSpawn_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_FetchAbilityBaseCooldown;
    [FieldOffset(0)]
    public float CustomCooldown;
    [FieldOffset(4)]
    public PrefabGUID TriggerAbility;
    [FieldOffset(8)]
    public bool FetchAbilityBaseCooldown;

    static Script_TriggerCooldownOnSpawn_DataServer()
    {
      Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_TriggerCooldownOnSpawn_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn_DataServer>.NativeClassPtr);
      Script_TriggerCooldownOnSpawn_DataServer.NativeFieldInfoPtr_CustomCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn_DataServer>.NativeClassPtr, nameof (CustomCooldown));
      Script_TriggerCooldownOnSpawn_DataServer.NativeFieldInfoPtr_TriggerAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn_DataServer>.NativeClassPtr, nameof (TriggerAbility));
      Script_TriggerCooldownOnSpawn_DataServer.NativeFieldInfoPtr_FetchAbilityBaseCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn_DataServer>.NativeClassPtr, nameof (FetchAbilityBaseCooldown));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
