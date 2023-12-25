// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityCastStarted_SetupAbilityTargetSystem_Shared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

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
  public class AbilityCastStarted_SetupAbilityTargetSystem_Shared : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupAbilityTarget_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupAbilityTarget_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanBeTargetedByAbilities_Private_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetupAbilityTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361891, XrefRangeEnd = 1361908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361908, XrefRangeEnd = 1361945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1361948, RefRangeEnd = 1361950, XrefRangeStart = 1361945, XrefRangeEnd = 1361948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanBeTargetedByAbilities(
      EntityManager entityManager,
      Entity interactorTarget)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &interactorTarget;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_CanBeTargetedByAbilities_Private_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityCastStarted_SetupAbilityTargetSystem_Shared()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361950, XrefRangeEnd = 1361983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361983, XrefRangeEnd = 1361999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetupAbilityTarget_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForSetupAbilityTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361999, XrefRangeEnd = 1362003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityCastStarted_SetupAbilityTargetSystem_Shared()
    {
      Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityCastStarted_SetupAbilityTargetSystem_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr);
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, nameof (_Query));
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr__BuffsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, nameof (_BuffsQuery));
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr___SetupAbilityTarget_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, "<>SetupAbilityTarget_entityQuery");
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr___SetupAbilityTarget_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, "<>SetupAbilityTarget_profilerMarker");
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, 100663499);
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, 100663500);
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_CanBeTargetedByAbilities_Private_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, 100663501);
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, 100663502);
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, 100663503);
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForSetupAbilityTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, 100663504);
      AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, 100663505);
    }

    public AbilityCastStarted_SetupAbilityTargetSystem_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _BuffsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr__BuffsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr__BuffsQuery)) = value;
      }
    }

    public unsafe EntityQuery __SetupAbilityTarget_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr___SetupAbilityTarget_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr___SetupAbilityTarget_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetupAbilityTarget_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr___SetupAbilityTarget_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityCastStarted_SetupAbilityTargetSystem_Shared.NativeFieldInfoPtr___SetupAbilityTarget_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AbilityCastStarted_SetupAbilityTargetSystem_Shared/<>c__DisplayClass3_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass3_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffGuids;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeArray<EntityOwner> buffOwners;
      [FieldOffset(24)]
      public NativeArray<PrefabGUID> buffGuids;
      [FieldOffset(40)]
      public NativeArray<Buff> buffs;
      [FieldOffset(56)]
      public NativeArray<Entity> buffEntities;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr, nameof (entityManager));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeFieldInfoPtr_buffOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr, nameof (buffOwners));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeFieldInfoPtr_buffGuids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr, nameof (buffGuids));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr, nameof (buffs));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeFieldInfoPtr_buffEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr, nameof (buffEntities));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr, 100663506);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr, 100663507);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AbilityCastStarted_SetupAbilityTargetSystem_Shared/ProjectM.<>c__DisplayClass_SetupAbilityTarget")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetupAbilityTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffOwners;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffGuids;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityCastStarted_SetupAbilityTargetSystem_Shared_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeArray<EntityOwner> buffOwners;
      [FieldOffset(24)]
      public NativeArray<PrefabGUID> buffGuids;
      [FieldOffset(40)]
      public NativeArray<Buff> buffs;
      [FieldOffset(56)]
      public NativeArray<Entity> buffEntities;
      [FieldOffset(72)]
      public AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361841, XrefRangeEnd = 1361868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1361868, RefRangeEnd = 1361869, XrefRangeStart = 1361868, XrefRangeEnd = 1361868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1361869, RefRangeEnd = 1361870, XrefRangeStart = 1361869, XrefRangeEnd = 1361869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361870, XrefRangeEnd = 1361872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1361877, RefRangeEnd = 1361878, XrefRangeStart = 1361872, XrefRangeEnd = 1361877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1361880, RefRangeEnd = 1361881, XrefRangeStart = 1361878, XrefRangeEnd = 1361880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityCastStarted_SetupAbilityTargetSystem_Shared componentSystem,
        ref AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityCastStarted_SetupAbilityTargetSystem_Shared_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361881, XrefRangeEnd = 1361885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361885, XrefRangeEnd = 1361891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetupAbilityTarget()
      {
        Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_SetupAbilityTarget");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (entityManager));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_buffOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (buffOwners));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_buffGuids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (buffGuids));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (buffs));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_buffEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (buffEntities));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (_runtimes));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, 100663508);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, 100663509);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, 100663510);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, 100663511);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, 100663512);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityCastStarted_SetupAbilityTargetSystem_Shared_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, 100663513);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, 100663514);
        AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, 100663515);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castStartedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityCastStarted_SetupAbilityTargetSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent> forParameter_castStartedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1361761, RefRangeEnd = 1361762, XrefRangeStart = 1361758, XrefRangeEnd = 1361761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityCastStarted_SetupAbilityTargetSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityCastStarted_SetupAbilityTargetSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1361765, RefRangeEnd = 1361766, XrefRangeStart = 1361762, XrefRangeEnd = 1361765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castStartedEvent));
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityCastStarted_SetupAbilityTargetSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders>.NativeClassPtr, 100663516);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders>.NativeClassPtr, 100663517);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castStartedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent>.Runtime runtime_castStartedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castStartedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityCastStarted_SetupAbilityTargetSystem_Shared/ProjectM.<>c__DisplayClass_SetupAbilityTarget/ProjectM.RunWithoutJobSystem_00000079$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, "RunWithoutJobSystem_00000079$PostfixBurstDelegate");
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663518);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663519);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663520);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663521);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityCastStarted_SetupAbilityTargetSystem_Shared/ProjectM.<>c__DisplayClass_SetupAbilityTarget/ProjectM.RunWithoutJobSystem_00000079$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361766, XrefRangeEnd = 1361780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361780, XrefRangeEnd = 1361798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361798, XrefRangeEnd = 1361813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1361840, RefRangeEnd = 1361841, XrefRangeStart = 1361813, XrefRangeEnd = 1361840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget>.NativeClassPtr, "RunWithoutJobSystem_00000079$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663522);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663523);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663524);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663525);
          AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663527);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityCastStarted_SetupAbilityTargetSystem_Shared.__c__DisplayClass_SetupAbilityTarget.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
