// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.StartCharacterCraftingSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

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
namespace ProjectM.Gameplay.Systems
{
  public class StartCharacterCraftingSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__StartCharacterCraftItemEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr___StartCraftingJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___StartCraftingJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForStartCraftingJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435428, XrefRangeEnd = 1435447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartCharacterCraftingSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435447, XrefRangeEnd = 1435450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartCharacterCraftingSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435450, XrefRangeEnd = 1435463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartCharacterCraftingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StartCharacterCraftingSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435463, XrefRangeEnd = 1435486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StartCharacterCraftingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435486, XrefRangeEnd = 1435505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForStartCraftingJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.NativeMethodInfoPtr___GetEntityQuery_ForStartCraftingJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static StartCharacterCraftingSystem()
    {
      Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (StartCharacterCraftingSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr);
      StartCharacterCraftingSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, nameof (_GameDataSystem));
      StartCharacterCraftingSystem.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      StartCharacterCraftingSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      StartCharacterCraftingSystem.NativeFieldInfoPtr__StartCharacterCraftItemEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, nameof (_StartCharacterCraftItemEventQuery));
      StartCharacterCraftingSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, nameof (_SyncedServerDebugSettingsAccessor));
      StartCharacterCraftingSystem.NativeFieldInfoPtr___StartCraftingJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, "<>StartCraftingJob_entityQuery");
      StartCharacterCraftingSystem.NativeFieldInfoPtr___StartCraftingJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, "<>StartCraftingJob_profilerMarker");
      StartCharacterCraftingSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, 100671234);
      StartCharacterCraftingSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, 100671235);
      StartCharacterCraftingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, 100671236);
      StartCharacterCraftingSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, 100671237);
      StartCharacterCraftingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, 100671238);
      StartCharacterCraftingSystem.NativeMethodInfoPtr___GetEntityQuery_ForStartCraftingJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, 100671239);
    }

    public StartCharacterCraftingSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == System.IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _StartCharacterCraftItemEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__StartCharacterCraftItemEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__StartCharacterCraftItemEventQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _SyncedServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __StartCraftingJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr___StartCraftingJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr___StartCraftingJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __StartCraftingJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr___StartCraftingJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.NativeFieldInfoPtr___StartCraftingJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StartCharacterCraftingSystem/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_recipeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_StartCharacterCraftItemEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref StartCharacterCraftItemEvent startCraftEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref startCraftEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_StartCharacterCraftItemEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr);
        StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_recipeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (recipeHashLookupMap));
        StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (skipProgressionCheck));
        StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (buildCostsDisabled));
        StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr, 100671240);
        StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_StartCharacterCraftItemEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr, 100671241);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe StartCharacterCraftingSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StartCharacterCraftingSystem) null : new StartCharacterCraftingSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, RecipeData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_recipeHashLookupMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_recipeHashLookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, RecipeData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.StartCharacterCraftingSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_StartCraftingJob")]
    public sealed class __c__DisplayClass_StartCraftingJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_recipeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StartCharacterCraftItemEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StartCharacterCraftingSystem_byref___c__DisplayClass7_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1435401, RefRangeEnd = 1435402, XrefRangeStart = 1435358, XrefRangeEnd = 1435401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref StartCharacterCraftItemEvent startCraftEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref startCraftEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StartCharacterCraftItemEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435402, XrefRangeEnd = 1435403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StartCharacterCraftingSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1435404, RefRangeEnd = 1435405, XrefRangeStart = 1435403, XrefRangeEnd = 1435404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StartCharacterCraftingSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435405, XrefRangeEnd = 1435419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1435425, RefRangeEnd = 1435426, XrefRangeStart = 1435419, XrefRangeEnd = 1435425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1435427, RefRangeEnd = 1435428, XrefRangeStart = 1435426, XrefRangeEnd = 1435427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StartCharacterCraftingSystem componentSystem,
        ref StartCharacterCraftingSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StartCharacterCraftingSystem_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_StartCraftingJob()
      {
        Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartCharacterCraftingSystem>.NativeClassPtr, "<>c__DisplayClass_StartCraftingJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr);
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, "<>4__this");
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_recipeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, nameof (recipeHashLookupMap));
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, nameof (skipProgressionCheck));
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, nameof (buildCostsDisabled));
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, nameof (_runtimes));
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StartCharacterCraftItemEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, 100671242);
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, 100671243);
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, 100671244);
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, 100671246);
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, 100671247);
        StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StartCharacterCraftingSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, 100671248);
      }

      public __c__DisplayClass_StartCraftingJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_StartCraftingJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, data));
      }

      public unsafe StartCharacterCraftingSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StartCharacterCraftingSystem) null : new StartCharacterCraftingSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, RecipeData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_recipeHashLookupMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_recipeHashLookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, RecipeData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }

      public unsafe StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_startCraftEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StartCharacterCraftingSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<StartCharacterCraftItemEvent> forParameter_startCraftEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435342, XrefRangeEnd = 1435349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StartCharacterCraftingSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StartCharacterCraftingSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1435357, RefRangeEnd = 1435358, XrefRangeStart = 1435349, XrefRangeEnd = 1435357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_startCraftEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_startCraftEvent));
          StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StartCharacterCraftingSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders>.NativeClassPtr, 100671249);
          StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders>.NativeClassPtr, 100671250);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_startCraftEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<StartCharacterCraftItemEvent>.StructuralChangeRuntime runtime_startCraftEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_startCraftEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_startCraftEvent));
            StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartCharacterCraftingSystem.__c__DisplayClass_StartCraftingJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
