// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroSystem
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class AggroSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__DayNightCycleAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__FactionLookupSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Remove_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ServantRemoveAllies_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ServantRemoveAllies_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddNewFromVicinity_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddNewFromAlert_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CalculateAggroValues_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SortAndSetTarget_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindCurrentAggroTarget_Private_Static_Boolean_Entity_DynamicBuffer_1_AggroBuffer_byref_AggroBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemove_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForServantRemoveAllies_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromVicinity_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromAlert_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCalculateAggroValues_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSortAndSetTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321651, XrefRangeEnd = 1321665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AggroSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321665, XrefRangeEnd = 1321731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AggroSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1321740, RefRangeEnd = 1321741, XrefRangeStart = 1321731, XrefRangeEnd = 1321740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindCurrentAggroTarget(
      Entity currentTarget,
      DynamicBuffer<AggroBuffer> aggroBuffer,
      out AggroBuffer result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &currentTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aggroBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr_TryFindCurrentAggroTarget_Private_Static_Boolean_Entity_DynamicBuffer_1_AggroBuffer_byref_AggroBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321741, XrefRangeEnd = 1321748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TimeOfDay GetTimeOfDay()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TimeOfDay*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AggroSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321748, XrefRangeEnd = 1321831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AggroSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321831, XrefRangeEnd = 1321850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321850, XrefRangeEnd = 1321869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1321894, RefRangeEnd = 1321895, XrefRangeStart = 1321869, XrefRangeEnd = 1321894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemove_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemove_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1321926, RefRangeEnd = 1321927, XrefRangeStart = 1321895, XrefRangeEnd = 1321926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForServantRemoveAllies_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForServantRemoveAllies_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1321970, RefRangeEnd = 1321971, XrefRangeStart = 1321927, XrefRangeEnd = 1321970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAddNewFromVicinity_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromVicinity_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1322002, RefRangeEnd = 1322003, XrefRangeStart = 1321971, XrefRangeEnd = 1322002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAddNewFromAlert_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromAlert_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1322043, RefRangeEnd = 1322044, XrefRangeStart = 1322003, XrefRangeEnd = 1322043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCalculateAggroValues_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForCalculateAggroValues_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1322069, RefRangeEnd = 1322070, XrefRangeStart = 1322044, XrefRangeEnd = 1322069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSortAndSetTarget_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForSortAndSetTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322070, XrefRangeEnd = 1322074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322074, XrefRangeEnd = 1322078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AggroSystem()
    {
      Il2CppClassPointerStore<AggroSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (AggroSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr);
      AggroSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      AggroSystem.NativeFieldInfoPtr__DayNightCycleAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, nameof (_DayNightCycleAccessor));
      AggroSystem.NativeFieldInfoPtr__FactionLookupSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, nameof (_FactionLookupSystem));
      AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      AggroSystem.NativeFieldInfoPtr___Remove_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>Remove_entityQuery");
      AggroSystem.NativeFieldInfoPtr___ServantRemoveAllies_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>ServantRemoveAllies_entityQuery");
      AggroSystem.NativeFieldInfoPtr___ServantRemoveAllies_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>ServantRemoveAllies_profilerMarker");
      AggroSystem.NativeFieldInfoPtr___AddNewFromVicinity_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>AddNewFromVicinity_entityQuery");
      AggroSystem.NativeFieldInfoPtr___AddNewFromAlert_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>AddNewFromAlert_entityQuery");
      AggroSystem.NativeFieldInfoPtr___CalculateAggroValues_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>CalculateAggroValues_entityQuery");
      AggroSystem.NativeFieldInfoPtr___SortAndSetTarget_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>SortAndSetTarget_entityQuery");
      AggroSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DayNightCycle_0));
      AggroSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663369);
      AggroSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663370);
      AggroSystem.NativeMethodInfoPtr_TryFindCurrentAggroTarget_Private_Static_Boolean_Entity_DynamicBuffer_1_AggroBuffer_byref_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663371);
      AggroSystem.NativeMethodInfoPtr_GetTimeOfDay_Private_TimeOfDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663372);
      AggroSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663373);
      AggroSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663374);
      AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663375);
      AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663376);
      AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemove_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663377);
      AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForServantRemoveAllies_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663378);
      AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromVicinity_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663379);
      AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddNewFromAlert_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663380);
      AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForCalculateAggroValues_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663381);
      AggroSystem.NativeMethodInfoPtr___GetEntityQuery_ForSortAndSetTarget_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663382);
      AggroSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663383);
      AggroSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, 100663384);
    }

    public AggroSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<DayNightCycle> _DayNightCycleAccessor
    {
      get
      {
        return *(SingletonAccessor<DayNightCycle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr__DayNightCycleAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr__DayNightCycleAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<DayNightCycle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FactionLookupSystem _FactionLookupSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr__FactionLookupSystem));
        return pointer == System.IntPtr.Zero ? (FactionLookupSystem) null : new FactionLookupSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr__FactionLookupSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __Remove_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___Remove_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___Remove_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __ServantRemoveAllies_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___ServantRemoveAllies_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___ServantRemoveAllies_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ServantRemoveAllies_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___ServantRemoveAllies_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___ServantRemoveAllies_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __AddNewFromVicinity_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___AddNewFromVicinity_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___AddNewFromVicinity_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __AddNewFromAlert_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___AddNewFromAlert_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___AddNewFromAlert_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __CalculateAggroValues_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___CalculateAggroValues_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___CalculateAggroValues_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __SortAndSetTarget_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___SortAndSetTarget_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr___SortAndSetTarget_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DayNightCycle_0
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_0));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_0)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_timeOfDay;
      private static readonly System.IntPtr NativeFieldInfoPtr_aggroMultiplierLookup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_Translation_byref_Rotation_byref_GainAggroByVicinity_byref_AggroModifiers_byref_DynamicBuffer_1_AggroCandidateBufferElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_DynamicBuffer_1_AggroDamageHistoryBufferElement_byref_DynamicBuffer_1_ExternalAggroBufferElement_byref_AggroDamageHistoryConfig_byref_AggroConsumer_byref_Translation_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        ref AggroConsumer aggroConsumer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        ref AggroConsumer aggroConsumer,
        [In] ref Team team)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_Team_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        Entity entity,
        ref AggroConsumer consumer,
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref GainAggroByVicinity gainAggroByVicinity,
        [In] ref AggroModifiers aggroModifiers,
        [In] ref DynamicBuffer<AggroCandidateBufferElement> aggroCandidateBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref gainAggroByVicinity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroModifiers;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroCandidateBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_Translation_byref_Rotation_byref_GainAggroByVicinity_byref_AggroModifiers_byref_DynamicBuffer_1_AggroCandidateBufferElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__6(
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref DynamicBuffer<AggroDamageHistoryBufferElement> damageHistoryBuffer,
        [In] ref DynamicBuffer<ExternalAggroBufferElement> externalAggroBuffer,
        [In] ref AggroDamageHistoryConfig damageHistoryConfig,
        [In] ref AggroConsumer aggroConsumer,
        [In] ref Translation translation,
        [In] ref Team team)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref damageHistoryBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref externalAggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref damageHistoryConfig;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_DynamicBuffer_1_AggroDamageHistoryBufferElement_byref_DynamicBuffer_1_ExternalAggroBufferElement_byref_AggroDamageHistoryConfig_byref_AggroConsumer_byref_Translation_byref_Team_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__7(
        Entity entity,
        ref AggroConsumer consumer,
        ref DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr);
        AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
        AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (serverTime));
        AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (timeOfDay));
        AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_aggroMultiplierLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (aggroMultiplierLookup));
        AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, 100663385);
        AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, 100663386);
        AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, 100663387);
        AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_Translation_byref_Rotation_byref_GainAggroByVicinity_byref_AggroModifiers_byref_DynamicBuffer_1_AggroCandidateBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, 100663388);
        AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_DynamicBuffer_1_AggroDamageHistoryBufferElement_byref_DynamicBuffer_1_ExternalAggroBufferElement_byref_AggroDamageHistoryConfig_byref_AggroConsumer_byref_Translation_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, 100663389);
        AggroSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__7_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, 100663390);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass4_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass4_0>.NativeClassPtr, data));
      }

      public unsafe AggroSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AggroSystem) null : new AggroSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe TimeOfDay timeOfDay
      {
        get
        {
          return *(TimeOfDay*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_timeOfDay));
        }
        [param: In] set
        {
          *(TimeOfDay*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_timeOfDay)) = value;
        }
      }

      public unsafe NativeArray<float> aggroMultiplierLookup
      {
        get
        {
          return *(NativeArray<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_aggroMultiplierLookup));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_aggroMultiplierLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_5;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_0_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_1_Internal_Void_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_5_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_GainAggroByAlert_byref_DynamicBuffer_1_AlertBuffer_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4_0(
        ref AggroConsumer aggroConsumer,
        ref DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c.NativeMethodInfoPtr__OnUpdate_b__4_0_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4_1(DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c.NativeMethodInfoPtr__OnUpdate_b__4_1_Internal_Void_DynamicBuffer_1_AggroBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4_5(
        ref AggroConsumer consumer,
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref GainAggroByAlert gainAggroByAlert,
        [In] ref DynamicBuffer<AlertBuffer> alertBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gainAggroByAlert;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c.NativeMethodInfoPtr__OnUpdate_b__4_5_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_GainAggroByAlert_byref_DynamicBuffer_1_AlertBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr);
        AggroSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr, "<>9");
        AggroSystem.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr, "<>9__4_0");
        AggroSystem.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr, "<>9__4_1");
        AggroSystem.__c.NativeFieldInfoPtr___9__4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr, "<>9__4_5");
        AggroSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr, 100663392);
        AggroSystem.__c.NativeMethodInfoPtr__OnUpdate_b__4_0_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr, 100663393);
        AggroSystem.__c.NativeMethodInfoPtr__OnUpdate_b__4_1_Internal_Void_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr, 100663394);
        AggroSystem.__c.NativeMethodInfoPtr__OnUpdate_b__4_5_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_GainAggroByAlert_byref_DynamicBuffer_1_AlertBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c>.NativeClassPtr, 100663395);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe AggroSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (AggroSystem.__c) null : new AggroSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RR<AggroConsumer, DynamicBuffer<AggroBuffer>> __9__4_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RR<AggroConsumer, DynamicBuffer<AggroBuffer>>) null : new RR<AggroConsumer, DynamicBuffer<AggroBuffer>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe V<DynamicBuffer<AggroBuffer>> __9__4_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c.NativeFieldInfoPtr___9__4_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (V<DynamicBuffer<AggroBuffer>>) null : new V<DynamicBuffer<AggroBuffer>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c.NativeFieldInfoPtr___9__4_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RRII<AggroConsumer, DynamicBuffer<AggroBuffer>, GainAggroByAlert, DynamicBuffer<AlertBuffer>> __9__4_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c.NativeFieldInfoPtr___9__4_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RRII<AggroConsumer, DynamicBuffer<AggroBuffer>, GainAggroByAlert, DynamicBuffer<AlertBuffer>>) null : new RRII<AggroConsumer, DynamicBuffer<AggroBuffer>, GainAggroByAlert, DynamicBuffer<AlertBuffer>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c.NativeFieldInfoPtr___9__4_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320999, XrefRangeEnd = 1321007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref AggroConsumer aggroConsumer,
        ref DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321007, XrefRangeEnd = 1321009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321017, RefRangeEnd = 1321018, XrefRangeStart = 1321009, XrefRangeEnd = 1321017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321018, XrefRangeEnd = 1321019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321019, XrefRangeEnd = 1321023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321023, XrefRangeEnd = 1321029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663396);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663397);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663398);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663399);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663400);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663401);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1320916, RefRangeEnd = 1320917, XrefRangeStart = 1320910, XrefRangeEnd = 1320916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1320923, RefRangeEnd = 1320924, XrefRangeStart = 1320917, XrefRangeEnd = 1320923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663402);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663403);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
            AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_0000004E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000004E$PostfixBurstDelegate");
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663404);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663405);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663406);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663407);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_0000004E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320924, XrefRangeEnd = 1320938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320938, XrefRangeEnd = 1320956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320956, XrefRangeEnd = 1320971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1320998, RefRangeEnd = 1320999, XrefRangeStart = 1320971, XrefRangeEnd = 1320998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000004E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663408);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663409);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663410);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663411);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663413);
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
            IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
      [FieldOffset(0)]
      public AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321037, XrefRangeEnd = 1321040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AggroBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321040, XrefRangeEnd = 1321042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321047, RefRangeEnd = 1321048, XrefRangeStart = 1321042, XrefRangeEnd = 1321047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321049, RefRangeEnd = 1321050, XrefRangeStart = 1321048, XrefRangeEnd = 1321049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663414);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663415);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663416);
        AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100663417);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321032, RefRangeEnd = 1321033, XrefRangeStart = 1321029, XrefRangeEnd = 1321032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321036, RefRangeEnd = 1321037, XrefRangeStart = 1321033, XrefRangeEnd = 1321036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663418);
          AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663419);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_Remove")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Remove
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0;
      [FieldOffset(0)]
      public double serverTime;
      [FieldOffset(8)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_0;
      [FieldOffset(40)]
      public ComponentDataFromEntity<Aggroable> _ComponentDataFromEntity_Aggroable_1;
      [FieldOffset(72)]
      public ComponentDataFromEntity<Disabled> _ComponentDataFromEntity_Disabled_2;
      [FieldOffset(104)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_3;
      [FieldOffset(136)]
      public AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(208)]
      public unsafe AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321064, XrefRangeEnd = 1321095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        ref AggroConsumer aggroConsumer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 937891, RefRangeEnd = 937897, XrefRangeStart = 937891, XrefRangeEnd = 937897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321095, XrefRangeEnd = 1321097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321105, RefRangeEnd = 1321106, XrefRangeStart = 1321097, XrefRangeEnd = 1321105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321120, RefRangeEnd = 1321121, XrefRangeStart = 1321106, XrefRangeEnd = 1321120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AggroSystem componentSystem,
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Remove()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass_Remove");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr);
        AggroSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (serverTime));
        AggroSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_0));
        AggroSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_ComponentDataFromEntity_Aggroable_1));
        AggroSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_ComponentDataFromEntity_Disabled_2));
        AggroSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_3));
        AggroSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AggroSystem.__c__DisplayClass_Remove.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (_runtimes));
        AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663420);
        AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663421);
        AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663422);
        AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663423);
        AggroSystem.__c__DisplayClass_Remove.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, 100663424);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321056, RefRangeEnd = 1321057, XrefRangeStart = 1321050, XrefRangeEnd = 1321056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321063, RefRangeEnd = 1321064, XrefRangeStart = 1321057, XrefRangeEnd = 1321063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, 100663425);
          AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, 100663426);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
            AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_Remove.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_ServantRemoveAllies")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ServantRemoveAllies
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Team_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Team> _ComponentDataFromEntity_Team_0;
      [FieldOffset(32)]
      public AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(136)]
      public unsafe AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321216, XrefRangeEnd = 1321246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        ref AggroConsumer aggroConsumer,
        [In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321246, XrefRangeEnd = 1321248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321259, RefRangeEnd = 1321260, XrefRangeStart = 1321248, XrefRangeEnd = 1321259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321264, RefRangeEnd = 1321265, XrefRangeStart = 1321260, XrefRangeEnd = 1321264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AggroSystem componentSystem,
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321265, XrefRangeEnd = 1321269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321269, XrefRangeEnd = 1321275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ServantRemoveAllies()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass_ServantRemoveAllies");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr);
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr__ComponentDataFromEntity_Team_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, nameof (_ComponentDataFromEntity_Team_0));
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, nameof (_runtimes));
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_AggroConsumer_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, 100663427);
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, 100663428);
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, 100663429);
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, 100663430);
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, 100663431);
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, 100663432);
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, 100663433);
        AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, 100663434);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c__DisplayClass_ServantRemoveAllies.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321130, RefRangeEnd = 1321131, XrefRangeStart = 1321121, XrefRangeEnd = 1321130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321140, RefRangeEnd = 1321141, XrefRangeStart = 1321131, XrefRangeEnd = 1321140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders>.NativeClassPtr, 100663435);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders>.NativeClassPtr, 100663436);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;

          static Runtimes()
          {
            Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
            AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
            AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_ServantRemoveAllies/ProjectM.RunWithoutJobSystem_00000064$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, "RunWithoutJobSystem_00000064$PostfixBurstDelegate");
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663437);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663438);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663439);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663440);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_ServantRemoveAllies/ProjectM.RunWithoutJobSystem_00000064$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321141, XrefRangeEnd = 1321155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321155, XrefRangeEnd = 1321173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321173, XrefRangeEnd = 1321188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321215, RefRangeEnd = 1321216, XrefRangeStart = 1321188, XrefRangeEnd = 1321215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies>.NativeClassPtr, "RunWithoutJobSystem_00000064$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663441);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663442);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663443);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663444);
          AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663446);
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
            IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AggroSystem.__c__DisplayClass_ServantRemoveAllies.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_AddNewFromVicinity")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_AddNewFromVicinity
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_timeOfDay;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeState_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_GainAlertByVicinity_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_Translation_byref_Rotation_byref_GainAggroByVicinity_byref_AggroModifiers_byref_DynamicBuffer_1_AggroCandidateBufferElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0;
      [FieldOffset(0)]
      public TimeOfDay timeOfDay;
      [FieldOffset(8)]
      public ComponentDataFromEntity<BehaviourTreeState> _ComponentDataFromEntity_BehaviourTreeState_0;
      [FieldOffset(40)]
      public ComponentDataFromEntity<GainAlertByVicinity> _ComponentDataFromEntity_GainAlertByVicinity_1;
      [FieldOffset(72)]
      public ComponentDataFromEntity<Aggroable> _ComponentDataFromEntity_Aggroable_2;
      [FieldOffset(104)]
      public AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(352)]
      public unsafe AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321321, XrefRangeEnd = 1321349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref AggroConsumer consumer,
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref GainAggroByVicinity gainAggroByVicinity,
        [In] ref AggroModifiers aggroModifiers,
        [In] ref DynamicBuffer<AggroCandidateBufferElement> aggroCandidateBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref gainAggroByVicinity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroModifiers;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroCandidateBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_Translation_byref_Rotation_byref_GainAggroByVicinity_byref_AggroModifiers_byref_DynamicBuffer_1_AggroCandidateBufferElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321349, RefRangeEnd = 1321350, XrefRangeStart = 1321349, XrefRangeEnd = 1321349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321350, XrefRangeEnd = 1321352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321376, RefRangeEnd = 1321377, XrefRangeStart = 1321352, XrefRangeEnd = 1321376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321388, RefRangeEnd = 1321389, XrefRangeStart = 1321377, XrefRangeEnd = 1321388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AggroSystem componentSystem,
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AddNewFromVicinity()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass_AddNewFromVicinity");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr);
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (timeOfDay));
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__ComponentDataFromEntity_BehaviourTreeState_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_ComponentDataFromEntity_BehaviourTreeState_0));
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__ComponentDataFromEntity_GainAlertByVicinity_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_ComponentDataFromEntity_GainAlertByVicinity_1));
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_ComponentDataFromEntity_Aggroable_2));
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (_runtimes));
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_Translation_byref_Rotation_byref_GainAggroByVicinity_byref_AggroModifiers_byref_DynamicBuffer_1_AggroCandidateBufferElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663447);
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663448);
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663449);
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663450);
        AggroSystem.__c__DisplayClass_AddNewFromVicinity.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, 100663451);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_consumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_gainAggroByVicinity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroModifiers;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroCandidateBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_consumer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(144)]
        public LambdaParameterValueProvider_IComponentData<GainAggroByVicinity> forParameter_gainAggroByVicinity;
        [FieldOffset(176)]
        public LambdaParameterValueProvider_IComponentData<AggroModifiers> forParameter_aggroModifiers;
        [FieldOffset(208)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroCandidateBufferElement> forParameter_aggroCandidateBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321297, RefRangeEnd = 1321298, XrefRangeStart = 1321275, XrefRangeEnd = 1321297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321320, RefRangeEnd = 1321321, XrefRangeStart = 1321298, XrefRangeEnd = 1321320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_consumer));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_gainAggroByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_gainAggroByVicinity));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroModifiers));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroCandidateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroCandidateBuffer));
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, 100663452);
          AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, 100663453);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_consumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_gainAggroByVicinity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroModifiers;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroCandidateBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_consumer;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<GainAggroByVicinity>.Runtime runtime_gainAggroByVicinity;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<AggroModifiers>.Runtime runtime_aggroModifiers;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroCandidateBufferElement>.Runtime runtime_aggroCandidateBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_consumer));
            AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
            AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_gainAggroByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_gainAggroByVicinity));
            AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroModifiers));
            AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroCandidateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroCandidateBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromVicinity.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_AddNewFromAlert")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_AddNewFromAlert
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_GainAggroByAlert_byref_DynamicBuffer_1_AlertBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
      [FieldOffset(0)]
      public AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(144)]
      public unsafe AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321415, XrefRangeEnd = 1321422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref AggroConsumer consumer,
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref GainAggroByAlert gainAggroByAlert,
        [In] ref DynamicBuffer<AlertBuffer> alertBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gainAggroByAlert;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref alertBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_GainAggroByAlert_byref_DynamicBuffer_1_AlertBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321422, XrefRangeEnd = 1321424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321438, RefRangeEnd = 1321439, XrefRangeStart = 1321424, XrefRangeEnd = 1321438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321440, RefRangeEnd = 1321441, XrefRangeStart = 1321439, XrefRangeEnd = 1321440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AddNewFromAlert()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass_AddNewFromAlert");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr);
        AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr, nameof (_runtimes));
        AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_byref_GainAggroByAlert_byref_DynamicBuffer_1_AlertBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr, 100663454);
        AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr, 100663455);
        AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr, 100663456);
        AggroSystem.__c__DisplayClass_AddNewFromAlert.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr, 100663457);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_consumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_gainAggroByAlert;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_alertBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_consumer;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<GainAggroByAlert> forParameter_gainAggroByAlert;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer> forParameter_alertBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321401, RefRangeEnd = 1321402, XrefRangeStart = 1321389, XrefRangeEnd = 1321401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321414, RefRangeEnd = 1321415, XrefRangeStart = 1321402, XrefRangeEnd = 1321414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_consumer));
          AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_gainAggroByAlert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_gainAggroByAlert));
          AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_alertBuffer));
          AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr, 100663458);
          AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr, 100663459);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_consumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_gainAggroByAlert;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_alertBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_consumer;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<GainAggroByAlert>.Runtime runtime_gainAggroByAlert;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_DynamicBuffer<AlertBuffer>.Runtime runtime_alertBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_consumer));
            AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
            AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_gainAggroByAlert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_gainAggroByAlert));
            AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_alertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_alertBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_AddNewFromAlert.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_CalculateAggroValues")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CalculateAggroValues
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_aggroMultiplierLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Team_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_DynamicBuffer_1_AggroDamageHistoryBufferElement_byref_DynamicBuffer_1_ExternalAggroBufferElement_byref_AggroDamageHistoryConfig_byref_AggroConsumer_byref_Translation_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0;
      [FieldOffset(0)]
      public NativeArray<float> aggroMultiplierLookup;
      [FieldOffset(16)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(48)]
      public ComponentDataFromEntity<Team> _ComponentDataFromEntity_Team_1;
      [FieldOffset(80)]
      public ComponentDataFromEntity<Aggroable> _ComponentDataFromEntity_Aggroable_2;
      [FieldOffset(112)]
      public AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(360)]
      public unsafe AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321485, XrefRangeEnd = 1321526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<AggroBuffer> aggroBuffer,
        [In] ref DynamicBuffer<AggroDamageHistoryBufferElement> damageHistoryBuffer,
        [In] ref DynamicBuffer<ExternalAggroBufferElement> externalAggroBuffer,
        [In] ref AggroDamageHistoryConfig damageHistoryConfig,
        [In] ref AggroConsumer aggroConsumer,
        [In] ref Translation translation,
        [In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref aggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref damageHistoryBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref externalAggroBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref damageHistoryConfig;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_DynamicBuffer_1_AggroDamageHistoryBufferElement_byref_DynamicBuffer_1_ExternalAggroBufferElement_byref_AggroDamageHistoryConfig_byref_AggroConsumer_byref_Translation_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 999309, RefRangeEnd = 999314, XrefRangeStart = 999309, XrefRangeEnd = 999314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321526, XrefRangeEnd = 1321528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321551, RefRangeEnd = 1321552, XrefRangeStart = 1321528, XrefRangeEnd = 1321551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321563, RefRangeEnd = 1321564, XrefRangeStart = 1321552, XrefRangeEnd = 1321563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AggroSystem componentSystem,
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CalculateAggroValues()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass_CalculateAggroValues");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr);
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeFieldInfoPtr_aggroMultiplierLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, nameof (aggroMultiplierLookup));
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeFieldInfoPtr__ComponentDataFromEntity_Team_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, nameof (_ComponentDataFromEntity_Team_1));
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, nameof (_ComponentDataFromEntity_Aggroable_2));
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, nameof (_runtimes));
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_AggroBuffer_byref_DynamicBuffer_1_AggroDamageHistoryBufferElement_byref_DynamicBuffer_1_ExternalAggroBufferElement_byref_AggroDamageHistoryConfig_byref_AggroConsumer_byref_Translation_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, 100663460);
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, 100663461);
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, 100663462);
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, 100663463);
        AggroSystem.__c__DisplayClass_CalculateAggroValues.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, 100663464);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_damageHistoryBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_externalAggroBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_damageHistoryConfig;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroDamageHistoryBufferElement> forParameter_damageHistoryBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_DynamicBuffer<ExternalAggroBufferElement> forParameter_externalAggroBuffer;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_IComponentData<AggroDamageHistoryConfig> forParameter_damageHistoryConfig;
        [FieldOffset(152)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;
        [FieldOffset(184)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(216)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321462, RefRangeEnd = 1321463, XrefRangeStart = 1321441, XrefRangeEnd = 1321462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321484, RefRangeEnd = 1321485, XrefRangeStart = 1321463, XrefRangeEnd = 1321484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_damageHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_damageHistoryBuffer));
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_externalAggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_externalAggroBuffer));
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_damageHistoryConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_damageHistoryConfig));
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, 100663465);
          AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, 100663466);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_damageHistoryBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_externalAggroBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_damageHistoryConfig;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroDamageHistoryBufferElement>.Runtime runtime_damageHistoryBuffer;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_DynamicBuffer<ExternalAggroBufferElement>.Runtime runtime_externalAggroBuffer;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<AggroDamageHistoryConfig>.Runtime runtime_damageHistoryConfig;
          [FieldOffset(80)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(96)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;

          static Runtimes()
          {
            Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
            AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_damageHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_damageHistoryBuffer));
            AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_externalAggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_externalAggroBuffer));
            AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_damageHistoryConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_damageHistoryConfig));
            AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
            AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_CalculateAggroValues.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AggroSystem/ProjectM.<>c__DisplayClass_SortAndSetTarget")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SortAndSetTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0;
      [FieldOffset(0)]
      public double serverTime;
      [FieldOffset(8)]
      public ComponentDataFromEntity<Aggroable> _ComponentDataFromEntity_Aggroable_0;
      [FieldOffset(40)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_1;
      [FieldOffset(72)]
      public ComponentDataFromEntity<AbilityBar_Shared> _ComponentDataFromEntity_AbilityBar_Shared_2;
      [FieldOffset(104)]
      public AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(184)]
      public unsafe AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321580, XrefRangeEnd = 1321627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref AggroConsumer consumer,
        ref DynamicBuffer<AggroBuffer> aggroBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref consumer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 937891, RefRangeEnd = 937897, XrefRangeStart = 937891, XrefRangeEnd = 937897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321627, XrefRangeEnd = 1321629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321638, RefRangeEnd = 1321639, XrefRangeStart = 1321629, XrefRangeEnd = 1321638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1321650, RefRangeEnd = 1321651, XrefRangeStart = 1321639, XrefRangeEnd = 1321650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AggroSystem componentSystem,
        ref AggroSystem.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SortAndSetTarget()
      {
        Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem>.NativeClassPtr, "<>c__DisplayClass_SortAndSetTarget");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr);
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (serverTime));
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeFieldInfoPtr__ComponentDataFromEntity_Aggroable_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (_ComponentDataFromEntity_Aggroable_0));
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_1));
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityBar_Shared_2));
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (_runtimes));
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AggroConsumer_byref_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663467);
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663468);
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663469);
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663470);
        AggroSystem.__c__DisplayClass_SortAndSetTarget.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, 100663471);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_consumer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_consumer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer> forParameter_aggroBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321571, RefRangeEnd = 1321572, XrefRangeStart = 1321564, XrefRangeEnd = 1321571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AggroSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1321579, RefRangeEnd = 1321580, XrefRangeStart = 1321572, XrefRangeEnd = 1321579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_consumer));
          AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroBuffer));
          AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AggroSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, 100663472);
          AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, 100663473);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_consumer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_consumer;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<AggroBuffer>.Runtime runtime_aggroBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_consumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_consumer));
            AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroSystem.__c__DisplayClass_SortAndSetTarget.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
