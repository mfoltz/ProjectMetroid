// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetUnitCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetMainCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDamageTakenListener;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilterByUnitCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilterByEntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilterByDamageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsBuffTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsStatChangeTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerOnZeroDamage;
    [FieldOffset(0)]
    public UnitCategory TargetUnitCategory;
    [FieldOffset(1)]
    public MainEntityCategory TargetMainCategory;
    [FieldOffset(4)]
    public ListenerId OnDamageTakenListener;
    [FieldOffset(12)]
    public GameplayEventId GameplayEventId;
    [FieldOffset(20)]
    public MainDamageType DamageType;
    [FieldOffset(24)]
    public bool FilterByUnitCategory;
    [FieldOffset(25)]
    public bool FilterByEntityCategory;
    [FieldOffset(26)]
    public bool FilterByDamageType;
    [FieldOffset(27)]
    public bool IsBuffTarget;
    [FieldOffset(28)]
    public bool IsStatChangeTarget;
    [FieldOffset(29)]
    public bool TriggerOnZeroDamage;

    static Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr);
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_TargetUnitCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (TargetUnitCategory));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_TargetMainCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (TargetMainCategory));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_OnDamageTakenListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (OnDamageTakenListener));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (GameplayEventId));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (DamageType));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_FilterByUnitCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (FilterByUnitCategory));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_FilterByEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (FilterByEntityCategory));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_FilterByDamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (FilterByDamageType));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_IsBuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (IsBuffTarget));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_IsStatChangeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (IsStatChangeTarget));
      Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer.NativeFieldInfoPtr_TriggerOnZeroDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, nameof (TriggerOnZeroDamage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateGameplayEventOnDamageTakenToEntityCategory_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
