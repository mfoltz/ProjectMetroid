// Decompiled with JetBrains decompiler
// Type: ProjectM.Update_ReplaceAbilityOnSlotSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class Update_ReplaceAbilityOnSlotSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdateAddQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdateRemoveQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_Add_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_Add_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_Add_WithCondition_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_Add_WithCondition_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_Remove_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_Remove_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_Remove_WithCondition_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Update_Remove_WithCondition_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Remove_Private_Static_Void_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_EntityManager_Entity_ConditionChecker_Double_EntityCommandBuffer_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Add_Private_Static_Boolean_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_EntityManager_EntityCommandBuffer_Entity_ConditionChecker_ModificationStructure_Boolean_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Add_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Add_WithCondition_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Remove_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Remove_WithCondition_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381687, XrefRangeEnd = 1381701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381701, XrefRangeEnd = 1381706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381706, XrefRangeEnd = 1381781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1381850, RefRangeEnd = 1381852, XrefRangeStart = 1381781, XrefRangeEnd = 1381850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Update_Remove(
      DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications,
      EntityManager entityManager,
      Entity entity,
      ConditionChecker conditionChecker,
      double serverTime,
      EntityCommandBuffer commandBuffer,
      bool withCondition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &slotModifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &conditionChecker;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &withCondition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Update_Remove_Private_Static_Void_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_EntityManager_Entity_ConditionChecker_Double_EntityCommandBuffer_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1381955, RefRangeEnd = 1381957, XrefRangeStart = 1381852, XrefRangeEnd = 1381955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Update_Add(
      DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications,
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      Entity entity,
      ConditionChecker conditionChecker,
      ModificationStructure modificationStruct,
      bool withCondition,
      double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &slotModifications;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &conditionChecker;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &modificationStruct;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &withCondition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Update_Add_Private_Static_Boolean_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_EntityManager_EntityCommandBuffer_Entity_ConditionChecker_ModificationStructure_Boolean_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Update_ReplaceAbilityOnSlotSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381957, XrefRangeEnd = 1382059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1382084, RefRangeEnd = 1382085, XrefRangeStart = 1382059, XrefRangeEnd = 1382084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdate_Add_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Add_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382085, XrefRangeEnd = 1382104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdate_Add_WithCondition_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Add_WithCondition_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1382129, RefRangeEnd = 1382130, XrefRangeStart = 1382104, XrefRangeEnd = 1382129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdate_Remove_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Remove_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382130, XrefRangeEnd = 1382149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdate_Remove_WithCondition_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Remove_WithCondition_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1382153, RefRangeEnd = 1382154, XrefRangeStart = 1382149, XrefRangeEnd = 1382153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1382158, RefRangeEnd = 1382159, XrefRangeStart = 1382154, XrefRangeEnd = 1382158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1382163, RefRangeEnd = 1382164, XrefRangeStart = 1382159, XrefRangeEnd = 1382163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1382168, RefRangeEnd = 1382169, XrefRangeStart = 1382164, XrefRangeEnd = 1382168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Update_ReplaceAbilityOnSlotSystem()
    {
      Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (Update_ReplaceAbilityOnSlotSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr);
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, nameof (_ModificationSystem));
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__UpdateAddQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, nameof (_UpdateAddQuery));
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__UpdateRemoveQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, nameof (_UpdateRemoveQuery));
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Update_Add_entityQuery");
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Update_Add_profilerMarker");
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_WithCondition_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Update_Add_WithCondition_entityQuery");
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_WithCondition_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Update_Add_WithCondition_profilerMarker");
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Update_Remove_entityQuery");
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Update_Remove_profilerMarker");
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_WithCondition_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Update_Remove_WithCondition_entityQuery");
      Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_WithCondition_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Update_Remove_WithCondition_profilerMarker");
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665478);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665479);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665480);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Update_Remove_Private_Static_Void_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_EntityManager_Entity_ConditionChecker_Double_EntityCommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665481);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Update_Add_Private_Static_Boolean_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_EntityManager_EntityCommandBuffer_Entity_ConditionChecker_ModificationStructure_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665482);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665483);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665484);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Add_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665485);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Add_WithCondition_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665486);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Remove_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665487);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdate_Remove_WithCondition_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665488);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665489);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665490);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665491);
      Update_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665492);
    }

    public Update_ReplaceAbilityOnSlotSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _UpdateAddQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__UpdateAddQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__UpdateAddQuery)) = value;
      }
    }

    public unsafe EntityQuery _UpdateRemoveQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__UpdateRemoveQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr__UpdateRemoveQuery)) = value;
      }
    }

    public unsafe EntityQuery __Update_Add_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Update_Add_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __Update_Add_WithCondition_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_WithCondition_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_WithCondition_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Update_Add_WithCondition_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_WithCondition_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Add_WithCondition_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __Update_Remove_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Update_Remove_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __Update_Remove_WithCondition_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_WithCondition_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_WithCondition_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Update_Remove_WithCondition_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_WithCondition_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Update_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Update_Remove_WithCondition_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/<>c__DisplayClass7_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass7_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(24)]
      public ConditionChecker conditionChecker;
      [FieldOffset(2224)]
      public ModificationStructure modificationStruct;
      [FieldOffset(2256)]
      public double serverTime;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotModifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotModifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        ref DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotModifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        ref DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotModifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (entityManager));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (commandBuffer));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (conditionChecker));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (modificationStruct));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (serverTime));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, 100665493);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, 100665494);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, 100665495);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, 100665496);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, 100665497);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Add")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Update_Add
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(24)]
      public ConditionChecker conditionChecker;
      [FieldOffset(2224)]
      public ModificationStructure modificationStruct;
      [FieldOffset(2256)]
      public double serverTime;
      [FieldOffset(2264)]
      public Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(2312)]
      public unsafe Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381318, XrefRangeEnd = 1381323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotModifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1381324, RefRangeEnd = 1381326, XrefRangeStart = 1381323, XrefRangeEnd = 1381324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1381327, RefRangeEnd = 1381329, XrefRangeStart = 1381326, XrefRangeEnd = 1381327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381329, XrefRangeEnd = 1381331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381337, RefRangeEnd = 1381338, XrefRangeStart = 1381331, XrefRangeEnd = 1381337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381340, RefRangeEnd = 1381341, XrefRangeStart = 1381338, XrefRangeEnd = 1381340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Update_ReplaceAbilityOnSlotSystem componentSystem,
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381341, XrefRangeEnd = 1381345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381345, XrefRangeEnd = 1381351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Update_Add()
      {
        Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass_Update_Add");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (entityManager));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (commandBuffer));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (conditionChecker));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (modificationStruct));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (serverTime));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (_runtimes));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, 100665498);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, 100665499);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, 100665500);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, 100665501);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, 100665502);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, 100665503);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, 100665504);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, 100665505);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_slotModifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotModificationBuffer> forParameter_slotModifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381237, RefRangeEnd = 1381238, XrefRangeStart = 1381233, XrefRangeEnd = 1381237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(Update_ReplaceAbilityOnSlotSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381242, RefRangeEnd = 1381243, XrefRangeStart = 1381238, XrefRangeEnd = 1381242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_slotModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_slotModifications));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders>.NativeClassPtr, 100665506);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders>.NativeClassPtr, 100665507);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_slotModifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotModificationBuffer>.Runtime runtime_slotModifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_slotModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_slotModifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Add/ProjectM.RunWithoutJobSystem_00000518$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, "RunWithoutJobSystem_00000518$PostfixBurstDelegate");
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665508);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665509);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665510);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665511);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Add/ProjectM.RunWithoutJobSystem_00000518$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381243, XrefRangeEnd = 1381257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381257, XrefRangeEnd = 1381275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381275, XrefRangeEnd = 1381290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381317, RefRangeEnd = 1381318, XrefRangeStart = 1381290, XrefRangeEnd = 1381317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add>.NativeClassPtr, "RunWithoutJobSystem_00000518$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665512);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665513);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665514);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665515);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665517);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Add_WithCondition")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Update_Add_WithCondition
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(24)]
      public ConditionChecker conditionChecker;
      [FieldOffset(2224)]
      public ModificationStructure modificationStruct;
      [FieldOffset(2256)]
      public double serverTime;
      [FieldOffset(2264)]
      public Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(2312)]
      public unsafe Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381438, RefRangeEnd = 1381439, XrefRangeStart = 1381436, XrefRangeEnd = 1381438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotModifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1381324, RefRangeEnd = 1381326, XrefRangeStart = 1381324, XrefRangeEnd = 1381326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1381327, RefRangeEnd = 1381329, XrefRangeStart = 1381327, XrefRangeEnd = 1381329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381439, XrefRangeEnd = 1381441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381447, RefRangeEnd = 1381448, XrefRangeStart = 1381441, XrefRangeEnd = 1381447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381450, RefRangeEnd = 1381451, XrefRangeStart = 1381448, XrefRangeEnd = 1381450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Update_ReplaceAbilityOnSlotSystem componentSystem,
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381451, XrefRangeEnd = 1381455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381455, XrefRangeEnd = 1381461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Update_Add_WithCondition()
      {
        Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass_Update_Add_WithCondition");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (entityManager));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (commandBuffer));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (conditionChecker));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (modificationStruct));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (serverTime));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (_runtimes));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, 100665518);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, 100665519);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, 100665520);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, 100665521);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, 100665522);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, 100665523);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, 100665524);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, 100665525);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_slotModifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotModificationBuffer> forParameter_slotModifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381355, RefRangeEnd = 1381356, XrefRangeStart = 1381351, XrefRangeEnd = 1381355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(Update_ReplaceAbilityOnSlotSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381360, RefRangeEnd = 1381361, XrefRangeStart = 1381356, XrefRangeEnd = 1381360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_slotModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_slotModifications));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, 100665526);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, 100665527);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_slotModifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotModificationBuffer>.Runtime runtime_slotModifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_slotModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_slotModifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Add_WithCondition/ProjectM.RunWithoutJobSystem_00000521$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, "RunWithoutJobSystem_00000521$PostfixBurstDelegate");
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665528);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665529);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665530);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665531);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Add_WithCondition/ProjectM.RunWithoutJobSystem_00000521$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381361, XrefRangeEnd = 1381375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381375, XrefRangeEnd = 1381393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381393, XrefRangeEnd = 1381408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381435, RefRangeEnd = 1381436, XrefRangeStart = 1381408, XrefRangeEnd = 1381435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition>.NativeClassPtr, "RunWithoutJobSystem_00000521$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665532);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665533);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665534);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665535);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665537);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Add_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Remove")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Update_Remove
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ConditionChecker conditionChecker;
      [FieldOffset(2208)]
      public double serverTime;
      [FieldOffset(2216)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(2232)]
      public Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(2280)]
      public unsafe Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381548, RefRangeEnd = 1381549, XrefRangeStart = 1381546, XrefRangeEnd = 1381548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotModifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1381550, RefRangeEnd = 1381552, XrefRangeStart = 1381549, XrefRangeEnd = 1381550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1381553, RefRangeEnd = 1381555, XrefRangeStart = 1381552, XrefRangeEnd = 1381553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381555, XrefRangeEnd = 1381557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381563, RefRangeEnd = 1381564, XrefRangeStart = 1381557, XrefRangeEnd = 1381563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381566, RefRangeEnd = 1381567, XrefRangeStart = 1381564, XrefRangeEnd = 1381566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Update_ReplaceAbilityOnSlotSystem componentSystem,
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381567, XrefRangeEnd = 1381571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381571, XrefRangeEnd = 1381577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Update_Remove()
      {
        Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass_Update_Remove");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (entityManager));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (conditionChecker));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (serverTime));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (commandBuffer));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (_runtimes));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, 100665538);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, 100665539);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, 100665540);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, 100665541);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, 100665542);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, 100665543);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, 100665544);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, 100665545);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_slotModifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotModificationBuffer> forParameter_slotModifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381465, RefRangeEnd = 1381466, XrefRangeStart = 1381461, XrefRangeEnd = 1381465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(Update_ReplaceAbilityOnSlotSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381470, RefRangeEnd = 1381471, XrefRangeStart = 1381466, XrefRangeEnd = 1381470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_slotModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_slotModifications));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders>.NativeClassPtr, 100665546);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders>.NativeClassPtr, 100665547);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_slotModifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotModificationBuffer>.Runtime runtime_slotModifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_slotModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_slotModifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Remove/ProjectM.RunWithoutJobSystem_0000052A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, "RunWithoutJobSystem_0000052A$PostfixBurstDelegate");
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665548);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665549);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665550);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665551);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Remove/ProjectM.RunWithoutJobSystem_0000052A$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381471, XrefRangeEnd = 1381485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381485, XrefRangeEnd = 1381503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381503, XrefRangeEnd = 1381518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381545, RefRangeEnd = 1381546, XrefRangeStart = 1381518, XrefRangeEnd = 1381545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove>.NativeClassPtr, "RunWithoutJobSystem_0000052A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665552);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665553);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665554);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665555);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665557);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Remove_WithCondition")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Update_Remove_WithCondition
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ConditionChecker conditionChecker;
      [FieldOffset(2208)]
      public double serverTime;
      [FieldOffset(2216)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(2232)]
      public Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(2280)]
      public unsafe Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381664, RefRangeEnd = 1381665, XrefRangeStart = 1381662, XrefRangeEnd = 1381664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<AbilityGroupSlotModificationBuffer> slotModifications)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref slotModifications;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1381550, RefRangeEnd = 1381552, XrefRangeStart = 1381550, XrefRangeEnd = 1381552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1381553, RefRangeEnd = 1381555, XrefRangeStart = 1381553, XrefRangeEnd = 1381555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381665, XrefRangeEnd = 1381667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381673, RefRangeEnd = 1381674, XrefRangeStart = 1381667, XrefRangeEnd = 1381673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381676, RefRangeEnd = 1381677, XrefRangeStart = 1381674, XrefRangeEnd = 1381676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Update_ReplaceAbilityOnSlotSystem componentSystem,
        ref Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381677, XrefRangeEnd = 1381681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381681, XrefRangeEnd = 1381687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Update_Remove_WithCondition()
      {
        Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass_Update_Remove_WithCondition");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (entityManager));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (conditionChecker));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (serverTime));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (commandBuffer));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (_runtimes));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AbilityGroupSlotModificationBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, 100665558);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, 100665559);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, 100665560);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, 100665561);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, 100665562);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, 100665563);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, 100665564);
        Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, 100665565);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_slotModifications;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotModificationBuffer> forParameter_slotModifications;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381581, RefRangeEnd = 1381582, XrefRangeStart = 1381577, XrefRangeEnd = 1381581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(Update_ReplaceAbilityOnSlotSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381586, RefRangeEnd = 1381587, XrefRangeStart = 1381582, XrefRangeEnd = 1381586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_slotModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_slotModifications));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Update_ReplaceAbilityOnSlotSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, 100665566);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, 100665567);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_slotModifications;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AbilityGroupSlotModificationBuffer>.Runtime runtime_slotModifications;

          static Runtimes()
          {
            Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_slotModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_slotModifications));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Remove_WithCondition/ProjectM.RunWithoutJobSystem_00000533$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, "RunWithoutJobSystem_00000533$PostfixBurstDelegate");
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665568);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665569);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665570);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665571);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Update_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Update_Remove_WithCondition/ProjectM.RunWithoutJobSystem_00000533$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381587, XrefRangeEnd = 1381601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381601, XrefRangeEnd = 1381619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381619, XrefRangeEnd = 1381634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381661, RefRangeEnd = 1381662, XrefRangeStart = 1381634, XrefRangeEnd = 1381661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition>.NativeClassPtr, "RunWithoutJobSystem_00000533$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665572);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665573);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665574);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665575);
          Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665577);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Update_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Update_Remove_WithCondition.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
