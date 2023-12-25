// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventsOnAbilityTrigger
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventsOnAbilityTrigger
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumOfPrefabTargets;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabTargetStartIndex;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public AbilityTriggerEventType Type;
    [FieldOffset(12)]
    public GameplayEventTarget Target;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(24)]
    public AbilityTypeFlag AbilityTypes;
    [FieldOffset(28)]
    public int NumOfPrefabTargets;
    [FieldOffset(32)]
    public int PrefabTargetStartIndex;

    static CreateGameplayEventsOnAbilityTrigger()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventsOnAbilityTrigger));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr);
      CreateGameplayEventsOnAbilityTrigger.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventsOnAbilityTrigger.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr, nameof (Type));
      CreateGameplayEventsOnAbilityTrigger.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr, nameof (Target));
      CreateGameplayEventsOnAbilityTrigger.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr, nameof (Condition));
      CreateGameplayEventsOnAbilityTrigger.NativeFieldInfoPtr_AbilityTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr, nameof (AbilityTypes));
      CreateGameplayEventsOnAbilityTrigger.NativeFieldInfoPtr_NumOfPrefabTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr, nameof (NumOfPrefabTargets));
      CreateGameplayEventsOnAbilityTrigger.NativeFieldInfoPtr_PrefabTargetStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr, nameof (PrefabTargetStartIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnAbilityTrigger>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
