// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitConsumableProjectile_DataServer
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
  public struct Script_CreateGameplayEventOnHitConsumableProjectile_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventHitId;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_MustBeOwnerOfProjectile;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    [FieldOffset(0)]
    public HitFilter TargetHitFilter;
    [FieldOffset(4)]
    public GameplayEventId GameplayEventHitId;
    [FieldOffset(12)]
    public MainEntityCategory EntityCategory;
    [FieldOffset(13)]
    public bool MustBeOwnerOfProjectile;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> TargetFilterCondition;

    static Script_CreateGameplayEventOnHitConsumableProjectile_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnHitConsumableProjectile_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile_DataServer>.NativeClassPtr);
      Script_CreateGameplayEventOnHitConsumableProjectile_DataServer.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile_DataServer>.NativeClassPtr, nameof (TargetHitFilter));
      Script_CreateGameplayEventOnHitConsumableProjectile_DataServer.NativeFieldInfoPtr_GameplayEventHitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile_DataServer>.NativeClassPtr, nameof (GameplayEventHitId));
      Script_CreateGameplayEventOnHitConsumableProjectile_DataServer.NativeFieldInfoPtr_EntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile_DataServer>.NativeClassPtr, nameof (EntityCategory));
      Script_CreateGameplayEventOnHitConsumableProjectile_DataServer.NativeFieldInfoPtr_MustBeOwnerOfProjectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile_DataServer>.NativeClassPtr, nameof (MustBeOwnerOfProjectile));
      Script_CreateGameplayEventOnHitConsumableProjectile_DataServer.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile_DataServer>.NativeClassPtr, nameof (TargetFilterCondition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
