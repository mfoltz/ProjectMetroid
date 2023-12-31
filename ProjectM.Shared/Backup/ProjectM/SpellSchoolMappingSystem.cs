// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellSchoolMappingSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class SpellSchoolMappingSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterPrefabQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellSchoolAbilityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilitiesQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729109, XrefRangeEnd = 729144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellSchoolMappingSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729144, XrefRangeEnd = 729167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellSchoolMappingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellSchoolMappingSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729167, XrefRangeEnd = 729187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellSchoolMappingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729187, XrefRangeEnd = 729203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellSchoolMappingSystem()
    {
      Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpellSchoolMappingSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr);
      SpellSchoolMappingSystem.NativeFieldInfoPtr__RegisterPrefabQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, nameof (_RegisterPrefabQuery));
      SpellSchoolMappingSystem.NativeFieldInfoPtr__SpellSchoolAbilityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, nameof (_SpellSchoolAbilityQuery));
      SpellSchoolMappingSystem.NativeFieldInfoPtr__AbilitiesQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, nameof (_AbilitiesQuery));
      SpellSchoolMappingSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      SpellSchoolMappingSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      SpellSchoolMappingSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, 100664553);
      SpellSchoolMappingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, 100664554);
      SpellSchoolMappingSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, 100664555);
      SpellSchoolMappingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, 100664556);
      SpellSchoolMappingSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, 100664557);
    }

    public SpellSchoolMappingSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _RegisterPrefabQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr__RegisterPrefabQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr__RegisterPrefabQuery)) = value;
      }
    }

    public unsafe EntityQuery _SpellSchoolAbilityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr__SpellSchoolAbilityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr__SpellSchoolAbilityQuery)) = value;
      }
    }

    public unsafe EntityQuery _AbilitiesQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr__AbilitiesQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr__AbilitiesQuery)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolMappingSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.SpellSchoolMappingSystem/<>c__DisplayClass4_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass4_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_spellSchools;
      private static readonly System.IntPtr NativeFieldInfoPtr_abilitiesId;
      private static readonly System.IntPtr NativeFieldInfoPtr_abilityEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RegisterPrefab_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeArray<Entity> spellSchools;
      [FieldOffset(24)]
      public NativeArray<PrefabGUID> abilitiesId;
      [FieldOffset(40)]
      public NativeArray<Entity> abilityEntities;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref RegisterPrefab registerEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RegisterPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr);
        SpellSchoolMappingSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (entityManager));
        SpellSchoolMappingSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_spellSchools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (spellSchools));
        SpellSchoolMappingSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_abilitiesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (abilitiesId));
        SpellSchoolMappingSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_abilityEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (abilityEntities));
        SpellSchoolMappingSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr, 100664558);
        SpellSchoolMappingSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr, 100664559);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass4_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SpellSchoolMappingSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_spellSchools;
      private static readonly System.IntPtr NativeFieldInfoPtr_abilitiesId;
      private static readonly System.IntPtr NativeFieldInfoPtr_abilityEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpellSchoolMappingSystem_byref___c__DisplayClass4_0_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeArray<Entity> spellSchools;
      [FieldOffset(24)]
      public NativeArray<PrefabGUID> abilitiesId;
      [FieldOffset(40)]
      public NativeArray<Entity> abilityEntities;
      [FieldOffset(56)]
      public SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 729088, RefRangeEnd = 729089, XrefRangeStart = 729046, XrefRangeEnd = 729088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref RegisterPrefab registerEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SpellSchoolMappingSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 729089, RefRangeEnd = 729090, XrefRangeStart = 729089, XrefRangeEnd = 729089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SpellSchoolMappingSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729090, XrefRangeEnd = 729101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 729107, RefRangeEnd = 729108, XrefRangeStart = 729101, XrefRangeEnd = 729107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 729108, RefRangeEnd = 729109, XrefRangeStart = 729108, XrefRangeEnd = 729108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SpellSchoolMappingSystem componentSystem,
        ref SpellSchoolMappingSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpellSchoolMappingSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellSchoolMappingSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_spellSchools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (spellSchools));
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_abilitiesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (abilitiesId));
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_abilityEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (abilityEntities));
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664560);
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664561);
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664562);
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664564);
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664565);
        SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpellSchoolMappingSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664566);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpellSchoolMappingSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefab> forParameter_registerEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729038, XrefRangeEnd = 729041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SpellSchoolMappingSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpellSchoolMappingSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 729045, RefRangeEnd = 729046, XrefRangeStart = 729041, XrefRangeEnd = 729045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpellSchoolMappingSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664567);
          SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664568);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefab>.StructuralChangeRuntime runtime_registerEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellSchoolMappingSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
