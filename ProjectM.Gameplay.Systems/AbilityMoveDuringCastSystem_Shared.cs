// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityMoveDuringCastSystem_Shared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Hybrid;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class AbilityMoveDuringCastSystem_Shared : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveDuringCastActivePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___InitializeMoveDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InitializeMoveDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForInitializeMoveDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366060, XrefRangeEnd = 1366098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366098, XrefRangeEnd = 1366145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityMoveDuringCastSystem_Shared()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366145, XrefRangeEnd = 1366209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366209, XrefRangeEnd = 1366225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForInitializeMoveDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForInitializeMoveDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366225, XrefRangeEnd = 1366241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366241, XrefRangeEnd = 1366245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366245, XrefRangeEnd = 1366249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityMoveDuringCastSystem_Shared()
    {
      Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityMoveDuringCastSystem_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr);
      AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, nameof (_CurveCollection));
      AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__MoveDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, nameof (_MoveDuringCastActivePrefab));
      AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, nameof (_ServerTime));
      AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, nameof (_ModificationSystem));
      AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeMoveDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, "<>InitializeMoveDuringCast_entityQuery");
      AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeMoveDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, "<>InitializeMoveDuringCast_profilerMarker");
      AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, 100663890);
      AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, 100663891);
      AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, 100663892);
      AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, 100663893);
      AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForInitializeMoveDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, 100663894);
      AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, 100663895);
      AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, 100663896);
      AbilityMoveDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, 100663897);
    }

    public AbilityMoveDuringCastSystem_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CurveCollectionSystem _CurveCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _MoveDuringCastActivePrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__MoveDuringCastActivePrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__MoveDuringCastActivePrefab)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __InitializeMoveDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeMoveDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeMoveDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __InitializeMoveDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeMoveDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeMoveDuringCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AbilityMoveDuringCastSystem_Shared/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_moveDuringCastActivePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_MoveDuringCastActive_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref MoveDuringCastActive moveDuringCastActive)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveDuringCastActive;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_MoveDuringCastActive_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, nameof (commandBuffer));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_moveDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, nameof (moveDuringCastActivePrefab));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, nameof (serverTime));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, nameof (modificationStruct));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_curveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, nameof (curveMap));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, 100663898);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, 100663899);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_MoveDuringCastActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, 100663900);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass5_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0>.NativeClassPtr, data));
      }

      public unsafe AbilityMoveDuringCastSystem_Shared __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AbilityMoveDuringCastSystem_Shared) null : new AbilityMoveDuringCastSystem_Shared(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe Entity moveDuringCastActivePrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_moveDuringCastActivePrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_moveDuringCastActivePrefab)) = value;
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe ModificationStructure modificationStruct
      {
        get
        {
          return *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_modificationStruct));
        }
        [param: In] set
        {
          *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_modificationStruct)) = value;
        }
      }

      public unsafe CurveCollection curveMap
      {
        get
        {
          return *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_curveMap));
        }
        [param: In] set
        {
          *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0.NativeFieldInfoPtr_curveMap)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityMoveDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeMoveDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_InitializeMoveDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_moveDuringCastActivePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MoveDuringCastData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityCastTimeData_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public Entity moveDuringCastActivePrefab;
      [FieldOffset(24)]
      public ComponentDataFromEntity<MoveDuringCastData> _ComponentDataFromEntity_MoveDuringCastData_0;
      [FieldOffset(56)]
      public ComponentDataFromEntity<AbilityCastTimeData> _ComponentDataFromEntity_AbilityCastTimeData_1;
      [FieldOffset(88)]
      public ComponentDataFromEntity<AbilityBar_Shared> _ComponentDataFromEntity_AbilityBar_Shared_2;
      [FieldOffset(120)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_3;
      [FieldOffset(152)]
      public AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(184)]
      public unsafe AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365744, XrefRangeEnd = 1365763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1365763, RefRangeEnd = 1365765, XrefRangeStart = 1365763, XrefRangeEnd = 1365763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1365765, RefRangeEnd = 1365767, XrefRangeStart = 1365765, XrefRangeEnd = 1365765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365767, XrefRangeEnd = 1365769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365774, RefRangeEnd = 1365775, XrefRangeStart = 1365769, XrefRangeEnd = 1365774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365789, RefRangeEnd = 1365790, XrefRangeStart = 1365775, XrefRangeEnd = 1365789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityMoveDuringCastSystem_Shared componentSystem,
        ref AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365790, XrefRangeEnd = 1365794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365794, XrefRangeEnd = 1365800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_InitializeMoveDuringCast()
      {
        Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_InitializeMoveDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (commandBuffer));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr_moveDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (moveDuringCastActivePrefab));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_MoveDuringCastData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_MoveDuringCastData_0));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityCastTimeData_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityCastTimeData_1));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityBar_Shared_2));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_3));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (_runtimes));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, 100663901);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, 100663902);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, 100663903);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, 100663904);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, 100663905);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, 100663906);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, 100663907);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, 100663908);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castStartedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent> forParameter_castStartedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365664, RefRangeEnd = 1365665, XrefRangeStart = 1365661, XrefRangeEnd = 1365664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AbilityMoveDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365668, RefRangeEnd = 1365669, XrefRangeStart = 1365665, XrefRangeEnd = 1365668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castStartedEvent));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663909);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663910);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castStartedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent>.Runtime runtime_castStartedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castStartedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityMoveDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeMoveDuringCast/ProjectM.RunWithoutJobSystem_00000159$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, "RunWithoutJobSystem_00000159$PostfixBurstDelegate");
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663911);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663912);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663913);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663914);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityMoveDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeMoveDuringCast/ProjectM.RunWithoutJobSystem_00000159$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365669, XrefRangeEnd = 1365683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365683, XrefRangeEnd = 1365701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365701, XrefRangeEnd = 1365716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365743, RefRangeEnd = 1365744, XrefRangeStart = 1365716, XrefRangeEnd = 1365743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast>.NativeClassPtr, "RunWithoutJobSystem_00000159$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663915);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663916);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663917);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663918);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663920);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_InitializeMoveDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityMoveDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Movement_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityState_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MoveDuringCastData_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityCastTimeData_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_UnitStats_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_6;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_7;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_LongModificationBuffer_8;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_9;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_10;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_HybridModelOffset_11;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_12;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MoveDuringCastActive_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public double serverTime;
      [FieldOffset(8)]
      public ModificationStructure modificationStruct;
      [FieldOffset(40)]
      public CurveCollection curveMap;
      [FieldOffset(56)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(72)]
      public ComponentDataFromEntity<Movement> _ComponentDataFromEntity_Movement_0;
      [FieldOffset(104)]
      public ComponentDataFromEntity<AbilityState> _ComponentDataFromEntity_AbilityState_1;
      [FieldOffset(136)]
      public ComponentDataFromEntity<MoveDuringCastData> _ComponentDataFromEntity_MoveDuringCastData_2;
      [FieldOffset(168)]
      public ComponentDataFromEntity<AbilityCastTimeData> _ComponentDataFromEntity_AbilityCastTimeData_3;
      [FieldOffset(200)]
      public ComponentDataFromEntity<AbilityBar_Shared> _ComponentDataFromEntity_AbilityBar_Shared_4;
      [FieldOffset(232)]
      public ComponentDataFromEntity<UnitStats> _ComponentDataFromEntity_UnitStats_5;
      [FieldOffset(264)]
      public ComponentDataFromEntity<EntityInput> _ComponentDataFromEntity_EntityInput_6;
      [FieldOffset(296)]
      public ComponentDataFromEntity<TargetDirection> _ComponentDataFromEntity_TargetDirection_7;
      [FieldOffset(328)]
      public BufferFromEntity<LongModificationBuffer> _BufferFromEntity_LongModificationBuffer_8;
      [FieldOffset(368)]
      public ComponentDataFromEntity<BuffableFlagState> _ComponentDataFromEntity_BuffableFlagState_9;
      [FieldOffset(400)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_10;
      [FieldOffset(432)]
      public ComponentDataFromEntity<HybridModelOffset> _ComponentDataFromEntity_HybridModelOffset_11;
      [FieldOffset(464)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_12;
      [FieldOffset(496)]
      public AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(536)]
      public unsafe AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365885, XrefRangeEnd = 1365997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref MoveDuringCastActive moveDuringCastActive)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveDuringCastActive;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MoveDuringCastActive_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365997, RefRangeEnd = 1365998, XrefRangeStart = 1365997, XrefRangeEnd = 1365997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365998, RefRangeEnd = 1365999, XrefRangeStart = 1365998, XrefRangeEnd = 1365998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365999, XrefRangeEnd = 1366001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1366007, RefRangeEnd = 1366008, XrefRangeStart = 1366001, XrefRangeEnd = 1366007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1366049, RefRangeEnd = 1366050, XrefRangeStart = 1366008, XrefRangeEnd = 1366049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityMoveDuringCastSystem_Shared componentSystem,
        ref AbilityMoveDuringCastSystem_Shared.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366050, XrefRangeEnd = 1366054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366054, XrefRangeEnd = 1366060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (serverTime));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (modificationStruct));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_curveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (curveMap));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (commandBuffer));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_Movement_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_Movement_0));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityState_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityState_1));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_MoveDuringCastData_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_MoveDuringCastData_2));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityCastTimeData_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityCastTimeData_3));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityBar_Shared_4));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_UnitStats_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_UnitStats_5));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityInput_6));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_TargetDirection_7));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__BufferFromEntity_LongModificationBuffer_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_BufferFromEntity_LongModificationBuffer_8));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_BuffableFlagState_9));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_10));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_HybridModelOffset_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_HybridModelOffset_11));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_12));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MoveDuringCastActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663921);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663922);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663923);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663924);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663925);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663926);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663927);
        AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663928);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_moveDuringCastActive;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<MoveDuringCastActive> forParameter_moveDuringCastActive;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365804, RefRangeEnd = 1365805, XrefRangeStart = 1365800, XrefRangeEnd = 1365804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AbilityMoveDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365809, RefRangeEnd = 1365810, XrefRangeStart = 1365805, XrefRangeEnd = 1365809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_moveDuringCastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_moveDuringCastActive));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityMoveDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663929);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663930);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_moveDuringCastActive;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<MoveDuringCastActive>.Runtime runtime_moveDuringCastActive;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_moveDuringCastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_moveDuringCastActive));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityMoveDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_00000162$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000162$PostfixBurstDelegate");
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663931);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663932);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663933);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663934);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityMoveDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_00000162$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365810, XrefRangeEnd = 1365824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365824, XrefRangeEnd = 1365842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365842, XrefRangeEnd = 1365857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365884, RefRangeEnd = 1365885, XrefRangeStart = 1365857, XrefRangeEnd = 1365884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000162$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663935);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663936);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663937);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663938);
          AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663940);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityMoveDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
