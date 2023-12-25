// Decompiled with JetBrains decompiler
// Type: ProjectM.BehaviourTreeShared
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class BehaviourTreeShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GenericIdleBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenericAlertBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenericCombatBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Boolean_Boolean_Single_RelocationSettingsAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenericCombatRelocateBehaviour_Public_Static_BehaviourTreeNodeAuthoring_RelocationSettingsAsset_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Combat_Internal_Static_BehaviourTreeNodeAuthoring_Boolean_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenericReturnBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenericFollowBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenericImprisonedBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateAlertAlliesNode_Internal_Static_BehaviourTreeNodeAuthoring_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_PrefabGUID_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WithGlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_BehaviourTreeNodeAuthoring_PrefabGUID_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WithGlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_BehaviourTreeNodeAuthoring_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegenerateHealth_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NoLineOfSightCombat_Public_Static_BehaviourTreeNodeAuthoring_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PathAwayFromTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_byref___c__DisplayClass0_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_byref___c__DisplayClass0_0_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1324183, RefRangeEnd = 1324186, XrefRangeStart = 1324011, XrefRangeEnd = 1324183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring GenericIdleBehaviour(
      float minIdleChillTime,
      float maxIdleChillTime,
      float maxWanderDistanceFromHome,
      float idleReturnDistance,
      float regenerateHealthFrequency,
      float regenerateHealthPercentage)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &minIdleChillTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxIdleChillTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxWanderDistanceFromHome;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &idleReturnDistance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &regenerateHealthFrequency;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &regenerateHealthPercentage;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_GenericIdleBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1324306, RefRangeEnd = 1324308, XrefRangeStart = 1324186, XrefRangeEnd = 1324306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring GenericAlertBehaviour()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_GenericAlertBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1324422, RefRangeEnd = 1324425, XrefRangeStart = 1324308, XrefRangeEnd = 1324422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring GenericCombatBehaviour(
      bool alertAllies,
      bool wallhack,
      float leaveDelay_noAggro,
      RelocationSettingsAsset relocationSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &alertAllies;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wallhack;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &leaveDelay_noAggro;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) relocationSettings);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_GenericCombatBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Boolean_Boolean_Single_RelocationSettingsAsset_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1324699, RefRangeEnd = 1324704, XrefRangeStart = 1324425, XrefRangeEnd = 1324699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring GenericCombatRelocateBehaviour(
      RelocationSettingsAsset relocationSettings,
      bool alertAllies)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) relocationSettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &alertAllies;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_GenericCombatRelocateBehaviour_Public_Static_BehaviourTreeNodeAuthoring_RelocationSettingsAsset_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1324753, RefRangeEnd = 1324755, XrefRangeStart = 1324704, XrefRangeEnd = 1324753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring Combat(
      bool alertAllies,
      BehaviourTreeNodeAuthoring combatLoop)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &alertAllies;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatLoop);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_Combat_Internal_Static_BehaviourTreeNodeAuthoring_Boolean_BehaviourTreeNodeAuthoring_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1324817, RefRangeEnd = 1324821, XrefRangeStart = 1324755, XrefRangeEnd = 1324817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring GenericReturnBehaviour()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_GenericReturnBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1325515, RefRangeEnd = 1325518, XrefRangeStart = 1324821, XrefRangeEnd = 1325515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring GenericFollowBehaviour(
      float regenerateHealthFrequency,
      float regenerateHealthPercentage,
      float pathRecalculationFrequency = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &regenerateHealthFrequency;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &regenerateHealthPercentage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pathRecalculationFrequency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_GenericFollowBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1325566, RefRangeEnd = 1325567, XrefRangeStart = 1325518, XrefRangeEnd = 1325566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring GenericImprisonedBehaviour()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_GenericImprisonedBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1325598, RefRangeEnd = 1325600, XrefRangeStart = 1325567, XrefRangeEnd = 1325598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring CreateAlertAlliesNode(bool alertAllies)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &alertAllies;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_CreateAlertAlliesNode_Internal_Static_BehaviourTreeNodeAuthoring_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1325815, RefRangeEnd = 1325816, XrefRangeStart = 1325600, XrefRangeEnd = 1325815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring GlobalLogic(
      PrefabGUID castOptionsPrefabGuid,
      bool implementsFollowState = false,
      bool implementsImprisonedState = false,
      bool forceAimInMoveDirection = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &castOptionsPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &implementsFollowState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &implementsImprisonedState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &forceAimInMoveDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_GlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_PrefabGUID_Boolean_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1325844, RefRangeEnd = 1325850, XrefRangeStart = 1325816, XrefRangeEnd = 1325844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring WithGlobalLogic(
      BehaviourTreeNodeAuthoring localLogic,
      PrefabGUID castOptionPrefabGuid,
      bool implementsFollowState = false,
      bool implementsImprisonedState = false,
      bool forceAimInMoveDirection = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localLogic);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &castOptionPrefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &implementsFollowState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &implementsImprisonedState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &forceAimInMoveDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_WithGlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_BehaviourTreeNodeAuthoring_PrefabGUID_Boolean_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1325850, XrefRangeEnd = 1325852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring WithGlobalLogic(
      BehaviourTreeNodeAuthoring localLogic,
      bool implementsFollowState = false,
      bool implementsImprisonedState = false,
      bool forceAimInMoveDirection = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) localLogic);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &implementsFollowState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &implementsImprisonedState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &forceAimInMoveDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_WithGlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_BehaviourTreeNodeAuthoring_Boolean_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1325908, RefRangeEnd = 1325912, XrefRangeStart = 1325852, XrefRangeEnd = 1325908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring RegenerateHealth(
      float regenerateHealthFrequency,
      float regenerateHealthPercentage,
      int regenerateHealthAbsoluteValue = 0,
      bool useAbsoluteRegenerateHealthValue = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &regenerateHealthFrequency;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &regenerateHealthPercentage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &regenerateHealthAbsoluteValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &useAbsoluteRegenerateHealthValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_RegenerateHealth_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1326503, RefRangeEnd = 1326504, XrefRangeStart = 1325912, XrefRangeEnd = 1326503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring NoLineOfSightCombat(
      bool wallhack,
      float noAggroReturnDelay)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &wallhack;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &noAggroReturnDelay;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_NoLineOfSightCombat_Public_Static_BehaviourTreeNodeAuthoring_Boolean_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1326504, XrefRangeEnd = 1326528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring PathToTargetPosition(int maxExpansionsOverride)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &maxExpansionsOverride;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1326600, RefRangeEnd = 1326604, XrefRangeStart = 1326528, XrefRangeEnd = 1326600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring PathToTargetPosition(
      float recalculationFrequency,
      int maxExpansionsOverride)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &recalculationFrequency;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxExpansionsOverride;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1326604, XrefRangeEnd = 1326605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring PathToTargetPosition(
      float recalculationFrequency)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &recalculationFrequency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1326629, RefRangeEnd = 1326631, XrefRangeStart = 1326605, XrefRangeEnd = 1326629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring PathToTargetPosition()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1326631, XrefRangeEnd = 1326664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring PathAwayFromTargetPosition(
      float minFleeDistanceFromTarget,
      float maxFleeDistanceFromTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &minFleeDistanceFromTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxFleeDistanceFromTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_PathAwayFromTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1326718, RefRangeEnd = 1326719, XrefRangeStart = 1326664, XrefRangeEnd = 1326718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring Method_Internal_Static_BehaviourTreeNodeAuthoring_byref___c__DisplayClass0_0_0(
      ref BehaviourTreeShared.__c__DisplayClass0_0 _param0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref _param0;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_byref___c__DisplayClass0_0_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1326853, RefRangeEnd = 1326854, XrefRangeStart = 1326719, XrefRangeEnd = 1326853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring Method_Internal_Static_BehaviourTreeNodeAuthoring_byref___c__DisplayClass0_0_1(
      ref BehaviourTreeShared.__c__DisplayClass0_0 _param0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref _param0;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_byref___c__DisplayClass0_0_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1327007, RefRangeEnd = 1327008, XrefRangeStart = 1326854, XrefRangeEnd = 1327007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeNodeAuthoring Method_Internal_Static_BehaviourTreeNodeAuthoring_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeShared.NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BehaviourTreeNodeAuthoring) null : new BehaviourTreeNodeAuthoring(pointer);
    }

    static BehaviourTreeShared()
    {
      Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (BehaviourTreeShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr);
      BehaviourTreeShared.NativeMethodInfoPtr_GenericIdleBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663681);
      BehaviourTreeShared.NativeMethodInfoPtr_GenericAlertBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663682);
      BehaviourTreeShared.NativeMethodInfoPtr_GenericCombatBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Boolean_Boolean_Single_RelocationSettingsAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663683);
      BehaviourTreeShared.NativeMethodInfoPtr_GenericCombatRelocateBehaviour_Public_Static_BehaviourTreeNodeAuthoring_RelocationSettingsAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663684);
      BehaviourTreeShared.NativeMethodInfoPtr_Combat_Internal_Static_BehaviourTreeNodeAuthoring_Boolean_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663685);
      BehaviourTreeShared.NativeMethodInfoPtr_GenericReturnBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663686);
      BehaviourTreeShared.NativeMethodInfoPtr_GenericFollowBehaviour_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663687);
      BehaviourTreeShared.NativeMethodInfoPtr_GenericImprisonedBehaviour_Public_Static_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663688);
      BehaviourTreeShared.NativeMethodInfoPtr_CreateAlertAlliesNode_Internal_Static_BehaviourTreeNodeAuthoring_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663689);
      BehaviourTreeShared.NativeMethodInfoPtr_GlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_PrefabGUID_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663690);
      BehaviourTreeShared.NativeMethodInfoPtr_WithGlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_BehaviourTreeNodeAuthoring_PrefabGUID_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663691);
      BehaviourTreeShared.NativeMethodInfoPtr_WithGlobalLogic_Public_Static_BehaviourTreeNodeAuthoring_BehaviourTreeNodeAuthoring_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663692);
      BehaviourTreeShared.NativeMethodInfoPtr_RegenerateHealth_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663693);
      BehaviourTreeShared.NativeMethodInfoPtr_NoLineOfSightCombat_Public_Static_BehaviourTreeNodeAuthoring_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663694);
      BehaviourTreeShared.NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663695);
      BehaviourTreeShared.NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663696);
      BehaviourTreeShared.NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663697);
      BehaviourTreeShared.NativeMethodInfoPtr_PathToTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663698);
      BehaviourTreeShared.NativeMethodInfoPtr_PathAwayFromTargetPosition_Public_Static_BehaviourTreeNodeAuthoring_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663699);
      BehaviourTreeShared.NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663700);
      BehaviourTreeShared.NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_byref___c__DisplayClass0_0_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663701);
      BehaviourTreeShared.NativeMethodInfoPtr_Method_Internal_Static_BehaviourTreeNodeAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, 100663702);
    }

    public BehaviourTreeShared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("ProjectM.BehaviourTreeShared/<>c__DisplayClass0_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass0_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_idleReturnDistance;
      private static readonly System.IntPtr NativeFieldInfoPtr_minIdleChillTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_maxIdleChillTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_maxWanderDistanceFromHome;
      [FieldOffset(0)]
      public float idleReturnDistance;
      [FieldOffset(4)]
      public float minIdleChillTime;
      [FieldOffset(8)]
      public float maxIdleChillTime;
      [FieldOffset(12)]
      public float maxWanderDistanceFromHome;

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<BehaviourTreeShared.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeShared>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeShared.__c__DisplayClass0_0>.NativeClassPtr);
        BehaviourTreeShared.__c__DisplayClass0_0.NativeFieldInfoPtr_idleReturnDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeShared.__c__DisplayClass0_0>.NativeClassPtr, nameof (idleReturnDistance));
        BehaviourTreeShared.__c__DisplayClass0_0.NativeFieldInfoPtr_minIdleChillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeShared.__c__DisplayClass0_0>.NativeClassPtr, nameof (minIdleChillTime));
        BehaviourTreeShared.__c__DisplayClass0_0.NativeFieldInfoPtr_maxIdleChillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeShared.__c__DisplayClass0_0>.NativeClassPtr, nameof (maxIdleChillTime));
        BehaviourTreeShared.__c__DisplayClass0_0.NativeFieldInfoPtr_maxWanderDistanceFromHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeShared.__c__DisplayClass0_0>.NativeClassPtr, nameof (maxWanderDistanceFromHome));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeShared.__c__DisplayClass0_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
