﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.RemapCastleHeartTerritoryConnectionOnPersistenceLoad
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public class RemapCastleHeartTerritoryConnectionOnPersistenceLoad : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202006, XrefRangeEnd = 1202022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202022, XrefRangeEnd = 1202039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RemapCastleHeartTerritoryConnectionOnPersistenceLoad()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202039, XrefRangeEnd = 1202075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202075, XrefRangeEnd = 1202094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1202098, RefRangeEnd = 1202099, XrefRangeStart = 1202094, XrefRangeEnd = 1202098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RemapCastleHeartTerritoryConnectionOnPersistenceLoad()
    {
      Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding.Placement", nameof (RemapCastleHeartTerritoryConnectionOnPersistenceLoad));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr);
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, nameof (_Query));
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr__MapZoneCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, nameof (_MapZoneCollectionSystem));
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, 100664435);
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, 100664436);
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, 100664437);
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, 100664438);
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, 100664439);
      RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, 100664440);
    }

    public RemapCastleHeartTerritoryConnectionOnPersistenceLoad(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe MapZoneCollectionSystem _MapZoneCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr__MapZoneCollectionSystem));
        return pointer == System.IntPtr.Zero ? (MapZoneCollectionSystem) null : new MapZoneCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr__MapZoneCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Placement.RemapCastleHeartTerritoryConnectionOnPersistenceLoad/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapZoneCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CastleHeart_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, ref CastleHeart castleHeart)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CastleHeart_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeFieldInfoPtr_mapZoneCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr, nameof (mapZoneCollection));
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr, 100664441);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CastleHeart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr, 100664442);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe MapZoneCollection mapZoneCollection
      {
        get
        {
          return *(MapZoneCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeFieldInfoPtr_mapZoneCollection));
        }
        [param: In] set
        {
          *(MapZoneCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeFieldInfoPtr_mapZoneCollection)) = value;
        }
      }

      public unsafe RemapCastleHeartTerritoryConnectionOnPersistenceLoad __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RemapCastleHeartTerritoryConnectionOnPersistenceLoad) null : new RemapCastleHeartTerritoryConnectionOnPersistenceLoad(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Placement.RemapCastleHeartTerritoryConnectionOnPersistenceLoad/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapZoneCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CastleTerritory_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleHeart_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemapCastleHeartTerritoryConnectionOnPersistenceLoad_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public MapZoneCollection mapZoneCollection;
      [FieldOffset(96)]
      public ComponentDataFromEntity<CastleTerritory> _ComponentDataFromEntity_CastleTerritory_0;
      [FieldOffset(128)]
      public RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(168)]
      public unsafe RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201970, XrefRangeEnd = 1201981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref CastleHeart castleHeart)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleHeart_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1201574, RefRangeEnd = 1201577, XrefRangeStart = 1201574, XrefRangeEnd = 1201577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1201577, RefRangeEnd = 1201580, XrefRangeStart = 1201577, XrefRangeEnd = 1201580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201981, XrefRangeEnd = 1201983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1201989, RefRangeEnd = 1201990, XrefRangeStart = 1201983, XrefRangeEnd = 1201989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1201995, RefRangeEnd = 1201996, XrefRangeStart = 1201990, XrefRangeEnd = 1201995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad componentSystem,
        ref RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemapCastleHeartTerritoryConnectionOnPersistenceLoad_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201996, XrefRangeEnd = 1202000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202000, XrefRangeEnd = 1202006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_mapZoneCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (mapZoneCollection));
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_CastleTerritory_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_CastleTerritory_0));
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleHeart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664443);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664444);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664445);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664446);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664447);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemapCastleHeartTerritoryConnectionOnPersistenceLoad_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664448);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664449);
        RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664450);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeart;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemapCastleHeartTerritoryConnectionOnPersistenceLoad_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CastleHeart> forParameter_castleHeart;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1201889, RefRangeEnd = 1201890, XrefRangeStart = 1201885, XrefRangeEnd = 1201889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemapCastleHeartTerritoryConnectionOnPersistenceLoad_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1201894, RefRangeEnd = 1201895, XrefRangeStart = 1201890, XrefRangeEnd = 1201894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeart));
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemapCastleHeartTerritoryConnectionOnPersistenceLoad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664451);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664452);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeart;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleHeart>.Runtime runtime_castleHeart;

          static Runtimes()
          {
            Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeart));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Placement.RemapCastleHeartTerritoryConnectionOnPersistenceLoad/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.CastleBuilding.Placement.RunWithoutJobSystem_00000318$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000318$PostfixBurstDelegate");
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664453);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664454);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664455);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664456);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Placement.RemapCastleHeartTerritoryConnectionOnPersistenceLoad/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.CastleBuilding.Placement.RunWithoutJobSystem_00000318$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201895, XrefRangeEnd = 1201909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201909, XrefRangeEnd = 1201927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201927, XrefRangeEnd = 1201942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1201969, RefRangeEnd = 1201970, XrefRangeStart = 1201942, XrefRangeEnd = 1201969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000318$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664457);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664458);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664459);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664460);
          RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664462);
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
            IL2CPP.il2cpp_field_static_get_value(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RemapCastleHeartTerritoryConnectionOnPersistenceLoad.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
