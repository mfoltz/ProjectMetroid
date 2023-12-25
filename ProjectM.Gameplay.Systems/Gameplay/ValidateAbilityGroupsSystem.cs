// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.ValidateAbilityGroupsSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay
{
  public class ValidateAbilityGroupsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModSyncSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___NewUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___NewUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_14;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertOnDemand_AbilityGroups_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewUpdate_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForNewUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428141, XrefRangeEnd = 1428147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ValidateAbilityGroupsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428147, XrefRangeEnd = 1428148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ValidateAbilityGroupsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertOnDemand_AbilityGroups()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.NativeMethodInfoPtr_ConvertOnDemand_AbilityGroups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1428179, RefRangeEnd = 1428180, XrefRangeStart = 1428148, XrefRangeEnd = 1428179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void NewUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.NativeMethodInfoPtr_NewUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ValidateAbilityGroupsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428180, XrefRangeEnd = 1428210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ValidateAbilityGroupsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428210, XrefRangeEnd = 1428229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForNewUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.NativeMethodInfoPtr___GetEntityQuery_ForNewUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ValidateAbilityGroupsSystem()
    {
      Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay", nameof (ValidateAbilityGroupsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr);
      ValidateAbilityGroupsSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, nameof (_Query));
      ValidateAbilityGroupsSystem.NativeFieldInfoPtr__SpellModSyncSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, nameof (_SpellModSyncSystem));
      ValidateAbilityGroupsSystem.NativeFieldInfoPtr___NewUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, "<>NewUpdate_LambdaJob0_entityQuery");
      ValidateAbilityGroupsSystem.NativeFieldInfoPtr___NewUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, "<>NewUpdate_LambdaJob0_profilerMarker");
      ValidateAbilityGroupsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_14));
      ValidateAbilityGroupsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, 100670409);
      ValidateAbilityGroupsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, 100670410);
      ValidateAbilityGroupsSystem.NativeMethodInfoPtr_ConvertOnDemand_AbilityGroups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, 100670411);
      ValidateAbilityGroupsSystem.NativeMethodInfoPtr_NewUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, 100670412);
      ValidateAbilityGroupsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, 100670413);
      ValidateAbilityGroupsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, 100670414);
      ValidateAbilityGroupsSystem.NativeMethodInfoPtr___GetEntityQuery_ForNewUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, 100670415);
    }

    public ValidateAbilityGroupsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe SpellModSyncSystem_Server _SpellModSyncSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr__SpellModSyncSystem));
        return pointer == System.IntPtr.Zero ? (SpellModSyncSystem_Server) null : new SpellModSyncSystem_Server(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr__SpellModSyncSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __NewUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr___NewUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr___NewUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __NewUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr___NewUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr___NewUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_14
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_14));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_14)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.ValidateAbilityGroupsSystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_spellModCollection;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__NewUpdate_b__0_Internal_Void_byref_AbilityGroupSlot_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _NewUpdate_b__0(ref AbilityGroupSlot groupSlot)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref groupSlot;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__NewUpdate_b__0_Internal_Void_byref_AbilityGroupSlot_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr);
        ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (prefabLookupMap));
        ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (serverTime));
        ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_spellModCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (spellModCollection));
        ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr, 100670416);
        ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__NewUpdate_b__0_Internal_Void_byref_AbilityGroupSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr, 100670417);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass5_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass5_0>.NativeClassPtr, data));
      }

      public unsafe ValidateAbilityGroupsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ValidateAbilityGroupsSystem) null : new ValidateAbilityGroupsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe SyncRegistry_Server<SpellModSet> spellModCollection
      {
        get
        {
          return *(SyncRegistry_Server<SpellModSet>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_spellModCollection));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_spellModCollection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SyncRegistry_Server<SpellModSet>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.ValidateAbilityGroupsSystem/ProjectM.Gameplay.<>c__DisplayClass_NewUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_NewUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_spellModCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityGroupSlot_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ValidateAbilityGroupsSystem_byref___c__DisplayClass5_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1428115, RefRangeEnd = 1428116, XrefRangeStart = 1427926, XrefRangeEnd = 1428115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref AbilityGroupSlot groupSlot)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref groupSlot;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityGroupSlot_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428116, XrefRangeEnd = 1428117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ValidateAbilityGroupsSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1428118, RefRangeEnd = 1428119, XrefRangeStart = 1428117, XrefRangeEnd = 1428118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ValidateAbilityGroupsSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428119, XrefRangeEnd = 1428132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1428138, RefRangeEnd = 1428139, XrefRangeStart = 1428132, XrefRangeEnd = 1428138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1428140, RefRangeEnd = 1428141, XrefRangeStart = 1428139, XrefRangeEnd = 1428140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ValidateAbilityGroupsSystem componentSystem,
        ref ValidateAbilityGroupsSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ValidateAbilityGroupsSystem_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_NewUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidateAbilityGroupsSystem>.NativeClassPtr, "<>c__DisplayClass_NewUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr);
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, "<>4__this");
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, nameof (prefabLookupMap));
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, nameof (serverTime));
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_spellModCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, nameof (spellModCollection));
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityGroupSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, 100670418);
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, 100670419);
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, 100670420);
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, 100670422);
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, 100670423);
        ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ValidateAbilityGroupsSystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, 100670424);
      }

      public __c__DisplayClass_NewUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_NewUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ValidateAbilityGroupsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ValidateAbilityGroupsSystem) null : new ValidateAbilityGroupsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe SyncRegistry_Server<SpellModSet> spellModCollection
      {
        get
        {
          return *(SyncRegistry_Server<SpellModSet>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_spellModCollection));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr_spellModCollection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SyncRegistry_Server<SpellModSet>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_groupSlot;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ValidateAbilityGroupsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityGroupSlot> forParameter_groupSlot;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427918, XrefRangeEnd = 1427921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ValidateAbilityGroupsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ValidateAbilityGroupsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1427925, RefRangeEnd = 1427926, XrefRangeStart = 1427921, XrefRangeEnd = 1427925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_groupSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_groupSlot));
          ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ValidateAbilityGroupsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100670425);
          ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100670426);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_groupSlot;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<AbilityGroupSlot>.StructuralChangeRuntime runtime_groupSlot;

          static Runtimes()
          {
            Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_groupSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_groupSlot));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidateAbilityGroupsSystem.__c__DisplayClass_NewUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
