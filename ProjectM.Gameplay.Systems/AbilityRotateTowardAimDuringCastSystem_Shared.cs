// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityRotateTowardAimDuringCastSystem_Shared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class AbilityRotateTowardAimDuringCastSystem_Shared : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__RotateDuringCastActivePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr___InitializeRotateDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InitializeRotateDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VectorAngle_Public_Static_Double_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForInitializeRotateDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366569, XrefRangeEnd = 1366602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366602, XrefRangeEnd = 1366648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1366650, RefRangeEnd = 1366651, XrefRangeStart = 1366648, XrefRangeEnd = 1366650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double VectorAngle(float2 p1, float2 p2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &p1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_VectorAngle_Public_Static_Double_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityRotateTowardAimDuringCastSystem_Shared()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366651, XrefRangeEnd = 1366715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366715, XrefRangeEnd = 1366731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForInitializeRotateDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForInitializeRotateDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366731, XrefRangeEnd = 1366747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366747, XrefRangeEnd = 1366751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366751, XrefRangeEnd = 1366755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityRotateTowardAimDuringCastSystem_Shared()
    {
      Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityRotateTowardAimDuringCastSystem_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, nameof (_CurveCollection));
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__RotateDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, nameof (_RotateDuringCastActivePrefab));
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, nameof (_ServerTime));
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeRotateDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, "<>InitializeRotateDuringCast_entityQuery");
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeRotateDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, "<>InitializeRotateDuringCast_profilerMarker");
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663941);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663942);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_VectorAngle_Public_Static_Double_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663943);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663944);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663945);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForInitializeRotateDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663946);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663947);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663948);
      AbilityRotateTowardAimDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, 100663949);
    }

    public AbilityRotateTowardAimDuringCastSystem_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CurveCollectionSystem _CurveCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _RotateDuringCastActivePrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__RotateDuringCastActivePrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__RotateDuringCastActivePrefab)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __InitializeRotateDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeRotateDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeRotateDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __InitializeRotateDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeRotateDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeRotateDuringCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AbilityRotateTowardAimDuringCastSystem_Shared/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_rotateDuringCastActivePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RotateTowardsAimDirectionDuringCastActive_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref RotateTowardsAimDirectionDuringCastActive moveDuringCastActive)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveDuringCastActive;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RotateTowardsAimDirectionDuringCastActive_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, nameof (commandBuffer));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_rotateDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, nameof (rotateDuringCastActivePrefab));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, nameof (serverTime));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_curveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, nameof (curveMap));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, 100663950);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, 100663951);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RotateTowardsAimDirectionDuringCastActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, 100663952);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass4_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0>.NativeClassPtr, data));
      }

      public unsafe AbilityRotateTowardAimDuringCastSystem_Shared __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AbilityRotateTowardAimDuringCastSystem_Shared) null : new AbilityRotateTowardAimDuringCastSystem_Shared(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe Entity rotateDuringCastActivePrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_rotateDuringCastActivePrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_rotateDuringCastActivePrefab)) = value;
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe CurveCollection curveMap
      {
        get
        {
          return *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_curveMap));
        }
        [param: In] set
        {
          *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0.NativeFieldInfoPtr_curveMap)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityRotateTowardAimDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeRotateDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_InitializeRotateDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_rotateDuringCastActivePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_RotateTowardsAimDirectionDuringCastData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityCastTimeData_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public Entity rotateDuringCastActivePrefab;
      [FieldOffset(24)]
      public ComponentDataFromEntity<RotateTowardsAimDirectionDuringCastData> _ComponentDataFromEntity_RotateTowardsAimDirectionDuringCastData_0;
      [FieldOffset(56)]
      public ComponentDataFromEntity<AbilityCastTimeData> _ComponentDataFromEntity_AbilityCastTimeData_1;
      [FieldOffset(88)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_2;
      [FieldOffset(120)]
      public AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(152)]
      public unsafe AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366332, XrefRangeEnd = 1366345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1365763, RefRangeEnd = 1365765, XrefRangeStart = 1365763, XrefRangeEnd = 1365765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1365765, RefRangeEnd = 1365767, XrefRangeStart = 1365765, XrefRangeEnd = 1365767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366345, XrefRangeEnd = 1366347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1366352, RefRangeEnd = 1366353, XrefRangeStart = 1366347, XrefRangeEnd = 1366352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1366364, RefRangeEnd = 1366365, XrefRangeStart = 1366353, XrefRangeEnd = 1366364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityRotateTowardAimDuringCastSystem_Shared componentSystem,
        ref AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366365, XrefRangeEnd = 1366369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366369, XrefRangeEnd = 1366375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_InitializeRotateDuringCast()
      {
        Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_InitializeRotateDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (commandBuffer));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr_rotateDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (rotateDuringCastActivePrefab));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_RotateTowardsAimDirectionDuringCastData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_RotateTowardsAimDirectionDuringCastData_0));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityCastTimeData_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityCastTimeData_1));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_2));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (_runtimes));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, 100663953);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, 100663954);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, 100663955);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, 100663956);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, 100663957);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, 100663958);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, 100663959);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, 100663960);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castStartedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent> forParameter_castStartedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1366252, RefRangeEnd = 1366253, XrefRangeStart = 1366249, XrefRangeEnd = 1366252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityRotateTowardAimDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1366256, RefRangeEnd = 1366257, XrefRangeStart = 1366253, XrefRangeEnd = 1366256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castStartedEvent));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663961);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663962);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castStartedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent>.Runtime runtime_castStartedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castStartedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityRotateTowardAimDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeRotateDuringCast/ProjectM.RunWithoutJobSystem_00000175$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, "RunWithoutJobSystem_00000175$PostfixBurstDelegate");
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663963);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663964);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663965);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663966);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityRotateTowardAimDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeRotateDuringCast/ProjectM.RunWithoutJobSystem_00000175$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366257, XrefRangeEnd = 1366271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366271, XrefRangeEnd = 1366289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366289, XrefRangeEnd = 1366304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1366331, RefRangeEnd = 1366332, XrefRangeStart = 1366304, XrefRangeEnd = 1366331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast>.NativeClassPtr, "RunWithoutJobSystem_00000175$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663967);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663968);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663969);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663970);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663972);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_InitializeRotateDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityRotateTowardAimDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityState_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_RotateTowardsAimDirectionDuringCastData_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityCastTimeData_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_UnitStats_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_6;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RotateTowardsAimDirectionDuringCastActive_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public double serverTime;
      [FieldOffset(8)]
      public CurveCollection curveMap;
      [FieldOffset(24)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(40)]
      public ComponentDataFromEntity<TargetDirection> _ComponentDataFromEntity_TargetDirection_0;
      [FieldOffset(72)]
      public ComponentDataFromEntity<AbilityState> _ComponentDataFromEntity_AbilityState_1;
      [FieldOffset(104)]
      public ComponentDataFromEntity<RotateTowardsAimDirectionDuringCastData> _ComponentDataFromEntity_RotateTowardsAimDirectionDuringCastData_2;
      [FieldOffset(136)]
      public ComponentDataFromEntity<AbilityCastTimeData> _ComponentDataFromEntity_AbilityCastTimeData_3;
      [FieldOffset(168)]
      public ComponentDataFromEntity<UnitStats> _ComponentDataFromEntity_UnitStats_4;
      [FieldOffset(200)]
      public ComponentDataFromEntity<EntityInput> _ComponentDataFromEntity_EntityInput_5;
      [FieldOffset(232)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_6;
      [FieldOffset(264)]
      public AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(304)]
      public unsafe AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366460, XrefRangeEnd = 1366524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref RotateTowardsAimDirectionDuringCastActive moveDuringCastActive)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveDuringCastActive;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RotateTowardsAimDirectionDuringCastActive_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1366524, RefRangeEnd = 1366525, XrefRangeStart = 1366524, XrefRangeEnd = 1366524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1366525, RefRangeEnd = 1366526, XrefRangeStart = 1366525, XrefRangeEnd = 1366525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366526, XrefRangeEnd = 1366528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1366534, RefRangeEnd = 1366535, XrefRangeStart = 1366528, XrefRangeEnd = 1366534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1366558, RefRangeEnd = 1366559, XrefRangeStart = 1366535, XrefRangeEnd = 1366558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityRotateTowardAimDuringCastSystem_Shared componentSystem,
        ref AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366559, XrefRangeEnd = 1366563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366563, XrefRangeEnd = 1366569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (serverTime));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_curveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (curveMap));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (commandBuffer));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_TargetDirection_0));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityState_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityState_1));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_RotateTowardsAimDirectionDuringCastData_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_RotateTowardsAimDirectionDuringCastData_2));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityCastTimeData_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityCastTimeData_3));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_UnitStats_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_UnitStats_4));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityInput_5));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_6));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RotateTowardsAimDirectionDuringCastActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663973);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663974);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663975);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663976);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663977);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663978);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663979);
        AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663980);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_moveDuringCastActive;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<RotateTowardsAimDirectionDuringCastActive> forParameter_moveDuringCastActive;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1366379, RefRangeEnd = 1366380, XrefRangeStart = 1366375, XrefRangeEnd = 1366379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityRotateTowardAimDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1366384, RefRangeEnd = 1366385, XrefRangeStart = 1366380, XrefRangeEnd = 1366384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_moveDuringCastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_moveDuringCastActive));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityRotateTowardAimDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663981);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663982);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_moveDuringCastActive;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RotateTowardsAimDirectionDuringCastActive>.Runtime runtime_moveDuringCastActive;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_moveDuringCastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_moveDuringCastActive));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityRotateTowardAimDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_0000017E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_0000017E$PostfixBurstDelegate");
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663983);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663984);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663985);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663986);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityRotateTowardAimDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_0000017E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366385, XrefRangeEnd = 1366399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366399, XrefRangeEnd = 1366417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366417, XrefRangeEnd = 1366432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1366459, RefRangeEnd = 1366460, XrefRangeStart = 1366432, XrefRangeEnd = 1366459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_0000017E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663987);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663988);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663989);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663990);
          AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663992);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityRotateTowardAimDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
