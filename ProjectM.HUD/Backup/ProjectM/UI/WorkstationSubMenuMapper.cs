// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.WorkstationSubMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class WorkstationSubMenuMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedRecipes;
    private static readonly System.IntPtr NativeFieldInfoPtr__BonusDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__RecipesDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutputDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedRecipeRequirements;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_17;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalPlayer_Private_Boolean_byref_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindQueuedCraftAction_Private_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_QueuedWorkstationCraftAction_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256164, XrefRangeEnd = 1256197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorkstationSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256197, XrefRangeEnd = 1256200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorkstationSubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256200, XrefRangeEnd = 1256211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetLocalPlayer(out Entity localPlayer, out Entity localUser)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUser;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.NativeMethodInfoPtr_TryGetLocalPlayer_Private_Boolean_byref_Entity_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256211, XrefRangeEnd = 1256245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorkstationSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256245, XrefRangeEnd = 1256254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindQueuedCraftAction(
      DynamicBuffer<QueuedWorkstationCraftAction> queuedActions,
      PrefabGUID recipeGuid,
      out QueuedWorkstationCraftAction craftAction,
      out int craftIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &queuedActions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref craftAction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref craftIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.NativeMethodInfoPtr_TryFindQueuedCraftAction_Private_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_QueuedWorkstationCraftAction_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256254, XrefRangeEnd = 1256283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorkstationSubMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256283, XrefRangeEnd = 1256310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorkstationSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256310, XrefRangeEnd = 1256326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WorkstationSubMenuMapper()
    {
      Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (WorkstationSubMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr);
      WorkstationSubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_UnlockedRecipes));
      WorkstationSubMenuMapper.NativeFieldInfoPtr__BonusDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_BonusDatas));
      WorkstationSubMenuMapper.NativeFieldInfoPtr__RecipesDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_RecipesDatas));
      WorkstationSubMenuMapper.NativeFieldInfoPtr__OutputDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_OutputDatas));
      WorkstationSubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_CachedRecipeRequirements));
      WorkstationSubMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_Query));
      WorkstationSubMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      WorkstationSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      WorkstationSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      WorkstationSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      WorkstationSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      WorkstationSubMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_17));
      WorkstationSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, 100666884);
      WorkstationSubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, 100666885);
      WorkstationSubMenuMapper.NativeMethodInfoPtr_TryGetLocalPlayer_Private_Boolean_byref_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, 100666886);
      WorkstationSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, 100666887);
      WorkstationSubMenuMapper.NativeMethodInfoPtr_TryFindQueuedCraftAction_Private_Static_Boolean_DynamicBuffer_1_QueuedWorkstationCraftAction_PrefabGUID_byref_QueuedWorkstationCraftAction_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, 100666888);
      WorkstationSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, 100666889);
      WorkstationSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, 100666890);
      WorkstationSubMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, 100666891);
    }

    public WorkstationSubMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashSet<PrefabGUID> _UnlockedRecipes
    {
      get
      {
        return *(NativeHashSet<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__UnlockedRecipes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<StationBonusEntry.Data> _BonusDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__BonusDatas));
        return pointer == System.IntPtr.Zero ? (List<StationBonusEntry.Data>) null : new List<StationBonusEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__BonusDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WorkstationRecipeGridSelectionEntry.Data> _RecipesDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__RecipesDatas));
        return pointer == System.IntPtr.Zero ? (List<WorkstationRecipeGridSelectionEntry.Data>) null : new List<WorkstationRecipeGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__RecipesDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemGridSelectionEntry.Data> _OutputDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__OutputDatas));
        return pointer == System.IntPtr.Zero ? (List<ItemGridSelectionEntry.Data>) null : new List<ItemGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__OutputDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, List<CostData>> _CachedRecipeRequirements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, List<CostData>>) null : new Dictionary<int, List<CostData>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__CachedRecipeRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_17
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_17));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_17)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WorkstationTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      [FieldOffset(0)]
      public Entity Target;

      static WorkstationTarget()
      {
        Il2CppClassPointerStore<WorkstationSubMenuMapper.WorkstationTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, nameof (WorkstationTarget));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationSubMenuMapper.WorkstationTarget>.NativeClassPtr);
        WorkstationSubMenuMapper.WorkstationTarget.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.WorkstationTarget>.NativeClassPtr, nameof (Target));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkstationSubMenuMapper.WorkstationTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.WorkstationSubMenuMapper/<>c__DisplayClass13_0")]
    public sealed class __c__DisplayClass13_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_progressionEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_WorkstationSubMenu_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity menuEntity, WorkstationSubMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &menuEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_WorkstationSubMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr);
        WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
        WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_progressionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, nameof (progressionEntity));
        WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, nameof (gameDataSystem));
        WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, nameof (prefabLookupMap));
        WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_localUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, nameof (localUser));
        WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, nameof (localPlayer));
        WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, 100666892);
        WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_WorkstationSubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, 100666893);
      }

      public __c__DisplayClass13_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass13_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass13_0>.NativeClassPtr, data));
      }

      public unsafe WorkstationSubMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (WorkstationSubMenuMapper) null : new WorkstationSubMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity progressionEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_progressionEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_progressionEntity)) = value;
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe Entity localUser
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_localUser));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_localUser)) = value;
        }
      }

      public unsafe Entity localPlayer
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_localPlayer));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass13_0.NativeFieldInfoPtr_localPlayer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.WorkstationSubMenuMapper/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_progressionEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_WorkstationSubMenu_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorkstationSubMenuMapper_byref___c__DisplayClass13_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1256145, RefRangeEnd = 1256146, XrefRangeStart = 1255865, XrefRangeEnd = 1256145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity menuEntity, WorkstationSubMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &menuEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_WorkstationSubMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref WorkstationSubMenuMapper.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1235666, RefRangeEnd = 1235668, XrefRangeStart = 1235666, XrefRangeEnd = 1235668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref WorkstationSubMenuMapper.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256146, XrefRangeEnd = 1256157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1256163, RefRangeEnd = 1256164, XrefRangeStart = 1256157, XrefRangeEnd = 1256163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1235688, RefRangeEnd = 1235690, XrefRangeStart = 1235688, XrefRangeEnd = 1235690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        WorkstationSubMenuMapper componentSystem,
        ref WorkstationSubMenuMapper.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorkstationSubMenuMapper_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkstationSubMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "<>4__this");
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_progressionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (progressionEntity));
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (gameDataSystem));
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (prefabLookupMap));
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (localUser));
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (localPlayer));
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_WorkstationSubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666894);
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666895);
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666896);
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666898);
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666899);
        WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorkstationSubMenuMapper_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666900);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe WorkstationSubMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (WorkstationSubMenuMapper) null : new WorkstationSubMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity progressionEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_progressionEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_progressionEntity)) = value;
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe Entity localUser
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localUser));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localUser)) = value;
        }
      }

      public unsafe Entity localPlayer
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localPlayer));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localPlayer)) = value;
        }
      }

      public unsafe WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menuEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menu;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorkstationSubMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_menuEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<WorkstationSubMenu> forParameter_menu;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255855, XrefRangeEnd = 1255859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(WorkstationSubMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorkstationSubMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1255864, RefRangeEnd = 1255865, XrefRangeStart = 1255859, XrefRangeEnd = 1255864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menuEntity));
          WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menu));
          WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorkstationSubMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666901);
          WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666902);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menuEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menu;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_menuEntity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_ManagedComponentData<WorkstationSubMenu>.StructuralChangeRuntime runtime_menu;

          static Runtimes()
          {
            Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menuEntity));
            WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menu));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkstationSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
