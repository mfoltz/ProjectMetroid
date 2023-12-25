// Decompiled with JetBrains decompiler
// Type: ProjectM.TravelToTargetSpawnSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class TravelToTargetSpawnSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupTravels_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupTravels_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetupTravels_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385328, XrefRangeEnd = 1385335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelToTargetSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385335, XrefRangeEnd = 1385355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelToTargetSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelToTargetSpawnSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TravelToTargetSpawnSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385355, XrefRangeEnd = 1385373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelToTargetSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1385398, RefRangeEnd = 1385399, XrefRangeStart = 1385373, XrefRangeEnd = 1385398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetupTravels_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetupTravels_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1385403, RefRangeEnd = 1385404, XrefRangeStart = 1385399, XrefRangeEnd = 1385403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TravelToTargetSpawnSystem()
    {
      Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (TravelToTargetSpawnSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr);
      TravelToTargetSpawnSystem.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, nameof (_TilePolygons));
      TravelToTargetSpawnSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      TravelToTargetSpawnSystem.NativeFieldInfoPtr___SetupTravels_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, "<>SetupTravels_entityQuery");
      TravelToTargetSpawnSystem.NativeFieldInfoPtr___SetupTravels_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, "<>SetupTravels_profilerMarker");
      TravelToTargetSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, 100665933);
      TravelToTargetSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, 100665934);
      TravelToTargetSpawnSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, 100665935);
      TravelToTargetSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, 100665936);
      TravelToTargetSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, 100665937);
      TravelToTargetSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetupTravels_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, 100665938);
      TravelToTargetSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, 100665939);
    }

    public TravelToTargetSpawnSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __SetupTravels_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.NativeFieldInfoPtr___SetupTravels_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.NativeFieldInfoPtr___SetupTravels_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetupTravels_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.NativeFieldInfoPtr___SetupTravels_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.NativeFieldInfoPtr___SetupTravels_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.TravelToTargetSpawnSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TravelToTarget_byref_SpellTarget_byref_Buff_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref TravelToTarget travelToTarget,
        [In] ref SpellTarget interactTarget,
        [In] ref Buff buff)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref travelToTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TravelToTarget_byref_SpellTarget_byref_Buff_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr);
        TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (mapData));
        TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (worldType));
        TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, 100665940);
        TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TravelToTarget_byref_SpellTarget_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, 100665941);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe TravelToTargetSpawnSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TravelToTargetSpawnSystem) null : new TravelToTargetSpawnSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TileMapCollisionMath.MapData mapData
      {
        get
        {
          return *(TileMapCollisionMath.MapData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_mapData));
        }
        [param: In] set
        {
          *(TileMapCollisionMath.MapData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_mapData)) = value;
        }
      }

      public unsafe WorldType worldType
      {
        get
        {
          return *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_worldType));
        }
        [param: In] set
        {
          *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSpawnSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_worldType)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.TravelToTargetSpawnSystem/ProjectM.<>c__DisplayClass_SetupTravels")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetupTravels
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TravelToTargetRadius_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CollisionRadius_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Buff_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TravelToTarget_byref_SpellTarget_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSpawnSystem_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public TileMapCollisionMath.MapData mapData;
      [FieldOffset(104)]
      public WorldType worldType;
      [FieldOffset(112)]
      public ComponentDataFromEntity<TravelToTargetRadius> _ComponentDataFromEntity_TravelToTargetRadius_0;
      [FieldOffset(144)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_1;
      [FieldOffset(176)]
      public ComponentDataFromEntity<CollisionRadius> _ComponentDataFromEntity_CollisionRadius_2;
      [FieldOffset(208)]
      public ComponentDataFromEntity<Buff> _ComponentDataFromEntity_Buff_3;
      [FieldOffset(240)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_4;
      [FieldOffset(272)]
      public TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(376)]
      public unsafe TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385241, XrefRangeEnd = 1385283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref TravelToTarget travelToTarget,
        [In] ref SpellTarget interactTarget,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref travelToTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TravelToTarget_byref_SpellTarget_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1385283, RefRangeEnd = 1385284, XrefRangeStart = 1385283, XrefRangeEnd = 1385283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TravelToTargetSpawnSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1385284, RefRangeEnd = 1385285, XrefRangeStart = 1385284, XrefRangeEnd = 1385284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TravelToTargetSpawnSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385285, XrefRangeEnd = 1385287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1385299, RefRangeEnd = 1385300, XrefRangeStart = 1385287, XrefRangeEnd = 1385299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1385317, RefRangeEnd = 1385318, XrefRangeStart = 1385300, XrefRangeEnd = 1385317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TravelToTargetSpawnSystem componentSystem,
        ref TravelToTargetSpawnSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSpawnSystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385318, XrefRangeEnd = 1385322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385322, XrefRangeEnd = 1385328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetupTravels()
      {
        Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_SetupTravels");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr);
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (mapData));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (worldType));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr__ComponentDataFromEntity_TravelToTargetRadius_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (_ComponentDataFromEntity_TravelToTargetRadius_0));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_1));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr__ComponentDataFromEntity_CollisionRadius_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (_ComponentDataFromEntity_CollisionRadius_2));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr__ComponentDataFromEntity_Buff_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (_ComponentDataFromEntity_Buff_3));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_4));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (_runtimes));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TravelToTarget_byref_SpellTarget_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, 100665942);
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, 100665943);
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, 100665944);
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, 100665945);
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, 100665946);
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSpawnSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, 100665947);
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, 100665948);
        TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, 100665949);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_travelToTarget;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interactTarget;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<TravelToTarget> forParameter_travelToTarget;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SpellTarget> forParameter_interactTarget;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1385154, RefRangeEnd = 1385155, XrefRangeStart = 1385144, XrefRangeEnd = 1385154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TravelToTargetSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1385165, RefRangeEnd = 1385166, XrefRangeStart = 1385155, XrefRangeEnd = 1385165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_travelToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_travelToTarget));
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interactTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interactTarget));
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr, 100665950);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr, 100665951);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_travelToTarget;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interactTarget;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<TravelToTarget>.Runtime runtime_travelToTarget;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<SpellTarget>.Runtime runtime_interactTarget;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_travelToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_travelToTarget));
            TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interactTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interactTarget));
            TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TravelToTargetSpawnSystem/ProjectM.<>c__DisplayClass_SetupTravels/ProjectM.RunWithoutJobSystem_00000617$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, "RunWithoutJobSystem_00000617$PostfixBurstDelegate");
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665952);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665953);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665954);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665955);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TravelToTargetSpawnSystem/ProjectM.<>c__DisplayClass_SetupTravels/ProjectM.RunWithoutJobSystem_00000617$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385166, XrefRangeEnd = 1385180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385180, XrefRangeEnd = 1385198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385198, XrefRangeEnd = 1385213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1385240, RefRangeEnd = 1385241, XrefRangeStart = 1385213, XrefRangeEnd = 1385240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels>.NativeClassPtr, "RunWithoutJobSystem_00000617$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665956);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665957);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665958);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665959);
          TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665961);
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
            IL2CPP.il2cpp_field_static_get_value(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TravelToTargetSpawnSystem.__c__DisplayClass_SetupTravels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
