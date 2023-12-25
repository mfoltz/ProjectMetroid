// Decompiled with JetBrains decompiler
// Type: ProjectM.InitializeNewSpawnChainSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class InitializeNewSpawnChainSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequiredPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr___InitializeNewSpawnChains_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InitializeNewSpawnChains_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeNewSpawnChains_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertOnDemand_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForInitializeNewSpawnChains_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069483, XrefRangeEnd = 1069495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InitializeNewSpawnChainSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069495, XrefRangeEnd = 1069501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InitializeNewSpawnChainSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069501, XrefRangeEnd = 1069502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InitializeNewSpawnChainSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1069542, RefRangeEnd = 1069543, XrefRangeStart = 1069502, XrefRangeEnd = 1069542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeNewSpawnChains()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.NativeMethodInfoPtr_InitializeNewSpawnChains_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertOnDemand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.NativeMethodInfoPtr_ConvertOnDemand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InitializeNewSpawnChainSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069543, XrefRangeEnd = 1069561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InitializeNewSpawnChainSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1069592, RefRangeEnd = 1069593, XrefRangeStart = 1069561, XrefRangeEnd = 1069592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForInitializeNewSpawnChains_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.NativeMethodInfoPtr___GetEntityQuery_ForInitializeNewSpawnChains_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1069597, RefRangeEnd = 1069598, XrefRangeStart = 1069593, XrefRangeEnd = 1069597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InitializeNewSpawnChainSystem()
    {
      Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InitializeNewSpawnChainSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr);
      InitializeNewSpawnChainSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      InitializeNewSpawnChainSystem.NativeFieldInfoPtr__RequiredPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, nameof (_RequiredPrefabs));
      InitializeNewSpawnChainSystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, nameof (_ServerTime));
      InitializeNewSpawnChainSystem.NativeFieldInfoPtr___InitializeNewSpawnChains_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, "<>InitializeNewSpawnChains_entityQuery");
      InitializeNewSpawnChainSystem.NativeFieldInfoPtr___InitializeNewSpawnChains_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, "<>InitializeNewSpawnChains_profilerMarker");
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684189);
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684190);
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684191);
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr_InitializeNewSpawnChains_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684192);
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr_ConvertOnDemand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684193);
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684194);
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684195);
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr___GetEntityQuery_ForInitializeNewSpawnChains_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684196);
      InitializeNewSpawnChainSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, 100684197);
    }

    public InitializeNewSpawnChainSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<PrefabGUID> _RequiredPrefabs
    {
      get
      {
        return *(NativeList<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr__RequiredPrefabs));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr__RequiredPrefabs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __InitializeNewSpawnChains_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr___InitializeNewSpawnChains_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr___InitializeNewSpawnChains_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __InitializeNewSpawnChains_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr___InitializeNewSpawnChains_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.NativeFieldInfoPtr___InitializeNewSpawnChains_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.InitializeNewSpawnChainSystem/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverElapsedSeconds;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_transitionDatas;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__InitializeNewSpawnChains_b__0_Internal_Void_Entity_byref_ActiveChildElement_byref_Translation_byref_Rotation_byref_PrefabGUID_byref_SpawnChainConstants_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _InitializeNewSpawnChains_b__0(
        Entity entity,
        ref SpawnChainData.ActiveChildElement activeChainElement,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref PrefabGUID prefabGUID,
        [In] ref SpawnChainData.SpawnChainConstants chainConstants)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeChainElement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref chainConstants;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__InitializeNewSpawnChains_b__0_Internal_Void_Entity_byref_ActiveChildElement_byref_Translation_byref_Rotation_byref_PrefabGUID_byref_SpawnChainConstants_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr);
        InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (prefabLookupMap));
        InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
        InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_serverElapsedSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (serverElapsedSeconds));
        InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_transitionDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (transitionDatas));
        InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, 100684198);
        InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__InitializeNewSpawnChains_b__0_Internal_Void_Entity_byref_ActiveChildElement_byref_Translation_byref_Rotation_byref_PrefabGUID_byref_SpawnChainConstants_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, 100684199);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass6_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass6_0>.NativeClassPtr, data));
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe InitializeNewSpawnChainSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InitializeNewSpawnChainSystem) null : new InitializeNewSpawnChainSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double serverElapsedSeconds
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_serverElapsedSeconds));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_serverElapsedSeconds)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }

      public unsafe SpawnChainTransitionSystem.TransitionDatas transitionDatas
      {
        get
        {
          return *(SpawnChainTransitionSystem.TransitionDatas*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_transitionDatas));
        }
        [param: In] set
        {
          *(SpawnChainTransitionSystem.TransitionDatas*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeNewSpawnChainSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_transitionDatas)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.InitializeNewSpawnChainSystem/ProjectM.<>c__DisplayClass_InitializeNewSpawnChains")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_InitializeNewSpawnChains
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverElapsedSeconds;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_transitionDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AutoChainInstanceData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ActiveChildElement_byref_Translation_byref_Rotation_byref_PrefabGUID_byref_SpawnChainConstants_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InitializeNewSpawnChainSystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(48)]
      public double serverElapsedSeconds;
      [FieldOffset(56)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(72)]
      public SpawnChainTransitionSystem.TransitionDatas transitionDatas;
      [FieldOffset(208)]
      public ComponentDataFromEntity<AutoChainInstanceData> _ComponentDataFromEntity_AutoChainInstanceData_0;
      [FieldOffset(240)]
      public InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(408)]
      public unsafe InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069419, XrefRangeEnd = 1069444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref SpawnChainData.ActiveChildElement activeChainElement,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref PrefabGUID prefabGUID,
        [In] ref SpawnChainData.SpawnChainConstants chainConstants)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeChainElement;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref chainConstants;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ActiveChildElement_byref_Translation_byref_Rotation_byref_PrefabGUID_byref_SpawnChainConstants_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069444, RefRangeEnd = 1069445, XrefRangeStart = 1069444, XrefRangeEnd = 1069444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InitializeNewSpawnChainSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069445, RefRangeEnd = 1069446, XrefRangeStart = 1069445, XrefRangeEnd = 1069445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InitializeNewSpawnChainSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069446, XrefRangeEnd = 1069448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069466, RefRangeEnd = 1069467, XrefRangeStart = 1069448, XrefRangeEnd = 1069466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069472, RefRangeEnd = 1069473, XrefRangeStart = 1069467, XrefRangeEnd = 1069472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InitializeNewSpawnChainSystem componentSystem,
        ref InitializeNewSpawnChainSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InitializeNewSpawnChainSystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069473, XrefRangeEnd = 1069477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069477, XrefRangeEnd = 1069483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_InitializeNewSpawnChains()
      {
        Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeNewSpawnChainSystem>.NativeClassPtr, "<>c__DisplayClass_InitializeNewSpawnChains");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr);
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (prefabLookupMap));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_serverElapsedSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (serverElapsedSeconds));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (spawnCommandBuffer));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_transitionDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (transitionDatas));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr__ComponentDataFromEntity_AutoChainInstanceData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (_ComponentDataFromEntity_AutoChainInstanceData_0));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (_runtimes));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ActiveChildElement_byref_Translation_byref_Rotation_byref_PrefabGUID_byref_SpawnChainConstants_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, 100684200);
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, 100684201);
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, 100684202);
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, 100684203);
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, 100684204);
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InitializeNewSpawnChainSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, 100684205);
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, 100684206);
        InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, 100684207);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeChainElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chainConstants;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InitializeNewSpawnChainSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainData.ActiveChildElement> forParameter_activeChainElement;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;
        [FieldOffset(136)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainData.SpawnChainConstants> forParameter_chainConstants;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069326, RefRangeEnd = 1069327, XrefRangeStart = 1069310, XrefRangeEnd = 1069326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(InitializeNewSpawnChainSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InitializeNewSpawnChainSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069343, RefRangeEnd = 1069344, XrefRangeStart = 1069327, XrefRangeEnd = 1069343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeChainElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeChainElement));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chainConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chainConstants));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InitializeNewSpawnChainSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, 100684208);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, 100684209);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeChainElement;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chainConstants;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainData.ActiveChildElement>.Runtime runtime_activeChainElement;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainData.SpawnChainConstants>.Runtime runtime_chainConstants;

          static Runtimes()
          {
            Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeChainElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeChainElement));
            InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
            InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chainConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chainConstants));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.InitializeNewSpawnChainSystem/ProjectM.<>c__DisplayClass_InitializeNewSpawnChains/ProjectM.RunWithoutJobSystem_000049A9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, "RunWithoutJobSystem_000049A9$PostfixBurstDelegate");
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684210);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684211);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684212);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684213);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.InitializeNewSpawnChainSystem/ProjectM.<>c__DisplayClass_InitializeNewSpawnChains/ProjectM.RunWithoutJobSystem_000049A9$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069344, XrefRangeEnd = 1069358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069358, XrefRangeEnd = 1069376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069376, XrefRangeEnd = 1069391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069418, RefRangeEnd = 1069419, XrefRangeStart = 1069391, XrefRangeEnd = 1069418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains>.NativeClassPtr, "RunWithoutJobSystem_000049A9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684214);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684215);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684216);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684217);
          InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684219);
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
            IL2CPP.il2cpp_field_static_get_value(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(InitializeNewSpawnChainSystem.__c__DisplayClass_InitializeNewSpawnChains.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
