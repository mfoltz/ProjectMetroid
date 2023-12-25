// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.KillAndDisableInactivePlayerAfterDuration
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
  public class KillAndDisableInactivePlayerAfterDuration : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesToDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesToDisable;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__StartSimulationGroupBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_22;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableEntity_Private_Static_Void_Entity_EntityManager_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451723, XrefRangeEnd = 1451737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451737, XrefRangeEnd = 1451742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451742, XrefRangeEnd = 1451812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1451874, RefRangeEnd = 1451875, XrefRangeStart = 1451812, XrefRangeEnd = 1451874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DisableEntity(
      Entity entity,
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_DisableEntity_Private_Static_Void_Entity_EntityManager_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KillAndDisableInactivePlayerAfterDuration()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451875, XrefRangeEnd = 1451900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1451928, RefRangeEnd = 1451929, XrefRangeStart = 1451900, XrefRangeEnd = 1451928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1451933, RefRangeEnd = 1451934, XrefRangeStart = 1451929, XrefRangeEnd = 1451933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KillAndDisableInactivePlayerAfterDuration()
    {
      Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (KillAndDisableInactivePlayerAfterDuration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr);
      KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__EntitiesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, nameof (_EntitiesToDestroy));
      KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__EntitiesToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, nameof (_EntitiesToDisable));
      KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, nameof (_Query));
      KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__StartSimulationGroupBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, nameof (_StartSimulationGroupBarrier));
      KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_22));
      KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, 100672794);
      KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, 100672795);
      KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, 100672796);
      KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_DisableEntity_Private_Static_Void_Entity_EntityManager_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, 100672797);
      KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, 100672798);
      KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, 100672799);
      KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, 100672800);
      KillAndDisableInactivePlayerAfterDuration.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, 100672801);
    }

    public KillAndDisableInactivePlayerAfterDuration(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<Entity> _EntitiesToDestroy
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__EntitiesToDestroy));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__EntitiesToDestroy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _EntitiesToDisable
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__EntitiesToDisable));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__EntitiesToDisable), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe StartSimulationGroupBarrier _StartSimulationGroupBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__StartSimulationGroupBarrier));
        return pointer == System.IntPtr.Zero ? (StartSimulationGroupBarrier) null : new StartSimulationGroupBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__StartSimulationGroupBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_22
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_22));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillAndDisableInactivePlayerAfterDuration.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_22)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.KillAndDisableInactivePlayerAfterDuration/<>c__DisplayClass6_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass6_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_disableDisconnectedDeadEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_disableDisconnectedDeadTimer;
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToDisable;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillTimerMaxItemLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillTimeMin;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillTimeMax;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillSafeTimeAddition;
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToDestroy;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DisconnectedTimer_byref_User_byref_Controller_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(4)]
      public bool disableDisconnectedDeadEnabled;
      [FieldOffset(8)]
      public EntityManager entityManager;
      [FieldOffset(16)]
      public double serverTime;
      [FieldOffset(24)]
      public int disableDisconnectedDeadTimer;
      [FieldOffset(32)]
      public NativeList<Entity> entitiesToDisable;
      [FieldOffset(48)]
      public bool inactivityKillEnabled;
      [FieldOffset(52)]
      public float inactivityKillTimerMaxItemLevel;
      [FieldOffset(56)]
      public int inactivityKillTimeMin;
      [FieldOffset(60)]
      public int inactivityKillTimeMax;
      [FieldOffset(64)]
      public int inactivityKillSafeTimeAddition;
      [FieldOffset(72)]
      public NativeList<Entity> entitiesToDestroy;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        ref DisconnectedTimer disconnectedTimer,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref disconnectedTimer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DisconnectedTimer_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (deltaTime));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_disableDisconnectedDeadEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (disableDisconnectedDeadEnabled));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (entityManager));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (serverTime));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_disableDisconnectedDeadTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (disableDisconnectedDeadTimer));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_entitiesToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (entitiesToDisable));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_inactivityKillEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (inactivityKillEnabled));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_inactivityKillTimerMaxItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (inactivityKillTimerMaxItemLevel));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_inactivityKillTimeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (inactivityKillTimeMin));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_inactivityKillTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (inactivityKillTimeMax));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_inactivityKillSafeTimeAddition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (inactivityKillSafeTimeAddition));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeFieldInfoPtr_entitiesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, nameof (entitiesToDestroy));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, 100672802);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DisconnectedTimer_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, 100672803);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.KillAndDisableInactivePlayerAfterDuration/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_disableDisconnectedDeadEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_disableDisconnectedDeadTimer;
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToDisable;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillTimerMaxItemLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillTimeMin;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillTimeMax;
      private static readonly System.IntPtr NativeFieldInfoPtr_inactivityKillSafeTimeAddition;
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToDestroy;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DisconnectedTimer_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillAndDisableInactivePlayerAfterDuration_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(4)]
      public bool disableDisconnectedDeadEnabled;
      [FieldOffset(8)]
      public EntityManager entityManager;
      [FieldOffset(16)]
      public double serverTime;
      [FieldOffset(24)]
      public int disableDisconnectedDeadTimer;
      [FieldOffset(32)]
      public NativeList<Entity> entitiesToDisable;
      [FieldOffset(48)]
      public bool inactivityKillEnabled;
      [FieldOffset(52)]
      public float inactivityKillTimerMaxItemLevel;
      [FieldOffset(56)]
      public int inactivityKillTimeMin;
      [FieldOffset(60)]
      public int inactivityKillTimeMax;
      [FieldOffset(64)]
      public int inactivityKillSafeTimeAddition;
      [FieldOffset(72)]
      public NativeList<Entity> entitiesToDestroy;
      [FieldOffset(88)]
      public KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(184)]
      public unsafe KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451645, XrefRangeEnd = 1451694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DisconnectedTimer disconnectedTimer,
        [In] ref User user,
        [In] ref Controller controller)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref disconnectedTimer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DisconnectedTimer_byref_User_byref_Controller_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1451694, RefRangeEnd = 1451695, XrefRangeStart = 1451694, XrefRangeEnd = 1451694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1451695, RefRangeEnd = 1451696, XrefRangeStart = 1451695, XrefRangeEnd = 1451695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451696, XrefRangeEnd = 1451698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1451709, RefRangeEnd = 1451710, XrefRangeStart = 1451698, XrefRangeEnd = 1451709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1451712, RefRangeEnd = 1451713, XrefRangeStart = 1451710, XrefRangeEnd = 1451712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        KillAndDisableInactivePlayerAfterDuration componentSystem,
        ref KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillAndDisableInactivePlayerAfterDuration_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451713, XrefRangeEnd = 1451717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451717, XrefRangeEnd = 1451723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (deltaTime));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_disableDisconnectedDeadEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (disableDisconnectedDeadEnabled));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (serverTime));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_disableDisconnectedDeadTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (disableDisconnectedDeadTimer));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entitiesToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entitiesToDisable));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inactivityKillEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inactivityKillEnabled));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inactivityKillTimerMaxItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inactivityKillTimerMaxItemLevel));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inactivityKillTimeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inactivityKillTimeMin));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inactivityKillTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inactivityKillTimeMax));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inactivityKillSafeTimeAddition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inactivityKillSafeTimeAddition));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entitiesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entitiesToDestroy));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DisconnectedTimer_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672804);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672805);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672806);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672807);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672808);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillAndDisableInactivePlayerAfterDuration_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672809);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672810);
        KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672811);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_disconnectedTimer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillAndDisableInactivePlayerAfterDuration_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<DisconnectedTimer> forParameter_disconnectedTimer;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1451559, RefRangeEnd = 1451560, XrefRangeStart = 1451550, XrefRangeEnd = 1451559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          KillAndDisableInactivePlayerAfterDuration componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillAndDisableInactivePlayerAfterDuration_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1451569, RefRangeEnd = 1451570, XrefRangeStart = 1451560, XrefRangeEnd = 1451569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_disconnectedTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_disconnectedTimer));
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillAndDisableInactivePlayerAfterDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100672812);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100672813);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_disconnectedTimer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<DisconnectedTimer>.Runtime runtime_disconnectedTimer;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_disconnectedTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_disconnectedTimer));
            KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.KillAndDisableInactivePlayerAfterDuration/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016CE$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000016CE$PostfixBurstDelegate");
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672814);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672815);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672816);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672817);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.KillAndDisableInactivePlayerAfterDuration/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016CE$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451570, XrefRangeEnd = 1451584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451584, XrefRangeEnd = 1451602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451602, XrefRangeEnd = 1451617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1451644, RefRangeEnd = 1451645, XrefRangeStart = 1451617, XrefRangeEnd = 1451644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000016CE$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672818);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672819);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672820);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672821);
          KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672823);
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
            IL2CPP.il2cpp_field_static_get_value(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(KillAndDisableInactivePlayerAfterDuration.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
