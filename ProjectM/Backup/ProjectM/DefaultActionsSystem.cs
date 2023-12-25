// Decompiled with JetBrains decompiler
// Type: ProjectM.DefaultActionsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

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
namespace ProjectM
{
  public class DefaultActionsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr___EnterDefaultActionsJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___EnterDefaultActionsJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForEnterDefaultActionsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024204, XrefRangeEnd = 1024220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultActionsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultActionsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024220, XrefRangeEnd = 1024254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultActionsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DefaultActionsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024254, XrefRangeEnd = 1024277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultActionsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024277, XrefRangeEnd = 1024296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForEnterDefaultActionsJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.NativeMethodInfoPtr___GetEntityQuery_ForEnterDefaultActionsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DefaultActionsSystem()
    {
      Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DefaultActionsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr);
      DefaultActionsSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, nameof (_Query));
      DefaultActionsSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      DefaultActionsSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      DefaultActionsSystem.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      DefaultActionsSystem.NativeFieldInfoPtr___EnterDefaultActionsJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, "<>EnterDefaultActionsJob_entityQuery");
      DefaultActionsSystem.NativeFieldInfoPtr___EnterDefaultActionsJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, "<>EnterDefaultActionsJob_profilerMarker");
      DefaultActionsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, 100679978);
      DefaultActionsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, 100679979);
      DefaultActionsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, 100679980);
      DefaultActionsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, 100679981);
      DefaultActionsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, 100679982);
      DefaultActionsSystem.NativeMethodInfoPtr___GetEntityQuery_ForEnterDefaultActionsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, 100679983);
    }

    public DefaultActionsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __EnterDefaultActionsJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr___EnterDefaultActionsJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr___EnterDefaultActionsJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __EnterDefaultActionsJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr___EnterDefaultActionsJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.NativeFieldInfoPtr___EnterDefaultActionsJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.DefaultActionsSystem/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_errorSctType;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_UseDefaultActionEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref UseDefaultActionEvent defaultAction,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref defaultAction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_UseDefaultActionEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr);
        DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
        DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (gameDataSystem));
        DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (prefabCollectionSystem));
        DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (conditionChecker));
        DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_sctPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (sctPrefab));
        DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_errorSctType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (errorSctType));
        DefaultActionsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, 100679984);
        DefaultActionsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_UseDefaultActionEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, 100679985);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass6_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass6_0>.NativeClassPtr, data));
      }

      public unsafe DefaultActionsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DefaultActionsSystem) null : new DefaultActionsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ConditionChecker conditionChecker
      {
        get
        {
          return *(ConditionChecker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conditionChecker));
        }
        [param: In] set
        {
          *(ConditionChecker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conditionChecker)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe Entity sctPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_sctPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_sctPrefab)) = value;
        }
      }

      public unsafe PrefabGUID errorSctType
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_errorSctType));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_errorSctType)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DefaultActionsSystem/ProjectM.<>c__DisplayClass_EnterDefaultActionsJob")]
    public sealed class __c__DisplayClass_EnterDefaultActionsJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_errorSctType;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UseDefaultActionEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DefaultActionsSystem_byref___c__DisplayClass6_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1024167, RefRangeEnd = 1024168, XrefRangeStart = 1024074, XrefRangeEnd = 1024167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref UseDefaultActionEvent defaultAction,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref defaultAction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UseDefaultActionEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1024172, RefRangeEnd = 1024174, XrefRangeStart = 1024168, XrefRangeEnd = 1024172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DefaultActionsSystem.__c__DisplayClass6_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1024178, RefRangeEnd = 1024180, XrefRangeStart = 1024174, XrefRangeEnd = 1024178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DefaultActionsSystem.__c__DisplayClass6_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024180, XrefRangeEnd = 1024194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1024200, RefRangeEnd = 1024201, XrefRangeStart = 1024194, XrefRangeEnd = 1024200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1024202, RefRangeEnd = 1024204, XrefRangeStart = 1024201, XrefRangeEnd = 1024202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DefaultActionsSystem componentSystem,
        ref DefaultActionsSystem.__c__DisplayClass6_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DefaultActionsSystem_byref___c__DisplayClass6_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_EnterDefaultActionsJob()
      {
        Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultActionsSystem>.NativeClassPtr, "<>c__DisplayClass_EnterDefaultActionsJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr);
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, "<>4__this");
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (gameDataSystem));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_prefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (prefabCollectionSystem));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (conditionChecker));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (spawnCommandBuffer));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_sctPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (sctPrefab));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_errorSctType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (errorSctType));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (_runtimes));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UseDefaultActionEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, 100679986);
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, 100679987);
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, 100679988);
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, 100679990);
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, 100679991);
        DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DefaultActionsSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, 100679992);
      }

      public __c__DisplayClass_EnterDefaultActionsJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_EnterDefaultActionsJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, data));
      }

      public unsafe DefaultActionsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DefaultActionsSystem) null : new DefaultActionsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabCollectionSystem prefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_prefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_prefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ConditionChecker conditionChecker
      {
        get
        {
          return *(ConditionChecker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_conditionChecker));
        }
        [param: In] set
        {
          *(ConditionChecker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_conditionChecker)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe Entity sctPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_sctPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_sctPrefab)) = value;
        }
      }

      public unsafe PrefabGUID errorSctType
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_errorSctType));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr_errorSctType)) = value;
        }
      }

      public unsafe DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_defaultAction;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DefaultActionsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UseDefaultActionEvent> forParameter_defaultAction;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024058, XrefRangeEnd = 1024065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DefaultActionsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DefaultActionsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1024073, RefRangeEnd = 1024074, XrefRangeStart = 1024065, XrefRangeEnd = 1024073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_defaultAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_defaultAction));
          DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DefaultActionsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679993);
          DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679994);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_defaultAction;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<UseDefaultActionEvent>.StructuralChangeRuntime runtime_defaultAction;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_defaultAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_defaultAction));
            DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefaultActionsSystem.__c__DisplayClass_EnterDefaultActionsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
