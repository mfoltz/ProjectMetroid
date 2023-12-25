// Decompiled with JetBrains decompiler
// Type: ProjectM.AiPrioritizationSystem
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Behaviours;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class AiPrioritizationSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UserActivityGridSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__AiDebugEnabledAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__List;
    private static readonly System.IntPtr NativeFieldInfoPtr__Slice;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputJobHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_LOW_PRIORITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_HIGH_PRIORITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_ULTRA_HIGH_PRIORITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_HIGH_PRIO_DISTANCE;
    private static readonly System.IntPtr NativeFieldInfoPtr_HIGH_PRIO_DISTANCE_SQ;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameSkip_LastUpdatedFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr___Prioritization_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Prioritization_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___Sort_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateSliceAndSetUpdated_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DoDebugOnlyStuff_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DoDebugOnlyStuff_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugViewData_1;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugViewData_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesAsync_Public_NativeSlice_1_Entry_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntities_Public_NativeSlice_1_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoDebugOnlyStuff_Private_Void_NativeList_1_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPrioritization_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDoDebugOnlyStuff_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_3;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322723, XrefRangeEnd = 1322736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiPrioritizationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322736, XrefRangeEnd = 1322740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiPrioritizationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1322741, RefRangeEnd = 1322742, XrefRangeStart = 1322740, XrefRangeEnd = 1322741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeSlice<AiPrioritizationSystem.Entry> GetEntitiesAsync(
      out JobHandle dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref dependency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr_GetEntitiesAsync_Public_NativeSlice_1_Entry_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeSlice<AiPrioritizationSystem.Entry>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1322743, RefRangeEnd = 1322744, XrefRangeStart = 1322742, XrefRangeEnd = 1322743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddInputJobHandle(JobHandle inputDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputDeps;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322744, XrefRangeEnd = 1322745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeSlice<AiPrioritizationSystem.Entry> GetEntities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr_GetEntities_Public_NativeSlice_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeSlice<AiPrioritizationSystem.Entry>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322745, XrefRangeEnd = 1322820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiPrioritizationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1322835, RefRangeEnd = 1322836, XrefRangeStart = 1322820, XrefRangeEnd = 1322835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoDebugOnlyStuff(NativeList<AiPrioritizationSystem.Entry> list)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &list;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr_DoDebugOnlyStuff_Private_Void_NativeList_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AiPrioritizationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322836, XrefRangeEnd = 1322932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiPrioritizationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1322966, RefRangeEnd = 1322967, XrefRangeStart = 1322932, XrefRangeEnd = 1322966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPrioritization_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrioritization_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322967, XrefRangeEnd = 1322986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDoDebugOnlyStuff_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr___GetEntityQuery_ForDoDebugOnlyStuff_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322986, XrefRangeEnd = 1322990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322990, XrefRangeEnd = 1322994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322994, XrefRangeEnd = 1322998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322998, XrefRangeEnd = 1323002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AiPrioritizationSystem()
    {
      Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (AiPrioritizationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr);
      AiPrioritizationSystem.NativeFieldInfoPtr__UserActivityGridSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (_UserActivityGridSystem));
      AiPrioritizationSystem.NativeFieldInfoPtr__AiDebugEnabledAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (_AiDebugEnabledAccessor));
      AiPrioritizationSystem.NativeFieldInfoPtr__List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (_List));
      AiPrioritizationSystem.NativeFieldInfoPtr__Slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (_Slice));
      AiPrioritizationSystem.NativeFieldInfoPtr__InputJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (_InputJobHandle));
      AiPrioritizationSystem.NativeFieldInfoPtr_LOW_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (LOW_PRIORITY));
      AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (HIGH_PRIORITY));
      AiPrioritizationSystem.NativeFieldInfoPtr_ULTRA_HIGH_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (ULTRA_HIGH_PRIORITY));
      AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIO_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (HIGH_PRIO_DISTANCE));
      AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIO_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (HIGH_PRIO_DISTANCE_SQ));
      AiPrioritizationSystem.NativeFieldInfoPtr_FrameSkip_LastUpdatedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (FrameSkip_LastUpdatedFrame));
      AiPrioritizationSystem.NativeFieldInfoPtr___Prioritization_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>Prioritization_entityQuery");
      AiPrioritizationSystem.NativeFieldInfoPtr___Prioritization_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>Prioritization_profilerMarker");
      AiPrioritizationSystem.NativeFieldInfoPtr___Sort_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>Sort_profilerMarker");
      AiPrioritizationSystem.NativeFieldInfoPtr___CreateSliceAndSetUpdated_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>CreateSliceAndSetUpdated_profilerMarker");
      AiPrioritizationSystem.NativeFieldInfoPtr___DoDebugOnlyStuff_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>DoDebugOnlyStuff_LambdaJob0_entityQuery");
      AiPrioritizationSystem.NativeFieldInfoPtr___DoDebugOnlyStuff_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>DoDebugOnlyStuff_LambdaJob0_profilerMarker");
      AiPrioritizationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugViewData_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerDebugViewData_1));
      AiPrioritizationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugViewData_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerDebugViewData_2));
      AiPrioritizationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663481);
      AiPrioritizationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663482);
      AiPrioritizationSystem.NativeMethodInfoPtr_GetEntitiesAsync_Public_NativeSlice_1_Entry_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663483);
      AiPrioritizationSystem.NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663484);
      AiPrioritizationSystem.NativeMethodInfoPtr_GetEntities_Public_NativeSlice_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663485);
      AiPrioritizationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663486);
      AiPrioritizationSystem.NativeMethodInfoPtr_DoDebugOnlyStuff_Private_Void_NativeList_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663487);
      AiPrioritizationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663488);
      AiPrioritizationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663489);
      AiPrioritizationSystem.NativeMethodInfoPtr___GetEntityQuery_ForPrioritization_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663490);
      AiPrioritizationSystem.NativeMethodInfoPtr___GetEntityQuery_ForDoDebugOnlyStuff_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663491);
      AiPrioritizationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663492);
      AiPrioritizationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663493);
      AiPrioritizationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663494);
      AiPrioritizationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, 100663495);
    }

    public AiPrioritizationSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UserActivityGridSystem _UserActivityGridSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__UserActivityGridSystem));
        return pointer == System.IntPtr.Zero ? (UserActivityGridSystem) null : new UserActivityGridSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__UserActivityGridSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<AiDebugEnabled> _AiDebugEnabledAccessor
    {
      get
      {
        return *(SingletonAccessor<AiDebugEnabled>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__AiDebugEnabledAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__AiDebugEnabledAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<AiDebugEnabled>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<AiPrioritizationSystem.Entry> _List
    {
      get
      {
        return *(NativeList<AiPrioritizationSystem.Entry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__List));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__List), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<AiPrioritizationSystem.Entry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeSlice<AiPrioritizationSystem.Entry> _Slice
    {
      get
      {
        return *(NativeSlice<AiPrioritizationSystem.Entry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__Slice));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__Slice), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<AiPrioritizationSystem.Entry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe JobHandleManager _InputJobHandle
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__InputJobHandle));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__InputJobHandle)) = value;
      }
    }

    public static unsafe int LOW_PRIORITY
    {
      get
      {
        int lowPriority;
        IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.NativeFieldInfoPtr_LOW_PRIORITY, (void*) &lowPriority);
        return lowPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.NativeFieldInfoPtr_LOW_PRIORITY, (void*) &value);
      }
    }

    public static unsafe int HIGH_PRIORITY
    {
      get
      {
        int highPriority;
        IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIORITY, (void*) &highPriority);
        return highPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIORITY, (void*) &value);
      }
    }

    public static unsafe int ULTRA_HIGH_PRIORITY
    {
      get
      {
        int ultraHighPriority;
        IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.NativeFieldInfoPtr_ULTRA_HIGH_PRIORITY, (void*) &ultraHighPriority);
        return ultraHighPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.NativeFieldInfoPtr_ULTRA_HIGH_PRIORITY, (void*) &value);
      }
    }

    public static unsafe int HIGH_PRIO_DISTANCE
    {
      get
      {
        int highPrioDistance;
        IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIO_DISTANCE, (void*) &highPrioDistance);
        return highPrioDistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIO_DISTANCE, (void*) &value);
      }
    }

    public static unsafe int HIGH_PRIO_DISTANCE_SQ
    {
      get
      {
        int highPrioDistanceSq;
        IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIO_DISTANCE_SQ, (void*) &highPrioDistanceSq);
        return highPrioDistanceSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.NativeFieldInfoPtr_HIGH_PRIO_DISTANCE_SQ, (void*) &value);
      }
    }

    public unsafe int FrameSkip_LastUpdatedFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr_FrameSkip_LastUpdatedFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr_FrameSkip_LastUpdatedFrame)) = value;
      }
    }

    public unsafe EntityQuery __Prioritization_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___Prioritization_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___Prioritization_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Prioritization_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___Prioritization_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___Prioritization_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __Sort_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___Sort_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___Sort_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateSliceAndSetUpdated_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___CreateSliceAndSetUpdated_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___CreateSliceAndSetUpdated_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __DoDebugOnlyStuff_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___DoDebugOnlyStuff_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___DoDebugOnlyStuff_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DoDebugOnlyStuff_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___DoDebugOnlyStuff_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr___DoDebugOnlyStuff_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerDebugViewData_1
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugViewData_1));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugViewData_1)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerDebugViewData_2
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugViewData_2));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiPrioritizationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerDebugViewData_2)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Entry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
      private static readonly System.IntPtr NativeFieldInfoPtr_AccumulatedDeltaTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public float Priority;
      [FieldOffset(12)]
      public float AccumulatedDeltaTime;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322215, XrefRangeEnd = 1322216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(AiPrioritizationSystem.Entry other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.Entry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Entry()
      {
        Il2CppClassPointerStore<AiPrioritizationSystem.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, nameof (Entry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.Entry>.NativeClassPtr);
        AiPrioritizationSystem.Entry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.Entry>.NativeClassPtr, nameof (Entity));
        AiPrioritizationSystem.Entry.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.Entry>.NativeClassPtr, nameof (Priority));
        AiPrioritizationSystem.Entry.NativeFieldInfoPtr_AccumulatedDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.Entry>.NativeClassPtr, nameof (AccumulatedDeltaTime));
        AiPrioritizationSystem.Entry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.Entry>.NativeClassPtr, 100663496);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.Entry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AiPrioritizationSystem/<>c__DisplayClass17_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass17_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_userActivityGrid;
      private static readonly System.IntPtr NativeFieldInfoPtr_userList;
      private static readonly System.IntPtr NativeFieldInfoPtr_highPriorityCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_list;
      private static readonly System.IntPtr NativeFieldInfoPtr_slice;
      private static readonly System.IntPtr NativeFieldInfoPtr_aiUpdatesPerFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAiPrioritizationState;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AiPrioritization_State_byref_AiPrioritization_Data_byref_Translation_byref_BehaviourTreeState_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_0;
      [FieldOffset(0)]
      public UserActivityGrid userActivityGrid;
      [FieldOffset(144)]
      public NativeList<int> userList;
      [FieldOffset(160)]
      public int highPriorityCount;
      [FieldOffset(164)]
      public float deltaTime;
      [FieldOffset(168)]
      public NativeList<AiPrioritizationSystem.Entry> list;
      [FieldOffset(184)]
      public NativeSlice<AiPrioritizationSystem.Entry> slice;
      [FieldOffset(200)]
      public int aiUpdatesPerFrame;
      [FieldOffset(208)]
      public ComponentDataFromEntity<AiPrioritization_State> getAiPrioritizationState;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref AiPrioritization_State aiPrioritizationState,
        [In] ref AiPrioritization_Data aiPrioritizationData,
        [In] ref Translation translation,
        [In] ref BehaviourTreeState behaviourTreeState,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiPrioritizationState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiPrioritizationData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref behaviourTreeState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AiPrioritization_State_byref_AiPrioritization_Data_byref_Translation_byref_BehaviourTreeState_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr);
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_userActivityGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (userActivityGrid));
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_userList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (userList));
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_highPriorityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (highPriorityCount));
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (deltaTime));
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (list));
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (slice));
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_aiUpdatesPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (aiUpdatesPerFrame));
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getAiPrioritizationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (getAiPrioritizationState));
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, 100663497);
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AiPrioritization_State_byref_AiPrioritization_Data_byref_Translation_byref_BehaviourTreeState_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, 100663498);
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, 100663499);
        AiPrioritizationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, 100663500);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass17_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AiPrioritizationSystem/<>c__DisplayClass18_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass18_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_list;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DoDebugOnlyStuff_b__0_Internal_Void_Entity_0;
      [FieldOffset(0)]
      public NativeList<AiPrioritizationSystem.Entry> list;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass18_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _DoDebugOnlyStuff_b__0(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__DoDebugOnlyStuff_b__0_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass18_0()
      {
        Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>c__DisplayClass18_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass18_0>.NativeClassPtr);
        AiPrioritizationSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass18_0>.NativeClassPtr, nameof (list));
        AiPrioritizationSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass18_0>.NativeClassPtr, 100663501);
        AiPrioritizationSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__DoDebugOnlyStuff_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass18_0>.NativeClassPtr, 100663502);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass18_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_Prioritization")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Prioritization
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_userActivityGrid;
      private static readonly System.IntPtr NativeFieldInfoPtr_userList;
      private static readonly System.IntPtr NativeFieldInfoPtr_highPriorityCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_list;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AiPrioritization_State_byref_AiPrioritization_Data_byref_Translation_byref_BehaviourTreeState_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public UserActivityGrid userActivityGrid;
      [FieldOffset(144)]
      public NativeList<int> userList;
      [FieldOffset(160)]
      public int highPriorityCount;
      [FieldOffset(164)]
      public float deltaTime;
      [FieldOffset(168)]
      public NativeList<AiPrioritizationSystem.Entry> list;
      [FieldOffset(184)]
      public AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(352)]
      public unsafe AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322325, XrefRangeEnd = 1322332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref AiPrioritization_State aiPrioritizationState,
        [In] ref AiPrioritization_Data aiPrioritizationData,
        [In] ref Translation translation,
        [In] ref BehaviourTreeState behaviourTreeState,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiPrioritizationState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref aiPrioritizationData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref behaviourTreeState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AiPrioritization_State_byref_AiPrioritization_Data_byref_Translation_byref_BehaviourTreeState_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322332, RefRangeEnd = 1322333, XrefRangeStart = 1322332, XrefRangeEnd = 1322332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322333, RefRangeEnd = 1322334, XrefRangeStart = 1322333, XrefRangeEnd = 1322333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322334, XrefRangeEnd = 1322336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322354, RefRangeEnd = 1322355, XrefRangeStart = 1322336, XrefRangeEnd = 1322354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322357, RefRangeEnd = 1322358, XrefRangeStart = 1322355, XrefRangeEnd = 1322357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiPrioritizationSystem componentSystem,
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322358, XrefRangeEnd = 1322362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322362, XrefRangeEnd = 1322368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Prioritization()
      {
        Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>c__DisplayClass_Prioritization");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr);
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_userActivityGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (userActivityGrid));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_userList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (userList));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_highPriorityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (highPriorityCount));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (deltaTime));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (list));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (_runtimes));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AiPrioritization_State_byref_AiPrioritization_Data_byref_Translation_byref_BehaviourTreeState_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, 100663503);
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, 100663504);
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, 100663505);
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, 100663506);
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, 100663507);
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, 100663508);
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, 100663509);
        AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, 100663510);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_Prioritization.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiPrioritizationState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aiPrioritizationData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_behaviourTreeState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffableFlagState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AiPrioritization_State> forParameter_aiPrioritizationState;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<AiPrioritization_Data> forParameter_aiPrioritizationData;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<BehaviourTreeState> forParameter_behaviourTreeState;
        [FieldOffset(136)]
        public LambdaParameterValueProvider_IComponentData<BuffableFlagState> forParameter_buffableFlagState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1322232, RefRangeEnd = 1322233, XrefRangeStart = 1322216, XrefRangeEnd = 1322232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiPrioritizationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1322249, RefRangeEnd = 1322250, XrefRangeStart = 1322233, XrefRangeEnd = 1322249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiPrioritizationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiPrioritizationState));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aiPrioritizationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aiPrioritizationData));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_behaviourTreeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_behaviourTreeState));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffableFlagState));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, 100663511);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, 100663512);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiPrioritizationState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aiPrioritizationData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_behaviourTreeState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffableFlagState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AiPrioritization_State>.Runtime runtime_aiPrioritizationState;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<AiPrioritization_Data>.Runtime runtime_aiPrioritizationData;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<BehaviourTreeState>.Runtime runtime_behaviourTreeState;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<BuffableFlagState>.Runtime runtime_buffableFlagState;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiPrioritizationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiPrioritizationState));
            AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aiPrioritizationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aiPrioritizationData));
            AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_behaviourTreeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_behaviourTreeState));
            AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffableFlagState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_Prioritization/ProjectM.RunWithoutJobSystem_000000A1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, "RunWithoutJobSystem_000000A1$PostfixBurstDelegate");
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663513);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663514);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663515);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663516);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_Prioritization/ProjectM.RunWithoutJobSystem_000000A1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322250, XrefRangeEnd = 1322264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322264, XrefRangeEnd = 1322282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322282, XrefRangeEnd = 1322297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1322324, RefRangeEnd = 1322325, XrefRangeStart = 1322297, XrefRangeEnd = 1322324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization>.NativeClassPtr, "RunWithoutJobSystem_000000A1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663517);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663518);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663519);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663520);
          AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663522);
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
            IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_Prioritization.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_Sort")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Sort
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_list;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeList<AiPrioritizationSystem.Entry> list;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322443, XrefRangeEnd = 1322446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322446, RefRangeEnd = 1322447, XrefRangeStart = 1322446, XrefRangeEnd = 1322446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322447, RefRangeEnd = 1322448, XrefRangeStart = 1322447, XrefRangeEnd = 1322447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322449, RefRangeEnd = 1322450, XrefRangeStart = 1322448, XrefRangeEnd = 1322449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322451, RefRangeEnd = 1322452, XrefRangeStart = 1322450, XrefRangeEnd = 1322451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiPrioritizationSystem componentSystem,
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322452, XrefRangeEnd = 1322456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322486, RefRangeEnd = 1322487, XrefRangeStart = 1322456, XrefRangeEnd = 1322486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Sort()
      {
        Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>c__DisplayClass_Sort");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr);
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, nameof (list));
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, 100663523);
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, 100663524);
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, 100663525);
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, 100663526);
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, 100663527);
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, 100663528);
        AiPrioritizationSystem.__c__DisplayClass_Sort.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, 100663529);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_Sort.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_Sort/ProjectM.RunWithoutJobSystem_000000A9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, "RunWithoutJobSystem_000000A9$PostfixBurstDelegate");
          AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663530);
          AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663531);
          AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663532);
          AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663533);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_Sort/ProjectM.RunWithoutJobSystem_000000A9$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322368, XrefRangeEnd = 1322382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322382, XrefRangeEnd = 1322400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322400, XrefRangeEnd = 1322415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1322442, RefRangeEnd = 1322443, XrefRangeStart = 1322415, XrefRangeEnd = 1322442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort>.NativeClassPtr, "RunWithoutJobSystem_000000A9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663534);
          AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663535);
          AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663536);
          AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663537);
          AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663539);
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
            IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_Sort.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_CreateSliceAndSetUpdated")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateSliceAndSetUpdated
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_list;
      private static readonly System.IntPtr NativeFieldInfoPtr_aiUpdatesPerFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_slice;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAiPrioritizationState;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeList<AiPrioritizationSystem.Entry> list;
      [FieldOffset(16)]
      public int aiUpdatesPerFrame;
      [FieldOffset(24)]
      public NativeSlice<AiPrioritizationSystem.Entry> slice;
      [FieldOffset(40)]
      public ComponentDataFromEntity<AiPrioritization_State> getAiPrioritizationState;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322562, XrefRangeEnd = 1322585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322585, RefRangeEnd = 1322586, XrefRangeStart = 1322585, XrefRangeEnd = 1322585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322586, RefRangeEnd = 1322587, XrefRangeStart = 1322586, XrefRangeEnd = 1322586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322588, RefRangeEnd = 1322589, XrefRangeStart = 1322587, XrefRangeEnd = 1322588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322590, RefRangeEnd = 1322591, XrefRangeStart = 1322589, XrefRangeEnd = 1322590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiPrioritizationSystem componentSystem,
        ref AiPrioritizationSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322591, XrefRangeEnd = 1322595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322621, RefRangeEnd = 1322622, XrefRangeStart = 1322595, XrefRangeEnd = 1322621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateSliceAndSetUpdated()
      {
        Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>c__DisplayClass_CreateSliceAndSetUpdated");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr);
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, nameof (list));
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_aiUpdatesPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, nameof (aiUpdatesPerFrame));
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, nameof (slice));
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_getAiPrioritizationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, nameof (getAiPrioritizationState));
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, 100663540);
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, 100663541);
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, 100663542);
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, 100663543);
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, 100663544);
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, 100663545);
        AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, 100663546);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_CreateSliceAndSetUpdated/ProjectM.RunWithoutJobSystem_000000AF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, "RunWithoutJobSystem_000000AF$PostfixBurstDelegate");
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663547);
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663548);
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663549);
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100663550);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_CreateSliceAndSetUpdated/ProjectM.RunWithoutJobSystem_000000AF$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322487, XrefRangeEnd = 1322501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322501, XrefRangeEnd = 1322519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322519, XrefRangeEnd = 1322534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1322561, RefRangeEnd = 1322562, XrefRangeStart = 1322534, XrefRangeEnd = 1322561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated>.NativeClassPtr, "RunWithoutJobSystem_000000AF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663551);
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663552);
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663553);
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663554);
          AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663556);
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
            IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_CreateSliceAndSetUpdated.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_DoDebugOnlyStuff_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DoDebugOnlyStuff_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_list;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass18_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<AiPrioritizationSystem.Entry> list;
      [FieldOffset(16)]
      public AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322697, XrefRangeEnd = 1322707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AiPrioritizationSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AiPrioritizationSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322707, XrefRangeEnd = 1322709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1322712, RefRangeEnd = 1322713, XrefRangeStart = 1322709, XrefRangeEnd = 1322712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1035887, RefRangeEnd = 1035897, XrefRangeStart = 1035887, XrefRangeEnd = 1035897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AiPrioritizationSystem componentSystem,
        ref AiPrioritizationSystem.__c__DisplayClass18_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass18_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322713, XrefRangeEnd = 1322717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322717, XrefRangeEnd = 1322723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DoDebugOnlyStuff_LambdaJob0()
      {
        Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem>.NativeClassPtr, "<>c__DisplayClass_DoDebugOnlyStuff_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr);
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, nameof (list));
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, 100663557);
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, 100663558);
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, 100663559);
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, 100663560);
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, 100663561);
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_byref___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, 100663562);
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, 100663563);
        AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, 100663564);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AiPrioritizationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AiPrioritizationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663565);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663566);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_DoDebugOnlyStuff_LambdaJob0/ProjectM.RunWithoutJobSystem_000000B6$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000000B6$PostfixBurstDelegate");
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663567);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663568);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663569);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663570);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AiPrioritizationSystem/ProjectM.<>c__DisplayClass_DoDebugOnlyStuff_LambdaJob0/ProjectM.RunWithoutJobSystem_000000B6$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322622, XrefRangeEnd = 1322636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322636, XrefRangeEnd = 1322654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322654, XrefRangeEnd = 1322669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1322696, RefRangeEnd = 1322697, XrefRangeStart = 1322669, XrefRangeEnd = 1322696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000000B6$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663571);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663572);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663573);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663574);
          AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663576);
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
            IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AiPrioritizationSystem.__c__DisplayClass_DoDebugOnlyStuff_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
