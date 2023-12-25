// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnBuffTargetDeath_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CreateGameplayEventOnBuffTargetDeath_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnTargetDeathListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventTriggerTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerForMinionMasterIfMinion;
    [FieldOffset(0)]
    public ListenerId OnTargetDeathListener;
    [FieldOffset(8)]
    public GameplayEventId GameplayEventId;
    [FieldOffset(16)]
    public EventTriggerTarget EventTriggerTarget;
    [FieldOffset(20)]
    public Entity Target;
    [FieldOffset(28)]
    public bool TriggerForMinionMasterIfMinion;

    static Script_CreateGameplayEventOnBuffTargetDeath_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnBuffTargetDeath_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnBuffTargetDeath_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnBuffTargetDeath_DataServer>.NativeClassPtr);
      Script_CreateGameplayEventOnBuffTargetDeath_DataServer.NativeFieldInfoPtr_OnTargetDeathListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnBuffTargetDeath_DataServer>.NativeClassPtr, nameof (OnTargetDeathListener));
      Script_CreateGameplayEventOnBuffTargetDeath_DataServer.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnBuffTargetDeath_DataServer>.NativeClassPtr, nameof (GameplayEventId));
      Script_CreateGameplayEventOnBuffTargetDeath_DataServer.NativeFieldInfoPtr_EventTriggerTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnBuffTargetDeath_DataServer>.NativeClassPtr, nameof (EventTriggerTarget));
      Script_CreateGameplayEventOnBuffTargetDeath_DataServer.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnBuffTargetDeath_DataServer>.NativeClassPtr, nameof (Target));
      Script_CreateGameplayEventOnBuffTargetDeath_DataServer.NativeFieldInfoPtr_TriggerForMinionMasterIfMinion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnBuffTargetDeath_DataServer>.NativeClassPtr, nameof (TriggerForMinionMasterIfMinion));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateGameplayEventOnBuffTargetDeath_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
