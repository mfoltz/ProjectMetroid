// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnRegionSpawnSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class SpawnRegionSpawnSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnSpawnRegionEntities_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnSpawnRegionEntities_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_0_Private_Void_byref_SpawnEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnSpawnRegionEntities_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072311, XrefRangeEnd = 1072317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnRegionSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072317, XrefRangeEnd = 1072327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnRegionSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnRegionSpawnSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1072390, RefRangeEnd = 1072392, XrefRangeStart = 1072327, XrefRangeEnd = 1072390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__4_0([In] ref SpawnRegionSpawnSystem.SpawnEvent spawnEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref spawnEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.NativeMethodInfoPtr__OnUpdate_b__4_0_Private_Void_byref_SpawnEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072392, XrefRangeEnd = 1072412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnRegionSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072412, XrefRangeEnd = 1072428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnSpawnRegionEntities_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnSpawnRegionEntities_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpawnRegionSpawnSystem()
    {
      Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnRegionSpawnSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr);
      SpawnRegionSpawnSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      SpawnRegionSpawnSystem.NativeFieldInfoPtr__DestroyQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, nameof (_DestroyQuery));
      SpawnRegionSpawnSystem.NativeFieldInfoPtr___SpawnSpawnRegionEntities_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, "<>SpawnSpawnRegionEntities_entityQuery");
      SpawnRegionSpawnSystem.NativeFieldInfoPtr___SpawnSpawnRegionEntities_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, "<>SpawnSpawnRegionEntities_profilerMarker");
      SpawnRegionSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, 100684490);
      SpawnRegionSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, 100684491);
      SpawnRegionSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, 100684492);
      SpawnRegionSpawnSystem.NativeMethodInfoPtr__OnUpdate_b__4_0_Private_Void_byref_SpawnEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, 100684493);
      SpawnRegionSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, 100684494);
      SpawnRegionSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnSpawnRegionEntities_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, 100684495);
    }

    public SpawnRegionSpawnSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DestroyQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.NativeFieldInfoPtr__DestroyQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.NativeFieldInfoPtr__DestroyQuery)) = value;
      }
    }

    public unsafe EntityQuery __SpawnSpawnRegionEntities_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.NativeFieldInfoPtr___SpawnSpawnRegionEntities_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.NativeFieldInfoPtr___SpawnSpawnRegionEntities_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnSpawnRegionEntities_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.NativeFieldInfoPtr___SpawnSpawnRegionEntities_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.NativeFieldInfoPtr___SpawnSpawnRegionEntities_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Translation;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSlotIndex;
      [FieldOffset(0)]
      public Entity SpawnRegion;
      [FieldOffset(8)]
      public PrefabGUID TargetPrefab;
      [FieldOffset(12)]
      public float3 Translation;
      [FieldOffset(24)]
      public quaternion Rotation;
      [FieldOffset(40)]
      public int SpawnSlotIndex;

      static SpawnEvent()
      {
        Il2CppClassPointerStore<SpawnRegionSpawnSystem.SpawnEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, nameof (SpawnEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionSpawnSystem.SpawnEvent>.NativeClassPtr);
        SpawnRegionSpawnSystem.SpawnEvent.NativeFieldInfoPtr_SpawnRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.SpawnEvent>.NativeClassPtr, nameof (SpawnRegion));
        SpawnRegionSpawnSystem.SpawnEvent.NativeFieldInfoPtr_TargetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.SpawnEvent>.NativeClassPtr, nameof (TargetPrefab));
        SpawnRegionSpawnSystem.SpawnEvent.NativeFieldInfoPtr_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.SpawnEvent>.NativeClassPtr, nameof (Translation));
        SpawnRegionSpawnSystem.SpawnEvent.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.SpawnEvent>.NativeClassPtr, nameof (Rotation));
        SpawnRegionSpawnSystem.SpawnEvent.NativeFieldInfoPtr_SpawnSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.SpawnEvent>.NativeClassPtr, nameof (SpawnSlotIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionSpawnSystem.SpawnEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SpawnRegionSpawnSystem/ProjectM.<>c__DisplayClass_SpawnSpawnRegionEntities")]
    public sealed class __c__DisplayClass_SpawnSpawnRegionEntities : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_SpawnEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionSpawnSystem_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072292, XrefRangeEnd = 1072294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref SpawnRegionSpawnSystem.SpawnEvent spawnEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref spawnEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_SpawnEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072294, XrefRangeEnd = 1072304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072310, RefRangeEnd = 1072311, XrefRangeStart = 1072304, XrefRangeEnd = 1072310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(SpawnRegionSpawnSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionSpawnSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnSpawnRegionEntities()
      {
        Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_SpawnSpawnRegionEntities");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr);
        SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, nameof (hostInstance));
        SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, nameof (_runtimes));
        SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, nameof (_performLambdaDelegate));
        SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_SpawnEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, 100684496);
        SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, 100684498);
        SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, 100684499);
        SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, 100684500);
      }

      public __c__DisplayClass_SpawnSpawnRegionEntities(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SpawnSpawnRegionEntities()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, data));
      }

      public unsafe SpawnRegionSpawnSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (SpawnRegionSpawnSystem) null : new SpawnRegionSpawnSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<SpawnRegionSpawnSystem.SpawnEvent> forParameter_spawnEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072284, XrefRangeEnd = 1072287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SpawnRegionSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1072291, RefRangeEnd = 1072292, XrefRangeStart = 1072287, XrefRangeEnd = 1072291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnEvent));
          SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders>.NativeClassPtr, 100684501);
          SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders>.NativeClassPtr, 100684502);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<SpawnRegionSpawnSystem.SpawnEvent>.StructuralChangeRuntime runtime_spawnEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionSpawnSystem.__c__DisplayClass_SpawnSpawnRegionEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
