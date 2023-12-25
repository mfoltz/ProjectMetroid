// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityModifyMovementDuringCastSystem_Shared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class AbilityModifyMovementDuringCastSystem_Shared : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModifyMovementDuringCastActivePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__InterruptedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModifyMovementDuringCastQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCastStartedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InterruptModifyMovementDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InterruptModifyMovementDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___InitializeModifyMovementDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___InitializeModifyMovementDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForInterruptModifyMovementDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForInitializeModifyMovementDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365400, XrefRangeEnd = 1365434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365434, XrefRangeEnd = 1365437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365437, XrefRangeEnd = 1365506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityModifyMovementDuringCastSystem_Shared()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365506, XrefRangeEnd = 1365601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365601, XrefRangeEnd = 1365617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForInterruptModifyMovementDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForInterruptModifyMovementDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365617, XrefRangeEnd = 1365633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForInitializeModifyMovementDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForInitializeModifyMovementDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365633, XrefRangeEnd = 1365649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365649, XrefRangeEnd = 1365653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365653, XrefRangeEnd = 1365657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365657, XrefRangeEnd = 1365661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityModifyMovementDuringCastSystem_Shared()
    {
      Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityModifyMovementDuringCastSystem_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr);
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyMovementDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, nameof (_ModifyMovementDuringCastActivePrefab));
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, nameof (_ServerTime));
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__InterruptedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, nameof (_InterruptedQuery));
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyMovementDuringCastQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, nameof (_ModifyMovementDuringCastQuery));
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityCastStartedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, nameof (_AbilityCastStartedEventQuery));
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InterruptModifyMovementDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>InterruptModifyMovementDuringCast_entityQuery");
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InterruptModifyMovementDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>InterruptModifyMovementDuringCast_profilerMarker");
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeModifyMovementDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>InitializeModifyMovementDuringCast_entityQuery");
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeModifyMovementDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>InitializeModifyMovementDuringCast_profilerMarker");
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>OnUpdate_LambdaJob2_entityQuery");
      AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663811);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663812);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663813);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663814);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663815);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForInterruptModifyMovementDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663816);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForInitializeModifyMovementDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663817);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663818);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663819);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663820);
      AbilityModifyMovementDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, 100663821);
    }

    public AbilityModifyMovementDuringCastSystem_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity _ModifyMovementDuringCastActivePrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyMovementDuringCastActivePrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyMovementDuringCastActivePrefab)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _InterruptedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__InterruptedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__InterruptedQuery)) = value;
      }
    }

    public unsafe EntityQuery _ModifyMovementDuringCastQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyMovementDuringCastQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyMovementDuringCastQuery)) = value;
      }
    }

    public unsafe EntityQuery _AbilityCastStartedEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityCastStartedEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityCastStartedEventQuery)) = value;
      }
    }

    public unsafe EntityQuery __InterruptModifyMovementDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InterruptModifyMovementDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InterruptModifyMovementDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __InterruptModifyMovementDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InterruptModifyMovementDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InterruptModifyMovementDuringCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __InitializeModifyMovementDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeModifyMovementDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeModifyMovementDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __InitializeModifyMovementDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeModifyMovementDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___InitializeModifyMovementDuringCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, nameof (serverTime));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, 100663822);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe AbilityModifyMovementDuringCastSystem_Shared __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AbilityModifyMovementDuringCastSystem_Shared) null : new AbilityModifyMovementDuringCastSystem_Shared(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/<>c__DisplayClass7_1")]
    public sealed class __c__DisplayClass7_1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_1()
      {
        Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass7_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, 100663823);
      }

      public __c__DisplayClass7_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, data));
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0);
          return new AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/<>c__DisplayClass7_2")]
    public sealed class __c__DisplayClass7_2 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_interruptedEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref ModifyMovementDuringCastActive modifyMovementDuringCastActive)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyMovementDuringCastActive;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_2()
      {
        Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass7_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeFieldInfoPtr_interruptedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr, nameof (interruptedEvents));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr, "CS$<>8__locals2");
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr, 100663824);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr, 100663825);
      }

      public __c__DisplayClass7_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_2()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2>.NativeClassPtr, data));
      }

      public unsafe NativeArray<AbilityInterruptedEvent> interruptedEvents
      {
        get
        {
          return *(NativeArray<AbilityInterruptedEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeFieldInfoPtr_interruptedEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeFieldInfoPtr_interruptedEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<AbilityInterruptedEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1 field_Public___c__DisplayClass7_1_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0);
          return new AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/<>c__DisplayClass7_3")]
    public sealed class __c__DisplayClass7_3 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_modifyMovementDuringCastActivePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_AbilityCastStartedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_3()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, [In] ref AbilityCastStartedEvent castStartedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_AbilityCastStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_3()
      {
        Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass7_3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeFieldInfoPtr_modifyMovementDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr, nameof (modifyMovementDuringCastActivePrefab));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr, "CS$<>8__locals3");
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr, 100663826);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr, 100663827);
      }

      public __c__DisplayClass7_3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_3()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3>.NativeClassPtr, data));
      }

      public unsafe Entity modifyMovementDuringCastActivePrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeFieldInfoPtr_modifyMovementDuringCastActivePrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeFieldInfoPtr_modifyMovementDuringCastActivePrefab)) = value;
        }
      }

      public AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1 field_Public___c__DisplayClass7_1_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0);
          return new AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3.NativeFieldInfoPtr_field_Public___c__DisplayClass7_1_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/<>c__DisplayClass7_4")]
    public sealed class __c__DisplayClass7_4 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_4()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        [In] ref ModifyMovementDuringCastActive modifyMovementDuringCastActive)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyMovementDuringCastActive;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_4()
      {
        Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass7_4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr, "CS$<>8__locals4");
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr, 100663828);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr, 100663829);
      }

      public __c__DisplayClass7_4(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_4()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4>.NativeClassPtr, data));
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0);
          return new AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InterruptModifyMovementDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_InterruptModifyMovementDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_interruptedEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<AbilityInterruptedEvent> interruptedEvents;
      [FieldOffset(16)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(32)]
      public AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365111, XrefRangeEnd = 1365116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ModifyMovementDuringCastActive modifyMovementDuringCastActive)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyMovementDuringCastActive;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365116, RefRangeEnd = 1365117, XrefRangeStart = 1365116, XrefRangeEnd = 1365116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365117, XrefRangeEnd = 1365119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365125, RefRangeEnd = 1365126, XrefRangeStart = 1365119, XrefRangeEnd = 1365125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365128, RefRangeEnd = 1365129, XrefRangeStart = 1365126, XrefRangeEnd = 1365128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityModifyMovementDuringCastSystem_Shared componentSystem,
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365129, XrefRangeEnd = 1365133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365133, XrefRangeEnd = 1365139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_InterruptModifyMovementDuringCast()
      {
        Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_InterruptModifyMovementDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr_interruptedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, nameof (interruptedEvents));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, nameof (_runtimes));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, 100663830);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, 100663831);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, 100663832);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, 100663833);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, 100663834);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, 100663835);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, 100663836);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, 100663837);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifyMovementDuringCastActive;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ModifyMovementDuringCastActive> forParameter_modifyMovementDuringCastActive;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365030, RefRangeEnd = 1365031, XrefRangeStart = 1365026, XrefRangeEnd = 1365030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityModifyMovementDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365035, RefRangeEnd = 1365036, XrefRangeStart = 1365031, XrefRangeEnd = 1365035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifyMovementDuringCastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifyMovementDuringCastActive));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663838);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663839);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifyMovementDuringCastActive;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ModifyMovementDuringCastActive>.Runtime runtime_modifyMovementDuringCastActive;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifyMovementDuringCastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifyMovementDuringCastActive));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InterruptModifyMovementDuringCast/ProjectM.RunWithoutJobSystem_00000135$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, "RunWithoutJobSystem_00000135$PostfixBurstDelegate");
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663840);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663841);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663842);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663843);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InterruptModifyMovementDuringCast/ProjectM.RunWithoutJobSystem_00000135$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365036, XrefRangeEnd = 1365050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365050, XrefRangeEnd = 1365068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365068, XrefRangeEnd = 1365083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365110, RefRangeEnd = 1365111, XrefRangeStart = 1365083, XrefRangeEnd = 1365110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast>.NativeClassPtr, "RunWithoutJobSystem_00000135$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663844);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663845);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663846);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663847);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663849);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InterruptModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeModifyMovementDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_InitializeModifyMovementDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_modifyMovementDuringCastActivePrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ModifyMovementDuringCastData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public Entity modifyMovementDuringCastActivePrefab;
      [FieldOffset(24)]
      public double serverTime;
      [FieldOffset(32)]
      public ComponentDataFromEntity<ModifyMovementDuringCastData> _ComponentDataFromEntity_ModifyMovementDuringCastData_0;
      [FieldOffset(64)]
      public AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365224, XrefRangeEnd = 1365231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365231, RefRangeEnd = 1365232, XrefRangeStart = 1365231, XrefRangeEnd = 1365231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365232, RefRangeEnd = 1365233, XrefRangeStart = 1365232, XrefRangeEnd = 1365232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365233, XrefRangeEnd = 1365235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365241, RefRangeEnd = 1365242, XrefRangeStart = 1365235, XrefRangeEnd = 1365241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365247, RefRangeEnd = 1365248, XrefRangeStart = 1365242, XrefRangeEnd = 1365247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityModifyMovementDuringCastSystem_Shared componentSystem,
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_3 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365248, XrefRangeEnd = 1365252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365252, XrefRangeEnd = 1365258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_InitializeModifyMovementDuringCast()
      {
        Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_InitializeModifyMovementDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_modifyMovementDuringCastActivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (modifyMovementDuringCastActivePrefab));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (serverTime));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_ModifyMovementDuringCastData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_ModifyMovementDuringCastData_0));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (_runtimes));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, 100663850);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, 100663851);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, 100663852);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, 100663853);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, 100663854);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, 100663855);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, 100663856);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, 100663857);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castStartedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent> forParameter_castStartedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365143, RefRangeEnd = 1365144, XrefRangeStart = 1365139, XrefRangeEnd = 1365143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityModifyMovementDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365148, RefRangeEnd = 1365149, XrefRangeStart = 1365144, XrefRangeEnd = 1365148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castStartedEvent));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663858);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663859);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castStartedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent>.Runtime runtime_castStartedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castStartedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeModifyMovementDuringCast/ProjectM.RunWithoutJobSystem_0000013E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, "RunWithoutJobSystem_0000013E$PostfixBurstDelegate");
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663860);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663861);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663862);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663863);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_InitializeModifyMovementDuringCast/ProjectM.RunWithoutJobSystem_0000013E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365149, XrefRangeEnd = 1365163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365163, XrefRangeEnd = 1365181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365181, XrefRangeEnd = 1365196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365223, RefRangeEnd = 1365224, XrefRangeStart = 1365196, XrefRangeEnd = 1365223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast>.NativeClassPtr, "RunWithoutJobSystem_0000013E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663864);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663865);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663866);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663867);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663869);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_InitializeModifyMovementDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Movement_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityState_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ModifyMovementDuringCastData_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public double serverTime;
      [FieldOffset(8)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(24)]
      public ComponentDataFromEntity<Movement> _ComponentDataFromEntity_Movement_0;
      [FieldOffset(56)]
      public ComponentDataFromEntity<AbilityState> _ComponentDataFromEntity_AbilityState_1;
      [FieldOffset(88)]
      public ComponentDataFromEntity<ModifyMovementDuringCastData> _ComponentDataFromEntity_ModifyMovementDuringCastData_2;
      [FieldOffset(120)]
      public AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(160)]
      public unsafe AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365343, XrefRangeEnd = 1365368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ModifyMovementDuringCastActive modifyMovementDuringCastActive)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyMovementDuringCastActive;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365368, RefRangeEnd = 1365369, XrefRangeStart = 1365368, XrefRangeEnd = 1365368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1364056, RefRangeEnd = 1364059, XrefRangeStart = 1364056, XrefRangeEnd = 1364059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365369, XrefRangeEnd = 1365371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365377, RefRangeEnd = 1365378, XrefRangeStart = 1365371, XrefRangeEnd = 1365377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1365389, RefRangeEnd = 1365390, XrefRangeStart = 1365378, XrefRangeEnd = 1365389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityModifyMovementDuringCastSystem_Shared componentSystem,
        ref AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass7_4 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365390, XrefRangeEnd = 1365394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365394, XrefRangeEnd = 1365400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (serverTime));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_Movement_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_Movement_0));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityState_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityState_1));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_ModifyMovementDuringCastData_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_ModifyMovementDuringCastData_2));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyMovementDuringCastActive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663870);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663871);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663872);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663873);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663874);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_byref___c__DisplayClass7_4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663875);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663876);
        AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663877);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifyMovementDuringCastActive;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ModifyMovementDuringCastActive> forParameter_modifyMovementDuringCastActive;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365262, RefRangeEnd = 1365263, XrefRangeStart = 1365258, XrefRangeEnd = 1365262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityModifyMovementDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365267, RefRangeEnd = 1365268, XrefRangeStart = 1365263, XrefRangeEnd = 1365267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifyMovementDuringCastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifyMovementDuringCastActive));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyMovementDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100663878);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100663879);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifyMovementDuringCastActive;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ModifyMovementDuringCastActive>.Runtime runtime_modifyMovementDuringCastActive;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifyMovementDuringCastActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifyMovementDuringCastActive));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_00000147$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000147$PostfixBurstDelegate");
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663880);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663881);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663882);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663883);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyMovementDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_00000147$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365268, XrefRangeEnd = 1365282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365282, XrefRangeEnd = 1365300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365300, XrefRangeEnd = 1365315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1365342, RefRangeEnd = 1365343, XrefRangeStart = 1365315, XrefRangeEnd = 1365342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000147$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663884);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663885);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663886);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663887);
          AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663889);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyMovementDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
