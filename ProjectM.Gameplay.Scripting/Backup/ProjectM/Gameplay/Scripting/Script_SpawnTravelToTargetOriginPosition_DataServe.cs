// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SpawnTravelToTargetOriginPosition_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_SpawnTravelToTargetOriginPosition_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelfTravelSpell;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivateScriptWhenPlayersHasBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetOriginPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_Activated;
    [FieldOffset(0)]
    public BlobAssetReference<ConditionBlob> TargetFilterCondition;
    [FieldOffset(8)]
    public PrefabGUID SelfTravelSpell;
    [FieldOffset(12)]
    public PrefabGUID ActivateScriptWhenPlayersHasBuff;
    [FieldOffset(16)]
    public float3 TargetOriginPosition;
    [FieldOffset(28)]
    public float MinDuration;
    [FieldOffset(32)]
    public float MaxDuration;
    [FieldOffset(36)]
    public float MaxRange;
    [FieldOffset(40)]
    public bool Activated;

    static Script_SpawnTravelToTargetOriginPosition_DataServer()
    {
      Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SpawnTravelToTargetOriginPosition_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr);
      Script_SpawnTravelToTargetOriginPosition_DataServer.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_SpawnTravelToTargetOriginPosition_DataServer.NativeFieldInfoPtr_SelfTravelSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, nameof (SelfTravelSpell));
      Script_SpawnTravelToTargetOriginPosition_DataServer.NativeFieldInfoPtr_ActivateScriptWhenPlayersHasBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, nameof (ActivateScriptWhenPlayersHasBuff));
      Script_SpawnTravelToTargetOriginPosition_DataServer.NativeFieldInfoPtr_TargetOriginPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, nameof (TargetOriginPosition));
      Script_SpawnTravelToTargetOriginPosition_DataServer.NativeFieldInfoPtr_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, nameof (MinDuration));
      Script_SpawnTravelToTargetOriginPosition_DataServer.NativeFieldInfoPtr_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, nameof (MaxDuration));
      Script_SpawnTravelToTargetOriginPosition_DataServer.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, nameof (MaxRange));
      Script_SpawnTravelToTargetOriginPosition_DataServer.NativeFieldInfoPtr_Activated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, nameof (Activated));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_SpawnTravelToTargetOriginPosition_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
