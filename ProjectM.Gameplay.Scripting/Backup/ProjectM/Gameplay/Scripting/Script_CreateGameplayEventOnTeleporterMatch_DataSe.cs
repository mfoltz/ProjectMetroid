// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTeleporterMatch_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CreateGameplayEventOnTeleporterMatch_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    [FieldOffset(0)]
    public BlobAssetReference<ConditionBlob> TargetFilterCondition;
    [FieldOffset(8)]
    public GameplayEventId GameplayEventId;

    static Script_CreateGameplayEventOnTeleporterMatch_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnTeleporterMatch_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnTeleporterMatch_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnTeleporterMatch_DataServer>.NativeClassPtr);
      Script_CreateGameplayEventOnTeleporterMatch_DataServer.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnTeleporterMatch_DataServer>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_CreateGameplayEventOnTeleporterMatch_DataServer.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnTeleporterMatch_DataServer>.NativeClassPtr, nameof (GameplayEventId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateGameplayEventOnTeleporterMatch_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
