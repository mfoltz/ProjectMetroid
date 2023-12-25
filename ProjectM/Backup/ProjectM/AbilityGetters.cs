// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGetters
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityGetters
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Abilities;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupSlots;
    private static readonly System.IntPtr NativeFieldInfoPtr_Charges;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupComboState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupResetComboState;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptData;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnergyRequirement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Energy;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buffable;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPrefabOnCast;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCastCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionChecker;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AbilityGetters_SystemBase_ConditionChecker_0;
    [FieldOffset(0)]
    public BufferFromEntity<AbilityStateBuffer> Abilities;
    [FieldOffset(40)]
    public BufferFromEntity<AbilityGroupSlotBuffer> GroupSlots;
    [FieldOffset(80)]
    public ComponentDataFromEntity<AbilityChargesState> Charges;
    [FieldOffset(112)]
    public ComponentDataFromEntity<AbilityCooldownState> Cooldown;
    [FieldOffset(144)]
    public ComponentDataFromEntity<AbilityGroupComboState> GroupComboState;
    [FieldOffset(176)]
    public ComponentDataFromEntity<AbilityGroupResetComboState> GroupResetComboState;
    [FieldOffset(208)]
    public ComponentDataFromEntity<AbilityIgnoreSettings> IgnoreSettings;
    [FieldOffset(240)]
    public ComponentDataFromEntity<AbilityPriority> Priority;
    [FieldOffset(272)]
    public ComponentDataFromEntity<AbilityGroupSlot> GroupSlot;
    [FieldOffset(304)]
    public ComponentDataFromEntity<AbilityState> State;
    [FieldOffset(336)]
    public ComponentDataFromEntity<AbilityCastTimeData> CastTimeData;
    [FieldOffset(368)]
    public ComponentDataFromEntity<AbilityInterruptData> InterruptData;
    [FieldOffset(400)]
    public ComponentDataFromEntity<ProjectM.EnergyRequirement> EnergyRequirement;
    [FieldOffset(432)]
    public ComponentDataFromEntity<ProjectM.Energy> Energy;
    [FieldOffset(464)]
    public ComponentDataFromEntity<ProjectM.Buff> Buff;
    [FieldOffset(496)]
    public ComponentDataFromEntity<ProjectM.Buffable> Buffable;
    [FieldOffset(528)]
    public ComponentDataFromEntity<ProjectM.EntityInput> EntityInput;
    [FieldOffset(560)]
    public BufferFromEntity<AbilitySpawnPrefabOnCast> SpawnPrefabOnCast;
    [FieldOffset(600)]
    public BufferFromEntity<ProjectM.AbilityCastCondition> AbilityCastCondition;
    [FieldOffset(640)]
    public ComponentDataFromEntity<ProjectM.Team> Team;
    [FieldOffset(672)]
    public ConditionChecker ConditionChecker;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 995865, RefRangeEnd = 995869, XrefRangeStart = 995803, XrefRangeEnd = 995865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AbilityGetters Create(
      SystemBase systemBase,
      ConditionChecker conditionChecker)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &conditionChecker;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityGetters.NativeMethodInfoPtr_Create_Public_Static_AbilityGetters_SystemBase_ConditionChecker_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AbilityGetters*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityGetters()
    {
      Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityGetters));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr);
      AbilityGetters.NativeFieldInfoPtr_Abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (Abilities));
      AbilityGetters.NativeFieldInfoPtr_GroupSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (GroupSlots));
      AbilityGetters.NativeFieldInfoPtr_Charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (Charges));
      AbilityGetters.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (Cooldown));
      AbilityGetters.NativeFieldInfoPtr_GroupComboState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (GroupComboState));
      AbilityGetters.NativeFieldInfoPtr_GroupResetComboState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (GroupResetComboState));
      AbilityGetters.NativeFieldInfoPtr_IgnoreSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (IgnoreSettings));
      AbilityGetters.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (Priority));
      AbilityGetters.NativeFieldInfoPtr_GroupSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (GroupSlot));
      AbilityGetters.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (State));
      AbilityGetters.NativeFieldInfoPtr_CastTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (CastTimeData));
      AbilityGetters.NativeFieldInfoPtr_InterruptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (InterruptData));
      AbilityGetters.NativeFieldInfoPtr_EnergyRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (EnergyRequirement));
      AbilityGetters.NativeFieldInfoPtr_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (Energy));
      AbilityGetters.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (Buff));
      AbilityGetters.NativeFieldInfoPtr_Buffable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (Buffable));
      AbilityGetters.NativeFieldInfoPtr_EntityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (EntityInput));
      AbilityGetters.NativeFieldInfoPtr_SpawnPrefabOnCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (SpawnPrefabOnCast));
      AbilityGetters.NativeFieldInfoPtr_AbilityCastCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (AbilityCastCondition));
      AbilityGetters.NativeFieldInfoPtr_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (Team));
      AbilityGetters.NativeFieldInfoPtr_ConditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, nameof (ConditionChecker));
      AbilityGetters.NativeMethodInfoPtr_Create_Public_Static_AbilityGetters_SystemBase_ConditionChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, 100676900);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGetters>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
