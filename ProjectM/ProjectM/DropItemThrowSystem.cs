// Decompiled with JetBrains decompiler
// Type: ProjectM.DropItemThrowSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class DropItemThrowSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hits;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropItemThrowsJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDropItemThrowsJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateDropItemThrowsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015095, XrefRangeEnd = 1015128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropItemThrowSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015128, XrefRangeEnd = 1015135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropItemThrowSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015135, XrefRangeEnd = 1015170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropItemThrowSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropItemThrowSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015170, XrefRangeEnd = 1015203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropItemThrowSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015203, XrefRangeEnd = 1015219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateDropItemThrowsJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDropItemThrowsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1015223, RefRangeEnd = 1015224, XrefRangeStart = 1015219, XrefRangeEnd = 1015223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DropItemThrowSystem()
    {
      Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropItemThrowSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr);
      DropItemThrowSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      DropItemThrowSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_GameDataSystem));
      DropItemThrowSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      DropItemThrowSystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_CollisionSystem));
      DropItemThrowSystem.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_TilePolygons));
      DropItemThrowSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      DropItemThrowSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_EventQuery));
      DropItemThrowSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      DropItemThrowSystem.NativeFieldInfoPtr__Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (_Hits));
      DropItemThrowSystem.NativeFieldInfoPtr___CreateDropItemThrowsJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, "<>CreateDropItemThrowsJob_entityQuery");
      DropItemThrowSystem.NativeFieldInfoPtr___CreateDropItemThrowsJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, "<>CreateDropItemThrowsJob_profilerMarker");
      DropItemThrowSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, 100679125);
      DropItemThrowSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, 100679126);
      DropItemThrowSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, 100679127);
      DropItemThrowSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, 100679128);
      DropItemThrowSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, 100679129);
      DropItemThrowSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDropItemThrowsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, 100679130);
      DropItemThrowSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, 100679131);
    }

    public DropItemThrowSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<DistanceHit> _Hits
    {
      get
      {
        return *(NativeList<DistanceHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__Hits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr__Hits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DistanceHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __CreateDropItemThrowsJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr___CreateDropItemThrowsJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr___CreateDropItemThrowsJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateDropItemThrowsJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr___CreateDropItemThrowsJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.NativeFieldInfoPtr___CreateDropItemThrowsJob_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DropItem
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
      [FieldOffset(0)]
      public Entity ItemEntity;
      [FieldOffset(8)]
      public PrefabGUID ItemType;
      [FieldOffset(12)]
      public int Amount;

      static DropItem()
      {
        Il2CppClassPointerStore<DropItemThrowSystem.DropItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, nameof (DropItem));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem.DropItem>.NativeClassPtr);
        DropItemThrowSystem.DropItem.NativeFieldInfoPtr_ItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.DropItem>.NativeClassPtr, nameof (ItemEntity));
        DropItemThrowSystem.DropItem.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.DropItem>.NativeClassPtr, nameof (ItemType));
        DropItemThrowSystem.DropItem.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.DropItem>.NativeClassPtr, nameof (Amount));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem.DropItem>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DropItemThrowSystem/<>c__DisplayClass12_0")]
    public sealed class __c__DisplayClass12_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dropsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropItemPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_hits;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionFilter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventoryInstances;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropItemAroundPosition_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref DropItemAroundPosition dropItem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropItem;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropItemAroundPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr);
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_dropsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (dropsDisabled));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_dropItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (dropItemPrefab));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_itemLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (itemLookupMap));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (prefabLookupMap));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (hits));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (collisionWorld));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (collisionFilter));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_getInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (getInventory));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_getInventoryInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (getInventoryInstances));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (random));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (tileWorld));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        DropItemThrowSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, 100679132);
        DropItemThrowSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropItemAroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, 100679133);
      }

      public __c__DisplayClass12_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass12_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass12_0>.NativeClassPtr, data));
      }

      public unsafe bool dropsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_dropsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_dropsDisabled)) = value;
        }
      }

      public unsafe Entity dropItemPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_dropItemPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_dropItemPrefab)) = value;
        }
      }

      public unsafe NativeHashMap<PrefabGUID, ItemData> itemLookupMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_itemLookupMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_itemLookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe NativeList<DistanceHit> hits
      {
        get
        {
          return *(NativeList<DistanceHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_hits));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_hits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DistanceHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }

      public unsafe CollisionFilter collisionFilter
      {
        get
        {
          return *(CollisionFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collisionFilter));
        }
        [param: In] set
        {
          *(CollisionFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_collisionFilter)) = value;
        }
      }

      public unsafe DropItemThrowSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DropItemThrowSystem) null : new DropItemThrowSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BufferFromEntity<InventoryBuffer> getInventory
      {
        get
        {
          return *(BufferFromEntity<InventoryBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_getInventory));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_getInventory), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<InventoryBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<InventoryInstanceElement> getInventoryInstances
      {
        get
        {
          return *(BufferFromEntity<InventoryInstanceElement>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_getInventoryInstances));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_getInventoryInstances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<InventoryInstanceElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Unity.Mathematics.Random random
      {
        get
        {
          return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_random));
        }
        [param: In] set
        {
          *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_random)) = value;
        }
      }

      public unsafe TileWorld tileWorld
      {
        get
        {
          return *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_tileWorld));
        }
        [param: In] set
        {
          *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_tileWorld)) = value;
        }
      }

      public unsafe EntityCommandBuffer spawnCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_spawnCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_spawnCommandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DropItemThrowSystem/ProjectM.<>c__DisplayClass_CreateDropItemThrowsJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateDropItemThrowsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dropsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropItemPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_hits;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionFilter;
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventory;
      private static readonly System.IntPtr NativeFieldInfoPtr_getInventoryInstances;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ItemPickup_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_DropItem_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SpellMovement_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropItemAroundPosition_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool dropsDisabled;
      [FieldOffset(4)]
      public Entity dropItemPrefab;
      [FieldOffset(16)]
      public NativeHashMap<PrefabGUID, ItemData> itemLookupMap;
      [FieldOffset(32)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(80)]
      public NativeList<DistanceHit> hits;
      [FieldOffset(96)]
      public CollisionWorld collisionWorld;
      [FieldOffset(440)]
      public CollisionFilter collisionFilter;
      [FieldOffset(456)]
      public BufferFromEntity<InventoryBuffer> getInventory;
      [FieldOffset(496)]
      public BufferFromEntity<InventoryInstanceElement> getInventoryInstances;
      [FieldOffset(536)]
      public Unity.Mathematics.Random random;
      [FieldOffset(544)]
      public TileWorld tileWorld;
      [FieldOffset(568)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(584)]
      public ComponentDataFromEntity<ItemPickup> _ComponentDataFromEntity_ItemPickup_0;
      [FieldOffset(616)]
      public ComponentDataFromEntity<DropItemThrowSystem.DropItem> _ComponentDataFromEntity_DropItem_1;
      [FieldOffset(648)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_2;
      [FieldOffset(680)]
      public ComponentDataFromEntity<SpellMovement> _ComponentDataFromEntity_SpellMovement_3;
      [FieldOffset(712)]
      public DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(752)]
      public unsafe DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014974, XrefRangeEnd = 1015059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref DropItemAroundPosition dropItem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropItem;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropItemAroundPosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015059, RefRangeEnd = 1015060, XrefRangeStart = 1015059, XrefRangeEnd = 1015059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DropItemThrowSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015060, RefRangeEnd = 1015061, XrefRangeStart = 1015060, XrefRangeEnd = 1015060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DropItemThrowSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015061, XrefRangeEnd = 1015063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015069, RefRangeEnd = 1015070, XrefRangeStart = 1015063, XrefRangeEnd = 1015069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015084, RefRangeEnd = 1015085, XrefRangeStart = 1015070, XrefRangeEnd = 1015084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DropItemThrowSystem componentSystem,
        ref DropItemThrowSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015085, XrefRangeEnd = 1015089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015089, XrefRangeEnd = 1015095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateDropItemThrowsJob()
      {
        Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem>.NativeClassPtr, "<>c__DisplayClass_CreateDropItemThrowsJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr);
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_dropsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (dropsDisabled));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_dropItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (dropItemPrefab));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_itemLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (itemLookupMap));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (prefabLookupMap));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (hits));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (collisionWorld));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_collisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (collisionFilter));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_getInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (getInventory));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_getInventoryInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (getInventoryInstances));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (random));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (tileWorld));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (spawnCommandBuffer));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr__ComponentDataFromEntity_ItemPickup_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_ItemPickup_0));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr__ComponentDataFromEntity_DropItem_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_DropItem_1));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_2));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr__ComponentDataFromEntity_SpellMovement_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_SpellMovement_3));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (_runtimes));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropItemAroundPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, 100679134);
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, 100679135);
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, 100679136);
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, 100679137);
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, 100679138);
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, 100679139);
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, 100679140);
        DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, 100679141);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dropItem;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<DropItemAroundPosition> forParameter_dropItem;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1014893, RefRangeEnd = 1014894, XrefRangeStart = 1014889, XrefRangeEnd = 1014893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DropItemThrowSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1014898, RefRangeEnd = 1014899, XrefRangeStart = 1014894, XrefRangeEnd = 1014898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dropItem));
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679142);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679143);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dropItem;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<DropItemAroundPosition>.Runtime runtime_dropItem;

          static Runtimes()
          {
            Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dropItem));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DropItemThrowSystem/ProjectM.<>c__DisplayClass_CreateDropItemThrowsJob/ProjectM.RunWithoutJobSystem_00003A83$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, "RunWithoutJobSystem_00003A83$PostfixBurstDelegate");
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679144);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679145);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679146);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679147);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DropItemThrowSystem/ProjectM.<>c__DisplayClass_CreateDropItemThrowsJob/ProjectM.RunWithoutJobSystem_00003A83$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014899, XrefRangeEnd = 1014913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014913, XrefRangeEnd = 1014931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014931, XrefRangeEnd = 1014946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1014973, RefRangeEnd = 1014974, XrefRangeStart = 1014946, XrefRangeEnd = 1014973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob>.NativeClassPtr, "RunWithoutJobSystem_00003A83$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679148);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679149);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679150);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679151);
          DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679153);
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
            IL2CPP.il2cpp_field_static_get_value(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropItemThrowSystem.__c__DisplayClass_CreateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
