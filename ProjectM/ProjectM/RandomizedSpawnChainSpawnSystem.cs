// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomizedSpawnChainSpawnSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class RandomizedSpawnChainSpawnSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkDataRemappingManager;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizedSpawnChain_SpawnJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizedSpawnChain_SpawnJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizedSpawnChains_HandleSpawnedChild_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizedSpawnChains_HandleSpawnedChild_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChain_SpawnJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChains_HandleSpawnedChild_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069856, XrefRangeEnd = 1069862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069862, XrefRangeEnd = 1069897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RandomizedSpawnChainSpawnSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069897, XrefRangeEnd = 1069949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1069974, RefRangeEnd = 1069975, XrefRangeStart = 1069949, XrefRangeEnd = 1069974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRandomizedSpawnChain_SpawnJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChain_SpawnJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069975, XrefRangeEnd = 1069994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRandomizedSpawnChains_HandleSpawnedChild_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChains_HandleSpawnedChild_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1069998, RefRangeEnd = 1069999, XrefRangeStart = 1069994, XrefRangeEnd = 1069998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1070003, RefRangeEnd = 1070004, XrefRangeStart = 1069999, XrefRangeEnd = 1070003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RandomizedSpawnChainSpawnSystem()
    {
      Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RandomizedSpawnChainSpawnSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr);
      RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr__ChunkDataRemappingManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, nameof (_ChunkDataRemappingManager));
      RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChain_SpawnJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, "<>RandomizedSpawnChain_SpawnJob_entityQuery");
      RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChain_SpawnJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, "<>RandomizedSpawnChain_SpawnJob_profilerMarker");
      RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChains_HandleSpawnedChild_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, "<>RandomizedSpawnChains_HandleSpawnedChild_entityQuery");
      RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChains_HandleSpawnedChild_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, "<>RandomizedSpawnChains_HandleSpawnedChild_profilerMarker");
      RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, 100684220);
      RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, 100684221);
      RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, 100684222);
      RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, 100684223);
      RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChain_SpawnJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, 100684224);
      RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChains_HandleSpawnedChild_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, 100684225);
      RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, 100684226);
      RandomizedSpawnChainSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, 100684227);
    }

    public RandomizedSpawnChainSpawnSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ChunkDataRemappingManager _ChunkDataRemappingManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr__ChunkDataRemappingManager));
        return pointer == System.IntPtr.Zero ? (ChunkDataRemappingManager) null : new ChunkDataRemappingManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr__ChunkDataRemappingManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __RandomizedSpawnChain_SpawnJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChain_SpawnJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChain_SpawnJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RandomizedSpawnChain_SpawnJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChain_SpawnJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChain_SpawnJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RandomizedSpawnChains_HandleSpawnedChild_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChains_HandleSpawnedChild_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChains_HandleSpawnedChild_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RandomizedSpawnChains_HandleSpawnedChild_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChains_HandleSpawnedChild_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.NativeFieldInfoPtr___RandomizedSpawnChains_HandleSpawnedChild_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.RandomizedSpawnChainSpawnSystem/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_settingReplacementLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RandomizedSpawnChain_byref_PrefabGUID_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RandomizedSpawnChainChild_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref RandomizedSpawnChain randomizedSpawnChain,
        [In] ref PrefabGUID prefabGuid,
        [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref randomizedSpawnChain;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RandomizedSpawnChain_byref_PrefabGUID_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, [In] ref RandomizedSpawnChainChild child)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref child;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RandomizedSpawnChainChild_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_settingReplacementLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (settingReplacementLookup));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (commandBuffer));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr, 100684228);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RandomizedSpawnChain_byref_PrefabGUID_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr, 100684229);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RandomizedSpawnChainChild_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr, 100684230);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe ChunkRemappingLookup<PrefabGUID> settingReplacementLookup
      {
        get
        {
          return *(ChunkRemappingLookup<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_settingReplacementLookup));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_settingReplacementLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChunkRemappingLookup<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe RandomizedSpawnChainSpawnSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RandomizedSpawnChainSpawnSystem) null : new RandomizedSpawnChainSpawnSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.RandomizedSpawnChainSpawnSystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChain_SpawnJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RandomizedSpawnChain_SpawnJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_settingReplacementLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RandomizedSpawnChain_byref_PrefabGUID_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ChunkRemappingLookup<PrefabGUID> settingReplacementLookup;
      [FieldOffset(16)]
      public RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069695, XrefRangeEnd = 1069699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref RandomizedSpawnChain randomizedSpawnChain,
        [In] ref PrefabGUID prefabGuid,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref randomizedSpawnChain;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RandomizedSpawnChain_byref_PrefabGUID_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069699, XrefRangeEnd = 1069701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069713, RefRangeEnd = 1069714, XrefRangeStart = 1069701, XrefRangeEnd = 1069713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069716, RefRangeEnd = 1069717, XrefRangeStart = 1069714, XrefRangeEnd = 1069716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RandomizedSpawnChainSpawnSystem componentSystem,
        ref RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069717, XrefRangeEnd = 1069721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069721, XrefRangeEnd = 1069727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RandomizedSpawnChain_SpawnJob()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_RandomizedSpawnChain_SpawnJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr_settingReplacementLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, nameof (settingReplacementLookup));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, nameof (_runtimes));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RandomizedSpawnChain_byref_PrefabGUID_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, 100684231);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, 100684232);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, 100684233);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, 100684234);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, 100684235);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, 100684236);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, 100684237);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, 100684238);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_randomizedSpawnChain;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<RandomizedSpawnChain> forParameter_randomizedSpawnChain;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGuid;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069608, RefRangeEnd = 1069609, XrefRangeStart = 1069598, XrefRangeEnd = 1069608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RandomizedSpawnChainSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069619, RefRangeEnd = 1069620, XrefRangeStart = 1069609, XrefRangeEnd = 1069619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_randomizedSpawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_randomizedSpawnChain));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGuid));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr, 100684239);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr, 100684240);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_randomizedSpawnChain;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGuid;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RandomizedSpawnChain>.Runtime runtime_randomizedSpawnChain;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGuid;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_randomizedSpawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_randomizedSpawnChain));
            RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGuid));
            RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.RandomizedSpawnChainSpawnSystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChain_SpawnJob/ProjectM.RunWithoutJobSystem_000049BB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, "RunWithoutJobSystem_000049BB$PostfixBurstDelegate");
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684241);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684242);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684243);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684244);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.RandomizedSpawnChainSpawnSystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChain_SpawnJob/ProjectM.RunWithoutJobSystem_000049BB$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069620, XrefRangeEnd = 1069634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069634, XrefRangeEnd = 1069652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069652, XrefRangeEnd = 1069667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069694, RefRangeEnd = 1069695, XrefRangeStart = 1069667, XrefRangeEnd = 1069694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob>.NativeClassPtr, "RunWithoutJobSystem_000049BB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684245);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684246);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684247);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684248);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684250);
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
            IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChain_SpawnJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.RandomizedSpawnChainSpawnSystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_DestroyTag_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_RandomizedSpawnChain_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RandomizedSpawnChainChild_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_0;
      [FieldOffset(48)]
      public ComponentDataFromEntity<DestroyTag> _ComponentDataFromEntity_DestroyTag_1;
      [FieldOffset(80)]
      public ComponentDataFromEntity<RandomizedSpawnChain> _ComponentDataFromEntity_RandomizedSpawnChain_2;
      [FieldOffset(112)]
      public RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(152)]
      public unsafe RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069812, XrefRangeEnd = 1069825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref RandomizedSpawnChainChild child)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref child;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RandomizedSpawnChainChild_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 999309, RefRangeEnd = 999314, XrefRangeStart = 999309, XrefRangeEnd = 999314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 999314, RefRangeEnd = 999318, XrefRangeStart = 999314, XrefRangeEnd = 999318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069825, XrefRangeEnd = 1069827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069833, RefRangeEnd = 1069834, XrefRangeStart = 1069827, XrefRangeEnd = 1069833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069845, RefRangeEnd = 1069846, XrefRangeStart = 1069834, XrefRangeEnd = 1069845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RandomizedSpawnChainSpawnSystem componentSystem,
        ref RandomizedSpawnChainSpawnSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069846, XrefRangeEnd = 1069850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069850, XrefRangeEnd = 1069856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (commandBuffer));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_0));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr__ComponentDataFromEntity_DestroyTag_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (_ComponentDataFromEntity_DestroyTag_1));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr__ComponentDataFromEntity_RandomizedSpawnChain_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (_ComponentDataFromEntity_RandomizedSpawnChain_2));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (_runtimes));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RandomizedSpawnChainChild_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, 100684251);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, 100684252);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, 100684253);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, 100684254);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, 100684255);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, 100684256);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, 100684257);
        RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, 100684258);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_child;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<RandomizedSpawnChainChild> forParameter_child;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069731, RefRangeEnd = 1069732, XrefRangeStart = 1069727, XrefRangeEnd = 1069731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RandomizedSpawnChainSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069736, RefRangeEnd = 1069737, XrefRangeStart = 1069732, XrefRangeEnd = 1069736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_child = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_child));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders>.NativeClassPtr, 100684259);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders>.NativeClassPtr, 100684260);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_child;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RandomizedSpawnChainChild>.Runtime runtime_child;

          static Runtimes()
          {
            Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_child = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_child));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.RandomizedSpawnChainSpawnSystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild/ProjectM.RunWithoutJobSystem_000049C4$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, "RunWithoutJobSystem_000049C4$PostfixBurstDelegate");
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684261);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684262);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684263);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684264);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.RandomizedSpawnChainSpawnSystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild/ProjectM.RunWithoutJobSystem_000049C4$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069737, XrefRangeEnd = 1069751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069751, XrefRangeEnd = 1069769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069769, XrefRangeEnd = 1069784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069811, RefRangeEnd = 1069812, XrefRangeStart = 1069784, XrefRangeEnd = 1069811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild>.NativeClassPtr, "RunWithoutJobSystem_000049C4$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684265);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684266);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684267);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684268);
          RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684270);
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
            IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainSpawnSystem.__c__DisplayClass_RandomizedSpawnChains_HandleSpawnedChild.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
