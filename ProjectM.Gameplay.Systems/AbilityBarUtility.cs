// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityBarUtility
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class AbilityBarUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_StartCast_Internal_Static_Void_byref_EntityCommandBuffer_Entity_Entity_Entity_Int32_Double_Entity_byref_DebugData_byref_NativeList_1_AbilityIsCastingState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Interrupt_Internal_Static_Void_byref_EntityCommandBuffer_byref_AbilityBar_Shared_Entity_Double_byref_EventPrefabs_byref_DebugData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Internal_Static_Void_Entity_Entity_Entity_byref_EntityCommandBuffer_byref_AbilityBar_Shared_Double_Boolean_Boolean_Int32_byref_Int32_byref_Int32_byref_EventPrefabs_byref_NativeList_1_AbilityIsCastingState_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndCast_Internal_Static_Void_byref_AbilityBar_Shared_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyEvents_Internal_Static_Void_EntityManager_byref_EventQueries_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1370103, RefRangeEnd = 1370105, XrefRangeStart = 1370034, XrefRangeEnd = 1370103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void StartCast(
      ref EntityCommandBuffer commandBuffer,
      Entity character,
      Entity groupEntity,
      Entity abilityEntity,
      int startCastedCounter,
      double serverTime,
      Entity abilityCastStartedEvent,
      [In] ref DebugData debugData,
      ref NativeList<AbilityIsCastingState> currentCasts)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &groupEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &startCastedCounter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityCastStartedEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref debugData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentCasts;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarUtility.NativeMethodInfoPtr_StartCast_Internal_Static_Void_byref_EntityCommandBuffer_Entity_Entity_Entity_Int32_Double_Entity_byref_DebugData_byref_NativeList_1_AbilityIsCastingState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1370204, RefRangeEnd = 1370206, XrefRangeStart = 1370105, XrefRangeEnd = 1370204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Interrupt(
      ref EntityCommandBuffer commandBuffer,
      ref AbilityBar_Shared abilityBar,
      Entity character,
      double serverTime,
      [In] ref EventPrefabs eventPrefabs,
      [In] ref DebugData debugData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBar;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventPrefabs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref debugData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarUtility.NativeMethodInfoPtr_Interrupt_Internal_Static_Void_byref_EntityCommandBuffer_byref_AbilityBar_Shared_Entity_Double_byref_EventPrefabs_byref_DebugData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1370590, RefRangeEnd = 1370592, XrefRangeStart = 1370206, XrefRangeEnd = 1370590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Update(
      Entity character,
      Entity ability,
      Entity abilityGroup,
      ref EntityCommandBuffer commandBuffer,
      ref AbilityBar_Shared abilityBar,
      double serverTime,
      bool serverHasAcked,
      bool isClient,
      int currentFrame,
      ref int castStartedCounter,
      ref int castCompletedCounter,
      [In] ref EventPrefabs eventPrefabs,
      ref NativeList<AbilityIsCastingState> currentCasts,
      out bool castFinishedThisFrame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[14];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ability;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBar;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &serverHasAcked;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &isClient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &currentFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref castStartedCounter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref castCompletedCounter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventPrefabs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentCasts;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) ref castFinishedThisFrame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarUtility.NativeMethodInfoPtr_Update_Internal_Static_Void_Entity_Entity_Entity_byref_EntityCommandBuffer_byref_AbilityBar_Shared_Double_Boolean_Boolean_Int32_byref_Int32_byref_Int32_byref_EventPrefabs_byref_NativeList_1_AbilityIsCastingState_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1370599, RefRangeEnd = 1370600, XrefRangeStart = 1370592, XrefRangeEnd = 1370599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void EndCast(ref AbilityBar_Shared abilityBar)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref abilityBar;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarUtility.NativeMethodInfoPtr_EndCast_Internal_Static_Void_byref_AbilityBar_Shared_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1370614, RefRangeEnd = 1370615, XrefRangeStart = 1370600, XrefRangeEnd = 1370614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyEvents(
      EntityManager entityManager,
      [In] ref EventQueries eventQueries)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventQueries;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarUtility.NativeMethodInfoPtr_DestroyEvents_Internal_Static_Void_EntityManager_byref_EventQueries_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityBarUtility()
    {
      Il2CppClassPointerStore<AbilityBarUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityBarUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityBarUtility>.NativeClassPtr);
      AbilityBarUtility.NativeMethodInfoPtr_StartCast_Internal_Static_Void_byref_EntityCommandBuffer_Entity_Entity_Entity_Int32_Double_Entity_byref_DebugData_byref_NativeList_1_AbilityIsCastingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarUtility>.NativeClassPtr, 100664339);
      AbilityBarUtility.NativeMethodInfoPtr_Interrupt_Internal_Static_Void_byref_EntityCommandBuffer_byref_AbilityBar_Shared_Entity_Double_byref_EventPrefabs_byref_DebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarUtility>.NativeClassPtr, 100664340);
      AbilityBarUtility.NativeMethodInfoPtr_Update_Internal_Static_Void_Entity_Entity_Entity_byref_EntityCommandBuffer_byref_AbilityBar_Shared_Double_Boolean_Boolean_Int32_byref_Int32_byref_Int32_byref_EventPrefabs_byref_NativeList_1_AbilityIsCastingState_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarUtility>.NativeClassPtr, 100664341);
      AbilityBarUtility.NativeMethodInfoPtr_EndCast_Internal_Static_Void_byref_AbilityBar_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarUtility>.NativeClassPtr, 100664342);
      AbilityBarUtility.NativeMethodInfoPtr_DestroyEvents_Internal_Static_Void_EntityManager_byref_EventQueries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarUtility>.NativeClassPtr, 100664343);
    }

    public AbilityBarUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
