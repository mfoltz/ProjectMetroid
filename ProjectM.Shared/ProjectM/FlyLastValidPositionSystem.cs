// Decompiled with JetBrains decompiler
// Type: ProjectM.FlyLastValidPositionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class FlyLastValidPositionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr___FlyLastValidPositionSystem_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FlyLastValidPositionSystem_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFlyLastValidPositionSystem_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737116, XrefRangeEnd = 737131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlyLastValidPositionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737131, XrefRangeEnd = 737151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlyLastValidPositionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737151, XrefRangeEnd = 737155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlyLastValidPositionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FlyLastValidPositionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737155, XrefRangeEnd = 737173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlyLastValidPositionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737198, RefRangeEnd = 737199, XrefRangeStart = 737173, XrefRangeEnd = 737198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFlyLastValidPositionSystem_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.NativeMethodInfoPtr___GetEntityQuery_ForFlyLastValidPositionSystem_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737203, RefRangeEnd = 737204, XrefRangeStart = 737199, XrefRangeEnd = 737203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FlyLastValidPositionSystem()
    {
      Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FlyLastValidPositionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr);
      FlyLastValidPositionSystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, nameof (_CollisionSystem));
      FlyLastValidPositionSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      FlyLastValidPositionSystem.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, nameof (_TilePolygons));
      FlyLastValidPositionSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      FlyLastValidPositionSystem.NativeFieldInfoPtr___FlyLastValidPositionSystem_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, "<>FlyLastValidPositionSystem_entityQuery");
      FlyLastValidPositionSystem.NativeFieldInfoPtr___FlyLastValidPositionSystem_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, "<>FlyLastValidPositionSystem_profilerMarker");
      FlyLastValidPositionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, 100665083);
      FlyLastValidPositionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, 100665084);
      FlyLastValidPositionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, 100665085);
      FlyLastValidPositionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, 100665086);
      FlyLastValidPositionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, 100665087);
      FlyLastValidPositionSystem.NativeMethodInfoPtr___GetEntityQuery_ForFlyLastValidPositionSystem_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, 100665088);
      FlyLastValidPositionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, 100665089);
    }

    public FlyLastValidPositionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __FlyLastValidPositionSystem_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr___FlyLastValidPositionSystem_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr___FlyLastValidPositionSystem_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FlyLastValidPositionSystem_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr___FlyLastValidPositionSystem_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.NativeFieldInfoPtr___FlyLastValidPositionSystem_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.FlyLastValidPositionSystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionFilter;
      private static readonly System.IntPtr NativeFieldInfoPtr_offset;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CanFly_byref_Translation_byref_Team_byref_BuffableFlagState_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref CanFly canFly,
        [In] ref Translation translation,
        [In] ref Team team,
        [In] ref BuffableFlagState buffableFlagState)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref canFly;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CanFly_byref_Translation_byref_Team_byref_BuffableFlagState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr);
        FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (collisionFilter));
        FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (offset));
        FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (collisionWorld));
        FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (mapData));
        FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, 100665090);
        FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CanFly_byref_Translation_byref_Team_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, 100665091);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass5_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass5_0>.NativeClassPtr, data));
      }

      public unsafe CollisionFilter collisionFilter
      {
        get
        {
          return *(CollisionFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collisionFilter));
        }
        [param: In] set
        {
          *(CollisionFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collisionFilter)) = value;
        }
      }

      public unsafe float3 offset
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_offset));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_offset)) = value;
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }

      public unsafe FlyLastValidPositionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (FlyLastValidPositionSystem) null : new FlyLastValidPositionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TileMapCollisionMath.MapData mapData
      {
        get
        {
          return *(TileMapCollisionMath.MapData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_mapData));
        }
        [param: In] set
        {
          *(TileMapCollisionMath.MapData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyLastValidPositionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_mapData)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.FlyLastValidPositionSystem/ProjectM.<>c__DisplayClass_FlyLastValidPositionSystem")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FlyLastValidPositionSystem
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionFilter;
      private static readonly System.IntPtr NativeFieldInfoPtr_offset;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Team_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CanFly_byref_Translation_byref_Team_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_FlyLastValidPositionSystem_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public CollisionFilter collisionFilter;
      [FieldOffset(12)]
      public float3 offset;
      [FieldOffset(24)]
      public CollisionWorld collisionWorld;
      [FieldOffset(368)]
      public TileMapCollisionMath.MapData mapData;
      [FieldOffset(472)]
      public ComponentDataFromEntity<Team> _ComponentDataFromEntity_Team_0;
      [FieldOffset(504)]
      public FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(640)]
      public unsafe FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737059, XrefRangeEnd = 737080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref CanFly canFly,
        [In] ref Translation translation,
        [In] ref Team team,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref canFly;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CanFly_byref_Translation_byref_Team_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 737080, RefRangeEnd = 737081, XrefRangeStart = 737080, XrefRangeEnd = 737080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref FlyLastValidPositionSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 737081, RefRangeEnd = 737082, XrefRangeStart = 737081, XrefRangeEnd = 737081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref FlyLastValidPositionSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737082, XrefRangeEnd = 737084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 737099, RefRangeEnd = 737100, XrefRangeStart = 737084, XrefRangeEnd = 737099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 737105, RefRangeEnd = 737106, XrefRangeStart = 737100, XrefRangeEnd = 737105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        FlyLastValidPositionSystem componentSystem,
        ref FlyLastValidPositionSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_FlyLastValidPositionSystem_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737106, XrefRangeEnd = 737110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737110, XrefRangeEnd = 737116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FlyLastValidPositionSystem()
      {
        Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlyLastValidPositionSystem>.NativeClassPtr, "<>c__DisplayClass_FlyLastValidPositionSystem");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr);
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_collisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (collisionFilter));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (offset));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (collisionWorld));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (mapData));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr__ComponentDataFromEntity_Team_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (_ComponentDataFromEntity_Team_0));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (_runtimes));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CanFly_byref_Translation_byref_Team_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, 100665092);
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, 100665093);
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, 100665094);
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, 100665095);
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, 100665096);
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_FlyLastValidPositionSystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, 100665097);
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, 100665098);
        FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, 100665099);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_canFly;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffableFlagState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_FlyLastValidPositionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CanFly> forParameter_canFly;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<BuffableFlagState> forParameter_buffableFlagState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 736969, RefRangeEnd = 736970, XrefRangeStart = 736956, XrefRangeEnd = 736969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(FlyLastValidPositionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_FlyLastValidPositionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 736983, RefRangeEnd = 736984, XrefRangeStart = 736970, XrefRangeEnd = 736983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_canFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_canFly));
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffableFlagState));
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_FlyLastValidPositionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, 100665100);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, 100665101);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_canFly;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffableFlagState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CanFly>.Runtime runtime_canFly;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<BuffableFlagState>.Runtime runtime_buffableFlagState;

          static Runtimes()
          {
            Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_canFly));
            FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
            FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffableFlagState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.FlyLastValidPositionSystem/ProjectM.<>c__DisplayClass_FlyLastValidPositionSystem/ProjectM.RunWithoutJobSystem_000006D9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, "RunWithoutJobSystem_000006D9$PostfixBurstDelegate");
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665102);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665103);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665104);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665105);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.FlyLastValidPositionSystem/ProjectM.<>c__DisplayClass_FlyLastValidPositionSystem/ProjectM.RunWithoutJobSystem_000006D9$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736984, XrefRangeEnd = 736998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736998, XrefRangeEnd = 737016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737016, XrefRangeEnd = 737031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 737058, RefRangeEnd = 737059, XrefRangeStart = 737031, XrefRangeEnd = 737058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem>.NativeClassPtr, "RunWithoutJobSystem_000006D9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665106);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665107);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665108);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665109);
          FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665111);
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
            IL2CPP.il2cpp_field_static_get_value(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(FlyLastValidPositionSystem.__c__DisplayClass_FlyLastValidPositionSystem.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
