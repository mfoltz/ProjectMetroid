// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityModifyRotationDuringCastSystem_Shared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class AbilityModifyRotationDuringCastSystem_Shared : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCastStartedEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityPreCastFinishedEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModifyRotations;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityPreCastEndedEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityPostCastEndedEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModifyRotationPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateModifyRotationDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateModifyRotationDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateModifyRotationDuringPostCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateModifyRotationDuringPostCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveModifyRotationDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveModifyRotationDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveModifyRotationDuringPostCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveModifyRotationDuringPostCast_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateModifyRotationDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateModifyRotationDuringPostCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveModifyRotationDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveModifyRotationDuringPostCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_4;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364208, XrefRangeEnd = 1364233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364233, XrefRangeEnd = 1364338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityModifyRotationDuringCastSystem_Shared()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364338, XrefRangeEnd = 1364498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364498, XrefRangeEnd = 1364514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateModifyRotationDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForCreateModifyRotationDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364514, XrefRangeEnd = 1364530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateModifyRotationDuringPostCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForCreateModifyRotationDuringPostCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364530, XrefRangeEnd = 1364549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364549, XrefRangeEnd = 1364565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveModifyRotationDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForRemoveModifyRotationDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364565, XrefRangeEnd = 1364581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveModifyRotationDuringPostCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForRemoveModifyRotationDuringPostCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364581, XrefRangeEnd = 1364585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364585, XrefRangeEnd = 1364589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364589, XrefRangeEnd = 1364593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364593, XrefRangeEnd = 1364597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364597, XrefRangeEnd = 1364601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityModifyRotationDuringCastSystem_Shared()
    {
      Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityModifyRotationDuringCastSystem_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr);
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityCastStartedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, nameof (_AbilityCastStartedEvents));
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPreCastFinishedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, nameof (_AbilityPreCastFinishedEvents));
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, nameof (_ModifyRotations));
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPreCastEndedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, nameof (_AbilityPreCastEndedEvents));
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPostCastEndedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, nameof (_AbilityPostCastEndedEvents));
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, nameof (_CurveCollection));
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyRotationPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, nameof (_ModifyRotationPrefab));
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>CreateModifyRotationDuringCast_entityQuery");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>CreateModifyRotationDuringCast_profilerMarker");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringPostCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>CreateModifyRotationDuringPostCast_entityQuery");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringPostCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>CreateModifyRotationDuringPostCast_profilerMarker");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>OnUpdate_LambdaJob2_entityQuery");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>RemoveModifyRotationDuringCast_entityQuery");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>RemoveModifyRotationDuringCast_profilerMarker");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringPostCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>RemoveModifyRotationDuringPostCast_entityQuery");
      AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringPostCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>RemoveModifyRotationDuringPostCast_profilerMarker");
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663635);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663636);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663637);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663638);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForCreateModifyRotationDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663639);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForCreateModifyRotationDuringPostCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663640);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663641);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForRemoveModifyRotationDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663642);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForRemoveModifyRotationDuringPostCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663643);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663644);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663645);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663646);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663647);
      AbilityModifyRotationDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, 100663648);
    }

    public AbilityModifyRotationDuringCastSystem_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _AbilityCastStartedEvents
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityCastStartedEvents));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityCastStartedEvents)) = value;
      }
    }

    public unsafe EntityQuery _AbilityPreCastFinishedEvents
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPreCastFinishedEvents));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPreCastFinishedEvents)) = value;
      }
    }

    public unsafe EntityQuery _ModifyRotations
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyRotations));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyRotations)) = value;
      }
    }

    public unsafe EntityQuery _AbilityPreCastEndedEvents
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPreCastEndedEvents));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPreCastEndedEvents)) = value;
      }
    }

    public unsafe EntityQuery _AbilityPostCastEndedEvents
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPostCastEndedEvents));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__AbilityPostCastEndedEvents)) = value;
      }
    }

    public unsafe CurveCollectionSystem _CurveCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__CurveCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _ModifyRotationPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyRotationPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr__ModifyRotationPrefab)) = value;
      }
    }

    public unsafe EntityQuery __CreateModifyRotationDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateModifyRotationDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CreateModifyRotationDuringPostCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringPostCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringPostCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateModifyRotationDuringPostCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringPostCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___CreateModifyRotationDuringPostCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RemoveModifyRotationDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveModifyRotationDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RemoveModifyRotationDuringPostCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringPostCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringPostCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveModifyRotationDuringPostCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringPostCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveModifyRotationDuringPostCast_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, nameof (entityManager));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, 100663649);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe AbilityModifyRotationDuringCastSystem_Shared __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AbilityModifyRotationDuringCastSystem_Shared) null : new AbilityModifyRotationDuringCastSystem_Shared(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/<>c__DisplayClass8_1")]
    public sealed class __c__DisplayClass8_1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_modifyRotationPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_1()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass8_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_prefabGuidFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr, nameof (prefabGuidFromEntity));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_modifyRotationPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr, nameof (modifyRotationPrefab));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr, "CS$<>8__locals1");
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr, 100663650);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr, 100663651);
      }

      public __c__DisplayClass8_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1>.NativeClassPtr, data));
      }

      public unsafe ComponentDataFromEntity<PrefabGUID> prefabGuidFromEntity
      {
        get
        {
          return *(ComponentDataFromEntity<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_prefabGuidFromEntity));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_prefabGuidFromEntity), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe Entity modifyRotationPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_modifyRotationPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_modifyRotationPrefab)) = value;
        }
      }

      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
          return new AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/<>c__DisplayClass8_2")]
    public sealed class __c__DisplayClass8_2 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_AbilityPreCastFinishedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref AbilityPreCastFinishedEvent castFinishedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castFinishedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_AbilityPreCastFinishedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_2()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass8_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_prefabGuidFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr, nameof (prefabGuidFromEntity));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr, "CS$<>8__locals2");
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr, 100663652);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_AbilityPreCastFinishedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr, 100663653);
      }

      public __c__DisplayClass8_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_2()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2>.NativeClassPtr, data));
      }

      public unsafe ComponentDataFromEntity<PrefabGUID> prefabGuidFromEntity
      {
        get
        {
          return *(ComponentDataFromEntity<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_prefabGuidFromEntity));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_prefabGuidFromEntity), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
          return new AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/<>c__DisplayClass8_3")]
    public sealed class __c__DisplayClass8_3 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_getForcedDirectionModification;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ModifyRotation_byref_EntityOwner_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_3()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        ref ModifyRotation modifyRotation,
        [In] ref EntityOwner entityOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyRotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ModifyRotation_byref_EntityOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_3()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass8_3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_curveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr, nameof (curveMap));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_getForcedDirectionModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr, nameof (getForcedDirectionModification));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr, "CS$<>8__locals3");
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr, 100663654);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ModifyRotation_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr, 100663655);
      }

      public __c__DisplayClass8_3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_3()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3>.NativeClassPtr, data));
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe CurveCollection curveMap
      {
        get
        {
          return *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_curveMap));
        }
        [param: In] set
        {
          *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_curveMap)) = value;
        }
      }

      public unsafe BufferFromEntity<Float3ModificationBuffer> getForcedDirectionModification
      {
        get
        {
          return *(BufferFromEntity<Float3ModificationBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_getForcedDirectionModification));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_getForcedDirectionModification), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<Float3ModificationBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
          return new AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/<>c__DisplayClass8_4")]
    public sealed class __c__DisplayClass8_4 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_AbilityPreCastEndedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_4()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        [In] ref AbilityPreCastEndedEvent abilityCastEnded)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityCastEnded;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_AbilityPreCastEndedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_4()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass8_4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr, "CS$<>8__locals4");
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr, 100663656);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_AbilityPreCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr, 100663657);
      }

      public __c__DisplayClass8_4(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_4()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4>.NativeClassPtr, data));
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
          return new AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/<>c__DisplayClass8_5")]
    public sealed class __c__DisplayClass8_5 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_AbilityPostCastEndedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_5()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        Entity entity,
        [In] ref AbilityPostCastEndedEvent abilityPostCastEnded)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityPostCastEnded;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_AbilityPostCastEndedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_5()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass8_5");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr, "CS$<>8__locals5");
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr, 100663658);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_AbilityPostCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr, 100663659);
      }

      public __c__DisplayClass8_5(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_5()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5>.NativeClassPtr, data));
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
          return new AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_CreateModifyRotationDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateModifyRotationDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_modifyRotationPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ModifyRotationDuringCast_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Client_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityTarget_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<PrefabGUID> prefabGuidFromEntity;
      [FieldOffset(32)]
      public EntityManager entityManager;
      [FieldOffset(40)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(56)]
      public Entity modifyRotationPrefab;
      [FieldOffset(64)]
      public ComponentDataFromEntity<AbilityBar_Shared> _ComponentDataFromEntity_AbilityBar_Shared_0;
      [FieldOffset(96)]
      public ComponentDataFromEntity<ModifyRotationDuringCast> _ComponentDataFromEntity_ModifyRotationDuringCast_1;
      [FieldOffset(128)]
      public ComponentDataFromEntity<AbilityBar_Client> _ComponentDataFromEntity_AbilityBar_Client_2;
      [FieldOffset(160)]
      public ComponentDataFromEntity<AbilityTarget> _ComponentDataFromEntity_AbilityTarget_3;
      [FieldOffset(192)]
      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(224)]
      public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363331, XrefRangeEnd = 1363383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363383, RefRangeEnd = 1363384, XrefRangeStart = 1363383, XrefRangeEnd = 1363383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363384, RefRangeEnd = 1363385, XrefRangeStart = 1363384, XrefRangeEnd = 1363384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363385, XrefRangeEnd = 1363387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363392, RefRangeEnd = 1363393, XrefRangeStart = 1363387, XrefRangeEnd = 1363392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363407, RefRangeEnd = 1363408, XrefRangeStart = 1363393, XrefRangeEnd = 1363407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityModifyRotationDuringCastSystem_Shared componentSystem,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363408, XrefRangeEnd = 1363412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363412, XrefRangeEnd = 1363418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateModifyRotationDuringCast()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_CreateModifyRotationDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_prefabGuidFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (prefabGuidFromEntity));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (entityManager));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_modifyRotationPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (modifyRotationPrefab));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityBar_Shared_0));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_ModifyRotationDuringCast_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_ModifyRotationDuringCast_1));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Client_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityBar_Client_2));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityTarget_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityTarget_3));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (_runtimes));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, 100663660);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, 100663661);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, 100663662);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, 100663663);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, 100663664);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, 100663665);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, 100663666);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, 100663667);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castStartedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent> forParameter_castStartedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363251, RefRangeEnd = 1363252, XrefRangeStart = 1363248, XrefRangeEnd = 1363251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityModifyRotationDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363255, RefRangeEnd = 1363256, XrefRangeStart = 1363252, XrefRangeEnd = 1363255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castStartedEvent));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663668);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663669);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castStartedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent>.Runtime runtime_castStartedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castStartedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_CreateModifyRotationDuringCast/ProjectM.RunWithoutJobSystem_000000DD$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, "RunWithoutJobSystem_000000DD$PostfixBurstDelegate");
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663670);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663671);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663672);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663673);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_CreateModifyRotationDuringCast/ProjectM.RunWithoutJobSystem_000000DD$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363256, XrefRangeEnd = 1363270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363270, XrefRangeEnd = 1363288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363288, XrefRangeEnd = 1363303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363330, RefRangeEnd = 1363331, XrefRangeStart = 1363303, XrefRangeEnd = 1363330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast>.NativeClassPtr, "RunWithoutJobSystem_000000DD$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663674);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663675);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663676);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663677);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663679);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_CreateModifyRotationDuringPostCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateModifyRotationDuringPostCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabGuidFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ModifyRotationDuringCast_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Client_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityTarget_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPreCastFinishedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<PrefabGUID> prefabGuidFromEntity;
      [FieldOffset(32)]
      public EntityManager entityManager;
      [FieldOffset(40)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(56)]
      public ComponentDataFromEntity<ModifyRotationDuringCast> _ComponentDataFromEntity_ModifyRotationDuringCast_0;
      [FieldOffset(88)]
      public ComponentDataFromEntity<AbilityBar_Shared> _ComponentDataFromEntity_AbilityBar_Shared_1;
      [FieldOffset(120)]
      public ComponentDataFromEntity<AbilityBar_Client> _ComponentDataFromEntity_AbilityBar_Client_2;
      [FieldOffset(152)]
      public ComponentDataFromEntity<TargetDirection> _ComponentDataFromEntity_TargetDirection_3;
      [FieldOffset(184)]
      public ComponentDataFromEntity<AbilityTarget> _ComponentDataFromEntity_AbilityTarget_4;
      [FieldOffset(216)]
      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(256)]
      public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363503, XrefRangeEnd = 1363598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref AbilityPreCastFinishedEvent castFinishedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castFinishedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPreCastFinishedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363598, RefRangeEnd = 1363599, XrefRangeStart = 1363598, XrefRangeEnd = 1363598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363599, RefRangeEnd = 1363600, XrefRangeStart = 1363599, XrefRangeEnd = 1363599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363600, XrefRangeEnd = 1363602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363608, RefRangeEnd = 1363609, XrefRangeStart = 1363602, XrefRangeEnd = 1363608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363626, RefRangeEnd = 1363627, XrefRangeStart = 1363609, XrefRangeEnd = 1363626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityModifyRotationDuringCastSystem_Shared componentSystem,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363627, XrefRangeEnd = 1363631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363631, XrefRangeEnd = 1363637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateModifyRotationDuringPostCast()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_CreateModifyRotationDuringPostCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_prefabGuidFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (prefabGuidFromEntity));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (entityManager));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr__ComponentDataFromEntity_ModifyRotationDuringCast_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_ModifyRotationDuringCast_0));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Shared_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityBar_Shared_1));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Client_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityBar_Client_2));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_TargetDirection_3));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityTarget_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityTarget_4));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (_runtimes));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPreCastFinishedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, 100663680);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, 100663681);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, 100663682);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, 100663683);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, 100663684);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, 100663685);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, 100663686);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, 100663687);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castFinishedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AbilityPreCastFinishedEvent> forParameter_castFinishedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363422, RefRangeEnd = 1363423, XrefRangeStart = 1363418, XrefRangeEnd = 1363422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityModifyRotationDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363427, RefRangeEnd = 1363428, XrefRangeStart = 1363423, XrefRangeEnd = 1363427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castFinishedEvent));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, 100663688);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, 100663689);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castFinishedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AbilityPreCastFinishedEvent>.Runtime runtime_castFinishedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castFinishedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_CreateModifyRotationDuringPostCast/ProjectM.RunWithoutJobSystem_000000E6$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, "RunWithoutJobSystem_000000E6$PostfixBurstDelegate");
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663690);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663691);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663692);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663693);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_CreateModifyRotationDuringPostCast/ProjectM.RunWithoutJobSystem_000000E6$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363428, XrefRangeEnd = 1363442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363442, XrefRangeEnd = 1363460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363460, XrefRangeEnd = 1363475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363502, RefRangeEnd = 1363503, XrefRangeStart = 1363475, XrefRangeEnd = 1363502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast>.NativeClassPtr, "RunWithoutJobSystem_000000E6$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663694);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663695);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663696);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663697);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663699);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_CreateModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_getForcedDirectionModification;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Buff_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AiMove_Shared_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_LifeTime_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Age_6;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_7;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityTarget_8;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SpellTarget_9;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_10;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_11;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyRotation_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public CurveCollection curveMap;
      [FieldOffset(32)]
      public BufferFromEntity<Float3ModificationBuffer> getForcedDirectionModification;
      [FieldOffset(72)]
      public ComponentDataFromEntity<Buff> _ComponentDataFromEntity_Buff_0;
      [FieldOffset(104)]
      public ComponentDataFromEntity<EntityInput> _ComponentDataFromEntity_EntityInput_1;
      [FieldOffset(136)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_2;
      [FieldOffset(168)]
      public ComponentDataFromEntity<TargetDirection> _ComponentDataFromEntity_TargetDirection_3;
      [FieldOffset(200)]
      public ComponentDataFromEntity<AiMove_Shared> _ComponentDataFromEntity_AiMove_Shared_4;
      [FieldOffset(232)]
      public ComponentDataFromEntity<LifeTime> _ComponentDataFromEntity_LifeTime_5;
      [FieldOffset(264)]
      public ComponentDataFromEntity<Age> _ComponentDataFromEntity_Age_6;
      [FieldOffset(296)]
      public ComponentDataFromEntity<Disabled> _ComponentDataFromEntity_Disabled_7;
      [FieldOffset(328)]
      public ComponentDataFromEntity<AbilityTarget> _ComponentDataFromEntity_AbilityTarget_8;
      [FieldOffset(360)]
      public ComponentDataFromEntity<SpellTarget> _ComponentDataFromEntity_SpellTarget_9;
      [FieldOffset(392)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_10;
      [FieldOffset(424)]
      public ComponentDataFromEntity<EntityOwner> _ComponentDataFromEntity_EntityOwner_11;
      [FieldOffset(456)]
      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(528)]
      public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363728, XrefRangeEnd = 1363892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref ModifyRotation modifyRotation,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyRotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyRotation_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363892, RefRangeEnd = 1363893, XrefRangeStart = 1363892, XrefRangeEnd = 1363892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363893, RefRangeEnd = 1363894, XrefRangeStart = 1363893, XrefRangeEnd = 1363893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363894, XrefRangeEnd = 1363896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363905, RefRangeEnd = 1363906, XrefRangeStart = 1363896, XrefRangeEnd = 1363905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1363944, RefRangeEnd = 1363945, XrefRangeStart = 1363906, XrefRangeEnd = 1363944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityModifyRotationDuringCastSystem_Shared componentSystem,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_3 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363945, XrefRangeEnd = 1363949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363949, XrefRangeEnd = 1363955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_curveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (curveMap));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_getForcedDirectionModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (getForcedDirectionModification));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_Buff_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_Buff_0));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_EntityInput_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityInput_1));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_2));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_TargetDirection_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_TargetDirection_3));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_AiMove_Shared_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_AiMove_Shared_4));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_LifeTime_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_LifeTime_5));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_Age_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_Age_6));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_Disabled_7));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityTarget_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityTarget_8));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_SpellTarget_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_SpellTarget_9));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_10));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityOwner_11));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ModifyRotation_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663700);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663701);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663702);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663703);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663704);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663705);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663706);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100663707);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifyRotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ModifyRotation> forParameter_modifyRotation;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363644, RefRangeEnd = 1363645, XrefRangeStart = 1363637, XrefRangeEnd = 1363644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityModifyRotationDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363652, RefRangeEnd = 1363653, XrefRangeStart = 1363645, XrefRangeEnd = 1363652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifyRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifyRotation));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100663708);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100663709);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifyRotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ModifyRotation>.Runtime runtime_modifyRotation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifyRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifyRotation));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_000000EF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_000000EF$PostfixBurstDelegate");
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663710);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663711);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663712);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663713);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_000000EF$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363653, XrefRangeEnd = 1363667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363667, XrefRangeEnd = 1363685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363685, XrefRangeEnd = 1363700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363727, RefRangeEnd = 1363728, XrefRangeStart = 1363700, XrefRangeEnd = 1363727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_000000EF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663714);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663715);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663716);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663717);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663719);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveModifyRotationDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RemoveModifyRotationDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ModifyRotationDuringCast_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPreCastEndedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(24)]
      public ComponentDataFromEntity<ModifyRotationDuringCast> _ComponentDataFromEntity_ModifyRotationDuringCast_0;
      [FieldOffset(56)]
      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364040, XrefRangeEnd = 1364054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref AbilityPreCastEndedEvent abilityCastEnded)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityCastEnded;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPreCastEndedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1364054, RefRangeEnd = 1364056, XrefRangeStart = 1364054, XrefRangeEnd = 1364054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1364056, RefRangeEnd = 1364059, XrefRangeStart = 1364056, XrefRangeEnd = 1364056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364059, XrefRangeEnd = 1364061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1364067, RefRangeEnd = 1364068, XrefRangeStart = 1364061, XrefRangeEnd = 1364067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1364073, RefRangeEnd = 1364074, XrefRangeStart = 1364068, XrefRangeEnd = 1364073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityModifyRotationDuringCastSystem_Shared componentSystem,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_4 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364074, XrefRangeEnd = 1364078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364078, XrefRangeEnd = 1364084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveModifyRotationDuringCast()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_RemoveModifyRotationDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, nameof (entityManager));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_ModifyRotationDuringCast_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_ModifyRotationDuringCast_0));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, nameof (_runtimes));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPreCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, 100663720);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, 100663721);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, 100663722);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, 100663723);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, 100663724);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, 100663725);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, 100663726);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, 100663727);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abilityCastEnded;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AbilityPreCastEndedEvent> forParameter_abilityCastEnded;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363959, RefRangeEnd = 1363960, XrefRangeStart = 1363955, XrefRangeEnd = 1363959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityModifyRotationDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1363964, RefRangeEnd = 1363965, XrefRangeStart = 1363960, XrefRangeEnd = 1363964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abilityCastEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abilityCastEnded));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663728);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663729);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abilityCastEnded;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AbilityPreCastEndedEvent>.Runtime runtime_abilityCastEnded;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abilityCastEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abilityCastEnded));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveModifyRotationDuringCast/ProjectM.RunWithoutJobSystem_000000F8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, "RunWithoutJobSystem_000000F8$PostfixBurstDelegate");
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663730);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663731);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663732);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663733);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveModifyRotationDuringCast/ProjectM.RunWithoutJobSystem_000000F8$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363965, XrefRangeEnd = 1363979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363979, XrefRangeEnd = 1363997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363997, XrefRangeEnd = 1364012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364039, RefRangeEnd = 1364040, XrefRangeStart = 1364012, XrefRangeEnd = 1364039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast>.NativeClassPtr, "RunWithoutJobSystem_000000F8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663734);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663735);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663736);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663737);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663739);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveModifyRotationDuringPostCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RemoveModifyRotationDuringPostCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ModifyRotationDuringCast_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPostCastEndedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_5_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_5_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_5_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(24)]
      public ComponentDataFromEntity<ModifyRotationDuringCast> _ComponentDataFromEntity_ModifyRotationDuringCast_0;
      [FieldOffset(56)]
      public AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364169, XrefRangeEnd = 1364183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref AbilityPostCastEndedEvent abilityPostCastEnded)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityPostCastEnded;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPostCastEndedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1364054, RefRangeEnd = 1364056, XrefRangeStart = 1364054, XrefRangeEnd = 1364056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_5_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1364056, RefRangeEnd = 1364059, XrefRangeStart = 1364056, XrefRangeEnd = 1364059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_5_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364183, XrefRangeEnd = 1364185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1364191, RefRangeEnd = 1364192, XrefRangeStart = 1364185, XrefRangeEnd = 1364191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1364197, RefRangeEnd = 1364198, XrefRangeStart = 1364192, XrefRangeEnd = 1364197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityModifyRotationDuringCastSystem_Shared componentSystem,
        ref AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass8_5 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_5_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364198, XrefRangeEnd = 1364202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364202, XrefRangeEnd = 1364208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveModifyRotationDuringPostCast()
      {
        Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_RemoveModifyRotationDuringPostCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, nameof (entityManager));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, nameof (commandBuffer));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr__ComponentDataFromEntity_ModifyRotationDuringCast_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_ModifyRotationDuringCast_0));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, nameof (_runtimes));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbilityPostCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, 100663740);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, 100663741);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, 100663742);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, 100663743);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, 100663744);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_byref___c__DisplayClass8_5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, 100663745);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, 100663746);
        AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, 100663747);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abilityPostCastEnded;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AbilityPostCastEndedEvent> forParameter_abilityPostCastEnded;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364088, RefRangeEnd = 1364089, XrefRangeStart = 1364084, XrefRangeEnd = 1364088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityModifyRotationDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364093, RefRangeEnd = 1364094, XrefRangeStart = 1364089, XrefRangeEnd = 1364093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abilityPostCastEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abilityPostCastEnded));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityModifyRotationDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, 100663748);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, 100663749);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abilityPostCastEnded;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AbilityPostCastEndedEvent>.Runtime runtime_abilityPostCastEnded;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abilityPostCastEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abilityPostCastEnded));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveModifyRotationDuringPostCast/ProjectM.RunWithoutJobSystem_00000101$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, "RunWithoutJobSystem_00000101$PostfixBurstDelegate");
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663750);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663751);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663752);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663753);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityModifyRotationDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveModifyRotationDuringPostCast/ProjectM.RunWithoutJobSystem_00000101$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364094, XrefRangeEnd = 1364108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364108, XrefRangeEnd = 1364126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364126, XrefRangeEnd = 1364141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364168, RefRangeEnd = 1364169, XrefRangeStart = 1364141, XrefRangeEnd = 1364168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast>.NativeClassPtr, "RunWithoutJobSystem_00000101$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663754);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663755);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663756);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663757);
          AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663759);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityModifyRotationDuringCastSystem_Shared.__c__DisplayClass_RemoveModifyRotationDuringPostCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
