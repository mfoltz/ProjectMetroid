// Decompiled with JetBrains decompiler
// Type: ProjectM.InteractWithPrisonerSystem
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
namespace ProjectM
{
  public class InteractWithPrisonerSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr___InteractWithPrisonerJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InteractWithPrisonerJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateCanCharm_Private_AssetGuid_Entity_byref_PrisonCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForInteractWithPrisonerJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411328, XrefRangeEnd = 1411344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractWithPrisonerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411344, XrefRangeEnd = 1411368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractWithPrisonerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411368, XrefRangeEnd = 1411377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetGuid ValidateCanCharm(Entity source, [In] ref PrisonCell prisonCell)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prisonCell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.NativeMethodInfoPtr_ValidateCanCharm_Private_AssetGuid_Entity_byref_PrisonCell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InteractWithPrisonerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411377, XrefRangeEnd = 1411400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractWithPrisonerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411400, XrefRangeEnd = 1411419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForInteractWithPrisonerJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.NativeMethodInfoPtr___GetEntityQuery_ForInteractWithPrisonerJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InteractWithPrisonerSystem()
    {
      Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (InteractWithPrisonerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr);
      InteractWithPrisonerSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      InteractWithPrisonerSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, nameof (_EventQuery));
      InteractWithPrisonerSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      InteractWithPrisonerSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      InteractWithPrisonerSystem.NativeFieldInfoPtr___InteractWithPrisonerJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, "<>InteractWithPrisonerJob_entityQuery");
      InteractWithPrisonerSystem.NativeFieldInfoPtr___InteractWithPrisonerJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, "<>InteractWithPrisonerJob_profilerMarker");
      InteractWithPrisonerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, 100668680);
      InteractWithPrisonerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, 100668681);
      InteractWithPrisonerSystem.NativeMethodInfoPtr_ValidateCanCharm_Private_AssetGuid_Entity_byref_PrisonCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, 100668682);
      InteractWithPrisonerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, 100668683);
      InteractWithPrisonerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, 100668684);
      InteractWithPrisonerSystem.NativeMethodInfoPtr___GetEntityQuery_ForInteractWithPrisonerJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, 100668685);
    }

    public InteractWithPrisonerSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __InteractWithPrisonerJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr___InteractWithPrisonerJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr___InteractWithPrisonerJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __InteractWithPrisonerJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr___InteractWithPrisonerJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.NativeFieldInfoPtr___InteractWithPrisonerJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.InteractWithPrisonerSystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverBootstrapSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctPrefabEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractWithPrisonerEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref InteractWithPrisonerEvent interact,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interact;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractWithPrisonerEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr);
        InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (prefabLookupMap));
        InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (serverBootstrapSystem));
        InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_sctPrefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (sctPrefabEntity));
        InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, 100668686);
        InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractWithPrisonerEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, 100668687);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass5_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass5_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe InteractWithPrisonerSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractWithPrisonerSystem) null : new InteractWithPrisonerSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe ServerBootstrapSystem serverBootstrapSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverBootstrapSystem));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_serverBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe Entity sctPrefabEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_sctPrefabEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_sctPrefabEntity)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.InteractWithPrisonerSystem/ProjectM.<>c__DisplayClass_InteractWithPrisonerJob")]
    public sealed class __c__DisplayClass_InteractWithPrisonerJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverBootstrapSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_sctPrefabEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractWithPrisonerEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractWithPrisonerSystem_byref___c__DisplayClass5_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1411298, RefRangeEnd = 1411299, XrefRangeStart = 1411276, XrefRangeEnd = 1411298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref InteractWithPrisonerEvent interact,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interact;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractWithPrisonerEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411299, XrefRangeEnd = 1411301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InteractWithPrisonerSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1411303, RefRangeEnd = 1411304, XrefRangeStart = 1411301, XrefRangeEnd = 1411303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InteractWithPrisonerSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411304, XrefRangeEnd = 1411318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1411324, RefRangeEnd = 1411325, XrefRangeStart = 1411318, XrefRangeEnd = 1411324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1411327, RefRangeEnd = 1411328, XrefRangeStart = 1411325, XrefRangeEnd = 1411327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InteractWithPrisonerSystem componentSystem,
        ref InteractWithPrisonerSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractWithPrisonerSystem_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_InteractWithPrisonerJob()
      {
        Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractWithPrisonerSystem>.NativeClassPtr, "<>c__DisplayClass_InteractWithPrisonerJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr);
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, "<>4__this");
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (prefabLookupMap));
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_serverBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (serverBootstrapSystem));
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (spawnCommandBuffer));
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_sctPrefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (sctPrefabEntity));
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (_runtimes));
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractWithPrisonerEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, 100668688);
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, 100668689);
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, 100668690);
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, 100668692);
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, 100668693);
        InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractWithPrisonerSystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, 100668694);
      }

      public __c__DisplayClass_InteractWithPrisonerJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_InteractWithPrisonerJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe InteractWithPrisonerSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractWithPrisonerSystem) null : new InteractWithPrisonerSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe ServerBootstrapSystem serverBootstrapSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_serverBootstrapSystem));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_serverBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe Entity sctPrefabEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_sctPrefabEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr_sctPrefabEntity)) = value;
        }
      }

      public unsafe InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interact;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractWithPrisonerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<InteractWithPrisonerEvent> forParameter_interact;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411260, XrefRangeEnd = 1411267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(InteractWithPrisonerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractWithPrisonerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1411275, RefRangeEnd = 1411276, XrefRangeStart = 1411267, XrefRangeEnd = 1411275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interact));
          InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractWithPrisonerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders>.NativeClassPtr, 100668695);
          InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders>.NativeClassPtr, 100668696);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interact;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<InteractWithPrisonerEvent>.StructuralChangeRuntime runtime_interact;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interact));
            InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractWithPrisonerSystem.__c__DisplayClass_InteractWithPrisonerJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
