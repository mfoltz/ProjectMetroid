// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.ActivateVBloodAbilitySystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class ActivateVBloodAbilitySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActivateVBloodAbilityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ActivateVBloodAbilityJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ActivateVBloodAbilityJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForActivateVBloodAbilityJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432006, XrefRangeEnd = 1432014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActivateVBloodAbilitySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActivateVBloodAbilitySystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432014, XrefRangeEnd = 1432031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActivateVBloodAbilitySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActivateVBloodAbilitySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432031, XrefRangeEnd = 1432054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActivateVBloodAbilitySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432054, XrefRangeEnd = 1432073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForActivateVBloodAbilityJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.NativeMethodInfoPtr___GetEntityQuery_ForActivateVBloodAbilityJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ActivateVBloodAbilitySystem()
    {
      Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (ActivateVBloodAbilitySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr);
      ActivateVBloodAbilitySystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ActivateVBloodAbilitySystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      ActivateVBloodAbilitySystem.NativeFieldInfoPtr__ActivateVBloodAbilityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, nameof (_ActivateVBloodAbilityQuery));
      ActivateVBloodAbilitySystem.NativeFieldInfoPtr___ActivateVBloodAbilityJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, "<>ActivateVBloodAbilityJob_entityQuery");
      ActivateVBloodAbilitySystem.NativeFieldInfoPtr___ActivateVBloodAbilityJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, "<>ActivateVBloodAbilityJob_profilerMarker");
      ActivateVBloodAbilitySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, 100670886);
      ActivateVBloodAbilitySystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, 100670887);
      ActivateVBloodAbilitySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, 100670888);
      ActivateVBloodAbilitySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, 100670889);
      ActivateVBloodAbilitySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, 100670890);
      ActivateVBloodAbilitySystem.NativeMethodInfoPtr___GetEntityQuery_ForActivateVBloodAbilityJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, 100670891);
    }

    public ActivateVBloodAbilitySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _ActivateVBloodAbilityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr__ActivateVBloodAbilityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr__ActivateVBloodAbilityQuery)) = value;
      }
    }

    public unsafe EntityQuery __ActivateVBloodAbilityJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr___ActivateVBloodAbilityJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr___ActivateVBloodAbilityJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ActivateVBloodAbilityJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr___ActivateVBloodAbilityJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.NativeFieldInfoPtr___ActivateVBloodAbilityJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.ActivateVBloodAbilitySystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverBootstrapSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ActivateVBloodAbilityEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref ActivateVBloodAbilityEvent activateVBloodAbility,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activateVBloodAbility;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ActivateVBloodAbilityEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr);
        ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (serverBootstrapSystem));
        ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (prefabMap));
        ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr, 100670892);
        ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ActivateVBloodAbilityEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr, 100670893);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass5_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass5_0>.NativeClassPtr, data));
      }

      public unsafe ActivateVBloodAbilitySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ActivateVBloodAbilitySystem) null : new ActivateVBloodAbilitySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerBootstrapSystem serverBootstrapSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverBootstrapSystem));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabMap)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.ActivateVBloodAbilitySystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ActivateVBloodAbilityJob")]
    public sealed class __c__DisplayClass_ActivateVBloodAbilityJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverBootstrapSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ActivateVBloodAbilityEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ActivateVBloodAbilitySystem_byref___c__DisplayClass5_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1431976, RefRangeEnd = 1431977, XrefRangeStart = 1431949, XrefRangeEnd = 1431976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ActivateVBloodAbilityEvent activateVBloodAbility,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activateVBloodAbility;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ActivateVBloodAbilityEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431977, XrefRangeEnd = 1431979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ActivateVBloodAbilitySystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1431981, RefRangeEnd = 1431982, XrefRangeStart = 1431979, XrefRangeEnd = 1431981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ActivateVBloodAbilitySystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431982, XrefRangeEnd = 1431996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1432002, RefRangeEnd = 1432003, XrefRangeStart = 1431996, XrefRangeEnd = 1432002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1432005, RefRangeEnd = 1432006, XrefRangeStart = 1432003, XrefRangeEnd = 1432005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ActivateVBloodAbilitySystem componentSystem,
        ref ActivateVBloodAbilitySystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ActivateVBloodAbilitySystem_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ActivateVBloodAbilityJob()
      {
        Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivateVBloodAbilitySystem>.NativeClassPtr, "<>c__DisplayClass_ActivateVBloodAbilityJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr);
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, "<>4__this");
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr_serverBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, nameof (serverBootstrapSystem));
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, nameof (prefabMap));
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, nameof (_runtimes));
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ActivateVBloodAbilityEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, 100670894);
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, 100670895);
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, 100670896);
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, 100670898);
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, 100670899);
        ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ActivateVBloodAbilitySystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, 100670900);
      }

      public __c__DisplayClass_ActivateVBloodAbilityJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ActivateVBloodAbilityJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, data));
      }

      public unsafe ActivateVBloodAbilitySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ActivateVBloodAbilitySystem) null : new ActivateVBloodAbilitySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerBootstrapSystem serverBootstrapSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr_serverBootstrapSystem));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr_serverBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr_prefabMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr_prefabMap)) = value;
        }
      }

      public unsafe ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activateVBloodAbility;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ActivateVBloodAbilitySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ActivateVBloodAbilityEvent> forParameter_activateVBloodAbility;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431933, XrefRangeEnd = 1431940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ActivateVBloodAbilitySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ActivateVBloodAbilitySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1431948, RefRangeEnd = 1431949, XrefRangeStart = 1431940, XrefRangeEnd = 1431948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activateVBloodAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activateVBloodAbility));
          ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ActivateVBloodAbilitySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders>.NativeClassPtr, 100670901);
          ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders>.NativeClassPtr, 100670902);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activateVBloodAbility;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<ActivateVBloodAbilityEvent>.StructuralChangeRuntime runtime_activateVBloodAbility;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activateVBloodAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activateVBloodAbility));
            ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActivateVBloodAbilitySystem.__c__DisplayClass_ActivateVBloodAbilityJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
