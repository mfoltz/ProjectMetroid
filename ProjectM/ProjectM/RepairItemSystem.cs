// Decompiled with JetBrains decompiler
// Type: ProjectM.RepairItemSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class RepairItemSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__RepairItemEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RepairEquippedItemEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr___RepairItemJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RepairItemJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RepairEquippedItemJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RepairEquippedItemJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRepairItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRepairEquippedItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044038, XrefRangeEnd = 1044057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RepairItemSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044057, XrefRangeEnd = 1044060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RepairItemSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044060, XrefRangeEnd = 1044103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RepairItemSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RepairItemSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044103, XrefRangeEnd = 1044148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RepairItemSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044148, XrefRangeEnd = 1044167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRepairItemJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.NativeMethodInfoPtr___GetEntityQuery_ForRepairItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044167, XrefRangeEnd = 1044186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRepairEquippedItemJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.NativeMethodInfoPtr___GetEntityQuery_ForRepairEquippedItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RepairItemSystem()
    {
      Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RepairItemSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr);
      RepairItemSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      RepairItemSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      RepairItemSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      RepairItemSystem.NativeFieldInfoPtr__RepairItemEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, nameof (_RepairItemEventQuery));
      RepairItemSystem.NativeFieldInfoPtr__RepairEquippedItemEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, nameof (_RepairEquippedItemEventQuery));
      RepairItemSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, nameof (_SyncedServerDebugSettingsAccessor));
      RepairItemSystem.NativeFieldInfoPtr___RepairItemJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, "<>RepairItemJob_entityQuery");
      RepairItemSystem.NativeFieldInfoPtr___RepairItemJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, "<>RepairItemJob_profilerMarker");
      RepairItemSystem.NativeFieldInfoPtr___RepairEquippedItemJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, "<>RepairEquippedItemJob_entityQuery");
      RepairItemSystem.NativeFieldInfoPtr___RepairEquippedItemJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, "<>RepairEquippedItemJob_profilerMarker");
      RepairItemSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, 100681796);
      RepairItemSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, 100681797);
      RepairItemSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, 100681798);
      RepairItemSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, 100681799);
      RepairItemSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, 100681800);
      RepairItemSystem.NativeMethodInfoPtr___GetEntityQuery_ForRepairItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, 100681801);
      RepairItemSystem.NativeMethodInfoPtr___GetEntityQuery_ForRepairEquippedItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, 100681802);
    }

    public RepairItemSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _RepairItemEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__RepairItemEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__RepairItemEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _RepairEquippedItemEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__RepairEquippedItemEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__RepairEquippedItemEventQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _SyncedServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __RepairItemJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr___RepairItemJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr___RepairItemJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RepairItemJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr___RepairItemJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr___RepairItemJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RepairEquippedItemJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr___RepairEquippedItemJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr___RepairEquippedItemJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RepairEquippedItemJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr___RepairEquippedItemJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.NativeFieldInfoPtr___RepairEquippedItemJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.RepairItemSystem/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkedSequence;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RepairItemEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RepairEquippedItemEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref RepairItemEvent repairItemEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref repairItemEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RepairItemEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref RepairEquippedItemEvent repairItemEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref repairItemEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RepairEquippedItemEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr);
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (prefabLookupMap));
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (skipProgressionCheck));
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (buildCostsDisabled));
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (prefabCollection));
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_sctCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (sctCollection));
        RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_networkedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (networkedSequence));
        RepairItemSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, 100681803);
        RepairItemSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RepairItemEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, 100681804);
        RepairItemSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RepairEquippedItemEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, 100681805);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe RepairItemSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RepairItemSystem) null : new RepairItemSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe PrefabCollectionSystem prefabCollection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabCollection));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SCTTypeCollection sctCollection
      {
        get
        {
          return *(SCTTypeCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_sctCollection));
        }
        [param: In] set
        {
          *(SCTTypeCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_sctCollection)) = value;
        }
      }

      public unsafe Entity networkedSequence
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_networkedSequence));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_networkedSequence)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.RepairItemSystem/ProjectM.<>c__DisplayClass_RepairItemJob")]
    public sealed class __c__DisplayClass_RepairItemJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkedSequence;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RepairItemEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_byref___c__DisplayClass8_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1043848, RefRangeEnd = 1043849, XrefRangeStart = 1043711, XrefRangeEnd = 1043848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref RepairItemEvent repairItemEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref repairItemEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RepairItemEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1043851, RefRangeEnd = 1043852, XrefRangeStart = 1043849, XrefRangeEnd = 1043851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RepairItemSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1043854, RefRangeEnd = 1043855, XrefRangeStart = 1043852, XrefRangeEnd = 1043854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RepairItemSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043855, XrefRangeEnd = 1043869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1043875, RefRangeEnd = 1043876, XrefRangeStart = 1043869, XrefRangeEnd = 1043875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1043877, RefRangeEnd = 1043878, XrefRangeStart = 1043876, XrefRangeEnd = 1043877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RepairItemSystem componentSystem,
        ref RepairItemSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RepairItemJob()
      {
        Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, "<>c__DisplayClass_RepairItemJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr);
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, "<>4__this");
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (prefabLookupMap));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (skipProgressionCheck));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (buildCostsDisabled));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (spawnCommandBuffer));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_prefabCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (prefabCollection));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_sctCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (sctCollection));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_networkedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (networkedSequence));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (_runtimes));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RepairItemEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, 100681806);
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, 100681807);
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, 100681808);
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, 100681810);
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, 100681811);
        RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, 100681812);
      }

      public __c__DisplayClass_RepairItemJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RepairItemJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe RepairItemSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RepairItemSystem) null : new RepairItemSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe PrefabCollectionSystem prefabCollection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_prefabCollection));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_prefabCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SCTTypeCollection sctCollection
      {
        get
        {
          return *(SCTTypeCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_sctCollection));
        }
        [param: In] set
        {
          *(SCTTypeCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_sctCollection)) = value;
        }
      }

      public unsafe Entity networkedSequence
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_networkedSequence));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr_networkedSequence)) = value;
        }
      }

      public unsafe RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RepairItemSystem.__c__DisplayClass_RepairItemJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_repairItemEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<RepairItemEvent> forParameter_repairItemEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043695, XrefRangeEnd = 1043702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RepairItemSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1043710, RefRangeEnd = 1043711, XrefRangeStart = 1043702, XrefRangeEnd = 1043710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_repairItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_repairItemEvent));
          RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders>.NativeClassPtr, 100681813);
          RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders>.NativeClassPtr, 100681814);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_repairItemEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<RepairItemEvent>.StructuralChangeRuntime runtime_repairItemEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_repairItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_repairItemEvent));
            RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.RepairItemSystem/ProjectM.<>c__DisplayClass_RepairEquippedItemJob")]
    public sealed class __c__DisplayClass_RepairEquippedItemJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkedSequence;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RepairEquippedItemEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_byref___c__DisplayClass8_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1044008, RefRangeEnd = 1044009, XrefRangeStart = 1043894, XrefRangeEnd = 1044008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref RepairEquippedItemEvent repairItemEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref repairItemEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RepairEquippedItemEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1044011, RefRangeEnd = 1044012, XrefRangeStart = 1044009, XrefRangeEnd = 1044011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RepairItemSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1044014, RefRangeEnd = 1044015, XrefRangeStart = 1044012, XrefRangeEnd = 1044014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RepairItemSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044015, XrefRangeEnd = 1044029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1044035, RefRangeEnd = 1044036, XrefRangeStart = 1044029, XrefRangeEnd = 1044035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1044037, RefRangeEnd = 1044038, XrefRangeStart = 1044036, XrefRangeEnd = 1044037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RepairItemSystem componentSystem,
        ref RepairItemSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RepairEquippedItemJob()
      {
        Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepairItemSystem>.NativeClassPtr, "<>c__DisplayClass_RepairEquippedItemJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr);
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, "<>4__this");
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (prefabLookupMap));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (skipProgressionCheck));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (buildCostsDisabled));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (spawnCommandBuffer));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_prefabCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (prefabCollection));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_sctCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (sctCollection));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_networkedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (networkedSequence));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (_runtimes));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RepairEquippedItemEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, 100681815);
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, 100681816);
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, 100681817);
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, 100681819);
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, 100681820);
        RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, 100681821);
      }

      public __c__DisplayClass_RepairEquippedItemJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RepairEquippedItemJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, data));
      }

      public unsafe RepairItemSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RepairItemSystem) null : new RepairItemSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe PrefabCollectionSystem prefabCollection
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_prefabCollection));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_prefabCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SCTTypeCollection sctCollection
      {
        get
        {
          return *(SCTTypeCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_sctCollection));
        }
        [param: In] set
        {
          *(SCTTypeCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_sctCollection)) = value;
        }
      }

      public unsafe Entity networkedSequence
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_networkedSequence));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr_networkedSequence)) = value;
        }
      }

      public unsafe RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_repairItemEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<RepairEquippedItemEvent> forParameter_repairItemEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043878, XrefRangeEnd = 1043885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RepairItemSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1043893, RefRangeEnd = 1043894, XrefRangeStart = 1043885, XrefRangeEnd = 1043893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_repairItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_repairItemEvent));
          RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RepairItemSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders>.NativeClassPtr, 100681822);
          RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders>.NativeClassPtr, 100681823);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_repairItemEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<RepairEquippedItemEvent>.StructuralChangeRuntime runtime_repairItemEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_repairItemEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_repairItemEvent));
            RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairItemSystem.__c__DisplayClass_RepairEquippedItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
