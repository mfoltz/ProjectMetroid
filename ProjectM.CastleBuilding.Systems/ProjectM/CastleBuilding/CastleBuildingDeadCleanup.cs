// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingDeadCleanup
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleBuildingDeadCleanup : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanupCastleBuildingOnDeath_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanupCastleBuildingOnDeath_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingOnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194939, XrefRangeEnd = 1194953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingDeadCleanup.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194953, XrefRangeEnd = 1194954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingDeadCleanup.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194954, XrefRangeEnd = 1194975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingDeadCleanup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuildingDeadCleanup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194975, XrefRangeEnd = 1195008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingDeadCleanup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195008, XrefRangeEnd = 1195024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCleanupCastleBuildingOnDeath_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingOnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195024, XrefRangeEnd = 1195028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuildingDeadCleanup()
    {
      Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingDeadCleanup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr);
      CastleBuildingDeadCleanup.NativeFieldInfoPtr_LogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, nameof (LogLevel));
      CastleBuildingDeadCleanup.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, nameof (_PlacementSystemData));
      CastleBuildingDeadCleanup.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, nameof (_SpawnBarrier));
      CastleBuildingDeadCleanup.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, nameof (_DestroyBarrier));
      CastleBuildingDeadCleanup.NativeFieldInfoPtr___CleanupCastleBuildingOnDeath_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, "<>CleanupCastleBuildingOnDeath_entityQuery");
      CastleBuildingDeadCleanup.NativeFieldInfoPtr___CleanupCastleBuildingOnDeath_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, "<>CleanupCastleBuildingOnDeath_profilerMarker");
      CastleBuildingDeadCleanup.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, 100663805);
      CastleBuildingDeadCleanup.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, 100663806);
      CastleBuildingDeadCleanup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, 100663807);
      CastleBuildingDeadCleanup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, 100663808);
      CastleBuildingDeadCleanup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, 100663809);
      CastleBuildingDeadCleanup.NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingOnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, 100663810);
      CastleBuildingDeadCleanup.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, 100663811);
    }

    public CastleBuildingDeadCleanup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe PlacementLogLevel LogLevel
    {
      get
      {
        PlacementLogLevel logLevel;
        IL2CPP.il2cpp_field_static_get_value(CastleBuildingDeadCleanup.NativeFieldInfoPtr_LogLevel, (void*) &logLevel);
        return logLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleBuildingDeadCleanup.NativeFieldInfoPtr_LogLevel, (void*) &value);
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __CleanupCastleBuildingOnDeath_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr___CleanupCastleBuildingOnDeath_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr___CleanupCastleBuildingOnDeath_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CleanupCastleBuildingOnDeath_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr___CleanupCastleBuildingOnDeath_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingDeadCleanup.NativeFieldInfoPtr___CleanupCastleBuildingOnDeath_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingDeadCleanup/<>c__DisplayClass6_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass6_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_placementJobParams;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public FullPlacementJobData placementJobParams;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref DeathEvent deathEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref deathEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass6_0>.NativeClassPtr);
        CastleBuildingDeadCleanup.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass6_0>.NativeClassPtr, nameof (entityManager));
        CastleBuildingDeadCleanup.__c__DisplayClass6_0.NativeFieldInfoPtr_placementJobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass6_0>.NativeClassPtr, nameof (placementJobParams));
        CastleBuildingDeadCleanup.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass6_0>.NativeClassPtr, 100663812);
        CastleBuildingDeadCleanup.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass6_0>.NativeClassPtr, 100663813);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass6_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingDeadCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingOnDeath")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CleanupCastleBuildingOnDeath
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_placementJobParams;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingDeadCleanup_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public FullPlacementJobData placementJobParams;
      [FieldOffset(3976)]
      public CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(4008)]
      public unsafe CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194901, XrefRangeEnd = 1194914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref DeathEvent deathEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref deathEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1194915, RefRangeEnd = 1194916, XrefRangeStart = 1194914, XrefRangeEnd = 1194915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleBuildingDeadCleanup.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1194917, RefRangeEnd = 1194918, XrefRangeStart = 1194916, XrefRangeEnd = 1194917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleBuildingDeadCleanup.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194918, XrefRangeEnd = 1194920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1194925, RefRangeEnd = 1194926, XrefRangeStart = 1194920, XrefRangeEnd = 1194925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1194928, RefRangeEnd = 1194929, XrefRangeStart = 1194926, XrefRangeEnd = 1194928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleBuildingDeadCleanup componentSystem,
        ref CastleBuildingDeadCleanup.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingDeadCleanup_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194929, XrefRangeEnd = 1194933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194933, XrefRangeEnd = 1194939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CleanupCastleBuildingOnDeath()
      {
        Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingDeadCleanup>.NativeClassPtr, "<>c__DisplayClass_CleanupCastleBuildingOnDeath");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr);
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, nameof (entityManager));
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr_placementJobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, nameof (placementJobParams));
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, nameof (_runtimes));
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, 100663814);
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, 100663815);
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, 100663816);
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, 100663817);
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, 100663818);
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingDeadCleanup_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, 100663819);
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, 100663820);
        CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, 100663821);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_deathEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingDeadCleanup_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<DeathEvent> forParameter_deathEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1194821, RefRangeEnd = 1194822, XrefRangeStart = 1194818, XrefRangeEnd = 1194821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleBuildingDeadCleanup componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingDeadCleanup_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1194825, RefRangeEnd = 1194826, XrefRangeStart = 1194822, XrefRangeEnd = 1194825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_deathEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_deathEvent));
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingDeadCleanup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders>.NativeClassPtr, 100663822);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders>.NativeClassPtr, 100663823);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_deathEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<DeathEvent>.Runtime runtime_deathEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_deathEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_deathEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingDeadCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingOnDeath/ProjectM.CastleBuilding.RunWithoutJobSystem_0000016F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, "RunWithoutJobSystem_0000016F$PostfixBurstDelegate");
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663824);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663825);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663826);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663827);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingDeadCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingOnDeath/ProjectM.CastleBuilding.RunWithoutJobSystem_0000016F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194826, XrefRangeEnd = 1194840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194840, XrefRangeEnd = 1194858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194858, XrefRangeEnd = 1194873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1194900, RefRangeEnd = 1194901, XrefRangeStart = 1194873, XrefRangeEnd = 1194900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath>.NativeClassPtr, "RunWithoutJobSystem_0000016F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663828);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663829);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663830);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663831);
          CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663833);
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
            IL2CPP.il2cpp_field_static_get_value(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleBuildingDeadCleanup.__c__DisplayClass_CleanupCastleBuildingOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
