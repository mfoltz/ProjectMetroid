// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.OnDeathSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class OnDeathSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerBalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__JewelSpawnSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModTierCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__YieldEssenceOnDeathEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlaySequenceOnDeathEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__CreateDropTableItemsOnDeaths;
    private static readonly System.IntPtr NativeFieldInfoPtr__DropInventoryOnDeathEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleWallsEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDeath_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DropInventoryJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_23;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCastleHeathSiege_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnnounceCastleBreaches_Private_Void_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_YieldEssenceOnDeath_Private_Void_EntityCommandBuffer_PrefabCollectionSystem_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlaySequenceOnDeath_Private_Void_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDropTableItemsOnDeath_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DropInventoryOnDeath_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452625, XrefRangeEnd = 1452679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OnDeathSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452679, XrefRangeEnd = 1452691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OnDeathSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452691, XrefRangeEnd = 1452754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OnDeathSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1452784, RefRangeEnd = 1452785, XrefRangeStart = 1452754, XrefRangeEnd = 1452784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetCastleHeathSiege()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_SetCastleHeathSiege_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1452844, RefRangeEnd = 1452845, XrefRangeStart = 1452785, XrefRangeEnd = 1452844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AnnounceCastleBreaches(EntityCommandBuffer postUpdateCommandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &postUpdateCommandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_AnnounceCastleBreaches_Private_Void_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1452893, RefRangeEnd = 1452894, XrefRangeStart = 1452845, XrefRangeEnd = 1452893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void YieldEssenceOnDeath(
      EntityCommandBuffer spawnCommandBuffer,
      PrefabCollectionSystem prefabCollectionSystem,
      Entity sctPrefab,
      float modifier)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sctPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_YieldEssenceOnDeath_Private_Void_EntityCommandBuffer_PrefabCollectionSystem_Entity_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1452931, RefRangeEnd = 1452932, XrefRangeStart = 1452894, XrefRangeEnd = 1452931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlaySequenceOnDeath(EntityCommandBuffer spawnCommandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &spawnCommandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_PlaySequenceOnDeath_Private_Void_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1452972, RefRangeEnd = 1452973, XrefRangeStart = 1452932, XrefRangeEnd = 1452972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDropTableItemsOnDeath()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_CreateDropTableItemsOnDeath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1453078, RefRangeEnd = 1453079, XrefRangeStart = 1452973, XrefRangeEnd = 1453078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DropInventoryOnDeath()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_DropInventoryOnDeath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnDeathSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1453079, XrefRangeEnd = 1453150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OnDeathSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1453150, XrefRangeEnd = 1453166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1453170, RefRangeEnd = 1453171, XrefRangeStart = 1453166, XrefRangeEnd = 1453170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1453175, RefRangeEnd = 1453176, XrefRangeStart = 1453171, XrefRangeEnd = 1453175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1453180, RefRangeEnd = 1453181, XrefRangeStart = 1453176, XrefRangeEnd = 1453180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OnDeathSystem()
    {
      Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (OnDeathSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr);
      OnDeathSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      OnDeathSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      OnDeathSystem.NativeFieldInfoPtr__ServerBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_ServerBalanceSettings));
      OnDeathSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      OnDeathSystem.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_BalanceSettings));
      OnDeathSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_GameDataSystem));
      OnDeathSystem.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_CurveCollectionSystem));
      OnDeathSystem.NativeFieldInfoPtr__JewelSpawnSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_JewelSpawnSystem));
      OnDeathSystem.NativeFieldInfoPtr__SpellModTierCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_SpellModTierCollectionSystem));
      OnDeathSystem.NativeFieldInfoPtr__YieldEssenceOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_YieldEssenceOnDeathEntities));
      OnDeathSystem.NativeFieldInfoPtr__PlaySequenceOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_PlaySequenceOnDeathEntities));
      OnDeathSystem.NativeFieldInfoPtr__CreateDropTableItemsOnDeaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_CreateDropTableItemsOnDeaths));
      OnDeathSystem.NativeFieldInfoPtr__DropInventoryOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_DropInventoryOnDeathEntities));
      OnDeathSystem.NativeFieldInfoPtr__CastleWallsEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_CastleWallsEntities));
      OnDeathSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_Query));
      OnDeathSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      OnDeathSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      OnDeathSystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDeath_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>CreateDropTableItemsJob_DropOnDeath_profilerMarker");
      OnDeathSystem.NativeFieldInfoPtr___DropInventoryJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>DropInventoryJob_profilerMarker");
      OnDeathSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_RelicDropped_23));
      OnDeathSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672824);
      OnDeathSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672825);
      OnDeathSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672826);
      OnDeathSystem.NativeMethodInfoPtr_SetCastleHeathSiege_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672827);
      OnDeathSystem.NativeMethodInfoPtr_AnnounceCastleBreaches_Private_Void_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672828);
      OnDeathSystem.NativeMethodInfoPtr_YieldEssenceOnDeath_Private_Void_EntityCommandBuffer_PrefabCollectionSystem_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672829);
      OnDeathSystem.NativeMethodInfoPtr_PlaySequenceOnDeath_Private_Void_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672830);
      OnDeathSystem.NativeMethodInfoPtr_CreateDropTableItemsOnDeath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672831);
      OnDeathSystem.NativeMethodInfoPtr_DropInventoryOnDeath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672832);
      OnDeathSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672833);
      OnDeathSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672834);
      OnDeathSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672835);
      OnDeathSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672836);
      OnDeathSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672837);
      OnDeathSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, 100672838);
    }

    public OnDeathSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerBalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__ServerBalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__ServerBalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JewelSpawnSystem _JewelSpawnSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__JewelSpawnSystem));
        return pointer == System.IntPtr.Zero ? (JewelSpawnSystem) null : new JewelSpawnSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__JewelSpawnSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModTierCollectionSystem _SpellModTierCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__SpellModTierCollectionSystem));
        return pointer == System.IntPtr.Zero ? (SpellModTierCollectionSystem) null : new SpellModTierCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__SpellModTierCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<Entity> _YieldEssenceOnDeathEntities
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__YieldEssenceOnDeathEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__YieldEssenceOnDeathEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _PlaySequenceOnDeathEntities
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__PlaySequenceOnDeathEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__PlaySequenceOnDeathEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<OnDeathSystem.DropOnDeathData> _CreateDropTableItemsOnDeaths
    {
      get
      {
        return *(NativeList<OnDeathSystem.DropOnDeathData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__CreateDropTableItemsOnDeaths));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__CreateDropTableItemsOnDeaths), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<OnDeathSystem.DropOnDeathData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _DropInventoryOnDeathEntities
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__DropInventoryOnDeathEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__DropInventoryOnDeathEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _CastleWallsEntities
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__CastleWallsEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__CastleWallsEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateDropTableItemsJob_DropOnDeath_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDeath_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr___CreateDropTableItemsJob_DropOnDeath_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __DropInventoryJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr___DropInventoryJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr___DropInventoryJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_RelicDropped_23
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_23));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.NativeFieldInfoPtr__SingletonEntityQuery_RelicDropped_23)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DropOnDeathData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeathSourceOwner;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public Entity DeathSourceOwner;

      static DropOnDeathData()
      {
        Il2CppClassPointerStore<OnDeathSystem.DropOnDeathData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (DropOnDeathData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.DropOnDeathData>.NativeClassPtr);
        OnDeathSystem.DropOnDeathData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropOnDeathData>.NativeClassPtr, nameof (Entity));
        OnDeathSystem.DropOnDeathData.NativeFieldInfoPtr_DeathSourceOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropOnDeathData>.NativeClassPtr, nameof (DeathSourceOwner));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.DropOnDeathData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DropInventoryJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GetInventoryBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetEquipment;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetServantEquipment;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDurability;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCanFly;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBuffableFlagState;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPlayerCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetFeedableInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetControlledBy;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetItemRepairCostBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetInventoryOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTravelBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetJumpFromCliffsTravelBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetShatteredItem;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeathPvPTimerBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ContainerPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayerContainerPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServantContainerPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTeamReference;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetUserOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr_DurabilityLossFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_DurabilityLossResourceFactor;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_Entity_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DrainDurability_Private_Void_Entity_byref_NativeList_1_InventoryBuffer_0;
      [FieldOffset(0)]
      public BufferFromEntity<InventoryBuffer> GetInventoryBuffer;
      [FieldOffset(40)]
      public ComponentDataFromEntity<Equipment> GetEquipment;
      [FieldOffset(72)]
      public ComponentDataFromEntity<ServantEquipment> GetServantEquipment;
      [FieldOffset(104)]
      public ComponentDataFromEntity<Durability> GetDurability;
      [FieldOffset(136)]
      public ComponentDataFromEntity<CanFly> GetCanFly;
      [FieldOffset(168)]
      public ComponentDataFromEntity<BuffableFlagState> GetBuffableFlagState;
      [FieldOffset(200)]
      public ComponentDataFromEntity<PlayerCharacter> GetPlayerCharacter;
      [FieldOffset(232)]
      public ComponentDataFromEntity<FeedableInventory> GetFeedableInventory;
      [FieldOffset(264)]
      public ComponentDataFromEntity<ControlledBy> GetControlledBy;
      [FieldOffset(296)]
      public BufferFromEntity<AttachedBuffer> GetAttachedBuffer;
      [FieldOffset(336)]
      public BufferFromEntity<ItemRepairBuffer> GetItemRepairCostBuffer;
      [FieldOffset(376)]
      public BufferFromEntity<InventoryInstanceElement> GetInventoryOwner;
      [FieldOffset(416)]
      public ComponentDataFromEntity<Buff> GetBuff;
      [FieldOffset(448)]
      public ComponentDataFromEntity<TravelBuff> GetTravelBuff;
      [FieldOffset(480)]
      public ComponentDataFromEntity<JumpFromCliffsTravelBuff> GetJumpFromCliffsTravelBuff;
      [FieldOffset(512)]
      public ComponentDataFromEntity<ShatteredItem> GetShatteredItem;
      [FieldOffset(544)]
      public NativeArray<Buff> DeathPvPTimerBuffs;
      [FieldOffset(560)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(576)]
      public Entity ContainerPrefab;
      [FieldOffset(584)]
      public Entity PlayerContainerPrefab;
      [FieldOffset(592)]
      public Entity ServantContainerPrefab;
      [FieldOffset(600)]
      public NativeHashMap<PrefabGUID, ItemData> ItemLookupMap;
      [FieldOffset(616)]
      public PrefabLookupMap PrefabLookupMap;
      [FieldOffset(664)]
      public ComponentDataFromEntity<TeamReference> GetTeamReference;
      [FieldOffset(696)]
      public ComponentDataFromEntity<UserOwner> GetUserOwner;
      [FieldOffset(728)]
      public float DurabilityLossFactor;
      [FieldOffset(732)]
      public float DurabilityLossResourceFactor;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452153, RefRangeEnd = 1452154, XrefRangeStart = 1451934, XrefRangeEnd = 1452153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(Entity entity, [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.DropInventoryJob.NativeMethodInfoPtr_Execute_Public_Void_Entity_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1452195, RefRangeEnd = 1452197, XrefRangeStart = 1452154, XrefRangeEnd = 1452195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void DrainDurability(
        Entity entity,
        ref NativeList<InventoryBuffer> droppedDurabilityItems)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref droppedDurabilityItems;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.DropInventoryJob.NativeMethodInfoPtr_DrainDurability_Private_Void_Entity_byref_NativeList_1_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DropInventoryJob()
      {
        Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, nameof (DropInventoryJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr);
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetInventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetInventoryBuffer));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetEquipment));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetServantEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetServantEquipment));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetDurability));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetCanFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetCanFly));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetBuffableFlagState));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetPlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetPlayerCharacter));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetFeedableInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetFeedableInventory));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetControlledBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetControlledBy));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetAttachedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetAttachedBuffer));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetItemRepairCostBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetItemRepairCostBuffer));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetInventoryOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetInventoryOwner));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetBuff));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetTravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetTravelBuff));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetJumpFromCliffsTravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetJumpFromCliffsTravelBuff));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetShatteredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetShatteredItem));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_DeathPvPTimerBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (DeathPvPTimerBuffs));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (CommandBuffer));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_ContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (ContainerPrefab));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_PlayerContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (PlayerContainerPrefab));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_ServantContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (ServantContainerPrefab));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_ItemLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (ItemLookupMap));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (PrefabLookupMap));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetTeamReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetTeamReference));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_GetUserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (GetUserOwner));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_DurabilityLossFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (DurabilityLossFactor));
        OnDeathSystem.DropInventoryJob.NativeFieldInfoPtr_DurabilityLossResourceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, nameof (DurabilityLossResourceFactor));
        OnDeathSystem.DropInventoryJob.NativeMethodInfoPtr_Execute_Public_Void_Entity_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, 100672839);
        OnDeathSystem.DropInventoryJob.NativeMethodInfoPtr_DrainDurability_Private_Void_Entity_byref_NativeList_1_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, 100672840);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.DropInventoryJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public enum EntityType
      {
        Player,
        Servant,
        Other,
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/<>c__DisplayClass18_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass18_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_yieldEssenceOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_playSequenceOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropInventoryOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleWallsEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<Entity> yieldEssenceOnDeathEntities;
      [FieldOffset(24)]
      public NativeList<Entity> playSequenceOnDeathEntities;
      [FieldOffset(40)]
      public NativeList<OnDeathSystem.DropOnDeathData> createDropTableItemsOnDeathEntities;
      [FieldOffset(56)]
      public NativeList<Entity> dropInventoryOnDeathEntities;
      [FieldOffset(72)]
      public NativeList<Entity> castleWallsEntities;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass18_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref DeathEvent deathEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref deathEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass18_0()
      {
        Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>c__DisplayClass18_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr);
        OnDeathSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (entityManager));
        OnDeathSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_yieldEssenceOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (yieldEssenceOnDeathEntities));
        OnDeathSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_playSequenceOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (playSequenceOnDeathEntities));
        OnDeathSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_createDropTableItemsOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (createDropTableItemsOnDeathEntities));
        OnDeathSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_dropInventoryOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (dropInventoryOnDeathEntities));
        OnDeathSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_castleWallsEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (castleWallsEntities));
        OnDeathSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, 100672841);
        OnDeathSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, 100672842);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass18_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/<>c__DisplayClass23_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass23_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsOnDeaths;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_relicsDroppedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverGameSettings;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CreateDropTableItemsOnDeath_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public NativeList<OnDeathSystem.DropOnDeathData> createDropTableItemsOnDeaths;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public CreateDropTableItemsJob createDropTableItemsJob;
      [FieldOffset(328)]
      public DynamicBuffer<RelicDropped> relicsDroppedBuffer;
      [FieldOffset(344)]
      public ServerGameBalanceSettings serverGameSettings;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass23_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _CreateDropTableItemsOnDeath_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__CreateDropTableItemsOnDeath_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass23_0()
      {
        Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>c__DisplayClass23_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr);
        OnDeathSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_createDropTableItemsOnDeaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (createDropTableItemsOnDeaths));
        OnDeathSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (entityManager));
        OnDeathSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_createDropTableItemsJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (createDropTableItemsJob));
        OnDeathSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_relicsDroppedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (relicsDroppedBuffer));
        OnDeathSystem.__c__DisplayClass23_0.NativeFieldInfoPtr_serverGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr, nameof (serverGameSettings));
        OnDeathSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr, 100672843);
        OnDeathSystem.__c__DisplayClass23_0.NativeMethodInfoPtr__CreateDropTableItemsOnDeath_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr, 100672844);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass23_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/<>c__DisplayClass24_0")]
    public sealed class __c__DisplayClass24_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_job;
      private static readonly System.IntPtr NativeFieldInfoPtr_deathTimerArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropInventoryOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DropInventoryOnDeath_b__0_Internal_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass24_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _DropInventoryOnDeath_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__DropInventoryOnDeath_b__0_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass24_0()
      {
        Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>c__DisplayClass24_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr);
        OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (job));
        OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_deathTimerArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (deathTimerArray));
        OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_dropInventoryOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (dropInventoryOnDeathEntities));
        OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
        OnDeathSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr, 100672845);
        OnDeathSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__DropInventoryOnDeath_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr, 100672846);
      }

      public __c__DisplayClass24_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass24_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass24_0>.NativeClassPtr, data));
      }

      public unsafe OnDeathSystem.DropInventoryJob job
      {
        get
        {
          return *(OnDeathSystem.DropInventoryJob*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_job));
        }
        [param: In] set
        {
          *(OnDeathSystem.DropInventoryJob*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_job)) = value;
        }
      }

      public unsafe NativeArray<Buff> deathTimerArray
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_deathTimerArray));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_deathTimerArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> dropInventoryOnDeathEntities
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_dropInventoryOnDeathEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_dropInventoryOnDeathEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe OnDeathSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (OnDeathSystem) null : new OnDeathSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnDeathSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_yieldEssenceOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_playSequenceOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropInventoryOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleWallsEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<Entity> yieldEssenceOnDeathEntities;
      [FieldOffset(24)]
      public NativeList<Entity> playSequenceOnDeathEntities;
      [FieldOffset(40)]
      public NativeList<OnDeathSystem.DropOnDeathData> createDropTableItemsOnDeathEntities;
      [FieldOffset(56)]
      public NativeList<Entity> dropInventoryOnDeathEntities;
      [FieldOffset(72)]
      public NativeList<Entity> castleWallsEntities;
      [FieldOffset(88)]
      public OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452280, XrefRangeEnd = 1452318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref DeathEvent deathEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref deathEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452318, RefRangeEnd = 1452319, XrefRangeStart = 1452318, XrefRangeEnd = 1452318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref OnDeathSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452319, RefRangeEnd = 1452320, XrefRangeStart = 1452319, XrefRangeEnd = 1452319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref OnDeathSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452320, XrefRangeEnd = 1452322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452327, RefRangeEnd = 1452328, XrefRangeStart = 1452322, XrefRangeEnd = 1452327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452330, RefRangeEnd = 1452331, XrefRangeStart = 1452328, XrefRangeEnd = 1452330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        OnDeathSystem componentSystem,
        ref OnDeathSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452331, XrefRangeEnd = 1452335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452335, XrefRangeEnd = 1452341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_yieldEssenceOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (yieldEssenceOnDeathEntities));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_playSequenceOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (playSequenceOnDeathEntities));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_createDropTableItemsOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (createDropTableItemsOnDeathEntities));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_dropInventoryOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (dropInventoryOnDeathEntities));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_castleWallsEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (castleWallsEntities));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672847);
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672848);
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672849);
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672850);
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672851);
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672852);
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672853);
        OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100672854);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_deathEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<DeathEvent> forParameter_deathEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1452200, RefRangeEnd = 1452201, XrefRangeStart = 1452197, XrefRangeEnd = 1452200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(OnDeathSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1452204, RefRangeEnd = 1452205, XrefRangeStart = 1452201, XrefRangeEnd = 1452204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_deathEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_deathEvent));
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100672855);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100672856);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_deathEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<DeathEvent>.Runtime runtime_deathEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_deathEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_deathEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016EB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000016EB$PostfixBurstDelegate");
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672857);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672858);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672859);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672860);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016EB$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452205, XrefRangeEnd = 1452219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452219, XrefRangeEnd = 1452237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452237, XrefRangeEnd = 1452252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1452279, RefRangeEnd = 1452280, XrefRangeStart = 1452252, XrefRangeEnd = 1452279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000016EB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672861);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672862);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672863);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672864);
          OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672866);
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
            IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateDropTableItemsJob_DropOnDeath")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateDropTableItemsJob_DropOnDeath
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsOnDeaths;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_createDropTableItemsJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_relicsDroppedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverGameSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass23_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeList<OnDeathSystem.DropOnDeathData> createDropTableItemsOnDeaths;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public CreateDropTableItemsJob createDropTableItemsJob;
      [FieldOffset(328)]
      public DynamicBuffer<RelicDropped> relicsDroppedBuffer;
      [FieldOffset(344)]
      public ServerGameBalanceSettings serverGameSettings;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452416, XrefRangeEnd = 1452462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452463, RefRangeEnd = 1452464, XrefRangeStart = 1452462, XrefRangeEnd = 1452463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref OnDeathSystem.__c__DisplayClass23_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452465, RefRangeEnd = 1452466, XrefRangeStart = 1452464, XrefRangeEnd = 1452465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref OnDeathSystem.__c__DisplayClass23_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452467, RefRangeEnd = 1452468, XrefRangeStart = 1452466, XrefRangeEnd = 1452467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452469, RefRangeEnd = 1452470, XrefRangeStart = 1452468, XrefRangeEnd = 1452469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        OnDeathSystem componentSystem,
        ref OnDeathSystem.__c__DisplayClass23_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass23_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452470, XrefRangeEnd = 1452474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452481, RefRangeEnd = 1452482, XrefRangeStart = 1452474, XrefRangeEnd = 1452481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateDropTableItemsJob_DropOnDeath()
      {
        Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>c__DisplayClass_CreateDropTableItemsJob_DropOnDeath");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr);
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_createDropTableItemsOnDeaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, nameof (createDropTableItemsOnDeaths));
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, nameof (entityManager));
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_createDropTableItemsJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, nameof (createDropTableItemsJob));
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_relicsDroppedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, nameof (relicsDroppedBuffer));
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_serverGameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, nameof (serverGameSettings));
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, 100672867);
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, 100672868);
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, 100672869);
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, 100672870);
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass23_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, 100672871);
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, 100672872);
        OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, 100672873);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateDropTableItemsJob_DropOnDeath/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016F3$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, "RunWithoutJobSystem_000016F3$PostfixBurstDelegate");
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672874);
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672875);
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672876);
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672877);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateDropTableItemsJob_DropOnDeath/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016F3$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452341, XrefRangeEnd = 1452355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452355, XrefRangeEnd = 1452373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452373, XrefRangeEnd = 1452388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1452415, RefRangeEnd = 1452416, XrefRangeStart = 1452388, XrefRangeEnd = 1452415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath>.NativeClassPtr, "RunWithoutJobSystem_000016F3$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672878);
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672879);
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672880);
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672881);
          OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672883);
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
            IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_CreateDropTableItemsJob_DropOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_DropInventoryJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DropInventoryJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_job;
      private static readonly System.IntPtr NativeFieldInfoPtr_deathTimerArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropInventoryOnDeathEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public OnDeathSystem.DropInventoryJob job;
      [FieldOffset(736)]
      public NativeArray<Buff> deathTimerArray;
      [FieldOffset(752)]
      public NativeList<Entity> dropInventoryOnDeathEntities;
      [FieldOffset(768)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452557, XrefRangeEnd = 1452569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452569, RefRangeEnd = 1452570, XrefRangeStart = 1452569, XrefRangeEnd = 1452569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref OnDeathSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452570, RefRangeEnd = 1452571, XrefRangeStart = 1452570, XrefRangeEnd = 1452570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref OnDeathSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452572, RefRangeEnd = 1452573, XrefRangeStart = 1452571, XrefRangeEnd = 1452572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452577, RefRangeEnd = 1452578, XrefRangeStart = 1452573, XrefRangeEnd = 1452577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        OnDeathSystem componentSystem,
        ref OnDeathSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452578, XrefRangeEnd = 1452582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1452624, RefRangeEnd = 1452625, XrefRangeStart = 1452582, XrefRangeEnd = 1452624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DropInventoryJob()
      {
        Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem>.NativeClassPtr, "<>c__DisplayClass_DropInventoryJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr);
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (job));
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_deathTimerArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (deathTimerArray));
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_dropInventoryOnDeathEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (dropInventoryOnDeathEntities));
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100672884);
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100672885);
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100672886);
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100672887);
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_OnDeathSystem_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100672888);
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100672889);
        OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, 100672890);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_DropInventoryJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_DropInventoryJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016F9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, "RunWithoutJobSystem_000016F9$PostfixBurstDelegate");
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672891);
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672892);
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672893);
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100672894);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.OnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_DropInventoryJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016F9$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452482, XrefRangeEnd = 1452496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452496, XrefRangeEnd = 1452514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1452514, XrefRangeEnd = 1452529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1452556, RefRangeEnd = 1452557, XrefRangeStart = 1452529, XrefRangeEnd = 1452556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob>.NativeClassPtr, "RunWithoutJobSystem_000016F9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672895);
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672896);
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672897);
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672898);
          OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672900);
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
            IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(OnDeathSystem.__c__DisplayClass_DropInventoryJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
