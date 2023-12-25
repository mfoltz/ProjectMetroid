// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer
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
  public struct Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetUnitCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetMainCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageDealtListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilterByUnitCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilterByEntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilterByDamageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyTriggerOnPrimaryAttack;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    [FieldOffset(0)]
    public UnitCategory TargetUnitCategory;
    [FieldOffset(1)]
    public MainEntityCategory TargetMainCategory;
    [FieldOffset(4)]
    public ListenerId OnDamageDealtListener;
    [FieldOffset(12)]
    public GameplayEventId GameplayEventId;
    [FieldOffset(20)]
    public GameplayEventTarget GameplayEventTarget;
    [FieldOffset(24)]
    public MainDamageType DamageType;
    [FieldOffset(28)]
    public bool FilterByUnitCategory;
    [FieldOffset(29)]
    public bool FilterByEntityCategory;
    [FieldOffset(30)]
    public bool FilterByDamageType;
    [FieldOffset(31)]
    public bool OnlyTriggerOnPrimaryAttack;
    [FieldOffset(32)]
    public BlobAssetReference<ConditionBlob> TargetFilterCondition;

    static Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr);
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_TargetUnitCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (TargetUnitCategory));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_TargetMainCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (TargetMainCategory));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_OnDamageDealtListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (OnDamageDealtListener));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (GameplayEventId));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_GameplayEventTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (GameplayEventTarget));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (DamageType));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_FilterByUnitCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (FilterByUnitCategory));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_FilterByEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (FilterByEntityCategory));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_FilterByDamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (FilterByDamageType));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_OnlyTriggerOnPrimaryAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (OnlyTriggerOnPrimaryAttack));
      Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, nameof (TargetFilterCondition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageDealtToEntityCategory_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
