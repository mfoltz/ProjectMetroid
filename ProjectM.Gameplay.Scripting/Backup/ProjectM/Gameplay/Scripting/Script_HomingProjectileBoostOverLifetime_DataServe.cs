// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_HomingProjectileBoostOverLifetime_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_HomingProjectileBoostOverLifetime_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventHitId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_InternalHitCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFX_Y_Offset;
    [FieldOffset(0)]
    public HitFilter TargetHitFilter;
    [FieldOffset(4)]
    public float TimeFactor;
    [FieldOffset(8)]
    public DealDamageParameters DamageParameters;
    [FieldOffset(120)]
    public GameplayEventId GameplayEventHitId;
    [FieldOffset(128)]
    public BlobAssetReference<ConditionBlob> TargetFilterCondition;
    [FieldOffset(136)]
    public float InternalHitCooldown;
    [FieldOffset(140)]
    public float MinTimer;
    [FieldOffset(144)]
    public float MaxTimer;
    [FieldOffset(148)]
    public float HitFX_Y_Offset;

    static Script_HomingProjectileBoostOverLifetime_DataServer()
    {
      Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_HomingProjectileBoostOverLifetime_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr);
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (TargetHitFilter));
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_TimeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (TimeFactor));
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_DamageParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (DamageParameters));
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_GameplayEventHitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (GameplayEventHitId));
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_InternalHitCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (InternalHitCooldown));
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_MinTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (MinTimer));
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_MaxTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (MaxTimer));
      Script_HomingProjectileBoostOverLifetime_DataServer.NativeFieldInfoPtr_HitFX_Y_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, nameof (HitFX_Y_Offset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
