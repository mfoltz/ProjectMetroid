// Decompiled with JetBrains decompiler
// Type: ProjectM.AlertSystem
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class AlertSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___Remove_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AggregateRadii_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddNewFromVicinity_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CalculateAlertValues_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SortAndSetTarget_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInRange_Private_Static_Boolean_byref_GainAlertByVicinity_byref_float3_byref_Aggroable_byref_float3_byref_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemove_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAggregateRadii_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromVicinity_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCalculateAlertValues_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSortAndSetTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323475, XrefRangeEnd = 1323526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AlertSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1323532, RefRangeEnd = 1323534, XrefRangeStart = 1323526, XrefRangeEnd = 1323532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInRange(
      [In] ref GainAlertByVicinity gainAlertByVicinity,
      [In] ref float3 candidatePosition,
      [In] ref Aggroable candidateAggroable,
      [In] ref float3 consumerPosition,
      [In] ref float3 consumerDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref gainAlertByVicinity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref candidatePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref candidateAggroable;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumerPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumerDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr_IsInRange_Private_Static_Boolean_byref_GainAlertByVicinity_byref_float3_byref_Aggroable_byref_float3_byref_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323534, XrefRangeEnd = 1323541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TimeOfDay GetTimeOfDay()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TimeOfDay*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AlertSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323541, XrefRangeEnd = 1323589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AlertSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323589, XrefRangeEnd = 1323608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1323636, RefRangeEnd = 1323637, XrefRangeStart = 1323608, XrefRangeEnd = 1323636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemove_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemove_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1323662, RefRangeEnd = 1323663, XrefRangeStart = 1323637, XrefRangeEnd = 1323662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAggregateRadii_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForAggregateRadii_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1323709, RefRangeEnd = 1323710, XrefRangeStart = 1323663, XrefRangeEnd = 1323709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAddNewFromVicinity_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromVicinity_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1323750, RefRangeEnd = 1323751, XrefRangeStart = 1323710, XrefRangeEnd = 1323750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCalculateAlertValues_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForCalculateAlertValues_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1323776, RefRangeEnd = 1323777, XrefRangeStart = 1323751, XrefRangeEnd = 1323776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSortAndSetTarget_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForSortAndSetTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323777, XrefRangeEnd = 1323781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AlertSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AlertSystem()
    {
      Il2CppClassPointerStore<AlertSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (AlertSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr);
      AlertSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      AlertSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      AlertSystem.NativeFieldInfoPtr___Remove_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>Remove_entityQuery");
      AlertSystem.NativeFieldInfoPtr___AggregateRadii_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>AggregateRadii_entityQuery");
      AlertSystem.NativeFieldInfoPtr___AddNewFromVicinity_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>AddNewFromVicinity_entityQuery");
      AlertSystem.NativeFieldInfoPtr___CalculateAlertValues_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>CalculateAlertValues_entityQuery");
      AlertSystem.NativeFieldInfoPtr___SortAndSetTarget_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>SortAndSetTarget_entityQuery");
      AlertSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DayNightCycle_3));
      AlertSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663578);
      AlertSystem.NativeMethodInfoPtr_IsInRange_Private_Static_Boolean_byref_GainAlertByVicinity_byref_float3_byref_Aggroable_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663579);
      AlertSystem.NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663580);
      AlertSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663581);
      AlertSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663582);
      AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663583);
      AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemove_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663584);
      AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForAggregateRadii_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663585);
      AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromVicinity_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663586);
      AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForCalculateAlertValues_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663587);
      AlertSystem.NativeMethodInfoPtr___GetEntityQuery_ForSortAndSetTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663588);
      AlertSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, 100663589);
    }

    public AlertSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __Remove_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___Remove_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___Remove_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __AggregateRadii_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___AggregateRadii_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___AggregateRadii_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __AddNewFromVicinity_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___AddNewFromVicinity_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___AddNewFromVicinity_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __CalculateAlertValues_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___CalculateAlertValues_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___CalculateAlertValues_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __SortAndSetTarget_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___SortAndSetTarget_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr___SortAndSetTarget_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DayNightCycle_3
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_3));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_3)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AlertSystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_timeOfDay;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_AlertBuffer_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_GainAlertByVicinity_byref_AlertModifiers_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_AlertBuffer_byref_GainAlertByVicinity_byref_AggroConsumer_byref_Rotation_byref_DynamicBuffer_1_AggroCandidateBufferElement_byref_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_DynamicBuffer_1_AlertBuffer_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_GainAlertByVicinity_byref_AlertModifiers_byref_Translation_byref_Rotation_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        ref DynamicBuffer<AlertBuffer> alertBuffer,
        [In] ref AggroConsumer aggroConsumer,
        [In] ref DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref alertBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_AlertBuffer_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        ref GainAlertByVicinity gainAlertByVicinity,
        [In] ref AlertModifiers alertModifiers)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref gainAlertByVicinity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertModifiers;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_GainAlertByVicinity_byref_AlertModifiers_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        ref DynamicBuffer<AlertBuffer> alertBuffer,
        ref GainAlertByVicinity gainAlertByVicinity,
        [In] ref AggroConsumer consumer,
        [In] ref Rotation rotation,
        [In] ref DynamicBuffer<AggroCandidateBufferElement> aggroCandidateBuffer,
        [In] ref DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gainAlertByVicinity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroCandidateBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_AlertBuffer_byref_GainAlertByVicinity_byref_AggroConsumer_byref_Rotation_byref_DynamicBuffer_1_AggroCandidateBufferElement_byref_DynamicBuffer_1_AggroBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        DynamicBuffer<AlertBuffer> alertBuffer,
        DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref AggroConsumer aggroConsumer,
        [In] ref GainAlertByVicinity gainAlertByVicinity,
        [In] ref AlertModifiers alertModifiers,
        [In] ref Translation translation,
        [In] ref Rotation rotation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &alertBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref gainAlertByVicinity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertModifiers;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_DynamicBuffer_1_AlertBuffer_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_GainAlertByVicinity_byref_AlertModifiers_byref_Translation_byref_Rotation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr);
        AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (timeOfDay));
        AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (deltaTime));
        AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, 100663590);
        AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_AlertBuffer_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, 100663591);
        AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_GainAlertByVicinity_byref_AlertModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, 100663592);
        AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_AlertBuffer_byref_GainAlertByVicinity_byref_AggroConsumer_byref_Rotation_byref_DynamicBuffer_1_AggroCandidateBufferElement_byref_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, 100663593);
        AlertSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_DynamicBuffer_1_AlertBuffer_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_GainAlertByVicinity_byref_AlertModifiers_byref_Translation_byref_Rotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, 100663594);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass0_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass0_0>.NativeClassPtr, data));
      }

      public unsafe AlertSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AlertSystem) null : new AlertSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TimeOfDay timeOfDay
      {
        get
        {
          return *(TimeOfDay*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_timeOfDay));
        }
        [param: In] set
        {
          *(TimeOfDay*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_timeOfDay)) = value;
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AlertSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.AlertSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0_5;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_5_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0_0(
        ref AggroConsumer aggroConsumer,
        ref DynamicBuffer<AlertBuffer> alertBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0_5(
        ref AggroConsumer consumer,
        ref DynamicBuffer<AlertBuffer> alertBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_5_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr);
        AlertSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr, "<>9");
        AlertSystem.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr, "<>9__0_0");
        AlertSystem.__c.NativeFieldInfoPtr___9__0_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr, "<>9__0_5");
        AlertSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr, 100663596);
        AlertSystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_0_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr, 100663597);
        AlertSystem.__c.NativeMethodInfoPtr__OnUpdate_b__0_5_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c>.NativeClassPtr, 100663598);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe AlertSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AlertSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (AlertSystem.__c) null : new AlertSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AlertSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RR<AggroConsumer, DynamicBuffer<AlertBuffer>> __9__0_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AlertSystem.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RR<AggroConsumer, DynamicBuffer<AlertBuffer>>) null : new RR<AggroConsumer, DynamicBuffer<AlertBuffer>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AlertSystem.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RR<AggroConsumer, DynamicBuffer<AlertBuffer>> __9__0_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AlertSystem.__c.NativeFieldInfoPtr___9__0_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RR<AggroConsumer, DynamicBuffer<AlertBuffer>>) null : new RR<AggroConsumer, DynamicBuffer<AlertBuffer>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AlertSystem.__c.NativeFieldInfoPtr___9__0_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.AlertSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323092, XrefRangeEnd = 1323100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref AggroConsumer aggroConsumer,
        ref DynamicBuffer<AlertBuffer> alertBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323100, XrefRangeEnd = 1323102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323110, RefRangeEnd = 1323111, XrefRangeStart = 1323102, XrefRangeEnd = 1323110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323111, XrefRangeEnd = 1323112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(AlertSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323112, XrefRangeEnd = 1323116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323116, XrefRangeEnd = 1323122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663599);
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663600);
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663601);
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663602);
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663603);
        AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663604);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_alertBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer> forParameter_alertBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323009, RefRangeEnd = 1323010, XrefRangeStart = 1323003, XrefRangeEnd = 1323009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AlertSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323016, RefRangeEnd = 1323017, XrefRangeStart = 1323010, XrefRangeEnd = 1323016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_alertBuffer));
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663605);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663606);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_alertBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer>.Runtime runtime_alertBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
            AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_alertBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AlertSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_000000D2$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000000D2$PostfixBurstDelegate");
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663607);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663608);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663609);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663610);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AlertSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_000000D2$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323017, XrefRangeEnd = 1323031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323031, XrefRangeEnd = 1323049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323049, XrefRangeEnd = 1323064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323091, RefRangeEnd = 1323092, XrefRangeStart = 1323064, XrefRangeEnd = 1323091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000000D2$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663611);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663612);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663613);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663614);
          AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663616);
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
            IL2CPP.il2cpp_field_static_get_value(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AlertSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AlertSystem/ProjectM.<>c__DisplayClass_Remove")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Remove
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AlertBuffer_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Aggroable> _ComponentDataFromEntity_Aggroable_0;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Disabled> _ComponentDataFromEntity_Disabled_1;
      [FieldOffset(64)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_2;
      [FieldOffset(96)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_3;
      [FieldOffset(128)]
      public AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(240)]
      public unsafe AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323142, XrefRangeEnd = 1323172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<AlertBuffer> alertBuffer,
        [In] ref AggroConsumer aggroConsumer,
        [In] ref DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref alertBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AlertBuffer_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AlertSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323172, XrefRangeEnd = 1323174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323185, RefRangeEnd = 1323186, XrefRangeStart = 1323174, XrefRangeEnd = 1323185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323199, RefRangeEnd = 1323200, XrefRangeStart = 1323186, XrefRangeEnd = 1323199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AlertSystem componentSystem,
        ref AlertSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Remove()
      {
        Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>c__DisplayClass_Remove");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr);
        AlertSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_ComponentDataFromEntity_Aggroable_0));
        AlertSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_ComponentDataFromEntity_Disabled_1));
        AlertSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_2));
        AlertSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_3));
        AlertSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AlertSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_runtimes));
        AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AlertBuffer_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663617);
        AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663618);
        AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663619);
        AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663620);
        AlertSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663621);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_alertBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer> forParameter_alertBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323131, RefRangeEnd = 1323132, XrefRangeStart = 1323122, XrefRangeEnd = 1323131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AlertSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323141, RefRangeEnd = 1323142, XrefRangeStart = 1323132, XrefRangeEnd = 1323141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_alertBuffer));
          AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, 100663622);
          AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, 100663623);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_alertBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer>.Runtime runtime_alertBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_alertBuffer));
            AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
            AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AlertSystem/ProjectM.<>c__DisplayClass_AggregateRadii")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_AggregateRadii
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_timeOfDay;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_GainAlertByVicinity_byref_AlertModifiers_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0;
      [FieldOffset(0)]
      public TimeOfDay timeOfDay;
      [FieldOffset(8)]
      public AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323217, RefRangeEnd = 1323218, XrefRangeStart = 1323214, XrefRangeEnd = 1323217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref GainAlertByVicinity gainAlertByVicinity,
        [In] ref AlertModifiers alertModifiers)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref gainAlertByVicinity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertModifiers;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_GainAlertByVicinity_byref_AlertModifiers_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 1149759, RefRangeEnd = 1149767, XrefRangeStart = 1149759, XrefRangeEnd = 1149767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AlertSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323218, XrefRangeEnd = 1323220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323228, RefRangeEnd = 1323229, XrefRangeStart = 1323220, XrefRangeEnd = 1323228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323231, RefRangeEnd = 1323232, XrefRangeStart = 1323229, XrefRangeEnd = 1323231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AlertSystem componentSystem,
        ref AlertSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AggregateRadii()
      {
        Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>c__DisplayClass_AggregateRadii");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr);
        AlertSystem.__c__DisplayClass_AggregateRadii.NativeFieldInfoPtr_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, nameof (timeOfDay));
        AlertSystem.__c__DisplayClass_AggregateRadii.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AlertSystem.__c__DisplayClass_AggregateRadii.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, nameof (_runtimes));
        AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_GainAlertByVicinity_byref_AlertModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, 100663624);
        AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, 100663625);
        AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, 100663626);
        AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, 100663627);
        AlertSystem.__c__DisplayClass_AggregateRadii.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, 100663628);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_gainAlertByVicinity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_alertModifiers;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<GainAlertByVicinity> forParameter_gainAlertByVicinity;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<AlertModifiers> forParameter_alertModifiers;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323206, RefRangeEnd = 1323207, XrefRangeStart = 1323200, XrefRangeEnd = 1323206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AlertSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323213, RefRangeEnd = 1323214, XrefRangeStart = 1323207, XrefRangeEnd = 1323213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_gainAlertByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_gainAlertByVicinity));
          AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_alertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_alertModifiers));
          AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders>.NativeClassPtr, 100663629);
          AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders>.NativeClassPtr, 100663630);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_gainAlertByVicinity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_alertModifiers;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<GainAlertByVicinity>.Runtime runtime_gainAlertByVicinity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AlertModifiers>.Runtime runtime_alertModifiers;

          static Runtimes()
          {
            Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_gainAlertByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_gainAlertByVicinity));
            AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_alertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_alertModifiers));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AggregateRadii.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AlertSystem/ProjectM.<>c__DisplayClass_AddNewFromVicinity")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_AddNewFromVicinity
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AlertBuffer_byref_GainAlertByVicinity_byref_AggroConsumer_byref_Rotation_byref_DynamicBuffer_1_AggroCandidateBufferElement_byref_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Aggroable> _ComponentDataFromEntity_Aggroable_1;
      [FieldOffset(64)]
      public AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(288)]
      public unsafe AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323272, XrefRangeEnd = 1323291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<AlertBuffer> alertBuffer,
        ref GainAlertByVicinity gainAlertByVicinity,
        [In] ref AggroConsumer consumer,
        [In] ref Rotation rotation,
        [In] ref DynamicBuffer<AggroCandidateBufferElement> aggroCandidateBuffer,
        [In] ref DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gainAlertByVicinity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroCandidateBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AlertBuffer_byref_GainAlertByVicinity_byref_AggroConsumer_byref_Rotation_byref_DynamicBuffer_1_AggroCandidateBufferElement_byref_DynamicBuffer_1_AggroBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AlertSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323291, XrefRangeEnd = 1323293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323314, RefRangeEnd = 1323315, XrefRangeStart = 1323293, XrefRangeEnd = 1323314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323322, RefRangeEnd = 1323323, XrefRangeStart = 1323315, XrefRangeEnd = 1323322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AlertSystem componentSystem,
        ref AlertSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AddNewFromVicinity()
      {
        Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>c__DisplayClass_AddNewFromVicinity");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr);
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_ComponentDataFromEntity_Aggroable_1));
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_runtimes));
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_AlertBuffer_byref_GainAlertByVicinity_byref_AggroConsumer_byref_Rotation_byref_DynamicBuffer_1_AggroCandidateBufferElement_byref_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663631);
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663632);
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663633);
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663634);
        AlertSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663635);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_alertBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_gainAlertByVicinity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_consumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroCandidateBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer> forParameter_alertBuffer;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<GainAlertByVicinity> forParameter_gainAlertByVicinity;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_consumer;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(144)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroCandidateBufferElement> forParameter_aggroCandidateBuffer;
        [FieldOffset(184)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323251, RefRangeEnd = 1323252, XrefRangeStart = 1323232, XrefRangeEnd = 1323251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AlertSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323271, RefRangeEnd = 1323272, XrefRangeStart = 1323252, XrefRangeEnd = 1323271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_alertBuffer));
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_gainAlertByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_gainAlertByVicinity));
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_consumer));
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroCandidateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroCandidateBuffer));
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, 100663636);
          AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, 100663637);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_alertBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_gainAlertByVicinity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_consumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroCandidateBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer>.Runtime runtime_alertBuffer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<GainAlertByVicinity>.Runtime runtime_gainAlertByVicinity;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_consumer;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroCandidateBufferElement>.Runtime runtime_aggroCandidateBuffer;
          [FieldOffset(80)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_alertBuffer));
            AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_gainAlertByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_gainAlertByVicinity));
            AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_consumer));
            AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroCandidateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroCandidateBuffer));
            AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AlertSystem/ProjectM.<>c__DisplayClass_CalculateAlertValues")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CalculateAlertValues
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AlertBuffer_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_GainAlertByVicinity_byref_AlertModifiers_byref_Translation_byref_Rotation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(8)]
      public ComponentDataFromEntity<Aggroable> _ComponentDataFromEntity_Aggroable_0;
      [FieldOffset(40)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_1;
      [FieldOffset(72)]
      public AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(312)]
      public unsafe AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323367, XrefRangeEnd = 1323391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<AlertBuffer> alertBuffer,
        DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref AggroConsumer aggroConsumer,
        [In] ref GainAlertByVicinity gainAlertByVicinity,
        [In] ref AlertModifiers alertModifiers,
        [In] ref Translation translation,
        [In] ref Rotation rotation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &alertBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref gainAlertByVicinity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertModifiers;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AlertBuffer_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_GainAlertByVicinity_byref_AlertModifiers_byref_Translation_byref_Rotation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323391, RefRangeEnd = 1323392, XrefRangeStart = 1323391, XrefRangeEnd = 1323391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AlertSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323392, XrefRangeEnd = 1323394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323417, RefRangeEnd = 1323418, XrefRangeStart = 1323394, XrefRangeEnd = 1323417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323426, RefRangeEnd = 1323427, XrefRangeStart = 1323418, XrefRangeEnd = 1323426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AlertSystem componentSystem,
        ref AlertSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CalculateAlertValues()
      {
        Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>c__DisplayClass_CalculateAlertValues");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr);
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, nameof (deltaTime));
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, nameof (_ComponentDataFromEntity_Aggroable_0));
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_1));
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, nameof (_runtimes));
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AlertBuffer_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_GainAlertByVicinity_byref_AlertModifiers_byref_Translation_byref_Rotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, 100663638);
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, 100663639);
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, 100663640);
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, 100663641);
        AlertSystem.__c__DisplayClass_CalculateAlertValues.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, 100663642);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_alertBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_gainAlertByVicinity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_alertModifiers;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer> forParameter_alertBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_IComponentData<GainAlertByVicinity> forParameter_gainAlertByVicinity;
        [FieldOffset(144)]
        public LambdaParameterValueProvider_IComponentData<AlertModifiers> forParameter_alertModifiers;
        [FieldOffset(176)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(208)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323344, RefRangeEnd = 1323345, XrefRangeStart = 1323323, XrefRangeEnd = 1323344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AlertSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323366, RefRangeEnd = 1323367, XrefRangeStart = 1323345, XrefRangeEnd = 1323366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_alertBuffer));
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_gainAlertByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_gainAlertByVicinity));
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_alertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_alertModifiers));
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, 100663643);
          AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, 100663644);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_alertBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_gainAlertByVicinity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_alertModifiers;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer>.Runtime runtime_alertBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<GainAlertByVicinity>.Runtime runtime_gainAlertByVicinity;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<AlertModifiers>.Runtime runtime_alertModifiers;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(80)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;

          static Runtimes()
          {
            Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_alertBuffer));
            AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
            AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
            AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_gainAlertByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_gainAlertByVicinity));
            AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_alertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_alertModifiers));
            AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_CalculateAlertValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AlertSystem/ProjectM.<>c__DisplayClass_SortAndSetTarget")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SortAndSetTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0;
      [FieldOffset(0)]
      public AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323441, XrefRangeEnd = 1323462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref AggroConsumer consumer,
        ref DynamicBuffer<AlertBuffer> alertBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1323462, XrefRangeEnd = 1323464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323472, RefRangeEnd = 1323473, XrefRangeStart = 1323464, XrefRangeEnd = 1323472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1323474, RefRangeEnd = 1323475, XrefRangeStart = 1323473, XrefRangeEnd = 1323474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(AlertSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SortAndSetTarget()
      {
        Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem>.NativeClassPtr, "<>c__DisplayClass_SortAndSetTarget");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr);
        AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (_runtimes));
        AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AlertBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663645);
        AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663646);
        AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663647);
        AlertSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663648);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_consumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_alertBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_consumer;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer> forParameter_alertBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323433, RefRangeEnd = 1323434, XrefRangeStart = 1323427, XrefRangeEnd = 1323433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AlertSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1323440, RefRangeEnd = 1323441, XrefRangeStart = 1323434, XrefRangeEnd = 1323440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_consumer));
          AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_alertBuffer));
          AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AlertSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, 100663649);
          AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, 100663650);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_consumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_alertBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_consumer;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer>.Runtime runtime_alertBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_consumer));
            AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_alertBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlertSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
